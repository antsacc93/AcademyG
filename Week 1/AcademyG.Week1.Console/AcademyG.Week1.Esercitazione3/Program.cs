using AcademyG.Week1.Esercitazione3.Companies;
using AcademyG.Week1.Esercitazione3.Handlers;
using System;

namespace AcademyG.Week1.Esercitazione3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numEmp = 40;
            CompanyFactory cmpFactory = new CompanyFactory(numEmp);

            ICompany cmpCreated = cmpFactory.GetCompany();
            cmpCreated.Employees[0] = new Employee
            {
                FirstName = "Mario",
                LastName = "Rossi",
                DateOfBirth = new DateTime(1999, 4, 3),
                HiringDate = new DateTime(2019, 3, 4),
                ProductivityRate = 34,
                AbsenceRate = 23
            };
            IHandler prodHandler = new ProductivityHandler { Y = 23, W = 54, Z = 56 };
            IHandler presenceHandler = new PresenceHandler { Y = 23, W = 54, Z = 56 };
            IHandler seniorityHandler = new SeniorityHandler { Y = 23, W = 54, Z = 56 };
            IHandler welfareHandler = new WelfareHandler { Y = 23, W = 54, Z = 56 };

            prodHandler.SetNext(presenceHandler).SetNext(seniorityHandler).SetNext(welfareHandler);

            foreach (Employee emp in cmpCreated.Employees)
            {
                if(emp != null)
                {
                    Console.WriteLine($"L'impiegato {emp.FirstName} {emp.LastName} " +
                    $"ha guadagnato {prodHandler.HandleBonus(emp)} euro");
                }
            }
        }
    }
}
