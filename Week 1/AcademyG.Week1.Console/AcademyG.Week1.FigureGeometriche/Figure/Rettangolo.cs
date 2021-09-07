using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week1.FigureGeometriche.Figure
{
    class Rettangolo : FiguraGenerica
    {
        public double Base { get; set; }
        public double Altezza { get; set; }

        public override double Area()
        {
            return Base * Altezza;
        }

        public override void Disegna()
        {
            Console.WriteLine($"Nome rettangolo: {Nome}. Base = {Base}, Altezza = {Altezza}");
            Console.WriteLine($"La mia area è {Area()}");
        }

        public override void LoadFromFile(string fileName)
        {
            
        }

        public override void SaveToFile(string fileName)
        {
            
        }
    }
}
