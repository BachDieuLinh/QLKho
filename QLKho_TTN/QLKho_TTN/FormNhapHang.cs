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
    public partial class FormNhapHang : Form
    {
        objNhanVien nv = new objNhanVien();
        objNhaCungCap ncc = new objNhaCungCap();
        objHangHoa hh = new objHangHoa();
        objChiTietNhap ctn = new objChiTietNhap();
        objPhieuNhap pn = new objPhieuNhap();
        public FormNhapHang()
        {
            InitializeComponent();
            gbCTHoaDonNhap.Enabled = false;
            HienThiDGVPN();
        }

        private void rbTenHH_CheckedChanged(object sender, EventArgs e)
        {

        }
        // phiếu nhập hàng
        public void HienThiDGVPN()
        {
            dgvPN.DataSource = pn.HienThiPhieuNhap();
            int i = 0;
            while (i < dgvPN.Rows.Count - 1)
            {
                dgvPN.Rows[i].Cells[0].Value = (i + 1).ToString();
                i++;
            }

        }


        //nhân viên
        public void HienThiDGVNV()
        {
            dgvNV.DataSource = nv.HienThiNhanVien();
            int i = 0;
            while (i < dgvNV.Rows.Count - 1)
            {
                dgvNV.Rows[i].Cells[0].Value = (i + 1).ToString();
                i++;
            }

        }

      
        private void btnNV_Click(object sender, EventArgs e)
        {
            HienThiDGVNV();
        }

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           txtMaNV.Text= dgvNV.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

      


        // kết thúc các hàm hiên quan đến nhân viên
        

        //Các hàm liên qua đến nhà cung cấp
        public void HienThiDGVNCC()
        {
            dgvNCC.DataSource = ncc.HienThiNhaCungCap();
            int i = 0;
            while (i < dgvNV.Rows.Count - 1)
            {
                dgvNCC.Rows[i].Cells[0].Value = (i + 1).ToString();
                i++;
            }

        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            HienThiDGVNCC();
        }

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNCC.Text = dgvNCC.Rows[e.RowIndex].Cells[0].Value.ToString();
        }


        //các hàm liên quan đến hàng hóa
        public void HienThiDGVHH()
        {
            dgvHH.DataSource = hh.HienThiHangHoa();
            int i = 0;
            while (i < dgvHH.Rows.Count - 1)
            {
                dgvHH.Rows[i].Cells[0].Value = (i + 1).ToString();
                i++;
            }

        }

        private void btnHH_Click(object sender, EventArgs e)
        {
            HienThiDGVHH();
        }

        private void dgvHH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           txtMaHH.Text  = dgvHH.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnGhiHoaDon_Click(object sender, EventArgs e)
        {
            pn.GhiPhieuNhap(txtMPN.Text, txtMaNV.Text, txtMaNCC.Text, DateTime.Now.ToString(), "");
            HienThiDGVPN();
            gbCTHoaDonNhap.Enabled = true;
            HienThiCTN();
        }
        // kết thúc các hàm có liên quan đến hoàng hóa

        // các hàm có liên quan đến chi tiết hóa đơn nhập
        public void HienThiCTN()
        {
            dgvCTN.DataSource = ctn.HienThiChiTietNhap();
            int i = 0;
            while (i < dgvCTN.Rows.Count - 1)
            {
                dgvCTN.Rows[i].Cells[0].Value = (i + 1).ToString();
                i++;
            }

        }

        private void btnGhiCTN_Click(object sender, EventArgs e)
        {
            ctn.GhiChiTietNhap(txtMaPhieuNhap.Text, txtMaHH.Text, txtSoLuong.Text, txtDonGiaNhap.Text, "");
            HienThiCTN();
        }

        private void btnXemCTN_Click(object sender, EventArgs e)
        {
            HienThiCTN();
        }

    }
}
