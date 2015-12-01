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
    public partial class FormTimKiemHangHoa : Form
    {
        objHangHoa hh = new objHangHoa();
        public FormTimKiemHangHoa()
        {
            InitializeComponent();
            HienThiDQVHH();
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            if (txtSeach.Text == "")
            {
                MessageBox.Show("Điền nội dung tìm kiếm");
            }
            else
            {
                if (rbMaHH.Checked == true) dgvHH.DataSource = hh.TimKiemMaHH(txtSeach.Text);
                if (rbTenHH.Checked == true) dgvHH.DataSource = hh.TimKiemTenHH(txtSeach.Text);
            }

        }
        private void HienThiDQVHH()
        {
            dgvHH.DataSource = hh.HienThiHangHoa();
        }



        }
    
}
