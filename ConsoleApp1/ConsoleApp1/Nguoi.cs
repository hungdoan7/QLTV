using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
   public class Nguoi
    {
        public string sHoTen;
        public string sDiaChi;
        public string sSDT;
        public string sNgaySinh;
		public Nguoi()
		{

		}
        public Nguoi (string HoTen, string DiaChi, string SDT, string NgaySinh)
        {
            this.sHoTen = HoTen;
            this.sDiaChi = DiaChi;
            this.sSDT = SDT;
            this.sNgaySinh = NgaySinh;
        }
        public virtual void Xuat()
        {
            Console.WriteLine("Ho Ten: " + this.sHoTen);
            Console.WriteLine("Dia Chi: " + this.sDiaChi);
            Console.WriteLine("SDT: " + this.sSDT);
            Console.WriteLine("Ngay Sinh: " + this.sNgaySinh);
        }
		//interface o cho gia han the 

    }
}
