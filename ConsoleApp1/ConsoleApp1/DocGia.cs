using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
  public  class DocGia:Nguoi
    {
        public string MaDG;
        public string Email;
        public iDate NgayLapThe;
        public double TaiKhoan;

        public DocGia() : base()
        {

        }
        public DocGia(string madg, string hoten, string diachi, string sdt, string ngaysinh, string email, int ngay, int thang, int nam,double taikhoan)
        {

            base.nhap(hoten, diachi, sdt, ngaysinh);
            this.MaDG = madg;
            this.Email = email;
            NgayLapThe = new iDate();
            this.NgayLapThe.ngay = ngay;
            this.NgayLapThe.thang = thang;
            this.NgayLapThe.nam = nam;
            this.TaiKhoan = taikhoan;
        }
        public  void nhap(string madg, string hoten, string diachi, string sdt, string email, string ngaysinh, int ngay, int thang, int nam,double taikhoan)
        {
            base.nhap(hoten, diachi, sdt, ngaysinh);
            this.MaDG = madg;
            this.Email = email;
            NgayLapThe = new iDate();
            this.NgayLapThe.ngay = ngay;
            this.NgayLapThe.thang = thang;
            this.NgayLapThe.nam = nam;
            this.TaiKhoan = taikhoan;

        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("Ma doc gia: " + this.MaDG);
            Console.WriteLine("Email: " + this.Email);
            Console.WriteLine("Ngay Lap the: " + this.NgayLapThe.ngay+"/"+this.NgayLapThe.thang+"/"+this.NgayLapThe.nam);
            Console.WriteLine("So du tai khoan: " + this.TaiKhoan);
        }

    }
}
