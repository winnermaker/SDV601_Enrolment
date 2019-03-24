using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enrolment2
{
    public class ClsStudent
    {
        private String _ID;
        private String _Name;
        private DateTime _DOB = DateTime.Today;
        private decimal _Balance;

        public string ID { get => _ID; set => _ID = value; }
        public string Name { get => _Name; set => _Name = value; }
        public DateTime DOB { get => _DOB; set => _DOB = value; }
        public decimal Balance { get => _Balance; set => _Balance = value; }

        public override string ToString()
        {
            return _ID + "\n" + _Name;
        }
    }
}
