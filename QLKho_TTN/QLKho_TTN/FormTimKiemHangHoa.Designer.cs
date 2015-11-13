namespace QLKho_TTN
{
    partial class FormTimKiemHangHoa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvHH = new System.Windows.Forms.DataGridView();
            this.rbMaHH = new System.Windows.Forms.RadioButton();
            this.rbTenHH = new System.Windows.Forms.RadioButton();
            this.txtSeach = new System.Windows.Forms.TextBox();
            this.btnSeach = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSeach);
            this.groupBox1.Controls.Add(this.txtSeach);
            this.groupBox1.Controls.Add(this.rbTenHH);
            this.groupBox1.Controls.Add(this.rbMaHH);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dgvHH
            // 
            this.dgvHH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHH.Location = new System.Drawing.Point(26, 141);
            this.dgvHH.Name = "dgvHH";
            this.dgvHH.Size = new System.Drawing.Size(838, 222);
            this.dgvHH.TabIndex = 1;
            // 
            // rbMaHH
            // 
            this.rbMaHH.AutoSize = true;
            this.rbMaHH.Location = new System.Drawing.Point(427, 19);
            this.rbMaHH.Name = "rbMaHH";
            this.rbMaHH.Size = new System.Drawing.Size(88, 17);
            this.rbMaHH.TabIndex = 0;
            this.rbMaHH.TabStop = true;
            this.rbMaHH.Text = "Mã hàng hóa";
            this.rbMaHH.UseVisualStyleBackColor = true;
            // 
            // rbTenHH
            // 
            this.rbTenHH.AutoSize = true;
            this.rbTenHH.Location = new System.Drawing.Point(427, 53);
            this.rbTenHH.Name = "rbTenHH";
            this.rbTenHH.Size = new System.Drawing.Size(92, 17);
            this.rbTenHH.TabIndex = 1;
            this.rbTenHH.TabStop = true;
            this.rbTenHH.Text = "Tên hàng hóa";
            this.rbTenHH.UseVisualStyleBackColor = true;
            // 
            // txtSeach
            // 
            this.txtSeach.Location = new System.Drawing.Point(6, 19);
            this.txtSeach.Name = "txtSeach";
            this.txtSeach.Size = new System.Drawing.Size(357, 20);
            this.txtSeach.TabIndex = 4;
            // 
            // btnSeach
            // 
            this.btnSeach.Location = new System.Drawing.Point(279, 47);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(75, 23);
            this.btnSeach.TabIndex = 5;
            this.btnSeach.Text = "Tìm kiếm";
            this.btnSeach.UseVisualStyleBackColor = true;
            this.btnSeach.Click += new System.EventHandler(this.btnSeach_Click);
            // 
            // FormTimKiemHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 341);
            this.Controls.Add(this.dgvHH);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTimKiemHangHoa";
            this.Text = "FormTimKiemHangHoa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSeach;
        private System.Windows.Forms.TextBox txtSeach;
        private System.Windows.Forms.RadioButton rbTenHH;
        private System.Windows.Forms.RadioButton rbMaHH;
        private System.Windows.Forms.DataGridView dgvHH;
    }
}