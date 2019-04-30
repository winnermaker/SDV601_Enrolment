using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrolment7
{
    public partial class FrmMain : Form
    {
        private FrmStudentList StudentListForm = new FrmStudentList();
              
        public FrmMain()
        {
            InitializeComponent();
            try
            {
                ClsInstitute.Retrieve();
                lblStudent.Text = string.Format("{0} Student(s)\nTotal Balance: {1:C}",
                ClsInstitute.StudentList.Count, ClsInstitute.TotalBalance());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
   
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                ClsInstitute.Save();
            }            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Close();
        }

        private void btnManageStudent_Click(object sender, EventArgs e)
        {
            CultureInfo nz = CultureInfo.GetCultureInfo("en-NZ"); //Change currency Symble to $ instead of €

            StudentListForm.ShowDialog();
            lblStudent.Text = ClsInstitute.StudentList.Count + " Student(s)";           
            lblStudent.Text = string.Format(nz,"{0} Student(s)\nTotal Balance: {1:C}",
            ClsInstitute.StudentList.Count, ClsInstitute.TotalBalance());
        }
    }
}