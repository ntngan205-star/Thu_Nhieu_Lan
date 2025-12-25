namespace Quán_lý_bán_thuốc
{
    partial class frmThuoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTenThuoc = new System.Windows.Forms.TextBox();
            this.txtCongDung = new System.Windows.Forms.TextBox();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.txtNgaySX = new System.Windows.Forms.TextBox();
            this.txtNgayHetHan = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtMaThuoc = new System.Windows.Forms.TextBox();
            this.dgvThuoc = new System.Windows.Forms.DataGridView();
            this.MaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CongDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHetHanDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnKhongGhi = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Thuốc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày hết hạn dùng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Sản Xuất:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Công Dụng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên Thuốc:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số Lượng Sản Xuất:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Đơn Vị Tính:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTenThuoc);
            this.panel1.Controls.Add(this.txtCongDung);
            this.panel1.Controls.Add(this.txtDonVi);
            this.panel1.Controls.Add(this.txtNgaySX);
            this.panel1.Controls.Add(this.txtNgayHetHan);
            this.panel1.Controls.Add(this.txtSoLuong);
            this.panel1.Controls.Add(this.txtMaThuoc);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 235);
            this.panel1.TabIndex = 7;
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.Location = new System.Drawing.Point(127, 71);
            this.txtTenThuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new System.Drawing.Size(184, 27);
            this.txtTenThuoc.TabIndex = 13;
            // 
            // txtCongDung
            // 
            this.txtCongDung.Location = new System.Drawing.Point(127, 135);
            this.txtCongDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCongDung.Name = "txtCongDung";
            this.txtCongDung.Size = new System.Drawing.Size(184, 27);
            this.txtCongDung.TabIndex = 12;
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(127, 191);
            this.txtDonVi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(184, 27);
            this.txtDonVi.TabIndex = 11;
            // 
            // txtNgaySX
            // 
            this.txtNgaySX.Location = new System.Drawing.Point(498, 8);
            this.txtNgaySX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNgaySX.Name = "txtNgaySX";
            this.txtNgaySX.Size = new System.Drawing.Size(190, 27);
            this.txtNgaySX.TabIndex = 10;
            // 
            // txtNgayHetHan
            // 
            this.txtNgayHetHan.Location = new System.Drawing.Point(498, 68);
            this.txtNgayHetHan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNgayHetHan.Name = "txtNgayHetHan";
            this.txtNgayHetHan.Size = new System.Drawing.Size(190, 27);
            this.txtNgayHetHan.TabIndex = 9;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(498, 135);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(190, 27);
            this.txtSoLuong.TabIndex = 8;
            // 
            // txtMaThuoc
            // 
            this.txtMaThuoc.Location = new System.Drawing.Point(127, 12);
            this.txtMaThuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaThuoc.Name = "txtMaThuoc";
            this.txtMaThuoc.Size = new System.Drawing.Size(184, 27);
            this.txtMaThuoc.TabIndex = 7;
            // 
            // dgvThuoc
            // 
            this.dgvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThuoc,
            this.TenThuoc,
            this.CongDung,
            this.NgaySanXuat,
            this.NgayHetHanDung,
            this.SoLuongSanXuat,
            this.DonViTinh});
            this.dgvThuoc.Location = new System.Drawing.Point(15, 269);
            this.dgvThuoc.Name = "dgvThuoc";
            this.dgvThuoc.RowHeadersWidth = 51;
            this.dgvThuoc.RowTemplate.Height = 24;
            this.dgvThuoc.Size = new System.Drawing.Size(712, 324);
            this.dgvThuoc.TabIndex = 8;
            this.dgvThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuoc_CellClick);
            // 
            // MaThuoc
            // 
            this.MaThuoc.DataPropertyName = "MaThuoc";
            this.MaThuoc.HeaderText = "Mã Thuốc";
            this.MaThuoc.MinimumWidth = 6;
            this.MaThuoc.Name = "MaThuoc";
            this.MaThuoc.Width = 125;
            // 
            // TenThuoc
            // 
            this.TenThuoc.DataPropertyName = "TenThuoc";
            this.TenThuoc.HeaderText = "Tên Thuốc";
            this.TenThuoc.MinimumWidth = 6;
            this.TenThuoc.Name = "TenThuoc";
            this.TenThuoc.Width = 125;
            // 
            // CongDung
            // 
            this.CongDung.DataPropertyName = "CongDung";
            this.CongDung.HeaderText = "Công dụng";
            this.CongDung.MinimumWidth = 6;
            this.CongDung.Name = "CongDung";
            this.CongDung.Width = 125;
            // 
            // NgaySanXuat
            // 
            this.NgaySanXuat.DataPropertyName = "NgaySanXuat";
            this.NgaySanXuat.HeaderText = "Ngày Sản Xuất";
            this.NgaySanXuat.MinimumWidth = 6;
            this.NgaySanXuat.Name = "NgaySanXuat";
            this.NgaySanXuat.Width = 125;
            // 
            // NgayHetHanDung
            // 
            this.NgayHetHanDung.DataPropertyName = "NgayHetHanDung";
            this.NgayHetHanDung.HeaderText = "Ngày Hết Hạn";
            this.NgayHetHanDung.MinimumWidth = 6;
            this.NgayHetHanDung.Name = "NgayHetHanDung";
            this.NgayHetHanDung.Width = 125;
            // 
            // SoLuongSanXuat
            // 
            this.SoLuongSanXuat.DataPropertyName = "SoLuongSanXuat";
            this.SoLuongSanXuat.HeaderText = "Số Lượng";
            this.SoLuongSanXuat.MinimumWidth = 6;
            this.SoLuongSanXuat.Name = "SoLuongSanXuat";
            this.SoLuongSanXuat.Width = 125;
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "DonViTinh";
            this.DonViTinh.HeaderText = "Đơn Vị";
            this.DonViTinh.MinimumWidth = 6;
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.Width = 125;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnKhongGhi);
            this.panel2.Controls.Add(this.btnGhi);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(744, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 578);
            this.panel2.TabIndex = 20;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(21, 38);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 52);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(21, 225);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(108, 52);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnKhongGhi
            // 
            this.btnKhongGhi.Location = new System.Drawing.Point(21, 406);
            this.btnKhongGhi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKhongGhi.Name = "btnKhongGhi";
            this.btnKhongGhi.Size = new System.Drawing.Size(108, 52);
            this.btnKhongGhi.TabIndex = 6;
            this.btnKhongGhi.Text = "Không Ghi";
            this.btnKhongGhi.UseVisualStyleBackColor = true;
            this.btnKhongGhi.Click += new System.EventHandler(this.btnKhongGhi_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.Location = new System.Drawing.Point(21, 135);
            this.btnGhi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(108, 52);
            this.btnGhi.TabIndex = 7;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(21, 308);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 52);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(21, 496);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(108, 52);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 612);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvThuoc);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thuốc";
            this.Load += new System.EventHandler(this.frmThuoc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTenThuoc;
        private System.Windows.Forms.TextBox txtCongDung;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.TextBox txtNgaySX;
        private System.Windows.Forms.TextBox txtNgayHetHan;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtMaThuoc;
        private System.Windows.Forms.DataGridView dgvThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CongDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHetHanDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongSanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnKhongGhi;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}

