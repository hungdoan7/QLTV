using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
	class NhanVien : Nguoi
	{
		private int iMaNV;
		private int iBoPhan;
		private double dLuongCB;
		private int iSoNgayCong;
		private double dLuong;

		public int MaNV
		{
			get { return this.iMaNV; }
			set
			{
				this.iMaNV = value;
			}
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
		public NhanVien(int MaNV, string HoTen, string DiaChi, string SDT, int NgaySinh,int ThangSinh, int NamSinh, int BoPhan, double LuongCoBan,int SoNgayCong) : base(HoTen, DiaChi, SDT, NgaySinh,ThangSinh,NamSinh)
		{
			this.iMaNV = MaNV;
			this.iBoPhan = BoPhan;
			this.dLuongCB = LuongCoBan;
			this.iSoNgayCong = SoNgayCong;
			Tien(dLuongCB);
		}
		public override void Xuat()
		{
			base.Xuat();
			Console.WriteLine("Ma Nhan vien: " + this.iMaNV);
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
			Console.Write("Bo phan (0 la quan ly.,1 la nhan vien): ");
			this.iBoPhan = Convert.ToInt32(Console.ReadLine());
			Console.Write("Luong co ban : ");
			this.dLuongCB = Convert.ToDouble(Console.ReadLine());
			Console.Write("So ngay cong: ");
			this.iBoPhan = Convert.ToInt32(Console.ReadLine());
			Tien(this.dLuongCB);
		}
		public override void Tien(double LuongCoBan)
		{
			if (this.iBoPhan == 0)
			{
				this.dLuong = (this.dLuongCB* 1.5 )+(this.dLuongCB*this.iSoNgayCong/100);
			}
			else
			{
				this.dLuong = ( this.dLuongCB )+ (this.dLuongCB * this.iSoNgayCong / 100);
			}
		}
	}
}
