namespace Quán_lý_bán_thuốc
{
    partial class frmmain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MNDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.DMThuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.DMKH = new System.Windows.Forms.ToolStripMenuItem();
            this.DMDH = new System.Windows.Forms.ToolStripMenuItem();
            this.DMChiTietHD = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LemonChiffon;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MNDanhMuc});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(682, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MNDanhMuc
            // 
            this.MNDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DMThuoc,
            this.DMKH,
            this.DMDH,
            this.DMChiTietHD});
            this.MNDanhMuc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MNDanhMuc.Name = "MNDanhMuc";
            this.MNDanhMuc.Size = new System.Drawing.Size(93, 24);
            this.MNDanhMuc.Text = "Danh Mục";
            // 
            // DMThuoc
            // 
            this.DMThuoc.Name = "DMThuoc";
            this.DMThuoc.Size = new System.Drawing.Size(224, 26);
            this.DMThuoc.Text = "Thuốc";
            this.DMThuoc.Click += new System.EventHandler(this.DMThuoc_Click);
            // 
            // DMKH
            // 
            this.DMKH.Name = "DMKH";
            this.DMKH.Size = new System.Drawing.Size(224, 26);
            this.DMKH.Text = "Khách Hàng";
//            this.DMKH.Click += new System.EventHandler(this.DMKH_Click);
            // 
            // DMDH
            // 
            this.DMDH.Name = "DMDH";
            this.DMDH.Size = new System.Drawing.Size(224, 26);
            this.DMDH.Text = "Đơn Hàng";
            this.DMDH.Click += new System.EventHandler(this.DMDH_Click);
            // 
            // DMChiTietHD
            // 
            this.DMChiTietHD.Name = "DMChiTietHD";
            this.DMChiTietHD.Size = new System.Drawing.Size(224, 26);
            this.DMChiTietHD.Text = "Chi Tiết Hóa Đơn";
            this.DMChiTietHD.Click += new System.EventHandler(this.DMChiTietHD_Click);
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 385);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmmain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MNDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem DMThuoc;
        private System.Windows.Forms.ToolStripMenuItem DMKH;
        private System.Windows.Forms.ToolStripMenuItem DMDH;
        private System.Windows.Forms.ToolStripMenuItem DMChiTietHD;
    }
}