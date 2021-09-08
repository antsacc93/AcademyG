using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week1.ChainOfResp.Handler
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler); //Metodo per settare l'anello successivo della catena
        string Handle(string request); //Metodo che gestisce effettivamente la richiesta
    }
}
