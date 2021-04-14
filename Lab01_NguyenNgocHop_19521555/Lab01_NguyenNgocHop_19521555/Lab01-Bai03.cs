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
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
        }

        int Input;
        private void btnDoc_Click(object sender, EventArgs e)
        {
            bool check = true;
            try
            {
                Input = int.Parse(txtSo.Text); 

                if(Input<0||Input>9)
                {
                    MessageBox.Show("Số không hợp lệ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSo.Clear();
                    txtSo.Focus();
                    check = false;
                }    
            }
            catch
            {
                MessageBox.Show("Số không hợp lệ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSo.Clear();
                txtSo.Focus();
                check = false;
            }

            if(check ==true)
            {
                switch (Input)
                {
                    case 0:
                        txtKetQua.Text = "Không";
                        break;
                    case 1:
                        txtKetQua.Text = "Một";
                        break;
                    case 2:
                        txtKetQua.Text = "Hai";
                        break;
                    case 3:
                        txtKetQua.Text = "Ba";
                        break;
                    case 4:
                        txtKetQua.Text = "Bốn";
                        break;
                    case 5:
                        txtKetQua.Text = "Năm";
                        break;
                    case 6:
                        txtKetQua.Text = "Sáu";
                        break;
                    case 7:
                        txtKetQua.Text = "Bảy";
                        break;
                    case 8:
                        txtKetQua.Text = "Tám";
                        break;
                    case 9:
                        txtKetQua.Text = "Chín";
                        break;
                }
            }    
               
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtSo.Clear();
            txtSo.Focus();
            txtKetQua.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
