namespace Bai_16
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSubject1 = new System.Windows.Forms.CheckBox();
            this.cbSubject2 = new System.Windows.Forms.CheckBox();
            this.cbSubject3 = new System.Windows.Forms.CheckBox();
            this.cbSubject4 = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Sinh Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(146, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(177, 32);
            this.txtName.TabIndex = 2;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(146, 121);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(177, 32);
            this.txtClass.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lớp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Danh sách môn học tự chọn:\r\n";
            // 
            // cbSubject1
            // 
            this.cbSubject1.AutoSize = true;
            this.cbSubject1.Location = new System.Drawing.Point(107, 231);
            this.cbSubject1.Name = "cbSubject1";
            this.cbSubject1.Size = new System.Drawing.Size(134, 27);
            this.cbSubject1.TabIndex = 6;
            this.cbSubject1.Text = "Lập trình C#";
            this.cbSubject1.UseVisualStyleBackColor = true;
            // 
            // cbSubject2
            // 
            this.cbSubject2.AutoSize = true;
            this.cbSubject2.Location = new System.Drawing.Point(107, 264);
            this.cbSubject2.Name = "cbSubject2";
            this.cbSubject2.Size = new System.Drawing.Size(152, 27);
            this.cbSubject2.TabIndex = 7;
            this.cbSubject2.Text = "Mạng máy tính";
            this.cbSubject2.UseVisualStyleBackColor = true;
            // 
            // cbSubject3
            // 
            this.cbSubject3.AutoSize = true;
            this.cbSubject3.Location = new System.Drawing.Point(108, 297);
            this.cbSubject3.Name = "cbSubject3";
            this.cbSubject3.Size = new System.Drawing.Size(108, 27);
            this.cbSubject3.TabIndex = 8;
            this.cbSubject3.Text = "Xử lý ảnh";
            this.cbSubject3.UseVisualStyleBackColor = true;
            // 
            // cbSubject4
            // 
            this.cbSubject4.AutoSize = true;
            this.cbSubject4.Location = new System.Drawing.Point(108, 330);
            this.cbSubject4.Name = "cbSubject4";
            this.cbSubject4.Size = new System.Drawing.Size(143, 27);
            this.cbSubject4.TabIndex = 9;
            this.cbSubject4.Text = "Lập trình web";
            this.cbSubject4.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(81, 386);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 33);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(200, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 33);
            this.button2.TabIndex = 11;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 441);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbSubject4);
            this.Controls.Add(this.cbSubject3);
            this.Controls.Add(this.cbSubject2);
            this.Controls.Add(this.cbSubject1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 16";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbSubject1;
        private System.Windows.Forms.CheckBox cbSubject2;
        private System.Windows.Forms.CheckBox cbSubject3;
        private System.Windows.Forms.CheckBox cbSubject4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button2;
    }
}

