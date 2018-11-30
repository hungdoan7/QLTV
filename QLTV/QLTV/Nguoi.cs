using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
  public  class Nguoi
    {
        public string HoTen;
        public string DiaChi;
        public string SDT;
        public string NgaySinh;
        public virtual void nhap(string hoten,string diachi,string sdt,string ngaysinh)
        {
            this.HoTen = hoten;
            this.DiaChi = diachi;
            this.SDT = sdt;
            this.NgaySinh = ngaysinh;
        }


    }
}
