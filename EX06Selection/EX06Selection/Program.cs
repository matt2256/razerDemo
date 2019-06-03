using System;

namespace EX06Selection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Brugeren indtaster et beløb, det kan godt være et kommatal
            Console.WriteLine("Indtast et beløb");

            //Brugeren kan indtaste et kommatal i CMD 
            double input = double.Parse(Console.ReadLine());

            double discount = 0;

            if (input > 1000)
            {
                discount = input * 0.05;
            }

            Console.WriteLine($"Du for {discount} i rabat");

            Console.ReadKey();
        }
    }
}
