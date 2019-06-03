using System;

namespace EX11While_11._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 7;

            while (x <= 70)
            {
                Console.WriteLine(x);

                x = x + 7;
            }

            int table = int.Parse(Console.ReadLine());

            int z = table;

            while (z <= 10 * table)
            {
                Console.WriteLine(z);

                z = z + table;
            }

            Console.ReadLine();
        }
    }
}
