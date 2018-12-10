import java.io.IOException;
import java.util.ArrayList;
import java.util.Scanner;

public class ThuVien
{
	private ArrayList<DauSachKhoaHoc> lDSDauSachKH;
	private ArrayList<DauSachGiaoTrinh> lDSDauSachGT;
	private ArrayList<DocGia> lDSDocGia;
	private ArrayList<NhanVien> lDSNhanVien;
	private ArrayList<HopDongMuon> lDSHopDongMuon;
	private Date dtToday;
	
	public ArrayList<DauSachKhoaHoc> getlDSDauSachKH() {
		return lDSDauSachKH;
	}
	public void setlDSDauSachKH(ArrayList<DauSachKhoaHoc> lDSDauSachKH) {
		this.lDSDauSachKH = lDSDauSachKH;
	}
	public ArrayList<DauSachGiaoTrinh> getlDSDauSachGT() {
		return lDSDauSachGT;
	}
	public void setlDSDauSachGT(ArrayList<DauSachGiaoTrinh> lDSDauSachGT) {
		this.lDSDauSachGT = lDSDauSachGT;
	}
	public ArrayList<DocGia> getlDSDocGia() {
		return lDSDocGia;
	}
	public void setlDSDocGia(ArrayList<DocGia> lDSDocGia) {
		this.lDSDocGia = lDSDocGia;
	}
	public ArrayList<HopDongMuon> getlDSHopDongMuon() {
		return lDSHopDongMuon;
	}
	public void setlDSHopDongMuon(ArrayList<HopDongMuon> lDSHopDongMuon) {
		this.lDSHopDongMuon = lDSHopDongMuon;
	}
	public Date getDtToday() {
		return dtToday;
	}
	public void setDtToday(Date dtToday) {
		this.dtToday = dtToday;
	}
	public ArrayList<NhanVien> getlDSNhanVien() {
		return lDSNhanVien;
	}
	public void setlDSNhanVien(ArrayList<NhanVien> lDSNhanVien) {
		this.lDSNhanVien = lDSNhanVien;
	}
	
	public ThuVien()
	{
		this.lDSDauSachKH = new ArrayList<DauSachKhoaHoc>();
		this.lDSDauSachGT = new ArrayList<DauSachGiaoTrinh>();
		this.lDSDocGia = new ArrayList<DocGia>();
		this.lDSNhanVien = new ArrayList<NhanVien>();
		this.lDSHopDongMuon = new ArrayList<HopDongMuon>();
		this.dtToday = new Date();
	}
	
	@SuppressWarnings("resource")
	public void NhapNgayHomNay()
	{
		this.dtToday = new Date();
		Scanner sc = new Scanner(System.in);
		System.out.println("Vui long nhap vao ngay hom nay: ");
		System.out.print("Ngay: ");

		this.dtToday.setdNgay(sc.nextInt()); 
		System.out.print("Thang: ");

		this.dtToday.setdThang(sc.nextInt());
		System.out.print("Nam: ");

		this.dtToday.setdNam(sc.nextInt());
	}
	public void NhapThuVien()
	{
		NhapNgayHomNay();

		NhanVien nv = new NhanVien(1, "Doan Van Nga", "HCM", 123432534, 0, 1500000,25);
		this.lDSNhanVien.add(nv);
		nv = new NhanVien(2, "Nguyen Thi Tuyet Mai", "HCM", 1234356594, 1, 1500000,26);
		this.lDSNhanVien.add(nv);
		
		DauSachKhoaHoc Temp1 = new DauSachKhoaHoc("KH101", "Cac nguyen to hoa hoc", "DHQG", "Nguyen Van A", 10000, "Hoa hoc");
		QuyenSachKhoaHoc Temp2 = new QuyenSachKhoaHoc("KH101", "Cac nguyen to hoa hoc", "DHQG", "Nguyen Van A", 10000, "Hoa hoc", 1);
		Temp1.lDSQuyenSach.add(Temp2);
		Temp1.iSoLuongTrongThuVien++;
		Temp2 = new QuyenSachKhoaHoc("KH101", "Cac nguyen to hoa hoc", "DHQG", "Nguyen Van A", 100000, "Hoa hoc", 2);
		Temp1.lDSQuyenSach.add(Temp2);
		Temp1.iSoLuongTrongThuVien++;
		this.lDSDauSachKH.add(Temp1);

		Temp1 = new DauSachKhoaHoc("KH102", "Cac thuyet tien hoa", "DHQG", "Nguyen Van C", 10000, "Sinh hoc");
		Temp2 = new QuyenSachKhoaHoc("KH102", "Cac thuyet tien hoa", "DHQG", "Nguyen Van C", 10000, "Sinh hoc", 3);
		Temp1.lDSQuyenSach.add(Temp2);
		Temp1.iSoLuongTrongThuVien++;
		Temp2 = new QuyenSachKhoaHoc("KH102", "Cac thuyet tien hoa", "DHQG", "Nguyen Van C", 10000, "Sinh hoc", 4);
		Temp1.lDSQuyenSach.add(Temp2);
		Temp1.iSoLuongTrongThuVien++;
		this.lDSDauSachKH.add(Temp1);

		Temp1 = new DauSachKhoaHoc("KH103", "Song luong tu", "SPKT", "Nguyen Thi Kha", 15000, "Vat Ly");
		Temp2 = new QuyenSachKhoaHoc("KH103", "Song luong tu", "SPKT", "Nguyen Thi Kha", 15000, "Vat Ly", 3);
		Temp1.lDSQuyenSach.add(Temp2);
		Temp1.iSoLuongTrongThuVien++;
		Temp2 = new QuyenSachKhoaHoc("KH103", "Song luong tu", "SPKT", "Nguyen Thi Kha", 15000, "Vat Ly", 4);
		Temp1.lDSQuyenSach.add(Temp2);
		Temp1.iSoLuongTrongThuVien++;
		this.lDSDauSachKH.add(Temp1);


		DauSachGiaoTrinh Temp3 = new DauSachGiaoTrinh("GT101", "Cau truc du lieu va giai thuat", "SPKT", "Nguyen Van B", 20000, "CTDL");
		QuyenSachGiaoTrinh Temp4 = new QuyenSachGiaoTrinh("GT101", "Cau truc du lieu va giai thuat", "SPKT", "Nguyen Van B", 20000, "CTDL", 1, 1);
		Temp3.lDSQuyenSach.add(Temp4);
		Temp3.iSoLuongTrongThuVien++;
		Temp4 = new QuyenSachGiaoTrinh("GT101", "Cau truc du lieu va giai thuat", "SPKT", "Nguyen Van B", 20000, "CTDL", 1, 2);
		Temp3.lDSQuyenSach.add(Temp4);
		Temp3.iSoLuongTrongThuVien++;
		this.lDSDauSachGT.add(Temp3);

		Temp3 = new DauSachGiaoTrinh("GT102", "Co so du lieu", "SPKT", "Nguyen Van A", 20000, "CSDL");
		Temp4 = new QuyenSachGiaoTrinh("GT102", "Co so du lieu", "SPKT", "Nguyen Van A", 20000, "CSDL", 1, 1);
		Temp3.lDSQuyenSach.add(Temp4);
		Temp3.iSoLuongTrongThuVien++;
		Temp4 = new QuyenSachGiaoTrinh("GT102", "Co so du lieu", "SPKT", "Nguyen Van A", 20000, "CSDL", 0, 2);
		Temp3.lDSQuyenSach.add(Temp4);
		Temp3.iSoLuongTrongThuVien++;
		this.lDSDauSachGT.add(Temp3);

		Temp3 = new DauSachGiaoTrinh("GT103", "Ky Thuat lap trinh", "DHQG", "Nguyen Thi C", 20000, "KTLT");
		Temp4 = new QuyenSachGiaoTrinh("GT103", "Ky Thuat Lap Trinh", "DHQG", "Nguyen Thi C", 20000, "KTLT", 0, 1);
		Temp3.lDSQuyenSach.add(Temp4);
		Temp3.iSoLuongTrongThuVien++;
		Temp4 = new QuyenSachGiaoTrinh("GT103", "KyThuatLapTrinh", "DHQG", "Nguyen Thi C", 20000, "KTLT", 1, 2);
		Temp3.lDSQuyenSach.add(Temp4);
		Temp3.iSoLuongTrongThuVien++;
		this.lDSDauSachGT.add(Temp3);

		DocGia Temp5 = new DocGia(1,"Nguyen Huynh Anh Truc","HCM",16523536,"Truc@mail",10,12,2018,100000);
		this.lDSDocGia.add(Temp5);
		Temp5 = new DocGia(2, "Nguyen Minh Thanh ", "HCM", 1645513518, "Thanh@mail", 25, 11, 2018, 120000);
		this.lDSDocGia.add(Temp5);
		Temp5 = new DocGia(3, "Nguyen Khac Hoang Phi ", "VT", 1645513518, "Phi@mail", 30, 12, 2018, 150000);
		this.lDSDocGia.add(Temp5);
		Temp5 = new DocGia(4, "Doan Quoc Hung ", "HN", 1628953485, "Hung@mail", 6, 12, 2018, 120000);
		this.lDSDocGia.add(Temp5);
		
		
	}

