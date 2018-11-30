using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    public class TheDocGia:Nguoi
    {
        public string MaDG;
        public string Email;
        public iDate NgayLapThe;
     
        public TheDocGia():base()
        {

        }
        public TheDocGia(string madg, string hoten, string diachi, string sdt, string ngaysinh, string email, int ngay, int thang, int nam)
        {

            base.nhap(hoten, diachi, sdt, ngaysinh);
            this.MaDG = madg;
            this.Email = email;
            NgayLapThe = new iDate();
            this.NgayLapThe.ngay = ngay;
            this.NgayLapThe.thang = thang;
            this.NgayLapThe.nam = nam;
        }
        public void nhap(string madg,string hoten, string diachi, string sdt, string email,string ngaysinh,int ngay,int thang,int nam)
        {
            base.nhap(hoten, diachi, sdt, ngaysinh);
            this.MaDG = madg;
            this.Email = email;
            NgayLapThe = new iDate();
            this.NgayLapThe.ngay = ngay;
            this.NgayLapThe.thang = thang;
            this.NgayLapThe.nam = nam;
         

        }
    }
}
