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
    public partial class MuonSach : Form
    {
        public MuonSach()
        {
            InitializeComponent();
            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;

            ngmuon.Text = Convert.ToString(day) + "/" + Convert.ToString(month) + "/" + Convert.ToString(year);
        }
        List<string> dsNguoi_SachMuon;
        List<string> dsMaSach;
        List<string> dsMaSachSai;
        List<string> dsDG;
        string s;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            dsNguoi_SachMuon = new List<string>();
            dsMaSachSai = new List<string>();
            dsMaSach = new List<string>();
            dsDG = new List<string>();

            Form1 temp = new Form1();
            int sosachmuon = 0;
            int sosachTV = 0;
            string tenfile = "DSSach.txt";
            temp.docfile(ref dsNguoi_SachMuon, ref sosachmuon, tenfile);
            // Lấy danh sách mã sách trong thư viện
            StreamReader rd = new StreamReader("DS.txt", Encoding.UTF8);
            string x = rd.ReadLine();
            sosachTV = Convert.ToInt32(x);
            if (sosachTV != 0)
                for (int i = 0; i < sosachTV; i++)
                {
                    string x1 = rd.ReadLine();
                   
                    dsMaSach.Add(x1);

                }
            rd.Close();
            //
            string MaSachSai = "";
            // Lấy danh sách độc giả
            int sodg = 0;
            tenfile=  "DanhSachDocGia.txt";
            temp.docfile(ref dsDG, ref sodg, tenfile);
            
            string[] KyTu = { "*", "(", ")", "<", ">", "+", "-", "{", "}", "[", "]", "|", "?","#","$","%" };
            if (ten.Text != "" && ms.Text != "")
            {
                int k = 0, kt = 0;
                while (k < dsDG.Count && ms.Text != Convert.ToString(dsDG[k].Split('+', '-')[1])) k++;
                if (k >= dsDG.Count) MessageBox.Show("Mã độc giả không đúng", "Thông báo");
                else
                {
                    // Kiểm tra thẻ đã hết hạn chưa
                    iDate Ngaydk = new iDate(Convert.ToInt32(dsDG[k].Split(';', '<')[1]), Convert.ToInt32(dsDG[k].Split('<', '>')[1]),
                        Convert.ToInt32(dsDG[k].Split('<', '|')[1]));       //Lấy ngày dk của độc giả này
                    iDate NgayHT = new iDate(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
                    if (Ngaydk + 180 > NgayHT) MessageBox.Show("Thẻ của bạn đã hết hạn", "Thông báo");
                    else
                    {
                        k = 0; kt = 0;
                        //Kiểm tra có sách nào trùng không

                        while (k < dataGridView1.Rows.Count - 1 && kt == 0 && dataGridView1.Rows[k].Cells["Column2"].Value.ToString() != "")
                        {

                            int dem = k + 1;
                            while (dem < dataGridView1.Rows.Count - 1 && dataGridView1.Rows[k].Cells["Column2"].Value.ToString() != dataGridView1.Rows[dem].Cells["Column2"].Value.ToString()) dem++;
                            if (dem >= dataGridView1.Rows.Count - 1) kt = 1;
                            k++;
                        }
                        if (k > dataGridView1.Rows.Count - 1) MessageBox.Show("Số lượng tối đa mỗi sách là 1", "Thông báo");
                        else
                        {
                            s += "!" + Convert.ToString(ten.Text) + "," + Convert.ToString(ms.Text) + "@" + Convert.ToString(ngmuon.Text);
                            int i = 0;
                            for (i = 0; i < dataGridView1.Rows.Count - 1; i++)
                            {
                                s += Convert.ToString(KyTu[i]);
                                string Masach = dataGridView1.Rows[i].Cells["Column2"].Value.ToString();
                                int j = 0;
                                //Kiểm tra mã có đúng với dữ liệu trong thư viện
                                while (j < dsMaSach.Count && Masach != Convert.ToString(dsMaSach[j].Split('*', '-')[1])) j++;   //mã sách khác mã sách trong thư viện
                                if (j >= dsMaSach.Count) MaSachSai += Masach + ", ";                                           // Lưu lại mã sai
                                else
                                    s += Masach;                        //Lưu lại mã đúng

                            }
                            s += Convert.ToString(KyTu[i]);
                            if (MaSachSai == "")        //không có mã sai
                            {
                                // kiểm tra người này đã mượn sách trước đó chưa
                                i = 0;
                                while (i < dsNguoi_SachMuon.Count && Convert.ToString(ms.Text) != Convert.ToString(dsNguoi_SachMuon[i].Split(',', '@')[1])) i++;
                                if (i < dsNguoi_SachMuon.Count)
                                {
                                    string tam = dsNguoi_SachMuon[i].Substring(dsNguoi_SachMuon[i].Length - 1, 1);
                                    int index = 0;
                                    while (index < 16 && tam != KyTu[index]) index++;           //

                                    string Luu = "";
                                    for (int j = 0; j < dataGridView1.Rows.Count - 1; j++)
                                    {

                                        string Masach = dataGridView1.Rows[j].Cells["Column2"].Value.ToString();
                                        Luu += Masach + Convert.ToString(KyTu[index + 1]);                         //Lưu lại mã sách mượn thêm
                                        index++;

                                    }
                                    dsNguoi_SachMuon[i] += Luu;

                                }
                                else dsNguoi_SachMuon.Add(s);
                                FileStream sach = new FileStream("DSSach.txt", FileMode.Create);
                                StreamWriter sWriter = new StreamWriter(sach, Encoding.UTF8);
                                FileStream CapNhat = new FileStream("DS.txt", FileMode.Create);
                                StreamWriter capnhat = new StreamWriter(CapNhat, Encoding.UTF8);
                                for (i = 0; i < dataGridView1.Rows.Count - 1; i++)
                                //cập nhật lại số lượng sách
                                {
                                    for (int j = 0; j < dsMaSach.Count; j++)

                                        if (Convert.ToString(dsMaSach[j].Split('*', '-')[1]) == dataGridView1.Rows[i].Cells["Column2"].Value.ToString())
                                        {
                                            string mang = dsMaSach[j];
                                            string[] left = mang.Split('*', '>');
                                            string[] soluong = mang.Split('>', '|');
                                            string[] right = mang.Split('|', '?');
                                            dsMaSach[j] = "*" + Convert.ToString(left[1]) + ">" + Convert.ToString(Convert.ToInt32(soluong[1]) - 1)
                                               + "|" + Convert.ToString(right[1]) + "?";
                                        }



                                }

                                //lưu dữ liệu vào file
                                sWriter.WriteLine(dsNguoi_SachMuon.Count);
                                for (i = 0; i < dsNguoi_SachMuon.Count; i++)
                                {
                                    sWriter.WriteLine(dsNguoi_SachMuon[i]);
                                }
                                sWriter.Flush();
                                sach.Close();
                                //Lưu sô lượng thay đổi vào file
                                capnhat.WriteLine(dsMaSach.Count);
                                for (i = 0; i < dsMaSach.Count; i++)
                                    capnhat.WriteLine(dsMaSach[i]);
                                capnhat.Flush();
                                CapNhat.Close();
                                MessageBox.Show("Lưu thành công.", "THÔNG BÁO:");
                                this.Close();
                            }

                            else MessageBox.Show("Mã sách không tồn tại: \n" + MaSachSai, "THÔNG BÁO:");
                        }

                    }
                }
            
            }
            else MessageBox.Show("Hãy hập đầy đủ thông tin.", "THÔNG BÁO:");
        }
    }
}
