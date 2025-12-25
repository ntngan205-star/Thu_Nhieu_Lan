using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quán_lý_bán_thuốc
{
    public partial class frmThuoc : Form
    {
        public frmThuoc()
        {
            InitializeComponent();
        }
        Ketnoidulieu2 kn2 = new Ketnoidulieu2();
        SqlDataReader dr = null;
        SqlCommand cmd = null;
        Boolean flag;

        private void LoadGR()
        {
            string sqlThuoc = "select * from Thuoc";
           dgvThuoc.DataSource = kn2.TaoBang(sqlThuoc);
            Trochuot();
        }
        private void LoadData()
        {
            int r = dgvThuoc.CurrentCell.RowIndex;
            txtMaThuoc.Text = dgvThuoc.Rows[r].Cells[0].Value.ToString();
            txtTenThuoc.Text = dgvThuoc.Rows[r].Cells[1].Value.ToString();
            txtCongDung.Text = dgvThuoc.Rows[r].Cells[2].Value.ToString();
            txtNgaySX.Text = dgvThuoc.Rows[r].Cells[3].Value.ToString();
            txtNgayHetHan.Text = dgvThuoc.Rows[r].Cells[4].Value.ToString();
            txtSoLuong.Text = dgvThuoc.Rows[r].Cells[5].Value.ToString();
            txtDonVi.Text = dgvThuoc.Rows[r].Cells[6].Value.ToString();

        }
        private void Lock_Control()
        {
            btnThem.Visible = true;
            btnSua.Visible = true;
            btnXoa.Visible = true;
            btnThoat.Visible = true;
            btnGhi.Visible = false;
            btnKhongGhi.Visible = false;
        }
        private void Unlock_Control()
        {
            btnThem.Visible = false;
            btnSua.Visible = false;
            btnThoat.Visible = false;
            btnXoa.Visible = false;
            btnGhi.Visible = true;
            btnKhongGhi.Visible = true;
        }
        private void Trochuot()
        {
            for (int i = 0; i < dgvThuoc.Rows.Count - 1; i++)
            {
                if (dgvThuoc.Rows[i].Cells[0].Value.ToString() == txtMaThuoc.Text.Trim())
                {
                    dgvThuoc.CurrentCell = dgvThuoc.Rows[i].Cells[0];
                    dgvThuoc.Rows[i].Selected = true;
                }
            }
        }
        private void frmThuoc_Load(object sender, EventArgs e)
        {
            try
            {
                kn2.Myconn();
                Lock_Control();
                LoadGR();
                LoadData();
                dgvThuoc.AllowUserToAddRows = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Kết nối CSDL");
                throw;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaThuoc.Clear();
            txtTenThuoc.Clear();
            txtCongDung.Clear();
            txtNgaySX.Clear();
            txtNgayHetHan.Clear();
            txtSoLuong.Clear();
            txtDonVi.Clear();

            txtMaThuoc.Focus();
            Unlock_Control();
            flag = true;
            txtMaThuoc.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Unlock_Control();
            flag = false;
            txtMaThuoc.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn xóa không", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                string sqlXoa = "delete Thuoc where MaThuoc='" + txtMaThuoc.Text.Trim() + "'";
                cmd = new SqlCommand(sqlXoa, kn2.conn);
                kn2.conn.Open();
                cmd.ExecuteNonQuery();
                kn2.conn.Close();
                LoadGR();

                LoadData();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKhongGhi_Click(object sender, EventArgs e)
        {
            Lock_Control();
            txtMaThuoc.Enabled = false;
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                if (txtMaThuoc.Text.Trim() == "" || txtTenThuoc.Text.Trim() == "" || txtCongDung.Text.Trim() == "" || txtNgaySX.Text.Trim() == "" || txtNgayHetHan.Text.Trim() == "" || txtSoLuong.Text.Trim() == "" || txtDonVi.Text.Trim() == "")
                {
                    MessageBox.Show("Mã, Tên,Công, Ngày, Số lượng, Đơn vị  không được để trống, nhập vào đi!!!");
                    return;
                }
                string sqlThuoc = "select * from Thuốc where MaThuốc='" + txtMaThuoc.Text.Trim() + "'";
                cmd = new SqlCommand(sqlThuoc, kn2.conn);
                //kn2.conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("Mã bị trùng vui lòng nhập mã khác !");
                    dr.Close();
                    return;
                }
                dr.Close();


                string sqlThem = "insert into Thuoc (MaThuoc, TenThuoc, CongDung, NgaySanXuat, NgayHetHanDung, SoLuongSanXuat, DonViTinh) values(@MaThuoc,@TenThuoc,@CongDung,@NgaySanXuat,@NgayHetHanDung,@SoLuongSanXuat,@DonViTinh)";
                cmd = new SqlCommand(sqlThem, kn2.conn);
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@MaThuoc", SqlDbType.Int).Value = txtMaThuoc.Text.Trim();
                cmd.Parameters.Add("@TenThuoc", SqlDbType.NVarChar).Value = txtTenThuoc.Text.Trim();
                cmd.Parameters.Add("@CongDung", SqlDbType.NVarChar).Value = txtTenThuoc.Text.Trim();
                cmd.Parameters.Add("@NgaySanXuat", SqlDbType.NVarChar).Value = txtTenThuoc.Text.Trim();
                cmd.Parameters.Add("@NgayHetHanDung", SqlDbType.NVarChar).Value = txtTenThuoc.Text.Trim();
                cmd.Parameters.Add("@SoLuongSanXuat", SqlDbType.NVarChar).Value = txtTenThuoc.Text.Trim();
                cmd.Parameters.Add("@DonViTinh", SqlDbType.NVarChar).Value = txtTenThuoc.Text.Trim();
                cmd.ExecuteNonQuery();

                LoadGR();
                Trochuot();
                LoadData();
            }
            else
            {
                string sqlSua = "update Thuoc set MaThuoc=@MaThuoc, TenThuoc=@TenThuoc,  CongDung=@CongDung, NgaySanXuat=@NgaySanXuat, NgayHetHanDung=@NgayHetHanDung, SoLuongSanXuat=@SoLuongSanXuat, DonViTinh=@DonViTinh where MaThuoc=@MaThuoc";
                cmd = new SqlCommand(sqlSua, kn2.conn);
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@MaThuoc", SqlDbType.Int).Value = txtMaThuoc.Text.Trim();
                cmd.Parameters.Add("@TenThuoc", SqlDbType.NVarChar).Value = txtTenThuoc.Text.Trim();
                cmd.Parameters.Add("@CongDung", SqlDbType.NVarChar).Value = txtTenThuoc.Text.Trim();
                cmd.Parameters.Add("@NgaySanXuat", SqlDbType.NVarChar).Value = txtTenThuoc.Text.Trim();
                cmd.Parameters.Add("@NgayHetHanDung", SqlDbType.NVarChar).Value = txtTenThuoc.Text.Trim();
                cmd.Parameters.Add("@SoLuongSanXuat", SqlDbType.NVarChar).Value = txtTenThuoc.Text.Trim();
                cmd.Parameters.Add("@DonViTinh", SqlDbType.NVarChar).Value = txtTenThuoc.Text.Trim();

                cmd.ExecuteNonQuery();

                LoadGR();
                //LoadData();
                Trochuot();
            }
        }

        private void dgvThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData();
        }
    }
}
