using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnNet001.Core
{
    class Dataset
    {
        private static Dataset data = null;

        internal static Dataset DaTa
        {
            get
            {
                if (data == null)
                {
                    data = new Dataset();
                }
                return data;
            }
            set => data = value;
        }

        SqlDataAdapter da = null;
        DataSet ds = null;
        string con = @"Data Source=DESKTOP-P47PEOK\SQLEXPRESS;Initial Catalog=DoAnNet;Integrated Security=True";
        public void getDataSet(DataGridView dgv, string query = "", string table = "")
        {
            SqlConnection conn = new SqlConnection(con);
            da = new SqlDataAdapter(query, conn); ;
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, table);
            dgv.DataSource = ds.Tables[table];
        }
        public void getDataColumn(DataGridView dgv, string query = "", string table = "", string display = "", string values = "", string column = "")
        {
            SqlConnection conn = new SqlConnection(con);
            conn.Open();
            da = new SqlDataAdapter(query, conn);
            ds = new DataSet();
            da.Fill(ds, table);          
            ((DataGridViewComboBoxColumn)dgv.Columns[column]).DataSource = ds.Tables[table];
            ((DataGridViewComboBoxColumn)dgv.Columns[column]).DisplayMember = display;
            ((DataGridViewComboBoxColumn)dgv.Columns[column]).ValueMember = values;         
        }
        public bool updates( string query="",string table = "")
        {
            SqlConnection conn = new SqlConnection(con);
            conn.Open();
            da = new SqlDataAdapter(query, conn); ;
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, table);
            da.Update(ds, table);
            conn.Close();
            return true;
        }
        public void runProcedure(string proc)
        {
            SqlConnection conn = new SqlConnection(con);
            conn.Open();
            var cmd = new SqlCommand(proc, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            var dap = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
        public DataTable GetData()
        {
            string query = "SELECT * FROM ThongKe ORDER BY Thang DESC";
            SqlConnection conn = new SqlConnection(con);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query,conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable report(string query)
        {
            SqlConnection conn = new SqlConnection(con);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
       
    }
}
