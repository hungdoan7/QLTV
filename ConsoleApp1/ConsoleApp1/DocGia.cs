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
        public  void nhap()
        {
            Console.WriteLine("Nhap ma doc gia: ");
            this.MaDG = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap ho ten: ");
            this.HoTen = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap dia chi: ");
            this.DiaChi = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap so dien thoai: ");
            this.SDT = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap ngay sinh: ");
            this.NgaySinh = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap email: ");
           this.Email= Convert.ToString(Console.ReadLine());
            this.NgayLapThe = new iDate(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);

        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("Ma doc gia: " + this.MaDG);
            Console.WriteLine("Email: " + this.Email);
            Console.WriteLine("Ngay Lap the: " + this.NgayLapThe.ngay+"/"+this.NgayLapThe.thang+"/"+this.NgayLapThe.nam);
            Console.WriteLine("So du tai khoan: " + this.TaiKhoan);
        }
        public override void GiaHanThe()
        {
            this.NgayLapThe = new iDate(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year) + 180;

        }
    }
}
