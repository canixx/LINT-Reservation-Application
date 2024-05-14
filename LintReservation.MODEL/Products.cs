using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LintReservation.MODEL
{
    public class Products
    {
        #region Fields
        private int _ID;
        private string _ProductName;
        private int _Amount;
        private int _ProductID;
        private int _Price;
        private decimal _Total;
        private int _CategoryID;
        private string _CategoryName;
        #endregion
        #region Properties
        public int ID { get => _ID; set => _ID = value; }
        public string ProductName { get => _ProductName; set => _ProductName = value; }
        public int Amount { get => _Amount; set => _Amount = value; }
        public int ProductID { get => _ProductID; set => _ProductID = value; }
        public int Price { get => _Price; set => _Price = value; }
        public decimal Total { get => _Total; set => _Total = value; }
        public int CategoryID { get => _CategoryID; set => _CategoryID = value; }
        public string CategoryName { get => _CategoryName; set => _CategoryName = value; }
        #endregion
    }
}
