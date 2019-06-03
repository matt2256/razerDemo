using System;

namespace EX13Array_13._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            numbers[0] = 7;
            numbers[1] = 79;
            numbers[2] = 95;
            numbers[3] = 73;
            numbers[4] = 78;
            numbers[5] = 18;
            numbers[6] = 76;
            numbers[7] = 80;
            numbers[8] = 60;
            numbers[9] = 21;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i] =numbers[i] + 5);
            }

            Console.ReadLine();
        }
    }
}
