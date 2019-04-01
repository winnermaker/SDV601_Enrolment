using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enrolment3
{    
    public abstract class ClsStudent
    {
        private String _ID;
        private String _Name;
        private DateTime _DOB = DateTime.Today;
        private decimal _Balance;
        private static string[] _StudentType = { "MOE (local)", "TOP", "International"};
        
        public string ID { get => _ID; set => _ID = value; }
        public string Name { get => _Name; set => _Name = value; }
        public DateTime DOB { get => _DOB; set => _DOB = value; }
        public decimal Balance { get => _Balance; set => _Balance = value; }
        public static string[] StudentType { get => _StudentType; set => _StudentType = value; }

        public static ClsStudent NewStudent(int prChoice)
        {
            if (prChoice == 0)
                return new ClsMOEStudent();
            else if (prChoice == 1)
                return new ClsTOPStudent();
            else
                return new ClsInternationalStudent();
        }
        public abstract Boolean ViewEdit();

        public override string ToString()
        {
            return "ID: " +_ID + "\nName: " + _Name + "\nDOB: " + _DOB.ToShortDateString() + "\nBalance: " + _Balance;
        }
              
    }
}
