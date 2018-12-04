using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
  public  class LichSu:Sach
    {
        public string Quocgia;
        public LichSu(string masach, string tua, string nxb, string tacgia, int gia, int soluong, string quocgia) : base(masach, tua, nxb, tacgia, gia, soluong)
        {
            this.Quocgia = quocgia;
        }
        //public void nhap(string masach, string tua, string nxb, string tacgia, int gia, string quocgia, int soluong)
        //{
        //    base.nhap(masach, tua, nxb, tacgia, gia, soluong);
        //    this.Quocgia = quocgia;
        //}

    }
}
