using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrolment5
{
    public partial class FrmStudent : Form
    {
        protected ClsStudent _Student;
        public FrmStudent()
        {
            InitializeComponent();
        }
        public DialogResult ShowDialog(ClsStudent prStudent)
        {
            _Student = prStudent;
            UpdateDisplay();
            return ShowDialog();
        }
        protected virtual void UpdateDisplay()
        {
            txtID.Text = _Student.ID;
            txtName.Text = _Student.Name;
            dtpDOB.Value = _Student.DOB;
            txtBalance.Text = Convert.ToString(_Student.Balance);
            txtID.Enabled = String.IsNullOrEmpty(_Student.ID);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            PushData();
            DialogResult = DialogResult.OK;

        }

        protected virtual void PushData()
        {
            _Student.ID = txtID.Text;
            _Student.Name = txtName.Text;
            _Student.DOB = dtpDOB.Value;
            _Student.Balance = Convert.ToDecimal(txtBalance.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {            
            DialogResult = DialogResult.Cancel;
        }
    }
}
