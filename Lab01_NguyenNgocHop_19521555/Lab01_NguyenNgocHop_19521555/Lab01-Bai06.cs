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
    public partial class Bai06 : Form
    {
        public Bai06()
        {
            InitializeComponent();
        }

        private void Bai06_Load(object sender, EventArgs e)
        {
            lsvDiem.Columns.Add("MÔN", 320);
            lsvDiem.Columns.Add("ĐIỂM", 320);
        }

        private void btnXuLy_Click(object sender, EventArgs e)
        {
            //Cắt Chuỗi
            string[] arrListStr = txtInput.Text.Split(',');
            int Length = arrListStr.Length;
            double so;
            bool check = true;

            //Kiểm Tra Chuỗi INPUT
            for (int i=0;i<Length;i++)
            {
                try
                {
                    so = double.Parse(arrListStr[i]);

                    if(so<0||so>10)
                    {
                        MessageBox.Show("INPUT không hợp lệ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtInput.Clear();
                        txtInput.Focus();
                        check = false;
                        break;
                    }
                }
                catch
                {
                    MessageBox.Show("INPUT không hợp lệ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtInput.Clear();
                    txtInput.Focus();
                    check =false;
                    break;
                }
            }

            //Nếu Chuỗi Hợp Lệ
            if (check == true)
            {
                double Tong = 0;
                double Max = double.Parse(arrListStr[0]);
                double Min = double.Parse(arrListStr[0]);
                double SoMonDau = 0;
                double SoMonRot = 0;

                for(int i=0;i<Length;i++)
                {
                    double GiaTri = double.Parse(arrListStr[i]);

                    //Xuất ra ListView
                    int SoThuTu = i + 1;

                    string[] Chuoi = new string[2];
                    Chuoi[0] = "Môn" + SoThuTu.ToString();
                    Chuoi[1] = arrListStr[i];

                    ListViewItem item = new ListViewItem(Chuoi);
                    lsvDiem.Items.Add(item);

                    //Tính Tổng Điểm
                    Tong += GiaTri;

                    //Tìm Max, Min
                    if(GiaTri>Max)
                    {
                        Max = GiaTri;
                    }    
                    if(GiaTri<Min)
                    {
                        Min = GiaTri;
                    }   
                    
                    //Tìm Số môn đậu,rớt
                    if(GiaTri>=5)
                    {
                        SoMonDau += 1;
                    }    
                    else
                    {
                        SoMonRot += 1;
                    }
                }


                //Điểm Cao Nhất
                txtCaoNhat.Text = Max.ToString();

                //Điểm Thấp Nhất
                txtThapNhat.Text = Min.ToString();

                //Số Môn Đậu
                txtDau.Text = SoMonDau.ToString();

                //Số Môn Rớt
                txtRot.Text = SoMonRot.ToString();

                //Điểm Trung Bình
                double DiemTrungBinh = Tong / Length;
                txtTrungBinh.Text = DiemTrungBinh.ToString();

                //Xếp Loại
                if(DiemTrungBinh>=9)
                {
                    if (Min >= 8)
                    {
                        txtXepLoai.Text = "Xuất Sắc";
                    }
                    else if (Min >= 6.5)
                    {
                        txtXepLoai.Text = "Giỏi";
                    }    
                    else if(Min>=5)
                    {
                        txtXepLoai.Text = "Khá";
                    }    
                    else if(Min>3.5)
                    {
                        txtXepLoai.Text = "Trung Bình";
                    }    
                    else
                    {
                        txtXepLoai.Text = "Yếu";
                    }    
                }  
                else if(DiemTrungBinh>=8)
                {
                   if (Min >= 6.5)
                   {
                       txtXepLoai.Text = "Giỏi";
                   }
                   else if (Min >= 5)
                   {
                       txtXepLoai.Text = "Khá";
                   }
                   else if (Min > 3.5)
                   {
                       txtXepLoai.Text = "Trung Bình";
                   }
                   else
                   {
                       txtXepLoai.Text = "Yếu";
                   }
                } 
                else if(DiemTrungBinh>=6.5)
                {
                    if (Min >= 5)
                    {
                        txtXepLoai.Text = "Khá";
                    }
                    else if (Min > 3.5)
                    {
                        txtXepLoai.Text = "Trung Bình";
                    }
                    else
                    {
                        txtXepLoai.Text = "Yếu";
                    }
                }
                else if (DiemTrungBinh >= 5)
                {
                    if (Min > 3.5)
                    {
                        txtXepLoai.Text = "Trung Bình";
                    }
                    else
                    {
                        txtXepLoai.Text = "Yếu";
                    }
                }
                else if (DiemTrungBinh >= 3.5)
                {
                    txtXepLoai.Text = "Yếu";
                }
                else if(DiemTrungBinh<3.5||Min<3.5)
                {
                    txtXepLoai.Text = "Kém";
                }


                txtInput.Clear();
                txtInput.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lsvDiem.Clear();
            txtTrungBinh.Clear();
            txtCaoNhat.Clear();
            txtThapNhat.Clear();
            txtDau.Clear();
            txtRot.Clear();
            txtInput.Clear();
            txtXepLoai.Clear();
            lsvDiem.Columns.Add("MÔN", 320);
            lsvDiem.Columns.Add("ĐIỂM", 320);
            txtInput.Enabled = true;

        }

        private void btnChuoiMoi_Click(object sender, EventArgs e)
        {
            txtInput.Enabled = true;
            lsvDiem.Clear();
            lsvDiem.Columns.Add("MÔN", 320);
            lsvDiem.Columns.Add("ĐIỂM", 320);
        }
    }
}
