using System;
using System.IO;

namespace Opgave1
{
    class Program
    {
        private static bool WriteToFile(string path)
        {
            bool fileExists = File.Exists(path);
            if(fileExists)
            {
                using(StreamWriter sr = File.AppendText(path))
                {
                    Console.Write("Skriv noget tekst: ");
                    DateTime today = DateTime.Now;
                    string input = Console.ReadLine();
                    sr.WriteLine($"{today.ToLocalTime()}: {input}");
                    sr.Close();
                }
                return true;
            }
            else
            {
                Console.WriteLine("Ugyldig sti! prøv igen");
                return false;
            }
        }
        private static void Main()
        {
            while(true)
            {
                Console.Write("Indtast filens sti: ");
                string fileInput = Console.ReadLine();
                WriteToFile(fileInput);
                Console.WriteLine("Modtaget. Dit dokument er blevet opdateret");
                Console.ReadLine();
                Console.Clear();
            }
            
        }
    }
}
