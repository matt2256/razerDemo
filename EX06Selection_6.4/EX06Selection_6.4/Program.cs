using System;

namespace EX06Selection_6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secoundNumber = int.Parse(Console.ReadLine());

            if (firstNumber == secoundNumber)
            {
                Console.WriteLine("De to tal er ens!");
            }else
            {
                Console.WriteLine("De to tal er ikke ens! ");
            }

            Console.ReadKey();
        }
    }
}
