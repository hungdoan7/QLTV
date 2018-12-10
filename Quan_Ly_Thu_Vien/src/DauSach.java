import java.util.Scanner;
interface DacTrungQuyenSach
{
	public void MuonNgayHomNay(Date Today);
	public void TraSach();
	public void XDNgayTra();
}
public abstract class DauSach 
{
	protected String sMaDauSach;
	protected String sTua;
	protected String sNXB;
	protected String sTacGia;
	protected int iSoLuongTrongThuVien;
	protected double dGia;
	protected double dThue;
	protected double dThanhTien;
	
	public int getiSoLuongTrongThuVien() 
	{
		return iSoLuongTrongThuVien;
	}
	public void setiSoLuongTrongThuVien(int iSoLuongTrongThuVien) 
	{
		this.iSoLuongTrongThuVien = iSoLuongTrongThuVien;
	}

	public double getdThanhTien() 
	{
		return dThanhTien;
	}
	public void setdThanhTien(double dThanhTien) 
	{
		this.dThanhTien = dThanhTien;
	}
	public String getsTenTacGia()
	{
		return this.sTacGia;
	}
	public void setsTenTacGia(String TenTacGia) 
	{
		this.sTacGia = TenTacGia;
	}
	public double getdThue() 
	{
		return this.dThue;
	}
	public void setdThue(double Tien) 
	{
		this.dThue = Tien;
	}
	public String getsMaDauSach() 
	{
		return this.sMaDauSach;
	}
	public void setsMaDauSach(String MaSach) 
	{
		this.sMaDauSach = MaSach;
	}
	public String getsNXB() 
	{
		return this.sNXB;
	}
	public void setsNXB(String NhaXuatBan) 
	{
		this.sNXB = NhaXuatBan;
	}
	public double getdGia() 
	{
		return this.dGia;
	}
	public void setdGia(double DonGia)
	{
		this.dGia = DonGia;
	}

	Scanner sScanner = new Scanner(System.in); 	
	public DauSach()
	{
		super();
	}
	public DauSach(String MaSach,String Tua,String NhaXuatBan,String TacGia, double DonGia)
	{
		super();
		this.sMaDauSach=MaSach;
		this.sTua=Tua;
		this.sNXB=NhaXuatBan;
		this.sTacGia=TacGia;
		this.dGia=DonGia;
		this.iSoLuongTrongThuVien=0;
	}
	 public void Nhap()
	 {
	        System.out.print("Nhap ma dau sach: ");
	        this.sMaDauSach = sScanner.nextLine();
	        System.out.println("Nhap tua sach: ");
	        this.sTua=sScanner.nextLine();
	        System.out.print("Nhap ten nha xuat ban: ");
	        this.sNXB = sScanner.nextLine();
	        System.out.println("Nhap tac gia: ");
	        this.sTacGia=sScanner.nextLine();
	        System.out.print("Nhap don gia: ");
	        this.dGia = sScanner.nextDouble();
	  }
	 public void Xuat()
	 {
		 	System.out.println(" Ma dau sach: "+this.sMaDauSach);
		 	System.out.println(" Tua sach: "+this.sTua);
		 	System.out.println(" NXB: "+this.sNXB);
		 	System.out.println(" Tac gia: "+this.sTacGia);
	 }
	public abstract void XacDinhThue();
	public abstract void TinhThanhTien();
}
