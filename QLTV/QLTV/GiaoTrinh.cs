using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
  public  class GiaoTrinh:Sach
    {
        public string BoMon;
        public GiaoTrinh():base()
        {

        }
        public void nhap(string masach, string tua, string nxb, string tacgia, int gia, string bomon,int soluong)
        {
            base.nhap(masach, tua, nxb, tacgia, gia,soluong);
            this.BoMon = bomon;
        }

    }
}
