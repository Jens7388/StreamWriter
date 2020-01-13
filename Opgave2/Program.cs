using System;
using System.IO;

namespace Opgave2
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
                    Console.Write("Skriv mindste værdi til talgeneratoren: ");
                    string input = Console.ReadLine();
                    int.TryParse(input, out int lowestNumber);

                    Console.Write("Skriv største værdi til talgeneratoren: ");
                    input = Console.ReadLine();
                    int.TryParse(input, out int highestNumber);

                    Console.Write("Skriv antallet af værdier til talgeneratorer: ");
                    input = Console.ReadLine();
                    int.TryParse(input, out int numbers);
                    Random generator = new Random();

                    for(int i = 0; i < numbers; i++)
                    {
                        sr.WriteLine(generator.Next(lowestNumber, highestNumber));                       
                    }
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
                Console.WriteLine("Dine tal er genereret!");
                Console.ReadLine();
                Console.Clear();
            }          
        }
    }
}
