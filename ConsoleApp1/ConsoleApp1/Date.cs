using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
   public class Date
    {
        public int iNgay { get; set; }

        public int iThang { get; set; }

        public int iNam { get; set; }
        public Date()
        {

        }
        public Date(int iNgay, int iThang, int iNam)
        {
            this.iNgay = iNgay;
            this.iThang = iThang;
            this.iNam = iNam;
        }
        public static bool operator ==(Date a, Date b)
        {
            return a.iNgay == b.iNgay && a.iThang == b.iThang && a.iNam == b.iNam;
        }
        public static bool operator !=(Date a, Date b)
        {
            return a.iNgay != b.iNgay || a.iThang != b.iThang || a.iNam != b.iNam;
        }
        public static bool operator >(Date a, Date b)
        {
            return (a.iNam > b.iNam) || (a.iNam == b.iNam && a.iThang > b.iThang) || (a.iNam == b.iNam && a.iThang == b.iThang && a.iNgay > b.iNgay);
        }
        public static bool operator <(Date a, Date b)
        {
            return (a.iNam < b.iNam) || (a.iNam == b.iNam && a.iThang < b.iThang) || (a.iNam == b.iNam && a.iThang == b.iThang && a.iNgay < b.iNgay);
        }
        public static bool operator >=(Date a, Date b)
        {
            return (a.iNam >= b.iNam) || (a.iNam == b.iNam && a.iThang >= b.iThang) || (a.iNam == b.iNam && a.iThang == b.iThang && a.iNgay >= b.iNgay);
        }
        public static bool operator <=(Date a, Date b)
        {
            return (a.iNam <= b.iNam) || (a.iNam == b.iNam && a.iThang <= b.iThang) || (a.iNam == b.iNam && a.iThang == b.iThang && a.iNgay <= b.iNgay);
        }
        public static Date operator +(Date a, int b)
        {
            int t;
            t = a.iNgay + b;
            a.iThang += t / 30;
            a.iNgay = t % 30;
            if (a.iThang > 12)
            {
                a.iThang = a.iThang % 12;
                a.iNam++;
            }
            return a;
        }
        public static Date operator -(Date a, int b)
        {
            Date c = new Date();
            c.iNgay = a.iNgay - b;
            c.iThang = a.iThang;
            c.iNam = a.iNam;

            while (c.iNgay <= 0)
            {
                c.iNgay = c.iNgay + 30;
                c.iThang--;
            }
            //a.iNgay = (30 - t)/30;
            while (c.iThang <= 0)
            {
                c.iThang = 12 - c.iThang;
                c.iNam--;
            }
            return c;
        }
        public static Date operator --(Date a)
        {
            a = a - 1;
            return a;
        }
        public static Date operator ++(Date a)
        {
            a = a + 1;
            return a;
        }
        public static explicit operator string(Date a)
        {
            string kq = (string)(a.iNgay + "/" + a.iThang + "/" + a.iNam);
            return kq;
        }

    }
}
