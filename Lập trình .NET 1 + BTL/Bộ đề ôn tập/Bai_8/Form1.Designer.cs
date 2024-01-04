namespace Bai_8
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbR = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbG = new System.Windows.Forms.TrackBar();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbB = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tbR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbB)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 139);
            this.panel1.TabIndex = 0;
            // 
            // tbR
            // 
            this.tbR.Location = new System.Drawing.Point(93, 177);
            this.tbR.Maximum = 255;
            this.tbR.Name = "tbR";
            this.tbR.Size = new System.Drawing.Size(551, 45);
            this.tbR.TabIndex = 1;
            this.tbR.Scroll += new System.EventHandler(this.tbR_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Red:";
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(662, 177);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(69, 35);
            this.txtR.TabIndex = 3;
            this.txtR.TextChanged += new System.EventHandler(this.txtR_TextChanged);
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(662, 242);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(69, 35);
            this.txtG.TabIndex = 6;
            this.txtG.TextChanged += new System.EventHandler(this.txtG_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Green:";
            // 
            // tbG
            // 
            this.tbG.Location = new System.Drawing.Point(93, 242);
            this.tbG.Maximum = 255;
            this.tbG.Name = "tbG";
            this.tbG.Size = new System.Drawing.Size(551, 45);
            this.tbG.TabIndex = 4;
            this.tbG.Scroll += new System.EventHandler(this.tbG_Scroll);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(662, 307);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(69, 35);
            this.txtB.TabIndex = 9;
            this.txtB.TextChanged += new System.EventHandler(this.txtB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Blue:";
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(93, 307);
            this.tbB.Maximum = 255;
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(551, 45);
            this.tbB.TabIndex = 7;
            this.tbB.Scroll += new System.EventHandler(this.tbB_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 369);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbG);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbR);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai_8";
            ((System.ComponentModel.ISupportInitialize)(this.tbR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar tbR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbG;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tbB;
    }
}

