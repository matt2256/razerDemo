using System;
using System.Timers;
using System.Diagnostics;
using System.Threading;


namespace MatematikSpil
{
    class Program
    {
        //rng
        static Random rand = new Random();

        static void Main(string[] args)
        {
            string[] operators = new string[] { "+", "-", "*", "/" };

            Stopwatch stopwatch = new Stopwatch();

            int playerLife = 10;
            int computerLife = 10;
            int numbOne = rand.Next(1, 11);
            int numbTwo = rand.Next(1, 11);
            int answer = 0;


            string rndOp = operators[rand.Next(0, operators.Length)];



            Console.WriteLine("Velkommen til matematik spillet");
            Console.WriteLine("Spillet handler om at svare rigtigt på matematik spørgsmål på tid, for at skade din modstander");
            while (playerLife > 0 && computerLife > 0)
            {
                numbOne = rand.Next(1, 11);
                numbTwo = rand.Next(1, 11);

                Console.WriteLine();
                Console.WriteLine($"Hvad er {numbOne} {rndOp} {numbTwo}?");
                stopwatch.Start();
                for (int i = 0; i < 10000; i++)
                {
                    System.Threading.Thread.Sleep(10);
                }
                stopwatch.Stop();

                int input = 0;
                while (true)
                {
                    Console.WriteLine("dit tal her:");
                    if (int.TryParse(Console.ReadLine(), out int newInt))
                    {
                        input = newInt;
                        break;
                    }
                }





                switch (rndOp)
                {
                    case "+":
                        answer = numbOne + numbTwo;
                        //start stopur 
                        //forloop 
                        if (input == answer)
                        {
                            Console.WriteLine("Du svarede rigtigt, din modstander mistede et liv");
                            computerLife--;
                            Console.WriteLine($"Din modstander har {computerLife} liv tilbage");
                            Console.WriteLine("Det tog dig: {0:\\:ss}", stopwatch.Elapsed);
                            Console.WriteLine($"Du har {playerLife} liv tilbage");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Du svarede forkert, du mistede et liv");
                            playerLife--;
                            Console.WriteLine($"Din modstander har {computerLife} liv tilbage");
                            Console.WriteLine($"Du har {playerLife} liv tilbage");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case "-":
                        answer = numbOne - numbTwo;
                        if (input == answer)
                        {
                            Console.WriteLine("Du svarede rigtigt, din modstander mistede et liv");
                            computerLife--;
                            Console.WriteLine($"Din modstander har {computerLife} liv tilbage");
                            Console.WriteLine($"Du har {playerLife} liv tilbage");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Du svarede forkert, du mistede et liv");
                            playerLife--;
                            Console.WriteLine($"Din modstander har {computerLife} liv tilbage");
                            Console.WriteLine($"Du har {playerLife} liv tilbage");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case "*":
                        answer = numbOne * numbTwo;
                        if (input == answer)
                        {
                            Console.WriteLine("Du svarede rigtigt, din modstander mistede et liv");
                            computerLife--;
                            Console.WriteLine($"Din modstander har {computerLife} liv tilbage");
                            Console.WriteLine($"Du har {playerLife} liv tilbage");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Du svarede forkert, du mistede et liv");
                            playerLife--;
                            Console.WriteLine($"Din modstander har {computerLife} liv tilbage");
                            Console.WriteLine($"Du har {playerLife} liv tilbage");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case "/":
                        answer = numbOne / numbTwo;
                        if (input == answer)
                        {
                            Console.WriteLine("Du svarede rigtigt, din modstander mistede et liv");
                            computerLife--;
                            Console.WriteLine($"Din modstander har {computerLife} liv tilbage");
                            Console.WriteLine($"Du har {playerLife} liv tilbage");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Du svarede forkert, du mistede et liv");
                            playerLife--;
                            Console.WriteLine($"Din modstander har {computerLife} liv tilbage");
                            Console.WriteLine($"Du har {playerLife} liv tilbage");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    



                }
            }


            if (playerLife == 0)
            {
                Console.WriteLine("Du har tabt");
                Console.ReadLine();
            } else if (computerLife == 0)
            {
                Console.WriteLine("Du har vundet");
                Console.ReadLine();
            }

           

        }

    }
}
