using LintReservation.DAL;
using LintReservation.MODEL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LintReservation.BLL
{
    public class LintReservationBL : IDisposable
    {
        Helper hlp = new Helper();
        public bool PersonelHareketleriniKaydet(EmployeeActions ph)
        {
            int sonuc = 0;
            SqlParameter[] p = { new SqlParameter("@personelId", ph.EmployeeID), new SqlParameter("@islem", ph.Operation), new SqlParameter("@tarih", ph.Date) };
            sonuc = hlp.ExecuteNonQuery("Insert into tbl_employee_actions(EMPLOYEE_ID,PROCESS,DATE) Values (@personelId,@islem,@tarih)", p);

            return sonuc > 0;
        }

        public bool PersonelGirisKontrol(string password, int UserId)
        {
            SqlParameter[] p = { new SqlParameter("@Id", UserId), new SqlParameter("@password", password) };
            return hlp.ExucuteScalar("Select * from tbl_employees where ID=@Id and PASSWORD=@password", p);
        }
        public List<Employees> PersonelBilgileriniGetir()
        {
            List<Employees> lst = new List<Employees>();
            SqlDataReader dr = hlp.ExecuteReader("Select * from tbl_employees ", null);

            while (dr.Read())
            {
                lst.Add(new Employees { EmployeeID1 = Convert.ToInt32(dr["ID"]), EmployeeDutyID1 = Convert.ToInt32(dr["DUTY_ID"]), EmployeeName1 = Convert.ToString(dr["NAME"]), EmployeeSurname1 = Convert.ToString(dr["SURNAME"]), EmployeePassword1 = Convert.ToString(dr["PASSWORD"]), EmployeeUsername1 = Convert.ToString(dr["USERNAME"]), EmployeeNameandSurname = Convert.ToString(dr["NAME"]) + " " + Convert.ToString(dr["SURNAME"]) });
            }
            lst.Insert(0, new Employees { EmployeeNameandSurname = "Choose One" });
            dr.Close();
            return lst;
        }
        public List<Employees2> PersonelGorevleriniGetir()
        {
            SqlDataReader dr = hlp.ExecuteReader("Select * from tbl_employees", null);
            List<Employees2> lst = new List<Employees2>();
            while (dr.Read())
            {
                lst.Add(new Employees2 { EmployeeID1 = Convert.ToInt32(dr["ID"]), EmployeeDutyID1 = Convert.ToInt32(dr["DUTY_ID"]), EmployeeName1 = Convert.ToString(dr["NAME"]), EmployeeSurname1 = Convert.ToString(dr["SURNAME"]), EmployeePassword1 = Convert.ToString(dr["PASSWORD"]), EmployeeUsername1 = Convert.ToString(dr["USERNAME"]) });
            }
            dr.Close();
            return lst;
        }
        public List<Duty> DutyList()
        {
            SqlDataReader dr = hlp.ExecuteReader("select * from tbl_employee_dutys", null);
            List<Duty> lst = new List<Duty>();
            while (dr.Read())
            {
                lst.Add(new Duty { ID = Convert.ToInt32(dr["ID"]), DUTY = Convert.ToString(dr["DUTY"]) });
            }
            lst.Insert(0, new Duty { DUTY = "Make a Duty Selection" });
            dr.Close();
            return lst;
        }

        public void Dispose()
        {
            hlp.Dispose();
        }
    }
}
