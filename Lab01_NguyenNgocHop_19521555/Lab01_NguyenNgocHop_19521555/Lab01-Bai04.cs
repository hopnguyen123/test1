using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_NguyenNgocHop_19521555
{
    public partial class Bai04 : Form
    {
        public Bai04()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Bai04_Load(object sender, EventArgs e)
        {
            //Thêm Items vào ComboBox
            cmBDonVi.Items.Add("USD Đô-la Mỹ");
            cmBDonVi.Items.Add("EUR");
            cmBDonVi.Items.Add("GBP");
            cmBDonVi.Items.Add("SGD");
            cmBDonVi.Items.Add("JPY");

            cmBDonVi.SelectedIndex = 0;
        }

        double TienBanDau;
        private void btnChuyenDoi_Click(object sender, EventArgs e)
        {
            bool check = true;
            //Kiểm tra Input nhập vào
            try
            {
                TienBanDau = double.Parse(txtTienChuyenDoi.Text);

                if ((txtTienChuyenDoi.Text.IndexOf(',') != -1)|| (TienBanDau < 0))
                {
                    MessageBox.Show("INPUT không hợp lệ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTienChuyenDoi.Clear();
                    txtTienChuyenDoi.Focus();
                    check = false;
                }
            }
            catch
            {
                MessageBox.Show("Giá Trị Không Hợp Lệ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTienChuyenDoi.Clear();
                txtTienDaDoi.Clear();
                txtTienChuyenDoi.Focus();
                check = false;
            }

            if(check==true)
            {
                int So;     // 0: USD, 1: EUR, 2: GBP, 3: SGD, 4:JPY
                So = cmBDonVi.SelectedIndex;

                double Tien=0;
                switch(So)
                {
                    case 0:
                        Tien = TienBanDau * 22.772;
                        lblTyGia.Text = "Tỷ Giá Quy Đổi: 1USD = 22,772 VND";
                        break;
                    case 1:
                        Tien = TienBanDau * 28.132;
                        lblTyGia.Text = "Tỷ Giá Quy Đổi: 1EUR = 28,132 VND";
                        break;
                    case 2:
                        Tien = TienBanDau * 31.538;
                        lblTyGia.Text = "Tỷ Giá Quy Đổi: 1GBP = 31,538 VND";
                        break;
                    case 3:
                        Tien = TienBanDau * 17.286;
                        lblTyGia.Text = "Tỷ Giá Quy Đổi: 1SGD = 17,286 VND";
                        break;
                    case 4:
                        Tien = TienBanDau * 214;
                        lblTyGia.Text = "Tỷ Giá Quy Đổi: 1JPY = 214 VND";
                        break;
                }
                txtTienDaDoi.Text = Tien.ToString();
                
            }    
        }
    }
}
