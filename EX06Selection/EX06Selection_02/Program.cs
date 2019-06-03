using System;

namespace EX06Selection_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv to og derefter bliver de skrevet ud i den stigende orden");
            int firstNumber = int.Parse(Console.ReadLine());
            int secoundNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secoundNumber)
            {
                Console.WriteLine(secoundNumber);
                Console.WriteLine(firstNumber);
            } else
            {
                Console.WriteLine(firstNumber);
                Console.WriteLine(secoundNumber);
            }

            Console.ReadKey();
        }
    }
}
