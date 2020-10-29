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
    public partial class frmhoadonnhap : Form
    {
        public frmhoadonnhap()
        {
            InitializeComponent();
        }
        ConnectCSDL co = new ConnectCSDL();
        public void LoadData()
        {
            co.KetNoi();
            dgvDShdn.DataSource = co.GetData("select * from tblHoadonnhap");
            co.NgatKetNoi();
        }

        private void frmhoadonnhap_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadData();
            cbomamaytinh.DataSource = co.GetData("select * from tblThongTinMT");
            cbomamaytinh.ValueMember = "MaMT";
            cbomamaytinh.DisplayMember = "MaMT";

            cbomancc.DataSource = co.GetData("select * from tblNhaCC");
            cbomancc.ValueMember = "MaNCC";
            cbomancc.DisplayMember = "MaNCC";

        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            this.txtmahoadonnhap.Clear();
            this.txtdiachi.Clear();
            this.txtdongia.Clear();
            this.txtsodienthoai.Clear();
            this.txtsoluong.Clear();
            this.txtTongtien.Clear();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {

            double soluong = double.Parse(txtsoluong.Text);
            double dongia = double.Parse(txtdongia.Text);
            double tongtien = soluong * dongia;
            txtTongtien.Text = tongtien.ToString();
            co.KetNoi();
            string sqlthem = "insert into tblHoadonnhap values ('" + txtmahoadonnhap.Text + "','" + txtmanv.Text +
                "','" + cbomamaytinh.SelectedValue + "','" + cbomancc.SelectedValue + "','" + txtsoluong.Text + "','" + mtbNgaynhap.Text + 
                "','" + txtdiachi.Text + "','" + txtsodienthoai.Text + "','" + txtdongia.Text + "','" + txtTongtien.Text + "')";
            co.ThucThi(sqlthem);
            frmhoadonnhap_Load(sender, e);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            double soluong = double.Parse(txtsoluong.Text);
            double dongia = double.Parse(txtdongia.Text);
            double tongtien = soluong * dongia;
            txtTongtien.Text = tongtien.ToString();
            co.KetNoi();
            string sqlsua = "update tblHoadonnhap set MaHDN='" + txtmahoadonnhap.Text + "',MaNV='" + txtmanv.Text +
                "',MaMT='" + cbomamaytinh.SelectedValue +
                "',MaNCC='" + cbomancc.SelectedValue + "',Soluong='" + txtsoluong.Text + "',Ngaynhap='" + mtbNgaynhap.Text + "',Diachi='" + txtdiachi.Text +
                "',sdt='" + txtsodienthoai.Text + "',Dongia='" + txtdongia.Text + "',Tongtien='" + txtTongtien.Text + "' where MaHDN='" + txtmahoadonnhap.Text + "'";
            co.ThucThi(sqlsua);
            LoadData();
        }

        private void dgvDShdn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtmahoadonnhap.Text = dgvDShdn.Rows[i].Cells[0].Value.ToString().Trim();
            txtmanv.Text = dgvDShdn.Rows[i].Cells[1].Value.ToString().Trim();
           cbomamaytinh.Text = dgvDShdn.Rows[i].Cells[2].Value.ToString().Trim();
           cbomancc.Text = dgvDShdn.Rows[i].Cells[3].Value.ToString().Trim();
            txtsoluong.Text = dgvDShdn.Rows[i].Cells[4].Value.ToString().Trim();

            txtdiachi.Text = dgvDShdn.Rows[i].Cells[6].Value.ToString().Trim();
            txtsodienthoai.Text = dgvDShdn.Rows[i].Cells[7].Value.ToString().Trim();
            txtdongia.Text = dgvDShdn.Rows[i].Cells[8].Value.ToString().Trim();
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

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn xóa không?", "Trả lời",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                string sqlxoa = "delete from tblHoadonban where MaHDN = '" + txtmahoadonnhap.Text + "'";
                co.ThucThi(sqlxoa);
            }
            frmhoadonnhap_Load(sender, e);
        }
    }
}
