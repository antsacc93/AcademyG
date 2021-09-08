using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week1.Esercitazione3.Companies
{
    public interface ICompany
    {
        public int NumEmployees { get; set; }
        public Employee[] Employees { get; set; }
    }
}
