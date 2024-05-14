using LintReservation.DAL;
using LintReservation.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LintReservation.BLL
{
    public class ReservationBL
    {
        Helper hlp = new Helper();
        //MusteriID masa numarasına göre

        public int MusteriIDBulRezerve(int MasaId)
        {
            int adisyonid = 0;
            SqlParameter[] p = { new SqlParameter("@TABLE_ID", MasaId) };
            SqlDataReader dr = hlp.ExecuteReader("Select top 1 CUSTOMERS_ID from tbl_reservations Where TABLE_ID=@TABLE_ID Order by CUSTOMERS_ID desc", p);
            while (dr.Read())
            {
                adisyonid = (int)dr["CUSTOMERS_ID"];
            }
            dr.Close();
            return adisyonid;
        }
        //Rezervasyon kapatma

        public bool RezervasyonKapat(int adisyonID)
        {
            SqlParameter[] p = { new SqlParameter("@BILL_ID", adisyonID-1) };
            return hlp.ExecuteNonQuery("Delete from tbl_reservations Where BILL_ID=@BILL_ID", p) > 0;
        }
        public bool RezervasyonAcikMiKontrol(int MusterID)
        {
            bool result = false;
            SqlParameter[] p = { new SqlParameter("@CUSTOMERS_ID", MusterID) };
            SqlDataReader dr = hlp.ExecuteReader("Select top 1 ID from tbl_reservations Where CUSTOMERS_ID=@CUSTOMERS_ID and STATE=1 Order by ID desc", p);
            while (dr.Read())
            {
                result = Convert.ToBoolean(dr["ID"]);
            }
            dr.Close();
            return result;
        }
        public bool RezervasyonAc(Reservations rezerve)
        {
            bool result = false;
            SqlParameter[] p = { new SqlParameter("@CUSTOMERS_ID", rezerve.CustomerID), new SqlParameter("@TABLE_ID", rezerve.TableID), new SqlParameter("@BILL_ID", rezerve.BillID), new SqlParameter("@CUSTOMER_NUMBER", rezerve.ClientCount), new SqlParameter("@DATE", rezerve.Date), new SqlParameter("@DESCRIPTION", rezerve.Description) };
            result = Convert.ToBoolean(hlp.ExecuteNonQuery("insert into tbl_reservations(CUSTOMERS_ID,TABLE_ID,BILL_ID,CUSTOMER_NUMBER,DATE,DESCRIPTION,STATE) values(@CUSTOMERS_ID,@TABLE_ID,@BILL_ID,@CUSTOMER_NUMBER,@DATE,@DESCRIPTION ,1)", p));
            return result;
        }
    }

}
