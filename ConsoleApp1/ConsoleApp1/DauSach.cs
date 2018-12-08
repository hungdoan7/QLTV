using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
	interface DacTrungQuyenSach
	{
		void MuonNgayHomNay(Date Today);
		void TraSach();
		void XDNgayTra();
	}
    abstract class DauSach
    { 
        protected string sMaDauSach;
        protected string sTua;
		protected string sNXB;
		protected string sTacGia;
		protected int iSoLuongTrongThuVien;
		protected double dGia;
		protected double dThue;
		protected double dThanhTien;

		public string MaDauSach
		{
			get { return this.sMaDauSach; }			
		}
		public string Tua
		{
			get { return this.sTua; }
		}
		public string NXB
		{
			get { return this.sNXB; }
		}
		public string TacGia
		{
			get { return this.sTacGia; }
		}
		public int SoLuongTrongThuVien
		{
			get { return this.iSoLuongTrongThuVien; }
			set { this.iSoLuongTrongThuVien = value; }
		}
		public double Gia
		{
			get { return this.dGia; }
		}
		public double Thue
		{
			get { return this.dThue; }
		}
		public double ThanhTien
		{
			get { return this.dThanhTien; }
		}
		public DauSach()
		{

		}
        public DauSach(string MaDauSach, string Tua, string NXB, string TacGia, double Gia)
        {
            this.sMaDauSach = MaDauSach;
            this.sTua = Tua;
            this.sNXB = NXB;
            this.sTacGia = TacGia;
            this.dGia = Gia;
			this.iSoLuongTrongThuVien = 0;
		}
        
		public virtual void Nhap()
		{
			Console.WriteLine(" Nhap vao ma dau sach: ");
			this.sMaDauSach = Console.ReadLine();
			Console.WriteLine(" Nhap vao tua sach: ");
			this.sTua = Console.ReadLine();
			Console.WriteLine(" Nhap vao NXB: ");
			this.sNXB = Console.ReadLine();
			Console.WriteLine(" Nhap vao tac gia: ");
			this.sTacGia = Console.ReadLine();
			Console.WriteLine(" Nhap vao gia: ");
			string Temp = Console.ReadLine();
			this.dGia= Convert.ToDouble(Temp);
			this.iSoLuongTrongThuVien = 0;
		}
		public virtual void Xuat()
		{
			
			Console.WriteLine(" Ma dau sach: " + this.sMaDauSach);
			Console.WriteLine(" Tua sach: " + this.sTua);
			Console.WriteLine(" NXB: " + this.sNXB);
			Console.WriteLine(" Tac gia: " + this.sTacGia);			
		}
		public abstract void TinhThanhTien();
		public abstract void XacDinhThue();
	}
}
