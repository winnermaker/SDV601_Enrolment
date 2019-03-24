using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enrolment3
{
    class ClsTOPStudent : ClsStudent
    {
        private String _ReferralAgency;
        public string ReferralAgency { get => _ReferralAgency; set => _ReferralAgency = value; }

        public override string ToString()
        {
            return base.ToString() + "\nReferral Agency: " + ReferralAgency.ToString();
        }
    }
}
