using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Enrolment6
{
    public partial class FrmInternationalStudent : Enrolment6.FrmStudent
    {
        public FrmInternationalStudent()
        {
            InitializeComponent();
        }

        protected override void UpdateDisplay()
        {
            base.UpdateDisplay();
            ClsInternationalStudent lcStudent = (ClsInternationalStudent)_Student;
            txtCountry.Text = lcStudent.Country;
            txtIELTS.Text = Convert.ToString(lcStudent.IELTSScore);            
        }

        protected override void PushData()
        {
            base.PushData();
            ClsInternationalStudent lcStudent = (ClsInternationalStudent)_Student;
            lcStudent.Country = txtCountry.Text;
            lcStudent.IELTSScore = Convert.ToSingle(txtIELTS.Text);
        }
    }
}
