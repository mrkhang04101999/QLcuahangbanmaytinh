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
    public partial class frmkhachhang : Form
    {
        public frmkhachhang()
        {
            InitializeComponent();
        }
        ConnectCSDL co = new ConnectCSDL();
        public void LoadData()
        {
            co.KetNoi();
            dgvkhachhang.DataSource = co.GetData("select * from tblKhachhang");
            co.NgatKetNoi();
        }

        private void frmkhachhang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {

            this.txtmakh.Clear();
            this.txttenkh.Clear();
            this.txtdiachi.Clear();
            this.txtsdt.Clear();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string sqlthem = "insert into tblKhachhang values ('" + txtmakh.Text + "','" + txttenkh.Text
             + "','"+txtgioitinh.Text+"','" + txtdiachi.Text + "','" + txtsdt.Text + "')";
            co.ThucThi(sqlthem);
            frmkhachhang_Load(sender, e);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sqlsua = "update tblKhachhang set MaKH='" + txtmakh.Text + "',TenKH='" + txttenkh.Text + "',Gioitinh = '" + txtgioitinh.Text
              + "',Diachi='" + txtdiachi.Text + "',sdt='" + txtsdt.Text + "'where MaKH='" + txtmakh.Text + "'";
            co.ThucThi(sqlsua);
            LoadData();
            frmkhachhang_Load(sender, e);

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn xóa không?", "Trả lời",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                string sqlxoa = "delete from tblKhachhang where MaKH = '" + txtmakh.Text + "'";
                co.ThucThi(sqlxoa);
            }
        }
        

        private void btnthoat_Click(object sender, EventArgs e)
        {

            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn thoát không?", "Trả lời",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void dgvkhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            
            txtmakh.Text = dgvkhachhang.Rows[i].Cells[0].Value.ToString().Trim();
            txttenkh.Text = dgvkhachhang.Rows[i].Cells[1].Value.ToString().Trim();
            txtgioitinh.Text = dgvkhachhang.Rows[i].Cells[2].Value.ToString().Trim();
            txtdiachi.Text = dgvkhachhang.Rows[i].Cells[3].Value.ToString().Trim();
            txtsdt.Text = dgvkhachhang.Rows[i].Cells[4].Value.ToString().Trim();
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {

            frmMenu tc = new frmMenu();
            tc.Show();
            this.Hide();
        }
    }
}
