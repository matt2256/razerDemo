using System;
using System.Collections.Generic;

namespace EX13Lists_14._1
{
    class Program
    {
        static void Main(string[] args)
        {
             List<int> ages = new List<int>();

            ages.Add(5);
            ages.Add(17);
            ages.Add(20);
            ages.Add(40);
            ages.Add(51);

            List<string> names = new List<string>();

            names.Add("Jens");
            names.Add("Karl");
            names.Add("Johannes");
            names.Add("Anton");
            names.Add("Nicklas");

            List<double> percentages = new List<double>() { 0.75, 0.23, 0.86, 0.17 };

            List<bool> areMarried = new List<bool>() { true, false, false, true, true };

            for (int i = 0; i < ages.Count; i++)
            {
                Console.WriteLine(ages[i]);
            }

            for (int i = 0; i < names.Count; i++) 
            {
                Console.WriteLine(names[i]);
            }

            foreach  (double percentage in percentages)
            {
                Console.WriteLine(percentage);
            }

            foreach (bool isMarried in areMarried)
            {
                Console.WriteLine(isMarried);
            }


            Console.ReadLine();
        }
    }
}
