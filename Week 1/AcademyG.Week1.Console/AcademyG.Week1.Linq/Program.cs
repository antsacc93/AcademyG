using System;
using System.Collections.Generic;
using System.Linq;

namespace AcademyG.Week1.Linq
{
    class Program
    {
        #region DATI DI PROVA

        static List<Valutazione> voti = new List<Valutazione> {
            new Valutazione
            {
                NomeStudente = "Mirko",
                DataValutazione = new DateTime(2021, 9, 9),
                Materia = Materia.Italiano,
                Voto = 7
            },
            new Valutazione
            {
                NomeStudente = "Canio",
                DataValutazione = new DateTime(2021, 9, 9),
                Materia = Materia.Storia,
                Voto = 8
            },
            new Valutazione
            {
                NomeStudente = "Antonia",
                DataValutazione = new DateTime(2021, 9, 8),
                Materia = Materia.Geografia,
                Voto = 10
            },
            new Valutazione
            {
                NomeStudente = "Renata",
                DataValutazione = new DateTime(2021, 9, 5),
                Materia = Materia.Matematica,
                Voto = 9
            },
            new Valutazione
            {
                NomeStudente = "Canio",
                DataValutazione = new DateTime(2021, 9, 4),
                Materia = Materia.Italiano,
                Voto = 4
            },
            new Valutazione
            {
                NomeStudente = "Luigi",
                DataValutazione = new DateTime(2021, 9, 8),
                Materia = Materia.Storia,
                Voto = 5
            }
        
        };

        #endregion


        static void Main(string[] args)
        {
            Console.WriteLine("=== LINQ APPLICATO AGLI OGGETTI ===");

            //TUTTE LE VALUTAZIONI DI CANIO
            //LAMBDA EXPRESSION
            //IEnumerable<Valutazione> valutazioniCanio = voti.Where(val => val.NomeStudente.Equals("Canio"));
            IEnumerable<Valutazione> valutazioniCanio = voti.Where(VotiDiCanio);
            //EQUIVALENTE A
            //QUERY EXPRESSION
            IEnumerable<Valutazione> valutazioniCanioQExp =
                from voto in voti
                where voto.NomeStudente.Equals("Canio")
                select voto;

            //EQUIVALENTE A 
            //(SENZA LINQ)
            IList<Valutazione> valutazioniCanioNOLinq = new List<Valutazione>();
            foreach (Valutazione v in voti)
            {
                if (v.NomeStudente.Equals("Canio"))
                {
                    valutazioniCanioNOLinq.Add(v);
                }
            }

            foreach(Valutazione v in valutazioniCanio)
            {
                Console.WriteLine(v);
            }

            foreach(Valutazione v in valutazioniCanioQExp)
            {
                Console.WriteLine(v);
            }

            foreach(Valutazione v in valutazioniCanioNOLinq)
            {
                Console.WriteLine(v);
            }

            //TUTTE LE VALUTAZIONI DI ITALIANO ORDINATE PER DATA
            //LAMBDA EXPRESSION
            IEnumerable<Valutazione> votiItaliano = voti.Where(v => v.Materia == Materia.Italiano)
                                                        .OrderBy(val => val.DataValutazione).ThenBy(v => v.NomeStudente);
                                                      //.Select(valutazione => valutazione); SOTTOINTESO
            //EQUIVALENTE A
            IEnumerable<Valutazione> votiItalianoQExp =
                from v in voti
                where v.Materia == Materia.Italiano
                orderby v.DataValutazione, v.NomeStudente
                select v;

            foreach(Valutazione v in votiItaliano)
            {
                Console.WriteLine(v);
            }
            foreach(Valutazione v in votiItalianoQExp)
            {
                Console.WriteLine(v);
            }

            //SELEZIONIAMO NOMI DEGLI STUDENTI E VOTI DI COLORO CHE SONO INSUFFICIENTI
            //Lambda Expression
            IEnumerable<Voto> soloVotiInsufficienti = voti.Where(v => v.Voto < 6)
                                                          .Select(v => new Voto { 
                                                              Nome = v.NomeStudente, 
                                                              Risultato = v.Voto 
                                                          });
            //Query Expression
            IEnumerable<Voto> soloVotiInsufficientiQExp =
                from v in voti
                where v.Voto < 6
                select new Voto { Nome = v.NomeStudente, Risultato = v.Voto };

            foreach (Voto voto in soloVotiInsufficienti)
            {
                Console.WriteLine($"Nome studente -> {voto.Nome} - Risultato -> {voto.Risultato}");
            }

            foreach(Voto voto in soloVotiInsufficientiQExp)
            {
                Console.WriteLine($"Nome studente -> {voto.Nome} - Risultato -> {voto.Risultato}");
            }

            //Media dei voti per studente
            //Nome studente - Media
            //Lambda expression
            IEnumerable<Media> mediaVotiPerStudente = voti.GroupBy(
                v => v.NomeStudente,
                (key, grp) => new Media { NomeStudente = key, 
                                          MediaStudente = grp.Average(v => v.Voto) 
                });

            //EQUIVALE A 
            //QUERY EXPRESSION
            IEnumerable<Media> mediaVotiPerStudenteQExp =
                from v in voti
                group v by v.NomeStudente into grp
                select new Media
                {
                    NomeStudente = grp.Key,
                    MediaStudente = grp.Average(v => v.Voto)
                };

            foreach (Media item in mediaVotiPerStudente)
            {
                Console.WriteLine(item);
            }

            foreach (Media item in mediaVotiPerStudenteQExp)
            {
                Console.WriteLine(item);
            }


        }

        static bool VotiDiCanio(Valutazione v)
        {
            return v.NomeStudente.Equals("Canio");
        }
    }
}
