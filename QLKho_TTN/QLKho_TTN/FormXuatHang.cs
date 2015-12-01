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
    public partial class FormXuatHang : Form
    {
        objNhanVien nv = new objNhanVien();
        objKhachHang kh = new objKhachHang();
        objHangHoa hh = new objHangHoa();
        objChiTietXuat ctx = new objChiTietXuat();
        objPhieuXuat px = new objPhieuXuat();

        public FormXuatHang()
        {
            InitializeComponent();
            HienThiDGVPX();
        }

        //phiếu xuất hàng
        public void HienThiDGVPX()
        {
            dgvPX.DataSource = px.HienThiPhieuXuat();
            int i = 0;
            while (i < dgvPX.Rows.Count - 1)
            {
                dgvPX.Rows[i].Cells[0].Value = (i + 1).ToString();
                i++;
            }

        }
        // thao tác liên quan đến nhân viên
        public void HienThiDGVNV()
        {
            dgvNV.DataSource = nv.HienThiNhanVien();
         }

        private void btnNV_Click(object sender, EventArgs e)
        {
            HienThiDGVNV();
        }

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dgvNV.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        
        //thao tác liên quan đến khách hàng

        public void HienThiDGVKH()
        {
            dgvKH.DataSource = kh.HienThiKhachHang();
          
        }
        private void btnKH_Click(object sender, EventArgs e)
        {
            HienThiDGVKH();
        }
        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKH.Text = dgvKH.Rows[e.RowIndex].Cells[0].Value.ToString();
        }


        //thao tác liên quan đến chi tiết xuất hàng

        private void btnGhiHoaDon_Click(object sender, EventArgs e)
        {
            px.GhiPhieuXuat(txtMPX.Text,txtMaNV.Text,txtMaKH.Text,DateTime.Now.ToString(),"");
            HienThiDGVPX();
            HienThiDGVCTX();
        }
        public void HienThiDGVCTX()
        {
            dgvCTX.DataSource = ctx.HienThiChiTietXuat();
        }

        private void btnGhiCTX_Click(object sender, EventArgs e)
        {
            ctx.GhiChiTietXuat(txtMaPhieuXuat.Text, txtMaHH.Text, txtSoLuong.Text, txtDonGiaXuat.Text, "");
            HienThiDGVCTX();
        }
        // Liên quan đến hàng hóa
        private void dgvHH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHH.Text = dgvHH.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDonGiaXuat.Text = dgvHH.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnHH_Click(object sender, EventArgs e)
        {
            dgvHH.DataSource = hh.HienThiHangHoa();
        }

        

       

    }
}
