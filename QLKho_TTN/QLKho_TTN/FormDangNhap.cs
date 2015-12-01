using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKho_TTN
{
    public partial class FormDangNhap : Form
    {
        objDangNhap DN = new objDangNhap();
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
          

            FormMenu frmMenu = new FormMenu();
            Form frm = new Form();
            DataTable dt = new DataTable();
            dt = DN.DangNhap(txtTenDN.Text, txtMK.Text);
            if (dt.Rows != null) frmMenu.Show();

        }


    
    }
}
