using System;

namespace W3_Opgave4
{
    class Program
    {

        

        static void Main(string[] args)
        {
            int n, sum = 0;
            double avg = 0;
            Console.WriteLine("Indtast værdier");
            for (int i = 1; i <= 10; i++)
            {
               
                Console.Write($"{i}: ");

                n = Convert.ToInt32(Console.ReadLine());
                sum += n;
            }
            avg = sum / 10.0;

            Console.WriteLine(avg);
            Console.WriteLine(" ");
            Console.WriteLine(sum);
            Console.ReadKey(); 
        }
    }
}
