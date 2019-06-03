using System;

namespace W3_Opgave12
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 0;
            int k = 1;
            rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            for (int i = 1; i < rows; i++)
            {
                for (int j = 1; j <= i; j++)

                    Console.Write("{0}", k++);
                Console.Write("\n");

            }

            Console.ReadKey();
        }
    }
}
