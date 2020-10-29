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
    public partial class frmtknhanvien : Form
    {
        public frmtknhanvien()
        {
            InitializeComponent();
        }
        ConnectCSDL co = new ConnectCSDL();

        private void txttktheoten_TextChanged(object sender, EventArgs e)
        {
            co.KetNoi();
            dgvtknhanvien.DataSource = co.GetData("select * from tblNhanvien where TenNV like '" + txttennv.Text.Trim() + "%'");
        }

        private void btntktheoma_Click(object sender, EventArgs e)
        {
            
        }

        private void txttktheoma_TextChanged(object sender, EventArgs e)
        {
            co.KetNoi();
            dgvtknhanvien.DataSource = co.GetData("select * from tblNhanvien where MaNV = '" + txtmanv.Text.Trim() + "'");
        }

        private void txttktheoten_MouseClick(object sender, MouseEventArgs e)
        {
            txttennv.Clear();
        }

        private void txttktheoma_MouseClick(object sender, MouseEventArgs e)
        {
            txtmanv.Clear();
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            frm.Show();
            this.Hide();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {

            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn thoát không?", "Trả lời",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void btndiachi_Click(object sender, EventArgs e)
        {
            
        }

        private void txtdiachi_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtdiachi_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            co.KetNoi();
            dgvtknhanvien.DataSource = co.GetData("select * from tblNhanvien where MaNV = '" + txtmanv.Text.Trim() + "'");
            co.KetNoi();
            dgvtknhanvien.DataSource = co.GetData("select * from tblNhanvien where TenNV = '" + txttennv.Text.Trim() + "'");
            co.KetNoi();
            dgvtknhanvien.DataSource = co.GetData("select * from tblNhanvien where Diachi = '" + txttkdiachi.Text.Trim() + "'");
        }
    }
}
