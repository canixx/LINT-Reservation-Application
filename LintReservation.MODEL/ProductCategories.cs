using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LintReservation.MODEL
{
    public class ProductCategories
    {
        #region Fields
        private int _ProductCategoryID;
        private string _CategoryName;
        private string _ProductName;
        private int _Price;
        private int _ID;
        #endregion

        #region Properties
        public int ProductCategoryID { get => _ProductCategoryID; set => _ProductCategoryID = value; }
        public string CategoryName { get => _CategoryName; set => _CategoryName = value; }
        public string ProductName { get => _ProductName; set => _ProductName = value; }
        public int Price { get => _Price; set => _Price = value; }
        public int ID { get => _ID; set => _ID = value; }
        #endregion
        public override string ToString()
        {
            return CategoryName;
        }
    }
}
