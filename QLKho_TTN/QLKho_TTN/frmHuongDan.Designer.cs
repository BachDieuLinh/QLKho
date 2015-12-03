namespace QLKho_TTN
{
    partial class frmHuongDan
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Nhóm Thực Hiện");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Giới Thiệu Sản Phẩm");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("GIỚI THIỆU CHUNG", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Form Đăng Nhập");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Form Chính");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Form Tìm kiếm hàng hóa");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Form Thống kê hàng hóa");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Form Hàng Hóa", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Form Nhập Hàng");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Form Xuất Hàng");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Form Khách Hàng");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("HƯỚNG DẪN SỬ DỤNG", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "root_GT_GTN";
            treeNode1.Text = "Nhóm Thực Hiện";
            treeNode2.Name = "root_GT_GTSP";
            treeNode2.Text = "Giới Thiệu Sản Phẩm";
            treeNode3.Name = "root_GT";
            treeNode3.Text = "GIỚI THIỆU CHUNG";
            treeNode4.Name = "root_HD_Chinh";
            treeNode4.Text = "Form Đăng Nhập";
            treeNode5.Name = "root_HD_DA";
            treeNode5.Text = "Form Chính";
            treeNode6.Name = "root_HD_TK";
            treeNode6.Text = "Form Tìm kiếm hàng hóa";
            treeNode7.Name = "root_HD_TKHH";
            treeNode7.Text = "Form Thống kê hàng hóa";
            treeNode8.Name = "root_HD_HH";
            treeNode8.Text = "Form Hàng Hóa";
            treeNode9.Name = "root_HD_NH";
            treeNode9.Text = "Form Nhập Hàng";
            treeNode10.Name = "root_HD_XH";
            treeNode10.Text = "Form Xuất Hàng";
            treeNode11.Name = "root_HD_KH";
            treeNode11.Text = "Form Khách Hàng";
            treeNode12.Name = "root_HD";
            treeNode12.Text = "HƯỚNG DẪN SỬ DỤNG";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(228, 367);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowWebBrowserDrop = false;
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(267, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(23, 23);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(642, 367);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            // 
            // frmHuongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 420);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.treeView1);
            this.Name = "frmHuongDan";
            this.Text = "frmHuongDan";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}