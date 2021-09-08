using AcademyG.Week1.Esercitazione3.Companies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week1.Esercitazione3.Handlers
{
    public interface IHandler
    {
        int Y { get; set; }
        int W { get; set; }
        int Z { get; set; }
        IHandler SetNext(IHandler handler);
        double HandleBonus(Employee employee);
    }
}
