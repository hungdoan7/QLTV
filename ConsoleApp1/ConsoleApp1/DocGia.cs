using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    class DocGia : Nguoi, DacTrungDocGia
    {
        private string sMaDG;
        private string sEmail;
        private Date dtNgayHetHanThe;
        private double dTaiKhoan;
		public string MaDG
		{
			get
			{
				return this.sMaDG;
			}
		}
		public string Email
		{
			get
			{
				return this.sEmail;
			}
		}
		public Date NgayHetHanThe
		{
			get { return this.dtNgayHetHanThe; }
			set { this.dtNgayHetHanThe = value; }
		}
		public double TaiKhoan
		{
			get { return this.dTaiKhoan; }
			set { this.dTaiKhoan = value; }
		}
		public DocGia() : base()
        {

        }
        public DocGia(string MaDG, string HoTen, string DiaChi, string SDT, int NgaySinh,int ThangSinh, int NamSinh, string Email, int NgayHH, int ThangHH, int NamHH, double TaiKhoan) : base(HoTen, DiaChi, SDT, NgaySinh,ThangSinh,NamSinh)
        {
            this.sMaDG = MaDG;
            this.sEmail = Email;
            this.dtNgayHetHanThe = new Date();
            this.dtNgayHetHanThe.iNgay = NgayHH;
            this.dtNgayHetHanThe.iThang = ThangHH;
            this.dtNgayHetHanThe.iNam = NamHH;
            this.dTaiKhoan = TaiKhoan;
        }
		public override void Nhap()
		{
			base.Nhap();
			Console.Write("Email: ");
			this.sEmail = Console.ReadLine();
		}
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Ma doc gia: " + this.sMaDG);
            Console.WriteLine("Email: " + this.sEmail);
            Console.WriteLine("Ngay het han the: " + this.dtNgayHetHanThe.iNgay+"/"+this.dtNgayHetHanThe.iThang+"/"+this.dtNgayHetHanThe.iNam);
            Console.WriteLine("So du tai khoan: " + this.dTaiKhoan);
        }
		public void GiaHanThe(Date Today)
		{
			if (Today < this.dtNgayHetHanThe)
			{
				this.dtNgayHetHanThe += 180;
				this.dTaiKhoan = this.dTaiKhoan - 50000;
			}
			else
			{
				this.dtNgayHetHanThe = Today + 180;
				this.dTaiKhoan = this.dTaiKhoan - 50000;
			}
		}
		public void NapThemTien(double Tien)
		{
			this.dTaiKhoan = this.dTaiKhoan + Tien;
		}
		public void DangKyTaiKhoanMoi(Date Today)
		{
			this.dtNgayHetHanThe = Today + 180;
			this.dTaiKhoan = 100000;
		}
	}
}
