using AcademyG.Week1.FigureGeometriche.Figure;
using System;

namespace AcademyG.Week1.FigureGeometriche
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
