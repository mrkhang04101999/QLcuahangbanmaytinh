using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLcuahangbanmaytinh
{
    public partial class frmnhacungcap : Form
    {
        public frmnhacungcap()
        {
            InitializeComponent();
        }
        ConnectCSDL co = new ConnectCSDL();
        public void LoadData()
        {
            co.KetNoi();
            dgvncc.DataSource = co.GetData("select * from tblNhaCC");
            co.NgatKetNoi();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {

            this.txtmancc.Clear();
            this.txttenncc.Clear();
            this.txtdiachi.Clear();
            this.txtsdt.Clear();
        }

        private void frmnhacungcap_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string sqlthem = "insert into tblNhaCC values ('" + txtmancc.Text + "','" + txttenncc.Text
              + "','" + txtdiachi.Text + "','" + txtsdt.Text + "')";
            co.ThucThi(sqlthem);
            frmnhacungcap_Load(sender, e);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {

            string sqlsua = "update tblNhaCC set MaNCC='" + txtmancc.Text + "',TenNCC='" + txttenncc.Text
               + "',Diachi='" + txtdiachi.Text + "',sdt='" + txtsdt.Text + "'where MaNCC='" + txtmancc.Text + "'";
            co.ThucThi(sqlsua);
            LoadData();
            frmnhacungcap_Load(sender, e);
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            frmMenu tc = new frmMenu();
            tc.Show();
            this.Hide();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn xóa không?", "Trả lời",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                string sqlxoa = "delete from tblNhaCC where MaNCC = '" + txtmancc.Text + "'";
                co.ThucThi(sqlxoa);
            }
            frmnhacungcap_Load(sender, e);

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn thoát không?", "Trả lời",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void dgvncc_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int i = e.RowIndex;
            txtmancc.Text = dgvncc.Rows[i].Cells[0].Value.ToString().Trim();
            txttenncc.Text = dgvncc.Rows[i].Cells[1].Value.ToString().Trim();
            txtdiachi.Text = dgvncc.Rows[i].Cells[2].Value.ToString().Trim();
            txtsdt.Text = dgvncc.Rows[i].Cells[3].Value.ToString().Trim();
        }
    }
}