	public void NhapHDMuon() throws IOException
	{
			
		HopDongMuon Temp = new HopDongMuon();
		Temp.setdgNguoiMuon(this.lDSDocGia.get(0)); 

		Temp.getlDSSachGTMuon().add(this.lDSDauSachGT.get(0).lDSQuyenSach.get(0));
		Temp.setiSoLuongSachMuon(Temp.getiSoLuongSachMuon()+1);   
		this.lDSDauSachGT.get(0).lDSQuyenSach.get(0).setbDaMuonHayChua(false) ;
		this.lDSDauSachGT.get(0).lDSQuyenSach.get(0).setdtNgayMuon(Date.SubDay(Temp.getdgNguoiMuon().getdtNgayHetHan(),50)); 
		this.lDSDauSachGT.get(0).lDSQuyenSach.get(0).XDNgayTra();
		this.lDSDauSachGT.get(0).iSoLuongTrongThuVien--;

		Temp.getlDSSachKHMuon().add(this.lDSDauSachKH.get(0).lDSQuyenSach.get(0));
		Temp.setiSoLuongSachMuon(Temp.getiSoLuongSachMuon()+1);
		this.lDSDauSachKH.get(0).lDSQuyenSach.get(0).setbDaMuonHayChua(false);
		this.lDSDauSachKH.get(0).lDSQuyenSach.get(0).setdtNgayMuon(Date.SubDay(Temp.getdgNguoiMuon().getdtNgayHetHan(),30));
		this.lDSDauSachKH.get(0).lDSQuyenSach.get(0).XDNgayTra();
		this.lDSHopDongMuon.add(Temp);
					
		Temp = new HopDongMuon();
		Temp.setdgNguoiMuon(this.lDSDocGia.get(1));
		 
		Temp.getlDSSachGTMuon().add(this.lDSDauSachGT.get(1).lDSQuyenSach.get(1));
		Temp.setiSoLuongSachMuon(Temp.getiSoLuongSachMuon()+1);   
		this.lDSDauSachGT.get(1).lDSQuyenSach.get(1).setbDaMuonHayChua(false);
		this.lDSDauSachGT.get(1).lDSQuyenSach.get(1).setdtNgayMuon(Date.SubDay(Temp.getdgNguoiMuon().getdtNgayHetHan(),150));
		this.lDSDauSachGT.get(1).lDSQuyenSach.get(1).XDNgayTra();
		this.lDSDauSachGT.get(1).iSoLuongTrongThuVien--;
		
		Temp.getlDSSachKHMuon().add(this.lDSDauSachKH.get(1).lDSQuyenSach.get(1));
		Temp.setiSoLuongSachMuon(Temp.getiSoLuongSachMuon()+1);   
		this.lDSDauSachKH.get(1).lDSQuyenSach.get(1).setbDaMuonHayChua(false);
		this.lDSDauSachKH.get(1).lDSQuyenSach.get(1).setdtNgayMuon(Date.SubDay(Temp.getdgNguoiMuon().getdtNgayHetHan(),50));
		this.lDSDauSachKH.get(1).lDSQuyenSach.get(1).XDNgayTra();
		this.lDSDauSachKH.get(1).iSoLuongTrongThuVien--;
		this.lDSHopDongMuon.add(Temp);
				
		Temp = new HopDongMuon();
		Temp.setdgNguoiMuon(this.lDSDocGia.get(2));
		this.lDSHopDongMuon.add(Temp);

		Temp = new HopDongMuon();
		Temp.setdgNguoiMuon(this.lDSDocGia.get(3));

		Temp.getlDSSachGTMuon().add(this.lDSDauSachGT.get(2).lDSQuyenSach.get(1));
		Temp.setiSoLuongSachMuon(Temp.getiSoLuongSachMuon()+1);   
		this.lDSDauSachGT.get(2).lDSQuyenSach.get(1).setbDaMuonHayChua(false);
		this.lDSDauSachGT.get(2).lDSQuyenSach.get(1).setdtNgayMuon(Date.SubDay(Temp.getdgNguoiMuon().getdtNgayHetHan(),50));
		this.lDSDauSachGT.get(2).lDSQuyenSach.get(1).XDNgayTra();
		this.lDSDauSachGT.get(2).iSoLuongTrongThuVien--;

		this.lDSHopDongMuon.add(Temp);
		
	}
	public void XuatToanBoSach()
	{
		for(int i=0;i<this.lDSDauSachGT.size();i++)
		{
			for(int j=0;j<this.lDSDauSachGT.get(i).lDSQuyenSach.size();j++)
			{
				this.lDSDauSachGT.get(i).lDSQuyenSach.get(j).Xuat();
				System.out.println("\n");
			}
		}
		for(int i=0;i<this.lDSDauSachKH.size();i++)
		{
			for(int j=0;j<this.lDSDauSachKH.get(i).lDSQuyenSach.size();j++)
			{
				this.lDSDauSachKH.get(i).lDSQuyenSach.get(j).Xuat();
				System.out.println("\n");
			}
		}
	}
	public int KiemTraViTriDocGiaTrongListHD(String  NhapVao)
	{
		for (int i = 0; i < this.lDSHopDongMuon.size(); i++)
		{
			if (this.lDSHopDongMuon.get(i).getdgNguoiMuon().getHoTen().equals(NhapVao) || this.lDSHopDongMuon.get(i).getdgNguoiMuon().getiMaDG() == Integer.parseInt(NhapVao))
			{
				return i;
			}
		}
		return -1;
	}
	public void TatCaHopDongMuon() throws IOException
	{
		for(int i=0;i<this.lDSHopDongMuon.size();i++)
		{
			this.lDSHopDongMuon.get(i).getdgNguoiMuon().Xuat();
			System.out.println(" So luong sach muon la:"+this.lDSHopDongMuon.get(i).getiSoLuongSachMuon()+"\n");
			for(int j=0;j<this.lDSHopDongMuon.get(i).getlDSSachGTMuon().size();j++)
			{
				this.lDSHopDongMuon.get(i).getlDSSachGTMuon().get(j).Xuat();
				System.out.println("\n");
			}
			for(int j=0;j<this.lDSHopDongMuon.get(i).getlDSSachKHMuon().size();j++)
			{
				this.lDSHopDongMuon.get(i).getlDSSachKHMuon().get(j).Xuat();
				System.out.println("\n");
			}
			System.out.println("=============================================================================");
		}
	}
	public void CapNhatLai() 
	{
		for(int a=0;a<this.lDSHopDongMuon.size();a++)
		{
			for(int b=0;b<this.lDSHopDongMuon.get(a).getlDSSachGTMuon().size();b++)
			{
				if(Date.SoSanhNhoHon(this.lDSHopDongMuon.get(a).getlDSSachGTMuon().get(b).getdtNgayPhaiTra(),this.dtToday )== true)
				{
					if(Date.SubDate(this.dtToday, this.lDSHopDongMuon.get(a).getlDSSachGTMuon().get(b).getdtNgayPhaiTra()) > 30)
					{
						this.lDSHopDongMuon.get(a).getdgNguoiMuon().setdTaiKhoan(this.lDSHopDongMuon.get(a).getdgNguoiMuon().getdTaiKhoan()-this.lDSHopDongMuon.get(a).getlDSSachGTMuon().get(b).dThanhTien);
						
						int Temp=KiemTraViTriSachGT(this.lDSHopDongMuon.get(a).getlDSSachGTMuon().get(b).sMaDauSach);
						for(int c=0;c<this.lDSDauSachGT.get(Temp).lDSQuyenSach.size();c++)
						{
							if(this.lDSDauSachGT.get(Temp).lDSQuyenSach.get(c).getsMaQuyenSach() == this.lDSHopDongMuon.get(a).getlDSSachGTMuon().get(b).getsMaQuyenSach())
							{
								System.out.println(" Doc gia "+this.lDSHopDongMuon.get(a).getdgNguoiMuon().getHoTen()+" lam mat sach nen cuon sach "+ this.lDSHopDongMuon.get(a).getlDSSachGTMuon().get(b).sTua+" se bi tru vao tai khoan \n");
								this.lDSDauSachGT.get(a).lDSQuyenSach.remove(this.lDSHopDongMuon.get(a).getlDSSachGTMuon().get(b));
								this.lDSDauSachGT.get(a).setiSoLuongTrongThuVien(this.lDSDauSachGT.get(a).getiSoLuongTrongThuVien()-1);
								this.lDSHopDongMuon.get(a).getlDSSachGTMuon().remove(this.lDSHopDongMuon.get(a).getlDSSachGTMuon().get(b));
								this.lDSHopDongMuon.get(a).setiSoLuongSachMuon(this.lDSHopDongMuon.get(a).getiSoLuongSachMuon()-1);
							}
						}
					}
					else 
					{
						System.out.println("Doc Gia "+ this.lDSHopDongMuon.get(a).getdgNguoiMuon().getHoTen()+" co muon cuon sach "+this.lDSHopDongMuon.get(a).getlDSSachGTMuon().get(b).sTua+" sap toi han tra \n");
					}
				}
			}
			for(int b=0;b<this.lDSHopDongMuon.get(a).getlDSSachKHMuon().size();b++)
			{
				if(Date.SoSanhNhoHon(this.lDSHopDongMuon.get(a).getlDSSachKHMuon().get(b).getdtNgayPhaiTra(),this.dtToday )== true)
				{
					if(Date.SubDate(this.dtToday, this.lDSHopDongMuon.get(a).getlDSSachKHMuon().get(b).getdtNgayPhaiTra()) > 30)
					{
						this.lDSHopDongMuon.get(a).getdgNguoiMuon().setdTaiKhoan(this.lDSHopDongMuon.get(a).getdgNguoiMuon().getdTaiKhoan()-this.lDSHopDongMuon.get(a).getlDSSachKHMuon().get(b).dThanhTien);
						
						int Temp=KiemTraViTriSachKH(this.lDSHopDongMuon.get(a).getlDSSachKHMuon().get(b).sMaDauSach);
						for(int c=0;c<this.lDSDauSachKH.get(Temp).lDSQuyenSach.size();c++)
						{
							if(this.lDSDauSachKH.get(Temp).lDSQuyenSach.get(c).getsMaQuyenSach() == this.lDSHopDongMuon.get(a).getlDSSachKHMuon().get(b).getsMaQuyenSach())
							{
								System.out.println(" Doc gia "+this.lDSHopDongMuon.get(a).getdgNguoiMuon().getHoTen()+" lam mat sach nen cuon sach "+ this.lDSHopDongMuon.get(a).getlDSSachKHMuon().get(b).sTua +" nen se bi tru vao tai khoan \n");
								this.lDSDauSachKH.get(a).lDSQuyenSach.remove(this.lDSHopDongMuon.get(a).getlDSSachKHMuon().get(b));
								this.lDSDauSachKH.get(a).setiSoLuongTrongThuVien(this.lDSDauSachKH.get(a).getiSoLuongTrongThuVien()-1);
								this.lDSHopDongMuon.get(a).getlDSSachKHMuon().remove(this.lDSHopDongMuon.get(a).getlDSSachKHMuon().get(b));
								this.lDSHopDongMuon.get(a).setiSoLuongSachMuon(this.lDSHopDongMuon.get(a).getiSoLuongSachMuon()-1);
							}
						}
					}
					else 
					{
						System.out.println("Doc Gia "+ this.lDSHopDongMuon.get(a).getdgNguoiMuon().getHoTen()+" co muon cuon sach "+this.lDSHopDongMuon.get(a).getlDSSachKHMuon().get(b).sTua+" sap toi han tra \n");
					}
				}
			}
		}
	}
	public void XacDinhLai1Nguoi(int a)
	{
		for(int b=0;b<this.lDSHopDongMuon.get(a).getlDSSachGTMuon().size();b++)
		{
			if(Date.SoSanhNhoHon(this.lDSHopDongMuon.get(a).getlDSSachGTMuon().get(b).getdtNgayPhaiTra(),this.dtToday )== true)
			{
				if(Date.SubDate(this.dtToday, this.lDSHopDongMuon.get(a).getlDSSachGTMuon().get(b).getdtNgayPhaiTra()) > 30)
				{
					this.lDSHopDongMuon.get(a).getdgNguoiMuon().setdTaiKhoan(this.lDSHopDongMuon.get(a).getdgNguoiMuon().getdTaiKhoan()-this.lDSHopDongMuon.get(a).getlDSSachGTMuon().get(b).dThanhTien);
					
					int Temp=KiemTraViTriSachGT(this.lDSHopDongMuon.get(a).getlDSSachGTMuon().get(b).sMaDauSach);
					for(int c=0;c<this.lDSDauSachGT.get(Temp).lDSQuyenSach.size();c++)
					{
						if(this.lDSDauSachGT.get(Temp).lDSQuyenSach.get(c).getsMaQuyenSach() == this.lDSHopDongMuon.get(a).getlDSSachGTMuon().get(b).getsMaQuyenSach())
						{
							System.out.println(" Doc gia "+this.lDSHopDongMuon.get(a).getdgNguoiMuon().getHoTen()+" lam mat sach nen cuon sach "+ this.lDSHopDongMuon.get(a).getlDSSachGTMuon().get(b).sTua+" nen se bi tru vao tai khoan \n");
							this.lDSDauSachGT.get(a).lDSQuyenSach.remove(this.lDSHopDongMuon.get(a).getlDSSachGTMuon().get(b));
							this.lDSDauSachGT.get(a).setiSoLuongTrongThuVien(this.lDSDauSachGT.get(a).getiSoLuongTrongThuVien()-1);
							this.lDSHopDongMuon.get(a).getlDSSachGTMuon().remove(this.lDSHopDongMuon.get(a).getlDSSachGTMuon().get(b));
							this.lDSHopDongMuon.get(a).setiSoLuongSachMuon(this.lDSHopDongMuon.get(a).getiSoLuongSachMuon()-1);
						}
					}
				}
				else 
				{
					System.out.println("Doc Gia"+ this.lDSHopDongMuon.get(a).getdgNguoiMuon().getHoTen()+" co muon cuon sach "+this.lDSHopDongMuon.get(a).getlDSSachGTMuon().get(b).sTua+" sap toi han tra \n");
				}
			}
		}
		for(int b=0;b<this.lDSHopDongMuon.get(a).getlDSSachKHMuon().size();b++)
		{
			if(Date.SoSanhNhoHon(this.lDSHopDongMuon.get(a).getlDSSachKHMuon().get(b).getdtNgayPhaiTra(),this.dtToday )== true)
			{
				if(Date.SubDate(this.dtToday, this.lDSHopDongMuon.get(a).getlDSSachKHMuon().get(b).getdtNgayPhaiTra()) > 30)
				{
					this.lDSHopDongMuon.get(a).getdgNguoiMuon().setdTaiKhoan(this.lDSHopDongMuon.get(a).getdgNguoiMuon().getdTaiKhoan()-this.lDSHopDongMuon.get(a).getlDSSachKHMuon().get(b).dThanhTien);
					
					int Temp=KiemTraViTriSachKH(this.lDSHopDongMuon.get(a).getlDSSachKHMuon().get(b).sMaDauSach);
					for(int c=0;c<this.lDSDauSachKH.get(Temp).lDSQuyenSach.size();c++)
					{
						if(this.lDSDauSachKH.get(Temp).lDSQuyenSach.get(c).getsMaQuyenSach() == this.lDSHopDongMuon.get(a).getlDSSachKHMuon().get(b).getsMaQuyenSach())
						{
							System.out.println(" Doc gia "+this.lDSHopDongMuon.get(a).getdgNguoiMuon().getHoTen()+" lam mat sach nen cuon sach "+ this.lDSHopDongMuon.get(a).getlDSSachKHMuon().get(b).sTua +" nen se bi tru vao tai khoan \n");
							this.lDSDauSachKH.get(a).lDSQuyenSach.remove(this.lDSHopDongMuon.get(a).getlDSSachKHMuon().get(b));
							this.lDSDauSachKH.get(a).setiSoLuongTrongThuVien(this.lDSDauSachKH.get(a).getiSoLuongTrongThuVien()-1);
							this.lDSHopDongMuon.get(a).getlDSSachKHMuon().remove(this.lDSHopDongMuon.get(a).getlDSSachKHMuon().get(b));
							this.lDSHopDongMuon.get(a).setiSoLuongSachMuon(this.lDSHopDongMuon.get(a).getiSoLuongSachMuon()-1);
						}
					}
				}
				else 
				{
					System.out.println("Doc Gia"+ this.lDSHopDongMuon.get(a).getdgNguoiMuon().getHoTen()+" co muon cuon sach "+this.lDSHopDongMuon.get(a).getlDSSachKHMuon().get(b).sTua+" sap toi han tra \n");
				}
			}
		}
	}
	public int KiemTraViTriSachGT(String NhapVao)
	{
		for(int i=0;i<this.lDSDauSachGT.size();i++)
		{
			if(this.lDSDauSachGT.get(i).sMaDauSach.equals(NhapVao) || this.lDSDauSachGT.get(i).sTua.equals(NhapVao))
			{
				return i;
			}
		}
		return -1;
	}
	public int KiemTraViTriSachKH(String NhapVao)
	{
		for(int i=0;i<this.lDSDauSachKH.size();i++)
		{
			if(this.lDSDauSachKH.get(i).sMaDauSach.equals(NhapVao) || this.lDSDauSachKH.get(i).sTua.equals(NhapVao))
			{
				return i;
			}
		}
		return -1;
	}
	public void TraSach(int ViTri,String MaSach,int MaQuyen)
	{
		int VT_Temp=KiemTraViTriSachGT(MaSach);
		if(VT_Temp!=-1)
		{
			for(int i=0;i<this.lDSDauSachGT.get(VT_Temp).lDSQuyenSach.size();i++)
			{
				if(this.lDSDauSachGT.get(VT_Temp).lDSQuyenSach.get(i).getsMaQuyenSach() == MaQuyen)
				{
					this.lDSDauSachGT.get(VT_Temp).lDSQuyenSach.get(i).TraSach();
					this.lDSDauSachGT.get(VT_Temp).setiSoLuongTrongThuVien(this.lDSDauSachGT.get(VT_Temp).getiSoLuongTrongThuVien()+1);
					this.lDSHopDongMuon.get(ViTri).getlDSSachGTMuon().remove(this.lDSDauSachGT.get(VT_Temp).lDSQuyenSach.get(i));
					this.lDSHopDongMuon.get(ViTri).setiSoLuongSachMuon(this.lDSHopDongMuon.get(ViTri).getiSoLuongSachMuon()-1);
					System.out.println(" Tra thanh cong ");
				}
			}
		}
		else
		{
			VT_Temp = KiemTraViTriSachKH(MaSach);
			for(int i=0;i<this.lDSDauSachKH.get(VT_Temp).lDSQuyenSach.size();i++)
			{
				if(this.lDSDauSachKH.get(VT_Temp).lDSQuyenSach.get(i).getsMaQuyenSach() == MaQuyen)
				{
					this.lDSDauSachKH.get(VT_Temp).lDSQuyenSach.get(i).TraSach();
					this.lDSDauSachKH.get(VT_Temp).setiSoLuongTrongThuVien(this.lDSDauSachKH.get(VT_Temp).getiSoLuongTrongThuVien()+1);
					this.lDSHopDongMuon.get(ViTri).getlDSSachKHMuon().remove(this.lDSDauSachKH.get(VT_Temp).lDSQuyenSach.get(i));
					this.lDSHopDongMuon.get(ViTri).setiSoLuongSachMuon(this.lDSHopDongMuon.get(ViTri).getiSoLuongSachMuon()-1);
					System.out.println(" Tra thanh cong ");
				}
			}
		}
	}
	public void MuonSach(int ViTriDocGia)
	{
		@SuppressWarnings("resource")
		Scanner sc = new Scanner(System.in);
		System.out.print("Ban muon muon sach khoa hoc hay sach giao trinh(0 la KH, 1 la GT): ");
		int KHhayGT = sc.nextInt();
		switch(KHhayGT)
		{
		
		case 0:
		{
			if(Date.SoSanhLonHon(this.lDSHopDongMuon.get(ViTriDocGia).getdgNguoiMuon().getdtNgayHetHan(),this.dtToday)==true)
			{
				if(Date.SubDate(this.lDSHopDongMuon.get(ViTriDocGia).getdgNguoiMuon().getdtNgayHetHan(),this.dtToday) <= 30)
						{
							System.out.println(" Khong du dieu kien thoi gian de muon sach KH ( the chi con hieu luc duoi 1 thang ), can gia han the ");
							return ;
						}
			}
			String Temp_NhapMaTuaSach;
			System.out.println(" Nhap ma sach hoac tua sach: ");
			sc= new Scanner(System.in);
			Temp_NhapMaTuaSach = sc.nextLine();
			for(int h=0;h<this.lDSHopDongMuon.get(ViTriDocGia).getlDSSachKHMuon().size();h++)
			{
				if(this.lDSHopDongMuon.get(ViTriDocGia).getlDSSachKHMuon().get(h).getsMaDauSach() == Temp_NhapMaTuaSach)
				{
					System.out.println(" Ban da muon 1 cuon sach cung dang ma chua tra, Khong the muon tiep, Tra cuon sach cu de tiep tuc muon cuon moi nay ");
					return;
				}
			}
			int Temp_ViTriDauSach= KiemTraViTriSachKH(Temp_NhapMaTuaSach);
			if(Temp_ViTriDauSach!=-1)
			{
				if(this.lDSDauSachKH.get(Temp_ViTriDauSach).getiSoLuongTrongThuVien()>0)
				{
					int Temp_ViTriSachRong = TimSachKHChuaDuocMuon(Temp_ViTriDauSach);
					this.lDSHopDongMuon.get(ViTriDocGia).getlDSSachKHMuon().add(this.lDSDauSachKH.get(Temp_ViTriDauSach).lDSQuyenSach.get(Temp_ViTriSachRong));
					this.lDSDauSachKH.get(Temp_ViTriDauSach).lDSQuyenSach.get(Temp_ViTriSachRong).MuonNgayHomNay(dtToday);
					this.lDSDauSachKH.get(Temp_ViTriDauSach).setiSoLuongTrongThuVien(this.lDSDauSachKH.get(Temp_ViTriDauSach).getiSoLuongTrongThuVien()-1);
					this.lDSHopDongMuon.get(ViTriDocGia).setiSoLuongSachMuon(this.lDSHopDongMuon.get(ViTriDocGia).getiSoLuongSachMuon() +1);
					System.out.println("Muon thanh cong");
				}
				else 
				{
					System.out.println("Thu vien da het tua sach do");
					return;
				}
			}
			else 
			{
				System.out.println(" Ma dau sach chua ton tai hoac nhap chua dung! ");
				return;
			}
			break;
		}
		
		case 1:
		{
			if(Date.SoSanhLonHon(this.lDSHopDongMuon.get(ViTriDocGia).getdgNguoiMuon().getdtNgayHetHan(),this.dtToday)==true)
			{
				if(Date.SubDate(this.lDSHopDongMuon.get(ViTriDocGia).getdgNguoiMuon().getdtNgayHetHan(),this.dtToday) <= 30)
						{
							System.out.println(" Khong du dieu kien thoi gian de muon sach GT ( the chi con hieu luc duoi 2 thang ), can gia han the ");
							return ;
						}
			}
			String Temp_NhapMaTuaSach;
			System.out.println(" Nhap ma sach hoac tua sach: ");
			sc = new Scanner(System.in);
			Temp_NhapMaTuaSach= sc.nextLine();
			for(int h=0;h<this.lDSHopDongMuon.get(ViTriDocGia).getlDSSachGTMuon().size();h++)
			{
				if(this.lDSHopDongMuon.get(ViTriDocGia).getlDSSachGTMuon().get(h).getsMaDauSach() == Temp_NhapMaTuaSach)
				{
					System.out.println(" Ban da muon 1 cuon sach cung dang ma chua tra, Khong the muon tiep, Tra cuon sach cu de tiep tuc muon cuon moi nay ");
					return;
				}
			}
			int Temp_ViTriDauSach= KiemTraViTriSachGT(Temp_NhapMaTuaSach);
			if(Temp_ViTriDauSach!=-1)
			{
				if(this.lDSDauSachGT.get(Temp_ViTriDauSach).getiSoLuongTrongThuVien()>0)
				{
					int Temp_ViTriSachRong = TimSachGTChuaDuocMuon(Temp_ViTriDauSach);
					this.lDSHopDongMuon.get(ViTriDocGia).getlDSSachGTMuon().add(this.lDSDauSachGT.get(Temp_ViTriDauSach).lDSQuyenSach.get(Temp_ViTriSachRong));
					this.lDSDauSachGT.get(Temp_ViTriDauSach).lDSQuyenSach.get(Temp_ViTriSachRong).MuonNgayHomNay(dtToday);
					this.lDSDauSachGT.get(Temp_ViTriDauSach).setiSoLuongTrongThuVien(this.lDSDauSachGT.get(Temp_ViTriDauSach).getiSoLuongTrongThuVien()-1);
					this.lDSHopDongMuon.get(ViTriDocGia).setiSoLuongSachMuon(this.lDSHopDongMuon.get(ViTriDocGia).getiSoLuongSachMuon() +1);
					System.out.println("Muon thanh cong");
				}
				else 
				{
					System.out.println("Thu vien da het tua sach do");
					return;
				}
			}
			else 
			{
				System.out.println(" Ma dau sach chua ton tai hoac nhap chua dung! ");
				return;
			}
			break;
		}
		
		default:
		{
			break;
		}
		}
	}
	public int TimSachKHChuaDuocMuon(int ViTriDauSach)
	{
		for (int i = 0; i < this.lDSDauSachKH.get(ViTriDauSach).getlDSQuyenSach().size(); i++)
		{
			if(this.lDSDauSachKH.get(ViTriDauSach).getlDSQuyenSach().get(i).getbDaMuonHayChua()==true)
			{
				return i;
			}
		}
		return -1;
	}
	public int TimSachGTChuaDuocMuon(int ViTriDauSach)
	{
		for (int i = 0; i < this.lDSDauSachGT.get(ViTriDauSach).getlDSQuyenSach().size(); i++)
		{
			if(this.lDSDauSachGT.get(ViTriDauSach).getlDSQuyenSach().get(i).getbDaMuonHayChua()==true)
			{
				return i;
			}
		}
		return -1;
	}
	public void ThongTinDocGiaTrongHD(int ViTri) throws IOException
	{
		XacDinhLai1Nguoi(ViTri);
		this.getlDSHopDongMuon().get(ViTri).getdgNguoiMuon().Xuat();
		System.out.println(" So luong sach muon: "+this.getlDSHopDongMuon().get(ViTri).getiSoLuongSachMuon());
		System.out.println("Bao gom \n");
		for(int i =0;i<this.getlDSHopDongMuon().get(ViTri).getlDSSachGTMuon().size();i++)
		{
			this.lDSHopDongMuon.get(ViTri).getlDSSachGTMuon().get(i).Xuat();
			System.out.println("\n \n");
		}
		for(int i =0;i<this.getlDSHopDongMuon().get(ViTri).getlDSSachKHMuon().size();i++)
		{
			this.lDSHopDongMuon.get(ViTri).getlDSSachKHMuon().get(i).Xuat();
			System.out.println("\n \n");
		}
	}
	public void DangKyTaiKhoanMoi(Date Today) throws IOException
	{
		DocGia NguoiDangKy = new DocGia();
		NguoiDangKy.Nhap();
		NguoiDangKy.setiMaDG(this.lDSDocGia.get(this.getlDSDocGia().size() - 1).getiMaDG() + 1); 
		NguoiDangKy.DangKyTaiKhoanMoi(Today);
		this.lDSDocGia.add(NguoiDangKy);
		HopDongMuon Temp_HD = new HopDongMuon();
		Temp_HD.setdgNguoiMuon(NguoiDangKy);
		this.lDSHopDongMuon.add(Temp_HD);
		System.out.println(" Dang ky thanh cong! ");
	}
	public void ThemSachKH(String MaMauSach)
	{
		int ViTriDauSach = KiemTraViTriSachKH(MaMauSach);
		if(ViTriDauSach!=-1)
		{
			System.out.println(" Ban muon nhap vao thu vien bao nhieu quyen loai nay : ");
			@SuppressWarnings("resource")
			Scanner sc = new Scanner(System.in);
			int soluong = sc.nextInt();
			int SoLuongBanDau = this.lDSDauSachKH.get(ViTriDauSach).lDSQuyenSach.size();
			int dem=1;
			for(int i=SoLuongBanDau;i<SoLuongBanDau+soluong;i++)
			{
				QuyenSachKhoaHoc QuyenSachKH_Temp = new QuyenSachKhoaHoc();
				if(this.lDSDauSachKH.get(ViTriDauSach).lDSQuyenSach.size()!=0)
				{
					QuyenSachKH_Temp = new QuyenSachKhoaHoc(this.lDSDauSachKH.get(ViTriDauSach).sMaDauSach, this.lDSDauSachKH.get(ViTriDauSach).sTua, this.lDSDauSachKH.get(ViTriDauSach).sNXB, this.lDSDauSachKH.get(ViTriDauSach).sTacGia,this.lDSDauSachKH.get(ViTriDauSach).dGia,this.lDSDauSachKH.get(ViTriDauSach).sChuyenNganh, (this.lDSDauSachKH.get(ViTriDauSach).lDSQuyenSach.get(this.lDSDauSachKH.get(ViTriDauSach).lDSQuyenSach.size()-1).getsMaQuyenSach() + 1));
				}
				else 
				{
					QuyenSachKH_Temp = new QuyenSachKhoaHoc(this.lDSDauSachKH.get(ViTriDauSach).sMaDauSach, this.lDSDauSachKH.get(ViTriDauSach).sTua, this.lDSDauSachKH.get(ViTriDauSach).sNXB, this.lDSDauSachKH.get(ViTriDauSach).sTacGia,this.lDSDauSachKH.get(ViTriDauSach).dGia,this.lDSDauSachKH.get(ViTriDauSach).sChuyenNganh, 1); 
				}
				this.lDSDauSachKH.get(ViTriDauSach).lDSQuyenSach.add(QuyenSachKH_Temp);
				this.lDSDauSachKH.get(ViTriDauSach).setiSoLuongTrongThuVien(this.lDSDauSachKH.get(ViTriDauSach).getiSoLuongTrongThuVien()+1);
				dem++;
				System.out.println(" Da them vao cuon thu "+(dem-1));
			}
			System.out.println(" Da them "+soluong+" cuon sach "+this.lDSDauSachKH.get(ViTriDauSach).sTua);
		}
		else 
		{
			System.out.println("Chua ton tai dau sach, xin moi them moi dau sach! ");
			DauSachKhoaHoc DauSachKH_Temp = new DauSachKhoaHoc();
			DauSachKH_Temp.Nhap();
			this.lDSDauSachKH.add(DauSachKH_Temp);
			ViTriDauSach = KiemTraViTriSachKH(DauSachKH_Temp.sMaDauSach);
			
			System.out.println(" Ban muon nhap vao thu vien bao nhieu quyen loai nay : ");
			@SuppressWarnings("resource")
			Scanner sc = new Scanner(System.in);
			int soluong = sc.nextInt();
			int SoLuongBanDau = this.lDSDauSachKH.get(ViTriDauSach).lDSQuyenSach.size();
			int dem=1;
			for(int i=SoLuongBanDau;i<SoLuongBanDau+soluong;i++)
			{
				QuyenSachKhoaHoc QuyenSachKH_Temp = new QuyenSachKhoaHoc();
				if(this.lDSDauSachKH.get(ViTriDauSach).lDSQuyenSach.size() !=0 )
				{
					QuyenSachKH_Temp = new QuyenSachKhoaHoc(this.lDSDauSachKH.get(ViTriDauSach).sMaDauSach, this.lDSDauSachKH.get(ViTriDauSach).sTua, this.lDSDauSachKH.get(ViTriDauSach).sNXB, this.lDSDauSachKH.get(ViTriDauSach).sTacGia,this.lDSDauSachKH.get(ViTriDauSach).dGia,this.lDSDauSachKH.get(ViTriDauSach).sChuyenNganh, (this.lDSDauSachKH.get(ViTriDauSach).lDSQuyenSach.get(this.lDSDauSachKH.get(ViTriDauSach).lDSQuyenSach.size()-1).getsMaQuyenSach() + 1));
				}
				else 
				{
					QuyenSachKH_Temp = new QuyenSachKhoaHoc(this.lDSDauSachKH.get(ViTriDauSach).sMaDauSach, this.lDSDauSachKH.get(ViTriDauSach).sTua, this.lDSDauSachKH.get(ViTriDauSach).sNXB, this.lDSDauSachKH.get(ViTriDauSach).sTacGia,this.lDSDauSachKH.get(ViTriDauSach).dGia,this.lDSDauSachKH.get(ViTriDauSach).sChuyenNganh, 1); 
				}
				this.lDSDauSachKH.get(ViTriDauSach).lDSQuyenSach.add(QuyenSachKH_Temp);
				this.lDSDauSachKH.get(ViTriDauSach).setiSoLuongTrongThuVien(this.lDSDauSachKH.get(ViTriDauSach).getiSoLuongTrongThuVien()+1);
				dem++;
				System.out.println(" Da them vao cuon thu "+(dem-1));
			}
			System.out.println(" Da them "+soluong+" cuon sach "+this.lDSDauSachKH.get(ViTriDauSach).sTua);
		}
	}
	
