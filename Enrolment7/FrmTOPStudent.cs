using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Enrolment7
{
    public partial class FrmTOPStudent : Enrolment7.FrmStudent
    {
        public FrmTOPStudent()
        {
            InitializeComponent();
        }

        protected override void UpdateDisplay()
        {
            base.UpdateDisplay();
            ClsTOPStudent lcStudent = (ClsTOPStudent)_Student;
            txtReferralAgency.Text = Convert.ToString(lcStudent.ReferralAgency);
        }

        protected override void PushData()
        {
            base.PushData();
            ClsTOPStudent lcStudent = (ClsTOPStudent)_Student;
            lcStudent.ReferralAgency = txtReferralAgency.Text;           
        }
    }
}
