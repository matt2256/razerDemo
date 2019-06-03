using System;

namespace EX03ConsolePlay
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ændre baggrunds farven til grøn
            Console.BackgroundColor = ConsoleColor.Green;

            //Ændre skfiftfarven til blå
            Console.ForegroundColor = ConsoleColor.Blue;

            //Ændre på størrelsen af consol vinduet 
            Console.WindowHeight = 10;
            Console.WindowWidth = 10;

            //Brug consolen til afspille en sang

            Console.Beep(4000, 100);


            Console.Clear();
            Console.ReadKey();
        }
    }
}
