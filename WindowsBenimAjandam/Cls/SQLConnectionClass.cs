using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsBenimAjandam.Cls
{
    class SQLConnectionClass
    {
        private static string SQLConnection = @"Server=(localdb)\MSSQLLocalDB; Database=AJANDA_DB; Trusted_Connection=true;";
        private static SqlConnection conn = new SqlConnection();
        private static SqlCommand com = new SqlCommand();
        private static SqlDataAdapter da = new SqlDataAdapter();
        public static SqlException SQLexception = null;

        public static void Bağlantı()
        {
            conn = new SqlConnection(SQLConnection);
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public static object Command(string Query)
        {
            SQLexception = null;
            object obje = null;
            com.Connection = conn;
            com.CommandText = Query;
            try
            {
                obje = com.ExecuteScalar();
            }
            catch(SqlException Ex)
            {
                SQLexception = Ex;
                MessageBox.Show(Ex.GetType().Name + " - " + Ex.Message);
            }
            return obje;
        }
        public static DataTable Table(string Query)
        {
            SQLexception = null;
            DataTable dt = new DataTable();
            com.Connection = conn;
            com.CommandText = Query;
            da.SelectCommand = com;
            try
            {
                da.Fill(dt);
            }
            catch(SqlException Ex)
            {
                SQLexception = Ex;
                MessageBox.Show(Ex.GetType().Name + " - " + Ex.Message);
            }
            return dt;
        }
    }
}
