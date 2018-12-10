using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// muc tieu
// chua lam duoc
// chua giai quyet van de doc gia VIP, nhan vien thu vien
// bo sung nhieu tinh nang thong ke, sap xep 

namespace QLTV
{
	public delegate int XacDinhMax(int a);
	public delegate int XacDinh();
	public delegate int KiemTra(String NhapVao);
	public delegate void Ngay(Date Today);
	public delegate Date XacDinhNgay();
	public delegate void CongViec(int ViTri);
	public delegate void Tien(double Tien);
	public delegate void TraSach(int a, string b, int c);
	public delegate void Them(String a);
	public delegate void DanhSach();
	class Program
	{
		static void Main(string[] args)
		{
			int Chon;
			ThuVien thuvien = new ThuVien();
			thuvien.NhapThuVien();
			thuvien.NhapHDMuon();
			
			int Temp;     // bien dung cho viec quay lai menu
			do
			{
				Console.WriteLine("Cap nhat lai tinh hinh thu vien ");
				Console.Write("\n");
				thuvien.CapNhatLai();
				Console.Write("\n");
				//Console.WriteLine("Chuong trinh quan ly thu vien ");
				Console.WriteLine("Cac tuy chon: ");
				Console.WriteLine(" 1.Dang nhap tai khoan doc gia va su dung ");
				Console.WriteLine(" 2.Dang ky tai khoan doc gia moi ");
				Console.WriteLine(" 3.Tim kiem thong tin 1 dau sach bat ky ");
				Console.WriteLine(" 4.Cac tinh nang thong ke va sap xep thu vien ");
				Console.WriteLine(" 5.Xoa hoac them moi sach vao thu vien ");
				Console.WriteLine(" 6.Danh sach luong nhan vien thu vien ");
				Console.Write("Xin hay nhap vao lua chon: ");
				Chon = Convert.ToInt32(Console.ReadLine());
				switch (Chon)
				{
					case 1:
						{
							int ChonChon;
							String Ten_Temp;
							Console.WriteLine(" Nhap ten hoac ma doc gia: ");
							Ten_Temp = Console.ReadLine();
							KiemTra kt = new KiemTra(thuvien.KiemTraViTriDocGiaTrongListHD);
							int ViTriDG_Temp = kt(Ten_Temp);
							if (ViTriDG_Temp != -1)
							{
								Console.WriteLine("Cac tuy chon: ");
								Console.WriteLine(" 1.Muon sach ");
								Console.WriteLine(" 2.Tra sach ");
								Console.WriteLine(" 3.KT thong tin ");
								Console.WriteLine(" 4.Nap them tien vao tai khoan ");
								Console.WriteLine(" 5.Gia han the thu vien ");
								Console.Write("Chon: ");
								ChonChon = Convert.ToInt32(Console.ReadLine());
								switch (ChonChon)
								{
									case 1:
										{
											if ((thuvien.DSHopDongMuon[ViTriDG_Temp].SoLuongSachMuon > 10))
											{
												Console.Write(" Tra sach truoc khi tiep tuc muon, ban da muon du 10 cuon sach ");
												int ChonChonChon;
												Console.WriteLine(" Ban co muon tra sach ngay:(0 la khong, 1 la co) ");
												ChonChonChon = Convert.ToInt32(Console.ReadLine());
												switch (ChonChonChon)
												{
													case 0:
														{
															break;
														}
													case 1:
														{
															Console.WriteLine("Nhap tua sach hoac ma dau sach: ");
															string Tua = Console.ReadLine();
															Console.WriteLine("Nhap ma quyen sach: ");
															int Quyen = Convert.ToInt32(Console.ReadLine());
															TraSach ts = new TraSach(thuvien.TraSach);
															ts(ViTriDG_Temp, Tua, Quyen);
															break;
														}
													default:
														{
															Console.WriteLine(" Nhap sai ");
															break;
														}
												}
												break;
											}
											else
											{
												if ((thuvien.DSHopDongMuon[ViTriDG_Temp].NguoiMuon.NgayHetHanThe < thuvien.Today))
												{
													Console.Write(" Gia han the truoc khi duoc quyen tiep tuc muon ");
													// Gia han the
													Console.WriteLine("Chon gia han ngay (0 la khong dong y, 1 la dong y) : ");
													int ChonChonCHon = Convert.ToInt32(Console.ReadLine());
													switch (ChonChonCHon)
													{
														case 1:
															{
																XacDinhNgay xd = new XacDinhNgay(thuvien.XacDinhToday);
																Date Today_Temp = xd();
																thuvien.DSHopDongMuon[ViTriDG_Temp].NguoiMuon.GiaHanThe(Today_Temp);
																break;
															}
														case 0:
															{
																break;
															}
														default:
															{
																Console.WriteLine("Nhap sai");
																break;
															}
													}
												}
												else
												{
													if ((thuvien.DSHopDongMuon[ViTriDG_Temp].NguoiMuon.TaiKhoan < 10000))
													{
														Console.Write(" Nap them vao tai khoan truoc khi duoc quyen tiep tuc muon ");
														//Nap them tien 
														Console.WriteLine("Chon nap vao tai khoan ngay (0 la khong dong y, 1 la dong y) : ");
														int ChonChonCHon = Convert.ToInt32(Console.ReadLine());
														switch (ChonChonCHon)
														{
															case 1:
																{
																	Console.WriteLine(" Nhap so tien can nap: ");
																	double Tien = Convert.ToDouble(Console.ReadLine());
																	Tien nt = new Tien(thuvien.DSHopDongMuon[ViTriDG_Temp].NguoiMuon.Tien);
																	nt(Tien);
																	break;
																}
															case 0:
																{
																	break;
																}
															default:
																{
																	Console.WriteLine("Nhap sai");
																	break;
																}
														}
													}
												}
											}
											CongViec ms = new CongViec(thuvien.MuonSach);
											ms(ViTriDG_Temp);
											break;
										}
									case 2:
										{
											Console.WriteLine("Nhap tua sach hoac ma dau sach: ");
											string Tua = Console.ReadLine();
											Console.WriteLine("Nhap ma quyen sach: ");
											int Quyen = Convert.ToInt32(Console.ReadLine());
											TraSach ts = new TraSach(thuvien.TraSach);
											ts(ViTriDG_Temp, Tua, Quyen);
											break;
										}
									case 3:
										{
											CongViec xd = new CongViec(thuvien.ThongTinDocGiaTrongHD);
											Console.Write("\n\n");
											xd(ViTriDG_Temp);
											break;
										}
									case 4:
										{
											Console.WriteLine(" Nhap so tien can nap: ");
											double Tien = Convert.ToDouble(Console.ReadLine());
											Tien nt = new Tien(thuvien.DSHopDongMuon[ViTriDG_Temp].NguoiMuon.Tien);
											nt(Tien);
											break;
										}
									case 5:
										{
											XacDinhNgay xd = new XacDinhNgay(thuvien.XacDinhToday);
											Date Today_Temp = xd();
											thuvien.DSHopDongMuon[ViTriDG_Temp].NguoiMuon.GiaHanThe(Today_Temp);
											break;
										}
									default:
										{
											Console.WriteLine("Nhap sai ");
											break;
										}
								}

							}
							else
							{
								int ChonChonChon;
								Console.WriteLine(" Chua ton tai tai khoan ");
								Console.WriteLine(" 1.Dang ky tai khoan ");
								Console.WriteLine(" 2.Thoat ");
								Console.Write("Xin moi nhap vao lua chon: ");
								ChonChonChon = Convert.ToInt32(Console.ReadLine());
								switch (ChonChonChon)
								{
									case 1:
										{
											XacDinhNgay xd = new XacDinhNgay(thuvien.XacDinhToday);
											Date Today_Temp = xd();
											Ngay dk = new Ngay(thuvien.DangKyTaiKhoanMoi);
											dk(Today_Temp);
											break;
										}
									case 2:
										{
											break;
										}
									default:
										{
											Console.WriteLine("Nhap sai ");
											break;
										}
								}
							}
							break;
						}
					case 2:
						{
							XacDinhNgay xd = new XacDinhNgay(thuvien.XacDinhToday);
							Date Today_Temp = xd();
							Ngay dk = new Ngay(thuvien.DangKyTaiKhoanMoi);
							dk(Today_Temp);
							break;
						}
					case 3:
						{
							Console.Write("Hay nhap vao ma sach hoac tua sach: ");
							string Ma_Temp = Console.ReadLine();
							Them t = new Them(thuvien.TimKiemThongTinDauSach);
							t(Ma_Temp);
							break;
						}
					case 4:
						{
							int ChonChon;
							Console.WriteLine("Cac lua chon: ");
							Console.WriteLine(" 1.Danh sach sach khoa hoc dang trong tinh trang bi muon ");
							Console.WriteLine(" 2.Danh sach khoa hoc dang nam trong thu vien ");
							Console.WriteLine(" 3.Danh sach giao trinh dang trong tinh trang bi muon ");
							Console.WriteLine(" 4.Danh sach giao trinh dang nam trong thu vien ");
							Console.WriteLine(" 5.Danh sach doc gia ");
							Console.WriteLine(" 6.Danh sach sach co gia tri lon hon 1 so tien cu the ");
							Console.WriteLine(" 7.Danh sach nhung cuon sach sap toi han tra");
							Console.WriteLine(" 8.Danh sach nhung doc gia sap het han the (duoi 30 ngay ke tu hom nay la het han) ");
							Console.WriteLine(" 9.Danh sach nhung doc gia muon nhieu sach nhat ");
							Console.WriteLine(" 10.Thong ke so luong sach duoc muon va phan tram so voi so sach ban dau ");
							Console.WriteLine(" 11.Sap xep danh sach doc gia theo thu tu tang dan ngay het han the ");
							Console.WriteLine(" 12.Xuat ra man hinh danh sach sach giao trinh theo thu tu gia tang dan ");
							Console.WriteLine(" 13.Xuat ra man hinh danh sach sap xep doc gia theo thu tu tang dan tong so sach dang muon  ");
							Console.WriteLine(" 14.Xuat ra man hinh danh sach sach khoa hoc theo thu tu gia giam dan ");
							Console.WriteLine(" 15.Xuat ra man hinh danh sach tat ca cac ban hop dong ");
							Console.Write(" Chon:  ");
							ChonChon = Convert.ToInt32(Console.ReadLine());
							switch (ChonChon)
							{
								case 1:
									{
										Console.WriteLine("/n Danh sach sach khoa hoc dang trong tinh trang bi muon:");
										DanhSach ds = new DanhSach(thuvien.XuatRaTatCaSachKHDaDuocMuon);
										ds();
										break;
									}
								case 2:
									{
										Console.WriteLine("/n Danh sach sach khoa hoc dang nam trong thu vien:");
										DanhSach ds = new DanhSach(thuvien.XuatRaTatCaSachKHNamTrongThuVien);
										ds();
										break;
									}
								case 3:
									{
										Console.WriteLine("/n Danh sach sach giao trinh dang trong tinh trang bi muon:");
										DanhSach ds = new DanhSach(thuvien.XuatRaTatCaSachGTDaDuocMuon);
										ds();
										break;
									}
								case 4:
									{
										Console.WriteLine("/n Danh sach sach giao trinh dang nam trong thu vien:");
										DanhSach ds = new DanhSach(thuvien.XuatRaTatCaSachGTNamTrongThuVien);
										ds();
										break;
									}
								case 5:
									{
										Console.WriteLine("/n Danh sach sach doc gia trong thu vien:");
										DanhSach ds = new DanhSach(thuvien.XuatRaDanhSachDocGia);
										ds();
										break;
									}
								case 6:
									{
										double tien;
										Console.Write("Hay nhap vao so tien: ");
										tien = Convert.ToDouble(Console.ReadLine());
										Tien t = new Tien(thuvien.SachLonHonTienCuThe);
										t(tien);
										break;
									}
								case 7:
									{
										DanhSach ds = new DanhSach(thuvien.SachLonSapToiHanTra);
										ds();
										break;
									}
								case 8:
									{
										DanhSach ds = new DanhSach(thuvien.DocGiaSapHetHanThe);
										ds();
										break;
									}
								case 9:
									{
										DanhSach ds = new DanhSach(thuvien.DocGiaMuonNhieuNhat);
										ds();
										break;
									}
								case 10:
									{
										DanhSach ds = new DanhSach(thuvien.ThongKeSoSach);
										ds();
										break;
									}
								case 11:
									{
										thuvien.SortIncreasingTheDateOfCustomer(0, thuvien.DSDocGia.Count - 1);
										DanhSach ds = new DanhSach(thuvien.XuatRaDanhSachDocGia);
										ds();
										break;
									}
								case 12:
									{
										DanhSach ds = (thuvien.SapXepDanhSachSachGTTheoGiaTangDan);
										ds();
										break;
									}
								case 13:
									{
										CongViec cv = new CongViec(thuvien.SapXepDocGiaTheoSoSachMuonTangDan);
										cv(thuvien.DSHopDongMuon.Count);
										break;
									}
								case 14:
									{
										DanhSach ds = new DanhSach(thuvien.SapXepDanhSachSachKHTheoGiaGiamDan);
										ds();
										break;
									}
								case 15:
									{
										DanhSach ds = new DanhSach(thuvien.TatCaHopDong);
										ds();
										break;
									}
							}
							break;
						}
					case 5:
						{
							Console.WriteLine("Cac lua chon:");
							Console.WriteLine(" 1.Them sach ");
							Console.WriteLine(" 2.Xoa bot sach ");
							Console.Write("Nhap vao lua chon: ");
							int ChonChon = Convert.ToInt32(Console.ReadLine());
							switch (ChonChon)
							{
								case 1:
									{
										Console.WriteLine(" Lua chon them sach GT hay sach KH (0 la khoa hoc, 1 la giao trinh): ");
										Console.Write(" Chon:");
										int ChonChonChon = Convert.ToInt32(Console.ReadLine());
										switch (ChonChonChon)
										{
											case 0:
												{	
													Console.WriteLine("Hay nhap vao ma sach hoac tua sach: ");
													string Ma_Temp = Console.ReadLine();
													Them th = new Them(thuvien.ThemSachKH);
													th(Ma_Temp);
													break;
												}
											case 1:
												{
													Console.WriteLine("Hay nhap vao ma sach hoac tua sach: ");
													string Ma_Temp = Console.ReadLine();
													Them th = new Them(thuvien.ThemSachGT);
													th(Ma_Temp);
													break;
												}
											default:
												{
													Console.WriteLine("Nhap sai ");
													break;
												}
										}
										break;
									}
								case 2:
									{
										Console.WriteLine(" Lua chon xoa sach GT hay sach KH (0 la khoa hoc, 1 la giao trinh): ");
										Console.Write(" Chon:");
										int ChonChonChon = Convert.ToInt32(Console.ReadLine());
										switch (ChonChonChon)
										{
											case 0:
												{
													Console.WriteLine("Hay nhap vao ma sach hoac tua sach: ");
													string Ma_Temp = Console.ReadLine();
													Them th = new Them(thuvien.XoaSachKH);
													th(Ma_Temp);
													break;
												}
											case 1:
												{
													Console.WriteLine("Hay nhap vao ma sach hoac tua sach: ");
													string Ma_Temp = Console.ReadLine();
													Them th = new Them(thuvien.XoaSachGT);
													th(Ma_Temp);
													break;
												}
											default:
												{
													Console.WriteLine("Nhap sai ");
													break;
												}
										}
										break;
									}
								default:
									{
										Console.WriteLine("Nhap sai ");
										break;
									}
							}
							break;
						}
					case 6:
						{
							DanhSach ds = new DanhSach(thuvien.XuatTatCaNhanVien);
							ds();
							Console.WriteLine(" Nhap them nhan vien(0 la thoat, 1 la nhap): ");
							int ChonChonChon = Convert.ToInt32(Console.ReadLine());
							switch (ChonChonChon)
							{
								case 0:
									{
										break;
									}
								case 1:
									{
										thuvien.DangKyNhanVienMoi();
										break;
									}
								default:
									{
										break;
									}
							}
							break;
						}
					default:
						{
							Console.WriteLine("Nhap sai ");
							break;
						}
				}
				Console.Write("\n Nhan phim so 0 + Enter de ket thuc        or        Nhan phim so khac 0 + Enter de tro ve Menu:       ");
				Temp = Convert.ToInt32(Console.ReadLine());
				Console.Write("\n\n");
			} while (Temp != 0);
		}
	}
}
