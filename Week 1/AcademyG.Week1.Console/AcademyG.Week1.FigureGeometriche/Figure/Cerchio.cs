using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week1.FigureGeometriche.Figure
{
    class Cerchio : FiguraGenerica
    {
        public int X { get; set; }
        public int Y { get; set; }
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }

        public override void Disegna()
        {
            Console.WriteLine($"Nome cerchio: {Nome}. X = {X}, Y = {Y}, Raggio = {Radius}");
            Console.WriteLine($"La mia area è {Area()}");
        }

        public override void LoadFromFile(string fileName)
        {
            Console.WriteLine($"Caricamento dati dal file {fileName}");
            string path = @"C:\Users\AntoniaSacchitella\Desktop\AcademyG\" + fileName; 
            try
            {
                //	      Nome cerchio;  X;  Y; Raggio
                //values:      Cerchio; 12; 13; 45.3

                //Aprire il flusso di lettura da file
                using (StreamReader reader = File.OpenText(path))
                {
                    //string lineaDaScartare = reader.ReadLine();
                    reader.ReadLine(); // scarto la prima linea del file perchè inutile
                    
                    string instanceData = reader.ReadLine().Split(":")[1];
                    string[] valoriDelCerchio = instanceData.Split(";");

                    //Recurpero i dati dal file ed eventualmente li converto
                    string nomeFigura = valoriDelCerchio[0].Trim();
                    int.TryParse(valoriDelCerchio[1], out int x);
                    int.TryParse(valoriDelCerchio[2], out int y);
                    double.TryParse(valoriDelCerchio[3], out double raggio);

                    //Assegnazione al cerchio
                    Cerchio cerchio = new Cerchio
                    {
                        Nome = nomeFigura,
                        X = x,
                        Y = y,
                        Radius = raggio
                    };

                }
            }
            catch(IOException ioe)
            {
                Console.WriteLine($"ERRORE (IO): {ioe.Message}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"ERRORE: {ex.Message}");
            }
        }

        public override void SaveToFile(string fileName)
        {
            string path = @"C:\Users\AntoniaSacchitella\Desktop\AcademyG\" + fileName;
            try
            {
                using (StreamWriter writer = File.CreateText(path))
                {
                    writer.WriteLine("\tNome cerchio; X; Y; Raggio");
                    writer.WriteLine($"values:\t{Nome}; {X}; {Y}; {Radius}");
                }
            }catch(Exception ex)
            {
                Console.WriteLine($"Errore: {ex.Message}");
            }
        }
    }
}
