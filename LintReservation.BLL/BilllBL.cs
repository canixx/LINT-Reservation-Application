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
    public class BilllBL
    {

        Helper hlp = new Helper();
        public int AdisyonBilgileriniGetir(int MasaId)
        {
            int adisyonid = 0;
            SqlParameter[] p = { new SqlParameter("@TABLE_ID", MasaId) };
            SqlDataReader dr = hlp.ExecuteReader("Select top 1 ID from tbl_bill Where TABLE_ID=@TABLE_ID Order by ID desc", p);
            while (dr.Read())
            {
                adisyonid = (int)dr["ID"];
            }
            dr.Close();
            return adisyonid;
        }
        public bool YeniAdisyon(Bill Bilgiler)
        {
            int sonuc = 0;
            SqlParameter[] p = { new SqlParameter("@EMPLOYEE_ID", Bilgiler.EmployeeId), new SqlParameter("@TABLE_ID", Bilgiler.TableId), new SqlParameter("@DATE", Bilgiler.Date), new SqlParameter("@STATUS", Bilgiler.State), };
            sonuc = hlp.ExecuteNonQuery("Insert into tbl_bill(EMPLOYEE_ID,TABLE_ID,DATE,STATUS) values (@EMPLOYEE_ID,@TABLE_ID,@DATE,@STATUS)", p);
            return sonuc > 0;

        }
        public void AdisyonKapama(int adisyonID, int durum)
        {
            SqlParameter[] p = { new SqlParameter("@BILL_ID", adisyonID), new SqlParameter("@STATUS", durum) };
            hlp.ExecuteNonQuery("Update tbl_bill set STATUS=@STATUS where ID=@BILL_ID", p);
        }
        public int RezervasyonAdisyonAcma(Bill Bilgiler)
        {
            int sonuc = 0;
            SqlParameter[] p = { new SqlParameter("@EMPLOYEE_ID", Bilgiler.EmployeeId), new SqlParameter("@TABLE_ID", Bilgiler.TableId), new SqlParameter("@DATE", Bilgiler.Date) };
            sonuc = hlp.ExecuteNonQuery("Insert into tbl_bill(DATE,EMPLOYEE_ID,TABLE_ID) values (@DATE,@EMPLOYEE_ID,@TABLE_ID);select scope_IDENTITY()", p);
            return sonuc;
        }
    }
}
