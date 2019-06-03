using System;

namespace EX13Arrays_13._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[5];
            number[0] = 25;
            number[1] = 28;
            number[2] = 15;
            number[3] = 35;
            number[4] = 14;

            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }

            Console.ReadLine();
        }
    }
}
