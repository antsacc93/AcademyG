using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week1.FigureGeometriche.Figure
{
    class Triangolo : FiguraGenerica
    {
        public double Base { get; set; }
        public double Altezza { get; set; }

        public override double Area()
        {
            return (Base * Altezza) / 2.0;
        }

        public override void Disegna()
        {
            Console.WriteLine($"Nome triangolo: {Nome}. Base = {Base}, Height = {Altezza}");
            Console.WriteLine($"My Area is {Area()}");
        }

        public override void LoadFromFile(string fileName)
        {
            
        }

        public override void SaveToFile(string fileName)
        {
            
        }
    }
}
