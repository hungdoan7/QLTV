using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
  public  class LichSu:Sach
    {
        public string sQuocgia;
        public double dThue;
        public LichSu(string MaSach, string Tua, string NXB, string TacGia, int Gia, int SoLuong, string QuocGia) : base(MaSach, Tua, NXB, TacGia, Gia, SoLuong)
        {
            this.sQuocgia = QuocGia;
        }
        public override void TinhThanhTien()
        {
            this.dThanhTien = this.dGia + 5000 * this.dThue;
        }
    }
}
