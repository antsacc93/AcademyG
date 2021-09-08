using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week1.Esercitazione3.Companies
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime HiringDate { get; set; }
        public int ProductivityRate { get; set; }
        public int AbsenceRate { get; set; }

        public int Age { get { return DateTime.Today.Year - DateOfBirth.Year; }  }

        public int Seniority { get { return DateTime.Today.Year - HiringDate.Year; } }

    }
}
