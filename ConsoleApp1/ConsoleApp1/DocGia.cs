using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    class DocGia : Nguoi, DacTrungDocGia
    {
        private int iMaDG;
        private string sEmail;
        private Date dtNgayHetHanThe;
        private double dTaiKhoan;
		public int MaDG
		{
			get
			{
				return this.iMaDG;
			}
			set
			{
				this.iMaDG = value;
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
			set
			{
				if (value < 0 )
					throw new ArgumentOutOfRangeException
					(" must be > 0");
				this.dTaiKhoan = value;
			}
		}
		public DocGia() : base()
        {
			this.dtNgayHetHanThe = new Date();
		}
        public DocGia(int MaDG, string HoTen, string DiaChi, string SDT, int NgaySinh,int ThangSinh, int NamSinh, string Email, int NgayHH, int ThangHH, int NamHH, double TaiKhoan) : base(HoTen, DiaChi, SDT, NgaySinh,ThangSinh,NamSinh)
        {
            this.iMaDG = MaDG;
            this.sEmail = Email;
            this.dtNgayHetHanThe = new Date();
            this.dtNgayHetHanThe.Ngay = NgayHH;
            this.dtNgayHetHanThe.Thang = ThangHH;
            this.dtNgayHetHanThe.Nam = NamHH;
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
            Console.WriteLine("Ma doc gia: " + this.iMaDG);
            Console.WriteLine("Email: " + this.sEmail);
            Console.WriteLine("Ngay het han the: " + this.dtNgayHetHanThe.Ngay+"/"+this.dtNgayHetHanThe.Thang+"/"+this.dtNgayHetHanThe.Nam);
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
		public override void Tien(double Tien)
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
