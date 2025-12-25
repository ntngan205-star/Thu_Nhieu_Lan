using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quán_lý_bán_thuốc
{
    public class Ketnoidulieu2
    {
        string strconn = "Data Source=LAPTOP-EMBN5V2V\\SQLEXPRESS;Initial Catalog=QuanLyBanThuoc;Integrated Security=True";
        public SqlConnection conn = null;
        public DataTable dt = null;

        public void Myconn()
        {
            if (conn == null) conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed) conn.Open();
        }

        public void Myclose()
        {
            if (conn != null || conn.State == ConnectionState.Open) conn.Close();
        }
        public DataTable TaoBang(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
