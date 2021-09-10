using AcademyG.Week1.EsercitazioneFinale.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week1.EsercitazioneFinale.Handlers
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        Rimborso Handle(Spesa spesa);
    }
}
