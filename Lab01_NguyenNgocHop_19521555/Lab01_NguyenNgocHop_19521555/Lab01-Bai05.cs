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
    public partial class Bai05 : Form
    {
        public Bai05()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int A, B;

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtA.Focus();

            lblA1.Text = "A! = ...";
            lblB1.Text = "B! = ...";
            lblS1.Text = "S1 = 1 + 2 + 3 + 4 + ... + A = ...";
            lblS2.Text = "S2 = 1 + 2 + 3 + 4 + ... + B = ...";
            lblS3.Text = "S3 = A^1 + A^2 + A^3 + A^4 + ... + A^B = ...";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTinhGiaTri_Click(object sender, EventArgs e)
        {
            bool check = true;
            //Kiểm tra giá trị A
            try
            {
                A = int.Parse(txtA.Text);

                if(A < 1)
                {
                    MessageBox.Show("Giả Trị Phải >= 1", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtA.Clear();
                    txtA.Focus();
                    check = false;
                }    
            }
            catch
            {
                MessageBox.Show("Dữ liệu không hợp lệ !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtA.Clear();
                txtA.Focus();
                check = false;
            }

            //Kiểm tra giá trị B
            try
            {
                B = int.Parse(txtB.Text);

                if (B < 1)
                {
                    MessageBox.Show("Giả Trị Phải >= 1", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtB.Clear();
                    txtB.Focus();
                    check = false;
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu không hợp lệ !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtB.Clear();
                txtB.Focus();
                check = false;
            }

            //Tính Luỹ Thừa
            //long ketqua = 1;
           /* long LuyThua(int x, int n)
            {
                for (int i = 1; i <= n; i++)
                {
                    ketqua = ketqua*x;
                }
                return ketqua;
            }*/


            if (check == true)
            {
                long S1 = 0;    //S1 = 1 + 2 + .... + A
                long S2 = 0;    //S2 = 1 + 2 + .... + B
                double S3 = 0;  //S3 = A^1 + A^2 + ... + A^B
                long T1 = 1;    //T1 = A!
                long T2 = 1;    //T2 = B!

                for (int i = 1; i <= A; i++)
                {
                    T1 = T1 * i;
                    S1 += i;
                }
                
                for (int i = 1; i<= B;i++)
                {
                    T2 = T2 * i;
                    S2 += i;
                    S3 += Math.Pow(A, i);
                }

                lblA1.Text = "A! = " + T1.ToString();
                lblB1.Text = "B! = " + T2.ToString();
                lblS1.Text = "S1 = 1 + 2 + 3 + 4 + ... + A = " + S1.ToString();
                lblS2.Text = "S2 = 1 + 2 + 3 + 4 + ... + B = " + S2.ToString();
                lblS3.Text = "S3 = A^1 + A^2 + A^3 + A^4 + ... + A^B = " + S3.ToString();
            }    
               

        }
    }
}
