using System;

namespace EX04ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            //printer Velkommen i consolen 
            Console.WriteLine("Velkommen");

            //gemmer et input fra brugeren i variablen fornavn
            Console.WriteLine("Skriv dit fornavn");
            string fornavn = Console.ReadLine();

            //gemmer et input fra brugeren i variablen efternavn
            Console.WriteLine("skriv dit efternavn");
            string efternavn = Console.ReadLine();

            Console.WriteLine($"Velkommen {fornavn} {efternavn}");



            //Printer skriv et tal 
            Console.WriteLine("Skriv et tal");

            //gemmer et tal input i variablen rndTal
            int rndTal = int.Parse(Console.ReadLine());

            //printer variabelen med inputtet i CMD 
            Console.WriteLine(rndTal);


            //udregning af areal 
            //højde inputtet 
            Console.WriteLine("skriv højden på arealet");
            int højde = int.Parse(Console.ReadLine());

            //bredte input
            Console.WriteLine("skriv bredten på arealet");
            int bredte = int.Parse(Console.ReadLine());

            //udregning af arealet 
            Console.WriteLine(højde*bredte);


            

            Console.ReadKey();
        }
    }
}
