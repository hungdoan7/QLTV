import java.io.IOException;
import java.util.Scanner;
interface DacTrungDocGia
{
	 void GiaHanTheThuVien(Date A);	
	 void DangKyTaiKhoanMoi(Date Today);
}
public abstract  class Nguoi 
{

	protected String sHoTen;
	protected String sDiaChi;
	protected int iSDT;
	public String getHoTen()
	{
		return this.sHoTen;
	}
	public void setHoten(String a)
	{
		this.sHoTen = a;
	}
	public String getDiaChi()
	{
		return this.sHoTen;
	}
	public void setSDT(String a)
	{
		this.sHoTen = a;
	}
	public int getSDT()
	{
		return this.iSDT;
	}
	public void setSDT(int a)
	{
		this.iSDT = a;
	}

	public Nguoi(String HoTen,String DiaChi,int SDT) 
	{
		super();
		this.sHoTen=HoTen;
		this.sDiaChi=DiaChi;
		this.iSDT=SDT;
	}
	public Nguoi()
	{
		super();
	}
	@SuppressWarnings("resource")
	public void Nhap() throws IOException
	{
		Scanner sc = new Scanner(System.in);
		System.out.println("Hay nhap vao ten: ");	
		this.sHoTen = sc.nextLine();
		System.out.println(" Hay nhap vao so dien thoai");
		this.iSDT=sc.nextInt();
	}
	
	public void Xuat() throws IOException
	{
		System.out.println(" Ma la: "+this.sHoTen);
		System.out.println(" SDT la: "+this.iSDT);
		System.out.println(" Dia chi la: "+this.sDiaChi);
	}
	public abstract  void Tien(double Tien);
}
