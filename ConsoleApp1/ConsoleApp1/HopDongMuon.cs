using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
     class HopDongMuon
    {
		private DocGia dgNguoiMuon;
		private List<QuyenSachKhoaHoc> lDSSachKHMuon;
		private List<QuyenSachGiaoTrinh> lDSSachGTMuon;
		private int iSoLuongSachMuon;
		public DocGia NguoiMuon
		{
			get { return this.dgNguoiMuon; }
			set { this.dgNguoiMuon = value; }
		}
		public List<QuyenSachKhoaHoc> DSSachKHMuon
		{
			get { return this.lDSSachKHMuon; }
			set { this.lDSSachKHMuon = value; }
		}
		public List<QuyenSachGiaoTrinh> DSSachGTMuon
		{
			get { return this.lDSSachGTMuon; }
			set { this.lDSSachGTMuon = value; }
		}
		public int SoLuongSachMuon
		{
			get
			{
				return this.iSoLuongSachMuon;
			}
			set
			{
				this.iSoLuongSachMuon = value;
			}
		}

		public HopDongMuon()
		{
			this.lDSSachGTMuon = new List<QuyenSachGiaoTrinh>();
			this.lDSSachKHMuon = new List<QuyenSachKhoaHoc>();
		}
		public HopDongMuon(DocGia NguoiMuon, List<QuyenSachKhoaHoc> DSSachKHMuon, List<QuyenSachGiaoTrinh> DSSachGTMuon)
		{
			this.dgNguoiMuon = NguoiMuon;
			this.lDSSachKHMuon = DSSachKHMuon;
			this.lDSSachGTMuon = DSSachGTMuon;
			this.iSoLuongSachMuon = this.lDSSachGTMuon.Count+this.lDSSachKHMuon.Count;
		}		
	}
}
