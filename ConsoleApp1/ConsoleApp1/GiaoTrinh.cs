using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV

{
   public class GiaoTrinh:Sach
    {
        public string sBoMon;
        public int iTinhTrang;			//0 là cũ , 1 là mới

        public GiaoTrinh(string MaSach, string Tua, string NXB, string TacGia, int Gia, int SoLuong, string BoMon, int TinhTrang) : base(MaSach, Tua, NXB, TacGia, Gia, SoLuong)
        {
            this.sBoMon = BoMon;
			this.iTinhTrang = TinhTrang;
        }
      
		public override void TinhThanhTien()
		{
			if (this.iTinhTrang == 0)
			{
				this.dThanhTien = this.dGia / 2;
			}
			else
			{
				this.dThanhTien = this.dGia;
			}
		}
	}
}
