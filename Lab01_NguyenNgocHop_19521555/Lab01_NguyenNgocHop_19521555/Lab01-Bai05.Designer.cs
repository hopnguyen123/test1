
namespace Lab01_NguyenNgocHop_19521555
{
    partial class Bai05
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnTinhGiaTri = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblS2 = new System.Windows.Forms.Label();
            this.lblS1 = new System.Windows.Forms.Label();
            this.lblS3 = new System.Windows.Forms.Label();
            this.lblB1 = new System.Windows.Forms.Label();
            this.lblA1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập A:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập B:";
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtA.Location = new System.Drawing.Point(115, 36);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(266, 30);
            this.txtA.TabIndex = 2;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(506, 36);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(266, 30);
            this.txtB.TabIndex = 3;
            // 
            // btnTinhGiaTri
            // 
            this.btnTinhGiaTri.Location = new System.Drawing.Point(12, 98);
            this.btnTinhGiaTri.Name = "btnTinhGiaTri";
            this.btnTinhGiaTri.Size = new System.Drawing.Size(369, 42);
            this.btnTinhGiaTri.TabIndex = 4;
            this.btnTinhGiaTri.Text = "Tính Giá Trị";
            this.btnTinhGiaTri.UseVisualStyleBackColor = true;
            this.btnTinhGiaTri.Click += new System.EventHandler(this.btnTinhGiaTri_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(447, 98);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(141, 42);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(640, 98);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(132, 42);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblS2);
            this.groupBox1.Controls.Add(this.lblS1);
            this.groupBox1.Controls.Add(this.lblS3);
            this.groupBox1.Controls.Add(this.lblB1);
            this.groupBox1.Controls.Add(this.lblA1);
            this.groupBox1.Location = new System.Drawing.Point(12, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 215);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết Quả";
            // 
            // lblS2
            // 
            this.lblS2.AutoSize = true;
            this.lblS2.Location = new System.Drawing.Point(19, 132);
            this.lblS2.Name = "lblS2";
            this.lblS2.Size = new System.Drawing.Size(261, 23);
            this.lblS2.TabIndex = 4;
            this.lblS2.Text = "S2 = 1 + 2 + 3 + 4 + ... + B = ...";
            // 
            // lblS1
            // 
            this.lblS1.AutoSize = true;
            this.lblS1.Location = new System.Drawing.Point(19, 88);
            this.lblS1.Name = "lblS1";
            this.lblS1.Size = new System.Drawing.Size(260, 23);
            this.lblS1.TabIndex = 3;
            this.lblS1.Text = "S1 = 1 + 2 + 3 + 4 + ... + A = ...";
            // 
            // lblS3
            // 
            this.lblS3.AutoSize = true;
            this.lblS3.Location = new System.Drawing.Point(19, 175);
            this.lblS3.Name = "lblS3";
            this.lblS3.Size = new System.Drawing.Size(386, 23);
            this.lblS3.TabIndex = 2;
            this.lblS3.Text = "S3 = A^1 + A^2 + A^3 + A^4 + ... + A^B = ...";
            // 
            // lblB1
            // 
            this.lblB1.AutoSize = true;
            this.lblB1.Location = new System.Drawing.Point(410, 43);
            this.lblB1.Name = "lblB1";
            this.lblB1.Size = new System.Drawing.Size(66, 23);
            this.lblB1.TabIndex = 1;
            this.lblB1.Text = "B! = ...";
            // 
            // lblA1
            // 
            this.lblA1.AutoSize = true;
            this.lblA1.Location = new System.Drawing.Point(19, 43);
            this.lblA1.Name = "lblA1";
            this.lblA1.Size = new System.Drawing.Size(67, 23);
            this.lblA1.TabIndex = 0;
            this.lblA1.Text = "A! = ...";
            // 
            // Bai05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTinhGiaTri);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Bai05";
            this.Text = "Bai05";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnTinhGiaTri;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblS2;
        private System.Windows.Forms.Label lblS1;
        private System.Windows.Forms.Label lblS3;
        private System.Windows.Forms.Label lblB1;
        private System.Windows.Forms.Label lblA1;
    }
}