using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
  public  class ThuVien
    {

        public List<KhoaHoc> lDSSachKH ;
        public List<LichSu> lDSSachLS;
        public List<GiaoTrinh> lDSSachGT;
        public List<DocGia> lDSDocGia;
        public List<MuonSach> lDSHopDongMuon;
        
        public ThuVien()
        {
            this.lDSSachKH = new List<KhoaHoc>();
            this. lDSSachLS = new List<LichSu>();
            this.lDSSachGT = new List<GiaoTrinh>();
            this.lDSDocGia = new List<DocGia>();
            this.lDSHopDongMuon = new List<MuonSach>();
        }
        public void NhapThuVien()
        {
            KhoaHoc s1 = new KhoaHoc("KH01", "A1", "DHQG", "TG1", 18888, 30, "Toan");
            lDSSachKH.Add(s1);
             s1 = new KhoaHoc("KH02", "A2", "DHQG", "TG2", 18888, 30, "Vat Ly");
            lDSSachKH.Add(s1);
            s1 = new KhoaHoc("KH03", "A3", "DHQG", "TG3", 18888, 30, "CTDL");
            lDSSachKH.Add(s1);
            LichSu s2 = new LichSu("LS01", "B1", "DHQG", "TG4", 20000, 30, "Viet nam");
            lDSSachLS.Add(s2);
            s2 = new LichSu("LS02", "B2", "DHQg", "Tg4", 30000, 20, "Thai lan");
            lDSSachLS.Add(s2);
            GiaoTrinh s3 = new GiaoTrinh("GT01", "C1", "SPKT", "TG4", 20000, 30, "Vat Ly",1);
            lDSSachGT.Add(s3);
            DocGia s4 = new DocGia("DG1", "Truc", "TuDu", "0199", "3/5", "hgakhas", 5, 9, 2001,330000);
            lDSDocGia.Add(s4);
            s4 = new DocGia("DG2", "Hung", "TuDu1", "01994", "3/7", "hdfgakhas", 6, 7, 2007, 100000);
            lDSDocGia.Add(s4);

        }
        public void NhapHDMuon()
        {
            List<Sach> DSSach_Temp = new List<Sach>();
            DSSach_Temp.Add(lDSSachGT[0]);
            lDSSachGT[0].iSoLuong--;
            DSSach_Temp.Add(lDSSachKH[0]);
            lDSSachKH[0].iSoLuong--;
            MuonSach MuonSach_Temp = new MuonSach(lDSDocGia[0], DSSach_Temp);

            lDSHopDongMuon.Add(MuonSach_Temp);

            DSSach_Temp.Clear();
            DSSach_Temp.Add(lDSSachLS[0]);
            lDSSachLS[0].iSoLuong--;
            MuonSach MuonSach_Temp1 = new MuonSach(lDSDocGia[1], DSSach_Temp);
            lDSHopDongMuon.Add(MuonSach_Temp1);

        }
     
        public void XuatDsHDMuon()
        {
            for(int i=0;i<lDSHopDongMuon.Count;i++)
            {
                Console.WriteLine("Nguoi muon: " + lDSHopDongMuon[i].dgNguoiMuon.sMaDG + " so luong: "+this.lDSHopDongMuon[i].iSoLuongSachMuon);
            }
        }
    }
}
