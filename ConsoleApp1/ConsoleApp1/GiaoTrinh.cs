using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV

{
   public class GiaoTrinh:Sach
    {
        public string BoMon;
        public int Ttrang;//0 là cũ , 1 là mới
        public GiaoTrinh(string masach, string tua, string nxb, string tacgia, int gia, int soluong, string bomon) : base(masach, tua, nxb, tacgia, gia, soluong)
        {
            this.BoMon = bomon;
        }
        public override void TinhTien()
        {
            if(Ttrang==0)
            {
                this.Thtien = this.Gia / 2;
            }
            else
            {
                this.Thtien = this.Gia;
            }
        }
        //public void nhap(string masach, string tua, string nxb, string tacgia, int gia, string bomon, int soluong)
        //{
        //    base.nhap(masach, tua, nxb, tacgia, gia, soluong);
        //    this.BoMon = bomon;
        //}
    }
}
