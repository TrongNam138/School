namespace Bai_24
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMauNen = new System.Windows.Forms.RadioButton();
            this.rbMauChu = new System.Windows.Forms.RadioButton();
            this.btnChonMau = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(654, 123);
            this.label1.TabIndex = 0;
            this.label1.Text = "Công nghệ thông tin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMauNen);
            this.groupBox1.Controls.Add(this.rbMauChu);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 116);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn màu chữ hoặc màu nền:";
            // 
            // rbMauNen
            // 
            this.rbMauNen.AutoSize = true;
            this.rbMauNen.Location = new System.Drawing.Point(23, 73);
            this.rbMauNen.Name = "rbMauNen";
            this.rbMauNen.Size = new System.Drawing.Size(92, 25);
            this.rbMauNen.TabIndex = 3;
            this.rbMauNen.TabStop = true;
            this.rbMauNen.Text = "Màu nền";
            this.rbMauNen.UseVisualStyleBackColor = true;
            // 
            // rbMauChu
            // 
            this.rbMauChu.AutoSize = true;
            this.rbMauChu.Location = new System.Drawing.Point(23, 42);
            this.rbMauChu.Name = "rbMauChu";
            this.rbMauChu.Size = new System.Drawing.Size(94, 25);
            this.rbMauChu.TabIndex = 2;
            this.rbMauChu.TabStop = true;
            this.rbMauChu.Text = "Màu chữ";
            this.rbMauChu.UseVisualStyleBackColor = true;
            // 
            // btnChonMau
            // 
            this.btnChonMau.AutoSize = true;
            this.btnChonMau.Location = new System.Drawing.Point(360, 163);
            this.btnChonMau.Name = "btnChonMau";
            this.btnChonMau.Size = new System.Drawing.Size(223, 74);
            this.btnChonMau.TabIndex = 2;
            this.btnChonMau.Text = "Chọn màu";
            this.btnChonMau.UseVisualStyleBackColor = true;
            this.btnChonMau.Click += new System.EventHandler(this.btnChonMau_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 267);
            this.Controls.Add(this.btnChonMau);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai_24";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMauChu;
        private System.Windows.Forms.RadioButton rbMauNen;
        private System.Windows.Forms.Button btnChonMau;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}

