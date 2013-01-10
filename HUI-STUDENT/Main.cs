using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using mshtml;
using System.IO;
using System.Runtime.InteropServices;

namespace HUI_STUDENT
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (wb.DocumentText.IndexOf("Ket qua hoc tap") != -1)
            {
                IHTMLDocument2 doc = (IHTMLDocument2)wb.Document.DomDocument;
                IHTMLControlRange imgRange = (IHTMLControlRange)((HTMLBody)doc.body).createControlRange();
                string name = "";
                Random random = new Random();
                pictureBox1.Image = null;
                foreach (IHTMLImgElement img in doc.images)
                {
                    imgRange.add((IHTMLControlElement)img);
                    imgRange.execCommand("Copy", false, null);
                    if (img.nameProp == "ConfirmImage.aspx")
                    {
                        using (Bitmap bmp = (Bitmap)Clipboard.GetDataObject().GetData(DataFormats.Bitmap))
                        {
                            name = random.Next(10000) + "";
                            bmp.Save(Path.GetTempPath() + "\\" + name);
                            break;
                        }
                    }
                }
                pictureBox1.Image = Image.FromFile(Path.GetTempPath() + "\\" + name);
                if (btnTichLuy.Text == "Đợi chút...")
                {
                    btnTichLuy.Text = "Tích lũy";
                    btnTichLuy.Enabled = true;
                }
                if (btnTichLuy.Text == "Tích lũy" && btnTichLuy.Enabled == false)
                {
                    if (wb.DocumentText.IndexOf("Không tìm thấy thông tin sinh viên") > -1)
                    {
                        btnTichLuy.Text = "Tích lũy";
                        MessageBox.Show("Không tìm thấy thông tin sinh viên", "Thông báo");
                    }
                    else
                    {
                        if (wb.DocumentText.IndexOf("Mã bảo vệ không đúng") > -1)
                        {
                            btnTichLuy.Text = "Tích lũy";
                        }
                        else
                        {
                            TLcore TichLuy = new TLcore(wb.DocumentText);
                            LoadMonHoc(TichLuy.DanhSachMon());
                            //StreamWriter wr = new StreamWriter("test.html");
                            //wr.Write(TichLuy.DanhSachMon());
                            //wr.Close();
                            MessageBox.Show("Hãy chọn bỏ môn nào nếu bạn không muốn tính\nhoặc có nhu cầu cải thiện điểm rồi nhấn tiếp tục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnTichLuy.Text = "Tiếp tục";
                            btnTinhLai.Visible = false;
                        }
                    }
                    btnTichLuy.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Kết nối tới csdl nhà trường có vấn đề hoặc đã bị thay đổi,\nhãy thử lại chương trình hoặc cập nhật phiên bản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTichLuy_Click(object sender, EventArgs e)
        {
            bool checkms = false;
            int ms=0;
            checkms = int.TryParse(txtMaSV.Text, out ms);
            if (checkms == true && txtMaXN.Text.Trim() != "")
            {
                if (btnTichLuy.Text == "Tích lũy")
                {
                    txtMaSV.Enabled = false;
                    txtMaXN.Enabled = false;
                    btnTichLuy.Enabled = false;
                    pbSinhVien.Image = null;
                    wb.Document.GetElementById("txtMaSV").InnerText = txtMaSV.Text;
                    wb.Document.GetElementById("txtMaXacNhan").InnerText = txtMaXN.Text.ToUpper();
                    HtmlElementCollection links = wb.Document.GetElementsByTagName("A");
                    foreach (HtmlElement link in links)
                    {
                        if (link.InnerText.Equals("Xem điểm"))
                            link.InvokeMember("Click");
                    }
                }
                else
                {
                    TLcore TichLuy = new TLcore(wb.DocumentText);
                    string[] KQ;
                    string[] ThongTin = { "Tổng môn tính", "Tổng tín chỉ tính", "Tỷ lệ Giỏi", "Tỷ lệ Khá", "Tỷ lệ TB", "Tỷ lệ TBY", "Tích lũy hệ 10", "Tích lũy hệ 4", "Kết quả" };
                    KQ = TichLuy.XemDiem(DSMonBo());
                    lvThongTin.Items.Clear();
                    for (int i = 0; i < KQ.Length; i++)
                    {
                        lvThongTin.Items.AddRange(new ListViewItem[] { new ListViewItem(new string[] { ThongTin[i], KQ[i] }) });
                    }

                    //Lấy ảnh sinh viên
                    IHTMLDocument2 doc = (IHTMLDocument2)wb.Document.DomDocument;
                    IHTMLControlRange imgRange = (IHTMLControlRange)((HTMLBody)doc.body).createControlRange();
                    string name = "AnhSV.aspx?MaSV=" + txtMaSV.Text;
                    foreach (IHTMLImgElement img in doc.images)
                    {
                        if (img.nameProp == name)
                        {
                            imgRange.add((IHTMLControlElement)img);
                            imgRange.execCommand("Copy", false, null);
                            using (Bitmap bmp = (Bitmap)Clipboard.GetDataObject().GetData(DataFormats.Bitmap))
                            {
                                bmp.Save(Path.GetTempPath() + "\\" + txtMaSV.Text);
                                break;
                            }
                        }
                    }
                    //Hết lấy ảnh sinh viên
                    pbSinhVien.Image = Image.FromFile(Path.GetTempPath() + "\\" + txtMaSV.Text);
                    btnTichLuy.Text = "Tích lũy";
                    btnTinhLai.Visible = true;
                    txtMaSV.Enabled = true;
                    txtMaXN.Enabled = true;
                }
            }
            else
                MessageBox.Show("Thông tin nhập không hợp lệ!\nĐề nghị bạn nhập lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void LoadMonHoc(string DSMonHoc)
        {
            string[] HocPhan = DSMonHoc.Split('\n');
            lvMonHoc.Items.Clear();
            lvMonBo.Items.Clear();
            foreach (string mon in HocPhan)
            {
                ListViewItem item = new ListViewItem();
                item.Text = mon.Split('|')[1];
                item.SubItems.Add(mon.Split('|')[0]);
                item.SubItems.Add(mon.Split('|')[2]);
                item.SubItems.Add(mon.Split('|')[mon.Split('|').Length-2]);
                lvMonHoc.Items.Add(item);
            }
        }

        private void bỏQuaMônNàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item = lvMonHoc.SelectedItems[0];
            lvMonHoc.Items.Remove(item);
            lvMonBo.Items.Add(item);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item = lvMonBo.SelectedItems[0];
            lvMonBo.Items.Remove(item);
            lvMonHoc.Items.Add(item);
        }
        private string[] DSMonBo()
        {
            string Monbo = "";
            if (lvMonBo.Items.Count > 0)
            {
                foreach (ListViewItem Item in lvMonBo.Items)
                {
                    Monbo += Item.SubItems[1].Text + "|";
                }
                Monbo = Monbo.Substring(0, Monbo.Length - 1);
            }
            return Monbo.Split('|');
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (!InternetConnection.IsConnectedToInternet())
            {
                MessageBox.Show("Hãy kiểm tra lại kết nối mạng!\nKhi kết nối ổn định chạy lại chương trình","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnTinhLai_Click(object sender, EventArgs e)
        {
            TLcore TichLuy = new TLcore(wb.DocumentText);
            string[] KQ;
            string[] ThongTin = { "Tổng môn tính", "Tổng tín chỉ tính", "Tỷ lệ Giỏi", "Tỷ lệ Khá", "Tỷ lệ TB", "Tỷ lệ TBY", "Tích lũy hệ 10", "Tích lũy hệ 4", "Kết quả" };
            KQ = TichLuy.XemDiem(DSMonBo());
            lvThongTin.Items.Clear();
            for (int i = 0; i < KQ.Length; i++)
            {
                lvThongTin.Items.AddRange(new ListViewItem[] { new ListViewItem(new string[] { ThongTin[i], KQ[i] }) });
            }
        }
    }
    class InternetConnection
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int description, int reservedValue);
        public static bool IsConnectedToInternet()
        {
            int desc;
            return InternetGetConnectedState(out desc, 0);
        }
    }
}
