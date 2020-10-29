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
    public partial class frmthongke : Form
    {
        public frmthongke()
        {
            InitializeComponent();
        }
        ConnectCSDL co = new ConnectCSDL();

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

        private void btnThongke_Click(object sender, EventArgs e)
        {
            
                      if(rdbHDB.Checked == true)
            {
                co.KetNoi();
                string sqlTK = "select * from tblHoadonban where Ngayban = '" + mtbThangnam.Text+"'";
                dgvTimkiem.DataSource = co.GetData(sqlTK);
            }
                      if (rdbHDN.Checked == true)
                      {
                          co.KetNoi();
                          string sqlTK = "select * from tblHoadonnhap where Ngaynhap = '" + mtbThangnam.Text + "'";
                          dgvTimkiem.DataSource = co.GetData(sqlTK);
                      }
        }
    }
}
