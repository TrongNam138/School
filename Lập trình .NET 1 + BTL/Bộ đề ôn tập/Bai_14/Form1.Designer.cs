namespace Bai_14
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
            this.Li_DSSanPham = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSanPham = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSanPhanVT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboViTri = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThemVT = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXoaDS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách sản phẩm";
            // 
            // Li_DSSanPham
            // 
            this.Li_DSSanPham.FormattingEnabled = true;
            this.Li_DSSanPham.ItemHeight = 23;
            this.Li_DSSanPham.Location = new System.Drawing.Point(16, 35);
            this.Li_DSSanPham.Name = "Li_DSSanPham";
            this.Li_DSSanPham.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.Li_DSSanPham.Size = new System.Drawing.Size(173, 303);
            this.Li_DSSanPham.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thêm sản phẩm: ";
            // 
            // txtSanPham
            // 
            this.txtSanPham.Location = new System.Drawing.Point(364, 32);
            this.txtSanPham.Name = "txtSanPham";
            this.txtSanPham.Size = new System.Drawing.Size(215, 32);
            this.txtSanPham.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.Location = new System.Drawing.Point(585, 32);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 33);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSanPhanVT
            // 
            this.txtSanPhanVT.Location = new System.Drawing.Point(364, 102);
            this.txtSanPhanVT.Name = "txtSanPhanVT";
            this.txtSanPhanVT.Size = new System.Drawing.Size(215, 32);
            this.txtSanPhanVT.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thêm sản phẩm: ";
            // 
            // cboViTri
            // 
            this.cboViTri.FormattingEnabled = true;
            this.cboViTri.Location = new System.Drawing.Point(364, 148);
            this.cboViTri.Name = "cboViTri";
            this.cboViTri.Size = new System.Drawing.Size(215, 31);
            this.cboViTri.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vị trí thêm:";
            // 
            // btnThemVT
            // 
            this.btnThemVT.AutoSize = true;
            this.btnThemVT.Location = new System.Drawing.Point(585, 119);
            this.btnThemVT.Name = "btnThemVT";
            this.btnThemVT.Size = new System.Drawing.Size(85, 43);
            this.btnThemVT.TabIndex = 9;
            this.btnThemVT.Text = "Thêm";
            this.btnThemVT.UseVisualStyleBackColor = true;
            this.btnThemVT.Click += new System.EventHandler(this.btnThemVT_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(364, 218);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(215, 32);
            this.txtTimKiem.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tìm sản phẩm: ";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AutoSize = true;
            this.btnTimKiem.Location = new System.Drawing.Point(585, 218);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(85, 33);
            this.btnTimKiem.TabIndex = 12;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.Location = new System.Drawing.Point(212, 295);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(221, 43);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa sản phẩm";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXoaDS
            // 
            this.btnXoaDS.AutoSize = true;
            this.btnXoaDS.Location = new System.Drawing.Point(449, 295);
            this.btnXoaDS.Name = "btnXoaDS";
            this.btnXoaDS.Size = new System.Drawing.Size(221, 43);
            this.btnXoaDS.TabIndex = 14;
            this.btnXoaDS.Text = "Xóa danh sách sản phẩm";
            this.btnXoaDS.UseVisualStyleBackColor = true;
            this.btnXoaDS.Click += new System.EventHandler(this.btnXoaDS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 356);
            this.Controls.Add(this.btnXoaDS);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnThemVT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboViTri);
            this.Controls.Add(this.txtSanPhanVT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSanPham);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Li_DSSanPham);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai_14";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Li_DSSanPham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSanPham;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtSanPhanVT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboViTri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThemVT;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXoaDS;
    }
}

