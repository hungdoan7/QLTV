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
        
        
        public ThuVien()
        {
            this.dsKH = new List<KhoaHoc>();
            this. dsLS = new List<LichSu>();
            this.dsGT = new List<GiaoTrinh>();
            this.dsDG = new List<DocGia>();
        }
        public ThuVien(List<KhoaHoc> dskh,List<LichSu>dsls,List<GiaoTrinh>dsgt,List<DocGia>dsdg)
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
            DocGia s4 = new DocGia();
            s4.nhap()
            
        }

        
        
    }
}
