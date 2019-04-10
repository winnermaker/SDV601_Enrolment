using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enrolment4
{
    [Serializable]
    class ClsMOEStudent : ClsStudent
    {
        private decimal _LoanAmount;
        private bool _FullTime;
        private static FrmMOEStudent _Form = new FrmMOEStudent();

        public decimal LoanAmount { get => _LoanAmount; set => _LoanAmount = value; }
        public bool FullTime { get => _FullTime; set => _FullTime = value; }
   
        public override Boolean ViewEdit()
        {
            return Convert.ToBoolean(_Form.ShowDialog(this));
        }
        public override string TypeOfStudent()
        {
            return "MOE";
        }

    }
}
