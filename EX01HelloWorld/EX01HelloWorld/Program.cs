using System;

namespace EX01HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Der printes navnet AspIT
            string schoolName = "AspIT";

            //Stringen schoolName printer også teksten: AspIT - Nordjylland 
            schoolName = "AspIT - Nordjylland";
            
            //Der skrives ud til CMD: AspIT - Nordjylland Fokuseret Talent 
            string motto = "Fokuseret Talent";

            //Der bliver skrevet ud og sætningen sammen sæt ved hjælp af interpolation
            Console.WriteLine($"{ schoolName }, er en skole i Aalborg. Mottoet for skolen er: { motto }");
            Console.ReadKey();
        }
    }
}
