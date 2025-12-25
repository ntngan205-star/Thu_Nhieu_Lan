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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }
        Ketnoidulieu1 kn1 = new Ketnoidulieu1();
        SqlDataReader dr = null;
        SqlCommand cmd = null;
        Boolean flag;
        DataTable dt = null;


        private string GetID()
        {
            String idu = null;
            String sql = "select * from users where user_name='" + txtTenDangNhap.Text.Trim() + "'and pass='" + txtMatKhau.Text.Trim() + "'";
            DataTable dt = new DataTable();
            dt = kn1.TaoBang(sql);
            foreach (DataRow dr in dt.Rows)
            {
                idu = dr["id_user"].ToString();
            }

            return idu;
        }


        private void frmlogin_Load(object sender, EventArgs e)
        {
            try
            {
                kn1.Myconn();

            }
            catch (Exception)
            {
                MessageBox.Show("Kết nối cơ sở dữ liệu bị lỗi");
                throw;
            }
        }

        public static string IDU = null;

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            IDU = GetID();
            if (IDU != null)
            {
                this.Hide();
                Form frm = new frmmain();
                frm.ShowDialog();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn đăng nhập sai PASS hoặc ACC");
            }
        }
    }
}
