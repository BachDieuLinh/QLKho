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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNhapHang frmNhapHang = new FormNhapHang();
            frmNhapHang.Show();
        }

        private void tìmKiếmHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTimKiemHangHoa frmTKHH = new FormTimKiemHangHoa();
            frmTKHH.Show();

        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHangHoa frmHangHoa = new FormHangHoa();
            frmHangHoa.Show();
        }

        private void thốngKêHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongKeHangHoa frmThongKeHangHoa = new FormThongKeHangHoa();
            frmThongKeHangHoa.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHuongDan frm = new frmHuongDan();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }
    }
}
