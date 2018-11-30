using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace QLTV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Form2 f = new Form2();
        List<string> dsChuoi;
        List<string> dsDong;
        public List<KhoaHoc> dsKH;
        public List<ThamKhao> dsTK;
        public List<GiaoTrinh> dsGT;
        public List<TheDocGia> dsDG;
        public string MasoDG;
        private void Form1_Load(object sender, EventArgs e)
        {
            Lay_Click(sender, e);
        }
        public class node
        {
          
            public TheDocGia giatri;      // Giá trị node
            public node left;       // Node pLeft
            public node right;      // Node pRight
           
                                    // Hàm tạo không đối số
            public node()
            {
               
                this.left = null;
                this.right = null;
               
            }
            // Hàm tạo có đối số là giá trị node
            public node(TheDocGia a)
            {
               
                this.giatri = a;
                this.left = null;
                this.right = null;
              
            }
        }

      private  int insertKey(ref node T, TheDocGia  x)
        {
            if (T != null)
            {
                if (Convert.ToInt32(T.giatri.MaDG) >Convert.ToInt32( x.MaDG))
                    return insertKey(ref T.left, x);
                else
                    if (Convert.ToInt32(T.giatri.MaDG) < Convert.ToInt32(x.MaDG))
                    return insertKey(ref T.right, x);
                else
                    return 0; //Node da co
            }
            else
            {
                T = new node(x);
                return 1;
            }
        }
        private void LNR(node T,ref DataTable d)
        {
            if (T!=null)
            {
                LNR(T.left,ref d);
                DataRow row;
                row = d.NewRow();
               
                row["Họ Tên"] = T.giatri.HoTen;
                row["Mã Độc Giả"] = T.giatri.MaDG;
                row["Địa Chỉ"] = T.giatri.DiaChi;
                row["SĐT"] = T.giatri.SDT;
                row["Email"] = T.giatri.Email;
                row["Ngày Sinh"] = T.giatri.NgaySinh;
                row["Ngày Đăng kí"] = Convert.ToString(T.giatri.NgayLapThe.ngay) + "/" + Convert.ToString(T.giatri.NgayLapThe.thang) +
                    "/" + Convert.ToString(T.giatri.NgayLapThe.nam);

                d.Rows.Add(row);
                LNR(T.right,ref d);
                
            }
        }
        private void xem_Click(object sender, EventArgs e)
        {
            int m = 1;
            
                DataTable dt = new DataTable();
                dt.Columns.Add("STT", typeof(int));
                dt.Columns.Add("Mã sách", typeof(string));
                dt.Columns.Add("Tựa sách", typeof(string));
                dt.Columns.Add("Nhà xuất bản", typeof(string));
                dt.Columns.Add("Tác Giả", typeof(string));
                dt.Columns.Add("Giá", typeof(int));
               if(comboBox1.Text=="KhoaHoc")
            {
                dt.Columns.Add("Chuyên ngành", typeof(string));
                dt.Columns.Add("Số lượng", typeof(int));
                for (int j = 0; j < dsKH.Count; j++)
                {
                    string ms = dsKH[j].Ma_sach;
                    string tua = dsKH[j].Tua;
                    string nxb = dsKH[j].NXB;
                    string tg = dsKH[j].TacGia;
                    int gia = dsKH[j].Gia;
                    int soluong = dsKH[j].SoLuong;
                    string cn = dsKH[j].ChuyenNganh;
                    DataRow row;
                    row = dt.NewRow();
                    row["STT"] = j+1;
                    row["Mã sách"] = ms;
                    row["Tựa sách"] = tua;
                    row["Nhà xuất bản"] = nxb;
                    row["Tác Giả"] = tg;
                    row["Giá"] = gia;
                    
                    row["Chuyên ngành"] = cn;
                    row["Số lượng"] = soluong;
                    dt.Rows.Add(row);
                }
                dtg1.DataSource = dt;
            }
            else if(comboBox1.Text == "ThamKhao")
            {
                dt.Columns.Add("Quốc gia", typeof(string));
                dt.Columns.Add("Số lượng", typeof(int));
                for (int j=0;j<dsTK.Count;j++)
                {
                    string ms = dsTK[j].Ma_sach;
                    string tua = dsTK[j].Tua;
                    string nxb = dsTK[j].NXB;
                    string tg = dsTK[j].TacGia;
                    int gia = dsTK[j].Gia;
                    int soluong = dsTK[j].SoLuong;
                    string qg = dsTK[j].Quocgia;
                    DataRow row;
                    row = dt.NewRow();
                    row["STT"] = j+1;
                    row["Mã sách"] = ms;
                    row["Tựa sách"] = tua;
                    row["Nhà xuất bản"] = nxb;
                    row["Tác Giả"] = tg;
                    row["Giá"] = gia;
                    row["Quốc gia"] = qg;
                    row["Số lượng"] = soluong;
                    dt.Rows.Add(row);
                }
                dtg1.DataSource = dt;
            }
            else if(comboBox1.Text == "GiaoTrinh")
            {
                dt.Columns.Add("Bộ môn", typeof(string));
                dt.Columns.Add("Số lượng", typeof(int));
                for (int j = 0; j < dsGT.Count; j++)
                {
                    string ms = dsGT[j].Ma_sach;
                    string tua = dsGT[j].Tua;
                    string nxb = dsGT[j].NXB;
                    string tg = dsGT[j].TacGia;
                    int gia = dsGT[j].Gia;
                    int soluong = dsGT[j].SoLuong;
                    string bm = dsGT[j].BoMon;
                    DataRow row;
                    row = dt.NewRow();
                    row["STT"] = j+1;
                    row["Mã sách"] = ms;
                    row["Tựa sách"] = tua;
                    row["Nhà xuất bản"] = nxb;
                    row["Tác Giả"] = tg;
                    row["Giá"] = gia;
                    row["Bộ môn"] = bm;
                    row["Số lượng"] = soluong;
                    dt.Rows.Add(row);
                }
                dtg1.DataSource = dt;
            }
            else MessageBox.Show("Chọn loại sách cần tìm. \n ", "THÔNG BÁO:");
        }


        private void xoa_Click(object sender, EventArgs e)
        {
            using (ThuVienDataContext db = new ThuVienDataContext())
            {
                string Masach = dtg1.SelectedCells[0].OwningRow.Cells["MaSach"].Value.ToString();
                Dausach ds = db.Dausaches.Where(p => p.Masach.Equals(Masach)).SingleOrDefault();
                db.Dausaches.DeleteOnSubmit(ds);
                db.SubmitChanges();
            }
            xem_Click(sender, e);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        // In danh sách độc giả
        private void sua_Click(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("STT", typeof(int));
            dt1.Columns.Add("Họ Tên", typeof(string));
            dt1.Columns.Add("Mã Độc Giả", typeof(string));
            dt1.Columns.Add("Địa Chỉ", typeof(string));
            dt1.Columns.Add("SĐT", typeof(string));
            dt1.Columns.Add("Email", typeof(string));
            dt1.Columns.Add("Ngày Sinh", typeof(string));
            dt1.Columns.Add("Ngày Đăng kí", typeof(string));
           
            for (int i = 0; i < dsDG.Count; i++)
            {
               
                int stt = i + 1;
                string ten = dsDG[i].HoTen;
                string ms = dsDG[i].MaDG;
                string dc = dsDG[i].DiaChi;
                string dt = dsDG[i].SDT;
                string mail = dsDG[i].Email;
                string ngsinh = dsDG[i].NgaySinh;
                string ngdk = Convert.ToString(dsDG[i].NgayLapThe.ngay)+"/"+Convert.ToString(dsDG[i].NgayLapThe.thang)+
                    "/"+Convert.ToString(dsDG[i].NgayLapThe.nam);
               
                DataRow row;
                row = dt1.NewRow();
                row["STT"] = stt;
                row["Họ Tên"] = ten;
                row["Mã Độc Giả"] = ms;
                row["Địa Chỉ"] = dc;
                row["SĐT"] = dt;
                row["Email"] = mail;
                row["Ngày Sinh"] = ngsinh;
                row["Ngày Đăng kí"] = ngdk;
               
                dt1.Rows.Add(row);
            }
            dtg1.DataSource = dt1;
            if (dsDG.Count == 0) MessageBox.Show("Danh sách độc giả đang rỗng. ", "THÔNG BÁO:");
            else MessageBox.Show("Xuất thành công.", "THÔNG BÁO:");
        }

        public void Lay_Click(object sender, EventArgs e)
        {
            int sosach=0;
            
            dsChuoi = new List<string>();
            dsDong = new List<string>();
            dsKH = new List<KhoaHoc>();
            dsGT = new List<GiaoTrinh>();
            dsTK = new List<ThamKhao>();
          
            string tenfile = "DS.txt";
           int kt= docfile(ref dsChuoi, ref sosach,tenfile);
            for (int i = 0; i < sosach; i++)
            {
                if (dsChuoi[i].Substring(1, 2) == "KH")
                {
                    KhoaHoc x2 = new KhoaHoc();
                    string str1 = dsChuoi[i];
                    string[] ms1 = str1.Split('*', '-');
                    string[] tua1 = str1.Split('-', '+');
                    string[] nxb1 = str1.Split('+', '/');
                    string[] tg1 = str1.Split('/', '<');
                    string[] prc1 = str1.Split('<', '>');
                    string[] soluong = str1.Split('>', '|');
                    string[] cn = str1.Split('|', '?');
                    x2.nhap(Convert.ToString(ms1[1]), Convert.ToString(tua1[1]), Convert.ToString(nxb1[1]),
                        Convert.ToString(tg1[1]), Convert.ToInt32(prc1[1]), Convert.ToString(cn[1]), Convert.ToInt32(soluong[1]));
                    dsKH.Add(x2);
                }
                else if (dsChuoi[i].Substring(1, 2) == "TK")
                {
                    ThamKhao x2 = new ThamKhao();
                    string str2 = dsChuoi[i];
                    string[] ms2 = str2.Split('*', '-');
                    string[] tua2 = str2.Split('-', '+');
                    string[] nxb2 = str2.Split('+', '/');
                    string[] tg2 = str2.Split('/', '<');
                    string[] prc2 = str2.Split('<', '>');
                    string[] soluong = str2.Split('>', '|');
                    string[] quocgia = str2.Split('|', '?');
                    x2.nhap(Convert.ToString(ms2[1]), Convert.ToString(tua2[1]), Convert.ToString(nxb2[1]),
                        Convert.ToString(tg2[1]), Convert.ToInt32(prc2[1]), Convert.ToString(quocgia[1]), Convert.ToInt32(soluong[1]));
                    dsTK.Add(x2);
                }
                else
                {
                    GiaoTrinh x2 = new GiaoTrinh();
                    string str3 = dsChuoi[i];
                    string[] ms3 = str3.Split('*', '-');
                    string[] tua3 = str3.Split('-', '+');
                    string[] nxb3 = str3.Split('+', '/');
                    string[] tg3 = str3.Split('/', '<');
                    string[] prc3 = str3.Split('<', '>');
                    string[] soluong = str3.Split('>', '|');
                    string[] mon = str3.Split('|', '?');
                   
                    x2.nhap(Convert.ToString(ms3[1]), Convert.ToString(tua3[1]), Convert.ToString(nxb3[1]),
                        Convert.ToString(tg3[1]), Convert.ToInt32(prc3[1]), Convert.ToString(mon[1]),Convert.ToInt32(soluong[1]));
                    dsGT.Add(x2);
                }
            }
            if (kt==1) MessageBox.Show("Lấy dữ liệu thành công.", "THÔNG BÁO:");
            else MessageBox.Show("Đọc file không thành công.", "THÔNG BÁO:");

            //đọc thông tin doc giả

          
            // Lấy danh sách độc giả
            int sodg = 0;
            dsDG = new List<TheDocGia>();
            tenfile = "DanhSachDocGia.txt";

            docfile(ref dsDong, ref sodg, tenfile);
            for (int i = 0; i < sodg; i++)
            {
                TheDocGia dg = new TheDocGia();
                string str = dsDong[i];
                string[] HTen = str.Split('*', '+');
                string[] maso = str.Split('+', '-');
                string[] diachi = str.Split('-', '(');
                string[] dt = str.Split('(', ')');
                string[] email = str.Split(')', ':');
                string[] ngsinh = str.Split(':', ';');
                string[] ngdk = str.Split(';', '<');
                string[] thangdk = str.Split('<', '>');
                string[] namdk = str.Split('>', '|');
                dg.nhap(Convert.ToString(maso[1]), Convert.ToString(HTen[1]), Convert.ToString(diachi[1]), Convert.ToString(dt[1]), Convert.ToString(email[1]),
                    Convert.ToString(ngsinh[1]), Convert.ToInt32(ngdk[1]),Convert.ToInt32(thangdk[1]),Convert.ToInt32(namdk[1])); 
                dsDG.Add(dg);
                
            }
           
        }

        private void dk_Click(object sender, EventArgs e)
        {
          
            f.ShowDialog();
        }
        //Hiện form mượn sách
        private void Muonsach_Click(object sender, EventArgs e)
        {
            MuonSach muonsach = new MuonSach();
            muonsach.ShowDialog();
        }
        public int docfile(ref List<string> ds,ref int sosach ,string TenFile)
        {
             using (StreamReader rd = new StreamReader(TenFile, Encoding.UTF8))
            {
                if (rd == null)
                {

                    return 0;
                }
                string x = rd.ReadLine();
                sosach = Convert.ToInt32(x);
                for (int i = 1; i <= sosach; i++)
                {
                    string x1 = rd.ReadLine();
                    ds.Add(x1);

                }
                rd.Close();
                return 1;
            }
        }
        // In danh sách người mượn
        private void dsNgmuon_Click(object sender, EventArgs e)
        {
   
            int dsNgMuon = 0;
            dsChuoi = new List<string>();
            string tenfile = "DSSach.txt";
            docfile(ref dsChuoi, ref dsNgMuon, tenfile);
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("STT", typeof(int));
            dt1.Columns.Add("Họ Tên", typeof(string));
            dt1.Columns.Add("Mã Độc Giả", typeof(string));
            dt1.Columns.Add("Địa Chỉ", typeof(string));
            dt1.Columns.Add("SĐT", typeof(string));
            dt1.Columns.Add("Email", typeof(string));
            dt1.Columns.Add("Ngày Sinh", typeof(string));
            dt1.Columns.Add("Ngày Đăng kí", typeof(string));
            
            int m = 1;
            for (int i = 0; i < dsChuoi.Count; i++)
                for (int j = 0; j < dsDG.Count; j++)
                    if (Convert.ToString(dsChuoi[i].Split(',', '@')[1]) == dsDG[j].MaDG)
                    {
                        int stt = m++;
                        string ten = dsDG[j].HoTen;
                        string ms = dsDG[j].MaDG;
                        string dc = dsDG[j].DiaChi;
                        string dt = dsDG[j].SDT;
                        string mail = dsDG[j].Email;
                        string ngsinh = dsDG[j].NgaySinh;
                        string ngdk = Convert.ToString(dsDG[j].NgayLapThe.ngay) + "/" + Convert.ToString(dsDG[j].NgayLapThe.thang) +
                            "/" + Convert.ToString(dsDG[j].NgayLapThe.nam);
                    
                        DataRow row;
                        row = dt1.NewRow();
                        row["STT"] = stt;
                        row["Họ Tên"] = ten;
                        row["Mã Độc Giả"] = ms;
                        row["Địa Chỉ"] = dc;
                        row["SĐT"] = dt;
                        row["Email"] = mail;
                        row["Ngày Sinh"] = ngsinh;
                        row["Ngày Đăng kí"] = ngdk;
                       
                        dt1.Rows.Add(row);

                    }
            dtg1.DataSource = dt1;
            if (dsChuoi.Count == 0) MessageBox.Show("Danh sách độc giả đang rỗng. ", "THÔNG BÁO:");
            else MessageBox.Show("Xuất thành công.", "THÔNG BÁO:");

        }
       
        private void dtg1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
             this.MasoDG = dtg1.SelectedCells[0].OwningRow.Cells["Mã Độc Giả"].Value.ToString();
            FileStream fs = new FileStream("INP.txt", FileMode.Create);
            StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
            sWriter.WriteLine(MasoDG);
            sWriter.Flush();
            fs.Close();
            form3 f3 = new form3();
            f3.ShowDialog();
            
           
        }

        private void sap_xep_Click(object sender, EventArgs e)
        {
            DataTable dt4 = new DataTable();
            dt4.Columns.Add("Họ Tên", typeof(string));
            dt4.Columns.Add("Mã Độc Giả", typeof(string));
            dt4.Columns.Add("Địa Chỉ", typeof(string));
            dt4.Columns.Add("SĐT", typeof(string));
            dt4.Columns.Add("Email", typeof(string));
            dt4.Columns.Add("Ngày Sinh", typeof(string));
            dt4.Columns.Add("Ngày Đăng kí", typeof(string));
            node T = null;
            for(int i=0;i<dsDG.Count;i++)
            {
                insertKey(ref T, dsDG[i]);
            }
            LNR(T, ref dt4);
            dtg1.DataSource = dt4;
        }
    }


}
