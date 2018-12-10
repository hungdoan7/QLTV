import java.util.Scanner;

public class QuyenSachGiaoTrinh extends DauSachGiaoTrinh implements DacTrungQuyenSach
{
	private int sMaQuyenSach;
	private boolean bDaMuonHayChua;
	private Date dtNgayMuon;
	private Date dtNgayPhaiTra;
	private int iTinhTrang;          
	public int getsMaQuyenSach() {
		return sMaQuyenSach;
	}
	public void setsMaQuyenSach(int sMaQuyenSach) {
		this.sMaQuyenSach = sMaQuyenSach;
	}
	public boolean getbDaMuonHayChua() {
		return bDaMuonHayChua;
	}
	public void setbDaMuonHayChua(boolean bDaMuonHayChua) {
		this.bDaMuonHayChua = bDaMuonHayChua;
	}
	public Date getdtNgayMuon() {
		return dtNgayMuon;
	}
	public void setdtNgayMuon(Date dtNgayMuon) {
		this.dtNgayMuon = dtNgayMuon;
	}
	public Date getdtNgayPhaiTra() {
		return dtNgayPhaiTra;
	}
	public void setdtNgayPhaiTra(Date dtNgayPhaiTra) {
		this.dtNgayPhaiTra = dtNgayPhaiTra;
	}
	public int getiTinhTrang() {
		return iTinhTrang;
	}
	public void setiTinhTrang(int iTinhTrang) {
		this.iTinhTrang = iTinhTrang;
	}
	public QuyenSachGiaoTrinh()
	{
		super();
		this.bDaMuonHayChua = true;
		this.dtNgayMuon = new Date();
		this.dtNgayPhaiTra = new Date();
	}
	public QuyenSachGiaoTrinh(String MaDauSach, String Tua, String NXB, String TacGia, double Gia, String BoMon, int TinhTrang,int MaQuyenSach) 
	{
		super(MaDauSach, Tua, NXB, TacGia, Gia,BoMon);
		this.sMaQuyenSach = MaQuyenSach;
		this.iTinhTrang = TinhTrang;	
		this.bDaMuonHayChua = true;
		this.dtNgayMuon = new Date();
		this.dtNgayPhaiTra = new Date();
		this.XacDinhThue();
		this.TinhThanhTien();
	}
	@SuppressWarnings("resource")
	@Override
	public void Nhap()
	{
		super.Nhap();
		Scanner sc = new Scanner(System.in);
		System.out.print("Tinh trang ( 0 la cu || 1 la moi ): ");
		this.iTinhTrang = sc.nextInt();
	}
	@Override
	public void Xuat()
	{
		super.Xuat();
		if (this.iTinhTrang == 0)
		{
			System.out.println(" Tinh Trang: Cu ");
		}
		else
		{
			System.out.println(" Trinh trang: Moi ");
		}
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
		System.out.println(" Ma quyen sach: " + this.sMaQuyenSach);
//		System.out.println(" Thanh tien: "+this.dThanhTien);
	}
	@Override
	public void TinhThanhTien()
	{
		if (this.iTinhTrang == 0)
		{
			this.dThanhTien = (this.dGia / 2) + (this.dThue*this.dGia/100);
		}
		else
		{
			this.dThanhTien = this.dGia + (this.dThue*this.dGia/100);
		}
	}
	public void MuonNgayHomNay(Date Today)
	{
		this.bDaMuonHayChua=false;
		this.dtNgayMuon = Today;
		this.dtNgayPhaiTra = Date.PlusDay(Today,120);
	}
	public void TraSach()
	{
		this.bDaMuonHayChua = true;
		this.dtNgayMuon = new Date();
		this.dtNgayPhaiTra = new Date();
	}
	public void XDNgayTra()
	{
		this.dtNgayPhaiTra = Date.PlusDay(this.dtNgayMuon,120);
	}
}
