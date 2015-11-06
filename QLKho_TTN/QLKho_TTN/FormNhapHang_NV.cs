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
    public partial class FormNhapHang_NV : Form
    {
        objNhanVien nv = new objNhanVien();
        string _maNV;
        public FormNhapHang_NV()
        {
            InitializeComponent();
            
        }

        public void LayMa(ref string MaNV)
        {
            dataGridViewNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNV_CellClick);
            MaNV = _maNV;
        }
        public void HienThiDGVNV()
        {
            dataGridViewNV.DataSource = nv.HienThiNhanVien();
            int i = 0;
            while (i < dataGridViewNV.Rows.Count - 1)
            {
                dataGridViewNV.Rows[i].Cells[0].Value = (i + 1).ToString();
                i++;
            }

        }

        private void FormNhapHang_NV_Load(object sender, EventArgs e)
        {
            HienThiDGVNV();
        }

        private void dataGridViewNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _maNV = dataGridViewNV.Rows[e.RowIndex].Cells[1].Value.ToString();
                
            }
            catch { }
        }

       

    }
}
