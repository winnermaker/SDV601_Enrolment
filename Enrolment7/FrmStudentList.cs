using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrolment7
{
    public partial class FrmStudentList : Form
    {        
        public FrmStudentList()
        {
            InitializeComponent();
            cboStudentType.DataSource = ClsStudent.StudentType;
            cboStudentType.SelectedIndex = 0;
        }      
        private void UpdateDisplay()
        {
            lstStudents.DataSource = null;
            lstStudents.DataSource = ClsInstitute.StudentList.Values.ToList<ClsStudent>();
        }

        private void btnCreateStudent_Click(object sender, EventArgs e)
        {
            ClsStudent lcStudent = ClsStudent.NewStudent(cboStudentType.SelectedIndex);
            if (lcStudent != null && lcStudent.ViewEdit())
            {
                ClsInstitute.StudentList.Add(lcStudent.ID, lcStudent);
                UpdateDisplay();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstStudents_DoubleClick(object sender, EventArgs e)
        {
            EditStudent();
        }

        private void btnModifyStudent_Click(object sender, EventArgs e)
        {
            EditStudent();
        }

        private void btnDltStudent_Click(object sender, EventArgs e)
        {
           ClsStudent lcStudent = (ClsStudent)lstStudents.SelectedItem;
            if (lcStudent != null && DialogResult.Yes == MessageBox.Show("Are you sure you want to delete the selected Student?", "Delete Student", MessageBoxButtons.YesNo))
            {
                ClsInstitute.StudentList.Remove(lcStudent.ID);
                UpdateDisplay();
            }
        }

        private void EditStudent()
        {
            ClsStudent lcStudent = (ClsStudent)lstStudents.SelectedItem;
            if (lcStudent != null && lcStudent.ViewEdit())
            {
                UpdateDisplay();
            }
        }

        private void btnFindStudent_Click(object sender, EventArgs e)
        {
            ClsStudent lcStudent;
            if (ClsInstitute.StudentList.TryGetValue(txtID.Text, out lcStudent))
            {
                lstStudents.SelectedItem = lcStudent;
            }
        }

        private void FrmStudentList_Load(object sender, EventArgs e)
        {
            UpdateDisplay();
        }
    }
}
