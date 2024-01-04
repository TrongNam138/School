namespace Bai_7
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.txtNS = new System.Windows.Forms.TextBox();
            this.txtHVT = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnT = new System.Windows.Forms.Button();
            this.btnDK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(706, 87);
            this.label1.TabIndex = 0;
            this.label1.Text = " Error Provider";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điểm trung bình:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh:";
            // 
            // txtDTB
            // 
            this.txtDTB.Location = new System.Drawing.Point(310, 237);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.Size = new System.Drawing.Size(258, 32);
            this.txtDTB.TabIndex = 4;
            this.txtDTB.TextChanged += new System.EventHandler(this.txtDTB_TextChanged);
            // 
            // txtNS
            // 
            this.txtNS.Location = new System.Drawing.Point(310, 182);
            this.txtNS.Name = "txtNS";
            this.txtNS.Size = new System.Drawing.Size(258, 32);
            this.txtNS.TabIndex = 5;
            this.txtNS.TextChanged += new System.EventHandler(this.txtNS_TextChanged);
            // 
            // txtHVT
            // 
            this.txtHVT.Location = new System.Drawing.Point(310, 127);
            this.txtHVT.Name = "txtHVT";
            this.txtHVT.Size = new System.Drawing.Size(258, 32);
            this.txtHVT.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnT);
            this.panel1.Controls.Add(this.btnDK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 318);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 100);
            this.panel1.TabIndex = 7;
            // 
            // btnT
            // 
            this.btnT.AutoSize = true;
            this.btnT.Location = new System.Drawing.Point(371, 23);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(128, 55);
            this.btnT.TabIndex = 1;
            this.btnT.Text = "Thoát";
            this.btnT.UseVisualStyleBackColor = true;
            // 
            // btnDK
            // 
            this.btnDK.AutoSize = true;
            this.btnDK.Location = new System.Drawing.Point(208, 23);
            this.btnDK.Name = "btnDK";
            this.btnDK.Size = new System.Drawing.Size(128, 55);
            this.btnDK.TabIndex = 0;
            this.btnDK.Text = "Đăng kí";
            this.btnDK.UseVisualStyleBackColor = true;
            this.btnDK.Click += new System.EventHandler(this.btnDK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(706, 418);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtHVT);
            this.Controls.Add(this.txtNS);
            this.Controls.Add(this.txtDTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai_7";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtHVT;
        private System.Windows.Forms.TextBox txtNS;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnDK;
    }
}

