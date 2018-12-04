using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    public class MuonSach
    {
        public DocGia NgMuon;
        public List<Sach> dsSachMuon;
        public int slSachMuon;
        public void Muon()
        { 
        }
        public MuonSach(DocGia NguoiMuon,List<Sach> ListSachMuon)
        {
           
            this.NgMuon = NguoiMuon;
            this.dsSachMuon = ListSachMuon;
            this.slSachMuon = this.dsSachMuon.Count;
        }

    }
}
