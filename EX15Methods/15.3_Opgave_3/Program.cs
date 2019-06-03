using System;

namespace _15._3_Opgave_3
{
    class Program
    {

        

        static void Main(string[] args)
        {
            int doubleValue = doubleUp(30);

            Console.WriteLine(doubleValue);
            Console.ReadLine();
        }

        static int doubleUp (int number)
        {
            int sum = number * 2;

            return sum;
        }
    }
}
