import java.util.ArrayList;
import java.util.Scanner;

public class DauSachKhoaHoc extends DauSach
{
	protected String sChuyenNganh;
	protected ArrayList <QuyenSachKhoaHoc> lDSQuyenSach;
	
	public String getsChuyenNganh() 
	{
		return sChuyenNganh;
	}

	public void setsChuyenNganh(String sChuyenNganh)
	{
		this.sChuyenNganh = sChuyenNganh;
	}

	public ArrayList<QuyenSachKhoaHoc> getlDSQuyenSach() 
	{
		return lDSQuyenSach;
	}

	public void setlDSQuyenSach(ArrayList<QuyenSachKhoaHoc> lDSQuyenSach)
	{
		this.lDSQuyenSach = lDSQuyenSach;
	}
	public DauSachKhoaHoc()
	{
		XacDinhThue();
		this.lDSQuyenSach = new ArrayList<QuyenSachKhoaHoc>();
	}
	public DauSachKhoaHoc(String MaSach,String Tua,String NhaXuatBan, String TacGia, double DonGia,String ChuyenNganh)
	{
		super(MaSach,Tua, NhaXuatBan,TacGia, DonGia);
		this.sChuyenNganh = ChuyenNganh;
		XacDinhThue();
		this.lDSQuyenSach = new ArrayList<QuyenSachKhoaHoc>();
	}
	@SuppressWarnings("resource")
	@Override
	public void Nhap()
	{
		super.Nhap();
		Scanner sc = new Scanner(System.in);		
		System.out.print("Nhap chuyen nganh : ");
		this.sChuyenNganh = sc.nextLine();
	}	
	@Override
	public void Xuat()
	{
		super.Xuat();
		System.out.println(" Chuyen nganh: " + this.sChuyenNganh);
	}
	@Override 
	public void TinhThanhTien()
	{
	}
	@Override
	public void XacDinhThue()
	{
		this.dThue= 5;
	}
}
