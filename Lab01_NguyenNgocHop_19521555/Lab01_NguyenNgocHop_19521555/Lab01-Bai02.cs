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
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
        }

        private void Bai02_Load(object sender, EventArgs e)
        {

        }

        double So1, So2, So3;

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtSo1.Clear();
            txtSo2.Clear();
            txtSo3.Clear();
            txtMin.Clear();
            txtMax.Clear();
            txtSo1.Focus();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            bool check = true;

            //Kiểm tra số 1
            try
            {
                So1 = double.Parse(txtSo1.Text);

                if (txtSo1.Text.IndexOf(',') != -1)
                {
                    MessageBox.Show("Số thứ nhất không hợp lệ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSo1.Clear();
                    txtSo1.Focus();
                    check = false;
                }
            }
            catch
            {
                MessageBox.Show("Số thứ nhất không hợp lệ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSo1.Clear();
                txtSo1.Focus();
                check = false;
            }

            //Kiểm tra số 2
            try
            {
                So2 = double.Parse(txtSo2.Text);

                if (txtSo2.Text.IndexOf(',') != -1)
                {
                    MessageBox.Show("Số thứ hai không hợp lệ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSo2.Clear();
                    txtSo2.Focus();
                    check = false;
                }
            }
            catch
            {
                MessageBox.Show("Số thứ hai không hợp lệ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSo2.Clear();
                txtSo2.Focus();
                check = false;
            }

            //Kiểm tra số 3
            try
            {
                So3 = double.Parse(txtSo3.Text);

                if (txtSo3.Text.IndexOf(',') != -1)
                {
                    MessageBox.Show("Số thứ hai không hợp lệ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSo3.Clear();
                    txtSo3.Focus();
                    check = false;
                }
            }
            catch
            {
                MessageBox.Show("Số thứ ba không hợp lệ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSo3.Clear();
                txtSo3.Focus();
                check =false;
            }

            //Tìm Max,Min
           if(check == true)
            {
                double min = So1;
                double max = So1;

                if(So2<min)
                {
                    min = So2;
                }    
                if(So3<min)
                {
                    min = So3;
                }    

                if(So2>max)
                {
                    max = So2;
                }
                if(So3>max)
                {
                    max = So3;
                }

                txtMax.Text = max.ToString();
                txtMin.Text = min.ToString();
            }    
        }


    }
}
