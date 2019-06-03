using System;
using System.Collections.Generic;
using CarHandler;

namespace _16._2_ListCar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            Car car1 = new Car("Ford", "Mustang", 1966, "rød");
            Car car2 = new Car("Porsche", "911", 2004, "sølv");

            cars.Add(car1);
            cars.Add(car2);

            Console.WriteLine("Informationerom bilerne: ");
            foreach ( Car c in cars)
            {
                Console.WriteLine(c.GetInfo());
            }


        }
    }
}
