using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast et tal, du gerne vil have kvadraten af: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(Calculate(input));

            Console.ReadKey();
        }

        static string Calculate(int a)
        {
            
            if (a >= 0)
            {
                
                return Math.Sqrt(a).ToString();
            } else
            {
                return"Du kan ikke tage kvadrat roden af et negativt tal";
            }

            

            
        }
    }
}
