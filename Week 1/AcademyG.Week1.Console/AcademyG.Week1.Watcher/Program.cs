using System;
using System.IO;

namespace AcademyG.Week1.Watcher
{
    class Program
    {
        static void Main(string[] args)
        {
            FileSystemWatcher fsw = new FileSystemWatcher
            {
                Path = @"C:\Users\AntoniaSacchitella\Desktop\AcademyG",
                Filter = "*.txt"
            };
            
            fsw.EnableRaisingEvents = true; //abilita la pubblicazione dell'evento
            //stabilisco alcuni filtri da verificare in fase di pubblicazione
            fsw.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.LastAccess
                | NotifyFilters.DirectoryName | NotifyFilters.FileName;

            fsw.Created += GestoreEvento.GestisciNuovoFile;
            
            Console.WriteLine("Premi q per uscire");
            while (Console.Read() != 'q') ;

        }
    }
}
