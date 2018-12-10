import java.io.IOException;
import java.util.Scanner;

public class NhanVien extends Nguoi
{
	private int iMaNV;
	private int iBoPhan;
	private double dLuongCB;
	private int iSoNgayCong;
	private double dLuong;


	public int getiMaNV() {
		return iMaNV;
	}
	public void setiMaNV(int iMaNV) {
		this.iMaNV = iMaNV;
	}
	public int getiBoPhan() {
		return iBoPhan;
	}
	public void setiBoPhan(int iBoPhan) {
		this.iBoPhan = iBoPhan;
	}
	public double getdLuongCB() {
		return dLuongCB;
	}
	public void setdLuongCB(double dLuongCB) {
		this.dLuongCB = dLuongCB;
	}
	public int getiSoNgayCong() {
		return iSoNgayCong;
	}
	public void setiSoNgayCong(int iSoNgayCong) {
		this.iSoNgayCong = iSoNgayCong;
	}
	public double getdLuong() {
		return dLuong;
	}
	public void setdLuong(double dLuong) {
		this.dLuong = dLuong;
	}
	public NhanVien()
	{
		super();
	}
	public NhanVien(int MaNV, String HoTen, String DiaChi, int SDT,int BoPhan, double LuongCoBan,int SoNgayCong)
	{
		super(HoTen, DiaChi, SDT);
		this.iMaNV = MaNV;
		this.iBoPhan = BoPhan;
		this.dLuongCB = LuongCoBan;
		this.iSoNgayCong = SoNgayCong;
		Tien(this.dLuongCB);
	}
	@Override 
	public void Xuat() throws IOException
	{
		super.Xuat();
		System.out.println("Ma Nhan vien: " + this.iMaNV);
		if (this.iBoPhan == 0)
		{
			System.out.println("Bo Phan: Quan ly ");
		}
		else
		{
			System.out.println("Bo Phan: Nhan vien");
		}
		System.out.println("Luong co ban: " + this.dLuongCB);
		System.out.println("Luong thuc te: " + this.dLuong);
	}
	@SuppressWarnings("resource")
	@Override 
	public void Nhap() throws IOException
	{
		super.Nhap();
		Scanner sc = new Scanner(System.in);
		System.out.print("Bo phan (0 la quan ly, 1 la nhan vien): ");
		this.iBoPhan = sc.nextInt() ;
		System.out.print("Luong co ban : ");
		this.dLuongCB = sc.nextDouble();
		System.out.print("So ngay cong: ");
		this.iBoPhan = sc.nextInt();
		Tien(this.dLuongCB);
	}
	
	@Override 
	public void Tien(double LuongCoBan)
	{
		if (this.iBoPhan == 0)
		{
			this.dLuong = (this.dLuongCB* 1.5 )+(this.dLuongCB*this.iSoNgayCong/100);
		}
		else
		{
			this.dLuong = ( this.dLuongCB )+ (this.dLuongCB * this.iSoNgayCong/100);
		}
	}
}
