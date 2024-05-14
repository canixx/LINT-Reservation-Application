
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
    public class EmployeeBL
    {
        Helper hlp = new Helper();

        public List<EmployeeDutys> PersonelBilgileriniGetir()
        {
            List<EmployeeDutys> lst = new List<EmployeeDutys>();
            SqlDataReader dr = hlp.ExecuteReader("Select p.*,pg.DUTY from tbl_employees as p Inner Join tbl_employee_dutys as pg on p.DUTY_ID=pg.ID ", null);

            while (dr.Read())
            {
                lst.Add(new EmployeeDutys { ID1 = Convert.ToInt32(dr["ID"]), DutyID = Convert.ToInt32(dr["DUTY_ID"]), DutyName = (dr["DUTY"]).ToString(), Name = (dr["NAME"]).ToString(), Surname = (dr["SURNAME"].ToString()), Username = (dr["USERNAME"]).ToString() });
            }
            dr.Close();
            return lst;

        }
        public List<EmployeeDutys> PersonelGorevleriniGetir()
        {
            SqlDataReader dr = hlp.ExecuteReader("Select * from tbl_employee_dutys", null);
            List<EmployeeDutys> lst = new List<EmployeeDutys>();
            while (dr.Read())
            {
                lst.Add(new EmployeeDutys { DutyID = Convert.ToInt32(dr["ID"]), DutyName = dr["DUTY"].ToString() });
            }
            dr.Close();
            return lst;
        }
        public string PersonelGorevTanım(int perid)
        {
            string sonuc = "";
            SqlParameter[] p = { new SqlParameter("@ID", perid) };
            SqlDataReader dr = hlp.ExecuteReader("Select DUTY from tbl_employee_dutys where ID=@Id", p);
            while (dr.Read())
            {
                sonuc = dr["DUTY"].ToString();
            }
            dr.Close();
            return sonuc;
        }
        public string PersonelisminiGetir(int personelID)
        {
            string sonuc = "";
            SqlParameter[] p = { new SqlParameter("@ID", personelID) };
            SqlDataReader dr = hlp.ExecuteReader("Select NAME from tbl_employees where ID=@ID ", p);
            while (dr.Read())
            {
                sonuc = dr["NAME"].ToString();
            }
            dr.Close();
            return sonuc;

        }
        public bool PersonelSifreDegistir(int personelID, int pass)
        {
            bool sonuc = false;
            SqlParameter[] p = { new SqlParameter("@ID", personelID), new SqlParameter("@Pass", pass) };
            sonuc = Convert.ToBoolean(hlp.ExecuteNonQuery("Update tbl_employees set PASSWORD=@Pass where ID=@ID", p));
            return sonuc;

        }
        public bool PersonelEkle(Employees2 pe)
        {
            bool sonuc = false;
            SqlParameter[] p = { new SqlParameter("@NAME", pe.EmployeeName1), new SqlParameter("@SURNAME", pe.EmployeeSurname1), new SqlParameter("@USERNAME", pe.EmployeeUsername1), new SqlParameter("@PASSWORD", pe.EmployeePassword1), new SqlParameter("@DUTY_ID", pe.EmployeeDutyID1) };
            sonuc = Convert.ToBoolean(hlp.ExecuteNonQuery("Insert into tbl_employees(NAME,SURNAME,USERNAME,PASSWORD,DUTY_ID) values (@NAME,@SURNAME,@USERNAME,@PASSWORD,@DUTY_ID)", p));
            return sonuc;

        }
        public bool PersonelGuncelle(Employees2 pe, int ID)
        {
            bool sonuc = false;
            SqlParameter[] p = { new SqlParameter("@ID", ID), new SqlParameter("@NAME", pe.EmployeeName1), new SqlParameter("@SURNAME", pe.EmployeeSurname1), new SqlParameter("@USERNAME", pe.EmployeeUsername1), new SqlParameter("@PASSWORD", pe.EmployeePassword1), new SqlParameter("@DUTY_ID", pe.EmployeeDutyID1) };
            sonuc = Convert.ToBoolean(hlp.ExecuteNonQuery("Update tbl_employees set NAME=@NAME,SURNAME=@SURNAME,USERNAME=@USERNAME,PASSWORD=@PASSWORD,DUTY_ID=@DUTY_ID where ID=@ID ", p));
            return sonuc;

        }
        public bool PersonelSil(int ID)
        {
            SqlParameter[] p = { new SqlParameter("@ID", ID) };
            return hlp.ExecuteNonQuery("Delete from tbl_employees Where ID=@ID", p) > 0;
        }
        public bool PersonelSilmekİçinGerekli(int ID)
        {
            SqlParameter[] p = { new SqlParameter("@ID", ID) };
            return hlp.ExecuteNonQuery("Delete from tbl_employee_actions Where EMPLOYEE_ID=@ID", p) > 0;
        }
        public int txtIDyazdırma(string ad)
        {
            int result = 0;
            SqlParameter[] p = { new SqlParameter("@NAME", ad) };
            SqlDataReader dr = hlp.ExecuteReader("Select ID from tbl_employees where NAME=@NAME", p);
            while (dr.Read())
            {
                result = (int)dr["ID"];
            }
            dr.Close();
            return result;
        }
        public int txtIDyazdırmaforGorev(string ad)
        {
            int result = 0;
            SqlParameter[] p = { new SqlParameter("@NAME", ad) };
            SqlDataReader dr = hlp.ExecuteReader("Select ID from tbl_employee_dutys where DUTY=@NAME", p);
            while (dr.Read())
            {
                result = (int)dr["ID"];
            }
            dr.Close();
            return result;
        }

    }
}
