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
    public partial class FormThongKeHangHoa : Form
    {
        public FormThongKeHangHoa()
        {
            InitializeComponent();
        }

        objHangHoa hanghoa = new objHangHoa();

        
        private void txtSeachHH_TextChanged(object sender, EventArgs e)
        {
            if (rbMaHH.Checked == true) dgvHangHoa.DataSource = hanghoa.TimKiemMaHH(txtSeachHH.Text);
            if (rbTenHH.Checked == true) dgvHangHoa.DataSource = hanghoa.TimKiemTenHH(txtSeachHH.Text);
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            if (rbGiaBan.Checked == true) dgvHangHoa.DataSource = hanghoa.SXHangHoa_GB();
            if (rbGiaNhap.Checked == true) dgvHangHoa.DataSource = hanghoa.SXHangHoa_GN();
            if (rbSoLuong.Checked == true) dgvHangHoa.DataSource = hanghoa.SXHangHoa_SL();
        }
    }
}
