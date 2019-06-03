using System;

namespace EX06Selection_to_i_stigende_orden
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv to og derefter bliver de skrevet ud i den stigende orden");
            int firstNumber = int.Parse(Console.ReadLine());
            int secoundNumber = int.Parse(Console.ReadLine());
            int thridNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secoundNumber && firstNumber > thridNumber)
            {
                Console.WriteLine(thridNumber);
                Console.WriteLine(secoundNumber);
                Console.WriteLine(firstNumber);
            }
            else if (secoundNumber > firstNumber && secoundNumber > thridNumber)
            {
                Console.WriteLine(firstNumber);
                Console.WriteLine(secoundNumber);
                Console.WriteLine(thridNumber);

            } else
            {
                Console.WriteLine(secoundNumber);
                Console.WriteLine(thridNumber);
                Console.WriteLine(firstNumber);
            }

            Console.ReadKey();
        }
    }
}
