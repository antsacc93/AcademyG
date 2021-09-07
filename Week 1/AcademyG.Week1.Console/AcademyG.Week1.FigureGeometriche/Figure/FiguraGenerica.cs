using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week1.FigureGeometriche.Figure
{
    public class FiguraGenerica : IFileSerializable
    {
        public string Nome { get; set; }

        public virtual double Area()
        {
            return 0;
        }

        public virtual void Disegna()
        {
            Console.WriteLine("Figura geometrica generica");
        }

        public virtual void LoadFromFile(string fileName)
        {
            Console.WriteLine($"Caricamento dati {fileName} ... non implementato");
        }

        public virtual void SaveToFile(string fileName)
        {
            Console.WriteLine($"Salvataggio dati da {fileName} ... non implementato");
        }

        
    }
}
