using System;

namespace EX07BooleanIf
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 3;

            if (a + b == b)
            {
                Console.WriteLine(a);
            }else
            {
                if (b - a == a)
                {
                    Console.WriteLine(b);
                }
                if (c-b == b)
                {
                    Console.WriteLine(3);
                }
            }
                
            
        }
    }
}
