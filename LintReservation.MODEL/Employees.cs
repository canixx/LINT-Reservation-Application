using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LintReservation.MODEL
{
    public class Employees
    {
        General gnl = new General();
        #region Field
        private int EmployeeID;
        private int EmployeeDutyID;
        private string EmployeeName;
        private string EmployeeSurname;
        private string EmployeePassword;
        private string EmployeeUsername;
        private string _EmployeeNameandSurname;
        #endregion

        #region Properties
        public int EmployeeID1 { get => EmployeeID; set => EmployeeID = value; }
        public int EmployeeDutyID1 { get => EmployeeDutyID; set => EmployeeDutyID = value; }
        public string EmployeeName1 { get => EmployeeName; set => EmployeeName = value; }
        public string EmployeeSurname1 { get => EmployeeSurname; set => EmployeeSurname = value; }
        public string EmployeePassword1 { get => EmployeePassword; set => EmployeePassword = value; }
        public string EmployeeUsername1 { get => EmployeeUsername; set => EmployeeUsername = value; }
        public string EmployeeNameandSurname { get => _EmployeeNameandSurname; set => _EmployeeNameandSurname = value; }
        #endregion



        public override string ToString()
        {
            EmployeeNameandSurname = EmployeeName1 + " " + EmployeeSurname1;
            return EmployeeNameandSurname;
        }
    }
}
