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
    public partial class frmtkncc : Form
    {
        public frmtkncc()
        {
            InitializeComponent();
        }
        ConnectCSDL co = new ConnectCSDL();

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            co.KetNoi();
            dgvtkncc.DataSource = co.GetData("select * from tblNhaCC where MaNCC = '" + txtmancc.Text.Trim() + "'");
            co.KetNoi();
            dgvtkncc.DataSource = co.GetData("select * from tblNhaCC where TenNCC = '" + txttenncc.Text.Trim() + "'");
            co.KetNoi();
            dgvtkncc.DataSource = co.GetData("select * from tblNhaCC where Diachi = '" + txtdiachi.Text.Trim() + "'");
        }

        private void txtmancc_TextChanged(object sender, EventArgs e)
        {
            co.KetNoi();
            dgvtkncc.DataSource = co.GetData("select * from tblNhaCC where MaNCC = '" + txtmancc.Text.Trim() + "'");
        }

        private void txttenncc_TextChanged(object sender, EventArgs e)
        {
            co.KetNoi();
            dgvtkncc.DataSource = co.GetData("select * from tblNhaCC where TenNCC like '" + txttenncc.Text.Trim() + "%'");
        }

        private void txttenncc_MouseClick(object sender, MouseEventArgs e)
        {
            txttenncc.Clear();
        }

        private void txtmancc_MouseClick(object sender, MouseEventArgs e)
        {
            txtmancc.Clear();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {

            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn thoát không?", "Trả lời",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            frmMenu tc = new frmMenu();
            tc.Show();
            this.Hide();
        }
    }
}
