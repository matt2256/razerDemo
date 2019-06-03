using System;

namespace EX11While_11._4
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = 0;

            while (input > 1 || input < 10)
            {
                Console.WriteLine("Indtast venligst et tal mellem 1 og 10");
                input = int.Parse(Console.ReadLine());
            }
        }
    }
}
