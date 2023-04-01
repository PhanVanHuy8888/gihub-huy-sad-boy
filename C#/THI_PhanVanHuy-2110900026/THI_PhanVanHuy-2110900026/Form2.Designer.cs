namespace THI_PhanVanHuy_2110900026
{
    partial class Form2
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIdRoom = new System.Windows.Forms.Label();
            this.tbMaNV = new System.Windows.Forms.TextBox();
            this.tbTenNV = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.cbIdRoom = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin sinh viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã NV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên NV:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ:";
            // 
            // tbIdRoom
            // 
            this.tbIdRoom.AutoSize = true;
            this.tbIdRoom.Location = new System.Drawing.Point(540, 91);
            this.tbIdRoom.Name = "tbIdRoom";
            this.tbIdRoom.Size = new System.Drawing.Size(58, 13);
            this.tbIdRoom.TabIndex = 5;
            this.tbIdRoom.Text = "Mã phòng:";
            // 
            // tbMaNV
            // 
            this.tbMaNV.Location = new System.Drawing.Point(109, 88);
            this.tbMaNV.Name = "tbMaNV";
            this.tbMaNV.Size = new System.Drawing.Size(100, 20);
            this.tbMaNV.TabIndex = 6;
            // 
            // tbTenNV
            // 
            this.tbTenNV.Location = new System.Drawing.Point(109, 156);
            this.tbTenNV.Name = "tbTenNV";
            this.tbTenNV.Size = new System.Drawing.Size(100, 20);
            this.tbTenNV.TabIndex = 7;
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(345, 88);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(100, 20);
            this.tbDate.TabIndex = 8;
            // 
            // tbAdress
            // 
            this.tbAdress.Location = new System.Drawing.Point(345, 156);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(100, 20);
            this.tbAdress.TabIndex = 9;
            // 
            // cbIdRoom
            // 
            this.cbIdRoom.FormattingEnabled = true;
            this.cbIdRoom.Location = new System.Drawing.Point(626, 88);
            this.cbIdRoom.Name = "cbIdRoom";
            this.cbIdRoom.Size = new System.Drawing.Size(121, 21);
            this.cbIdRoom.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Chức năng:";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(47, 209);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(700, 150);
            this.dgv.TabIndex = 12;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(69, 424);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(252, 424);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 14;
            this.btUpdate.Text = "Cập nhật";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(447, 424);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(648, 424);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbIdRoom);
            this.Controls.Add(this.tbAdress);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.tbTenNV);
            this.Controls.Add(this.tbMaNV);
            this.Controls.Add(this.tbIdRoom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "frmDMNhanVien";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tbIdRoom;
        private System.Windows.Forms.TextBox tbMaNV;
        private System.Windows.Forms.TextBox tbTenNV;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.ComboBox cbIdRoom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}