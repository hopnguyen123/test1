using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_19521555_NguyenNgocHop
{
    public partial class Lab02_19521555_NguyenNgocHop : Form
    {
        public Lab02_19521555_NguyenNgocHop()
        {
            InitializeComponent();
        }

        private void btnBai01_Click(object sender, EventArgs e)
        {
            Lab02_Bai01_19521555 Bai01 = new Lab02_Bai01_19521555();
            Bai01.ShowDialog();
        }

        private void btnBai02_Click(object sender, EventArgs e)
        {
            Lab02_Bai02_19521555 Bai02 = new Lab02_Bai02_19521555();
            Bai02.ShowDialog();
        }

        private void btnBai03_Click(object sender, EventArgs e)
        {
            Lab02_Bai03_19521555 Bai03 = new Lab02_Bai03_19521555();
            Bai03.ShowDialog();
        }

        private void btnBai04_Click(object sender, EventArgs e)
        {
            Lab02_Bai04_19521555 Bai04 = new Lab02_Bai04_19521555();
            Bai04.ShowDialog();
        }

        private void btnBai05_Click(object sender, EventArgs e)
        {
            Lab02_Bai05_19521555 Bai05 = new Lab02_Bai05_19521555();
            Bai05.ShowDialog();
        }

        private void Lab02_19521555_NguyenNgocHop_Load(object sender, EventArgs e)
        {

        }
    }
}
