namespace QLKho_TTN
{
    partial class FormThongKeHangHoa
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
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.dgvHangHoa = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSoLuong = new System.Windows.Forms.RadioButton();
            this.rbGiaNhap = new System.Windows.Forms.RadioButton();
            this.rbGiaBan = new System.Windows.Forms.RadioButton();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbMaHH = new System.Windows.Forms.RadioButton();
            this.rbTenHH = new System.Windows.Forms.RadioButton();
            this.txtSeachHH = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "GiaNhap";
            this.Column6.HeaderText = "giá nhập";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "GiaBan";
            this.Column7.HeaderText = "Giá bán";
            this.Column7.Name = "Column7";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DVT";
            this.Column4.HeaderText = "Đơn vị tính";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenHH";
            this.Column3.HeaderText = "Tên hàng hóa";
            this.Column3.Name = "Column3";
            this.Column3.Width = 120;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaHH";
            this.Column2.HeaderText = "Mã hàng hóa";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvHangHoa.Location = new System.Drawing.Point(21, 148);
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.Size = new System.Drawing.Size(723, 150);
            this.dgvHangHoa.TabIndex = 16;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SoLuong";
            this.Column5.HeaderText = "Số lượng";
            this.Column5.Name = "Column5";
            this.Column5.Width = 120;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnSapXep);
            this.groupBox1.Controls.Add(this.rbGiaBan);
            this.groupBox1.Controls.Add(this.rbGiaNhap);
            this.groupBox1.Controls.Add(this.rbSoLuong);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 114);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // rbSoLuong
            // 
            this.rbSoLuong.AutoSize = true;
            this.rbSoLuong.Location = new System.Drawing.Point(144, 28);
            this.rbSoLuong.Name = "rbSoLuong";
            this.rbSoLuong.Size = new System.Drawing.Size(67, 17);
            this.rbSoLuong.TabIndex = 0;
            this.rbSoLuong.TabStop = true;
            this.rbSoLuong.Text = "Số lượng";
            this.rbSoLuong.UseVisualStyleBackColor = true;
            // 
            // rbGiaNhap
            // 
            this.rbGiaNhap.AutoSize = true;
            this.rbGiaNhap.Location = new System.Drawing.Point(143, 55);
            this.rbGiaNhap.Name = "rbGiaNhap";
            this.rbGiaNhap.Size = new System.Drawing.Size(68, 17);
            this.rbGiaNhap.TabIndex = 1;
            this.rbGiaNhap.TabStop = true;
            this.rbGiaNhap.Text = "Giá nhập";
            this.rbGiaNhap.UseVisualStyleBackColor = true;
            // 
            // rbGiaBan
            // 
            this.rbGiaBan.AutoSize = true;
            this.rbGiaBan.Location = new System.Drawing.Point(144, 82);
            this.rbGiaBan.Name = "rbGiaBan";
            this.rbGiaBan.Size = new System.Drawing.Size(62, 17);
            this.rbGiaBan.TabIndex = 2;
            this.rbGiaBan.TabStop = true;
            this.rbGiaBan.Text = "Giá bán";
            this.rbGiaBan.UseVisualStyleBackColor = true;
            // 
            // btnSapXep
            // 
            this.btnSapXep.Location = new System.Drawing.Point(6, 49);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(75, 23);
            this.btnSapXep.TabIndex = 3;
            this.btnSapXep.Text = "sắp xếp";
            this.btnSapXep.UseVisualStyleBackColor = true;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.rbMaHH);
            this.groupBox2.Controls.Add(this.rbTenHH);
            this.groupBox2.Controls.Add(this.txtSeachHH);
            this.groupBox2.Location = new System.Drawing.Point(282, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 114);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // rbMaHH
            // 
            this.rbMaHH.AutoSize = true;
            this.rbMaHH.Location = new System.Drawing.Point(249, 31);
            this.rbMaHH.Name = "rbMaHH";
            this.rbMaHH.Size = new System.Drawing.Size(88, 17);
            this.rbMaHH.TabIndex = 21;
            this.rbMaHH.TabStop = true;
            this.rbMaHH.Text = "Mã hàng hóa";
            this.rbMaHH.UseVisualStyleBackColor = true;
            // 
            // rbTenHH
            // 
            this.rbTenHH.AutoSize = true;
            this.rbTenHH.Location = new System.Drawing.Point(249, 55);
            this.rbTenHH.Name = "rbTenHH";
            this.rbTenHH.Size = new System.Drawing.Size(92, 17);
            this.rbTenHH.TabIndex = 22;
            this.rbTenHH.TabStop = true;
            this.rbTenHH.Text = "Tên hàng hóa";
            this.rbTenHH.UseVisualStyleBackColor = true;
            // 
            // txtSeachHH
            // 
            this.txtSeachHH.Location = new System.Drawing.Point(11, 40);
            this.txtSeachHH.Name = "txtSeachHH";
            this.txtSeachHH.Size = new System.Drawing.Size(175, 20);
            this.txtSeachHH.TabIndex = 20;
            this.txtSeachHH.TextChanged += new System.EventHandler(this.txtSeachHH_TextChanged);
            // 
            // FormThongKeHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(761, 299);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvHangHoa);
            this.Name = "FormThongKeHangHoa";
            this.Text = "Thống kê hàng hóa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.DataGridView dgvHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.RadioButton rbGiaBan;
        private System.Windows.Forms.RadioButton rbGiaNhap;
        private System.Windows.Forms.RadioButton rbSoLuong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbMaHH;
        private System.Windows.Forms.RadioButton rbTenHH;
        private System.Windows.Forms.TextBox txtSeachHH;
    }
}