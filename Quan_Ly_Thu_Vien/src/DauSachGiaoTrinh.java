import java.util.ArrayList;
import java.util.Scanner;

public class DauSachGiaoTrinh extends DauSach
{
	protected String sBoMon;
	protected ArrayList <QuyenSachGiaoTrinh> lDSQuyenSach;
	
	public String getsBoMon() 
	{
		return sBoMon;
	}

	public void setsBoMon(String sChuyenNganh)
	{
		this.sBoMon = sChuyenNganh;
	}

	public ArrayList<QuyenSachGiaoTrinh> getlDSQuyenSach() 
	{
		return lDSQuyenSach;
	}

	public void setlDSQuyenSach(ArrayList<QuyenSachGiaoTrinh> lDSQuyenSach)
	{
		this.lDSQuyenSach = lDSQuyenSach;
	}
	public DauSachGiaoTrinh()
	{
		XacDinhThue();
		this.lDSQuyenSach = new ArrayList<QuyenSachGiaoTrinh>();
	}
	public DauSachGiaoTrinh(String MaSach,String Tua,String NhaXuatBan, String TacGia, double DonGia,String BoMon)
	{
		super(MaSach,Tua, NhaXuatBan,TacGia, DonGia);
		this.sBoMon = BoMon;
		XacDinhThue();
		this.lDSQuyenSach = new ArrayList<QuyenSachGiaoTrinh>();
	}
	
	@SuppressWarnings("resource")
	@Override
	public void Nhap()
	{
		super.Nhap();
		Scanner sc = new Scanner(System.in);		
		System.out.print("Nhap bo mon: ");
		this.sBoMon = sc.nextLine();
	}	
	@Override
	public void Xuat()
	{
		super.Xuat();
		System.out.println(" Bo mon: " + this.sBoMon);
	}
	@Override 
	public void TinhThanhTien()
	{
	}
	@Override
	public void XacDinhThue()
	{
		this.dThue= 10;
	}
}
