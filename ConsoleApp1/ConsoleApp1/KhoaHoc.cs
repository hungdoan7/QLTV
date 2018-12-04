using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
   public class KhoaHoc:Sach
    {
        public string ChuyenNganh;
        public double Thue;
        public KhoaHoc(string masach, string tua, string nxb, string tacgia, int gia, int soluong, string chnganh) : base(masach, tua, nxb, tacgia, gia, soluong)
        {
            this.ChuyenNganh = chnganh;
        }
        public override void TinhTien()
        {
            this.Thtien = this.Gia + this.Gia*this.Thue;
        }
    }
}
