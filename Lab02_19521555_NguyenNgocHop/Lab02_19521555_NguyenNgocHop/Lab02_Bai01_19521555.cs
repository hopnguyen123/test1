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

namespace Lab02_19521555_NguyenNgocHop
{
    public partial class Lab02_Bai01_19521555 : Form
    {
        public Lab02_Bai01_19521555()
        {
            InitializeComponent();
            btnGhiFile.Enabled = false;
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            //Mở ra các file để ta chọn
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";     //Lọc ra chỉ có file .txt 
            ofd.ShowDialog();

            //Đọc file và kiểm tra (nếu chưa chọn file thì chương trình sẽ hiện ra lỗi)
            try
            {
                //B1: Mở File
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);

                //B2: Đọc File
                StreamReader sr = new StreamReader(fs);
                string content = sr.ReadToEnd();
                richtxtIN.Text = content;

                //B3: Đóng file
                fs.Close();

                //Nếu Đọc File thành công => Cho phép Ghi File
                btnGhiFile.Enabled = true;
            }
            catch
            {
                MessageBox.Show("File không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            if (!File.Exists("OUTPUT01.txt"))
            {
                File.Create("OUTPUT01.txt").Close();
                using (StreamWriter sw = File.AppendText("OUTPUT01.txt"))
                {
                    string ToUpperIN = richtxtIN.Text.ToUpper();
                    sw.WriteLine(ToUpperIN);
                }
            }
            else
            {
                File.WriteAllText("OUTPUT01.txt", String.Empty); // Clear file
                using (StreamWriter sw = File.AppendText("OUTPUT01.txt"))
                {
                    string ToUpperIN = richtxtIN.Text.ToUpper();
                    sw.WriteLine(ToUpperIN);
                }
            }

            MessageBox.Show("Ghi File thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}