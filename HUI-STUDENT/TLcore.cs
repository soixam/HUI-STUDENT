using System;
using System.Collections.Generic;
using System.Text;

namespace HUI_STUDENT
{
    public class TLcore:StringProcessing
    {
        string HTML = "";
        public TLcore(string MaNguon)
        {
            HTML = MaNguon;
        }
        int KieuHe = 0;
        int SoMonGioi = 0, SoMonKha = 0, SoMonTB = 0, SoMonTBY = 0;
        int TCGioi = 0, TCKha = 0, TCTB = 0, TCTBY = 0, TLMon = 0;
        int TongMonDaHoc = 0;
        float DiemHe10 = 0;
        private bool KiemTraMonBo(string MaHP, string[] MonBo)
        {
            if (MonBo.Length > 0)
                foreach (string item in MonBo)
                {
                    if (MaHP == item)
                        return false;
                }
            return true;
        }
        public string LayBangDiem()
        {
            return getPointTable(HTML);
        }
        public string LayThongTin()
        {
            return getStudentInf(HTML);
        }
        public string DanhSachMon()
        {
            return getListSubjects(HTML);
        }
        private void XepLoaiDiem(int DiemSo, float Diem10, int TC)
        {
            switch (DiemSo)
            {
                case 4:
                    SoMonGioi++;
                    TCGioi += TC;
                    break;
                case 3:
                    SoMonKha++;
                    TCKha += TC;
                    break;
                case 2:
                    SoMonTB++;
                    TCTB += TC;
                    break;
                case 1:
                    SoMonTBY++;
                    TCTBY += TC;
                    break;
                default:
                    break;
            }
            if (DiemSo != 0)
            {
                TongMonDaHoc++;
                TLMon += DiemSo * TC;
                DiemHe10 += Diem10 * TC;
            }
        }
        private string XepLoai(float DiemTC)
        {
            if (DiemTC >= 3.6)
                return "Xuất sắc";
            else
            {
                if (DiemTC >= 3.2)
                    return "Giỏi";
                else
                {
                    if (DiemTC >= 2.5)
                        return "Khá";
                    else
                    {
                        if (DiemTC >= 2)
                            return "Trung Bình";
                    }
                }
            }
            return "Muốn ra trường thì cải thiện đi";
        }
        private string XemDiemTichLuyCaNhan(string[] MonBo)
        {
            int DiemMon, TCMon, TongTC = 0;
            string BangDiem = DanhSachMon();
            string[] DSMon = BangDiem.Split('\n');
            for (int i = 0; i < DSMon.Length; i++)
            {
                string MonHoc = DSMon[i];
                string[] MonHocInfo = MonHoc.Split('|');
                if (KiemTraMonBo(MonHocInfo[0], MonBo))
                {
                    if (MonHocInfo[15].Length > 8)
                    {
                        bool CheckTKMon = int.TryParse(MonHocInfo[15].Substring(3, 1), out DiemMon);
                        if (CheckTKMon)
                        {
                            TCMon = int.Parse(MonHocInfo[2]);
                            float Diem10 = 0, Diem101, Diem102;
                            bool d101 = float.TryParse(MonHocInfo[14].ToString(), out Diem101);
                            bool d102 = float.TryParse(MonHocInfo[13].ToString(), out Diem102);
                            if (Diem101 > Diem102)
                                Diem10 = Diem101;
                            else
                                Diem10 = Diem102;
                            XepLoaiDiem(DiemMon, Diem10, TCMon);
                        }
                    }
                }
            }
            TongTC = TCGioi + TCKha + TCTB + TCTBY;
            float DiemTL = (float)TLMon / TongTC;
            float DiemHe10Chuan = DiemHe10 / TongTC;
            DiemHe10Chuan = (DiemHe10Chuan > 10) ? (DiemHe10Chuan / 10) : DiemHe10Chuan;
            string trave = TongMonDaHoc + "|" + TongTC + "|" + SoMonGioi + "/" + TCGioi + "|" + SoMonKha + "/" + TCKha + "|" + SoMonTB + "/" + TCTB + "|" + SoMonTBY + "/" + TCTBY + "|" + DiemHe10Chuan + "|" + DiemTL + "|" + XepLoai(DiemTL);
            return trave;
        }
        private string XemDiemNienCheCaNhan(string[] MonBo)
        {
            float DiemMon = 0, TCMon = 0, TongDiem = 0, TongTC = 0;
            int TongMonDaHoc = 0;
            string[] DSMon = DanhSachMon().Split('\n');
            for (int i = 0; i < DSMon.Length; i++)
            {
                string MonHoc = DSMon[i];
                string[] MonHocInfo = MonHoc.Split('|');
                if (KiemTraMonBo(MonHocInfo[0], MonBo))
                {
                    if (KieuHe == 1)
                    {
                        if (MonHocInfo[9].Length > 2)
                        {
                            bool CheckDiem = float.TryParse(MonHocInfo[9], out DiemMon);
                            if (CheckDiem)
                                if (DiemMon >= 5)
                                {
                                    TCMon = float.Parse(MonHocInfo[1]);
                                    if (TCMon > 10)
                                        TCMon = TCMon / 15;
                                    TongDiem += (DiemMon * TCMon);
                                    TongTC += TCMon;
                                    TongMonDaHoc++;
                                }
                        }
                    }
                    else
                    {
                        if (MonHocInfo[10].Length > 2)
                        {
                            bool CheckDiem = float.TryParse(MonHocInfo[10], out DiemMon);
                            if (CheckDiem)
                                if (DiemMon >= 5)
                                {
                                    TCMon = float.Parse(MonHocInfo[1]);
                                    if (TCMon > 10)
                                        TCMon = TCMon / 15;
                                    TongDiem += (DiemMon * TCMon);
                                    TongTC += TCMon;
                                    TongMonDaHoc++;
                                }
                        }
                    }

                }
            }
            float DiemNienChe = TongDiem / TongTC;
            DiemNienChe = (DiemNienChe > 10) ? (DiemNienChe / 10) : DiemNienChe;
            string XepLoai = DiemNienChe + "||" + XepLoaiNienChe(DiemNienChe);
            string trave = TongMonDaHoc + "|" + TongTC + "|||||" + XepLoai;
            return trave;
        }
        private string XepLoaiNienChe(float Diem)
        {
            if (Diem >= 9)
                return "Xuất sắc";
            else
            {
                if (Diem >= 8)
                    return "Giỏi";
                else
                {
                    if (Diem >= 7)
                        return "Khá";
                    else
                    {
                        if (Diem >= 6)
                            return "Trung Bình Khá";
                        else
                        {
                            if (Diem >= 5)
                            {
                                return "Trung Bình";
                            }
                        }
                    }
                }
            }
            return "Không Đạt";
        }
        public string[] XemDiem(string[] MonBo)
        {
            string KetQuaTraVe = "";
            if (HTML.IndexOf("Cao đẳng Nghề") > -1)
            {
                KieuHe = 1;
                KetQuaTraVe=XemDiemNienCheCaNhan(MonBo);
            }
            else
            {
                if (HTML.IndexOf("Trung học") > -1 || HTML.IndexOf("Trung cấp") > -1)
                {
                    KieuHe = 2;
                    KetQuaTraVe=XemDiemNienCheCaNhan(MonBo);
                }
                else
                    KetQuaTraVe=XemDiemTichLuyCaNhan(MonBo);
            }
            return KetQuaTraVe.Split('|');
        }
    }
}
