using System;

namespace _15._1_Opgave_1
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHallo();
            SayGoodBye();

            Console.ReadLine();
        }

        static void SayHallo()
        {
            string hallo = "Hallo";
            Console.WriteLine(hallo);
        }

        static void SayGoodBye()
        {
            string GoodBye = "GoodBye";
            Console.WriteLine(GoodBye);
        }
    }
}
