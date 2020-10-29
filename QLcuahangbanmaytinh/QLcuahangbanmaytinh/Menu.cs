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
    public partial class frmMenu : Form
    {
        int admin = 1;
        public frmMenu()
        {
            InitializeComponent();
            admin = frmdangnhap.admin;
            
        }
        public int i = 8;
        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.Left += i;
            if (label1.Left >= this.Width - label1.Width || label1.Left <= 0)
                i = -i;
        }

        private void quảnLýThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void thôngTinMáyTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLthongtinmaytinh frm = new frmQLthongtinmaytinh();
            frm.Show();
            this.Hide();
        }

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnhanvien frm = new frmnhanvien();
            frm.Show();
            this.Hide();
        }

        private void thôngTinNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnhacungcap frm = new frmnhacungcap();
            frm.Show();
            this.Hide();
        }

        private void thôngTinHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmhoadonnhap frm = new frmhoadonnhap();
            frm.Show();
            this.Hide();
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmhoadonban frm = new frmhoadonban();
            frm.Show();
            this.Hide();
        }

        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmkhachhang frm = new frmkhachhang();
            frm.Show();
            this.Hide();
        }

        private void thôngTinMáyTínhToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmtkthongtinmaytinh frm = new frmtkthongtinmaytinh();
            frm.Show();
            this.Hide();
        }

        private void thôngTinNhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmtknhanvien frm = new frmtknhanvien();
            frm.Show();
            this.Hide();
        }

        private void thôngTinNhàCungCấpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmtkncc frm = new frmtkncc();
            frm.Show();
            this.Hide();
        }

        private void thôngTinKháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmtkkhachhang frm = new frmtkkhachhang();
            frm.Show();
            this.Hide();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn thoát không?", "Trả lời",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void quayLaijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdangnhap tc = new frmdangnhap();
            tc.Show();
            this.Hide();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmthongke frm = new frmthongke();
            frm.Show();
            this.Hide();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            if (admin == 0)
            {
                thôngTinNhânViênToolStripMenuItem.Visible = false;
            }
            else
            {
                thôngTinNhânViênToolStripMenuItem.Visible = true;
            }
        }
    }
    }
