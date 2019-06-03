using System;

namespace _15._4_Opgave_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = toTal(2, 4);

            Console.WriteLine(sum);

            Console.ReadLine();
        }

        static int toTal (int a, int b)
        {
            int sum = a + b;

            return sum;
        }
    }
}
