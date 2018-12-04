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
        List<string> dsSach= new List<string>();
        
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
            for (int i = 0; i < dsGT.Count; i++)
                dsSach.Add(dsGT[i].Ma_sach);
            for (int i = 0; i < dsKH.Count; i++)
                dsSach.Add(dsKH[i].Ma_sach);
            for (int i = 0; i < dsLS.Count; i++)
                dsSach.Add(dsLS[i].Ma_sach);

        }
        public void NhapHDMuon()
        {
           
            DocGia NewDG=new DocGia();
            MuonSach MuonSach_Temp;
            bool DangKi=false;
            Console.WriteLine("Nhap ma doc gia: ");
            string ID = Convert.ToString(Console.ReadLine());
            int kt = 0;
            while (kt == 0)
            {
                int k = 0;
                while (k < dsDG.Count && ID != dsDG[k].MaDG) k++;
                if (k >= dsDG.Count)
                {
                    int Chon;
                    Console.WriteLine("Ma doc gia sai. Ban co muon dang ki ? (Phim 1)");
                    Console.WriteLine("Nhập lại (Phim 0)");
                    Console.WriteLine("Lua chon cua ban: ");
                    Chon = int.Parse(Console.ReadLine());
                    if (Chon == 1)
                    {

                        NewDG.nhap();
                        dsDG.Add(NewDG);
                        kt = 1;
                        DangKi = true;
                    }
                    else
                    {
                        kt = 0;
                        Console.WriteLine("Nhap lai ma doc gia: ");
                        ID = Convert.ToString(Console.ReadLine());
                    }
                }
                else kt = 1;
                
            }
            
           
                List<Sach> DSSach_Temp = new List<Sach>();
                Console.WriteLine("Nhap so luong sach can muon: ");
                int SLSach = int.Parse(Console.ReadLine());
                string MaSach;
            for (int i=0;i<SLSach;i++)
            {
                 kt = 0;
                 Console.WriteLine("Nhap ma sach: ");
                 MaSach = Convert.ToString(Console.ReadLine());
                  while (kt == 0) {
                       
                       int k = 0;
                        while (k < dsSach.Count && MaSach != dsSach[k]) k++;
                        if (k >= dsSach.Count)
                        {
                            Console.WriteLine("Ma sach khong dung: ");
                            Console.WriteLine("Nhap lai ma sach: ");
                            MaSach = Convert.ToString(Console.ReadLine());
                            kt = 0;
                        }
                        else kt = 1;
                  }
                if (MaSach.Substring(0, 2) == "KH")
                {
                    for (i = 0; i < dsKH.Count; i++)
                        if (MaSach == dsKH[i].Ma_sach)
                            DSSach_Temp.Add(dsKH[i]);
                }
                else if (MaSach.Substring(0, 2) == "LS")
                {
                    for (i = 0; i < dsLS.Count; i++)
                        if (MaSach == dsLS[i].Ma_sach)
                            DSSach_Temp.Add(dsLS[i]);
                }
                else
                {
                    for (i = 0; i < dsGT.Count; i++)
                        if (MaSach == dsGT[i].Ma_sach)
                            DSSach_Temp.Add(dsGT[i]);
                }
                    if (DangKi == false)
                        NewDG = dsDG.Where(item => item.MaDG == ID).SingleOrDefault();
                    MuonSach_Temp = new MuonSach(NewDG, DSSach_Temp);
                    dsMuon.Add(MuonSach_Temp);
            }

            
            //List<Sach> DSSach_Temp = new List<Sach>();
            //DSSach_Temp.Add(dsGT[0]);
            //dsGT[0].SoLuong--;
            //DSSach_Temp.Add(dsKH[0]);
            //dsKH[0].SoLuong--;
            //MuonSach MuonSach_Temp = new MuonSach(dsDG[0], DSSach_Temp);

            //dsMuon.Add(MuonSach_Temp);

            //DSSach_Temp.Clear();
            //DSSach_Temp.Add(dsLS[0]);
            //dsLS[0].SoLuong--;
            //MuonSach MuonSach_Temp1 = new MuonSach(dsDG[1], DSSach_Temp);
            //dsMuon.Add(MuonSach_Temp1);
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
