using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Collections.Generic

namespace Lab02_19521555_NguyenNgocHop
{
    public partial class Lab02_Bai04_19521555 : Form
    {
        public Lab02_Bai04_19521555()
        {
            InitializeComponent();
        }

        private void Lab02_Bai04_19521555_Load(object sender, EventArgs e)
        {}

        private void btnNhap_INPUT_Click(object sender, EventArgs e)
        {
            int SoLuongSinhVien=0;
            bool check = true;

            //Kiểm tra số lượng sinh viên
            try
            {
                SoLuongSinhVien = int.Parse(txtSoLuong.Text);

                //Chỉ cho nhập từ 1->10 sinh viên 1 lần
                if(SoLuongSinhVien<1||SoLuongSinhVien>10)
                {
                    MessageBox.Show("Số Lượng Sinh Viên không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSoLuong.Clear();
                    txtSoLuong.Focus();
                    check = false;
                }    
            }
            catch
            {
                MessageBox.Show("Số Lượng Sinh Viên không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Clear();
                txtSoLuong.Focus();
                check = false;
            }

            if(check == true)
            {
                for (int i=1;i<=SoLuongSinhVien;i++)
                {
                   NhapSinhVienBai04 NhapSV = new NhapSinhVienBai04();
                   NhapSV.Ktra = 1;
                   NhapSV.ShowDialog();
                }
            }
        }

        private void btnOUTPUT_Click(object sender, EventArgs e)
        {
            NhapSinhVienBai04 Xuat = new NhapSinhVienBai04();
            Xuat.Ktra = 2;
            Xuat.ShowDialog();
        }
    }
}
