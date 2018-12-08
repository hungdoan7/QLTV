using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    class DauSachGiaoTrinh:DauSach
    {
        protected string sBoMon;
        protected int iTinhTrang;          //0 là cũ , 1 là mới
		protected List<QuyenSachGiaoTrinh> lDSQuyenSach;
		public string BoMon
		{
			get { return this.sBoMon; }
		}
		public int TinhTrang
		{
			get { return this.iTinhTrang; }
		}
		public List<QuyenSachGiaoTrinh> DSQuyenSach
		{
			get { return this.lDSQuyenSach; }
			set { this.lDSQuyenSach = value; }
		}
		public DauSachGiaoTrinh()
		{
			this.XacDinhThue();
			this.lDSQuyenSach = new List<QuyenSachGiaoTrinh>();
		}
		
        public DauSachGiaoTrinh(string MaDauSach, string Tua, string NXB, string TacGia, double Gia, string BoMon) : base(MaDauSach, Tua, NXB, TacGia, Gia)
        {
            this.sBoMon = BoMon;
			this.lDSQuyenSach = new List<QuyenSachGiaoTrinh>();
		}
      
		public override void Nhap()
		{
			base.Nhap();
			Console.Write(" Bo mon: ");
			this.sBoMon = Console.ReadLine();
		}
		public override void Xuat()
		{
			base.Xuat();
			Console.WriteLine(" Bo mon: " + this.sBoMon);
		}
		public override void TinhThanhTien()
		{
			if (this.iTinhTrang == 0)
			{
				this.dThanhTien = (this.dGia / 2) + (this.dThue * this.dGia/100);
			}
			else
			{
				this.dThanhTien = this.dGia + (this.dThue * this.dGia/100);
			}
		}
		public override void XacDinhThue()
		{
			this.dThue = 10;
		}
	}
}
