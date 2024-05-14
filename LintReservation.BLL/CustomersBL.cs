using LintReservation.DAL;
using LintReservation.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LintReservation.BLL
{
    public class CustomersBL
    {
        Helper hlp = new Helper();

        public int MusteriEkle(Customers musteri)
        {
            int sonuc = 0;
            SqlParameter[] p = { new SqlParameter("@NAME", musteri.CustomerName), new SqlParameter("@SURNAME", musteri.CustomerSurname), new SqlParameter("@PHONE", musteri.Phone), new SqlParameter("@ADDRESS", musteri.Address), new SqlParameter("@EMAIL", musteri.Email) };
            sonuc = hlp.ExecuteNonQuery("Insert into tbl_customers(NAME,SURNAME,PHONE,ADDRESS,EMAIL) values (@NAME,@SURNAME,@PHONE,@ADDRESS,@EMAIL)", p);
            return sonuc;
        }

        public DataTable MusteriListele()
        {
            return hlp.MyDataTable("Select * from tbl_customers");
        }
        public bool MusteriSil(int ID)
        {
            SqlParameter[] p = { new SqlParameter("@CustomerID", ID) };
            return hlp.ExecuteNonQuery("Delete from tbl_customers Where ID=@CustomerID", p) > 0;
        }
        public bool MusteriGuncelle(Customers m)
        {
            int sonuc = 0;
            SqlParameter[] p = { new SqlParameter("@ID", m.CustomerID), new SqlParameter("@NAME", m.CustomerName), new SqlParameter("@SURNAME", m.CustomerSurname), new SqlParameter("@PHONE", m.Phone), new SqlParameter("@ADDRESS", m.Address), new SqlParameter("@EMAIL", m.Email) };

            sonuc = hlp.ExecuteNonQuery("UPDATE tbl_customers SET NAME=@NAME,SURNAME=@SURNAME,PHONE=@PHONE,ADDRESS=@ADDRESS,EMAIL=@EMAIL WHERE ID=@ID", p);

            return sonuc > 0;
        }

        public List<Customers> MüsterileriListelemece()
        {
            List<Customers> lst = new List<Customers>();
            SqlDataReader dr = hlp.ExecuteReader("Select * from tbl_customers", null);

            while (dr.Read())
            {
                lst.Add(new Customers { CustomerID = Convert.ToInt32((dr["ID"]).ToString()), CustomerName = (dr["NAME"].ToString()), CustomerSurname = (dr["SURNAME"].ToString()), Address = (dr["ADDRESS"].ToString()), Phone = ((dr["PHONE"].ToString())), Email = ((dr["EMAIL"].ToString())) });
            }
            dr.Close();
            return lst;

        }

    }
}
