namespace Bai_20
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNode = new System.Windows.Forms.TextBox();
            this.btnThemNodeGoc = new System.Windows.Forms.Button();
            this.btnThemNodeCon = new System.Windows.Forms.Button();
            this.btnXoaTatCaNode = new System.Windows.Forms.Button();
            this.btnXoaNodeDuocChon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(219, 251);
            this.treeView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiêu đề node:";
            // 
            // txtNode
            // 
            this.txtNode.Location = new System.Drawing.Point(266, 39);
            this.txtNode.Name = "txtNode";
            this.txtNode.Size = new System.Drawing.Size(308, 32);
            this.txtNode.TabIndex = 2;
            // 
            // btnThemNodeGoc
            // 
            this.btnThemNodeGoc.AutoSize = true;
            this.btnThemNodeGoc.Location = new System.Drawing.Point(266, 89);
            this.btnThemNodeGoc.Name = "btnThemNodeGoc";
            this.btnThemNodeGoc.Size = new System.Drawing.Size(308, 33);
            this.btnThemNodeGoc.TabIndex = 3;
            this.btnThemNodeGoc.Text = "Thêm node gốc";
            this.btnThemNodeGoc.UseVisualStyleBackColor = true;
            this.btnThemNodeGoc.Click += new System.EventHandler(this.btnThemNodeGoc_Click);
            // 
            // btnThemNodeCon
            // 
            this.btnThemNodeCon.AutoSize = true;
            this.btnThemNodeCon.Location = new System.Drawing.Point(266, 136);
            this.btnThemNodeCon.Name = "btnThemNodeCon";
            this.btnThemNodeCon.Size = new System.Drawing.Size(308, 33);
            this.btnThemNodeCon.TabIndex = 4;
            this.btnThemNodeCon.Text = "Thêm node con tại vị trí chọn";
            this.btnThemNodeCon.UseVisualStyleBackColor = true;
            this.btnThemNodeCon.Click += new System.EventHandler(this.btnThemNodeCon_Click);
            // 
            // btnXoaTatCaNode
            // 
            this.btnXoaTatCaNode.AutoSize = true;
            this.btnXoaTatCaNode.Location = new System.Drawing.Point(266, 183);
            this.btnXoaTatCaNode.Name = "btnXoaTatCaNode";
            this.btnXoaTatCaNode.Size = new System.Drawing.Size(308, 33);
            this.btnXoaTatCaNode.TabIndex = 5;
            this.btnXoaTatCaNode.Text = "Xóa tất các các node";
            this.btnXoaTatCaNode.UseVisualStyleBackColor = true;
            this.btnXoaTatCaNode.Click += new System.EventHandler(this.btnXoaTatCaNode_Click);
            // 
            // btnXoaNodeDuocChon
            // 
            this.btnXoaNodeDuocChon.AutoSize = true;
            this.btnXoaNodeDuocChon.Location = new System.Drawing.Point(266, 230);
            this.btnXoaNodeDuocChon.Name = "btnXoaNodeDuocChon";
            this.btnXoaNodeDuocChon.Size = new System.Drawing.Size(308, 33);
            this.btnXoaNodeDuocChon.TabIndex = 6;
            this.btnXoaNodeDuocChon.Text = "Xóa nút đang chọn\r\n";
            this.btnXoaNodeDuocChon.UseVisualStyleBackColor = true;
            this.btnXoaNodeDuocChon.Click += new System.EventHandler(this.btnXoaNodeDuocChon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 281);
            this.Controls.Add(this.btnXoaNodeDuocChon);
            this.Controls.Add(this.btnXoaTatCaNode);
            this.Controls.Add(this.btnThemNodeCon);
            this.Controls.Add(this.btnThemNodeGoc);
            this.Controls.Add(this.txtNode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai_20";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNode;
        private System.Windows.Forms.Button btnThemNodeGoc;
        private System.Windows.Forms.Button btnThemNodeCon;
        private System.Windows.Forms.Button btnXoaTatCaNode;
        private System.Windows.Forms.Button btnXoaNodeDuocChon;
    }
}

