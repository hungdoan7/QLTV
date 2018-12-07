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
        //public static bool operator ==(Date a, Date b)
        //{
        //    return a.iNgay == b.iNgay && a.iThang == b.iThang && a.iNam == b.iNam;
        //}
        //public static bool operator !=(Date a, Date b)
        //{
        //    return a.iNgay != b.iNgay || a.iThang != b.iThang || a.iNam != b.iNam;
        //}
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
		public static int operator -(Date a, Date b)
		{
			int SoLuongNgay = 0;
			if (a.iNam == b.iNam)
			{
				if (a.iThang == b.iThang)
				{
					SoLuongNgay = a.iNgay - b.iNgay;
				}
				else
				{
					SoLuongNgay = (30 - b.iNgay) + ((a.iThang - b.iThang - 1) * 30) + a.iNgay;
				}
			}
			else
			{
				SoLuongNgay = ((12 - b.iThang) * 30) + (30 - b.iNgay) + ((a.iThang-1) * 30) + a.iNgay + ((a.iNam - b.iNam - 1) * 365);
			}
			return SoLuongNgay;
		}
		public static Date operator + (Date a, int b)
        {
			Date c = new Date();
			c.iNgay = a.iNgay;
			c.iThang = a.iThang;
			c.iNam = a.iNam;
            int t;
            t = c.iNgay + b;
            c.iThang += t / 30;
            c.iNgay = t % 30;
            if (c.iThang > 12)
            {
                c.iThang = c.iThang % 12;
                c.iNam++;
            }
            return c;
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
