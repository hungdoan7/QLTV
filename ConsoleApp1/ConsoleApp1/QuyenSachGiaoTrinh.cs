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
		public QuyenSachGiaoTrinh(string MaDauSach, string Tua, string NXB, string TacGia, double Gia, string BoMon, int TinhTrang,int MaQuyenSach) : base(MaDauSach, Tua, NXB, TacGia, Gia,BoMon)
		{
			this.sMaQuyenSach = MaQuyenSach;
			this.iTinhTrang = TinhTrang;
			this.XacDinhThue();
			this.bDaMuonHayChua = true;
			this.dtNgayMuon = new Date();
			this.dtNgayPhaiTra = new Date();
			TinhThanhTien();
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
			}
			else
			{
				Console.WriteLine(" Nam trong thu vien!  ");
			}
			Console.Write(" Ma quyen sach: " + this.sMaQuyenSach);
		}
		public override void TinhThanhTien()
		{
			if (this.iTinhTrang == 0)
			{
				this.dThanhTien = (this.dGia / 2) + (this.dThue*this.dGia);
			}
			else
			{
				this.dThanhTien = this.dGia + (this.dThue*this.dGia);
			}
		}
		public void MuonNgayHomNay(Date Today)
		{
			this.dtNgayMuon = Today;
			this.dtNgayPhaiTra = (Today + 90);
		}
		public void TraSach()
		{
			this.bDaMuonHayChua = false;
			this.dtNgayMuon = new Date();
			this.dtNgayPhaiTra = new Date();
		}
		public void XDNgayTra()
		{
			this.dtNgayPhaiTra = this.dtNgayMuon + 120;
		}
	}
}
