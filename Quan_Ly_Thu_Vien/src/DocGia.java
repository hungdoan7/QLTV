import java.io.IOException;
import java.util.Scanner;

public class DocGia extends Nguoi implements DacTrungDocGia 
{
	private int iMaDG;
	private String sEmail;
	private Date dtNgayHetHan;
	private double dTaiKhoan;
	
	public int getiMaDG() 
	{
		return iMaDG;
	}
	public void setiMaDG(int iMaDG)
	{
		this.iMaDG = iMaDG;
	}
	public String getsEmail()
	{
		return sEmail;
	}

	public void setsEmail(String sEmail)
	{
		this.sEmail = sEmail;
	}
	public double getdTaiKhoan() 
	{
		return this.dTaiKhoan;
	}

	public void setdTaiKhoan(double dTaiKhoan) 
	{
		this.dTaiKhoan = dTaiKhoan;
	}
	public Date getdtNgayHetHan() 
	{
		return dtNgayHetHan;
	}
	public void setdtNgayHetHan(Date dtNgayHetHan)
	{
		this.dtNgayHetHan = dtNgayHetHan;
	}
	
	public DocGia() 
	{
		super();
		this.dtNgayHetHan= new Date();
	}
	
	
	public DocGia (int MaDG, String HoTen, String DiaChi, int SDT, String Email, int NgayHH,int ThangHH,int NamHH, int TKSV)
	{
		super(HoTen, DiaChi, SDT);
		this.iMaDG=MaDG;
		this.sEmail= Email;
		this.dtNgayHetHan= new Date();
		this.dtNgayHetHan.setdNgay(NgayHH);
		this.dtNgayHetHan.setdThang(ThangHH);
		this.dtNgayHetHan.setdNam(NamHH);
		this.dTaiKhoan = TKSV;
	}

	@SuppressWarnings("resource")
	@Override
	public void Nhap() throws IOException 
	{
		super.Nhap();
		Scanner sc = new Scanner(System.in);
		System.out.println("Nhap  vao Email: ");
		this.sEmail = sc.nextLine();
	}
	@Override
	public void Xuat() throws IOException
	{
		super.Xuat();
		System.out.println(" Ma doc gia: "+this.iMaDG);
		System.out.println(" Email doc gia: "+this.sEmail);
		System.out.println(" Ngay het han the la: ");
		System.out.println(" Ngay: " + this.dtNgayHetHan.getiNgay());
		System.out.println(" Thang: " + this.dtNgayHetHan.getiThang());
		System.out.println(" Nam: " + this.dtNgayHetHan.getiNam());
		System.out.println(" So du tai khoan; "+this.dTaiKhoan);
		
	}
	@Override
	public void GiaHanTheThuVien(Date Today) 
	{
		if (Date.SoSanhNhoHon(Today,this.dtNgayHetHan)==true)
		{
			this.dtNgayHetHan = Date.PlusDay(this.dtNgayHetHan, 180);
			this.dTaiKhoan = this.dTaiKhoan - 50000;
		}
		else
		{
			this.dtNgayHetHan = Date.PlusDay(Today,180);
			this.dTaiKhoan = this.dTaiKhoan - 50000;
		}
	}
	@Override
	public void Tien(double Tien) 
	{
		this.dTaiKhoan = this.dTaiKhoan + Tien;
	}
	@Override
	public void DangKyTaiKhoanMoi(Date Today)
	{
		this.dtNgayHetHan = Date.PlusDay(Today,180);
		this.dTaiKhoan = 100000;
	}
}
