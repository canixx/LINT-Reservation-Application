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
    public class ProductsBL
    {
        Helper hlp = new Helper();
        ProductCategories ubl = new ProductCategories();
        public List<Products> UrunleriListeleWUrunAdi(string UrunAdi)
        {
            List<Products> lst = new List<Products>();
            SqlParameter[] p = { new SqlParameter("@PRODUCT_NAME", UrunAdi) };
            SqlDataReader dr = hlp.ExecuteReader("Select u.ID,u.CATEGORY_ID,k.CATEGORY_NAME,u.PRODUCT_NAME,u.PRICE from tbl_products as u inner join tbl_categories as k on k.ID=u.CATEGORY_ID where PRODUCT_NAME like +@PRODUCT_NAME+'%'", p);

            while (dr.Read())
            {
                lst.Add(new Products { ID = Convert.ToInt32((dr["ID"])), CategoryID = Convert.ToInt32((dr["CATEGORY_ID"])), CategoryName = (dr["CATEGORY_NAME"].ToString()), ProductName = (dr["PRODUCT_NAME"].ToString()), Price = Convert.ToInt32((dr["PRICE"])) });
            }
            dr.Close();
            return lst;

        }
        public int UrunEkle(Products urun)
        {
            int sonuc = 0;
            SqlParameter[] p = { new SqlParameter("@PRODUCT_NAME", urun.ProductName), new SqlParameter("@CATEGORY_ID", urun.CategoryID), new SqlParameter("@PRICE", urun.Price) };
            sonuc = hlp.ExecuteNonQuery("Insert into tbl_products(PRODUCT_NAME,CATEGORY_ID,PRICE) values (@PRODUCT_NAME,@CATEGORY_ID,@PRICE)", p);
            return sonuc;
        }
        public List<Products> UrunleriListele()
        {
            List<Products> lst = new List<Products>();
            SqlDataReader dr = hlp.ExecuteReader("Select u.ID,u.CATEGORY_ID,k.CATEGORY_NAME,u.PRODUCT_NAME,u.PRICE from tbl_products as u inner join tbl_categories as k on k.ID=u.CATEGORY_ID", null);

            while (dr.Read())
            {
                lst.Add(new Products { ID = Convert.ToInt32((dr["ID"])), CategoryID = Convert.ToInt32((dr["CATEGORY_ID"])), CategoryName = (dr["CATEGORY_NAME"].ToString()), ProductName = (dr["PRODUCT_NAME"].ToString()), Price = Convert.ToInt32((dr["PRICE"])) });
            }
            dr.Close();
            return lst;

        }
        public bool UrunSil(int ID)
        {
            SqlParameter[] p = { new SqlParameter("@Product_ID", ID) };
            return hlp.ExecuteNonQuery("Delete from tbl_products Where ID=@Product_ID", p) > 0;
        }
        public bool UrunSilmekİcinGerekli(int ID)
        {
            SqlParameter[] p = { new SqlParameter("@PRODUCT_ID", ID) };
            return hlp.ExecuteNonQuery("Delete from tbl_sales Where PRODUCT_ID=@PRODUCT_ID", p) > 0;
        }
        public bool UrunGüncelle(Products urun)
        {
            bool sonuc = false;
            SqlParameter[] p = { new SqlParameter("@PRODUCT_NAME", urun.ProductName), new SqlParameter("@CATEGORY_ID", urun.CategoryID), new SqlParameter("@PRICE", urun.Price), new SqlParameter("@Product_ID", urun.ID) };
            sonuc = Convert.ToBoolean(hlp.ExecuteNonQuery("UPDATE tbl_products SET PRODUCT_NAME=@PRODUCT_NAME,CATEGORY_ID=@CATEGORY_ID,PRICE=@PRICE WHERE ID=@Product_ID", p));
            return sonuc;
        }
        public List<ProductCategories> UrunCesitleriniGetir()
        {
            List<ProductCategories> lst = new List<ProductCategories>();
            SqlDataReader dr = hlp.ExecuteReader("Select * from tbl_categories ", null);

            while (dr.Read())
            {
                lst.Add(new ProductCategories { ProductCategoryID = Convert.ToInt32(dr["ID"]), CategoryName = (dr["CATEGORY_NAME"]).ToString() });
            }
            dr.Close();
            lst.Insert(0, new ProductCategories { CategoryName = "Choose One" });
            return lst;
        }
        public int txtIDyazdırma(string ad)
        {
            int result = 0;
            SqlParameter[] p = { new SqlParameter("@CATEGORY_NAME", ad) };
            SqlDataReader dr = hlp.ExecuteReader("Select ID from tbl_categories where CATEGORY_NAME=@CATEGORY_NAME", p);
            while (dr.Read())
            {
                result = (int)dr["ID"];
            }
            dr.Close();
            return result;
        }
        public List<Products> UrunListeleIstatistiklereGorewUrunID(string baslangic, string bitis, int KategoriID)
        {
            List<Products> lst = new List<Products>();
            SqlParameter[] p = { new SqlParameter("@Baslangic", baslangic), new SqlParameter("@Bitis", bitis), new SqlParameter("@KategoriID", KategoriID) };
            SqlDataReader dr = hlp.ExecuteReader("select top 10 dbo.tbl_products.PRODUCT_NAME,sum(dbo.tbl_sales.AMOUNT) as Adeti From dbo.tbl_categories inner join dbo.tbl_products on dbo.tbl_categories.ID=dbo.tbl_products.CATEGORY_ID inner join dbo.tbl_sales on dbo.tbl_products.ID=dbo.tbl_sales.PRODUCT_ID inner join dbo.tbl_bill on dbo.tbl_sales.BILL_ID=dbo.tbl_bill.ID where (CONVERT(datetime,DATE,104) between CONVERT( datetime,@Baslangic,104) and CONVERT(datetime,@Bitis,104)) and(dbo.tbl_products.CATEGORY_ID=@KategoriID) group by dbo.tbl_products.PRODUCT_NAME order by Adeti desc", p);
            while (dr.Read())
            {
                lst.Add(new Products { ProductName = (dr["PRODUCT_NAME"]).ToString(), Amount = Convert.ToInt32((dr["Adeti"])) });
            }
            dr.Close();
            return lst;
        }
        public List<Products> UrunListeleIstatistiklereGore(string baslangic, string bitis)
        {
            List<Products> lst = new List<Products>();
            SqlParameter[] p = { new SqlParameter("@Baslangic", baslangic), new SqlParameter("@Bitis", bitis) };
            SqlDataReader dr = hlp.ExecuteReader("select top 10 dbo.tbl_products.PRODUCT_NAME,sum(dbo.tbl_sales.AMOUNT) as Adeti From dbo.tbl_categories inner join dbo.tbl_products on dbo.tbl_categories.ID=dbo.tbl_products.CATEGORY_ID inner join dbo.tbl_sales on dbo.tbl_products.ID=dbo.tbl_sales.PRODUCT_ID inner join dbo.tbl_bill on dbo.tbl_sales.BILL_ID=dbo.tbl_bill.ID where (CONVERT(datetime,DATE,104) between CONVERT( datetime,@Baslangic,104) and CONVERT(datetime,@Bitis,104)) group by dbo.tbl_products.PRODUCT_NAME order by Adeti desc", p);
            while (dr.Read())
            {
                lst.Add(new Products { ProductName = (dr["PRODUCT_NAME"]).ToString(), Amount = Convert.ToInt32((dr["Adeti"])) });
            }
            dr.Close();
            return lst;
        }
    }
}
