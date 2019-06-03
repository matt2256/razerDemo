using System;

namespace EX05Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen til lommeregner version 2");
            Console.WriteLine("Nu kan den også regne med kommatal!");

            //Brugeren intaster det første tal
            //Nu kan lommeregneren også regnen med kommatal 
            Console.WriteLine("Intast det førte tal");
            double førsteTal = double.Parse(Console.ReadLine());

            //brugeren indtaster det andet tal
            Console.WriteLine("Indtast det andet tal");
            int andetTal = int.Parse(Console.ReadLine());

            //De to tal bliver lagt sammen og printet ud til CMD
            Console.WriteLine($"De to tal lagt sammen er: {førsteTal + andetTal}");
            Console.WriteLine("");

            //De to tal bliver minuset og printet ud til CMD
            Console.WriteLine($"De to tal minuset er: {førsteTal - andetTal}");
            Console.WriteLine("");

            //De to tal bliver ganget og printet ud til CMD
            Console.WriteLine($"De to tal ganget sammen er: {førsteTal * andetTal}");
            Console.WriteLine("");

            //De to tal bliver divideret og printet ud til CMD
            Console.WriteLine($"De to tal divideret er: {førsteTal / andetTal}");
            Console.WriteLine("");
            Console.ReadKey();


        }
    }
}
