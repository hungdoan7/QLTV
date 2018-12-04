using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    public class NhanVien : Nguoi
    {
        public string sMaNV;
        public string sChucVu;
        public string sBoPhan;
        public double dLuongCB;
        public double dPhuCap;
		public double dLuong;

        public NhanVien() : base()
        {

        }
        public NhanVien(string MaNV, string HoTen, string DiaChi, string SDT, string NgaySinh, string ChucVu, string BoPhan,double LuongCoBan, double PhuCap) : base(HoTen, DiaChi, SDT, NgaySinh)
        {
            this.sMaNV = MaNV;
            this.sChucVu = ChucVu;
            this.sBoPhan = BoPhan;
			this.dLuongCB = LuongCoBan;
			this.dPhuCap = PhuCap;
			TinhLuong();
        }
        public void TinhLuong()
        {
            this.dLuong = (this.dLuongCB + this.dPhuCap);
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Ma Nhan vien: " + this.sMaNV);
            Console.WriteLine("Chuc Vu: " + this.sChucVu);
            Console.WriteLine("Bo Phan: " + this.sBoPhan);
            Console.WriteLine("Luong co ban: " + this.dLuongCB);
            Console.WriteLine("Phu cap: " + this.dPhuCap);
			Console.WriteLine("Phu cap: " + this.dLuong);
		}
    }
}
