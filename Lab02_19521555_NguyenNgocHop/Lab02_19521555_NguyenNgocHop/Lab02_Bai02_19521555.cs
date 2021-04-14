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
    public partial class Lab02_Bai02_19521555 : Form
    {
        public Lab02_Bai02_19521555()
        {
            InitializeComponent();
        }

        private void Lab02_Bai02_19521555_Load(object sender, EventArgs e)
        {

        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            //Chọn File
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.ShowDialog();
           
            //Đọc file và kiểm tra (nếu chưa chọn file thì chương trình sẽ hiện ra lỗi)
            try
            {
                //Mở File
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);

                //Đọc File
                StreamReader sr = new StreamReader(fs);
                string content = sr.ReadToEnd();
                richtxtIN.Text = content;

                //Đóng File
                fs.Close();

                //Tên file
                txtTenFile.Text = ofd.SafeFileName.ToString();

                //Địa chỉ URL
                txtURL.Text = ofd.FileName.ToString();

                //Đếm Số dòng
                int lineCount = File.ReadLines(ofd.FileName).Count();
                txtSoDong.Text = lineCount.ToString();

                //Đếm số từ
                string[] source = content.Split(new char[] { '.', ',', '!', ' ', '?', ':', ';','\n' }, StringSplitOptions.RemoveEmptyEntries);
                int dem = source.Count();
                txtSoTu.Text = dem.ToString();

                //Đếm số kí tự (chưa xong) ** -> cách 2 OK
               // int dem = 0;
                //while()
                //int demsokitu = content.Length; Nó bị sai??
                int demsokitu = richtxtIN.Text.Length;
                txtSoKiTu.Text = demsokitu.ToString();

            }
            catch
            {
                MessageBox.Show("Chưa chọn File để đọc", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }
    }
}
