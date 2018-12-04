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
        public double Thue;
        public LichSu(string masach, string tua, string nxb, string tacgia, int gia, int soluong, string quocgia) : base(masach, tua, nxb, tacgia, gia, soluong)
        {
            this.Quocgia = quocgia;
        }
        public override void TinhTien()
        {
            this.Thtien = this.Gia + 5000 * this.Thue;
        }
    }
}
