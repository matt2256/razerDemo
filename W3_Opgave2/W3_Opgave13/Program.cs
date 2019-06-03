using System;

namespace W3_Opgave13
{
    class Program
    {
        static void Main(string[] args)
        {
            


            int p = 5;
            int lenght = 10;

            for (int i = 1; i <= lenght; i++)
            {
                for (int j = 1; j <= lenght; j++)
                {
                    if ((i+j > lenght) && (i-j > 0))
                    {
                        Console.WriteLine($"{i},{j}".PadRight(p));
                    }
                    else
                    {
                        Console.Write(" ".PadRight(p));
                    }
                }
            }
            Console.WriteLine();
            Console.ReadKey();

           

            Console.ReadKey();
        }
    }
}
