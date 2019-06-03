using System;
using System.Collections.Generic;
using System.IO;


namespace EX19StreamReader_19._2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<boxes> numbers = new List<boxes>();

            Console.WriteLine("Læser text fra filen");

            using (StreamReader reader = new StreamReader("Boxes.txt"))
            {
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    string[] data = line.Split(',');

                    int width = int.Parse(data[0]);
                    int height = int.Parse(data[1]);
                    int lenght = int.Parse(data[2]);

                    numbers.Add(
                        new boxes(width,height,lenght)
                       );



                }
            }

            for (int i = 0; i < numbers.Count; i++)
            {
               Console.WriteLine(numbers[i]);
            }

            Console.ReadKey();
        }
    }
}
