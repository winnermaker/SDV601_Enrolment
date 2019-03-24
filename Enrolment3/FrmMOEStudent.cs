using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Enrolment3
{
    public partial class FrmMOEStudent : Enrolment3.FrmStudent
    {
        public FrmMOEStudent()
        {
            InitializeComponent();
        }
        protected override void UpdateDisplay()
        {
            base.UpdateDisplay();
            ClsMOEStudent lcStudent = (ClsMOEStudent)_Student;
            txtLoan.Text = Convert.ToString(lcStudent.LoanAmount);
            chkFullTime.Checked = lcStudent.FullTime;
        }

        protected override void PushData()
        {
            base.PushData();
            ClsMOEStudent lcStudent = (ClsMOEStudent)_Student;
            lcStudent.LoanAmount = Convert.ToDecimal(txtLoan.Text);
            lcStudent.FullTime = chkFullTime.Checked;
        }
    }
}
