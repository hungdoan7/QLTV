using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
 public   class NhanVien:Nguoi
    {
        public string MaNV;
        public string ChucVu;
        public string BoPhan;
        public NhanVien():base()
        {

        }
        public void nhap(string manv, string hoten, string diachi, string sdt, string ngaysinh,string chucvu,string bophan)
        {
            base.nhap(hoten, diachi, sdt, ngaysinh);
            this.MaNV = manv;
            this.ChucVu = chucvu;
            this.BoPhan = bophan;
        }

    }
}
