using System;

namespace AcademyG.Week1.DelegateAndEventi
{
    //DICHIARAZIONE DI UN DELEGATE
    delegate int Somma(int primo, int secondo);

    class Program
    {
        static void Main(string[] args)
        {
            #region DELEGATE
            //ISTANZIO UN PUNTATORE AL METODO 'LA MIA SOMMA'
            Somma somma = new Somma(LaMiaSomma);

            Console.WriteLine(somma(1, 2));

            //Somma prova = new Somma(Coniugato); - NON FUNZIONA PERCHE' NON PRESENTA LA STESSA FIRMA 
            //                                      DEL DELEGATE
            #endregion

            #region EVENTI

            Funzionalita.EsempioSugliEventi();

            #endregion
        }

        public static int LaMiaSomma(int primoAddendo, int secondoAddendo)
        {
            return primoAddendo + secondoAddendo;
        }

        public static int Coniugato(int item)
        {
            return -item;
        }
    }
}
