using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week1.Esercitazione3.Companies
{
    public class CompanyFactory 
    {
        public int Parameter { get; set; } 

        public CompanyFactory(int numEmployees)
        {
            Parameter = numEmployees;
        }

        public ICompany GetCompany()
        {
            if(Parameter <= 20)
            {
                return new SmallCompany(Parameter);
            }else if(Parameter > 20 && Parameter <= 100)
            {
                return new MediumCompany(Parameter);
            }else if(Parameter > 100 && Parameter <= 500)
            {
                return new BigCompany(Parameter);
            }
            else
            {
                return new MultinationalCompany(Parameter);
            }
        }
    }
}
