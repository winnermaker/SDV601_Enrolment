using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enrolment3
{
    class ClsMOEStudent : ClsStudent
    {
        private decimal _LoanAmount;
        private bool _FullTime;
        private static FrmMOEStudent _Form = new FrmMOEStudent();

        public decimal LoanAmount { get => _LoanAmount; set => _LoanAmount = value; }
        public bool FullTime { get => _FullTime; set => _FullTime = value; }

        public override string ToString()
        {            
            return base.ToString() +"\nLoan: " + LoanAmount.ToString() + "\nFull Time: "+ FullTime.ToString();
        }
        public override Boolean ViewEdit()
        {
            return Convert.ToBoolean(_Form.ShowDialog(this));
        }


    }
}
