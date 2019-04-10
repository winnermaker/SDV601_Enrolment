﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enrolment4
{
    [Serializable]
    class ClsInternationalStudent : ClsStudent
    {
        private String _Country;
        private Single _IELTSScore;
        private static FrmInternationalStudent _Form = new FrmInternationalStudent();

        public float IELTSScore { get => _IELTSScore; set => _IELTSScore = value; }
        public string Country { get => _Country; set => _Country = value; }

        public override Boolean ViewEdit()
        {
            return Convert.ToBoolean(_Form.ShowDialog(this));
        }

        public override string TypeOfStudent()
        {
            return "intl.";
        }
    }
}
