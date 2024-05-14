using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LintReservation.MODEL
{
    public class Tables
    {
        #region Fields
        private int _ID;
        private int _Capacity;
        private int _State;
        private int _Approvement;
        private string _TableInfo;
        #endregion

        #region Properties
        public int ID { get => _ID; set => _ID = value; }
        public int Capacity { get => _Capacity; set => _Capacity = value; }
        public int State { get => _State; set => _State = value; }
        public int Approvement { get => _Approvement; set => _Approvement = value; }
        public string TableInfo { get => _TableInfo; set => _TableInfo = value; }
        #endregion
        public override string ToString()
        {
            TableInfo = "Table No:" + ID + ":" + "Its Capacity:" + Capacity + ":";
            return TableInfo;
        }


    }
}
