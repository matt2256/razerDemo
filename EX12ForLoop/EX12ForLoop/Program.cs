using System;

namespace EX12ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            //forloop der skriver tallene fra 1 til 10
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }

            //forloop der skriver alle tallen fra 10 til 1 
            for (int j = 11 - 1; j >= 1; j--)
            {
                Console.WriteLine(j);
            }

            //forloop der skrier alle de lige tal fra 0 til 20
            for (int k = 0; k < 20; k += 2)
            {
                Console.WriteLine(k);
            }

            //forloop der skriver alle de ulige tal fra 1 til 20
            for (int l = 1; l < 20; l += 2)
            {
                Console.WriteLine(l);
            }

            //7 tabellen skrives ud i CMD
            for (int m = 0; m < 71; m += 7)
            {
                Console.WriteLine(m);
            }

            //13 tabellen skrives ud i CMD
            for (int n = 0; n < 131; n += 13)
            {
                Console.WriteLine(n);
            }

            //Skriver en tabel ud fra det bruger gerne vil have 

            int tabel = int.Parse(Console.ReadLine());

            for (int o = 0; o <= 10 * tabel; o += tabel)
            {
                Console.WriteLine(o);

                
            }
            Console.ReadLine();
        }
    }
}
