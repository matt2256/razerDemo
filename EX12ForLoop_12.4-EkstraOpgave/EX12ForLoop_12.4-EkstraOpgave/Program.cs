using System;

namespace EX12ForLoop_12._4_EkstraOpgave
{
    class Program
    {
        //random number generator 
        static Random rand = new Random();
        static void Main(string[] args)
        {
            //forloop

            for (int i = 0; i < 10; i++)
            {
              Console.WriteLine(rand.Next(1, 7));
            }


            //whileLoop

            while (rand.Next(1,7) < 6)
            {
                Console.WriteLine(rand.Next(1,7));
            }


          
            Console.ReadLine();
        }
    }
}
