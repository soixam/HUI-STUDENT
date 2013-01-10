using System;
using System.Collections.Generic;
using System.Text;
using HtmlAgilityPack;
using System.Text.RegularExpressions;

namespace HUI_STUDENT
{
    public class StringProcessing
    {
        public string LayChuoiOGiua1(string ChuoiGoc, string dau, string cuoi)
        {
            string chuoi = "";
            int vt1 = ChuoiGoc.IndexOf(dau);
            chuoi = ChuoiGoc.Remove(0, vt1 + dau.Length);
            int vt2 = chuoi.IndexOf(cuoi);
            chuoi = chuoi.Substring(0, vt2);
            return chuoi;
        }
        public string LayChuoiOGiua2(string ChuoiGoc, string dau, string cuoi)
        {
            string chuoi = "";
            int vt1 = ChuoiGoc.IndexOf(dau);
            ChuoiGoc = ChuoiGoc.Remove(0, vt1 - 1);
            int vt2 = ChuoiGoc.IndexOf(cuoi);
            chuoi = ChuoiGoc.Substring(0, vt2 + cuoi.Length);
            return chuoi;
        }
        public string getPointTable(string html)
        {
            string BangDiem = LayChuoiOGiua1(html, "divKetQua\">", "</table>");
            return BangDiem;
        }
        public string getStudentInf(string html)
        {
            string StudentInfor = LayChuoiOGiua1(html, "TẬP</h1>", "<br />");
            StudentInfor = StudentInfor.Replace("AnhSV.aspx", "http://iuh.edu.vn/ketquahoctap/AnhSV.aspx");
            return StudentInfor;
        }

