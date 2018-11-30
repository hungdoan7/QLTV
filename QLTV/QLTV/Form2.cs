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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;

            ngaydk.Text = Convert.ToString(day) + "/" + Convert.ToString(month) + "/" + Convert.ToString(year);
        }
        List<string> dsDong = new List<string>();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ok_Click(object sender, EventArgs e)
        {

           
            
            Form1 temp = new Form1();
       
            int sosach = 0;
            string tenfile = "DanhSachDocGia.txt";
            temp.docfile(ref dsDong, ref sosach, tenfile);
            int j = 0;
            while (j < dsDong.Count && Convert.ToString(ms.Text) != Convert.ToString(dsDong[j].Split('+', '-')[1])) j++;
            if (j >= dsDong.Count)
            
            {
                FileStream fs = new FileStream("DanhSachDocGia.txt", FileMode.Create);
                StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
                string s = "*" + Convert.ToString(ten.Text) + "+" + Convert.ToString(ms.Text) + "-" + Convert.ToString(dc.Text) +
                    "(" + Convert.ToString(sdt.Text) + ")" + Convert.ToString(mail.Text) + ":" + Convert.ToString(date.Text) + ";" +
                    Convert.ToString(DateTime.Now.Day)+ "<" +Convert.ToString(DateTime.Now.Month)+ ">" +Convert.ToString(DateTime.Now.Year) + "|";
                dsDong.Add(s);
                sWriter.WriteLine(dsDong.Count);
                for (int i = 0; i < dsDong.Count; i++)
                {
                    sWriter.WriteLine(dsDong[i]);
                }
                sWriter.Flush();
                fs.Close();

                MessageBox.Show("Lưu thành công.", "THÔNG BÁO:");
                ten.Clear();
                ms.Clear();
                dc.Clear();
                sdt.Clear();
                mail.Clear();
                date.Clear();

                this.Close();
            }
            else MessageBox.Show("Mã độc giả đã tồn tại. \n Hãy nhập lại mã khác.", "THÔNG BÁO:");


        }

       

        private void Luu_Click(object sender, EventArgs e)
        {
        }
    }
}

