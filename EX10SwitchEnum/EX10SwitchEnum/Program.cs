using System;

namespace EX10SwitchEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen til denne fantastiske menu. Du har nu fire muligheder: ");
            Console.WriteLine(" ");
            Console.WriteLine("Tryk a for at høre en historie.");
            Console.WriteLine("Tryk mellemrum for at høre en joke.");
            Console.WriteLine("Tryk 9 for at få et matematik spørgsmål.");
            Console.WriteLine("Tryk escape for at afslutte programmet.");
            ConsoleKeyInfo keyinfo = Console.ReadKey(true);

            switch (keyinfo.Key)
            {
                case ConsoleKey.A:
                    Console.WriteLine("Dette er historien om den lille rødhætte");
                    break;
                case ConsoleKey.Backspace:
                    Console.WriteLine("Dette er en dårlig joke!");
                    break;
                case ConsoleKey.D9:
                    Console.WriteLine("Hvad er 2+2 ?");
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }
    }
}
