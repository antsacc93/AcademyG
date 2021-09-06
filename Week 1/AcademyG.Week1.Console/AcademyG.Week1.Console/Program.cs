using AcademyG.Week1.Console.Entita;
using System;

namespace AcademyG.Week1.Console
{
    
    class Program
    {
        public enum Status
        {
            APERTO = 1,
            INCONSEGNA,
            CHIUSO
        }
        static void Main(string[] args)
        {
            // VALUE TYPE VS REFERENCE TYPE
            int primo = 1;
            int copiaPrimo = primo;
            //copia di un value type
            System.Console.WriteLine($"Stampa di primo: {primo} - Stampa di copiaPirmo: {copiaPrimo}");
            copiaPrimo = 5;
            System.Console.WriteLine("Dopo la modifica");
            System.Console.WriteLine($"primo: {primo}, copiaPrimo: {copiaPrimo}");
            //valore di default
            double secondo = 0.0;
            
            System.Console.WriteLine($"Valore di default di secondo {secondo}");
            System.Console.WriteLine($"{int.MinValue} - {int.MaxValue}");
            System.Console.WriteLine($"{float.MinValue} - {float.MaxValue}");
            System.Console.WriteLine($"{double.MinValue} - {double.MaxValue}");

            bool valore = true;
            bool valore2 = false;

            DateTime dataOggi = DateTime.Now;
            System.Console.WriteLine(dataOggi);

            dataOggi = new DateTime(2021, 9, 6);
            System.Console.WriteLine(dataOggi);

            Status value = Status.APERTO;
            System.Console.WriteLine(value);

            if(value == Status.APERTO)
            {
                System.Console.WriteLine("L'ordine è aperto");
            }

            Persona persona = new Persona();
            persona.Nome = "Mario";
            persona.Cognome = "Rossi";
            //persona.DataNascita = dataOggi; -> PROPRIETA' IN SOLA LETTURA, NON MODIFICABILE

            System.Console.WriteLine(persona.NomeCompleto());
            System.Console.WriteLine(persona.Nome);
            System.Console.WriteLine(persona.Cognome);

            Persona copiaPersona = persona; //COPIA DI UN REFERENCE TYPE
            System.Console.WriteLine($"Nome persona: {persona.Nome} - Cognome persona: {persona.Cognome}");
            System.Console.WriteLine($"Nome copiaPersona: {copiaPersona.Nome} - Cognome copiaPersona: {copiaPersona.Cognome}");
            
            copiaPersona.Cognome = "Rossini";
            
            System.Console.WriteLine($"Nome persona: {persona.Nome} - Cognome persona: {persona.Cognome}");
            System.Console.WriteLine($"Nome copiaPersona: {copiaPersona.Nome} - Cognome copiaPersona: {copiaPersona.Cognome}");
            PersonaNonPubblica pnp = new PersonaNonPubblica();

            System.Console.WriteLine(persona.CodiceFiscale);


            Impiegato impiegato = new Impiegato();
            impiegato.Nome = "Antonia";
            impiegato.Cognome = "Sacchitella";
            System.Console.WriteLine(impiegato.NomeCompleto() + impiegato.CodiceFiscale);

            impiegato.Stipendio = 2000;

            Manager manager = new Manager();
            manager.Nome = "Paolo";
            manager.Cognome = "Rossi";
            manager.Stipendio = 5000;
            manager.NomeCompleto();

            Persona impiegato2 = new Impiegato();
            System.Console.WriteLine(impiegato2.NomeCompleto());

            ILogging pc = new Computer { Modello = "DELL X9012" };
            ILogging impiegatoLog = new Impiegato { Nome = "Franco", Cognome = "Franchi", Stipendio = 1450 };

            pc.LogInfo("pc in errore");
            pc.LogError("manca la corrente");
            pc.LogWarning("è solo un problema temporaneo");

            impiegatoLog.LogInfo("messaggio di comunicazione sospensione corrente");
            impiegatoLog.LogWarning("mancherà la corrente per qualche minuto");
            impiegatoLog.LogError("il pc non si riaccenderà più");

            
            
        }
    }
}
