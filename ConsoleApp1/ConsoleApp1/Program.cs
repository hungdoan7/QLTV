using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
	
	class Program
    {
		// tim cach de dToday thanh bien toan cuc
		// tao day du cac ham nhap xuat cho cac class
		// chu y den tinh dong goi , han che su dung public
		// khai bao day du cac properties

		public static Date dToday = new Date();
		static void Main(string[] args)
        { 
            Console.WriteLine("Ngay hom nay: ");
            dToday.iNgay = Convert.ToInt32(Console.ReadLine());
            dToday.iThang = Convert.ToInt32(Console.ReadLine());
            dToday.iNam = Convert.ToInt32(Console.ReadLine());

			ThuVien thuvien = new ThuVien();
			thuvien.NhapThuVien();
			thuvien.NhapHDMuon();
			thuvien.XuatDsHDMuon();

		}
    }
}
