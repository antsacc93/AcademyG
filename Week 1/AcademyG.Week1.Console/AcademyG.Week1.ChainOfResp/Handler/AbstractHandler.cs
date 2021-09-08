using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week1.ChainOfResp.Handler
{
    public abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler; //Proprietà privata che tiene traccia dell'anello successivo della 
                                       //catena di responsabilità
        public virtual string Handle(string request)
        {
            if(_nextHandler != null)
            {
                return _nextHandler.Handle(request);
            }
            return null;
        }

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return _nextHandler;
        }
    }
}
