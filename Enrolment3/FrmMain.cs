using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrolment3
{
    public partial class FrmMain : Form
    {
        private ClsStudent _Student;        
        private FrmStudent _StudentForm;
        private FrmStudent _MOEStudentForm = new FrmMOEStudent();
        private FrmStudent _IntStudentForm = new FrmInternationalStudent();
        private FrmStudent _TOPStundentForm = new FrmTOPStudent();
        private string[] _StudentType = { "MOE (local)", "TOP", "International"};

        public FrmMain()
        {
            InitializeComponent();
            cboStudentType.DataSource = _StudentType;
            cboStudentType.SelectedIndex = 0;
        }

        private void CreateStudent()
        {            
            if (cboStudentType.SelectedIndex == 0)
            {
                _StudentForm = _MOEStudentForm;
                _Student = new ClsMOEStudent();
            }
            else if (cboStudentType.SelectedIndex == 1)
            {
                _StudentForm = _TOPStundentForm;
                _Student = new ClsTOPStudent();
            }
            else
            {
                _StudentForm = _IntStudentForm;
                _Student = new ClsInternationalStudent();
            }            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreateStudent_Click(object sender, EventArgs e)
        {                      
            CreateStudent();
            EditStudent();    
        }

        private void btnModStudent_Click(object sender, EventArgs e)
        {
            if (_Student != null)
            {
                EditStudent();
            }
            else
            {
                if (MessageBox.Show("Would you like to create a new Student?", "Create new Student", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CreateStudent();
                    EditStudent();

                    if (_StudentForm.DialogResult == DialogResult.Cancel)
                    {
                        _Student = null;
                    }
                }
            }

        }

        private void EditStudent()
        {
            if (_Student != null && _StudentForm.ShowDialog(_Student) == DialogResult.OK)
            {                
                if (cboStudentType.SelectedIndex == 0)
                {
                    lblStudent.Text = "MOE Student:\n" + _Student.ToString();
                                     
                }
                else if (cboStudentType.SelectedIndex == 1)
                {
                    lblStudent.Text = "TOP Student:\n" + _Student.ToString();
                }
                else
                {           
                    lblStudent.Text = "International Student:\n" + _Student.ToString();
                }
            }           
        }       
    }
}