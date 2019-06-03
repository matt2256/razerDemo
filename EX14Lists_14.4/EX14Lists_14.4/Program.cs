using System;
using System.Collections.Generic;

namespace EX14Lists_14._4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            names.Add("Hans");
            names.Add("Kristian");
            names.Add("Jens");
            names.Add("Karsten");
            names.Add("Ib");

            names.Insert(3, "Anders");
            names.Insert(2, "Lars");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }


            List<int> ages = new List<int>();
            ages.Add(13);
            ages.Add(14);
            ages.Add(13);
            ages.Add(15);
            ages.Add(13);
            ages.Add(14);
            ages.Add(14);
            ages.Add(15);

            ages.Remove(13);
            ages.Remove(15);

            ages.RemoveAt(2);

            for (int i = 0; i < ages.Count; i++)
            {
                Console.WriteLine(ages[i]);
            }


            Console.ReadLine();
        }
    }
}
