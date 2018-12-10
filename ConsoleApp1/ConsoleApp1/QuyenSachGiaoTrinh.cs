using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
	class QuyenSachGiaoTrinh:DauSachGiaoTrinh,DacTrungQuyenSach
	{
		private int sMaQuyenSach;
		private bool bDaMuonHayChua;
		private Date dtNgayMuon;
		private Date dtNgayPhaiTra;
		private int iTinhTrang;          //0 là cũ , 1 là mới
		public int MaQuyenSach
		{
			get { return this.sMaQuyenSach; }
		}
		public bool DaMuonHayChua
		{
			get { return this.bDaMuonHayChua; }
			set { this.bDaMuonHayChua = value; }
		}
		public Date NgayMuon
		{
			get { return this.dtNgayMuon; }
			set { this.dtNgayMuon = value; }
		}
		public Date NgayPhaiTra
		{
			get { return this.dtNgayPhaiTra; }
			set { this.dtNgayPhaiTra = value; }
		}
		public QuyenSachGiaoTrinh() : base()
		{
			this.bDaMuonHayChua = true;
			this.dtNgayMuon = new Date();
			this.dtNgayPhaiTra = new Date();
		}
		public int TinhTrang
		{
			get { return this.iTinhTrang; }
			set { this.iTinhTrang = value; }
		}
		public QuyenSachGiaoTrinh(string MaDauSach, string Tua, string NXB, string TacGia, double Gia, string BoMon, int TinhTrang,int MaQuyenSach) : base(MaDauSach, Tua, NXB, TacGia, Gia,BoMon)
		{
			this.sMaQuyenSach = MaQuyenSach;
			this.iTinhTrang = TinhTrang;	
			this.bDaMuonHayChua = true;
			this.dtNgayMuon = new Date();
			this.dtNgayPhaiTra = new Date();
			this.XacDinhThue();
			this.TinhThanhTien();
		}
		public override void Nhap()
		{
			base.Nhap();
			Console.Write("Tinh trang ( 0 la cu || 1 la moi ): ");
			this.iTinhTrang = Convert.ToInt32(Console.ReadLine());
		}
		public override void Xuat()
		{
			base.Xuat();
			if (this.iTinhTrang == 0)
			{
				Console.WriteLine(" Tinh Trang: Cu ");
			}
			else
			{
				Console.WriteLine(" Trinh trang: Moi ");
			}
			if (this.bDaMuonHayChua == false)
			{
				Console.WriteLine(" Da duoc muon! ");
				Console.WriteLine("Ngay het duoc muon : " + this.dtNgayMuon.Ngay + "/" + this.dtNgayMuon.Thang + "/" + this.dtNgayMuon.Nam);
				Console.WriteLine("Ngay het phai tra : " + this.dtNgayPhaiTra.Ngay + "/" + this.dtNgayPhaiTra.Thang + "/" + this.dtNgayPhaiTra.Nam);
			}
			else
			{
				Console.WriteLine(" Nam trong thu vien!  ");
			}
			Console.WriteLine(" Ma quyen sach: " + this.sMaQuyenSach);
			
		}
		public override void TinhThanhTien()
		{
			if (this.iTinhTrang == 0)
			{
				this.dThanhTien = (this.dGia / 2) + (this.dThue*this.dGia/100);
			}
			else
			{
				this.dThanhTien = this.dGia + (this.dThue*this.dGia/100);
			}
		}
		public void MuonNgayHomNay(Date Today)
		{
			this.bDaMuonHayChua = false;
			this.dtNgayMuon = Today;
			this.dtNgayPhaiTra = (Today + 120);
		}
		public void TraSach()
		{
			this.bDaMuonHayChua = true;
			this.dtNgayMuon = new Date();
			this.dtNgayPhaiTra = new Date();
		}
		public void XDNgayTra()
		{
			this.dtNgayPhaiTra = this.dtNgayMuon + 120;
		}
	}
}
