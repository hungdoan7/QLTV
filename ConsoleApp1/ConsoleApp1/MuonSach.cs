using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    public class MuonSach
    {
        public DocGia dgNguoiMuon;
        public List<Sach> lDSSachMuon;
        public int iSoLuongSachMuon;
        public void Muon()
        { 

        }
        public MuonSach(DocGia NguoiMuon,List<Sach> DSSachMuon)
        {         
            this.dgNguoiMuon = NguoiMuon;
            this.lDSSachMuon = DSSachMuon;
            this.iSoLuongSachMuon = this.lDSSachMuon.Count;
        }
		
    }
}
