using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LintReservation.MODEL
{
    public class Customers
    {
        #region Fields
        private int _CustomerID;
        private string _CustomerName;
        private string _CustomerSurname;
        private string _Phone;
        private string _Address;
        private string _Email;
        #endregion

        #region Properties
        public int CustomerID { get => _CustomerID; set => _CustomerID = value; }
        public string CustomerName { get => _CustomerName; set => _CustomerName = value; }
        public string CustomerSurname { get => _CustomerSurname; set => _CustomerSurname = value; }
        public string Phone { get => _Phone; set => _Phone = value; }
        public string Address { get => _Address; set => _Address = value; }
        public string Email { get => _Email; set => _Email = value; } 
        #endregion
    }
}
