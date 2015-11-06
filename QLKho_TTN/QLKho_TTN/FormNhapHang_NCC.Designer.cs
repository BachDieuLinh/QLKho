namespace QLKho_TTN
{
    partial class FormNhapHang_NCC
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
            this.groupBoxNCC = new System.Windows.Forms.GroupBox();
            this.TenNCC = new System.Windows.Forms.RadioButton();
            this.MaNCC = new System.Windows.Forms.RadioButton();
            this.txtNCC = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxNCC
            // 
            this.groupBoxNCC.Controls.Add(this.TenNCC);
            this.groupBoxNCC.Controls.Add(this.MaNCC);
            this.groupBoxNCC.Controls.Add(this.txtNCC);
            this.groupBoxNCC.Controls.Add(this.dataGridView2);
            this.groupBoxNCC.Location = new System.Drawing.Point(12, 22);
            this.groupBoxNCC.Name = "groupBoxNCC";
            this.groupBoxNCC.Size = new System.Drawing.Size(697, 228);
            this.groupBoxNCC.TabIndex = 23;
            this.groupBoxNCC.TabStop = false;
            this.groupBoxNCC.Text = "Nhà cung cấp";
            // 
            // TenNCC
            // 
            this.TenNCC.AutoSize = true;
            this.TenNCC.Location = new System.Drawing.Point(279, 15);
            this.TenNCC.Name = "TenNCC";
            this.TenNCC.Size = new System.Drawing.Size(94, 17);
            this.TenNCC.TabIndex = 7;
            this.TenNCC.TabStop = true;
            this.TenNCC.Text = "Tên nhân viên";
            this.TenNCC.UseVisualStyleBackColor = true;
            // 
            // MaNCC
            // 
            this.MaNCC.AutoSize = true;
            this.MaNCC.Location = new System.Drawing.Point(183, 16);
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.Size = new System.Drawing.Size(90, 17);
            this.MaNCC.TabIndex = 6;
            this.MaNCC.TabStop = true;
            this.MaNCC.Text = "Mã nhân viên";
            this.MaNCC.UseVisualStyleBackColor = true;
            // 
            // txtNCC
            // 
            this.txtNCC.Location = new System.Drawing.Point(0, 15);
            this.txtNCC.Name = "txtNCC";
            this.txtNCC.Size = new System.Drawing.Size(177, 20);
            this.txtNCC.TabIndex = 5;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView2.Location = new System.Drawing.Point(6, 52);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(684, 170);
            this.dataGridView2.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã NCC";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên NCC";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Địa chỉ";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "SĐT";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Ghi chú";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // FormNhapHang_NCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 254);
            this.Controls.Add(this.groupBoxNCC);
            this.Name = "FormNhapHang_NCC";
            this.Text = "Nhà cung cấp";
            this.groupBoxNCC.ResumeLayout(false);
            this.groupBoxNCC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxNCC;
        private System.Windows.Forms.RadioButton TenNCC;
        private System.Windows.Forms.RadioButton MaNCC;
        private System.Windows.Forms.TextBox txtNCC;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}