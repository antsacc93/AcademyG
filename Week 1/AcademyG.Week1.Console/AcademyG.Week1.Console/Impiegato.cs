using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week1.Console
{
    public class Impiegato : Persona, ILogging
    {
        public double Stipendio { get; set; }

        public void LogError(string messaggio)
        {
            System.Console.WriteLine($"Messaggio di errore per {NomeCompleto()}, {messaggio}");
        }

        public void LogInfo(string messaggio)
        {
            System.Console.WriteLine($"Messaggio di info per {NomeCompleto()}, {messaggio}");
        }

        public void LogWarning(string messaggio)
        {
            System.Console.WriteLine($"Messaggio di warning per {NomeCompleto()}, {messaggio}");
        }

        public override string NomeCompleto()
        {
            return base.NomeCompleto() + $" Stipendio: {Stipendio} euro" ;
        }

    }
}
