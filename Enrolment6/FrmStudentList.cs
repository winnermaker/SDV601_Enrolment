using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrolment6
{
    public partial class FrmStudentList : Form
    {
        private const string fileName = "student.xml";
        public FrmStudentList()
        {
            InitializeComponent();
            cboStudentType.DataSource = ClsStudent.StudentType;
            cboStudentType.SelectedIndex = 0;
            //Retrieve();
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
            //Save();
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

        /*private void Save()
       {
           try
           {
               System.IO.FileStream lcFileStream = new System.IO.FileStream(fileName, System.IO.FileMode.Create);
               System.Runtime.Serialization.Formatters.Binary.BinaryFormatter lcFormatter =
                   new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

               lcFormatter.Serialize(lcFileStream, ClsInstitute.StudentList);
               lcFileStream.Close();
           }
           catch (Exception e)
           {
               MessageBox.Show(e.Message, "File Save Error");
           }
       }

      private void Retrieve()
       {
           try
           {
               System.IO.FileStream lcFileStream = new System.IO.FileStream(fileName, System.IO.FileMode.Open);
               System.Runtime.Serialization.Formatters.Binary.BinaryFormatter lcFormatter =
                   new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
               ClsInstitute.StudentList.AddRange((List < ClsStudent >) lcFormatter.Deserialize(lcFileStream));

               UpdateDisplay();
               lcFileStream.Close();
           }

           catch (Exception e)
           {
               MessageBox.Show(e.Message, "File Retrieve Error");
           }
       }*/

        private void btnFindStudent_Click(object sender, EventArgs e)
        {
            ClsStudent lcStudent;
            if (ClsInstitute.StudentList.TryGetValue(txtID.Text, out lcStudent))
            {
                lstStudents.SelectedItem = lcStudent;
            }
        }
    }
}
