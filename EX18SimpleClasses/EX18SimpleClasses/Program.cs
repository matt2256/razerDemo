using System;

namespace EX18SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Dacia", "Logan", "Beige", 170000, false, true);
            Car car2 = new Car("Toyota", "Yaris", "Rød", 89000, true, false);
            Car myCar = new Car("Honda", "Civic", "Hvid", 199000, false, false);
            myCar.PrintInfo();
            car1.PrintInfo();
            car2.PrintInfo();
            Console.WriteLine(myCar);
            car1.PutOnSale();
            car1.PrintInfo();

            Console.ReadKey();
        }

        
    }
}
