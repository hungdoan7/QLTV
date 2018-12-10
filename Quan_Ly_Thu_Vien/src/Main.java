import java.io.IOException;
import java.util.Scanner;
public class Main 
{
	public static void main(String[] args) throws IOException
	{
		int Chon;
		ThuVien thuvien = new ThuVien();
		thuvien.NhapThuVien();
		thuvien.NhapHDMuon();

		int Temp;
		@SuppressWarnings("resource")
		Scanner sc = new Scanner(System.in);
		do 
		{
			System.out.println(" Cap nhat lai tinh hinh thu vien \n");
			thuvien.CapNhatLai();
			System.out.println("Cac tuy chon: ");
			System.out.println(" 1.Dang nhap tai khoan doc gia va su dung ");
			System.out.println(" 2.Dang ky tai khoan doc gia moi ");
			System.out.println(" 3.Tim kiem thong tin 1 dau sach bat ky ");
			System.out.println(" 4.Cac tinh nang thong ke va sap xep thu vien ");
			System.out.println(" 5.Xoa hoac them moi sach vao thu vien ");
			System.out.println(" 6.Danh sach luong nhan vien thu vien ");
			System.out.print("Xin hay nhap vao lua chon: ");
			Chon = sc.nextInt();
			switch (Chon) 
			{
			case 1: 
			{
				int ChonChon;
				String Ten_Temp;
				System.out.println(" Nhap ma doc gia: ");
				sc = new Scanner(System.in);
				Ten_Temp = sc.nextLine();
				
				int ViTriDG_Temp = thuvien.KiemTraViTriDocGiaTrongListHD(Ten_Temp);
				if (ViTriDG_Temp != -1)
				{
					System.out.println("Cac tuy chon: ");
					System.out.println(" 1.Muon sach ");
					System.out.println(" 2.Tra sach ");
					System.out.println(" 3.KT thong tin ");
					System.out.println(" 4.Nap them tien vao tai khoan ");
					System.out.println(" 5.Gia han the thu vien ");
					System.out.print("Chon: ");
					ChonChon = sc.nextInt();
					switch (ChonChon)
					{
					case 1:
					{
						if(thuvien.getlDSHopDongMuon().get(ViTriDG_Temp).getiSoLuongSachMuon()>10)
						{
							System.out.println("Tra sach truoc khi tiep tuc muon, ban da muon du 10 cuoi sach ! ");
							int ChonChonChon;
							System.out.println("Ban co muon tra sach ngay khong (0 la khong, 1 la co ) ");
							ChonChonChon = sc.nextInt();
							switch(ChonChonChon)
							{
							case 0:
							{
								break;
							}
							case 1:
							{
								System.out.println("Nhap tua sach hoac ma dau sach: ");
								String Tua=sc.nextLine();
								System.out.println("Nhap ma quyen sach");
								int Quyen = sc.nextInt();
								thuvien.TraSach(ViTriDG_Temp,Tua,Quyen);
								break;
							}
							default:
							{
								break;
							}
							}
						}
						else 
						{
							if (Date.SoSanhNhoHon(thuvien.getlDSHopDongMuon().get(ViTriDG_Temp).getdgNguoiMuon().getdtNgayHetHan(),thuvien.getDtToday()) == true)
							{
								System.out.println(" Gia han the truoc khi duoc quyen tiep tuc muon ");
								// Gia han the
								System.out.println("Chon gia han ngay (0 la khong dong y, 1 la dong y) : ");
								int ChonChonCHon = sc.nextInt();
								switch (ChonChonCHon)
								{
								case 1:
								{
									thuvien.getlDSHopDongMuon().get(ViTriDG_Temp).getdgNguoiMuon().GiaHanTheThuVien(thuvien.getDtToday());
									System.out.println(" Gia han thanh cong !");
									break;
								}
								case 0:
								{
									break;
								}
								default:
								{
									System.out.println(" Nhap sai");
									break;
								}
								}
							}
							else 
							{
								if(thuvien.getlDSHopDongMuon().get(ViTriDG_Temp).getdgNguoiMuon().getdTaiKhoan()<10000)
								{
									System.out.println(" Nap them tien vao tai khoan truoc khi duoc quyen tiep tuc muon ");
									System.out.println(" Chon nap vao tai khoan ngay (0 la khong, 1 la dong y) ");
									int ChonChonChon = sc.nextInt();
									switch (ChonChonChon)
									{
									case 0:
									{
										break;
									}
									case 1:
									{
										System.out.println(" Nhap so tien can nap: ");
										double Tien = sc.nextDouble();
										thuvien.getlDSHopDongMuon().get(ViTriDG_Temp).getdgNguoiMuon().Tien(Tien);
										System.out.println(" Da nap "+Tien+" ngan thanh cong !");
										break;
									}
									default:
									{
										System.out.println(" Nhap sai");
										break;
									}
									}
								}
							}
						}
						thuvien.MuonSach(ViTriDG_Temp);
						break;
					}
					case 2:
					{
						System.out.println("Nhap tua sach hoac ma dau sach: ");
						sc = new Scanner(System.in);
						String Tua=sc.nextLine();
						System.out.println("Nhap ma quyen sach");
						@SuppressWarnings("resource")
						Scanner sc1 = new Scanner(System.in);
						int Quyen = sc1.nextInt();
					
						thuvien.TraSach(ViTriDG_Temp,Tua,Quyen);
						break;
					}
					case 3:
					{
						thuvien.ThongTinDocGiaTrongHD(ViTriDG_Temp);
						break;
					}
					case 4:
					{
						System.out.println(" Nhap so tien can nap: ");
						double Tien = sc.nextDouble();
						thuvien.getlDSHopDongMuon().get(ViTriDG_Temp).getdgNguoiMuon().Tien(Tien);
						System.out.println(" Da nap "+Tien+" ngan thanh cong !");
						break;
					}
					case 5:
					{
						thuvien.getlDSHopDongMuon().get(ViTriDG_Temp).getdgNguoiMuon().GiaHanTheThuVien(thuvien.getDtToday());
						System.out.println(" Gia han thanh cong !");
						break;
					}
					}
				}
				else 
				{
					int ChonChonChon;
					System.out.println(" Chua ton tai tai khoan ");
					System.out.println(" 1.Dang ky tai khoan ");
					System.out.println(" 2.Thoat ");
					System.out.print("Xin moi nhap vao lua chon: ");
					ChonChonChon = sc.nextInt(); 
					switch (ChonChonChon)
					{
						case 1:
							{
								thuvien.DangKyTaiKhoanMoi(thuvien.getDtToday());
								break;
							}
						case 2:
							{
								break;
							}
						default:
							{
								System.out.println("Nhap sai ");
								break;
							}
					}
				}
				break;
			}
			case 2: 
			{
				thuvien.DangKyTaiKhoanMoi(thuvien.getDtToday());
				break;
			}
			case 3:
			{
				sc = new Scanner(System.in);
				System.out.println("Hay nhap vao ma sach hoac tua sach: ");
				String MaDauSach = sc.nextLine();
				thuvien.TimKiemThongTinDauSach(MaDauSach);;
				break;
			}
			case 4: 
			{
				int ChonChon;
				System.out.println("Cac lua chon: ");
				System.out.println(" 1.Danh sach sach khoa hoc dang trong tinh trang bi muon ");
				System.out.println(" 2.Danh sach khoa hoc dang nam trong thu vien ");
				System.out.println(" 3.Danh sach giao trinh dang trong tinh trang bi muon ");
				System.out.println(" 4.Danh sach giao trinh dang nam trong thu vien ");
				System.out.println(" 5.Danh sach doc gia ");
				System.out.println(" 6.Danh sach sach co gia tri lon hon 1 so tien cu the ");
				System.out.println(" 7.Danh sach nhung cuon sach sap toi han tra");
				System.out.println(" 8.Danh sach nhung doc gia sap het han the (duoi 30 ngay ke tu hom nay la het han) ");
				System.out.println(" 9.Danh sach nhung doc gia muon nhieu sach nhat ");
				System.out.println(" 10.Thong ke so luong sach duoc muon va phan tram so voi so sach ban dau ");
				System.out.println(" 11.Xuat ra man hinh danh sach tat ca cac ban hop dong ");
				System.out.print(" Chon:  ");
				sc = new Scanner(System.in);
				ChonChon = sc.nextInt();
				switch(ChonChon)
				{
					case 1:
					{
						System.out.println(" Danh sach sach khoa hoc dang trong tinh trang bi muon:");
						thuvien.XuatRaTatCaSachKHDaDuocMuon();
						break;
					}
					case 2:
					{
						System.out.println(" Danh sach sach khoa hoc dang nam trong thu vien:");
						thuvien.XuatRaTatCaSachKHNamTrongThuVien();
					
						break;
					}
					case 3:
					{
						System.out.println(" Danh sach sach giao trinh dang trong tinh trang bi muon:");
						thuvien.XuatRaTatCaSachGTDaDuocMuon();
						break;
					}
					case 4:
					{
						System.out.println(" Danh sach sach giao trinh dang nam trong thu vien:");
						thuvien.XuatRaTatCaSachGTNamTrongThuVien();
						break;
					}
					case 5:
					{
						System.out.println(" Danh sach sach doc gia trong thu vien:");
						thuvien.XuatRaDanhSachDocGia();
						break;
					}
					case 6:
					{
						double tien;
						System.out.print("Hay nhap vao so tien: ");
						sc = new Scanner(System.in);
						tien =sc.nextDouble();
						thuvien.SachLonHonTienCuThe(tien);
						break;
					}
					case 7:
					{
						thuvien.SachSapToiHanTra();
						break;
					}
					case 8:
					{
						thuvien.DocGiaSapHetHanThe();
						break;
					}
					case 9:
					{
						thuvien.DocGiaMuonNhieuNhat();
						break;
					}
					case 10:
					{
						thuvien.ThongKeSoSach();
						break;
					}	
					case 11:
					{
						thuvien.TatCaHopDong();
						break;
					}
					default:
					{
						break;
					}
				}
				break;
			}
			case 5:
			{
				System.out.println("Cac lua chon:");
				System.out.println(" 1.Them sach ");
				System.out.println(" 2.Xoa bot sach ");
				System.out.print("Nhap vao lua chon: ");
				@SuppressWarnings("resource")
				Scanner sc1 = new Scanner(System.in);
				int ChonChon = sc1.nextInt();
				switch (ChonChon)
				{
				
				case 1:
				{
					System.out.println(" Lua chon them sach GT hay sach KH (0 la khoa hoc, 1 la giao trinh): ");
					System.out.print(" Chon:");
					sc = new Scanner(System.in);
					int ChonChonChon = sc.nextInt();
					switch (ChonChonChon)
					{
					
					case 0:
					{
						System.out.print("Hay nhap vao ma sach hoac tua sach: ");
						sc= new Scanner(System.in);
						String Ma_Temp = sc.nextLine();
						thuvien.ThemSachKH(Ma_Temp);
						break;
					}
					case 1:
					{
						System.out.print("Hay nhap vao ma sach hoac tua sach: ");
						sc= new Scanner(System.in);
						String Ma_Temp = sc.nextLine();
						thuvien.ThemSachGT(Ma_Temp);
						break;
					}
					default:
					{
						System.out.println(" Nhap sai");
						break;
					}
						
					}
					break;
				}
				case 2:
				{
					System.out.println(" Lua chon xoa sach GT hay sach KH (0 la khoa hoc, 1 la giao trinh): ");
					System.out.print(" Chon:");
					@SuppressWarnings("resource")
					Scanner sc2= new Scanner(System.in);
					int ChonChonChon = sc2.nextInt();
					switch (ChonChonChon)
					{
						case 0:
							{
								System.out.println("Hay nhap vao ma sach hoac tua sach: ");
								sc2 = new Scanner(System.in);
								String Ma_Temp = sc2.nextLine();
								thuvien.XoaSachKH(Ma_Temp);
								break;
							}
						case 1:
							{
								System.out.println("Hay nhap vao ma sach hoac tua sach: ");
								sc2 = new Scanner(System.in);
								String Ma_Temp = sc2.nextLine();
								thuvien.XoaSachGT(Ma_Temp);
								break;
							}
						default:
							{
								System.out.println("Nhap sai ");
								break;
							}
					}
					break;
				}
				default:
				{
					System.out.println("Nhap sai ");
					break;
				}
				}
				break;
			}
			case 6: 
			{
				thuvien.XuatTatCaNhanVien();
				System.out.println(" Nhap them nhan vien(0 la thoat, 1 la nhap): ");
				sc = new Scanner(System.in);
				int ChonChonChon = sc.nextInt();
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
				System.out.println("Nhap sai ");
				break;
			}
			}
			System.out.print("\n Nhan phim so 0 + Enter de ket thuc        or        Nhan phim so khac 0 + Enter de tro ve Menu:       ");
			Temp = sc.nextInt();
			System.out.print("\n\n");
		} while (Temp != 0);
	}
}
