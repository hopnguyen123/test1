
namespace Lab02_19521555_NguyenNgocHop
{
    partial class Lab02_Bai02_19521555
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
            this.btnDocFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenFile = new System.Windows.Forms.TextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtSoDong = new System.Windows.Forms.TextBox();
            this.txtSoTu = new System.Windows.Forms.TextBox();
            this.txtSoKiTu = new System.Windows.Forms.TextBox();
            this.richtxtIN = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnDocFile
            // 
            this.btnDocFile.Location = new System.Drawing.Point(39, 30);
            this.btnDocFile.Name = "btnDocFile";
            this.btnDocFile.Size = new System.Drawing.Size(344, 95);
            this.btnDocFile.TabIndex = 0;
            this.btnDocFile.Text = "Đọc File";
            this.btnDocFile.UseVisualStyleBackColor = true;
            this.btnDocFile.Click += new System.EventHandler(this.btnDocFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên File:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "URL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số Dòng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số Từ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số Kí Tự:";
            // 
            // txtTenFile
            // 
            this.txtTenFile.Enabled = false;
            this.txtTenFile.Location = new System.Drawing.Point(169, 173);
            this.txtTenFile.Name = "txtTenFile";
            this.txtTenFile.Size = new System.Drawing.Size(214, 30);
            this.txtTenFile.TabIndex = 6;
            // 
            // txtURL
            // 
            this.txtURL.Enabled = false;
            this.txtURL.Location = new System.Drawing.Point(169, 224);
            this.txtURL.Multiline = true;
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(214, 95);
            this.txtURL.TabIndex = 7;
            // 
            // txtSoDong
            // 
            this.txtSoDong.Enabled = false;
            this.txtSoDong.Location = new System.Drawing.Point(169, 325);
            this.txtSoDong.Name = "txtSoDong";
            this.txtSoDong.Size = new System.Drawing.Size(214, 30);
            this.txtSoDong.TabIndex = 8;
            // 
            // txtSoTu
            // 
            this.txtSoTu.Enabled = false;
            this.txtSoTu.Location = new System.Drawing.Point(169, 361);
            this.txtSoTu.Name = "txtSoTu";
            this.txtSoTu.Size = new System.Drawing.Size(214, 30);
            this.txtSoTu.TabIndex = 9;
            // 
            // txtSoKiTu
            // 
            this.txtSoKiTu.Enabled = false;
            this.txtSoKiTu.Location = new System.Drawing.Point(169, 397);
            this.txtSoKiTu.Name = "txtSoKiTu";
            this.txtSoKiTu.Size = new System.Drawing.Size(214, 30);
            this.txtSoKiTu.TabIndex = 10;
            // 
            // richtxtIN
            // 
            this.richtxtIN.Location = new System.Drawing.Point(432, 30);
            this.richtxtIN.Name = "richtxtIN";
            this.richtxtIN.Size = new System.Drawing.Size(327, 397);
            this.richtxtIN.TabIndex = 11;
            this.richtxtIN.Text = "";
            // 
            // Lab02_Bai02_19521555
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richtxtIN);
            this.Controls.Add(this.txtSoKiTu);
            this.Controls.Add(this.txtSoTu);
            this.Controls.Add(this.txtSoDong);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.txtTenFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDocFile);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Lab02_Bai02_19521555";
            this.Text = "Lab02_Bai02_19521555";
            this.Load += new System.EventHandler(this.Lab02_Bai02_19521555_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDocFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenFile;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtSoDong;
        private System.Windows.Forms.TextBox txtSoTu;
        private System.Windows.Forms.TextBox txtSoKiTu;
        private System.Windows.Forms.RichTextBox richtxtIN;
    }
}