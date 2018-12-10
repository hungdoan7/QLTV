using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
	class QuyenSachKhoaHoc : DauSachKhoaHoc,DacTrungQuyenSach
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
		public QuyenSachKhoaHoc() : base()
		{
			this.bDaMuonHayChua = true;
			this.dtNgayMuon = new Date();
			this.dtNgayPhaiTra = new Date();
		}
		public QuyenSachKhoaHoc(string MaDauSach, string Tua, string NXB, string TacGia, double Gia, string ChuyenNganh,int MaQuyenSach) : base(MaDauSach, Tua, NXB, TacGia, Gia,ChuyenNganh)
		{
			this.sMaQuyenSach = MaQuyenSach;
			this.bDaMuonHayChua = true;						// true la chua duoc muon, con trong thu vien, false la da duoc muon roi
			this.dtNgayMuon = new Date();
			this.dtNgayPhaiTra = new Date();
			TinhThanhTien();
		}
		public override void Nhap()
		{
			base.Nhap();
		}
		public override void Xuat()
		{
			base.Xuat();
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
			Console.Write(" Ma quyen sach: " + this.sMaQuyenSach);
		}
		public override void TinhThanhTien()
		{
			this.dThanhTien = this.dGia + (this.dGia * this.dThue/100);
		}
		
		public void MuonNgayHomNay(Date Today)
		{
			this.bDaMuonHayChua = false;
			this.dtNgayMuon = Today;
			this.dtNgayPhaiTra = (Today + 60);
		}
		public void TraSach()
		{
			this.bDaMuonHayChua = true;
			this.dtNgayMuon = new Date();
			this.dtNgayPhaiTra = new Date();
		}
		public void XDNgayTra()
		{
			this.dtNgayPhaiTra = this.dtNgayMuon + 60;
		}
	}
}
