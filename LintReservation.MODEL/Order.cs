using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LintReservation.MODEL
{
    public class Order
    {
        #region Fields
        private int _ID;
        private int _BillID;
        private int _ProductID;
        private int _Amount;
        private int _TableID;

        #endregion
        #region Properties
        public int ID { get => _ID; set => _ID = value; }
        public int BillID { get => _BillID; set => _BillID = value; }
        public int ProductID { get => _ProductID; set => _ProductID = value; }
        public int Amount { get => _Amount; set => _Amount = value; }
        public int TableID { get => _TableID; set => _TableID = value; } 
        #endregion
    }
}
