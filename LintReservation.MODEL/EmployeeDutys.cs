using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LintReservation.MODEL
{
    public class EmployeeDutys
    {
        #region Fields
        private int ID;
        private int _DutyID;
        private string _DutyName;
        private string _Name;
        private string _Surname;
        private string __Username;

        #endregion

        #region Properties
        public int DutyID { get => _DutyID; set => _DutyID = value; }
        public string DutyName { get => _DutyName; set => _DutyName = value; }
        public int ID1 { get => ID; set => ID = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string Surname { get => _Surname; set => _Surname = value; }
        public string Username { get => __Username; set => __Username = value; }
        #endregion
        public override string ToString()
        {
            return DutyName;
        }
    }
}
