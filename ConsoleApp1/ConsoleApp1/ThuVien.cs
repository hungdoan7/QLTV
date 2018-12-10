using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
	class ThuVien
	{

		private List<DauSachKhoaHoc> lDSDauSachKH;
		private List<DauSachGiaoTrinh> lDSDauSachGT;
		private List<DocGia> lDSDocGia;
		private List<NhanVien> lDSNhanVien;
		private List<HopDongMuon> lDSHopDongMuon;
		private Date dtToday;
		

		public List<DauSachKhoaHoc> DSDauSachKH { get => lDSDauSachKH; set => lDSDauSachKH = value; }
		public List<DauSachGiaoTrinh> DSDauSachGT { get => lDSDauSachGT; set => lDSDauSachGT = value; }
		public List<HopDongMuon> DSHopDongMuon { get => lDSHopDongMuon; set => lDSHopDongMuon = value; }
		public List<DocGia> DSDocGia { get => lDSDocGia; set => lDSDocGia = value; }
		public List<NhanVien> DSNhanVien { get => lDSNhanVien; set => lDSNhanVien = value; }
		public Date Today { get => dtToday; set => dtToday = value; }

		public ThuVien()
		{
			this.lDSDauSachKH = new List<DauSachKhoaHoc>();
			this.lDSDauSachGT = new List<DauSachGiaoTrinh>();
			this.lDSDocGia = new List<DocGia>();
			this.lDSNhanVien = new List<NhanVien>();
			this.lDSHopDongMuon = new List<HopDongMuon>();
			this.dtToday = new Date();
		}
		public void NhapNgayHomNay()
		{
			Console.WriteLine("Vui long nhap vao ngay hom nay: ");
			Console.Write("Ngay: ");

			this.dtToday.Ngay = Convert.ToInt32(Console.ReadLine());
			Console.Write("Thang: ");

			this.dtToday.Thang = Convert.ToInt32(Console.ReadLine());
			Console.Write("Nam: ");

			this.dtToday.Nam = Convert.ToInt32(Console.ReadLine());
		}
		public void NhapThuVien()
		{
			NhapNgayHomNay();

			NhanVien nv = new NhanVien(1, "Doan Van Nga", "HCM", "0123432534", 12, 3, 1993, 0, 1500000,25);
			this.lDSNhanVien.Add(nv);
			nv = new NhanVien(2, "Nguyen Thi Tuyet Mai", "HCM", "01234356594", 18, 5, 1994, 1, 1500000,26);
			this.lDSNhanVien.Add(nv);


			DauSachKhoaHoc Temp1 = new DauSachKhoaHoc("KH101", "Cac nguyen to hoa hoc", "DHQG", "Nguyen Van A", 10000, "Hoa hoc");
			QuyenSachKhoaHoc Temp2 = new QuyenSachKhoaHoc("KH101", "Cac nguyen to hoa hoc", "DHQG", "Nguyen Van A", 10000, "Hoa hoc", 1);
			Temp1.DSQuyenSach.Add(Temp2);
			Temp1.SoLuongTrongThuVien++;
			Temp2 = new QuyenSachKhoaHoc("KH101", "Cac nguyen to hoa hoc", "DHQG", "Nguyen Van A", 100000, "Hoa hoc", 2);
			Temp1.DSQuyenSach.Add(Temp2);
			Temp1.SoLuongTrongThuVien++;
			this.lDSDauSachKH.Add(Temp1);

			Temp1 = new DauSachKhoaHoc("KH102", "Cac thuyet tien hoa", "DHQG", "Nguyen Van C", 10000, "Sinh hoc");
			Temp2 = new QuyenSachKhoaHoc("KH102", "Cac thuyet tien hoa", "DHQG", "Nguyen Van C", 10000, "Sinh hoc", 3);
			Temp1.DSQuyenSach.Add(Temp2);
			Temp1.SoLuongTrongThuVien++;
			Temp2 = new QuyenSachKhoaHoc("KH102", "Cac thuyet tien hoa", "DHQG", "Nguyen Van C", 10000, "Sinh hoc", 4);
			Temp1.DSQuyenSach.Add(Temp2);
			Temp1.SoLuongTrongThuVien++;
			this.lDSDauSachKH.Add(Temp1);

			Temp1 = new DauSachKhoaHoc("KH103", "Song luong tu", "SPKT", "Nguyen Thi Kha", 15000, "Vat Ly");
			Temp2 = new QuyenSachKhoaHoc("KH103", "Song luong tu", "SPKT", "Nguyen Thi Kha", 15000, "Vat Ly", 3);
			Temp1.DSQuyenSach.Add(Temp2);
			Temp1.SoLuongTrongThuVien++;
			Temp2 = new QuyenSachKhoaHoc("KH103", "Song luong tu", "SPKT", "Nguyen Thi Kha", 15000, "Vat Ly", 4);
			Temp1.DSQuyenSach.Add(Temp2);
			Temp1.SoLuongTrongThuVien++;
			this.lDSDauSachKH.Add(Temp1);


			DauSachGiaoTrinh Temp3 = new DauSachGiaoTrinh("GT101", "Cau truc du lieu va giai thuat", "SPKT", "Nguyen Van B", 20000, "CTDL");
			QuyenSachGiaoTrinh Temp4 = new QuyenSachGiaoTrinh("GT101", "Cau truc du lieu va giai thuat", "SPKT", "Nguyen Van B", 20000, "CTDL", 1, 1);
			Temp3.DSQuyenSach.Add(Temp4);
			Temp3.SoLuongTrongThuVien++;
			Temp4 = new QuyenSachGiaoTrinh("GT101", "Cau truc du lieu va giai thuat", "SPKT", "Nguyen Van B", 20000, "CTDL", 1, 2);
			Temp3.DSQuyenSach.Add(Temp4);
			Temp3.SoLuongTrongThuVien++;
			this.lDSDauSachGT.Add(Temp3);

			Temp3 = new DauSachGiaoTrinh("GT102", "Co so du lieu", "SPKT", "Nguyen Van A", 20000, "CSDL");
			Temp4 = new QuyenSachGiaoTrinh("GT102", "Co so du lieu", "SPKT", "Nguyen Van A", 20000, "CSDL", 1, 1);
			Temp3.DSQuyenSach.Add(Temp4);
			Temp3.SoLuongTrongThuVien++;
			Temp4 = new QuyenSachGiaoTrinh("GT102", "Co so du lieu", "SPKT", "Nguyen Van A", 20000, "CSDL", 0, 2);
			Temp3.DSQuyenSach.Add(Temp4);
			Temp3.SoLuongTrongThuVien++;
			this.lDSDauSachGT.Add(Temp3);

			Temp3 = new DauSachGiaoTrinh("GT103", "Ky Thuat lap trinh", "DHQG", "Nguyen Thi C", 20000, "KTLT");
			Temp4 = new QuyenSachGiaoTrinh("GT103", "Ky Thuat Lap Trinh", "DHQG", "Nguyen Thi C", 20000, "KTLT", 0, 1);
			Temp3.DSQuyenSach.Add(Temp4);
			Temp3.SoLuongTrongThuVien++;
			Temp4 = new QuyenSachGiaoTrinh("GT103", "KyThuatLapTrinh", "DHQG", "Nguyen Thi C", 20000, "KTLT", 1, 2);
			Temp3.DSQuyenSach.Add(Temp4);
			Temp3.SoLuongTrongThuVien++;
			this.lDSDauSachGT.Add(Temp3);

			DocGia Temp5 = new DocGia(1, "Nguyen Huynh Anh Truc ", "HCM", "0167723899", 1, 1, 1999, "Truc@mail", 10, 2, 2019, 100000);
			this.lDSDocGia.Add(Temp5);
			Temp5 = new DocGia(2, "Nguyen Minh Thanh ", "HCM", "01645513518", 1, 4, 1999, "Thanh@mail", 25, 11, 2018, 120000);
			this.lDSDocGia.Add(Temp5);
			Temp5 = new DocGia(3, "Nguyen Khac Hoang Phi ", "VT", "01645513518", 1, 3, 1999, "Phi@mail", 30, 12, 2018, 150000);
			this.lDSDocGia.Add(Temp5);
			Temp5 = new DocGia(4, "Doan Quoc Hung ", "HN", "01628953485", 24, 7, 1999, "Hung@mail", 6, 12, 2018, 120000);
			this.lDSDocGia.Add(Temp5);
			
		}

		public void NhapHDMuon()
		{
			//Hop dong co san thu 1		
			HopDongMuon Temp = new HopDongMuon();
			Temp.NguoiMuon = this.DSDocGia[0];

			Temp.DSSachGTMuon.Add(this.DSDauSachGT[0].DSQuyenSach[0]);
			Temp.SoLuongSachMuon++;
			this.DSDauSachGT[0].DSQuyenSach[0].DaMuonHayChua = false;
			this.lDSDauSachGT[0].DSQuyenSach[0].NgayMuon = (Temp.NguoiMuon.NgayHetHanThe - 50);
			this.lDSDauSachGT[0].DSQuyenSach[0].XDNgayTra();
			this.DSDauSachGT[0].SoLuongTrongThuVien--;

			Temp.DSSachKHMuon.Add(this.DSDauSachKH[0].DSQuyenSach[0]);
			Temp.SoLuongSachMuon++;
			this.DSDauSachKH[0].DSQuyenSach[0].DaMuonHayChua = false;
			this.DSDauSachKH[0].DSQuyenSach[0].NgayMuon = (Temp.NguoiMuon.NgayHetHanThe - 29);
			this.lDSDauSachKH[0].DSQuyenSach[0].XDNgayTra();
			this.DSDauSachKH[0].SoLuongTrongThuVien--;

			this.DSHopDongMuon.Add(Temp);


			//Hop dong co san thu 2
			Temp = new HopDongMuon();
			Temp.NguoiMuon = this.DSDocGia[1];

			Temp.DSSachGTMuon.Add(this.DSDauSachGT[1].DSQuyenSach[1]);
			Temp.SoLuongSachMuon++;
			this.DSDauSachGT[1].DSQuyenSach[1].DaMuonHayChua = false;
			this.lDSDauSachGT[1].DSQuyenSach[1].NgayMuon = (Temp.NguoiMuon.NgayHetHanThe - 170);
			this.lDSDauSachGT[1].DSQuyenSach[1].XDNgayTra();
			this.DSDauSachGT[1].SoLuongTrongThuVien--;

			Temp.DSSachKHMuon.Add(this.DSDauSachKH[2].DSQuyenSach[1]);
			Temp.SoLuongSachMuon++;
			this.DSDauSachKH[2].DSQuyenSach[1].DaMuonHayChua = false;
			this.lDSDauSachKH[2].DSQuyenSach[1].NgayMuon = (Temp.NguoiMuon.NgayHetHanThe - 20);
			this.lDSDauSachKH[2].DSQuyenSach[1].XDNgayTra();
			this.DSDauSachKH[2].SoLuongTrongThuVien--;

			Temp.DSSachKHMuon.Add(this.DSDauSachKH[1].DSQuyenSach[0]);
			Temp.SoLuongSachMuon++;
			this.DSDauSachKH[1].DSQuyenSach[0].DaMuonHayChua = false;
			this.lDSDauSachKH[1].DSQuyenSach[0].NgayMuon = (Temp.NguoiMuon.NgayHetHanThe - 15);
			this.lDSDauSachKH[1].DSQuyenSach[0].XDNgayTra();
			this.DSDauSachKH[1].SoLuongTrongThuVien--;

			this.DSHopDongMuon.Add(Temp);

			//Hop dong co san thu 3
			Temp = new HopDongMuon();
			Temp.NguoiMuon = this.DSDocGia[2];
			this.DSHopDongMuon.Add(Temp);

			//Hop dong co san thu 4
			Temp = new HopDongMuon();
			Temp.NguoiMuon = this.DSDocGia[3];

			Temp.DSSachGTMuon.Add(this.DSDauSachGT[2].DSQuyenSach[1]);
			Temp.SoLuongSachMuon++;
			this.DSDauSachGT[2].DSQuyenSach[1].DaMuonHayChua = false;
			this.lDSDauSachGT[2].DSQuyenSach[1].NgayMuon = (Temp.NguoiMuon.NgayHetHanThe - 70);
			this.lDSDauSachGT[2].DSQuyenSach[1].XDNgayTra();
			this.DSDauSachGT[2].SoLuongTrongThuVien--;

			this.DSHopDongMuon.Add(Temp);


		}
		public void TraSach(int ViTri, String MaSach, int MaQuyen)
		{
			int VT_Temp = KiemTraViTriSachGT(MaSach);
			if (VT_Temp != -1)
			{
				for (int i = 0; i < this.lDSDauSachGT[VT_Temp].DSQuyenSach.Count; i++)
				{
					if (this.lDSDauSachGT[VT_Temp].DSQuyenSach[i].MaQuyenSach == MaQuyen)
					{
						this.lDSDauSachGT[VT_Temp].DSQuyenSach[i].TraSach();
						this.lDSDauSachGT[VT_Temp].SoLuongTrongThuVien++;
						this.lDSHopDongMuon[ViTri].DSSachGTMuon.Remove(this.lDSDauSachGT[VT_Temp].DSQuyenSach[i]);
						this.lDSHopDongMuon[ViTri].SoLuongSachMuon--;
						Console.WriteLine(" Tra thanh cong: ");
					}
				}
			}
			else
			{
				VT_Temp = KiemTraViTriSachKH(MaSach);
				for (int i = 0; i < this.lDSDauSachKH[VT_Temp].DSQuyenSach.Count; i++)
				{
					if (this.lDSDauSachKH[VT_Temp].DSQuyenSach[i].MaQuyenSach == MaQuyen)
					{
						this.lDSDauSachKH[VT_Temp].DSQuyenSach[i].TraSach();
						this.lDSDauSachKH[VT_Temp].SoLuongTrongThuVien++;
						this.lDSHopDongMuon[ViTri].DSSachKHMuon.Remove(this.lDSDauSachKH[VT_Temp].DSQuyenSach[i]);
						this.lDSHopDongMuon[ViTri].SoLuongSachMuon--;
						Console.WriteLine(" Tra thanh cong: ");
					}
				}
			}
		}
		public void ThongTinDocGiaTrongHD(int ViTri)
		{
			XacDinhLai1Nguoi(ViTri);
			this.lDSHopDongMuon[ViTri].NguoiMuon.Xuat();

			Console.WriteLine("So luong sach muon: " + this.lDSHopDongMuon[ViTri].SoLuongSachMuon);
			Console.WriteLine("Bao gom: \n");
			for (int i = 0; i < this.lDSHopDongMuon[ViTri].DSSachGTMuon.Count; i++)
			{
				this.lDSHopDongMuon[ViTri].DSSachGTMuon[i].Xuat();
				Console.Write("\n\n");
			}
			for (int i = 0; i < this.lDSHopDongMuon[ViTri].DSSachKHMuon.Count; i++)
			{
				this.lDSHopDongMuon[ViTri].DSSachKHMuon[i].Xuat();
				Console.Write("\n\n");
			}
		}
		public void XuatDSSachConTrongThuVien()
		{
			Console.WriteLine("\n DS sach con lai trong thu vien \n");
			Console.WriteLine(" Con lai " + XacDinhSoLuongSachTrongTV() + " cuon sach\n");
			for (int i = 0; i < this.lDSDauSachKH.Count; i++)
			{
				for (int j = 0; j < this.DSDauSachKH[i].DSQuyenSach.Count; j++)
				{
					if (this.DSDauSachKH[i].DSQuyenSach[j].DaMuonHayChua == true)
					{
						this.DSDauSachKH[i].DSQuyenSach[j].Xuat();
						Console.Write("\n\n");
					}
				}
			}
			for (int i = 0; i < this.DSDauSachGT.Count; i++)
			{
				for (int j = 0; j < this.DSDauSachGT[i].DSQuyenSach.Count; j++)
				{
					if (this.DSDauSachGT[i].DSQuyenSach[j].DaMuonHayChua == true)
					{
						this.DSDauSachGT[i].DSQuyenSach[j].Xuat();
						Console.Write("\n\n");
					}
				}
			}
		}
		public void MuonSach(int ViTriDocGia)
		{
			Console.Write("Ban muon muon sach khoa hoc hay sach giao trinh (0 la KH, 1 la GT): ");
			int KHhayGT = Convert.ToInt32(Console.ReadLine());
			if (KHhayGT == 0)
			{
				if (this.dtToday < this.lDSHopDongMuon[ViTriDocGia].NguoiMuon.NgayHetHanThe)
				{
					if ((this.lDSHopDongMuon[ViTriDocGia].NguoiMuon.NgayHetHanThe- this.dtToday) <= 30)
					{
						Console.WriteLine(" Khong du dieu kien thoi gian de muon sach KH ( the chi con hieu luc duoi 1 thang ), can gia han the ");
						return;
					}
				}
				Console.WriteLine("Nhap ma dau sach hoac tua sach: ");
				string Temp_NhapMaTuaSach = Console.ReadLine();
				for (int h = 0; h < this.lDSHopDongMuon[ViTriDocGia].DSSachKHMuon.Count; h++)
				{
					if (this.lDSHopDongMuon[ViTriDocGia].DSSachKHMuon[h].MaDauSach == Temp_NhapMaTuaSach || this.lDSHopDongMuon[ViTriDocGia].DSSachKHMuon[h].Tua == Temp_NhapMaTuaSach)
					{
						Console.WriteLine(" Ban da muon 1 cuon sach cung dang ma chua tra, Khong the muon tiep, Tra cuon sach cu de tiep tuc muon cuon moi nay ");
						return;
					}
				}
				int Temp_ViTriDauSach = KiemTraViTriSachKH(Temp_NhapMaTuaSach);
				if (Temp_ViTriDauSach != -1)
				{
					if (this.lDSDauSachKH[Temp_ViTriDauSach].SoLuongTrongThuVien > 0)
					{
						int Temp_ViTriSachRong = TimSachKHChuaDuocMuon(Temp_ViTriDauSach);
						this.lDSHopDongMuon[ViTriDocGia].DSSachKHMuon.Add(this.lDSDauSachKH[Temp_ViTriDauSach].DSQuyenSach[Temp_ViTriSachRong]);
						this.lDSDauSachKH[Temp_ViTriDauSach].DSQuyenSach[Temp_ViTriSachRong].MuonNgayHomNay(this.dtToday);
						this.lDSDauSachKH[Temp_ViTriDauSach].SoLuongTrongThuVien--;
						this.lDSHopDongMuon[ViTriDocGia].SoLuongSachMuon++;
						Console.WriteLine("Muon thanh cong");
					}
					else
					{
						Console.WriteLine("Thu vien da het sach tua do");
						return;
					}
				}
				else
				{
					Console.WriteLine(" Ma dau sach chua ton tai hoac nhap chua dung! ");
					return;
				}
			}
			else
			{
				if (this.dtToday < this.lDSHopDongMuon[ViTriDocGia].NguoiMuon.NgayHetHanThe)
				{
					if ((this.lDSHopDongMuon[ViTriDocGia].NguoiMuon.NgayHetHanThe - this.dtToday) <= 60)
					{
						Console.WriteLine(" Khong du dieu kien thoi gian de muon sach GT ( the chi con hieu luc duoi 2 thang ), can gia han the ");
						return;
					}
				}
				Console.WriteLine("Nhap ma dau sach hoac tua sach: ");
				string Temp_NhapMaTuaSach = Console.ReadLine();
				for (int h = 0; h < this.lDSHopDongMuon[ViTriDocGia].DSSachGTMuon.Count; h++)
				{
					if (this.lDSHopDongMuon[ViTriDocGia].DSSachGTMuon[h].MaDauSach == Temp_NhapMaTuaSach || this.lDSHopDongMuon[ViTriDocGia].DSSachGTMuon[h].Tua == Temp_NhapMaTuaSach)
					{
						Console.WriteLine(" Ban da muon 1 cuon sach cung dang ma chua tra, Khong the muon tiep, Tra cuon sach cu de tiep tuc muon cuon moi nay ");
						return;
					}		
				}
				int Temp_ViTriDauSach = KiemTraViTriSachGT(Temp_NhapMaTuaSach);
				if (Temp_ViTriDauSach != -1)
				{
					if (this.lDSDauSachGT[Temp_ViTriDauSach].SoLuongTrongThuVien > 0)
					{
						int Temp_ViTriSachRong = TimSachGTChuaDuocMuon(Temp_ViTriDauSach);
						this.lDSHopDongMuon[ViTriDocGia].DSSachGTMuon.Add(this.lDSDauSachGT[Temp_ViTriDauSach].DSQuyenSach[Temp_ViTriSachRong]);
						this.lDSDauSachGT[Temp_ViTriDauSach].DSQuyenSach[Temp_ViTriSachRong].MuonNgayHomNay(this.dtToday);
						this.lDSDauSachGT[Temp_ViTriDauSach].SoLuongTrongThuVien--;
						this.lDSHopDongMuon[ViTriDocGia].SoLuongSachMuon++;
						Console.WriteLine("Muon thanh cong");
						return;
					}
					else
					{
						Console.WriteLine("Thu vien da het sach tua do");
						return;
					}
				}
				else
				{
					Console.WriteLine(" Ma dau sach chua ton tai hoac nhap chua dung ");
					return;
				}
			}
		}
		public void CapNhatLai()
		{
			for (int a = 0; a < this.lDSHopDongMuon.Count; a++)
			{
				for (int b = 0; b < this.lDSHopDongMuon[a].DSSachGTMuon.Count; b++)
				{
					if ((this.lDSHopDongMuon[a].DSSachGTMuon[b].NgayPhaiTra < this.dtToday) == true)
					{
						if ((this.dtToday - this.lDSHopDongMuon[a].DSSachGTMuon[b].NgayPhaiTra) > 30)
						{
							this.lDSHopDongMuon[a].NguoiMuon.TaiKhoan -= this.lDSHopDongMuon[a].DSSachGTMuon[b].ThanhTien;

							int Temp = KiemTraViTriSachGT(this.lDSHopDongMuon[a].DSSachGTMuon[b].MaDauSach);
							for (int c = 0; c < this.lDSDauSachGT[Temp].DSQuyenSach.Count; c++)
							{
								if (this.lDSDauSachGT[Temp].DSQuyenSach[c].MaQuyenSach == this.lDSHopDongMuon[a].DSSachGTMuon[b].MaQuyenSach)
								{
									Console.Write("Doc gia " + this.lDSHopDongMuon[a].NguoiMuon.HoTen + "lam mat sach nen xoa 1 cuon sach " + this.lDSHopDongMuon[a].DSSachGTMuon[b].Tua + "\n");
									this.lDSDauSachGT[a].DSQuyenSach.Remove(this.lDSHopDongMuon[a].DSSachGTMuon[b]);
									this.lDSDauSachGT[a].SoLuongTrongThuVien--;
									this.lDSHopDongMuon[a].DSSachGTMuon.Remove(this.lDSHopDongMuon[a].DSSachGTMuon[b]);
									this.lDSHopDongMuon[a].SoLuongSachMuon--;
									break;
								}
							}
						}
						else
						{
							Console.Write("Doc gia " + this.lDSHopDongMuon[a].NguoiMuon.HoTen + "co muon 1 cuon sach " + this.lDSHopDongMuon[a].DSSachGTMuon[b].Tua + " sap toi han tra\n");
						}
					}
				}
				for (int b = 0; b < this.lDSHopDongMuon[a].DSSachKHMuon.Count; b++)
				{
					if ((this.lDSHopDongMuon[a].DSSachKHMuon[b].NgayPhaiTra < this.dtToday) == true)
					{
						if ((this.dtToday - this.lDSHopDongMuon[a].DSSachKHMuon[b].NgayPhaiTra) > 30)
						{
							this.lDSHopDongMuon[a].NguoiMuon.TaiKhoan -= this.lDSHopDongMuon[a].DSSachKHMuon[b].ThanhTien;

							int Temp = KiemTraViTriSachKH(this.lDSHopDongMuon[a].DSSachKHMuon[b].MaDauSach);
							for (int c = 0; c < this.lDSDauSachKH[Temp].DSQuyenSach.Count; c++)
							{
								if (this.lDSDauSachKH[Temp].DSQuyenSach[c].MaQuyenSach == this.lDSHopDongMuon[a].DSSachKHMuon[b].MaQuyenSach)
								{
									Console.Write("doc gia " + this.lDSHopDongMuon[a].NguoiMuon.HoTen + "lam mat sach nen xoa 1 cuon sach " + this.lDSHopDongMuon[a].DSSachKHMuon[b].Tua + "\n");
									this.lDSDauSachKH[a].DSQuyenSach.Remove(this.lDSHopDongMuon[a].DSSachKHMuon[b]);
									this.lDSDauSachKH[a].SoLuongTrongThuVien--;
									this.lDSHopDongMuon[a].DSSachKHMuon.Remove(this.lDSHopDongMuon[a].DSSachKHMuon[b]);
									this.lDSHopDongMuon[a].SoLuongSachMuon--;
									break;
								}
							}
						}
						else
						{
							Console.Write("Doc gia " + this.lDSHopDongMuon[a].NguoiMuon.HoTen + "co muon 1 cuon sach " + this.lDSHopDongMuon[a].DSSachKHMuon[b].Tua + " sap toi han tra\n");
						}
					}
				}
			}
		}
		public void XacDinhLai1Nguoi(int a)
		{
			for (int b = 0; b < this.lDSHopDongMuon[a].DSSachGTMuon.Count; b++)
			{
				if ((this.lDSHopDongMuon[a].DSSachGTMuon[b].NgayPhaiTra < this.dtToday) == true)
				{
					if ((this.dtToday - this.lDSHopDongMuon[a].DSSachGTMuon[b].NgayPhaiTra) > 30)
					{
						this.lDSHopDongMuon[a].NguoiMuon.TaiKhoan -= this.lDSHopDongMuon[a].DSSachGTMuon[b].ThanhTien;

						int Temp = KiemTraViTriSachGT(this.lDSHopDongMuon[a].DSSachGTMuon[b].MaDauSach);
						for (int c = 0; c < this.lDSDauSachGT[Temp].DSQuyenSach.Count; c++)
						{
							if (this.lDSDauSachGT[Temp].DSQuyenSach[c].MaQuyenSach == this.lDSHopDongMuon[a].DSSachGTMuon[b].MaQuyenSach)
							{
								Console.Write("Doc gia " + this.lDSHopDongMuon[a].NguoiMuon.HoTen + "lam mat sach nen xoa 1 cuon sach " + this.lDSHopDongMuon[a].DSSachGTMuon[b].Tua + "\n");
								this.lDSDauSachGT[a].DSQuyenSach.Remove(this.lDSHopDongMuon[a].DSSachGTMuon[b]);
								this.lDSDauSachGT[a].SoLuongTrongThuVien--;
								this.lDSHopDongMuon[a].DSSachGTMuon.Remove(this.lDSHopDongMuon[a].DSSachGTMuon[b]);
								this.lDSHopDongMuon[a].SoLuongSachMuon--;
								break;
							}
						}
					}
					else
					{
						Console.Write("Doc gia " + this.lDSHopDongMuon[a].NguoiMuon.HoTen + "co muon 1 cuon sach " + this.lDSHopDongMuon[a].DSSachGTMuon[b].Tua + " sap toi han tra\n");
					}
				}
			}
			for (int b = 0; b < this.lDSHopDongMuon[a].DSSachKHMuon.Count; b++)
			{
				if ((this.lDSHopDongMuon[a].DSSachKHMuon[b].NgayPhaiTra < this.dtToday) == true)
				{
					if ((this.dtToday - this.lDSHopDongMuon[a].DSSachKHMuon[b].NgayPhaiTra) > 30)
					{
						this.lDSHopDongMuon[a].NguoiMuon.TaiKhoan -= this.lDSHopDongMuon[a].DSSachKHMuon[b].ThanhTien;

						int Temp = KiemTraViTriSachKH(this.lDSHopDongMuon[a].DSSachKHMuon[b].MaDauSach);
						for (int c = 0; c < this.lDSDauSachKH[Temp].DSQuyenSach.Count; c++)
						{
							if (this.lDSDauSachKH[Temp].DSQuyenSach[c].MaQuyenSach == this.lDSHopDongMuon[a].DSSachKHMuon[b].MaQuyenSach)
							{
								Console.Write("Doc gia " + this.lDSHopDongMuon[a].NguoiMuon.HoTen + "lam mat sach nen xoa 1 cuon sach " + this.lDSHopDongMuon[a].DSSachKHMuon[b].Tua + "\n");
								this.lDSDauSachKH[a].DSQuyenSach.Remove(this.lDSHopDongMuon[a].DSSachKHMuon[b]);
								this.lDSDauSachKH[a].SoLuongTrongThuVien--;
								this.lDSHopDongMuon[a].DSSachKHMuon.Remove(this.lDSHopDongMuon[a].DSSachKHMuon[b]);
								this.lDSHopDongMuon[a].SoLuongSachMuon--;
								break;
							}
						}
					}
					else
					{
						Console.Write("Doc gia " + this.lDSHopDongMuon[a].NguoiMuon.HoTen + "co muon cuon 1 sach " + this.lDSHopDongMuon[a].DSSachKHMuon[b].Tua + " sap toi han tra\n");
					}
				}
			}
		}
		public void DangKyTaiKhoanMoi(Date Today)
		{
			DocGia NguoiDangKy = new DocGia();
			NguoiDangKy.Nhap();
			NguoiDangKy.MaDG = this.DSDocGia[this.DSDocGia.Count - 1].MaDG + 1; 
			NguoiDangKy.DangKyTaiKhoanMoi(Today);
			this.lDSDocGia.Add(NguoiDangKy);
			HopDongMuon Temp_HD = new HopDongMuon();
			Temp_HD.NguoiMuon = NguoiDangKy;
			this.lDSHopDongMuon.Add(Temp_HD);
		}
		public void DangKyNhanVienMoi()
		{
			NhanVien NguoiDangKy = new NhanVien();
			NguoiDangKy.Nhap();
			NguoiDangKy.MaNV = (this.DSNhanVien[this.DSNhanVien.Count - 1].MaNV + 1);
			this.lDSNhanVien.Add(NguoiDangKy);
		}
		public int KiemTraViTriDocGiaTrongListHD(string NhapVao)
		{
			for (int i = 0; i < this.lDSHopDongMuon.Count; i++)
			{
				if (this.lDSHopDongMuon[i].NguoiMuon.HoTen == NhapVao || this.lDSHopDongMuon[i].NguoiMuon.MaDG == Convert.ToInt32(NhapVao))
				{
					return i;
				}
			}
			return -1;
		}
		public int KiemTraViTriSachKH(string NhapVao)
		{
			for (int i = 0; i < this.lDSDauSachKH.Count; i++)
			{
				if (this.lDSDauSachKH[i].MaDauSach == NhapVao || this.lDSDauSachKH[i].Tua == NhapVao)
				{
					return i;
				}
			}
			return -1;
		}
		public int KiemTraViTriSachGT(string NhapVao)
		{
			for (int i = 0; i < this.lDSDauSachGT.Count; i++)
			{
				if (this.lDSDauSachGT[i].MaDauSach == NhapVao || this.lDSDauSachGT[i].Tua == NhapVao)
				{
					return i;
				}
			}
			return -1;
		}
		public int TimSachKHChuaDuocMuon(int ViTriDauSach)
		{
			for (int i = 0; i < this.lDSDauSachKH[ViTriDauSach].DSQuyenSach.Count; i++)
			{
				if (this.lDSDauSachKH[ViTriDauSach].DSQuyenSach[i].DaMuonHayChua == true)
				{
					return i;
				}
			}
			return -1;
		}
		public int TimSachGTChuaDuocMuon(int ViTriDauSach)
		{
			for (int i = 0; i < this.lDSDauSachGT[ViTriDauSach].DSQuyenSach.Count; i++)
			{
				if (this.lDSDauSachGT[ViTriDauSach].DSQuyenSach[i].DaMuonHayChua == true)
				{
					return i;
				}
			}
			return -1;
		}
		public int XacDinhSoLuongSachTrongTV()
		{
			int SoLuong = 0;
			for (int i = 0; i < this.lDSDauSachKH.Count; i++)
			{
				for (int j = 0; j < this.lDSDauSachKH[i].DSQuyenSach.Count; j++)
				{
					if (this.lDSDauSachKH[i].DSQuyenSach[j].DaMuonHayChua == true)
					{
						SoLuong++;
					}
				}
			}
			for (int i = 0; i < this.lDSDauSachGT.Count; i++)
			{
				for (int j = 0; j < this.lDSDauSachGT[i].DSQuyenSach.Count; j++)
				{
					if (this.lDSDauSachGT[i].DSQuyenSach[j].DaMuonHayChua == true)
					{
						SoLuong++;
					}
				}
			}
			return SoLuong;
		}
		public Date XacDinhToday()
		{
			return this.dtToday;
		}
		public void ThemSachGT(string MaDauSach)
		{
			int ViTriDauSach = KiemTraViTriSachGT(MaDauSach);
			if (ViTriDauSach != -1)
			{
				Console.WriteLine("Ban muon nhap vao thu vien bao nhieu quyen sach loai nay: ");
				int soluong = Convert.ToInt32(Console.ReadLine());
				int SoLuongBanDau = this.lDSDauSachGT[ViTriDauSach].DSQuyenSach.Count;
				int dem = 1;
				for (int i = SoLuongBanDau; i < SoLuongBanDau + soluong; i++)
				{

					Console.WriteLine("Cuon thu " + dem + " dinh them vao :");
					//Console.Write(" Nhap vao ma sach moi ");
					//string MaQuyen_Temp = Console.ReadLine();
					Console.Write(" Nhap vao trinh trang cuon sach:(0 la cu, 1 la moi): ");
					int TinhTrang_Temp = Convert.ToInt32(Console.ReadLine());
					QuyenSachGiaoTrinh QuyenSachGT_Temp = new QuyenSachGiaoTrinh();
					if (this.lDSDauSachKH[ViTriDauSach].DSQuyenSach.Count != 0)
					{
						QuyenSachGT_Temp = new QuyenSachGiaoTrinh(this.lDSDauSachGT[ViTriDauSach].MaDauSach, this.lDSDauSachGT[ViTriDauSach].Tua, this.lDSDauSachGT[ViTriDauSach].NXB, this.lDSDauSachGT[ViTriDauSach].TacGia, this.lDSDauSachGT[ViTriDauSach].Gia, this.lDSDauSachGT[ViTriDauSach].BoMon, TinhTrang_Temp, this.lDSDauSachGT[ViTriDauSach].DSQuyenSach[this.lDSDauSachGT[ViTriDauSach].DSQuyenSach.Count - 1].MaQuyenSach + 1);
					}
					else
					{
						 QuyenSachGT_Temp = new QuyenSachGiaoTrinh(this.lDSDauSachGT[ViTriDauSach].MaDauSach, this.lDSDauSachGT[ViTriDauSach].Tua, this.lDSDauSachGT[ViTriDauSach].NXB, this.lDSDauSachGT[ViTriDauSach].TacGia, this.lDSDauSachGT[ViTriDauSach].Gia, this.lDSDauSachGT[ViTriDauSach].BoMon, TinhTrang_Temp, 1);

					}
					this.lDSDauSachGT[ViTriDauSach].DSQuyenSach.Add(QuyenSachGT_Temp);
					this.lDSDauSachGT[ViTriDauSach].SoLuongTrongThuVien++;
					dem++;
				}
				Console.WriteLine(" Them thanh cong " + (dem - 1) + " sach co ma " + MaDauSach);
			}
			else
			{
				Console.WriteLine("Chua ton tai dau sach, xin moi them moi dau sach! ");
				DauSachGiaoTrinh DauSachGT_Temp = new DauSachGiaoTrinh();
				DauSachGT_Temp.Nhap();
				this.lDSDauSachGT.Add(DauSachGT_Temp);
				ViTriDauSach = KiemTraViTriSachGT(DauSachGT_Temp.MaDauSach);
				Console.WriteLine("Ban muon nhap vao thu vien bao nhieu quyen sach loai nay: ");
				int soluong = Convert.ToInt32(Console.ReadLine());
				int SoLuongBanDau = this.lDSDauSachGT[ViTriDauSach].DSQuyenSach.Count;
				int dem = 1;
				for (int i = SoLuongBanDau; i < SoLuongBanDau + soluong; i++)
				{

					Console.WriteLine("Cuon thu " + dem + " dinh them vao :");
					//Console.Write(" Nhap vao ma sach moi ");
					//string MaQuyen_Temp = Console.ReadLine();
					Console.Write(" Nhap vao trinh trang cuon sach:(0 la cu, 1 la moi): ");
					int TinhTrang_Temp = Convert.ToInt32(Console.ReadLine());
					QuyenSachGiaoTrinh QuyenSachGT_Temp = new QuyenSachGiaoTrinh();
					if (this.lDSDauSachGT[ViTriDauSach].DSQuyenSach.Count != 0)
					{
						QuyenSachGT_Temp = new QuyenSachGiaoTrinh(this.lDSDauSachGT[ViTriDauSach].MaDauSach, this.lDSDauSachGT[ViTriDauSach].Tua, this.lDSDauSachGT[ViTriDauSach].NXB, this.lDSDauSachGT[ViTriDauSach].TacGia, this.lDSDauSachGT[ViTriDauSach].Gia, this.lDSDauSachGT[ViTriDauSach].BoMon, TinhTrang_Temp, this.lDSDauSachGT[ViTriDauSach].DSQuyenSach[this.lDSDauSachGT[ViTriDauSach].DSQuyenSach.Count - 1].MaQuyenSach + 1);
					}
					else
					{
						QuyenSachGT_Temp = new QuyenSachGiaoTrinh(this.lDSDauSachGT[ViTriDauSach].MaDauSach, this.lDSDauSachGT[ViTriDauSach].Tua, this.lDSDauSachGT[ViTriDauSach].NXB, this.lDSDauSachGT[ViTriDauSach].TacGia, this.lDSDauSachGT[ViTriDauSach].Gia, this.lDSDauSachGT[ViTriDauSach].BoMon, TinhTrang_Temp, 1);
					}
					this.lDSDauSachGT[ViTriDauSach].DSQuyenSach.Add(QuyenSachGT_Temp);
					this.lDSDauSachGT[ViTriDauSach].SoLuongTrongThuVien++;
					dem++;
				}
				Console.WriteLine(" Them thanh cong " + (dem - 1) + " sach co ma " + MaDauSach);
			}
		}
		public void ThemSachKH(string MaDauSach)
		{
			int ViTriDauSach = KiemTraViTriSachKH(MaDauSach);
			if (ViTriDauSach != -1)
			{
				Console.WriteLine("Ban muon nhap vao thu vien bao nhieu quyen sach loai nay: ");
				int soluong = Convert.ToInt32(Console.ReadLine());
				int SoLuongBanDau = this.lDSDauSachKH[ViTriDauSach].DSQuyenSach.Count;
				int dem = 1;
				for (int i = SoLuongBanDau; i < SoLuongBanDau + soluong; i++)
				{

					Console.WriteLine("Cuon thu " + dem + " dinh them vao :");
					QuyenSachKhoaHoc QuyenSachKH_Temp = new QuyenSachKhoaHoc();
					if (this.lDSDauSachKH[ViTriDauSach].DSQuyenSach.Count != 0)
					{
					QuyenSachKH_Temp = new QuyenSachKhoaHoc(this.lDSDauSachKH[ViTriDauSach].MaDauSach, this.lDSDauSachKH[ViTriDauSach].Tua, this.lDSDauSachKH[ViTriDauSach].NXB, this.lDSDauSachKH[ViTriDauSach].TacGia, this.lDSDauSachKH[ViTriDauSach].Gia, this.lDSDauSachKH[ViTriDauSach].ChuyenNganh, this.lDSDauSachKH[ViTriDauSach].DSQuyenSach[this.lDSDauSachKH[ViTriDauSach].DSQuyenSach.Count - 1].MaQuyenSach + 1);
					}
					else
					{
					QuyenSachKH_Temp = new QuyenSachKhoaHoc(this.lDSDauSachKH[ViTriDauSach].MaDauSach, this.lDSDauSachKH[ViTriDauSach].Tua, this.lDSDauSachKH[ViTriDauSach].NXB, this.lDSDauSachKH[ViTriDauSach].TacGia, this.lDSDauSachKH[ViTriDauSach].Gia, this.lDSDauSachKH[ViTriDauSach].ChuyenNganh, 1);
					}
					this.lDSDauSachKH[ViTriDauSach].DSQuyenSach.Add(QuyenSachKH_Temp);
					this.lDSDauSachKH[ViTriDauSach].SoLuongTrongThuVien++;
					dem++;
				}
				Console.WriteLine(" Them thanh cong " + (dem - 1) + " sach co ma " + MaDauSach);
			}
			else
			{
				Console.WriteLine("Chua ton tai dau sach, xin moi them moi dau sach! ");
				DauSachKhoaHoc DauSachKH_Temp = new DauSachKhoaHoc();
				DauSachKH_Temp.Nhap();
				this.lDSDauSachKH.Add(DauSachKH_Temp);
				ViTriDauSach = KiemTraViTriSachKH(DauSachKH_Temp.MaDauSach);

				Console.WriteLine("Ban muon nhap vao thu vien bao nhieu quyen sach loai nay: ");
				int soluong = Convert.ToInt32(Console.ReadLine());
				int SoLuongBanDau = this.lDSDauSachKH[ViTriDauSach].DSQuyenSach.Count;
				int dem = 1;
				for (int i = SoLuongBanDau; i < SoLuongBanDau + soluong; i++)
				{

					Console.WriteLine("Cuon thu " + dem + " dinh them vao :");
					QuyenSachKhoaHoc QuyenSachKH_Temp = new QuyenSachKhoaHoc();
					if (this.lDSDauSachKH[ViTriDauSach].DSQuyenSach.Count != 0)
					{
						QuyenSachKH_Temp = new QuyenSachKhoaHoc(this.lDSDauSachKH[ViTriDauSach].MaDauSach, this.lDSDauSachKH[ViTriDauSach].Tua, this.lDSDauSachKH[ViTriDauSach].NXB, this.lDSDauSachKH[ViTriDauSach].TacGia, this.lDSDauSachKH[ViTriDauSach].Gia, this.lDSDauSachKH[ViTriDauSach].ChuyenNganh, this.lDSDauSachKH[ViTriDauSach].DSQuyenSach[this.lDSDauSachKH[ViTriDauSach].DSQuyenSach.Count - 1].MaQuyenSach + 1);
					}
					else
					{
						QuyenSachKH_Temp = new QuyenSachKhoaHoc(this.lDSDauSachKH[ViTriDauSach].MaDauSach, this.lDSDauSachKH[ViTriDauSach].Tua, this.lDSDauSachKH[ViTriDauSach].NXB, this.lDSDauSachKH[ViTriDauSach].TacGia, this.lDSDauSachKH[ViTriDauSach].Gia, this.lDSDauSachKH[ViTriDauSach].ChuyenNganh, 1);
					}
					this.lDSDauSachKH[ViTriDauSach].DSQuyenSach.Add(QuyenSachKH_Temp);
					this.lDSDauSachKH[ViTriDauSach].SoLuongTrongThuVien++;
					dem++;
				}
				Console.WriteLine(" Them thanh cong " + (dem - 1) + " sach co ma " + MaDauSach);
			}
		}
		public void XoaSachGT(string MaDauSach)
		{
			int ViTriDauSach = KiemTraViTriSachGT(MaDauSach);
			if (ViTriDauSach != -1)
			{
				Console.WriteLine("Ban muon xoa khoi thu vien bao nhieu quyen sach loai nay: ");
				int soluong = Convert.ToInt32(Console.ReadLine());
				if (soluong > this.lDSDauSachGT[ViTriDauSach].SoLuongTrongThuVien)
				{
					Console.WriteLine(" So luong sach con lai trong thu vien nho hon so sach ban muon xoa! ");
					return;
				}
				else
				{
					int dem = 0;
					int i = 0;
					do
					{
						int Temp = dem;
						if (this.lDSDauSachGT[ViTriDauSach].DSQuyenSach[i].DaMuonHayChua == false)
						{
							this.lDSDauSachGT[ViTriDauSach].DSQuyenSach.Remove(this.lDSDauSachGT[ViTriDauSach].DSQuyenSach[i]);
							this.lDSDauSachGT[ViTriDauSach].SoLuongTrongThuVien--;
							dem++;
						}
						if (Temp != dem)
						{
							i = 0;
						}
						else
						{
							i++;
						}
					} while (dem != soluong);
					Console.WriteLine(" Xoa thanh cong " + dem + " co ma " + MaDauSach);
				}
			}
			else
			{
				Console.Write("Khong ton tai dau sach !");
				return;
			}
		}
		public void XoaSachKH(string MaDauSach)
		{
			int ViTriDauSach = KiemTraViTriSachKH(MaDauSach);
			if (ViTriDauSach != -1)
			{
				Console.Write("Ban muon xoa khoi thu vien bao nhieu quyen sach loai nay: ");
				int soluong = Convert.ToInt32(Console.ReadLine());
				if (soluong > this.lDSDauSachKH[ViTriDauSach].SoLuongTrongThuVien)
				{
					Console.WriteLine(" So luong sach con lai trong thu vien nho hon so sach ban muon xoa! ");
					return;
				}
				else
				{
					int dem = 0;
					int i = 0;
					do
					{
						int Temp = dem;
						if (this.lDSDauSachKH[ViTriDauSach].DSQuyenSach[i].DaMuonHayChua == true)
						{
							this.lDSDauSachKH[ViTriDauSach].DSQuyenSach.Remove(this.lDSDauSachKH[ViTriDauSach].DSQuyenSach[i]);
							this.lDSDauSachKH[ViTriDauSach].SoLuongTrongThuVien--;
							dem++;
						}
						if (dem != Temp)
						{
							i = 0;
						}
						else
						{
							i++;
						}
					} while (dem != soluong);
					Console.WriteLine(" Xoa thanh cong " + dem + " co ma " + MaDauSach);
				}
			}
			else
			{
				Console.Write("Khong ton tai dau sach !");
				return;
			}
		}
		public void TimKiemThongTinDauSach(string MaDauSach)
		{
			int ViTriDauSach = KiemTraViTriSachKH(MaDauSach);
			if (ViTriDauSach != -1)
			{
				Console.WriteLine("Thong tin dau sach ");
				this.DSDauSachKH[ViTriDauSach].Xuat();
				Console.Write("Ban co muon tim kiem sau hon thong tin 1 cuon sach thuoc dau sach do ? (0 la khong, 1 la co): ");
				int Temp = Convert.ToInt32(Console.ReadLine());
				if (Temp == 1)
				{
					Console.WriteLine(" Xin nhap ma quyen sach ");
					int MaQuyen = Convert.ToInt32(Console.ReadLine());
					for (int i = 0; i < this.lDSDauSachKH[ViTriDauSach].DSQuyenSach.Count; i++)
					{
						if (this.DSDauSachKH[ViTriDauSach].DSQuyenSach[i].MaQuyenSach == MaQuyen)
						{
							Console.WriteLine(" Thong tin chi tiet quyen sach la :");
							this.DSDauSachKH[ViTriDauSach].DSQuyenSach[i].Xuat();
							return;
						}
					}
					Console.WriteLine("Khong ton tai quyen sach nao co ma trung voi ma ban nhap! ");
					return;
				}
				if (Temp == 0)
				{
					return;
				}
			}
			else
			{
				ViTriDauSach = KiemTraViTriSachGT(MaDauSach);
				if (ViTriDauSach != -1)
				{
					Console.WriteLine("Thong tin dau sach: ");
					this.DSDauSachKH[ViTriDauSach].Xuat();
					Console.Write("Ban co muon tim kiem sau hon thong tin 1 cuon sach thuoc dau sach do ? (0 la khong, 1 la co): ");
					int Temp = Convert.ToInt32(Console.ReadLine());
					if (Temp == 1)
					{
						Console.WriteLine(" Xin nhap ma quyen sach ");
						int MaQuyen = Convert.ToInt32(Console.ReadLine());
						for (int i = 0; i < this.lDSDauSachGT[ViTriDauSach].DSQuyenSach.Count; i++)
						{
							if (this.DSDauSachGT[ViTriDauSach].DSQuyenSach[i].MaQuyenSach == MaQuyen)
							{
								Console.WriteLine(" Thong tin chi tiet quyen sach la :");
								this.DSDauSachGT[ViTriDauSach].DSQuyenSach[i].Xuat();
								return;
							}
						}
						Console.WriteLine("Khong ton tai quyen sach nao co ma trung voi ma ban nhap! ");
						return;
					}
					if (Temp == 0)
					{
						return;
					}
				}
				else
				{
					Console.WriteLine("Khong ton tai ma sach do trong thu vien");
				}
			}
		}
		public void XuatRaTatCaDauSachGT()
		{
		  var emty = from c in this.DSDauSachGT
					   select c;
			foreach(DauSachGiaoTrinh c in emty)
			{
				c.Xuat();
				Console.WriteLine("\n");
			}
		}
		public void XuatRaTatCaDauSachKH()
		{
			var emty = from c in this.DSDauSachKH
					   select c;
			foreach (DauSachKhoaHoc c in emty)
			{
				c.Xuat();
				Console.WriteLine("\n");
			}
		}
		public void XuatRaTatCaSachKHDaDuocMuon()
		{
			foreach (var c in this.DSDauSachKH)
			{
				var emty = c.DSQuyenSach.Where(x => x.DaMuonHayChua == false);
				foreach (var d in emty)
				{
					d.Xuat();
					Console.WriteLine("\n");
				}
			}
		}
		public void XuatRaTatCaSachGTDaDuocMuon()
		{
			IEnumerable<QuyenSachGiaoTrinh> emty = new List<QuyenSachGiaoTrinh>();
			foreach (var c in this.DSDauSachGT)
			{
				emty = from d in c.DSQuyenSach
						   where d.DaMuonHayChua == false
						   select d;
				foreach (var d in emty)
				{
					d.Xuat();
					Console.WriteLine("\n");
				}
			}
		}
		public void XuatRaTatCaSachKHNamTrongThuVien()
		{
			foreach (var c in this.DSDauSachKH)
			{
				var emty = c.DSQuyenSach.Where(x => x.DaMuonHayChua == true);
				foreach (var d in emty)
				{
					d.Xuat();
					Console.WriteLine("\n");
				}
			}
		}
		public void XuatRaTatCaSachGTNamTrongThuVien()
		{
			IEnumerable<QuyenSachGiaoTrinh> emty = new List<QuyenSachGiaoTrinh>();
			foreach (var c in this.DSDauSachGT)
			{
				emty = from d in c.DSQuyenSach
					   where d.DaMuonHayChua == true
					   select d;
				foreach (var d in emty)
				{
					d.Xuat();
					Console.WriteLine("\n");
				}
			}
		}
		
		public void XuatRaDanhSachDocGia()
		{
			var emty = from c in this.DSDocGia
					   select c;
			foreach (var c in emty)
			{
				c.Xuat();
				Console.WriteLine("\n");
			}
		}
		
		public void DocGiaMuonNhieuNhat()
		{
			int max = this.DSHopDongMuon[0].SoLuongSachMuon;
			XacDinhMax xdmax = delegate(int a)
			{
				for (int i = 0; i < this.lDSHopDongMuon.Count; i++)
				{
					if (this.lDSHopDongMuon[i].SoLuongSachMuon > a)
					{
						a = this.lDSHopDongMuon[i].SoLuongSachMuon;
					}
				}
				return a;
			};
			var emty = from c in this.lDSHopDongMuon
					   where c.SoLuongSachMuon == xdmax(max)
					   select c.NguoiMuon;
			foreach (var c in emty)
			{
				c.Xuat();
				Console.WriteLine("\n");
			}
		}

		public void SachLonHonTienCuThe(double Tien)
		{
			int i = 0;
			while (i != this.DSDauSachGT.Count)
			{
				var emty = this.DSDauSachGT[i].DSQuyenSach.Where(x => x.ThanhTien > Tien);
				foreach (var c in emty)
				{
					c.Xuat();
					Console.WriteLine("\n");
				}
				i++;
			}
			i = 0;
			while (i != this.DSDauSachKH.Count)
			{
				var emty = this.DSDauSachKH[i].DSQuyenSach.Where(x => x.ThanhTien > Tien);
				foreach (var c in emty)
				{
					c.Xuat();
					Console.WriteLine("\n");
				}
				i++;
			}
		}
		public void SachLonSapToiHanTra()
		{
			int i = 0;
			while (i != this.DSDauSachGT.Count)
			{
				var emty = this.DSDauSachGT[i].DSQuyenSach.Where(x => x.DaMuonHayChua == false && x.NgayPhaiTra > this.dtToday && x.NgayPhaiTra - this.dtToday < 30);
				foreach (var c in emty)
				{
					c.Xuat();
					Console.WriteLine("\n");
				}
				i++;
			}
			i = 0;
			while (i != this.DSDauSachKH.Count)
			{
				var emty = this.DSDauSachKH[i].DSQuyenSach.Where(x => x.DaMuonHayChua == false && x.NgayPhaiTra > this.dtToday && x.NgayPhaiTra -this.dtToday < 30);
				foreach (var c in emty)
				{
					c.Xuat();
					Console.WriteLine("\n");
				}
				i++;
			}
		}

		public void DocGiaSapHetHanThe()
		{
			var emty = this.DSDocGia.Where(x => x.NgayHetHanThe < this.dtToday );					 
			foreach (var c in emty)
			{
				c.Xuat();
				Console.WriteLine("\n");
			}
			emty = this.DSDocGia.Where(x => x.NgayHetHanThe > this.dtToday && x.NgayHetHanThe-this.dtToday < 30);
			foreach (var c in emty)
			{
				c.Xuat();
				Console.WriteLine("\n");
			}
		}
		public void ThongKeSoSach()
		{
			int tongsach = 0;
			int sachmuon = 0;
			IEnumerable<QuyenSachGiaoTrinh> emty1 = new List<QuyenSachGiaoTrinh>();
			IEnumerable<QuyenSachKhoaHoc> emty2 = new List<QuyenSachKhoaHoc>();
			foreach(var c in this.DSDauSachGT)
			{
				var emty3 = from d in c.DSQuyenSach
							select d;
				foreach (var e in emty3)
				{
					if (e.DaMuonHayChua == false)
					{
						sachmuon++;
					}
					tongsach++;
				}
			}
			foreach (var c in this.DSDauSachKH)
			{
				var emty3 = from d in c.DSQuyenSach
							select d;
				foreach (var e in emty3)
				{
					if (e.DaMuonHayChua == false)
					{
						sachmuon++;
					}
					tongsach++;
				}
			}
			Console.WriteLine(" Tong so sach la: "+tongsach);
			Console.WriteLine(" So sach muon la: " + sachmuon);
			Console.WriteLine(" So sach nam trong thu vien la: " + (tongsach - sachmuon));
			float PhanTramMuon = ((sachmuon * 100) / tongsach);
			Console.WriteLine("Phan tram cua so sach muon so voi tong so sach la: "+PhanTramMuon+ "%");
			PhanTramMuon = 100 - PhanTramMuon;
			Console.WriteLine("Phan tram cua so sach nam torng thu vien so voi tong so sach la: " + PhanTramMuon+"%");
		}
		public void SortIncreasingTheDateOfCustomer(int left,int right)
		{
			int i = left;
			int j = right;
			DocGia Pivot = this.DSDocGia[(i + j ) / 2];
			while (i <= j)
			{
				while(this.DSDocGia[i].NgayHetHanThe < Pivot.NgayHetHanThe)
				{
					i++;
				}
				while (this.DSDocGia[j].NgayHetHanThe > Pivot.NgayHetHanThe)
				{
					j--;
				}
				if (i <= j)
				{
					DocGia Temp = this.DSDocGia[i];
					this.DSDocGia[i] = this.DSDocGia[j];
					this.DSDocGia[j] = Temp;
					i++;
					j--;
				}
			}
			if (left < j)
			{
				SortIncreasingTheDateOfCustomer(left, j);
			}
			if (i < right)
			{
				SortIncreasingTheDateOfCustomer(i, right);
			}
		}
		public void SapXepDocGiaTheoSoSachMuonTangDan(int n)
		{
			int flag = 1;
			int j = 0;
			while (flag !=0 )
			{
				flag = 0;
				j++;
				for (int i = 0; i < n - j; i++)
				{
					if (this.DSHopDongMuon[i].SoLuongSachMuon > DSHopDongMuon[i + 1].SoLuongSachMuon)
					{
						HopDongMuon Temp = this.DSHopDongMuon[i];
						this.DSHopDongMuon[i] = this.DSHopDongMuon[i + 1];
						this.DSHopDongMuon[i + 1] = Temp;
						flag = 1;
					}
				}
			}
			for (int i = 0; i < this.DSHopDongMuon.Count; i++)
			{
				this.DSDocGia[i] = this.DSHopDongMuon[i].NguoiMuon;
				this.lDSDocGia[i].Xuat();
				Console.WriteLine(" Tong so sach muon la: "+this.DSHopDongMuon[i].SoLuongSachMuon+"\n");
			}
		}
		public void SapXepDanhSachSachGTTheoGiaTangDan()
		{
			List<QuyenSachGiaoTrinh> List_Temp = new List<QuyenSachGiaoTrinh>();
			int i = 0;
			while (i != this.DSDauSachGT.Count)
			{
				var emty = this.DSDauSachGT[i].DSQuyenSach;		   
				foreach (var c in emty)
				{
					List_Temp.Add(c);
				}
				i++;
			}
			for (int j = 1; j < List_Temp.Count; j++)
			{
				QuyenSachGiaoTrinh x = List_Temp[j];
				int h = j - 1;
				while (h >= 0 && List_Temp[h].ThanhTien > x.ThanhTien)
				{
					List_Temp[h + 1] = List_Temp[h];
					h--;
				}
				List_Temp[h+1] = x;
			}
			foreach (var c in List_Temp)
			{
				c.Xuat();
				Console.WriteLine(" Thanh tien: " + c.ThanhTien);
				Console.WriteLine("\n");
			}
		}
		public void SapXepDanhSachSachKHTheoGiaGiamDan()
		{
			List<QuyenSachKhoaHoc> List_Temp = new List<QuyenSachKhoaHoc>();
			int i = 0;
			while (i != this.DSDauSachKH.Count)
			{
				var emty = this.DSDauSachKH[i].DSQuyenSach;
				foreach (var c in emty)
				{
					List_Temp.Add(c);
				}
				i++;
			}
			int MinPos;
			for ( i = 0; i < List_Temp.Count-1; i++)
			{
				MinPos = i;
				for (int j = i + 1; j < List_Temp.Count; j++)
				{
					if (List_Temp[j].ThanhTien > List_Temp[MinPos].ThanhTien)
					{
						MinPos = j;
					}
				}
				if(MinPos!=i)
				{
					QuyenSachKhoaHoc Temp = List_Temp[i];
					List_Temp[i] = List_Temp[MinPos];
					List_Temp[MinPos] = Temp;
				}
			}
			foreach (var c in List_Temp)
			{
				c.Xuat();
				Console.WriteLine("Gia : "+c.ThanhTien);
				Console.WriteLine("\n");
			}
		}
		public void XuatTatCaNhanVien()
		{
			Console.WriteLine("\n");
			foreach (var c in this.lDSNhanVien)
			{
				c.Xuat();
				Console.WriteLine("\n");
			}
		}
		public void TatCaHopDong()
		{
			foreach (var c in this.lDSHopDongMuon)
			{
				c.NguoiMuon.Xuat();
				Console.WriteLine(" So luong sach muon la:" + c.SoLuongSachMuon + "\n");
				foreach (var d in c.DSSachGTMuon)
				{
					d.Xuat();
					Console.WriteLine("\n");
				}
				foreach (var d in c.DSSachKHMuon)
				{
					d.Xuat();
					Console.WriteLine("\n");
				}

				Console.WriteLine("=============================================================================");
			}
		}

	}
}
