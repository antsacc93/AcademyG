using System;
using System.IO;

namespace AcademyG.Week1.Watcher
{
    public class GestoreEvento
    {
        public static void GestisciNuovoFile(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Gestione dell'evento {e.ChangeType} sul file {e.Name}");
            ReadFile(e);

            WriteFile(e);
        }

        private static void WriteFile(FileSystemEventArgs e)
        {
            
            try
            {
                using(StreamWriter writer = File.CreateText(e.FullPath))
                {
                    writer.WriteLine($"Dopo aver letto {e.Name}");
                    writer.WriteLine("Lo sovrascrivo");
                }
            }catch(IOException ioe)
            {
                Console.WriteLine(ioe.Message);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private static void ReadFile(FileSystemEventArgs e)
        {
            //Lettura da file
            try
            {
                using (StreamReader reader = File.OpenText(e.FullPath)) { 

                    Console.WriteLine($"Lettura del file {e.Name} in corso");
                    string line = reader.ReadLine();
                    while(line != null)
                    {
                        Console.WriteLine(line);
                        line = reader.ReadLine();
                    }
                    Console.WriteLine("\n Fine del file \n");
                }
            }           
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}