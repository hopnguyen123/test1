using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab02_19521555_NguyenNgocHop
{
    public partial class Lab02_Bai03_19521555 : Form
    {
        public Lab02_Bai03_19521555()
        {
            InitializeComponent();
        }

        private void btnEnTer_Click(object sender, EventArgs e)
        {
            //Chọn File
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.ShowDialog();
            
            try
            {
                //Tạo 1 mảng string lưu từng dòng của file INPUT.txt
                string[] line = File.ReadAllLines(ofd.FileName);

                string chuoiso1, chuoiso2;
                double so1, so2;
                double ketqua;

                string chuoi;
                string[] line_output = new string[line.Length];  //Mảng string-> lưu những dòng để in ra OUTPUT.txt
                int vitri = 0;

                //Xét mỗi dòng của INPUT.txt
                foreach (string s in line)
                {
                    chuoi = "";
                    chuoiso1 = "";
                    chuoiso2 = "";

                    //Xét từng kí tự trong mỗi dòng
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (s[i] == '+')
                        {
                            for (int j = 0; j < i; j++)
                            {
                                if (s[j] != ' ' && s[j] != '\n')
                                    chuoiso1 += s[j];
                            }
                            for (int j = i + 1; j < s.Length; j++)
                            {
                                if (s[j] != ' ' && s[j] != '\n')
                                    chuoiso2 += s[j];
                            }
                            so1 = double.Parse(chuoiso1);
                            so2 = double.Parse(chuoiso2);
                            ketqua = so1 + so2;

                            chuoi = chuoiso1 + '+' + chuoiso2 + '=' + ketqua.ToString();
                            line_output[vitri] = chuoi;
                            i = s.Length;
                        }
                        else if (s[i] == '-'&&i!=0)
                        {
                            for (int j = 0; j < i; j++)
                            {
                                if (s[j] != ' ' && s[j] != '\n')
                                    chuoiso1 += s[j];
                            }
                            for (int j = i + 1; j < s.Length; j++)
                            {
                                if (s[j] != ' ' && s[j] != '\n')
                                    chuoiso2 += s[j];
                            }
                            so1 = double.Parse(chuoiso1);
                            so2 = double.Parse(chuoiso2);
                            ketqua = so1 - so2;

                            chuoi = chuoiso1 + '-' + chuoiso2 + '=' + ketqua.ToString();
                            line_output[vitri] = chuoi;
                            i = s.Length;
                        }
                        else if (s[i] == '*')
                        {
                            for (int j = 0; j < i; j++)
                            {
                                if (s[j] != ' ' && s[j] != '\n')
                                    chuoiso1 += s[j];
                            }
                            for (int j = i + 1; j < s.Length; j++)
                            {
                                if (s[j] != ' ' && s[j] != '\n')
                                    chuoiso2 += s[j];
                            }
                            so1 = double.Parse(chuoiso1);
                            so2 = double.Parse(chuoiso2);
                            ketqua = so1 * so2;

                            chuoi = chuoiso1 + '*' + chuoiso2 + '=' + ketqua.ToString();
                            line_output[vitri] = chuoi;
                            i = s.Length;
                        }
                        else if (s[i] == '/')
                        {
                            for (int j = 0; j < i; j++)
                            {
                                if (s[j] != ' ' && s[j] != '\n')
                                    chuoiso1 += s[j];
                            }
                            for (int j = i + 1; j < s.Length; j++)
                            {
                                if (s[j] != ' ' && s[j] != '\n')
                                    chuoiso2 += s[j];
                            }

                            so1 = double.Parse(chuoiso1);
                            so2 = double.Parse(chuoiso2);
                            ketqua = so1 / so2;

                            chuoi = chuoiso1 + '/' + chuoiso2 + '=' + ketqua.ToString();
                            line_output[vitri] = chuoi;
                            i = s.Length;
                        }
                        
                    }

                    vitri += 1;
                }
                //Sau khi Duyệt xong thì ta được string[] line_output -> để xuất ra file OUPUT.txt


                //Ghi File
                if (!File.Exists("OUTPUT03.txt"))
                {
                    File.Create("OUTPUT03.txt").Close();
                    using (StreamWriter sw = File.AppendText("OUTPUT03.txt"))
                    {
                        for (int i = 0; i < line_output.Length; i++)
                        {
                            sw.WriteLine(line_output[i]);
                        }

                    }
                }
                else
                {
                    File.WriteAllText("OUTPUT03.txt", String.Empty); // Clear file
                    using (StreamWriter sw = File.AppendText("OUTPUT03.txt"))
                    {
                        for (int i = 0; i < line_output.Length; i++)
                        {
                            sw.WriteLine(line_output[i]);
                        }
                    }
                }

                MessageBox.Show("Đọc và ghi thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Chưa chọn file");
            }
        }
    }
}
