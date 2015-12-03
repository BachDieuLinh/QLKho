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
    public partial class FormHangHoa : Form
    {
        objHangHoa hanghoa = new objHangHoa();
        public FormHangHoa()
        {
            InitializeComponent();
            HienThiDGVHangHoa();
            SetNull();
        }
        public int chon;
       
        public void HienThiDGVHangHoa()
        {
            dgvHangHoa.DataSource = hanghoa.HienThiHangHoa();
        }

        public void SetNull()
        {
            txtGiaNhap.Enabled = txtGiaBan.Enabled = txtDVT.Enabled = txtMaHH.Enabled = txtSoLuong.Enabled = txtTenHH.Enabled = false;
        }


        public void SetNotNull()
        {
            txtGiaNhap.Enabled = txtGiaBan.Enabled = txtDVT.Enabled = txtMaHH.Enabled = txtSoLuong.Enabled = txtTenHH.Enabled = true;
        }
        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHH.Text = dgvHangHoa.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenHH.Text = dgvHangHoa.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDVT.Text = dgvHangHoa.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSoLuong.Text = dgvHangHoa.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtGiaNhap.Text = dgvHangHoa.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtGiaBan.Text = dgvHangHoa.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SetNotNull();
            chon = 0;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (chon == 0)
            {
                try
                {
                    hanghoa.ThemHangHoa(txtMaHH.Text, txtTenHH.Text, txtDVT.Text, Convert.ToInt32(txtSoLuong.Text), Convert.ToInt32(txtGiaNhap.Text), Convert.ToInt32(txtGiaBan.Text));
                    MessageBox.Show("Thêm thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("lỗi");
                }
                
            }
            if (chon == 1)
            {
                try
                {

                    hanghoa.SuaHangHoa(txtMaHH.Text, txtTenHH.Text, txtDVT.Text, Convert.ToInt32(txtSoLuong.Text), Convert.ToInt32(txtGiaNhap.Text), Convert.ToInt32(txtGiaBan.Text));
                    MessageBox.Show("Sửa thành công");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("lỗi");
                }
            }
            HienThiDGVHangHoa();
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
                hanghoa.XoaHangHoa(txtMaHH.Text);
                MessageBox.Show("Xóa thành công");
            }
            catch (Exception ẽ)
            {
                MessageBox.Show("lỗi");
            }
            HienThiDGVHangHoa();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvHangHoa.DataSource = hanghoa.SXHangHoa_SL();
        }

        private void txtSeachHH_TextChanged(object sender, EventArgs e)
        {
            if (rbMaHH.Checked == true) dgvHangHoa.DataSource = hanghoa.TimKiemMaHH(txtSeachHH.Text);
            if (rbTenHH.Checked == true) dgvHangHoa.DataSource = hanghoa.TimKiemTenHH(txtSeachHH.Text);
        }

    }
}
