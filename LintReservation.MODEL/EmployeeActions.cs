using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LintReservation.MODEL
{
    public class EmployeeActions
    {
       
        #region Fields
        private int _ID;
        private int _EmployeeID;
        private string _Operation;
        private DateTime _Date;
        private bool _State;
        #endregion

        #region Properties
        public int ID { get => _ID; set => _ID = value; }
        public int EmployeeID { get => _EmployeeID; set => _EmployeeID = value; }
        public string Operation { get => _Operation; set => _Operation = value; }
        public DateTime Date { get => _Date; set => _Date = value; }
        public bool State { get => _State; set => _State = value; }
        #endregion

       
    }
}
