using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enrolment3
{
    class ClsTOPStudent : ClsStudent
    {
        private static FrmTOPStudent _Form = new FrmTOPStudent();
        private String _ReferralAgency;
        public string ReferralAgency { get => _ReferralAgency; set => _ReferralAgency = value; }

        public override string ToString()
        {
            return base.ToString() + "\nReferral Agency: " + ReferralAgency.ToString();
        }
        public override Boolean ViewEdit()
        {
            return Convert.ToBoolean(_Form.ShowDialog(this));
        }
    }
}
