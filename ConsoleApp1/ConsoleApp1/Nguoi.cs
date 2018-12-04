using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
   public abstract class Nguoi
    {
        public string HoTen;
        public string DiaChi;
        public string SDT;
        public string NgaySinh;
        public virtual void nhap(string hoten, string diachi, string sdt, string ngaysinh)
        {
            this.HoTen = hoten;
            this.DiaChi = diachi;
            this.SDT = sdt;
            this.NgaySinh = ngaysinh;
        }
        public virtual void xuat()
        {
            Console.WriteLine("Ho Ten: " + this.HoTen);
            Console.WriteLine("Dia Chi: " + this.DiaChi);
            Console.WriteLine("SDT: " + this.SDT);
            Console.WriteLine("Ngay Sinh: " + this.NgaySinh);
        }
        public abstract void GiaHanThe();

    }
}
