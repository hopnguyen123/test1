
namespace Lab02_19521555_NguyenNgocHop
{
    partial class Lab02_Bai01_19521555
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
            this.btnGhiFile = new System.Windows.Forms.Button();
            this.richtxtIN = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnDocFile
            // 
            this.btnDocFile.Location = new System.Drawing.Point(40, 48);
            this.btnDocFile.Name = "btnDocFile";
            this.btnDocFile.Size = new System.Drawing.Size(224, 131);
            this.btnDocFile.TabIndex = 0;
            this.btnDocFile.Text = "Đọc File";
            this.btnDocFile.UseVisualStyleBackColor = true;
            this.btnDocFile.Click += new System.EventHandler(this.btnDocFile_Click);
            // 
            // btnGhiFile
            // 
            this.btnGhiFile.Location = new System.Drawing.Point(40, 228);
            this.btnGhiFile.Name = "btnGhiFile";
            this.btnGhiFile.Size = new System.Drawing.Size(224, 131);
            this.btnGhiFile.TabIndex = 1;
            this.btnGhiFile.Text = "Ghi File";
            this.btnGhiFile.UseVisualStyleBackColor = true;
            this.btnGhiFile.Click += new System.EventHandler(this.btnGhiFile_Click);
            // 
            // richtxtIN
            // 
            this.richtxtIN.Location = new System.Drawing.Point(393, 48);
            this.richtxtIN.Name = "richtxtIN";
            this.richtxtIN.Size = new System.Drawing.Size(364, 311);
            this.richtxtIN.TabIndex = 2;
            this.richtxtIN.Text = "";
            // 
            // Lab02_Bai01_19521555
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richtxtIN);
            this.Controls.Add(this.btnGhiFile);
            this.Controls.Add(this.btnDocFile);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Lab02_Bai01_19521555";
            this.Text = "Lab02_Bai01_19521555";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDocFile;
        private System.Windows.Forms.Button btnGhiFile;
        private System.Windows.Forms.RichTextBox richtxtIN;
    }
}