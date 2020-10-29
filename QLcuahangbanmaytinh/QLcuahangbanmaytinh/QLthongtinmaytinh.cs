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
    public partial class frmQLthongtinmaytinh : Form
    {
        public frmQLthongtinmaytinh()
        {
            InitializeComponent();
        }
        ConnectCSDL co = new ConnectCSDL();
        public void LoadData()
        {
            co.KetNoi();
            dgvmaytinh.DataSource = co.GetData("select * from tblThongTinMT");
            co.NgatKetNoi();
        }
        private void btnlammoi_Click(object sender, EventArgs e)
        {

            this.txtgiaban.Clear();
            this.txtmamaytinh.Clear();

            this.txttenmaytinh.Clear();
            this.txtsoluong.Clear();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string sqlthem = "insert into tblThongTinMT values ('" + txtmamaytinh.Text + "','" + txttenmaytinh.Text
                + "','" + cbomancc.Text + "','" + txtsoluong.Text + "','" + txtgiaban.Text + "')";

            co.ThucThi(sqlthem);
            LoadData();
            frmQLthongtinmaytinh_Load(sender, e);
        }

        private void frmQLthongtinmaytinh_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadData();

            cbomancc.DataSource = co.GetData("select * from tblNhaCC");
            cbomancc.ValueMember = "MaNCC";
            cbomancc.DisplayMember = "MaNCC";
        }

        private void btnsua_Click(object sender, EventArgs e)
        {

            string sqlsua = "update tblThongTinMT set MaMT='" + txtmamaytinh.Text + "',tenmt='" + txttenmaytinh.Text
               + "',soluong='" + txtsoluong.Text + "',giaban='" + txtgiaban.Text + "',MaNCC='" + cbomancc.SelectedValue +
               "' where MaMT ='" + txtmamaytinh.Text + "'";
            co.ThucThi(sqlsua);
            LoadData();

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn xóa không?", "Trả lời",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                string sqlxoa = "delete from tblThongtinMT where MaMT = '" + txtmamaytinh.Text + "'";
                co.ThucThi(sqlxoa);
            }
            frmQLthongtinmaytinh_Load(sender, e);

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

        private void dgvmaytinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtmamaytinh.Text = dgvmaytinh.Rows[i].Cells[0].Value.ToString().Trim();
            txttenmaytinh.Text = dgvmaytinh.Rows[i].Cells[1].Value.ToString().Trim();
            cbomancc.Text = dgvmaytinh.Rows[i].Cells[2].Value.ToString().Trim();
            txtsoluong.Text = dgvmaytinh.Rows[i].Cells[3].Value.ToString().Trim();
            txtgiaban.Text = dgvmaytinh.Rows[i].Cells[4].Value.ToString().Trim();
           
        }

        private void txttktheoten_TextChanged(object sender, EventArgs e)
        {
           
         
            
        }

        
        private void btntktheoma_Click(object sender, EventArgs e)
        {
          
        }

        private void txttktheoma_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void txttktheoten_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void txttktheoma_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
