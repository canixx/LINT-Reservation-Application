using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LintReservation.MODEL
{
   public class Bill
    {
        #region Fields
        private int _ID;
        private decimal _Amount;
        private DateTime _Date;
        private int _EmployeeId;
        private int _State;
        private int _TableId;
        #endregion

        #region Properties
        public int ID { get => _ID; set => _ID = value; }
        public decimal Amount { get => _Amount; set => _Amount = value; }
        public DateTime Date { get => _Date; set => _Date = value; }
        public int EmployeeId { get => _EmployeeId; set => _EmployeeId = value; }
        public int State { get => _State; set => _State = value; }
        public int TableId { get => _TableId; set => _TableId = value; } 
        #endregion
    }
}
