namespace QLKho_TTN
{
    partial class FormNhapHang_NV
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
            this.groupBoxNV = new System.Windows.Forms.GroupBox();
            this.btnTimNV = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rbMaNV = new System.Windows.Forms.RadioButton();
            this.txtTimKiemNhanVien = new System.Windows.Forms.TextBox();
            this.dataGridViewNV = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxNV
            // 
            this.groupBoxNV.Controls.Add(this.btnTimNV);
            this.groupBoxNV.Controls.Add(this.label2);
            this.groupBoxNV.Controls.Add(this.label1);
            this.groupBoxNV.Controls.Add(this.radioButton2);
            this.groupBoxNV.Controls.Add(this.rbMaNV);
            this.groupBoxNV.Controls.Add(this.txtTimKiemNhanVien);
            this.groupBoxNV.Controls.Add(this.dataGridViewNV);
            this.groupBoxNV.Location = new System.Drawing.Point(12, 12);
            this.groupBoxNV.Name = "groupBoxNV";
            this.groupBoxNV.Size = new System.Drawing.Size(682, 238);
            this.groupBoxNV.TabIndex = 6;
            this.groupBoxNV.TabStop = false;
            this.groupBoxNV.Text = "Nhân viên";
            // 
            // btnTimNV
            // 
            this.btnTimNV.Location = new System.Drawing.Point(616, 18);
            this.btnTimNV.Name = "btnTimNV";
            this.btnTimNV.Size = new System.Drawing.Size(43, 23);
            this.btnTimNV.TabIndex = 6;
            this.btnTimNV.Text = "Tìm";
            this.btnTimNV.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = ": ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã nhân viên";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(516, 17);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(94, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tên nhân viên";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rbMaNV
            // 
            this.rbMaNV.AutoSize = true;
            this.rbMaNV.Location = new System.Drawing.Point(420, 18);
            this.rbMaNV.Name = "rbMaNV";
            this.rbMaNV.Size = new System.Drawing.Size(90, 17);
            this.rbMaNV.TabIndex = 2;
            this.rbMaNV.TabStop = true;
            this.rbMaNV.Text = "Mã nhân viên";
            this.rbMaNV.UseVisualStyleBackColor = true;
            // 
            // txtTimKiemNhanVien
            // 
            this.txtTimKiemNhanVien.Location = new System.Drawing.Point(273, 17);
            this.txtTimKiemNhanVien.Name = "txtTimKiemNhanVien";
            this.txtTimKiemNhanVien.Size = new System.Drawing.Size(141, 20);
            this.txtTimKiemNhanVien.TabIndex = 1;
            // 
            // dataGridViewNV
            // 
            this.dataGridViewNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dataGridViewNV.Location = new System.Drawing.Point(12, 68);
            this.dataGridViewNV.Name = "dataGridViewNV";
            this.dataGridViewNV.Size = new System.Drawing.Size(664, 164);
            this.dataGridViewNV.TabIndex = 0;
            this.dataGridViewNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNV_CellClick);
            // 
            // Column7
            // 
            this.Column7.HeaderText = "STT";
            this.Column7.Name = "Column7";
            this.Column7.Width = 30;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "MaNV";
            this.Column8.HeaderText = "Mã nhân viên";
            this.Column8.Name = "Column8";
            this.Column8.Width = 50;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "TenNV";
            this.Column9.HeaderText = "Tên nhân viên";
            this.Column9.Name = "Column9";
            this.Column9.Width = 150;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "DiaChi";
            this.Column10.HeaderText = "Địa chỉ";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "SDT";
            this.Column11.HeaderText = "SĐT";
            this.Column11.Name = "Column11";
            this.Column11.Width = 120;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "ChucVu";
            this.Column12.HeaderText = "Chức vụ";
            this.Column12.Name = "Column12";
            // 
            // FormNhapHang_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 262);
            this.Controls.Add(this.groupBoxNV);
            this.Name = "FormNhapHang_NV";
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.FormNhapHang_NV_Load);
            this.groupBoxNV.ResumeLayout(false);
            this.groupBoxNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxNV;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rbMaNV;
        private System.Windows.Forms.TextBox txtTimKiemNhanVien;
        private System.Windows.Forms.DataGridView dataGridViewNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.Button btnTimNV;
    }
}