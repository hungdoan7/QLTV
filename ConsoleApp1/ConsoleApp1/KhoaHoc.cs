using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
   public class KhoaHoc:Sach
    {
        public string sChuyenNganh;
        public double dThue;
        public KhoaHoc(string MaSach, string Tua, string NXB, string TacGia, int Gia, int SoLuong, string ChuyenNganh) : base(MaSach, Tua, NXB, TacGia, Gia, SoLuong)
        {
            this.sChuyenNganh = ChuyenNganh;
        }
        public override void TinhThanhTien()
        {
            this.dThanhTien = this.dGia + this.dGia*this.dThue;
        }
    }
}
