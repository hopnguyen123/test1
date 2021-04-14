
namespace Lab02_19521555_NguyenNgocHop
{
    partial class Lab02_Bai05_19521555
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
            this.btnChon = new System.Windows.Forms.Button();
            this.lsvDanhSach = new System.Windows.Forms.ListView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(58, 332);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(373, 80);
            this.btnChon.TabIndex = 0;
            this.btnChon.Text = "Enter";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // lsvDanhSach
            // 
            this.lsvDanhSach.FullRowSelect = true;
            this.lsvDanhSach.GridLines = true;
            this.lsvDanhSach.HideSelection = false;
            this.lsvDanhSach.Location = new System.Drawing.Point(58, 49);
            this.lsvDanhSach.Name = "lsvDanhSach";
            this.lsvDanhSach.Size = new System.Drawing.Size(1074, 215);
            this.lsvDanhSach.TabIndex = 1;
            this.lsvDanhSach.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSach.View = System.Windows.Forms.View.Details;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(759, 314);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(373, 80);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Lab02_Bai05_19521555
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 445);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lsvDanhSach);
            this.Controls.Add(this.btnChon);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Lab02_Bai05_19521555";
            this.Text = "Lab02_Bai05_19521555";
            this.Load += new System.EventHandler(this.Lab02_Bai05_19521555_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.ListView lsvDanhSach;
        private System.Windows.Forms.Button btnThoat;
    }
}