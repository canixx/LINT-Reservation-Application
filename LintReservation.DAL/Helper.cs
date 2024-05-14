using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace LintReservation.DAL
{//DAL -> DATA ACCESS LAYER
    public class Helper:IDisposable
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString);
        SqlCommand cmd = null;
        public int ExecuteNonQuery(string cmdtext, SqlParameter[] p)
        {
            int sonuc = 0;
            cmd = new SqlCommand(cmdtext, cn);
            if (p != null)
            {
                cmd.Parameters.AddRange(p);
            }

            OpenConnection();
            sonuc = cmd.ExecuteNonQuery();         
            return sonuc;
        }
        public DataTable MyDataTable(string cmdtext)
        {
            SqlDataAdapter da = new SqlDataAdapter(cmdtext, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public SqlDataReader ExecuteReader(string cmdtext, SqlParameter[] p)
        {         
            //SqlCommand cmd = new SqlCommand(cmdtext, cn);
            cmd = new SqlCommand(cmdtext, cn);
            if (p != null)
            {
                cmd.Parameters.AddRange(p);
            }

            OpenConnection();
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        public bool ExucuteScalar(string cmdtext, SqlParameter[] p) 
        {
            bool result = true;
            cmd = new SqlCommand(cmdtext, cn);
            if (p != null)
            {
                cmd.Parameters.AddRange(p);
            }

            OpenConnection();
            result = Convert.ToBoolean(cmd.ExecuteScalar());//


            return result;
        }
      
       
        public void OpenConnection()
        {
            try
            {
                if (cn != null && cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void CloseConnection()
        {
            try
            {
                if (cn != null && cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Dispose()
        {
            if (cn!=null && cmd!=null)
            {
                cn.Dispose();
                cmd.Dispose();
            }         
        }
    }
}
