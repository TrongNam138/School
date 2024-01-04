namespace Bai_25
{
    partial class Form1
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
            this.btnMoTapTin = new System.Windows.Forms.Button();
            this.btnLuuTapTin = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soạn thảo văn bản";
            // 
            // btnMoTapTin
            // 
            this.btnMoTapTin.AutoSize = true;
            this.btnMoTapTin.Location = new System.Drawing.Point(196, 83);
            this.btnMoTapTin.Name = "btnMoTapTin";
            this.btnMoTapTin.Size = new System.Drawing.Size(134, 46);
            this.btnMoTapTin.TabIndex = 1;
            this.btnMoTapTin.Text = "Mở tập tin";
            this.btnMoTapTin.UseVisualStyleBackColor = true;
            this.btnMoTapTin.Click += new System.EventHandler(this.btnMoTapTin_Click);
            // 
            // btnLuuTapTin
            // 
            this.btnLuuTapTin.AutoSize = true;
            this.btnLuuTapTin.Location = new System.Drawing.Point(360, 83);
            this.btnLuuTapTin.Name = "btnLuuTapTin";
            this.btnLuuTapTin.Size = new System.Drawing.Size(139, 46);
            this.btnLuuTapTin.TabIndex = 2;
            this.btnLuuTapTin.Text = "Lưu tập tin";
            this.btnLuuTapTin.UseVisualStyleBackColor = true;
            this.btnLuuTapTin.Click += new System.EventHandler(this.btnLuuTapTin_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = true;
            this.btnThoat.Location = new System.Drawing.Point(529, 83);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(139, 46);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 147);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(840, 379);
            this.textBox.TabIndex = 4;
            // 
            // Bai_25
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 538);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuuTapTin);
            this.Controls.Add(this.btnMoTapTin);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Bai_25";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai_25";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMoTapTin;
        private System.Windows.Forms.Button btnLuuTapTin;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

