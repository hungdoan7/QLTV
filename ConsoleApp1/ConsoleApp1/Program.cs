using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    class Program
    {
        public static iDate today = new iDate();
        static void Main(string[] args)
        { 
            //Console.WriteLine("Ngay hom nay: ");
            //today.ngay = Convert.ToInt32(Console.ReadLine());
            //today.thang = Convert.ToInt32(Console.ReadLine());
            //today.nam = Convert.ToInt32(Console.ReadLine());
            ThuVien tv = new ThuVien();
            tv.NhapThuVien();
            tv.NhapHDMuon();
            tv.XuatDsHDMuon();
        }
    }
}
