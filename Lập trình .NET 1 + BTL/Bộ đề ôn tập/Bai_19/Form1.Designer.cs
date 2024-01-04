namespace Bai_19
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListL = new System.Windows.Forms.ImageList(this.components);
            this.imageListS = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cboView = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtHoDem = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView.HideSelection = false;
            this.listView.LargeImageList = this.imageListL;
            this.listView.Location = new System.Drawing.Point(12, 66);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(437, 222);
            this.listView.SmallImageList = this.imageListS;
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Họ đệm";
            this.columnHeader1.Width = 152;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên";
            this.columnHeader2.Width = 128;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số điện thoại";
            this.columnHeader3.Width = 152;
            // 
            // imageListL
            // 
            this.imageListL.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListL.ImageStream")));
            this.imageListL.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListL.Images.SetKeyName(0, "user.png");
            // 
            // imageListS
            // 
            this.imageListS.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListS.ImageStream")));
            this.imageListS.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListS.Images.SetKeyName(0, "user.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "View:";
            // 
            // cboView
            // 
            this.cboView.FormattingEnabled = true;
            this.cboView.Location = new System.Drawing.Point(78, 15);
            this.cboView.Name = "cboView";
            this.cboView.Size = new System.Drawing.Size(107, 31);
            this.cboView.TabIndex = 2;
            this.cboView.SelectedIndexChanged += new System.EventHandler(this.cboView_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ đệm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Điện thoại:";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(570, 174);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(169, 32);
            this.txtDienThoai.TabIndex = 6;
            // 
            // txtHoDem
            // 
            this.txtHoDem.Location = new System.Drawing.Point(570, 66);
            this.txtHoDem.Name = "txtHoDem";
            this.txtHoDem.Size = new System.Drawing.Size(169, 32);
            this.txtHoDem.TabIndex = 7;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(570, 120);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(169, 32);
            this.txtTen.TabIndex = 8;
            // 
            // txtThem
            // 
            this.txtThem.AutoSize = true;
            this.txtThem.Location = new System.Drawing.Point(465, 236);
            this.txtThem.Name = "txtThem";
            this.txtThem.Size = new System.Drawing.Size(274, 52);
            this.txtThem.TabIndex = 9;
            this.txtThem.Text = "Thêm";
            this.txtThem.UseVisualStyleBackColor = true;
            this.txtThem.Click += new System.EventHandler(this.txtThem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 305);
            this.Controls.Add(this.txtThem);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHoDem);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Bai_19";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtHoDem;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button txtThem;
        private System.Windows.Forms.ImageList imageListL;
        private System.Windows.Forms.ImageList imageListS;
    }
}

