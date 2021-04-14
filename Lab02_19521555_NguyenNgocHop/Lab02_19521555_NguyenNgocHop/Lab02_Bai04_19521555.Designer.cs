
namespace Lab02_19521555_NguyenNgocHop
{
    partial class Lab02_Bai04_19521555
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.btnNhap_INPUT = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnOUTPUT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "Số lượng sinh viên:";
            // 
            // btnNhap_INPUT
            // 
            this.btnNhap_INPUT.Location = new System.Drawing.Point(58, 101);
            this.btnNhap_INPUT.Name = "btnNhap_INPUT";
            this.btnNhap_INPUT.Size = new System.Drawing.Size(363, 45);
            this.btnNhap_INPUT.TabIndex = 18;
            this.btnNhap_INPUT.Text = "Nhập vào INPUT";
            this.btnNhap_INPUT.UseVisualStyleBackColor = true;
            this.btnNhap_INPUT.Click += new System.EventHandler(this.btnNhap_INPUT_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(296, 42);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(125, 30);
            this.txtSoLuong.TabIndex = 19;
            // 
            // btnOUTPUT
            // 
            this.btnOUTPUT.Location = new System.Drawing.Point(58, 190);
            this.btnOUTPUT.Name = "btnOUTPUT";
            this.btnOUTPUT.Size = new System.Drawing.Size(363, 45);
            this.btnOUTPUT.TabIndex = 20;
            this.btnOUTPUT.Text = "Xuất ra OUTPUT";
            this.btnOUTPUT.UseVisualStyleBackColor = true;
            this.btnOUTPUT.Click += new System.EventHandler(this.btnOUTPUT_Click);
            // 
            // Lab02_Bai04_19521555
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 299);
            this.Controls.Add(this.btnOUTPUT);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.btnNhap_INPUT);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Lab02_Bai04_19521555";
            this.Text = "Lab02_Bai04_19521555";
            this.Load += new System.EventHandler(this.Lab02_Bai04_19521555_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNhap_INPUT;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnOUTPUT;
    }
}