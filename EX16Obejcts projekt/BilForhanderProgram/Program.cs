using System;
using CarHandler;
using System.Collections.Generic;


namespace BilForhanderProgram
{
    class Program
    {

        static List<Car> newCar = new List<Car>() { };

        static void Main(string[] args)
        {
            Car car1 = new Car("Ford", "Mustang", 1966, "rød");
            Car car2 = new Car("Porsche", "911", 2004, "sølv");

            newCar.Add(car1);
            newCar.Add(car2);
            while (true)
            {
                Console.WriteLine("Velkommen til biladministrationen version 1997");
                Console.WriteLine("Du har nu to muligheder. Ønskder du at: ");
                Console.WriteLine("Indtast en bil (1)?");
                Console.WriteLine("Se informationer om alle biler (2)?");
                Console.WriteLine("Søg for bestemt bil (3)");
                Console.WriteLine("For at lukke programmet (4)");
                Console.WriteLine("Tast dit ønske: ");

                int ønske = int.Parse(Console.ReadLine());

                int attempts = 0;

                switch (ønske)
                {
                    case 1:
                        Console.WriteLine("Indtast venligt følgende informationer");
                        Console.WriteLine($"Hvilket brand er bilen:");
                        string brandInput = Console.ReadLine();
                        Console.WriteLine($"Hvilen model er bilen:");
                        string modelInput = Console.ReadLine();
                        Console.WriteLine($"Hvilket årstal er bilen fra:");
                        int aarstalinput = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Hvilken farve er bilen:");
                        string farveInput = Console.ReadLine();
                        newCar.Add(new Car(brandInput, modelInput, aarstalinput, farveInput));
                        CarHandler.Car newStartCar = new Car(brandInput, modelInput, aarstalinput, farveInput);
                        do
                        {
                            Console.WriteLine($"starting car: {attempts}");
                            attempts++;
                            
                        } while (!newStartCar.StartCar());
                        Console.WriteLine(newStartCar);
                        break;
                    case 2:
                        Console.WriteLine("Informationer om bilerne: ");
                        foreach (Car c in newCar)
                        {
                            Console.WriteLine(c.GetInfo());
                        }
                        break;
                    case 3:
                        string searchParam = Console.ReadLine();
                        searchParam = searchParam.ToLower();
                        

                        for (int i = 0; i < newCar.Count; i++)
                        {
                            if (newCar[i].Make.ToLower() == searchParam)
                            {
                                Console.WriteLine(newCar[i].GetInfo());
                            }
                        }
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;

                }


            }

        }

    }
}
