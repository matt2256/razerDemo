using System;

namespace EX12ForLoop_12._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //et tabellen
            for (int a = 0; a < 11; a++)
            {
                Console.Write(a.ToString().PadLeft(4));
            }

            //2 tabellen
            Console.WriteLine(" ");
            for (int b = 0; b < 21; b += 2)
            {
                Console.Write(b.ToString().PadLeft(4));
            }

            //3 tabellen
            Console.WriteLine(" ");
            for (int c = 0; c < 31; c += 3)
            {
                Console.Write(c.ToString().PadLeft(4));
            }

            //4 tabellen
            Console.WriteLine(" ");
            for (int d = 0; d < 41; d += 4)
            {
                Console.Write(d.ToString().PadLeft(4));
            }

            //5 tabellen
            Console.WriteLine(" ");
            for (int e = 0; e < 51; e += 5)
            {
                Console.Write(e.ToString().PadLeft(4));
            }

            //6 tabellen
            Console.WriteLine(" ");
            for (int f = 0; f < 61; f += 6)
            {
                Console.Write(f.ToString().PadLeft(4));
            }

            //7 tabellen
            Console.WriteLine(" ");
            for (int g = 0; g < 71; g += 7)
            {
                Console.Write(g.ToString().PadLeft(4));
            }

            //8 tabellen
            Console.WriteLine(" ");
            for (int h = 0; h < 81; h += 8)
            {
                Console.Write(h.ToString().PadLeft(4));
            }

            //9 tabellen
            Console.WriteLine(" ");
            for (int i = 0; i < 91; i += 9)
            {
                Console.Write(i.ToString().PadLeft(4));
            }

            //10 tabellen
            Console.WriteLine(" ");
            for (int j = 0; j < 101; j += 10)
            {
                Console.Write(j.ToString().PadLeft(4));
            }

            Console.ReadLine();
        }
    }
}
