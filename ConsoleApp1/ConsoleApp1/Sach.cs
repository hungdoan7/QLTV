using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    public abstract class Sach
    { 
        public string sMaSach;
        public string sTua;
        public string sNXB;
        public string sTacGia;
        public double dGia;
        public int iSoLuong;
        public double dThanhTien;

        public  Sach(string MaSach, string Tua, string NXB, string TacGia, double Gia, int SoLuong)
        {
            this.sMaSach = MaSach;
            this.sTua = Tua;
            this.sNXB = NXB;
            this.sTacGia = TacGia;
            this.dGia = Gia;
            this.iSoLuong = SoLuong;
        }
        
		public void Nhap()
		{
			Console.WriteLine(" Nhap vao tua sach: ");
			this.sMaSach = Console.ReadLine();
			Console.WriteLine(" Nhap vao NXB: ");
			this.sNXB = Console.ReadLine();
			Console.WriteLine(" Nhap vao tac gia: ");
			this.sTacGia = Console.ReadLine();
			Console.WriteLine(" Nhap vao gia: ");
			string Temp = Console.ReadLine();
			this.dGia= Convert.ToDouble(Temp);
			Console.WriteLine(" Nhap vao so luong: ");
			Temp = Console.ReadLine();
			this.dGia = Convert.ToInt32(Temp);
		}


		public abstract void TinhThanhTien();
	}
}
