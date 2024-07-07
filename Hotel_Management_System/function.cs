using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    class function
    {
        protected SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-Q2A8B85\\SQLEXPRESS;Initial Catalog=Hotel_Management_System;Integrated Security=True";
            return conn;
        }

        public DataSet GetData(String query)    // Get data from databse
        {
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd); 
            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds;
        }

        public void setData(String query,String message)    // Insert delete Update
        {
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("'"+message+"'","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        
        public SqlDataReader getForCombo(String query)
        {
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd = new SqlCommand(query,conn);
            SqlDataReader sdr = cmd.ExecuteReader();

            return sdr;
        }
    }
}
