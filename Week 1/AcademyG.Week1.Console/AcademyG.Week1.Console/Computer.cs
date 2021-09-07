using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week1.Console
{
    public class Computer : ILogging
    {
        public static int NumeroCore = 4;
        public string Modello { get; set; }

        public double Prezzo { get; set; }

        public static void StampaCore()
        {
            System.Console.WriteLine(NumeroCore);
        }

        public void LogError(string messaggio)
        {
            System.Console.WriteLine($"Messaggio di errore per {Modello}: {messaggio}");
        }

        public void LogInfo(string messaggio)
        {
            System.Console.WriteLine($"Messaggio di info per {Modello}: {messaggio}");
        }

        public void LogWarning(string messaggio)
        {
            System.Console.WriteLine($"Messaggio di warning per {Modello}: {messaggio}");
        }
    }
}
