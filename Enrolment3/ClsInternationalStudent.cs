using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enrolment3
{
    class ClsInternationalStudent : ClsStudent
    {
        private String _Country;
        private Single _IELTSScore;

        public float IELTSScore { get => _IELTSScore; set => _IELTSScore = value; }
        public string Country { get => _Country; set => _Country = value; }

        public override string ToString()
        {
            return base.ToString() + "\nCountry: " + Country + "\nIELTS Score: " + IELTSScore.ToString();
        }
        
    }
}
