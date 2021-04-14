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
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }

        private void Bai01_Load(object sender, EventArgs e)
        {

        }

        int So1, So2, KetQua = 0;
        
        private void btnEnter_Click(object sender, EventArgs e)
        {
            bool check = true;
            //Kiểm tra số thứ 1
            try
            {
                So1 = int.Parse(txtSo1.Text);

            }
            catch
            {
                MessageBox.Show("Số thứ nhất không hợp lệ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSo1.Clear();
                txtSo1.Focus();
                check = false;
            }

            //Kiểm tra số thứ 2
            try
            {
                So2 = int.Parse(txtSo2.Text);
            }
            catch
            {
                MessageBox.Show("Số thứ hai không hợp lệ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSo2.Clear();
                txtSo2.Focus();
                check = false;
            }

            if(check ==true)
            {
                KetQua = So1 + So2;
                txtKetQua.Text = KetQua.ToString();
            }    
           
        }
    }
}
