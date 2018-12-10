
public class QuyenSachKhoaHoc extends DauSachKhoaHoc implements DacTrungQuyenSach
{
	private int sMaQuyenSach;
	private boolean bDaMuonHayChua;
	private Date dtNgayMuon;
	private Date dtNgayPhaiTra;
	
	public int getsMaQuyenSach() 
	{
		return sMaQuyenSach;
	}
	public void setsMaQuyenSach(int sMaQuyenSach) 
	{
		this.sMaQuyenSach = sMaQuyenSach;
	}
	public boolean getbDaMuonHayChua() 
	{
		return bDaMuonHayChua;
	}
	public void setbDaMuonHayChua(boolean bDaMuonHayChua)
	{
		this.bDaMuonHayChua = bDaMuonHayChua;
	}
	public Date getdtNgayMuon() 
	{
		return this.dtNgayMuon;
	}
	public void setdtNgayMuon(Date dtNgayMuon) 
	{
		this.dtNgayMuon = dtNgayMuon;
	}
	public Date getdtNgayPhaiTra()
	{
		return dtNgayPhaiTra;
	}
	public void setdtNgayPhaiTra(Date dtNgayPhaiTra) 
	{
		this.dtNgayPhaiTra = dtNgayPhaiTra;
	}
	public QuyenSachKhoaHoc()
	{
		super();
		this.bDaMuonHayChua = true;
		this.dtNgayMuon = new Date();
		this.dtNgayPhaiTra = new Date();
	}
	public QuyenSachKhoaHoc(String MaDauSach,String Tua, String NXB,String TacGia, double Gia, String ChuyenNganh,int MaQuyenSach)
	{
		super(MaDauSach, Tua, NXB, TacGia, Gia,ChuyenNganh);
		this.sMaQuyenSach = MaQuyenSach;
		this.bDaMuonHayChua = true;						
		this.dtNgayMuon = new Date();
		this.dtNgayPhaiTra = new Date();
		TinhThanhTien();
	}
	@Override
	public void Nhap()
	{
		super.Nhap();
	}
	@Override 
	public void Xuat()
	{
		super.Xuat();
		if (this.bDaMuonHayChua == false)
		{
			System.out.println(" Da duoc muon! ");
			System.out.println(" Ngay muon : " + this.dtNgayMuon.getiNgay() + "/" + this.dtNgayMuon.getiThang() + "/" + this.dtNgayMuon.getiNam());
			System.out.println(" Ngay phai tra : " + this.dtNgayPhaiTra.getiNgay() + "/" + this.dtNgayPhaiTra.getiThang() + "/" + this.dtNgayPhaiTra.getiNam());
		}
		else
		{
			System.out.println(" Nam trong thu vien!  ");
		}
		System.out.print(" Ma quyen sach: " + this.sMaQuyenSach);
	}
	@Override 
	public void TinhThanhTien()
	{
		this.dThanhTien = this.dGia + (this.dGia * this.dThue/100);
	}
	
	public void MuonNgayHomNay(Date Today)
	{
		this.bDaMuonHayChua=false;
		this.dtNgayMuon = Today;
		this.dtNgayPhaiTra = Date.PlusDay(Today,60);
	}
	public void TraSach()
	{
		this.bDaMuonHayChua = true;
		this.dtNgayMuon = new Date();
		this.dtNgayPhaiTra = new Date();
	}
	public void XDNgayTra()
	{
		this.dtNgayPhaiTra = Date.PlusDay(this.dtNgayMuon,60);
	}
}
