using System;
using System.IO;
using System.Collections.Generic;

namespace EX19SreamReader
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int>();
            
            Console.WriteLine("Læser text fra filen");
                    double sum = 0;
            

            using (StreamReader reader = new StreamReader("Values.txt"))
            {
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    numbers.Add(int.Parse(line));
                    int rndNumber = int.Parse(line);
                    sum = sum + rndNumber;
                }
            }

            


            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine(sum);
            Console.WriteLine("");
            Console.WriteLine(sum/numbers.Count);
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("");



        }
    }
}
