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

namespace Lab02_19521555_NguyenNgocHop
{
    public partial class NhapSinhVienBai04 : Form
    {
        public NhapSinhVienBai04()
        {
            InitializeComponent();
        }
       
        public int Ktra;    //1: -> nhập, 2: -> Xuất
        private void NhapSinhVienBai04_Load(object sender, EventArgs e)
        {
            if(Ktra == 1)
            {
                btnXuat.Enabled = false;

                btnGhi_1_SV.Enabled = true;
                txtMSSV.Enabled = true;
                txtHoTen.Enabled = true;
                txtSDT.Enabled = true;
                txtDiemToan.Enabled = true;
                txtDiemVan.Enabled = true;
            }    
            else if(Ktra==2)
            {
                btnXuat.Enabled = true;

                btnGhi_1_SV.Enabled = false;
                txtMSSV.Enabled = false;
                txtHoTen.Enabled = false;
                txtSDT.Enabled = false;
                txtDiemToan.Enabled = false;
                txtDiemVan.Enabled = false;
            }    
        }

        //Tạo 1 lớp chứa sinh viên
        [Serializable]
        public class MyObject
        {
            public string MSSV = "";
            public string HoTen = "";
            public string SDT = "";
            public float DiemVan = 0;
            public float DiemToan = 0;
            public float DTB = 0;
        }

        private void btnGhi_1_SV_Click(object sender, EventArgs e)
        {
            float DiemToan, DiemVan;
            bool check = true;
            
            //Kiểm tra MSSV
            if(txtMSSV.Text=="")
            {
                MessageBox.Show("MSSV bị trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
                txtMSSV.Focus();
            }    
            else
            {
                for (int i = 0; i < txtMSSV.Text.Length; i++)
                {
                    if (txtMSSV.Text[i] < '0' || txtMSSV.Text[i] > '9')
                    {
                        MessageBox.Show("MSSV không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        i = txtMSSV.Text.Length;
                        txtMSSV.Clear();
                        txtMSSV.Focus();
                        check = false;
                    }
                }
            }    
             
            //Kiểm Tra Họ Tên
            if(txtHoTen.Text=="")
            {
                MessageBox.Show("Họ Tên bị trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen.Focus();
                check = false;
            }
            else
            {
                for (int i = 0; i < txtHoTen.Text.Length; i++)
                {
                    if (((txtHoTen.Text[i] < 'a' || txtHoTen.Text[i] > 'z') && (txtHoTen.Text[i] < 'A' || txtHoTen.Text[i] > 'Z'))&&(txtHoTen.Text[i]!=' '))
                    {
                        MessageBox.Show("Họ Tên không đúng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtHoTen.Clear();
                        txtHoTen.Focus();
                        i = txtHoTen.Text.Length;
                        check = false;
                    }
                }
            }

            //Kiểm Tra Số Điện Thoại
            if (txtSDT.Text == "")
            {
                MessageBox.Show("Số điện Thoại bị trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
                txtSDT.Focus();
            }
            else
            {
                for (int i = 0; i < txtSDT.Text.Length; i++)
                {
                    if (txtSDT.Text[i] < '0' || txtSDT.Text[i] > '9')
                    {
                        MessageBox.Show("Số Điện Thoại không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        i = txtSDT.Text.Length;
                        txtSDT.Clear();
                        txtSDT.Focus();
                        check = false;
                    }
                }
            }

            //Kiểm Tra Điểm Toán
            try
            {
                DiemToan = float.Parse(txtDiemToan.Text);

                if(DiemToan<0 ||DiemToan>10)
                {
                    MessageBox.Show("Điểm Toán không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDiemToan.Clear();
                    txtDiemToan.Focus();
                    check = false;
                }    
            }
            catch
            {
                MessageBox.Show("Điểm Toán không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiemToan.Clear();
                txtDiemToan.Focus();
                check = false;
            }

            //Kiểm Tra Điểm Văn
            try
            {
                DiemVan = float.Parse(txtDiemVan.Text);

                if (DiemVan < 0 || DiemVan > 10)
                {
                    MessageBox.Show("Điểm Văn không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDiemVan.Clear();
                    txtDiemVan.Focus();
                    check = false;
                }
            }
            catch
            {
                MessageBox.Show("Điểm Văn không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiemVan.Clear();
                txtDiemVan.Focus();
                check = false;
            }

            //Nếu các giá trị nhập vào chính xác
            if (check ==true)
            {
                //Tạo 1 đối tượng lưu trữ các giá trị nhập vào
                MyObject obj = new MyObject();  
                obj.MSSV = txtMSSV.Text;
                obj.HoTen = txtHoTen.Text;
                obj.SDT = txtSDT.Text;
                obj.DiemToan = float.Parse(txtDiemToan.Text);
                obj.DiemVan = float.Parse(txtDiemVan.Text);

                //Mã hoá từng sinh viên -> lưu vào file
                Stream stream = new FileStream("INPUT04.txt", FileMode.Append, FileAccess.Write, FileShare.None);
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, obj);
                stream.Close();

                MessageBox.Show("Nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }    
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            //Giải mã dữ liệu và lưu vào listFromFile
            List<MyObject> listFromFile = new List<MyObject>();
            using (Stream fileStream = new FileStream("INPUT04.txt", FileMode.Open))
            {
                IFormatter bFormatter = new BinaryFormatter();
                while (fileStream.Position!= fileStream.Length)
                {
                    listFromFile.Add((MyObject)bFormatter.Deserialize(fileStream));
                }
                
            }

            //Tính Điểm Trung bình => gán vào mảng String
            string[] ChuoiOutPut = new string[listFromFile.Count];
            for(int i=0;i<listFromFile.Count;i++)
            {
                float DTB = 0;
                string Chuoi = "";
                DTB = (listFromFile[i].DiemToan + listFromFile[i].DiemVan) / 2;
                Chuoi = Chuoi + listFromFile[i].MSSV + " - " + listFromFile[i].HoTen + " - " + listFromFile[i].SDT + " - " + listFromFile[i].DiemToan.ToString() + " - " + listFromFile[i].DiemVan.ToString() + " - " + DTB.ToString();
                richtxtIN.Text = richtxtIN.Text + Chuoi + '\n';
                ChuoiOutPut[i] = Chuoi;
            }

            //Xuất từ phần tử trong mảng String[] ChuoiOutPut => File OUTPUT04.txt
            if (!File.Exists("OUTPUT04.txt"))
            {
                File.Create("OUTPUT04.txt").Close();
                using (StreamWriter sw = File.AppendText("OUTPUT04.txt"))
                {
                    for(int i=0;i<ChuoiOutPut.Length;i++)
                    {
                        sw.WriteLine(ChuoiOutPut[i]);
                    }    
                }
            }
            else
            {
                File.WriteAllText("OUTPUT04.txt", String.Empty); // Clear file
                using (StreamWriter sw = File.AppendText("OUTPUT04.txt"))
                {
                    for(int i = 0; i < ChuoiOutPut.Length; i++)
                    {
                        sw.WriteLine(ChuoiOutPut[i]);
                    }    
                }
            }

            MessageBox.Show("Xuất File thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
