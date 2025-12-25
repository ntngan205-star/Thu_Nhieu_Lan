using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quán_lý_bán_thuốc
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }
        string IDU = frmlogin.IDU;
        Ketnoidulieu1 kn1 = new Ketnoidulieu1();

        private string GetIDP()
        {
            string idp = null;
            string sql = "select * from per_relationship where id_user ='" + IDU + "'";
            DataTable dt = new DataTable();
            dt = kn1.TaoBang(sql);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    idp = dr["id_per"].ToString();
                }

            }
            return idp;

        }

        public static string IDP = null;


        private void frmmain_Load(object sender, EventArgs e)
        {
            try
            {
                kn1.Myconn();
            }
            catch (Exception)
            {
                MessageBox.Show("Kết Nối CSDL lỗi");
                throw;
            }
            int idp = int.Parse(GetIDP());
            switch (idp)
            {
                case 1:
                    MNDanhMuc.Enabled = true;
                    break;

                default:
                    break;
            }
        }

        private void DMThuoc_Click(object sender, EventArgs e)
        {
            IDP = GetIDP();
            Form fr = new frmThuoc();
            this.Hide();
            fr.ShowDialog();
            this.Show();
        }

       
    }
}
