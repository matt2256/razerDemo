using System;

namespace W3_Opgave10
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int rows = 0;
            rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            for (int i = 1; i < rows; i++)
            {
                for (int j = 1; j <= i; j++)
                
                    Console.Write("{0}", j);
                    Console.Write("\n");
                
            }

            Console.ReadKey();
        }
    }
}
