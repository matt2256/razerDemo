using System;

namespace _15._5_Opgave_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = toTal(3, 5);

            Console.WriteLine(sum);

            Console.ReadLine();
        }

        static int toTal (int a, int b)
        {
            if (a > b)
            {
                return a;
            }

            if (b > a)
            {
                return b;
            }

            return a;
        }
    }
}
