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
    public partial class frmtkthongtinmaytinh : Form
    {
        public frmtkthongtinmaytinh()
        {
            InitializeComponent();
        }
        ConnectCSDL co = new ConnectCSDL();

        private void frmtkthongtinmaytinh_Load(object sender, EventArgs e)
        {

        }

        private void btntktheoten_Click(object sender, EventArgs e)
        {

        }

        private void txttktheoten_TextChanged(object sender, EventArgs e)
        {
            co.KetNoi();
            dgvtkthongtinmaytinh.DataSource = co.GetData("select * from tblThongTinMT where TENMT like '" + txttktheoten.Text.Trim() + "%'");
        }

        private void btntktheoma_Click(object sender, EventArgs e)
        {
            co.KetNoi();
            dgvtkthongtinmaytinh.DataSource = co.GetData("select * from tblThongTinMT where MaMT = '" + txttktheoma.Text.Trim() + "'");
        }

        private void txttktheoma_TextChanged(object sender, EventArgs e)
        {
            co.KetNoi();
            dgvtkthongtinmaytinh.DataSource = co.GetData("select * from tblThongTinMT where MaMT = '" + txttktheoma.Text.Trim() + "'");
            
        }

        private void txttktheoten_MouseClick(object sender, MouseEventArgs e)
        {
            txttktheoten.Clear();
        }

        private void txttktheoma_MouseClick(object sender, MouseEventArgs e)
        {
            txttktheoma.Clear();
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            frmMenu tc = new frmMenu();
            tc.Show();
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
    }
}
