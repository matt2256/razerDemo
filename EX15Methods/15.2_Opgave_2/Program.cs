using System;

namespace _15._2_Opgave_2
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHallo("Pia");
            SayGoodBye("Karsten");

            Console.ReadLine();
        }

        static void SayHallo(string name)
        {
            Console.WriteLine($"Hello and welcome {name}, what would you like to do?");
        }

        static void SayGoodBye(string name)
        {
            
            Console.WriteLine($"Hope you will comeback agian {name}");
        }
    }
}
