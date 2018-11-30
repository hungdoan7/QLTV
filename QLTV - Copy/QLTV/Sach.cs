using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
 public  class Sach
    {
      public string Ma_sach;
       public  string Tua;
        public string NXB;
        public string TacGia;
        public int Gia;
        public int SoLuong;


        public virtual void nhap(string masach,string tua, string nxb,string tacgia,int gia,int soluong)
        {
            this.Ma_sach = masach;
            this.Tua = tua;
            this.NXB = nxb;
            this.TacGia = tacgia;
            this.Gia = gia;
            this.SoLuong = soluong;
        }
    }
}
