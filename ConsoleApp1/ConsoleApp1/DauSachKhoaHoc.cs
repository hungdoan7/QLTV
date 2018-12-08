using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    class DauSachKhoaHoc:DauSach
    {
        protected string sChuyenNganh;
		protected List<QuyenSachKhoaHoc> lDSQuyenSach;
		public string ChuyenNganh
		{
			get { return this.sChuyenNganh; }
		}
		public List<QuyenSachKhoaHoc> DSQuyenSach
		{
			get { return this.lDSQuyenSach; }
			set { this.lDSQuyenSach = value; }
		}
		public DauSachKhoaHoc()
		{
			XacDinhThue();
			this.lDSQuyenSach = new List<QuyenSachKhoaHoc>();
		}
        public DauSachKhoaHoc(string MaDauSach, string Tua, string NXB, string TacGia, double Gia, string ChuyenNganh) : base(MaDauSach, Tua, NXB, TacGia, Gia)
        {
            this.sChuyenNganh = ChuyenNganh;
			XacDinhThue();
			this.lDSQuyenSach = new List<QuyenSachKhoaHoc>();
        }
		public override void Nhap()
		{
			base.Nhap();
			Console.Write(" Chuyen nganh: ");
			this.sChuyenNganh = Console.ReadLine();
		}
		public override void Xuat()
		{
			base.Xuat();
			Console.WriteLine(" Chuyen nganh: " + this.sChuyenNganh);
		}
		public override void TinhThanhTien()
		{
			this.dThanhTien = this.dGia + (this.dGia * this.dThue/100);
		}
		public override void XacDinhThue()
		{
			this.dThue= 5;
		}
	}
}
