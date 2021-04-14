
namespace Lab01_NguyenNgocHop_19521555
{
    partial class Bai04
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
            this.txtTienDaDoi = new System.Windows.Forms.TextBox();
            this.btnChuyenDoi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTienChuyenDoi = new System.Windows.Forms.TextBox();
            this.lblTyGia = new System.Windows.Forms.Label();
            this.cmBDonVi = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTienDaDoi
            // 
            this.txtTienDaDoi.Enabled = false;
            this.txtTienDaDoi.Location = new System.Drawing.Point(270, 171);
            this.txtTienDaDoi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTienDaDoi.Name = "txtTienDaDoi";
            this.txtTienDaDoi.Size = new System.Drawing.Size(216, 34);
            this.txtTienDaDoi.TabIndex = 1;
            // 
            // btnChuyenDoi
            // 
            this.btnChuyenDoi.Location = new System.Drawing.Point(56, 114);
            this.btnChuyenDoi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnChuyenDoi.Name = "btnChuyenDoi";
            this.btnChuyenDoi.Size = new System.Drawing.Size(430, 36);
            this.btnChuyenDoi.TabIndex = 2;
            this.btnChuyenDoi.Text = "Chuyển Đổi";
            this.btnChuyenDoi.UseVisualStyleBackColor = true;
            this.btnChuyenDoi.Click += new System.EventHandler(this.btnChuyenDoi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số Tiền Đã Đổi";
            // 
            // txtTienChuyenDoi
            // 
            this.txtTienChuyenDoi.Location = new System.Drawing.Point(270, 51);
            this.txtTienChuyenDoi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTienChuyenDoi.Name = "txtTienChuyenDoi";
            this.txtTienChuyenDoi.Size = new System.Drawing.Size(216, 34);
            this.txtTienChuyenDoi.TabIndex = 4;
            // 
            // lblTyGia
            // 
            this.lblTyGia.AutoSize = true;
            this.lblTyGia.Location = new System.Drawing.Point(56, 240);
            this.lblTyGia.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTyGia.Name = "lblTyGia";
            this.lblTyGia.Size = new System.Drawing.Size(167, 25);
            this.lblTyGia.TabIndex = 5;
            this.lblTyGia.Text = "Tỷ Giá Quy Đổi";
            // 
            // cmBDonVi
            // 
            this.cmBDonVi.FormattingEnabled = true;
            this.cmBDonVi.Location = new System.Drawing.Point(512, 52);
            this.cmBDonVi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmBDonVi.Name = "cmBDonVi";
            this.cmBDonVi.Size = new System.Drawing.Size(204, 33);
            this.cmBDonVi.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmBDonVi);
            this.groupBox1.Controls.Add(this.txtTienChuyenDoi);
            this.groupBox1.Controls.Add(this.lblTyGia);
            this.groupBox1.Controls.Add(this.btnChuyenDoi);
            this.groupBox1.Controls.Add(this.txtTienDaDoi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(32, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 295);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chuyển Đổi Tiền Tệ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số Tiền Cần Đổi:";
            // 
            // Bai04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 368);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Bai04";
            this.Text = "Bai04";
            this.Load += new System.EventHandler(this.Bai04_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtTienDaDoi;
        private System.Windows.Forms.Button btnChuyenDoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTienChuyenDoi;
        private System.Windows.Forms.Label lblTyGia;
        private System.Windows.Forms.ComboBox cmBDonVi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}