import java.util.ArrayList;

public class HopDongMuon
{
	private DocGia dgNguoiMuon;
	private ArrayList<QuyenSachKhoaHoc> lDSSachKHMuon;
	private ArrayList<QuyenSachGiaoTrinh> lDSSachGTMuon;
	private int iSoLuongSachMuon;
	
	public DocGia getdgNguoiMuon() {
		return dgNguoiMuon;
	}
	public void setdgNguoiMuon(DocGia dgNguoiMuon) {
		this.dgNguoiMuon = dgNguoiMuon;
	}
	public ArrayList<QuyenSachKhoaHoc> getlDSSachKHMuon() {
		return lDSSachKHMuon;
	}
	public void setlDSSachKHMuon(ArrayList<QuyenSachKhoaHoc> lDSSachKHMuon) {
		this.lDSSachKHMuon = lDSSachKHMuon;
	}
	public ArrayList<QuyenSachGiaoTrinh> getlDSSachGTMuon() {
		return lDSSachGTMuon;
	}
	public void setlDSSachGTMuon(ArrayList<QuyenSachGiaoTrinh> lDSSachGTMuon) {
		this.lDSSachGTMuon = lDSSachGTMuon;
	}
	public int getiSoLuongSachMuon() {
		return iSoLuongSachMuon;
	}
	public void setiSoLuongSachMuon(int iSoLuongSachMuon) {
		this.iSoLuongSachMuon = iSoLuongSachMuon;
	}
	
	public HopDongMuon()
	{
		this.lDSSachGTMuon = new ArrayList<QuyenSachGiaoTrinh>();
		this.lDSSachKHMuon = new ArrayList<QuyenSachKhoaHoc>();
	}
	public HopDongMuon(DocGia NguoiMuon, ArrayList<QuyenSachKhoaHoc> DSSachKHMuon, ArrayList<QuyenSachGiaoTrinh> DSSachGTMuon)
	{
		this.dgNguoiMuon = NguoiMuon;
		this.lDSSachKHMuon = DSSachKHMuon;
		this.lDSSachGTMuon = DSSachGTMuon;
		this.iSoLuongSachMuon = this.lDSSachGTMuon.size() +this.lDSSachKHMuon.size();
	}		
}
