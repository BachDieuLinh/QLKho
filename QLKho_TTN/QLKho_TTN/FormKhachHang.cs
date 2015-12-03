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
    public partial class FormKhachHang : Form
    {
        objKhachHang khachhang = new objKhachHang();
        int chon;
        public FormKhachHang()
        {
            InitializeComponent();
            HienThiDGVKhachHang();
            SetNull();
        }

        public void HienThiDGVKhachHang()
        {
            dgvKhachHang.DataSource = khachhang.HienThiKhachHang();

        }

        public void SetNull()
        {
            txtDiaChi.Enabled = txtTenKH.Enabled = txtMaKH.Enabled = txtGhiChu.Enabled = txtSDT.Enabled = false;
        }
        public void SetNotNull()
        {
            txtDiaChi.Enabled = txtTenKH.Enabled = txtMaKH.Enabled = txtGhiChu.Enabled = txtSDT.Enabled = true;
        }

        public void clear()
        {
            txtDiaChi.Text = txtGhiChu.Text = txtMaKH.Text = txtSDT.Text = txtTenKH.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            SetNotNull();
            chon = 0;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SetNotNull();
            chon = 1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                khachhang.XoaKhachHang(txtMaKH.Text);
                MessageBox.Show("Xóa thành công");
                HienThiDGVKhachHang();
                clear();
                SetNull();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lõi");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (chon == 0)
            {
                try
                {
                    khachhang.ThemKhachHang(txtMaKH.Text, txtTenKH.Text, txtDiaChi.Text, txtSDT.Text, txtGhiChu.Text);
                    MessageBox.Show("Thêm thành công");
                    clear();
                    SetNull();
                    HienThiDGVKhachHang();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi");
                }
            }
            if (chon == 1)
            {
                try
                {
                    khachhang.SuaKhachHang(txtMaKH.Text, txtTenKH.Text, txtDiaChi.Text, txtSDT.Text, txtGhiChu.Text);
                    MessageBox.Show("Sửa thành công");
                    clear();
                    SetNull();
                    HienThiDGVKhachHang();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKH.Text = dgvKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenKH.Text= dgvKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSDT.Text = dgvKhachHang.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtGhiChu.Text = dgvKhachHang.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

    }
}
