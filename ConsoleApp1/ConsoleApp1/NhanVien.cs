using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    public class NhanVien:Nguoi
    {
        public string MaNV;
        public string ChucVu;
        public string BoPhan;
        public int LuongCB;
        double Phucap;
        public NhanVien() : base()
        {

        }
        public void nhap(string manv, string hoten, string diachi, string sdt, string ngaysinh, string chucvu, string bophan)
        {
            base.nhap(hoten, diachi, sdt, ngaysinh);
            this.MaNV = manv;
            this.ChucVu = chucvu;
            this.BoPhan = bophan;
        }
        public void TinhLuong()
        {
            Console.WriteLine("luong: " + (this.LuongCB + this.Phucap));
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("Ma Nhan vien: " + this.MaNV);
            Console.WriteLine("Chuc Vu: " + this.ChucVu);
            Console.WriteLine("Bo Phan: " + this.BoPhan);
            Console.WriteLine("Luong co ban: " + this.LuongCB);
            Console.WriteLine("Phu cap: " + this.Phucap);
        }
    }
}
