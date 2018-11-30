using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
  public  class KhoaHoc : Sach
    {
        public string ChuyenNganh;
        public KhoaHoc():base()
            {

            }
        public void nhap(string masach, string tua, string nxb, string tacgia, int gia,string chuyennganh,int soluong)
        {
            base.nhap(masach,tua,nxb,tacgia,gia,soluong);
            this.ChuyenNganh = chuyennganh;

        }


    }
}
