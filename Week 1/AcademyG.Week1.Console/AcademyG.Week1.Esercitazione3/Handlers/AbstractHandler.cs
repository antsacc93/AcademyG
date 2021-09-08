using AcademyG.Week1.Esercitazione3.Companies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week1.Esercitazione3.Handlers
{
    public abstract class AbstractHandler : IHandler
    {
        public int Y { get; set; }
        public int W { get; set; }
        public int Z { get; set; }

        private IHandler _nextHandler;

        public virtual double HandleBonus(Employee employee)
        {
            if(_nextHandler != null)
            {
                return _nextHandler.HandleBonus(employee);
            }
            return 0.0;
        }

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return _nextHandler;
        }
    }
}
