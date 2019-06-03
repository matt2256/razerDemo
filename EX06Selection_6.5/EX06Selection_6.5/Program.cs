using System;

namespace EX06Selection_6._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //gemmer inputs i variablerne a og b 
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (b == 0)
            {
                Console.WriteLine("Dette er en fejl medddelse!");
            }
            else
            {
                Console.WriteLine(a/b);
            }

            Console.ReadLine();
        }
    }
}
