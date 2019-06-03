using System;

namespace EX06Selection_6_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Brugeren indtaster pakkens vægt 
            Console.WriteLine("Hvad er vægten på pakken?");
            int vægt = int.Parse(Console.ReadLine());
            //pakkens start værdi
            double pris = 0;

            //en if sætning der undersøger om hvor meget pakken vejer og ud fra det printer en pris 
            if (vægt < 20)
            {
                pris = 5;
            }
            else if (vægt >= 20 && vægt < 50)
            {
                pris = 7;           
            }
            else if (vægt >= 50 && vægt < 100)
            {
                pris = 10;
            }
            else if (vægt >= 100 && vægt < 150)
            {
                pris = 15;           
            }
            else if (vægt >= 150 && vægt < 200)
            {
                pris = 20;
            }
            else
            {
                pris = 30;
            }

            //Undersøger om hvorvidt pakken skal være ekspress, hvis den skal være ekspress, så bliver pakken 50% dyrer 
            Console.WriteLine("Skal pakken være ekspress? ja eller nej ");
            if (Console.ReadLine() == "ja")
            {
                Console.WriteLine(pris * 1.5);
            }


            //Gør så consollen ikke lukker automatisk 
            Console.ReadKey();
        }
    }
}
