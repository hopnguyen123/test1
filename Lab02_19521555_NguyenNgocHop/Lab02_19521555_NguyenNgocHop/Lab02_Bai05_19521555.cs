using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_19521555_NguyenNgocHop
{
    public partial class Lab02_Bai05_19521555 : Form
    {
        public Lab02_Bai05_19521555()
        {
            InitializeComponent();
        }

        private void Lab02_Bai05_19521555_Load(object sender, EventArgs e)
        {
            lsvDanhSach.Columns.Add("Tên File", 265);
            lsvDanhSach.Columns.Add("Kích Thước", 220);
            lsvDanhSach.Columns.Add("Đuôi mở rộng", 220);
            lsvDanhSach.Columns.Add("Ngày tạo", 350);
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            String dirPath = "D:\\TAI_LIEU_HOC_KI_4_UIT\\6.LichSuDang";
            
            //Tạo 1 mảng -> lấy tất cả các file có trong thư mục
            string[] allfiles = Directory.GetFiles(dirPath, "*.*", SearchOption.AllDirectories);
            foreach(var file in allfiles)
            {
                FileInfo info = new FileInfo(file);

                string[] Mang_ThongTin = new string[4];
                ListViewItem item;
                Mang_ThongTin[0] = info.Name;
                Mang_ThongTin[1] = info.Length.ToString();
                Mang_ThongTin[2] = Path.GetExtension(info.Name).ToString();
                DateTime dt = File.GetCreationTime(info.FullName);
                Mang_ThongTin[3] = dt.ToString(("dd/MM/yyyy hh:mm:ss tt")); //CHƯA XONG ***************

                item = new ListViewItem(Mang_ThongTin);
                lsvDanhSach.Items.Add(item);
            }    
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
