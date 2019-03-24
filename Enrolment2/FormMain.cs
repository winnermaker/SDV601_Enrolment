using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrolment2
{
    public partial class FormMain : Form
    {
        private ClsStudent _Student;
        private ClsStudent lcStudent;
        private FrmStudent _StudentForm = new FrmStudent();
        public FormMain()
        {
            InitializeComponent();
        }

        public ClsStudent LcStudent { get => lcStudent; set => lcStudent = value; }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreateStudent_Click(object sender, EventArgs e)
        {
            if(_Student != null)
            {
               lcStudent = _Student;
            }
            _Student = new ClsStudent();
            editStudent();
        }

        private void btnModStudent_Click(object sender, EventArgs e)
        {
            if (_Student != null)
            {
                editStudent();
            }
            else
            {
                if(MessageBox.Show("Would you like to create a new Student?", "Create new Student", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _Student = new ClsStudent();
                    editStudent();
                }                
            }
            
        }

        private void editStudent()
        {
            if (_Student != null && _StudentForm.ShowDialog(_Student) == DialogResult.OK)
            {
                lblStudent.Text = "Student:\n" + _Student.ToString();
            }
            else if(_StudentForm.DialogResult == DialogResult.Cancel)
            {
                _Student = lcStudent;
            }
        }
    }
}
