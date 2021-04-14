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
    public partial class Lab01 : Form
    {
        public Lab01()
        {
            InitializeComponent();
        }

        private void btnBai01_Click(object sender, EventArgs e)
        {
            Bai01 bai01 = new Bai01();
            bai01.ShowDialog();
        }

        private void btnBai02_Click(object sender, EventArgs e)
        {
            Bai02 bai02 = new Bai02();
            bai02.ShowDialog();
        }

        private void btnBai03_Click(object sender, EventArgs e)
        {
            Bai03 bai03 = new Bai03();
            bai03.ShowDialog();
        }

        private void btnBai04_Click(object sender, EventArgs e)
        {
            Bai04 bai04 = new Bai04();
            bai04.ShowDialog();
        }

        private void btnBai05_Click(object sender, EventArgs e)
        {
            Bai05 bai05 = new Bai05();
            bai05.ShowDialog();
        }

        private void btnBai06_Click(object sender, EventArgs e)
        {
            Bai06 bai06 = new Bai06();
            bai06.ShowDialog();
        }

        private void Lab01_MouseMove(object sender, MouseEventArgs e)
        {
           this.btnBai01.BackColor = Color.Green;
           this.btnBai02.BackColor = Color.Green;
           this.btnBai03.BackColor = Color.Green;
           this.btnBai04.BackColor = Color.Green;
           this.btnBai05.BackColor = Color.Green;
           this.btnBai06.BackColor = Color.Green;
        }

        private void Lab01_MouseLeave(object sender, EventArgs e)
        {
        }

        private void Lab01_MouseEnter(object sender, EventArgs e)
        {
        }

        private void Lab01_MouseDown(object sender, MouseEventArgs e)
        { 
        }

        //BTN01
        private void btnBai01_MouseMove(object sender, MouseEventArgs e)
        {
            btnBai01.BackColor = Color.Yellow;
        }

        private void btnBai01_MouseLeave(object sender, EventArgs e)
        {
            btnBai01.BackColor = Color.Green;
        }

        //BTN02
        private void btnBai02_MouseMove_1(object sender, MouseEventArgs e)
        {
            btnBai02.BackColor = Color.Yellow;
        }

        private void btnBai02_MouseLeave(object sender, EventArgs e)
        {
            btnBai02.BackColor = Color.Green;
        }

        //BTN03
        private void btnBai03_MouseMove(object sender, MouseEventArgs e)
        {
            btnBai03.BackColor = Color.Yellow;
        }

        private void btnBai03_MouseLeave(object sender, EventArgs e)
        {
            btnBai03.BackColor = Color.Green;
        }

        //BTN04
        private void btnBai04_MouseMove(object sender, MouseEventArgs e)
        {
            btnBai04.BackColor = Color.Yellow;
        }

        private void btnBai04_MouseLeave(object sender, EventArgs e)
        {
            btnBai04.BackColor = Color.Green;
        }

        //BTN05
        private void btnBai05_MouseMove(object sender, MouseEventArgs e)
        {
            btnBai05.BackColor = Color.Yellow;
        }

        private void btnBai05_MouseLeave(object sender, EventArgs e)
        {
            btnBai05.BackColor = Color.Green;
        }

        //BTN06
        private void btnBai06_MouseMove(object sender, MouseEventArgs e)
        {
            btnBai06.BackColor = Color.Yellow;
        }

        private void btnBai06_MouseLeave(object sender, EventArgs e)
        {
            btnBai06.BackColor = Color.Green;
        }
    }
}
