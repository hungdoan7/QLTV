using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
  public  class ThuVien
    {

        public List<KhoaHoc> dsKH ;
        public List<LichSu> dsLS;
        public List<GiaoTrinh> dsGT;
        public List<DocGia> dsDG;
        public List<MuonSach> dsMuon;
        
        public ThuVien()
        {
            this.dsKH = new List<KhoaHoc>();
            this. dsLS = new List<LichSu>();
            this.dsGT = new List<GiaoTrinh>();
            this.dsDG = new List<DocGia>();
            this.dsMuon = new List<MuonSach>();
        }
        public void NhapThuVien()
        {
            KhoaHoc s1 = new KhoaHoc("KH01", "A1", "DHQG", "TG1", 18888, 30, "Toan");
            dsKH.Add(s1);
             s1 = new KhoaHoc("KH02", "A2", "DHQG", "TG2", 18888, 30, "Vat Ly");
            dsKH.Add(s1);
            s1 = new KhoaHoc("KH03", "A3", "DHQG", "TG3", 18888, 30, "CTDL");
            dsKH.Add(s1);
            LichSu s2 = new LichSu("LS01", "B1", "DHQG", "TG4", 20000, 30, "Viet nam");
            dsLS.Add(s2);
            s2 = new LichSu("LS02", "B2", "DHQg", "Tg4", 30000, 20, "Thai lan");
            dsLS.Add(s2);
            GiaoTrinh s3 = new GiaoTrinh("GT01", "C1", "SPKT", "TG4", 20000, 30, "Vat Ly");
            dsGT.Add(s3);
            DocGia s4 = new DocGia("DG1", "Truc", "TuDu", "0199", "3/5", "hgakhas", 5, 9, 2001,330000);
            dsDG.Add(s4);
            s4 = new DocGia("DG2", "Hung", "TuDu1", "01994", "3/7", "hdfgakhas", 6, 7, 2007, 100000);
            dsDG.Add(s4);

        }
        public void NhapHDMuon()
        {
            List<Sach> DSSach_Temp = new List<Sach>();
            DSSach_Temp.Add(dsGT[0]);
            dsGT[0].SoLuong--;
            DSSach_Temp.Add(dsKH[0]);
            dsKH[0].SoLuong--;
            MuonSach MuonSach_Temp = new MuonSach(dsDG[0], DSSach_Temp);

            dsMuon.Add(MuonSach_Temp);

            DSSach_Temp.Clear();
            DSSach_Temp.Add(dsLS[0]);
            dsLS[0].SoLuong--;
            MuonSach MuonSach_Temp1 = new MuonSach(dsDG[1], DSSach_Temp);
            dsMuon.Add(MuonSach_Temp1);
        }
        public void GiaHanThe()
        {

        }
        
        public void XuatDsHDMuon()
        {
            for(int i=0;i<dsMuon.Count;i++)
            {
                Console.WriteLine("Nguoi muon: " + dsMuon[i].NgMuon.MaDG + " so luong: "+this.dsMuon[i].slSachMuon);
            }
        }
    }
}
