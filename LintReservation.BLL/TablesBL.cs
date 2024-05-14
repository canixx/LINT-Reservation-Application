using LintReservation.DAL;
using LintReservation.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace LintReservation.BLL
{
    public class TablesBL

    {
        Helper hlp = new Helper();

        public int MasaSayisiBul()
        {
            int sayi = 0;
            SqlParameter[] p = { new SqlParameter("@ID", sayi) };
            SqlDataReader dr = hlp.ExecuteReader("Select ID from tbl_tables", p);
            while (dr.Read())
            {
                sayi = (int)dr["ID"];
            }
            dr.Close();
            return sayi;
        }
        public int MasaIDGetir()
        {
            int tableid = 0;
            SqlDataReader dr = hlp.ExecuteReader("Select ID from tbl_tables ", null);
            while (dr.Read())
            {
                tableid = (int)dr["ID"];
            }
            dr.Close();
            return tableid;
        }
        public int DurumGetir(int id)
        {
            int result = 0;
            SqlParameter[] p = { new SqlParameter("@ID", id) };
            SqlDataReader dr = hlp.ExecuteReader("Select ID,RES_STATUS from tbl_tables where ID=@ID", p);
            while (dr.Read())
            {
                result = (int)dr["RES_STATUS"];
            }
            dr.Close();
            return result;
        }
        public int TableGetByNumber(string TableValue)
        {
            string aa = TableValue;
            int length = aa.Length;
            if (length > 8)
            {
                return Convert.ToInt32(aa.Substring(length - 2, 2));
            }
            else
            {
                return Convert.ToInt32(aa.Substring(length - 1, 1));
            }

        }
        public bool TableGetByState(int ButtonName, int state)
        {
            SqlParameter[] p = { new SqlParameter("@tableId", ButtonName), new SqlParameter("@state", state) };
            return hlp.ExucuteScalar("Select RES_STATUS from tbl_tables WHERE ID=@tableId and RES_STATUS=@state", p);
        }
        public void TabloDurumunuDegistir(string ButtonName, int state)
        {
            string masano = "";
            string aa = ButtonName;
            int uzunluk = aa.Length;
            if (uzunluk > 8)
            {
                masano = aa.Substring(uzunluk - 2, 2);
            }
            else
            {
                masano = aa.Substring(uzunluk - 1, 1);
            }
            SqlParameter[] p = { new SqlParameter("@RES_STATUS", state), new SqlParameter("@table_ID", masano) };
            hlp.ExecuteNonQuery("Update tbl_tables set RES_STATUS=@RES_STATUS where ID=@table_ID", p);
        }
        public List<Tables> MasalarıGetir()
        {
            List<Tables> lst = new List<Tables>();
            SqlDataReader dr = hlp.ExecuteReader("Select * from tbl_tables ", null);

            while (dr.Read())
            {
                lst.Add(new Tables { ID = Convert.ToInt32(dr["ID"]), State = Convert.ToInt32((dr["RES_STATUS"])), Capacity = Convert.ToInt32((dr["CAPACITY"])), TableInfo = "Masa No:" + Convert.ToInt32(dr["ID"]) + ":" + "Kapasitesi:" + Convert.ToInt32((dr["CAPACITY"])) + ":" });
            }
            lst.Insert(0, new Tables { TableInfo = "Choose One" });
            dr.Close();
            return lst;
        }

    }
}