        //public string getListSubjects(string HTML)
        //{
        //    int Colum = 0;
        //    if (HTML.IndexOf("Trung cấp") > -1 || HTML.IndexOf("Trung học") > -1 || HTML.IndexOf("Cao đẳng Nghề") > -1)
        //        Colum = 12;
        //    else
        //        Colum = 17;
        //    string BangDiem = getPointTable(HTML);
        //    BangDiem = BangDiem.Replace("\t", "");//Loai bo ky tu Tab
        //    BangDiem = BangDiem.Replace("\r", "");//Loai bo ky tu xuong dong
        //    BangDiem = BangDiem.Replace("\n", "");//Loai bo ky tu xuong dong
        //    BangDiem = BangDiem.Replace("  ", "");//Loai bo ky tu xuong dong
        //    BangDiem = BangDiem.Replace("<span style=\"color:red;font-weight:bold;\">", "");
        //    BangDiem = BangDiem.Replace("</span>", "");
        //    if (BangDiem.IndexOf("colspan=\"4\"") != -1)
        //        BangDiem = BangDiem.Replace("colspan=\"4\"", "width=\"35px\">&nbsp;</td><td width=\"35px\">&nbsp;</td><td width=\"35px\"");
        //    if (BangDiem.IndexOf("colspan=\"8\"") != -1)
        //        BangDiem = BangDiem.Replace("colspan=\"8\"", "width=\"35px\">&nbsp;</td><td width=\"35px\">&nbsp;</td><td width=\"35px\">&nbsp;</td><td width=\"35px\">&nbsp;</td><td width=\"35px\">&nbsp;</td><td width=\"35px\">&nbsp;</td><td width=\"35px\"");
        //    if (BangDiem.IndexOf("colspan=\"3\"") != -1)
        //        BangDiem = BangDiem.Replace("colspan=\"3\"", "width=\"35px\">&nbsp;</td><td width=\"35px\"");
        //    string ListSub = "";
        //    HtmlDocument htmlDoc = new HtmlDocument();
        //    htmlDoc.LoadHtml(BangDiem);
        //    if (htmlDoc.DocumentNode != null)
        //    {
        //        foreach (HtmlNode text in htmlDoc.DocumentNode.SelectNodes("//table/tr/td/text()"))
        //        {
        //            ListSub += text.InnerText + "|";
        //        }
        //    }
        //    ListSub = ListSub.Remove(0, ListSub.IndexOf("|1|") + 1);
        //    BangDiem = "";
        //    string SubInfo = "";
        //    for (int i = 0; i < ListSub.Split('|').Length - 1; i++)
        //    {
        //        SubInfo = ListSub.Split('|')[i].ToString();
        //        if (i % Colum == 0 && i != 0)
        //        {
        //            if (SubInfo.IndexOf("Học kỳ") > -1)
        //            {
        //                BangDiem += "\n";
        //                ListSub = ListSub.Replace(SubInfo + "|" + ListSub.Split('|')[i + 1].ToString(), "");
        //                //i--;
        //            }
        //            else
        //                BangDiem += "\n";
        //        }
        //        else
        //        {
        //            BangDiem += SubInfo + '|';
        //        }
        //    }
        //    BangDiem = BangDiem.Remove(0, 2);
        //    return BangDiem;
        //}
        public string getListSubjects(string HTML)
        {
            string BangDiem = getPointTable(HTML);
            BangDiem = BangDiem.Replace("</span>", "");
            BangDiem = BangDiem.Replace("<b>", "");
            BangDiem = BangDiem.Replace("</b>", "");
            BangDiem = Regex.Replace(BangDiem, "<span.*?>", "");
            if (BangDiem.IndexOf("colspan=\"4\"") != -1)
                BangDiem = BangDiem.Replace("colspan=\"4\"", "width=\"35px\">&nbsp;</td><td width=\"35px\">&nbsp;</td><td width=\"35px\"");
            if (BangDiem.IndexOf("colspan=\"8\"") != -1)
                BangDiem = BangDiem.Replace("colspan=\"8\"", "width=\"35px\">&nbsp;</td><td width=\"35px\">&nbsp;</td><td width=\"35px\">&nbsp;</td><td width=\"35px\">&nbsp;</td><td width=\"35px\">&nbsp;</td><td width=\"35px\">&nbsp;</td><td width=\"35px\"");
            if (BangDiem.IndexOf("colspan=\"3\"") != -1)
                BangDiem = BangDiem.Replace("colspan=\"3\"", "width=\"35px\">&nbsp;</td><td width=\"35px\"");
            int Colum = 0;
            if (HTML.IndexOf("Cao đẳng Nghề") > -1)
                Colum = 12;
            else
            {
                if (HTML.IndexOf("Trung học") > -1 || HTML.IndexOf("Trung cấp") > -1)
                {
                    Colum = 13;
                }
                else
                    Colum = 17;
            }
            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(BangDiem);
            string ListSub = "";
            if (htmlDoc.DocumentNode != null)
            {
                foreach (HtmlNode text in htmlDoc.DocumentNode.SelectNodes("//table/tr/td/text()"))
                {
                    ListSub += text.InnerText + "|";
                }
            }
            ListSub = ListSub.Replace("\t", "");//Loai bo ky tu Tab
            ListSub = ListSub.Replace("\r", "");//Loai bo ky tu xuong dong
            ListSub = ListSub.Replace("\n", "");//Loai bo ky tu xuong dong
            ListSub = ListSub.Replace("  ", "");//Loai bo ky tu xuong dong
            ListSub = ListSub.Remove(0, ListSub.IndexOf("|1|") + 1);
            BangDiem = "";
            string SubInfo = "";
            for (int i = 0; i < ListSub.Split('|').Length - 1; i++)
            {
                SubInfo = ListSub.Split('|')[i].ToString();
                if (i % Colum == 0 && i != 0)
                {
                    if (SubInfo.IndexOf("Học kỳ") > -1 || SubInfo.IndexOf("Điểm chứng chỉ") > -1)
                    {
                        BangDiem += "\n";
                        ListSub = ListSub.Replace(SubInfo + "|" + ListSub.Split('|')[i + 1].ToString(), "");
                        //i--;
                    }
                    else
                        BangDiem += "\n";
                }
                else
                {
                    BangDiem += SubInfo + '|';
                }
            }
            BangDiem = BangDiem.Remove(0, 2);
            return BangDiem;
        }
    }
}
