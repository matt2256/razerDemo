using System;

namespace W3_Opgave5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
                n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine((i*i*i));
            }
            Console.ReadKey();
        }
    }
}
