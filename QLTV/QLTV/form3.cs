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
    public partial class form3 : Form
    {
        List<string> dsChuoi;
        List<string> dsDong;
        Form1 f1 = new Form1();
        public form3()
        {
            InitializeComponent();
        }
       
        private void form3_Load(object sender, EventArgs e)
        {
            f1.Lay_Click(sender, e);
            using (StreamReader rd = new StreamReader("INP.txt", Encoding.UTF8))
            {

                f1.MasoDG = rd.ReadLine();
            }
                int dem = 0;
            string[] temp =new string [] {};
            string[] KyTu = { "*", "(", ")", "<", ">", "+", "-", "{", "}", "[", "]", "|", "?", "#", "$", "%" };
            int dsSachMuon = 0;
           
            dsChuoi = new List<string>();
            dsDong = new List<string>();
            string tenfile = "DSSach.txt";
            f1.docfile(ref dsChuoi, ref dsSachMuon, tenfile);

            for (int i = 0; i < dsChuoi.Count; i++)
                if (Convert.ToString(dsChuoi[i].Split(',', '@')[1]) == f1. MasoDG)
                {
                    string x = dsChuoi[i];
                    string tam = dsChuoi[i].Substring(dsChuoi[i].Length - 1, 1);    //lấy kí tự cuối cùng
                    int j = 0;

                    while (tam != KyTu[j] && KyTu[j + 1] != "")
                    {
                       dsDong.Add( Convert.ToString(x.Split(Convert.ToChar(KyTu[j]), Convert.ToChar(KyTu[j + 1]))[1]));
                        j++;
                    }

                }
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("Mã sách", typeof(string));
            dt.Columns.Add("Tựa sách", typeof(string));
            dt.Columns.Add("Nhà xuất bản", typeof(string));
            dt.Columns.Add("Tác Giả", typeof(string));
            dt.Columns.Add("Giá", typeof(int));
            for (int i = 0; i < dsDong.Count; i++)
                if (dsDong[i].Substring(0, 2) == "KH")
                    for (int j = 0; j <f1. dsKH.Count; j++)
                    {
                        if (Convert.ToString(dsDong[i]) == f1.dsKH[j].Ma_sach)
                        {

                            string ms = f1.dsKH[j].Ma_sach;
                            string tua =f1. dsKH[j].Tua;
                            string nxb =f1. dsKH[j].NXB;
                            string tg = f1.dsKH[j].TacGia;
                            int gia = f1.dsKH[j].Gia;


                            DataRow row;
                            row = dt.NewRow();
                            row["STT"] = i + 1;
                            row["Mã sách"] = ms;
                            row["Tựa sách"] = tua;
                            row["Nhà xuất bản"] = nxb;
                            row["Tác Giả"] = tg;
                            row["Giá"] = gia;
                            dt.Rows.Add(row);
                        }

                    }
                else if (dsDong[i].Substring(0, 2) == "TK")
                {
                    for (int j = 0; j < f1.dsTK.Count; j++)
                        if (Convert.ToString(dsDong[i]) == f1.dsTK[j].Ma_sach)
                        {
                            string ms =f1. dsTK[j].Ma_sach;
                            string tua = f1.dsTK[j].Tua;
                            string nxb = f1.dsTK[j].NXB;
                            string tg = f1.dsTK[j].TacGia;
                            int gia =f1. dsTK[j].Gia;


                            DataRow row;
                            row = dt.NewRow();
                            row["STT"] = i + 1;
                            row["Mã sách"] = ms;
                            row["Tựa sách"] = tua;
                            row["Nhà xuất bản"] = nxb;
                            row["Tác Giả"] = tg;
                            row["Giá"] = gia;


                            dt.Rows.Add(row);
                        }
                }
                else if (dsDong[i].Substring(0, 2) == "GT")
                {
                    for (int j = 0; j < f1.dsGT.Count; j++)
                        if (Convert.ToString(dsDong[i]) ==f1. dsGT[j].Ma_sach)
                        {
                            string ms = f1.dsGT[j].Ma_sach;
                            string tua = f1.dsGT[j].Tua;
                            string nxb = f1.dsGT[j].NXB;
                            string tg = f1.dsGT[j].TacGia;
                            int gia = f1.dsGT[j].Gia;

                            DataRow row;
                            row = dt.NewRow();
                            row["STT"] = i + 1;
                            row["Mã sách"] = ms;
                            row["Tựa sách"] = tua;
                            row["Nhà xuất bản"] = nxb;
                            row["Tác Giả"] = tg;
                            row["Giá"] = gia;

                            dt.Rows.Add(row);
                        }

                }
            dtg2.DataSource = dt;
        }
    }
}
