namespace Project2
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
            this.lbNhap = new System.Windows.Forms.Label();
            this.txtNN = new System.Windows.Forms.TextBox();
            this.lbList = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lsbNN = new System.Windows.Forms.ListBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNhap
            // 
            this.lbNhap.AutoSize = true;
            this.lbNhap.Location = new System.Drawing.Point(137, 66);
            this.lbNhap.Name = "lbNhap";
            this.lbNhap.Size = new System.Drawing.Size(104, 13);
            this.lbNhap.TabIndex = 0;
            this.lbNhap.Text = "Nhập tên ngoại ngữ:";
            // 
            // txtNN
            // 
            this.txtNN.Location = new System.Drawing.Point(266, 59);
            this.txtNN.Name = "txtNN";
            this.txtNN.Size = new System.Drawing.Size(186, 20);
            this.txtNN.TabIndex = 1;
            // 
            // lbList
            // 
            this.lbList.AutoSize = true;
            this.lbList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbList.Location = new System.Drawing.Point(137, 113);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(130, 13);
            this.lbList.TabIndex = 2;
            this.lbList.Text = "Danh sách các ngoại ngữ";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(140, 329);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(343, 329);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(443, 329);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(550, 329);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lsbNN
            // 
            this.lsbNN.FormattingEnabled = true;
            this.lsbNN.Location = new System.Drawing.Point(140, 145);
            this.lsbNN.Name = "lsbNN";
            this.lsbNN.Size = new System.Drawing.Size(485, 147);
            this.lsbNN.TabIndex = 7;
            this.lsbNN.SelectedIndexChanged += new System.EventHandler(this.lsbNN_SelectedIndexChanged);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(243, 329);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.lsbNN);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lbList);
            this.Controls.Add(this.txtNN);
            this.Controls.Add(this.lbNhap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNhap;
        private System.Windows.Forms.TextBox txtNN;
        private System.Windows.Forms.Label lbList;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ListBox lsbNN;
        private System.Windows.Forms.Button btnSua;
    }
}

