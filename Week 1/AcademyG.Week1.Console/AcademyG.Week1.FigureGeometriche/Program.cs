using AcademyG.Week1.FigureGeometriche.Figure;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AcademyG.Week1.FigureGeometriche
{
    class Program
    {
        static IEnumerable<FiguraGenerica> Figure = new List<FiguraGenerica>
        {
            new Cerchio {Nome = "A", X = 1, Y = 2, Radius = 3},
            new Cerchio { Nome = "B", X = 4, Y = 5, Radius = 6},
            new Cerchio { Nome = "C", X = 7, Y = 8, Radius = 9},
            new Rettangolo { Nome = "A", Base = 10, Altezza = 11},
            new Rettangolo { Nome = "B", Base = 12, Altezza = 13},
            new Rettangolo { Nome = "C", Base = 14, Altezza = 15},
            new Triangolo { Nome = "A", Base = 16, Altezza = 17},
            new Triangolo { Nome = "B", Base = 18, Altezza = 19},
            new Triangolo { Nome = "C", Base = 20, Altezza = 21},
            new Triangolo { Nome = "D", Base = 22, Altezza = 23}
        };
        static void Main(string[] args)
        {
            #region Esercitazione 1-2-3
            Cerchio cerchio = new Cerchio() 
            {
                Nome = "Mio cerchio",
                X = 5,
                Y = 4,
                Radius = 46.7
            };
            cerchio.SaveToFile("cerchio.txt");
            //cerchio.LoadFromFile("cerchio.txt");

            //Cerchio cerchio = new Cerchio();
            //cerchio.LoadFromFile("cerchio.txt");

            //LoadFromFile("cerchio.txt", cerchio); IDEA DA SVILUPPARE

            //cerchio.X = 400;
            //cerchio.Nome = "Nome modificato del cerchio";
            //cerchio.SaveToFile("cerchio.txt");


            //DATA UNA ISTANZA RECUPARATA DA FILE
            //MODIFICATELA
            //SALVARE IL RISULTATO SU FILE
            #endregion

            Console.WriteLine("Figure geometriche di area superiore a 20");
            //LAMBDA EXPRESSION
            IEnumerable<FiguraGenerica> areaMaggioreVenti = Figure.Where(fig => fig.Area() > 20.0);
            //QUERY EXPRESSION
            IEnumerable<FiguraGenerica> areaMaggioreVentiQExp =
                from figura in Figure
                where figura.Area() > 20.0
                select figura;

            foreach (FiguraGenerica item in areaMaggioreVenti)
            {
                item.Disegna();
            }

            foreach(FiguraGenerica item in areaMaggioreVentiQExp)
            {
                item.Disegna();
            }

            Console.WriteLine("Figure il cui nome comincia per A");
            //LAMBDA EXPRESSION
            IEnumerable<FiguraGenerica> figureA = Figure.Where(figura => figura.Nome.StartsWith("A"));
            //QUERY EXPRESSION
            IEnumerable<FiguraGenerica> figuraAQExp =
                from figura in Figure
                where figura.Nome.StartsWith("A")
                select figura;

            foreach (FiguraGenerica item in figureA)
            {
                item.Disegna();
            }

            foreach (FiguraGenerica item in figuraAQExp)
            {
                item.Disegna();
            }

            Console.WriteLine("Recupera il nome di tutte le figure");
            //LAMBDA EXPRESSION
            IEnumerable<string> nomiFigure = Figure.Select(f => f.Nome);
            //QUERY EXPRESSION
            IEnumerable<string> nomiFigureQExp =
                from figura in Figure
                select figura.Nome;

            foreach (string item in nomiFigure)
            {
                Console.WriteLine(item);
            }
            foreach (string item in nomiFigureQExp)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Figure geometriche in ordine crescente per nome e decrescente per area");
            //LAMBDA EXPRESSION
            IEnumerable<FiguraGenerica> figureOrdinate = Figure.OrderBy(f => f.Nome)
                                                               .ThenByDescending(f => f.Area());
            //QUERY EXPRESSION
            IEnumerable<FiguraGenerica> figureOrdinateQExp =
                from figura in Figure
                orderby figura.Nome, figura.Area() descending
                //orderby figura.Area() descending, figura.Nome ascending -> ordinate prima per area decrescente e
                //                                                           poi per nome crescente
                select figura;

            foreach (FiguraGenerica item in figureOrdinate)
            {
                item.Disegna();
            }
            foreach (FiguraGenerica item in figureOrdinateQExp)
            {
                item.Disegna();
            }

        }
    }
}
