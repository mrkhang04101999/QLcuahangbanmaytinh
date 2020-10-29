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
    public partial class frmhoadonban : Form
    {
        public frmhoadonban()
        {
            InitializeComponent();
        }
        ConnectCSDL co = new ConnectCSDL();
        public void LoadData()
        {
            co.KetNoi();
            dgvDShdb.DataSource = co.GetData("select * from tblHoadonban");
            co.NgatKetNoi();
        }

        private void frmhoadonban_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadData();
            cbomamaytinh.DataSource = co.GetData("select * from tblThongTinMT");
            cbomamaytinh.ValueMember = "MaMT";
            cbomamaytinh.DisplayMember = "MaMT";
           
            cbomakh.DataSource = co.GetData("select * from tblKhachhang");
            cbomakh.ValueMember = "MaKH";
            cbomakh.DisplayMember = "MaKH";

         
           
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            this.txtdongia.Clear();
            this.txtmahoadonban.Clear();
            this.txtmanv.Clear();
            this.txtsodienthoai.Clear();
            this.txtdiachi.Clear();

            this.txtsoluong.Clear();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            double soluong = double.Parse(txtsoluong.Text);
            double dongia = double.Parse(txtdongia.Text);
            double tongtien = soluong * dongia;
            txtTongtien.Text = tongtien.ToString();
            co.KetNoi();
            string sqlthem = "insert into tblHoadonban values ('" + txtmahoadonban.Text + "','" + txtmanv.Text + "','" + cbomakh.SelectedValue + "','" + cbomamaytinh.SelectedValue + "','" + txtsoluong.Text + "','"+mtbNgayban.Text+"','" + txtdiachi.Text + "','" + txtsodienthoai.Text + "','" + txtdongia.Text + "','" + txtTongtien.Text + "')";
            co.ThucThi(sqlthem);
            frmhoadonban_Load(sender, e);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn xóa không?", "Trả lời",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                string sqlxoa = "delete from tblHoadonban where MaHDB = '" + txtmahoadonban.Text + "'";
                co.ThucThi(sqlxoa);
            }
            frmhoadonban_Load(sender, e);

          
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

        private void dgvDShdb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtmahoadonban.Text = dgvDShdb.Rows[i].Cells[0].Value.ToString().Trim();
            txtmanv.Text = dgvDShdb.Rows[i].Cells[1].Value.ToString().Trim();
            cbomakh.Text = dgvDShdb.Rows[i].Cells[2].Value.ToString().Trim();
            cbomamaytinh.Text = dgvDShdb.Rows[i].Cells[3].Value.ToString().Trim();
            txtsoluong.Text = dgvDShdb.Rows[i].Cells[4].Value.ToString().Trim();

            txtdiachi.Text = dgvDShdb.Rows[i].Cells[6].Value.ToString().Trim();
            txtsodienthoai.Text = dgvDShdb.Rows[i].Cells[7].Value.ToString().Trim();
            txtdongia.Text = dgvDShdb.Rows[i].Cells[8].Value.ToString().Trim();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            double soluong = double.Parse(txtsoluong.Text);
            double dongia = double.Parse(txtdongia.Text);
            double tongtien = soluong * dongia;
            txtTongtien.Text = tongtien.ToString();
            co.KetNoi();
            string sqlsua = "update tblHoadonban set MaHDB='" + txtmahoadonban.Text + "',MaNV='" + txtmanv.Text + 
                "',MaKH='" + cbomakh.SelectedValue + "',MaMT='" + cbomamaytinh.SelectedValue + 
                "',Soluong='" + txtsoluong.Text + "',Ngayban='" + mtbNgayban.Text + "',Diachi='" + txtdiachi.Text + 
                "',sdt='" + txtsodienthoai.Text + "',Dongia='" + txtdongia.Text + "',Tongtien='" + txtTongtien.Text + "' where MaHDB='" + txtmahoadonban.Text + "'";
            co.ThucThi(sqlsua);
            LoadData();
            
        }
        public void Export(DataTable dt, string sheetName, string title)
        {
            //Tạo các đối tượng Excel
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetName;

            // Tạo phần đầu nếu muốn
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "J1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Times New Roman";
            head.Font.Size = "18";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã HDB";
            cl1.ColumnWidth = 13.5;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Mã NV";
            cl2.ColumnWidth = 13.5;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Mã KH";
            cl3.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Mã MT";
            cl4.ColumnWidth = 13.5;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Số lượng";
            cl5.ColumnWidth = 13.5;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Ngày bán";
            cl6.ColumnWidth = 13.5;

            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "Địa chỉ";
            cl7.ColumnWidth = 13.5;

            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");
            cl8.Value2 = "sdt";
            cl8.ColumnWidth = 13.5;

            Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I3", "I3");
            cl9.Value2 = "Đơn giá";
            cl9.ColumnWidth = 13.5;

            Microsoft.Office.Interop.Excel.Range cl10 = oSheet.get_Range("J3", "J3");
            cl10.Value2 = "Tổng tiền";
            cl10.ColumnWidth = 13.5;


            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "J3");
            rowHead.Font.Bold = true;
            // Kẻ viền
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // Thiết lập màu nền
            rowHead.Interior.ColorIndex = 15;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;


            // Tạo mảng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,
            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.
            object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng
            for (int r = 0; r < dt.Rows.Count; r++)
            {
                DataRow dr = dt.Rows[r];
                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    arr[r, c] = dr[c];
                }
            }

            //Thiết lập vùng điền dữ liệu
            int rowStart = 4;
            int columnStart = 1;

            int rowEnd = rowStart + dt.Rows.Count - 1;
            int columnEnd = dt.Columns.Count;

            // Ô bắt đầu điền dữ liệu
            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];
            // Ô kết thúc điền dữ liệu
            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];
            // Lấy về vùng điền dữ liệu
            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập
            range.Value2 = arr;

            // Kẻ viền
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // Căn giữa cột STT
            Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];
            Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);
            oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

        }

        private void btninhoadon_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dgvDShdb.DataSource;
            Export(dt, "Danh sach", "DANH SÁCH HÓA ĐƠN BÁN");
        }

        public void loaddata()
        {
            co.KetNoi();
            dgvDShdb.DataSource = co.GetData("select * from tblHoadonban");
            co.NgatKetNoi();
        }

        private void grphoadonban_Enter(object sender, EventArgs e)
        {

        }

    }
}
