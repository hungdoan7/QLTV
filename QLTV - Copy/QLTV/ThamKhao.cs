using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
   public class ThamKhao : Sach
    {
        public string Quocgia;
        public ThamKhao() : base()
        {

        }
        public void nhap(string masach, string tua, string nxb, string tacgia, int gia, string quocgia,int soluong)
        {
            base.nhap(masach, tua, nxb, tacgia, gia,soluong);
            this.Quocgia = quocgia;
        }
    }
}
