using System;

namespace EX11While
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int z = 10;
            int a = 2;
            int b = 19;

            while (x<=10)
            {
                Console.WriteLine(x);


                x = x + 1; // x++  er det samme 
            }

            while (z>= 1)
            {
                Console.WriteLine(z);

                z = z - 1; 
            }

            while (a <= 20)
            {
                Console.WriteLine(a);

                a = a + 2;
            }

            while (b >= 1)
            {
                Console.WriteLine(b);

                b = b - 2;
            }

            Console.ReadLine();
        }
    }
}
