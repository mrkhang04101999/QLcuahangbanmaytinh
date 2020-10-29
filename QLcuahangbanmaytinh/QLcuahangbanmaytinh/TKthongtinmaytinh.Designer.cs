namespace QLcuahangbanmaytinh
{
    partial class frmtkthongtinmaytinh
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
            this.grptimkiem = new System.Windows.Forms.GroupBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.txttktheoten = new System.Windows.Forms.TextBox();
            this.btnquaylai = new System.Windows.Forms.Button();
            this.btntktheoten = new System.Windows.Forms.Button();
            this.btntktheoma = new System.Windows.Forms.Button();
            this.txttktheoma = new System.Windows.Forms.TextBox();
            this.dgvtkthongtinmaytinh = new System.Windows.Forms.DataGridView();
            this.grptimkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtkthongtinmaytinh)).BeginInit();
            this.SuspendLayout();
            // 
            // grptimkiem
            // 
            this.grptimkiem.BackColor = System.Drawing.Color.LightBlue;
            this.grptimkiem.Controls.Add(this.btnthoat);
            this.grptimkiem.Controls.Add(this.txttktheoten);
            this.grptimkiem.Controls.Add(this.btnquaylai);
            this.grptimkiem.Controls.Add(this.btntktheoten);
            this.grptimkiem.Controls.Add(this.btntktheoma);
            this.grptimkiem.Controls.Add(this.txttktheoma);
            this.grptimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grptimkiem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grptimkiem.Location = new System.Drawing.Point(12, 12);
            this.grptimkiem.Name = "grptimkiem";
            this.grptimkiem.Size = new System.Drawing.Size(632, 171);
            this.grptimkiem.TabIndex = 21;
            this.grptimkiem.TabStop = false;
            this.grptimkiem.Text = "Tìm kiếm";
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.LightBlue;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnthoat.Location = new System.Drawing.Point(437, 108);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(97, 35);
            this.btnthoat.TabIndex = 44;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // txttktheoten
            // 
            this.txttktheoten.BackColor = System.Drawing.Color.White;
            this.txttktheoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttktheoten.Location = new System.Drawing.Point(96, 59);
            this.txttktheoten.Name = "txttktheoten";
            this.txttktheoten.Size = new System.Drawing.Size(97, 22);
            this.txttktheoten.TabIndex = 17;
            this.txttktheoten.Text = "Nhập vào tên";
            this.txttktheoten.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txttktheoten_MouseClick);
            this.txttktheoten.TextChanged += new System.EventHandler(this.txttktheoten_TextChanged);
            // 
            // btnquaylai
            // 
            this.btnquaylai.BackColor = System.Drawing.Color.LightBlue;
            this.btnquaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquaylai.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnquaylai.Location = new System.Drawing.Point(437, 46);
            this.btnquaylai.Name = "btnquaylai";
            this.btnquaylai.Size = new System.Drawing.Size(97, 36);
            this.btnquaylai.TabIndex = 43;
            this.btnquaylai.Text = "Quay lại";
            this.btnquaylai.UseVisualStyleBackColor = false;
            this.btnquaylai.Click += new System.EventHandler(this.btnquaylai_Click);
            // 
            // btntktheoten
            // 
            this.btntktheoten.BackColor = System.Drawing.Color.LightBlue;
            this.btntktheoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntktheoten.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btntktheoten.Location = new System.Drawing.Point(237, 46);
            this.btntktheoten.Name = "btntktheoten";
            this.btntktheoten.Size = new System.Drawing.Size(109, 36);
            this.btntktheoten.TabIndex = 10;
            this.btntktheoten.Text = "TK theo tên";
            this.btntktheoten.UseVisualStyleBackColor = false;
            this.btntktheoten.Click += new System.EventHandler(this.btntktheoten_Click);
            // 
            // btntktheoma
            // 
            this.btntktheoma.BackColor = System.Drawing.Color.LightBlue;
            this.btntktheoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntktheoma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btntktheoma.Location = new System.Drawing.Point(237, 107);
            this.btntktheoma.Name = "btntktheoma";
            this.btntktheoma.Size = new System.Drawing.Size(109, 36);
            this.btntktheoma.TabIndex = 16;
            this.btntktheoma.Text = "TK theo mã";
            this.btntktheoma.UseVisualStyleBackColor = false;
            this.btntktheoma.Click += new System.EventHandler(this.btntktheoma_Click);
            // 
            // txttktheoma
            // 
            this.txttktheoma.BackColor = System.Drawing.Color.White;
            this.txttktheoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttktheoma.Location = new System.Drawing.Point(96, 108);
            this.txttktheoma.Name = "txttktheoma";
            this.txttktheoma.Size = new System.Drawing.Size(97, 22);
            this.txttktheoma.TabIndex = 18;
            this.txttktheoma.Text = "Nhập vào mã";
            this.txttktheoma.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txttktheoma_MouseClick);
            this.txttktheoma.TextChanged += new System.EventHandler(this.txttktheoma_TextChanged);
            // 
            // dgvtkthongtinmaytinh
            // 
            this.dgvtkthongtinmaytinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtkthongtinmaytinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtkthongtinmaytinh.Location = new System.Drawing.Point(11, 189);
            this.dgvtkthongtinmaytinh.Name = "dgvtkthongtinmaytinh";
            this.dgvtkthongtinmaytinh.Size = new System.Drawing.Size(637, 150);
            this.dgvtkthongtinmaytinh.TabIndex = 22;
            // 
            // frmtkthongtinmaytinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(660, 353);
            this.Controls.Add(this.dgvtkthongtinmaytinh);
            this.Controls.Add(this.grptimkiem);
            this.Name = "frmtkthongtinmaytinh";
            this.Text = "Tìm kiếm thông tin máy tính";
            this.Load += new System.EventHandler(this.frmtkthongtinmaytinh_Load);
            this.grptimkiem.ResumeLayout(false);
            this.grptimkiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtkthongtinmaytinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grptimkiem;
        private System.Windows.Forms.TextBox txttktheoten;
        private System.Windows.Forms.Button btntktheoten;
        private System.Windows.Forms.Button btntktheoma;
        private System.Windows.Forms.TextBox txttktheoma;
        private System.Windows.Forms.DataGridView dgvtkthongtinmaytinh;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnquaylai;
    }
}