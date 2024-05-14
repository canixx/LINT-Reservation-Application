using LintReservation.DAL;
using LintReservation.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LintReservation.BLL
{
    public class ProductCategoriesBL
    {
        Helper hlp = new Helper();

        public List<ProductCategories> UruncesitleriGetrirmece(string btnName)
        {
            List<ProductCategories> lst = new List<ProductCategories>();
            int uzunluk = btnName.Length;
            SqlParameter[] p = { new SqlParameter("@CATEGORY_ID", btnName.Substring(uzunluk - 1, 1)) };
            SqlDataReader dr = hlp.ExecuteReader("Select PRODUCT_NAME,PRICE,tbl_products.ID from tbl_categories Inner Join tbl_products on tbl_categories.ID=tbl_products.CATEGORY_ID where tbl_products.CATEGORY_ID=@CATEGORY_ID", p);
            while (dr.Read())
            {
                lst.Add(new ProductCategories { ProductName = (dr["PRODUCT_NAME"].ToString()), Price = Convert.ToInt32(dr["PRICE"]), ID = Convert.ToInt32(dr["ID"]) });
            }
            dr.Close();
            return lst;

        }
        public List<ProductCategories> UruncesitleriAramaca(int txt)
        {
            List<ProductCategories> lst = new List<ProductCategories>();
            SqlParameter[] p = { new SqlParameter("@ID", txt) };
            SqlDataReader dr = hlp.ExecuteReader("Select * from tbl_products where ID=@ID", p);
            while (dr.Read())
            {
                lst.Add(new ProductCategories { ProductName = (dr["PRODUCT_NAME"].ToString()), Price = Convert.ToInt32(dr["PRICE"]), ID = Convert.ToInt32(dr["ID"]) });
            }
            dr.Close();
            return lst;

        }

    }
}
