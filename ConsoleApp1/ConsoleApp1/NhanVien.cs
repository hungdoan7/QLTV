using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
	class NhanVien : Nguoi
	{
		private string sMaNV;
		private int iBoPhan;
		private double dLuongCB;
		private int iSoNgayCong;
		private double dLuong;

		public string MaNV
		{
			get { return this.sMaNV; }
		}
		public int BoPhan
		{
			get { return this.iBoPhan; }
		}
		public double LuongCoBan
		{
			get { return this.dLuongCB; }
		}
		public int SoNgayCong
		{
			get { return this.iSoNgayCong; }
		}
		public double Luong
		{
			get { return this.dLuong; }
		}

		public NhanVien() : base()
		{

		}
		public NhanVien(string MaNV, string HoTen, string DiaChi, string SDT, int NgaySinh,int ThangSinh, int NamSinh, int BoPhan, double LuongCoBan) : base(HoTen, DiaChi, SDT, NgaySinh,ThangSinh,NamSinh)
		{
			this.sMaNV = MaNV;
			this.iBoPhan = BoPhan;
			this.dLuongCB = LuongCoBan;
			Tien(dLuongCB);
		}
		public override void Xuat()
		{
			base.Xuat();
			Console.WriteLine("Ma Nhan vien: " + this.sMaNV);
			if (this.iBoPhan == 0)
			{
				Console.WriteLine("Bo Phan: Quan ly ");
			}
			else
			{
				Console.WriteLine("Bo Phan: Nhan vien");
			}
			Console.WriteLine("Luong co ban: " + this.dLuongCB);
			Console.WriteLine("Luong thuc te: " + this.dLuong);
		}
		public override void Nhap()
		{
			base.Nhap();
			Console.Write("Ma nhan vien : ");
			this.sMaNV = Console.ReadLine();
			Console.Write("Bo phan: ");
			this.iBoPhan = Convert.ToInt32(Console.ReadLine());
			Console.Write("Luong co ban : ");
			this.dLuongCB = Convert.ToDouble(Console.ReadLine());
			Tien(this.dLuongCB);
		}
		public override void Tien(double LuongCoBan)
		{
			if (this.iBoPhan == 0)
			{
				this.dLuong = (this.dLuongCB* 1.5 );
			}
			else
			{
				this.dLuong = ( this.dLuongCB );
			}
		}
	}
}
