using AcademyG.Week1.Esercitazione3.Companies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week1.Esercitazione3.Handlers
{
    public class WelfareHandler : AbstractHandler
    {
        public override double HandleBonus(Employee employee)
        {
            if(employee.ProductivityRate > W)
            {
                return 400.0;
            }
            return base.HandleBonus(employee);
        }
    }
}
