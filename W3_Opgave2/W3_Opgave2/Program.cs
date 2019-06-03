using System;

namespace W3_Opgave2
{
    class Program
    {
        static void Main(string[] args)
        {

            int sum = 0;
            
            for (int j = 1; j <= 10; j++)
            {

                sum = sum + j;
                Console.WriteLine(j);
                
            }
            Console.ReadKey();
            Console.Clear();
                Console.WriteLine(sum);


            Console.ReadKey();
        }
    }
}
