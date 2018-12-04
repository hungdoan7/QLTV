using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    public class DocGiaVIP : Nguoi
    {
		public string sMaDG;
		public string sEmail;
		public Date dtNgayLapThe;
		public double dTaiKhoan;

		public DocGiaVIP() : base()
		{

		}
		public DocGiaVIP(string MaDG, string HoTen, string DiaChi, string SDT, string NgaySinh, string Email, int Ngay, int Thang, int Nam, double TaiKhoan) : base(HoTen, DiaChi, SDT, NgaySinh)
		{
			this.sMaDG = MaDG;
			this.sEmail = Email;
			this.dtNgayLapThe = new Date();
			this.dtNgayLapThe.iNgay = Ngay;
			this.dtNgayLapThe.iThang = Thang;
			this.dtNgayLapThe.iNam = Nam;
			this.dTaiKhoan = TaiKhoan;
		}

		public override void Xuat()
		{
			base.Xuat();
			Console.WriteLine("Ma doc gia: " + this.sMaDG);
			Console.WriteLine("Email: " + this.sEmail);
			Console.WriteLine("Ngay Lap the: " + this.dtNgayLapThe.iNgay + "/" + this.dtNgayLapThe.iThang + "/" + this.dtNgayLapThe.iNam);
			Console.WriteLine("So du tai khoan: " + this.dTaiKhoan);
		}


	}
}
