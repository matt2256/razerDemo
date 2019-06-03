using System;

namespace EX09Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oversigt over forskellige dyr");
            int value = int.Parse(Console.ReadLine());
            Console.ReadKey();
            switch (value)
            {
                case 1:
                    {
                        Console.WriteLine("undulat");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Papegøje");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Hund");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("kat");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("gris");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Dyret findes ikke");
                        break;
                    }


                   
            }
        }
    }
}
