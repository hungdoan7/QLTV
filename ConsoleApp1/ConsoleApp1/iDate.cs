using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
   public class iDate
    {
        public int ngay { get; set; }

        public int thang { get; set; }

        public int nam { get; set; }
        public iDate()
        {

        }
        public iDate(int Ngay, int Thang, int Nam)
        {
            this.ngay = Ngay;
            this.thang = Thang;
            this.nam = Nam;
        }
        public static bool operator ==(iDate a, iDate b)
        {
            return a.ngay == b.ngay && a.thang == b.thang && a.nam == b.nam;
        }
        public static bool operator !=(iDate a, iDate b)
        {
            return a.ngay != b.ngay || a.thang != b.thang || a.nam != b.nam;
        }
        public static bool operator >(iDate a, iDate b)
        {
            return (a.nam > b.nam) || (a.nam == b.nam && a.thang > b.thang) || (a.nam == b.nam && a.thang == b.thang && a.ngay > b.ngay);
        }
        public static bool operator <(iDate a, iDate b)
        {
            return (a.nam < b.nam) || (a.nam == b.nam && a.thang < b.thang) || (a.nam == b.nam && a.thang == b.thang && a.ngay < b.ngay);
        }
        public static bool operator >=(iDate a, iDate b)
        {
            return (a.nam >= b.nam) || (a.nam == b.nam && a.thang >= b.thang) || (a.nam == b.nam && a.thang == b.thang && a.ngay >= b.ngay);
        }
        public static bool operator <=(iDate a, iDate b)
        {
            return (a.nam <= b.nam) || (a.nam == b.nam && a.thang <= b.thang) || (a.nam == b.nam && a.thang == b.thang && a.ngay <= b.ngay);
        }
        public static iDate operator +(iDate a, int b)
        {
            int t;
            t = a.ngay + b;
            a.thang += t / 30;
            a.ngay = t % 30;
            if (a.thang > 12)
            {
                a.thang = a.thang % 12;
                a.nam++;
            }
            return a;
        }
        public static iDate operator -(iDate a, int b)
        {
            iDate c = new iDate();
            c.ngay = a.ngay - b;
            c.thang = a.thang;
            c.nam = a.nam;

            while (c.ngay <= 0)
            {
                c.ngay = c.ngay + 30;
                c.thang--;
            }
            //a.ngay = (30 - t)/30;
            while (c.thang <= 0)
            {
                c.thang = 12 - c.thang;
                c.nam--;
            }
            return c;
        }
        public static iDate operator --(iDate a)
        {
            a = a - 1;
            return a;
        }
        public static iDate operator ++(iDate a)
        {
            a = a + 1;
            return a;
        }
        public static explicit operator string(iDate a)
        {
            string kq = (string)(a.ngay + "/" + a.thang + "/" + a.nam);
            return kq;
        }

    }
}
