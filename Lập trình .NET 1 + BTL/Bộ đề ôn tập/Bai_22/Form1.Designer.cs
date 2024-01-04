namespace Bai_22
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listViewTab1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTab1Ẹdit = new System.Windows.Forms.Button();
            this.btnTab1Delete = new System.Windows.Forms.Button();
            this.btnTab1Add = new System.Windows.Forms.Button();
            this.txtTab1LuongCoBan = new System.Windows.Forms.TextBox();
            this.txtTab1HeSoLuong = new System.Windows.Forms.TextBox();
            this.txtTab1HoVaTen = new System.Windows.Forms.TextBox();
            this.txtTab1ChucVu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listViewTab2 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTab2Edit = new System.Windows.Forms.Button();
            this.btnTab2Delete = new System.Windows.Forms.Button();
            this.btnTab2Add = new System.Windows.Forms.Button();
            this.txtTab2SoTietDay = new System.Windows.Forms.TextBox();
            this.txtTab2TienMotTiet = new System.Windows.Forms.TextBox();
            this.txtTab2HoVaTen = new System.Windows.Forms.TextBox();
            this.txtTab2HocVi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(796, 520);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listViewTab1);
            this.tabPage1.Controls.Add(this.btnTab1Ẹdit);
            this.tabPage1.Controls.Add(this.btnTab1Delete);
            this.tabPage1.Controls.Add(this.btnTab1Add);
            this.tabPage1.Controls.Add(this.txtTab1LuongCoBan);
            this.tabPage1.Controls.Add(this.txtTab1HeSoLuong);
            this.tabPage1.Controls.Add(this.txtTab1HoVaTen);
            this.tabPage1.Controls.Add(this.txtTab1ChucVu);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage1.Size = new System.Drawing.Size(788, 484);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý nhân viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listViewTab1
            // 
            this.listViewTab1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewTab1.FullRowSelect = true;
            this.listViewTab1.HideSelection = false;
            this.listViewTab1.Location = new System.Drawing.Point(8, 219);
            this.listViewTab1.MultiSelect = false;
            this.listViewTab1.Name = "listViewTab1";
            this.listViewTab1.Size = new System.Drawing.Size(770, 257);
            this.listViewTab1.TabIndex = 11;
            this.listViewTab1.UseCompatibleStateImageBehavior = false;
            this.listViewTab1.View = System.Windows.Forms.View.Details;
            this.listViewTab1.SelectedIndexChanged += new System.EventHandler(this.listViewTab1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Họ và tên";
            this.columnHeader1.Width = 232;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Chức vụ";
            this.columnHeader2.Width = 182;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Lương cơ bản";
            this.columnHeader3.Width = 217;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Hệ số";
            this.columnHeader4.Width = 135;
            // 
            // btnTab1Ẹdit
            // 
            this.btnTab1Ẹdit.AutoSize = true;
            this.btnTab1Ẹdit.Location = new System.Drawing.Point(200, 146);
            this.btnTab1Ẹdit.Name = "btnTab1Ẹdit";
            this.btnTab1Ẹdit.Size = new System.Drawing.Size(117, 47);
            this.btnTab1Ẹdit.TabIndex = 10;
            this.btnTab1Ẹdit.Text = "Sửa";
            this.btnTab1Ẹdit.UseVisualStyleBackColor = true;
            this.btnTab1Ẹdit.Click += new System.EventHandler(this.btnTab1Ẹdit_Click);
            // 
            // btnTab1Delete
            // 
            this.btnTab1Delete.AutoSize = true;
            this.btnTab1Delete.Location = new System.Drawing.Point(347, 146);
            this.btnTab1Delete.Name = "btnTab1Delete";
            this.btnTab1Delete.Size = new System.Drawing.Size(117, 47);
            this.btnTab1Delete.TabIndex = 9;
            this.btnTab1Delete.Text = "Xóa";
            this.btnTab1Delete.UseVisualStyleBackColor = true;
            this.btnTab1Delete.Click += new System.EventHandler(this.btnTab1Delete_Click);
            // 
            // btnTab1Add
            // 
            this.btnTab1Add.AutoSize = true;
            this.btnTab1Add.Location = new System.Drawing.Point(53, 146);
            this.btnTab1Add.Name = "btnTab1Add";
            this.btnTab1Add.Size = new System.Drawing.Size(117, 47);
            this.btnTab1Add.TabIndex = 8;
            this.btnTab1Add.Text = "Thêm";
            this.btnTab1Add.UseVisualStyleBackColor = true;
            this.btnTab1Add.Click += new System.EventHandler(this.btnTab1Add_Click);
            // 
            // txtTab1LuongCoBan
            // 
            this.txtTab1LuongCoBan.Location = new System.Drawing.Point(550, 26);
            this.txtTab1LuongCoBan.Name = "txtTab1LuongCoBan";
            this.txtTab1LuongCoBan.Size = new System.Drawing.Size(189, 32);
            this.txtTab1LuongCoBan.TabIndex = 7;
            // 
            // txtTab1HeSoLuong
            // 
            this.txtTab1HeSoLuong.Location = new System.Drawing.Point(550, 82);
            this.txtTab1HeSoLuong.Name = "txtTab1HeSoLuong";
            this.txtTab1HeSoLuong.Size = new System.Drawing.Size(189, 32);
            this.txtTab1HeSoLuong.TabIndex = 6;
            // 
            // txtTab1HoVaTen
            // 
            this.txtTab1HoVaTen.Location = new System.Drawing.Point(157, 26);
            this.txtTab1HoVaTen.Name = "txtTab1HoVaTen";
            this.txtTab1HoVaTen.Size = new System.Drawing.Size(189, 32);
            this.txtTab1HoVaTen.TabIndex = 5;
            // 
            // txtTab1ChucVu
            // 
            this.txtTab1ChucVu.Location = new System.Drawing.Point(157, 82);
            this.txtTab1ChucVu.Name = "txtTab1ChucVu";
            this.txtTab1ChucVu.Size = new System.Drawing.Size(189, 32);
            this.txtTab1ChucVu.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lương cơ bản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hệ số lương";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chức vụ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listViewTab2);
            this.tabPage2.Controls.Add(this.btnTab2Edit);
            this.tabPage2.Controls.Add(this.btnTab2Delete);
            this.tabPage2.Controls.Add(this.btnTab2Add);
            this.tabPage2.Controls.Add(this.txtTab2SoTietDay);
            this.tabPage2.Controls.Add(this.txtTab2TienMotTiet);
            this.tabPage2.Controls.Add(this.txtTab2HoVaTen);
            this.tabPage2.Controls.Add(this.txtTab2HocVi);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage2.Size = new System.Drawing.Size(788, 484);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lý giáo viên";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listViewTab2
            // 
            this.listViewTab2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listViewTab2.FullRowSelect = true;
            this.listViewTab2.HideSelection = false;
            this.listViewTab2.Location = new System.Drawing.Point(9, 210);
            this.listViewTab2.MultiSelect = false;
            this.listViewTab2.Name = "listViewTab2";
            this.listViewTab2.Size = new System.Drawing.Size(770, 257);
            this.listViewTab2.TabIndex = 23;
            this.listViewTab2.UseCompatibleStateImageBehavior = false;
            this.listViewTab2.View = System.Windows.Forms.View.Details;
            this.listViewTab2.SelectedIndexChanged += new System.EventHandler(this.listViewTab2_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Họ và tên";
            this.columnHeader5.Width = 240;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Học vị";
            this.columnHeader6.Width = 191;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Số tiết dạy";
            this.columnHeader7.Width = 175;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tiền dạy 1 tiết";
            this.columnHeader8.Width = 160;
            // 
            // btnTab2Edit
            // 
            this.btnTab2Edit.AutoSize = true;
            this.btnTab2Edit.Location = new System.Drawing.Point(198, 134);
            this.btnTab2Edit.Name = "btnTab2Edit";
            this.btnTab2Edit.Size = new System.Drawing.Size(117, 47);
            this.btnTab2Edit.TabIndex = 22;
            this.btnTab2Edit.Text = "Sửa";
            this.btnTab2Edit.UseVisualStyleBackColor = true;
            this.btnTab2Edit.Click += new System.EventHandler(this.btnTab2Edit_Click);
            // 
            // btnTab2Delete
            // 
            this.btnTab2Delete.AutoSize = true;
            this.btnTab2Delete.Location = new System.Drawing.Point(345, 134);
            this.btnTab2Delete.Name = "btnTab2Delete";
            this.btnTab2Delete.Size = new System.Drawing.Size(117, 47);
            this.btnTab2Delete.TabIndex = 21;
            this.btnTab2Delete.Text = "Xóa";
            this.btnTab2Delete.UseVisualStyleBackColor = true;
            this.btnTab2Delete.Click += new System.EventHandler(this.btnTab2Delete_Click);
            // 
            // btnTab2Add
            // 
            this.btnTab2Add.AutoSize = true;
            this.btnTab2Add.Location = new System.Drawing.Point(51, 134);
            this.btnTab2Add.Name = "btnTab2Add";
            this.btnTab2Add.Size = new System.Drawing.Size(117, 47);
            this.btnTab2Add.TabIndex = 20;
            this.btnTab2Add.Text = "Thêm";
            this.btnTab2Add.UseVisualStyleBackColor = true;
            this.btnTab2Add.Click += new System.EventHandler(this.btnTab2Add_Click);
            // 
            // txtTab2SoTietDay
            // 
            this.txtTab2SoTietDay.Location = new System.Drawing.Point(552, 19);
            this.txtTab2SoTietDay.Name = "txtTab2SoTietDay";
            this.txtTab2SoTietDay.Size = new System.Drawing.Size(189, 32);
            this.txtTab2SoTietDay.TabIndex = 19;
            // 
            // txtTab2TienMotTiet
            // 
            this.txtTab2TienMotTiet.Location = new System.Drawing.Point(552, 75);
            this.txtTab2TienMotTiet.Name = "txtTab2TienMotTiet";
            this.txtTab2TienMotTiet.Size = new System.Drawing.Size(189, 32);
            this.txtTab2TienMotTiet.TabIndex = 18;
            // 
            // txtTab2HoVaTen
            // 
            this.txtTab2HoVaTen.Location = new System.Drawing.Point(154, 19);
            this.txtTab2HoVaTen.Name = "txtTab2HoVaTen";
            this.txtTab2HoVaTen.Size = new System.Drawing.Size(189, 32);
            this.txtTab2HoVaTen.TabIndex = 17;
            // 
            // txtTab2HocVi
            // 
            this.txtTab2HocVi.Location = new System.Drawing.Point(155, 75);
            this.txtTab2HocVi.Name = "txtTab2HocVi";
            this.txtTab2HocVi.Size = new System.Drawing.Size(189, 32);
            this.txtTab2HocVi.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Số tiết dạy:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(413, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tiền dạy 1 tiết:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Học vị:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "Họ và tên:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 520);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai_22";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnTab1Ẹdit;
        private System.Windows.Forms.Button btnTab1Delete;
        private System.Windows.Forms.Button btnTab1Add;
        private System.Windows.Forms.TextBox txtTab1LuongCoBan;
        private System.Windows.Forms.TextBox txtTab1HeSoLuong;
        private System.Windows.Forms.TextBox txtTab1HoVaTen;
        private System.Windows.Forms.TextBox txtTab1ChucVu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewTab1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listViewTab2;
        private System.Windows.Forms.Button btnTab2Edit;
        private System.Windows.Forms.Button btnTab2Delete;
        private System.Windows.Forms.Button btnTab2Add;
        private System.Windows.Forms.TextBox txtTab2SoTietDay;
        private System.Windows.Forms.TextBox txtTab2TienMotTiet;
        private System.Windows.Forms.TextBox txtTab2HoVaTen;
        private System.Windows.Forms.TextBox txtTab2HocVi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}

