namespace QLcuahangbanmaytinh
{
    partial class frmtknhanvien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvtknhanvien = new System.Windows.Forms.DataGridView();
            this.grptimkiem = new System.Windows.Forms.GroupBox();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.lblmanv = new System.Windows.Forms.Label();
            this.lbltennv = new System.Windows.Forms.Label();
            this.txttkdiachi = new System.Windows.Forms.TextBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.btnquaylai = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txtmanv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtknhanvien)).BeginInit();
            this.grptimkiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvtknhanvien
            // 
            this.dgvtknhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtknhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtknhanvien.Location = new System.Drawing.Point(12, 235);
            this.dgvtknhanvien.Name = "dgvtknhanvien";
            this.dgvtknhanvien.Size = new System.Drawing.Size(637, 150);
            this.dgvtknhanvien.TabIndex = 24;
            // 
            // grptimkiem
            // 
            this.grptimkiem.BackColor = System.Drawing.Color.PowderBlue;
            this.grptimkiem.Controls.Add(this.lbldiachi);
            this.grptimkiem.Controls.Add(this.lblmanv);
            this.grptimkiem.Controls.Add(this.lbltennv);
            this.grptimkiem.Controls.Add(this.txttkdiachi);
            this.grptimkiem.Controls.Add(this.btnthoat);
            this.grptimkiem.Controls.Add(this.txttennv);
            this.grptimkiem.Controls.Add(this.btnquaylai);
            this.grptimkiem.Controls.Add(this.btntimkiem);
            this.grptimkiem.Controls.Add(this.txtmanv);
            this.grptimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grptimkiem.Location = new System.Drawing.Point(12, 12);
            this.grptimkiem.Name = "grptimkiem";
            this.grptimkiem.Size = new System.Drawing.Size(632, 217);
            this.grptimkiem.TabIndex = 23;
            this.grptimkiem.TabStop = false;
            this.grptimkiem.Text = "Tìm kiếm";
            // 
            // lbldiachi
            // 
            this.lbldiachi.AutoSize = true;
            this.lbldiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiachi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbldiachi.Location = new System.Drawing.Point(99, 163);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(53, 18);
            this.lbldiachi.TabIndex = 50;
            this.lbldiachi.Text = "Địa chỉ";
            // 
            // lblmanv
            // 
            this.lblmanv.AutoSize = true;
            this.lblmanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmanv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblmanv.Location = new System.Drawing.Point(99, 103);
            this.lblmanv.Name = "lblmanv";
            this.lblmanv.Size = new System.Drawing.Size(53, 18);
            this.lblmanv.TabIndex = 49;
            this.lblmanv.Text = "Mã NV";
            // 
            // lbltennv
            // 
            this.lbltennv.AutoSize = true;
            this.lbltennv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltennv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbltennv.Location = new System.Drawing.Point(99, 45);
            this.lbltennv.Name = "lbltennv";
            this.lbltennv.Size = new System.Drawing.Size(57, 18);
            this.lbltennv.TabIndex = 48;
            this.lbltennv.Text = "Tên NV";
            // 
            // txttkdiachi
            // 
            this.txttkdiachi.BackColor = System.Drawing.Color.White;
            this.txttkdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttkdiachi.Location = new System.Drawing.Point(182, 160);
            this.txttkdiachi.Name = "txttkdiachi";
            this.txttkdiachi.Size = new System.Drawing.Size(97, 24);
            this.txttkdiachi.TabIndex = 46;
            this.txttkdiachi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtdiachi_MouseClick);
            this.txttkdiachi.TextChanged += new System.EventHandler(this.txtdiachi_TextChanged);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.LightBlue;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnthoat.Location = new System.Drawing.Point(386, 156);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(106, 34);
            this.btnthoat.TabIndex = 44;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // txttennv
            // 
            this.txttennv.BackColor = System.Drawing.Color.White;
            this.txttennv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttennv.Location = new System.Drawing.Point(182, 42);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(97, 24);
            this.txttennv.TabIndex = 17;
            this.txttennv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txttktheoten_MouseClick);
            this.txttennv.TextChanged += new System.EventHandler(this.txttktheoten_TextChanged);
            // 
            // btnquaylai
            // 
            this.btnquaylai.BackColor = System.Drawing.Color.LightBlue;
            this.btnquaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquaylai.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnquaylai.Location = new System.Drawing.Point(386, 96);
            this.btnquaylai.Name = "btnquaylai";
            this.btnquaylai.Size = new System.Drawing.Size(107, 34);
            this.btnquaylai.TabIndex = 43;
            this.btnquaylai.Text = "Quay lại";
            this.btnquaylai.UseVisualStyleBackColor = false;
            this.btnquaylai.Click += new System.EventHandler(this.btnquaylai_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.Color.LightBlue;
            this.btntimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btntimkiem.Location = new System.Drawing.Point(386, 39);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(106, 33);
            this.btntimkiem.TabIndex = 10;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // txtmanv
            // 
            this.txtmanv.BackColor = System.Drawing.Color.White;
            this.txtmanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmanv.Location = new System.Drawing.Point(182, 100);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(97, 24);
            this.txtmanv.TabIndex = 18;
            this.txtmanv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txttktheoma_MouseClick);
            this.txtmanv.TextChanged += new System.EventHandler(this.txttktheoma_TextChanged);
            // 
            // frmtknhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 379);
            this.Controls.Add(this.dgvtknhanvien);
            this.Controls.Add(this.grptimkiem);
            this.Name = "frmtknhanvien";
            this.Text = "Tìm kiếm Nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.dgvtknhanvien)).EndInit();
            this.grptimkiem.ResumeLayout(false);
            this.grptimkiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvtknhanvien;
        private System.Windows.Forms.GroupBox grptimkiem;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.Button btnquaylai;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.TextBox txttkdiachi;
        private System.Windows.Forms.Label lbldiachi;
        private System.Windows.Forms.Label lblmanv;
        private System.Windows.Forms.Label lbltennv;
    }
}