	public void ThemSachGT(String MaMauSach)
	{
		int ViTriDauSach = KiemTraViTriSachGT(MaMauSach);
		if(ViTriDauSach!=-1)
		{
			System.out.println(" Ban muon nhap vao thu vien bao nhieu quyen loai nay : ");
			@SuppressWarnings("resource")
			Scanner sc = new Scanner(System.in);
			int soluong = sc.nextInt();
			int SoLuongBanDau = this.lDSDauSachGT.get(ViTriDauSach).lDSQuyenSach.size();
			int dem=1;
			for(int i=SoLuongBanDau;i<SoLuongBanDau+soluong;i++)
			{
				
				System.out.println(" Nhap vao trinh trang cuon sach thu "+dem+" (0 la cu, 1 la moi): ");
				@SuppressWarnings("resource")
				Scanner sc1= new Scanner(System.in);
				int TinhTrang_Temp = sc1.nextInt();
				QuyenSachGiaoTrinh QuyenSachGT_Temp = new QuyenSachGiaoTrinh();
				if(this.lDSDauSachGT.get(ViTriDauSach).lDSQuyenSach.size()!=0)
				{
				 QuyenSachGT_Temp = new QuyenSachGiaoTrinh(this.lDSDauSachGT.get(ViTriDauSach).sMaDauSach, this.lDSDauSachGT.get(ViTriDauSach).sTua, this.lDSDauSachGT.get(ViTriDauSach).sNXB, this.lDSDauSachGT.get(ViTriDauSach).sTacGia,this.lDSDauSachGT.get(ViTriDauSach).dGia,this.lDSDauSachGT.get(ViTriDauSach).sBoMon, TinhTrang_Temp , (this.lDSDauSachGT.get(ViTriDauSach).lDSQuyenSach.get(this.lDSDauSachGT.get(ViTriDauSach).lDSQuyenSach.size()-1).getsMaQuyenSach() + 1));
				}
				else 
				{
				 QuyenSachGT_Temp = new QuyenSachGiaoTrinh(this.lDSDauSachGT.get(ViTriDauSach).sMaDauSach, this.lDSDauSachGT.get(ViTriDauSach).sTua, this.lDSDauSachGT.get(ViTriDauSach).sNXB, this.lDSDauSachGT.get(ViTriDauSach).sTacGia,this.lDSDauSachGT.get(ViTriDauSach).dGia,this.lDSDauSachGT.get(ViTriDauSach).sBoMon, TinhTrang_Temp , 1);	
				}
				this.lDSDauSachGT.get(ViTriDauSach).lDSQuyenSach.add(QuyenSachGT_Temp);
				this.lDSDauSachGT.get(ViTriDauSach).setiSoLuongTrongThuVien(this.lDSDauSachGT.get(ViTriDauSach).getiSoLuongTrongThuVien()+1);
				dem++;
				System.out.println(" Da them vao cuon thu "+(dem-1));
			}
			System.out.println(" Da them "+soluong+" cuon sach "+this.lDSDauSachGT.get(ViTriDauSach).sTua);
		}
		else 
		{
			System.out.println("Chua ton tai dau sach, xin moi them moi dau sach! ");
			DauSachGiaoTrinh DauSachGT_Temp = new DauSachGiaoTrinh();
			DauSachGT_Temp.Nhap();
			this.lDSDauSachGT.add(DauSachGT_Temp);
			ViTriDauSach = KiemTraViTriSachGT(DauSachGT_Temp.sMaDauSach);
			
			System.out.println(" Ban muon nhap vao thu vien bao nhieu quyen loai nay : ");
			@SuppressWarnings("resource")
			Scanner sc = new Scanner(System.in);
			int soluong = sc.nextInt();
			int SoLuongBanDau = this.lDSDauSachGT.get(ViTriDauSach).lDSQuyenSach.size();
			int dem=1;
			for(int i=SoLuongBanDau;i<SoLuongBanDau+soluong;i++)
			{
				
				System.out.println(" Nhap vao trinh trang cuon sach thu "+dem+" (0 la cu, 1 la moi): ");
				@SuppressWarnings("resource")
				Scanner sc1= new Scanner(System.in);
				int TinhTrang_Temp = sc1.nextInt();
				QuyenSachGiaoTrinh QuyenSachGT_Temp = new QuyenSachGiaoTrinh();
				if(this.lDSDauSachGT.get(ViTriDauSach).lDSQuyenSach.size()!=0)
				{
				 QuyenSachGT_Temp = new QuyenSachGiaoTrinh(this.lDSDauSachGT.get(ViTriDauSach).sMaDauSach, this.lDSDauSachGT.get(ViTriDauSach).sTua, this.lDSDauSachGT.get(ViTriDauSach).sNXB, this.lDSDauSachGT.get(ViTriDauSach).sTacGia,this.lDSDauSachGT.get(ViTriDauSach).dGia,this.lDSDauSachGT.get(ViTriDauSach).sBoMon, TinhTrang_Temp , (this.lDSDauSachGT.get(ViTriDauSach).lDSQuyenSach.get(this.lDSDauSachGT.get(ViTriDauSach).lDSQuyenSach.size()-1).getsMaQuyenSach() + 1));
				}
				else 
				{
				 QuyenSachGT_Temp = new QuyenSachGiaoTrinh(this.lDSDauSachGT.get(ViTriDauSach).sMaDauSach, this.lDSDauSachGT.get(ViTriDauSach).sTua, this.lDSDauSachGT.get(ViTriDauSach).sNXB, this.lDSDauSachGT.get(ViTriDauSach).sTacGia,this.lDSDauSachGT.get(ViTriDauSach).dGia,this.lDSDauSachGT.get(ViTriDauSach).sBoMon, TinhTrang_Temp , 1);	
				}
				this.lDSDauSachGT.get(ViTriDauSach).lDSQuyenSach.add(QuyenSachGT_Temp);
				this.lDSDauSachGT.get(ViTriDauSach).setiSoLuongTrongThuVien(this.lDSDauSachGT.get(ViTriDauSach).getiSoLuongTrongThuVien()+1);
				dem++;
				System.out.println(" Da them vao cuon thu "+(dem-1));
			}
			System.out.println(" Da them "+soluong+" cuon sach "+this.lDSDauSachGT.get(ViTriDauSach).sTua);
		}
	}
	public void XoaSachKH(String MaDauSach)
	{
		int ViTriDauSach = KiemTraViTriSachKH(MaDauSach);
		if(ViTriDauSach!=-1)
		{
			System.out.println(" Ban muon xoa khoi thu vien bao nhieu quyen sach loai nay: ");
			@SuppressWarnings("resource")
			Scanner sc = new Scanner(System.in);
			int soluong= sc.nextInt();
			if(soluong > this.lDSDauSachKH.get(ViTriDauSach).getiSoLuongTrongThuVien())
			{
				System.out.println(" So luong sach con lai trong thu vien nho hon so sach ban muon xoa! ");
				return;
			}
			else 
			{
				int dem=0;
				int i=0;
				do 
				{
					int Temp=dem;
					if(this.lDSDauSachKH.get(ViTriDauSach).lDSQuyenSach.get(i).getbDaMuonHayChua() == true)
					{
						this.lDSDauSachKH.get(ViTriDauSach).lDSQuyenSach.remove(this.lDSDauSachKH.get(ViTriDauSach).lDSQuyenSach.get(i));
						this.lDSDauSachKH.get(ViTriDauSach).setiSoLuongTrongThuVien(	this.lDSDauSachKH.get(ViTriDauSach).getiSoLuongTrongThuVien()-1);
						dem++;
					}
					if(dem!=Temp)
					{
						i=0;
					}
				
					else 
					{
						i++;
					}
				}while(dem!=soluong);
				System.out.println("Xoa thanh cong "+soluong+" cuon ");
			}
		}
		else
		{
			System.out.println(" Khong ton tai dau sach! ");
		}
	}
	public void XoaSachGT(String MaDauSach)
	{
		int ViTriDauSach = KiemTraViTriSachGT(MaDauSach);
		if(ViTriDauSach!=-1)
		{
			System.out.println(" Ban muon xoa khoi thu vien bao nhieu quyen sach loai nay: ");
			@SuppressWarnings("resource")
			Scanner sc = new Scanner(System.in);
			int soluong= sc.nextInt();
			if(soluong > this.lDSDauSachGT.get(ViTriDauSach).getiSoLuongTrongThuVien())
			{
				System.out.println(" So luong sach con lai trong thu vien nho hon so sach ban muon xoa! ");
				return;
			}
			else 
			{
				int dem=0;
				int i=0;
				do 
				{
					int Temp = dem;
					if( this.lDSDauSachGT.get(ViTriDauSach).lDSQuyenSach.get(i).getbDaMuonHayChua() == true)
					{
						this.lDSDauSachGT.get(ViTriDauSach).lDSQuyenSach.remove(this.lDSDauSachGT.get(ViTriDauSach).lDSQuyenSach.get(i));
						this.lDSDauSachGT.get(ViTriDauSach).setiSoLuongTrongThuVien(	this.lDSDauSachGT.get(ViTriDauSach).getiSoLuongTrongThuVien()-1);
						dem++;
					}
					if(dem!=Temp)
					{
						i=0;
					}
					else 
					{
						i++;
					}
				}while(dem!=soluong);
				System.out.println("Xoa thanh cong "+soluong+" cuon ");
			}
		}
		else
		{
			System.out.println(" Khong ton tai dau sach! ");
		}
	}
	public void TimKiemThongTinDauSach(String MaDauSach)
	{		
	int ViTriDauSach = KiemTraViTriSachKH(MaDauSach);
	if (ViTriDauSach != -1)
	{
		System.out.println("Thong tin dau sach ");
		this.lDSDauSachKH.get(ViTriDauSach).Xuat();
		System.out.print("Ban co muon tim kiem sau hon thong tin 1 cuon sach thuoc dau sach do ? (0 la khong, 1 la co): ");
		@SuppressWarnings("resource")
		Scanner sc = new Scanner(System.in);
		int Temp = sc.nextInt();
		if (Temp == 1)
		{
			System.out.println(" Xin nhap ma quyen sach ");
			sc = new Scanner(System.in);
			int MaQuyen = sc.nextInt();
			for (int i = 0; i < this.lDSDauSachKH.get(ViTriDauSach).lDSQuyenSach.size(); i++)
			{
				if (this.lDSDauSachKH.get(ViTriDauSach).lDSQuyenSach.get(i).getsMaQuyenSach() == MaQuyen)
				{
					System.out.println(" Thong tin chi tiet quyen sach la :");
					this.lDSDauSachKH.get(ViTriDauSach).lDSQuyenSach.get(i).Xuat();
					return;
				}
			}
			System.out.println("Khong ton tai quyen sach nao co ma trung voi ma ban nhap! ");
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
			System.out.println("Thong tin dau sach ");
			this.lDSDauSachGT.get(ViTriDauSach).Xuat();
			System.out.print("Ban co muon tim kiem sau hon thong tin 1 cuon sach thuoc dau sach do ? (0 la khong, 1 la co): ");
			@SuppressWarnings("resource")
			Scanner sc = new Scanner(System.in);
			int Temp = sc.nextInt();
			if (Temp == 1)
			{
				System.out.println(" Xin nhap ma quyen sach ");
				sc = new Scanner(System.in);
				int MaQuyen = sc.nextInt();
				for (int i = 0; i < this.lDSDauSachGT.get(ViTriDauSach).lDSQuyenSach.size(); i++)
				{
					if (this.lDSDauSachGT.get(ViTriDauSach).lDSQuyenSach.get(i).getsMaQuyenSach() == MaQuyen)
					{
						System.out.println(" Thong tin chi tiet quyen sach la :");
						this.lDSDauSachGT.get(ViTriDauSach).lDSQuyenSach.get(i).Xuat();
						return;
					}
				}
				System.out.println("Khong ton tai quyen sach nao co ma trung voi ma ban nhap! ");
				return;
			}
			if (Temp == 0)
			{
				return;
			}
		}
		else 
		{
			System.out.println(" Khong ton tai ma sach do trong thu vien ");
		}
	}	
	}
	public void XuatTatCaNhanVien() throws IOException
	{
		System.out.println("\n");
		for (NhanVien c : this.lDSNhanVien)
		{
			c.Xuat();
			System.out.println("\n");
		}
	}
	public void DangKyNhanVienMoi() throws IOException
	{
		NhanVien NguoiDangKy = new NhanVien();
		NguoiDangKy.Nhap();
		NguoiDangKy.setiMaNV( (this.getlDSNhanVien().get(this.getlDSNhanVien().size() - 1).getiMaNV() + 1));
		this.lDSNhanVien.add(NguoiDangKy);
	}
	public void XuatRaTatCaSachKHDaDuocMuon()
	{
		int i = 0;
		while (i != this.lDSDauSachKH.size())
		{
			for(QuyenSachKhoaHoc c : this.lDSDauSachKH.get(i).lDSQuyenSach)
			{
				if(c.getbDaMuonHayChua() == false)
				{
				c.Xuat();
				System.out.println("\n");
				}
			}
			i++;
		}
	}
	public void XuatRaTatCaSachGTDaDuocMuon()
	{
		int i = 0;
		while (i != this.lDSDauSachGT.size())
		{
			for(QuyenSachGiaoTrinh c : this.lDSDauSachGT.get(i).lDSQuyenSach)
			{
				if(c.getbDaMuonHayChua() == false)
				{
				c.Xuat();
				System.out.println("\n");
				}
			}
			i++;
		}
	}
	public void XuatRaTatCaSachKHNamTrongThuVien()
	{
		int i = 0;
		while (i != this.lDSDauSachKH.size())
		{
			for(QuyenSachKhoaHoc c : this.lDSDauSachKH.get(i).lDSQuyenSach)
			{
				if(c.getbDaMuonHayChua() == true)
				{
				c.Xuat();
				System.out.println("\n");
				}
			}
			i++;
		}
	}
	public void XuatRaTatCaSachGTNamTrongThuVien()
	{

		int i = 0;
		while (i != this.lDSDauSachGT.size())
		{
			for(QuyenSachGiaoTrinh c : this.lDSDauSachGT.get(i).lDSQuyenSach)
			{
				if(c.getbDaMuonHayChua() == true)
				{
				c.Xuat();
				System.out.println("\n");
				}
			}
			i++;
		}
	}
	public void XuatRaDanhSachDocGia() throws IOException
	{
		for(DocGia c : this.lDSDocGia)
		{
			c.Xuat();
			System.out.println("\n");
		}
	}	
	public void DocGiaMuonNhieuNhat() throws IOException
	{
		int Max=this.lDSHopDongMuon.get(0).getiSoLuongSachMuon();
		for(HopDongMuon c : this.lDSHopDongMuon)
		{
			if(c.getiSoLuongSachMuon()>=Max)
			{
				Max = c.getiSoLuongSachMuon();
			}
		}
		for(HopDongMuon d:this.lDSHopDongMuon)
		{
			if(d.getiSoLuongSachMuon()==Max)
			{
				d.getdgNguoiMuon().Xuat();
				System.out.println(" So luong sach muon la: "+d.getiSoLuongSachMuon()+"\n");
			}
		}
		
	}
	public void SachSapToiHanTra()
	{
		int i = 0;
		while (i != this.lDSDauSachGT.size())
		{
			ArrayList<QuyenSachGiaoTrinh> Temp = new ArrayList<QuyenSachGiaoTrinh>();
			for(QuyenSachGiaoTrinh c :this.lDSDauSachGT.get(i).lDSQuyenSach)
			{
				if(c.getbDaMuonHayChua() == false && Date.SoSanhLonHon(c.getdtNgayPhaiTra(),this.dtToday)==true && Date.SubDate(c.getdtNgayPhaiTra(), this.dtToday)<60 )
				{
					Temp.add(c);
				}
			}
			for(QuyenSachGiaoTrinh c : Temp)
			{
				c.Xuat();
				System.out.println("\n");
			}
			i++;
		}
		i = 0;
		while (i != this.lDSDauSachKH.size())
		{
			ArrayList<QuyenSachKhoaHoc> Temp = new ArrayList<QuyenSachKhoaHoc>();
			for(QuyenSachKhoaHoc c :this.lDSDauSachKH.get(i).lDSQuyenSach)
			{
				if(c.getbDaMuonHayChua() == false && Date.SoSanhLonHon(c.getdtNgayPhaiTra(),this.dtToday)==true && Date.SubDate(c.getdtNgayPhaiTra(), this.dtToday)<60 )
				{
					Temp.add(c);
				}
			}
			for(QuyenSachKhoaHoc c : Temp)
			{
				c.Xuat();
				System.out.println("\n");
			}
			i++;
		}
	}
	public void DocGiaSapHetHanThe() throws IOException
	{
		for(DocGia c: this.lDSDocGia)
		{
			if(Date.SoSanhNhoHon(c.getdtNgayHetHan(),this.dtToday))
			{
				c.Xuat();
				System.out.println("\n");
			}
		}
		for(DocGia c: this.lDSDocGia)
		{
			if(Date.SoSanhLonHon(c.getdtNgayHetHan(),this.dtToday)&&Date.SubDate(c.getdtNgayHetHan(), this.dtToday)<30)
			{
				c.Xuat();
				System.out.println("\n");
			}
		}
	}
	public void SachLonHonTienCuThe(double Tien)
	{
		for(DauSachGiaoTrinh d:this.lDSDauSachGT)
		{
			for(QuyenSachGiaoTrinh c: d.lDSQuyenSach )
			{
				if(c.dThanhTien>=Tien)
				{
					c.Xuat();
					System.out.println(" Thanh tien: "+ c.dThanhTien +"\n");
				}
			}
		}
		for(DauSachKhoaHoc d:this.lDSDauSachKH)
		{
			for(QuyenSachKhoaHoc c: d.lDSQuyenSach )
			{
				if(c.dThanhTien>=Tien)
				{
					c.Xuat();
					System.out.println(" Thanh tien: "+ c.dThanhTien +"\n");
				}
			}
		}
	}
	public void ThongKeSoSach()
	{
		int tongsach=0;
		int sachmuon=0;
		for(int i=0;i<this.lDSDauSachGT.size();i++)
		{
			for(int j=0;j<this.lDSDauSachGT.get(i).lDSQuyenSach.size();j++)
			{
				if(this.lDSDauSachGT.get(i).lDSQuyenSach.get(j).getbDaMuonHayChua()==false)
				{
					sachmuon++;
				}
				tongsach++;
			}
		}
		for(int i=0;i<this.lDSDauSachKH.size();i++)
		{
			for(int j=0;j<this.lDSDauSachKH.get(i).lDSQuyenSach.size();j++)
			{
				if(this.lDSDauSachKH.get(i).lDSQuyenSach.get(j).getbDaMuonHayChua()==false)
				{
					sachmuon++;
				}
				tongsach++;
			}
		}
		System.out.println(" Tong so sach la: "+tongsach);
		System.out.println(" So sach muon la: " + sachmuon);
		System.out.println(" So sach nam trong thu vien la: " + (tongsach - sachmuon));
		float PhanTramMuon = ((sachmuon * 100) / tongsach);
		System.out.println(" Phan tram cua so sach muon so voi tong so sach la: "+PhanTramMuon+ "%");
		PhanTramMuon = 100 - PhanTramMuon;
		System.out.println(" Phan tram cua so sach nam torng thu vien so voi tong so sach la: " + PhanTramMuon+"%");
	}
	public void TatCaHopDong() throws IOException
	{
		for(HopDongMuon c : this.lDSHopDongMuon)
		{
			c.getdgNguoiMuon().Xuat();
			System.out.println(" So luong sach muon la:" + c.getiSoLuongSachMuon() + "\n");
			for(QuyenSachGiaoTrinh a : c.getlDSSachGTMuon())
			{
				a.Xuat();
				System.out.println("\n");
			}
			for(QuyenSachKhoaHoc a : c.getlDSSachKHMuon())
			{
				a.Xuat();
				System.out.println("\n");
			}
			System.out.println("=============================================================================");
		}
	}
}
