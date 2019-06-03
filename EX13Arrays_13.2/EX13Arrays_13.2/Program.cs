using System;

namespace EX13Arrays_13._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[4] { "Hans", "Anton", "Betinna", "Daniel" };

            names[3] = "Kong Daniel";

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.ReadLine();
        }
    }
}
