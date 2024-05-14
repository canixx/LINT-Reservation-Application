using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LintReservation.MODEL
{
    public class Reservations
    {
        #region Fields
        private int _ID;
        private int _TableID;
        private int _ClientID;
        private DateTime _Date;
        private int _ClientCount;
        private int _BillID;
        private int _CustomerID;
        private string _CustomerName;
        private string _CustomerSurname;
        private string _Description;
        #endregion

        #region Properties
        public int ID { get => _ID; set => _ID = value; }
        public int TableID { get => _TableID; set => _TableID = value; }
        public int ClientID { get => _ClientID; set => _ClientID = value; }
        public DateTime Date { get => _Date; set => _Date = value; }
        public int ClientCount { get => _ClientCount; set => _ClientCount = value; }
        public int BillID { get => _BillID; set => _BillID = value; }
        public int CustomerID { get => _CustomerID; set => _CustomerID = value; }
        public string CustomerName { get => _CustomerName; set => _CustomerName = value; }
        public string CustomerSurname { get => _CustomerSurname; set => _CustomerSurname = value; }
        public string Description { get => _Description; set => _Description = value; }
        #endregion
    }
}
