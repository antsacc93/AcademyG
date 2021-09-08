using AcademyG.Week1.ChainOfResp.Handler;
using System;
using System.Collections.Generic;

namespace AcademyG.Week1.ChainOfResp
{
    class Program
    {
        static void Main(string[] args)
        {
            IHandler lion = new LionHandler();
            IHandler zebra = new ZebraHandler();
            IHandler elephant = new ElephantHandler();

            //Determino l'ordine con cui le richieste verranno processate
            //lion.SetNext(zebra).SetNext(elephant);
            IHandler secondoAnello = lion.SetNext(zebra);
            IHandler terzoAnello = secondoAnello.SetNext(elephant);
            List<string> foods = new List<string> { "Noccioline", "Insalata", "Pasta", "Bistecca" };

            foreach (string item in foods)
            {
                Console.WriteLine($"Chi vuole un po' di {item}?");
                string result = lion.Handle(item);
                
                if(result != null)
                {
                    //se qualcuno ha gestito la richiesta
                    Console.WriteLine($"\t {result}");
                }
                else
                {
                    //se nessun handler è in grado di gestire la richiesta
                    Console.WriteLine($"{item} non è stat* gradito da nessuno");
                }

            }

        }
    }
}
