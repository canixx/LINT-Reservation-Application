using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LintReservation.MODEL
{
    public class Duty
    {
        private int _ID;
        private string _DUTY;
        public int ID { get => _ID; set => _ID = value; }
        public string DUTY { get => _DUTY; set => _DUTY = value; }
    }
}
