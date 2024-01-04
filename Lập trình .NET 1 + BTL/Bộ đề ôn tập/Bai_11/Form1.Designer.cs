namespace Bai_11
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUSCLN = new System.Windows.Forms.TextBox();
            this.txtBSCNN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số A";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(86, 29);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(91, 29);
            this.txtA.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ước số chung lớn nhất:";
            // 
            // txtUSCLN
            // 
            this.txtUSCLN.Location = new System.Drawing.Point(240, 94);
            this.txtUSCLN.Name = "txtUSCLN";
            this.txtUSCLN.ReadOnly = true;
            this.txtUSCLN.Size = new System.Drawing.Size(100, 29);
            this.txtUSCLN.TabIndex = 5;
            // 
            // txtBSCNN
            // 
            this.txtBSCNN.Location = new System.Drawing.Point(240, 139);
            this.txtBSCNN.Name = "txtBSCNN";
            this.txtBSCNN.ReadOnly = true;
            this.txtBSCNN.Size = new System.Drawing.Size(100, 29);
            this.txtBSCNN.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bội số chung nhỏ nhất:";
            // 
            // btnFind
            // 
            this.btnFind.AutoSize = true;
            this.btnFind.Location = new System.Drawing.Point(33, 198);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(115, 42);
            this.btnFind.TabIndex = 8;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(249, 32);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(91, 29);
            this.txtB.TabIndex = 9;
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Location = new System.Drawing.Point(225, 198);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 42);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 269);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtBSCNN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUSCLN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USCLN_va_BSCNN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUSCLN;
        private System.Windows.Forms.TextBox txtBSCNN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnExit;
    }
}

