using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LintReservation.MODEL
{
    public class Employees2
    {

        #region Field
        private int EmployeeID;
        private int EmployeeDutyID;
        private string EmployeeName;
        private string EmployeeSurname;
        private string EmployeePassword;
        private string EmployeeUsername;
        private string _DutyName;
        #endregion

        #region Properties
        public int EmployeeID1 { get => EmployeeID; set => EmployeeID = value; }
        public int EmployeeDutyID1 { get => EmployeeDutyID; set => EmployeeDutyID = value; }
        public string EmployeeName1 { get => EmployeeName; set => EmployeeName = value; }
        public string EmployeeSurname1 { get => EmployeeSurname; set => EmployeeSurname = value; }
        public string EmployeePassword1 { get => EmployeePassword; set => EmployeePassword = value; }
        public string EmployeeUsername1 { get => EmployeeUsername; set => EmployeeUsername = value; }
        public string DutyName { get => _DutyName; set => _DutyName = value; }
        #endregion


        public override string ToString()
        {
            return EmployeeName1;
        }
    }
}
