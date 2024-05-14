using LintReservation.DAL;
using LintReservation.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LintReservation.BLL
{
    public class OrderBL
    {
        Helper hlp = new Helper();
        public List<Products> SiparisGetirmece(int AdisyonID)
        {
            List<Products> lst = new List<Products>();
            SqlParameter[] p = { new SqlParameter("@BILL_ID", AdisyonID) };
            SqlDataReader dr = hlp.ExecuteReader("Select PRODUCT_NAME,PRICE,tbl_sales.ID,PRODUCT_ID,tbl_sales.AMOUNT from tbl_sales Inner Join tbl_products on tbl_sales.PRODUCT_ID=tbl_products.ID WHERE BILL_ID=@BILL_ID", p);

            while (dr.Read())
            {
                lst.Add(new Products { ProductName = (dr["PRODUCT_NAME"].ToString()), Amount = Convert.ToInt32(dr["AMOUNT"]), ProductID = Convert.ToInt32(dr["PRODUCT_ID"]), Total = Convert.ToDecimal(dr["PRICE"]) * Convert.ToDecimal(dr["AMOUNT"]), ID = Convert.ToInt32((dr["ID"].ToString())) });
            }
            dr.Close();
            return lst;

        }
        public bool SiparisiSil(int satisid)
        {
            SqlParameter[] p = { new SqlParameter("@SalesID", satisid) };
            return hlp.ExecuteNonQuery("Delete from tbl_sales where ID=@SalesID", p) > 0;
        }

        public bool SiparisiKaydet(Order Bilgiler)
        {
            bool sonuc = false;
            SqlParameter[] p = { new SqlParameter("@BILL_ID", Bilgiler.BillID), new SqlParameter("@PRODUCT_ID", Bilgiler.ProductID), new SqlParameter("@TABLE_ID", Bilgiler.TableID), new SqlParameter("@AMOUNT", Bilgiler.Amount) };
            sonuc = Convert.ToBoolean(hlp.ExecuteNonQuery("Insert into tbl_sales(BILL_ID,PRODUCT_ID,TABLE_ID,AMOUNT) values (@BILL_ID,@PRODUCT_ID,@TABLE_ID,@AMOUNT)", p));
            return sonuc;

        }
    }
}
