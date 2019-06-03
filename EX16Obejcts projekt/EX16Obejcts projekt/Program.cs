using System;
using CarHandler;

namespace EX16Obejcts_projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Car car1 = new Car("ford", "mustang", 1966, "rød");
            Car car2 = new Car("ford", "mustang", 1966, "blå");

            bool getCar = car1.StartCar();
            string getcar1 = car2.GetInfo();
            


            Console.WriteLine(getCar);
            Console.WriteLine(getcar1);
            Console.ReadLine();
        }
    }
}
