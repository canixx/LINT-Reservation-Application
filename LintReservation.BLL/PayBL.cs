using LintReservation.MODEL;
using LintReservation.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LintReservation.BLL
{
    public class PayBL
    {
        General gnl = new General();
        Helper hlp = new Helper();
        public bool FaturaKapama(Paying Fatura)
        {
            bool result = false;
            SqlParameter[] p = { new SqlParameter("@BILL_ID", Fatura.BillID), new SqlParameter("@PAYMENT_TYPE_ID", Fatura.PayID), new SqlParameter("@CUSTOMER_ID", Fatura.CustomerID), new SqlParameter("@SUBTOTAL", Fatura.Subtotal), new SqlParameter("@KDV_AMOUNT", Fatura.Kdvamount), new SqlParameter("@DISCOUNT", Fatura.Discount), new SqlParameter("@TOTAL_AMOUNT", Fatura.Total) };
            result = Convert.ToBoolean(hlp.ExecuteNonQuery("Insert into tbl_bill_payment(BILL_ID,PAYMENT_TYPE_ID,CUSTOMER_ID,SUBTOTAL,KDV_AMOUNT,DISCOUNT,TOTAL_AMOUNT) values (@BILL_ID,@PAYMENT_TYPE_ID,@CUSTOMER_ID,@SUBTOTAL,@KDV_AMOUNT,@DISCOUNT,@TOTAL_AMOUNT)", p));
            return result;

        }
        //Musterinin toplam harcamasını hesaplama
    }
}
