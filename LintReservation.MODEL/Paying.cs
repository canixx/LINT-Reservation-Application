using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LintReservation.MODEL
{
    public class Paying
    {
        #region Fields
        private int _PayID;
        private int _BillID;
        private decimal _Subtotal;
        private decimal _Discount;
        private decimal _Kdvamount;
        private decimal _Total;
        private DateTime _Date;
        private int _CustomerID;
        #endregion

        #region Properties
        public int PayID { get => _PayID; set => _PayID = value; }
        public int BillID { get => _BillID; set => _BillID = value; }
        public decimal Subtotal { get => _Subtotal; set => _Subtotal = value; }
        public decimal Discount { get => _Discount; set => _Discount = value; }
        public decimal Kdvamount { get => _Kdvamount; set => _Kdvamount = value; }
        public decimal Total { get => _Total; set => _Total = value; }
        public DateTime Date { get => _Date; set => _Date = value; }
        public int CustomerID { get => _CustomerID; set => _CustomerID = value; } 
        #endregion
    }
}
