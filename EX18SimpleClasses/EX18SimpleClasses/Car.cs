using System;
using System.Collections.Generic;
using System.Text;

namespace EX18SimpleClasses
{
    class Car
    {
        //fields
        public string Make;
        public string Model;
        public string Color;
        public double Price;
        public bool IsSold;
        public bool IsOnSale;

        //constructors
        public Car (string make, string model, string color, double price, bool isSold, bool isOnSale)
        {
            Make = make;
            Model = model;
            Color = color;
            Price = price;
            IsSold = isSold;
            IsOnSale = isOnSale;
        }

        public void PrintInfo()
        {
            if (IsSold)
            {
                Console.WriteLine($"SOLGT! Bilen er en {Make} {Model} i farven {Color}. Prisen er {Price} DKK");
            }

            else
            {
                Console.WriteLine($"Bilen er en {Make} {Model} i farven {Color}. Prisen er {Price} DKK");
            }
            
        }

        public override string ToString()
        {
            return $"{Make} {Model} {Color} {Price} {IsSold}";
        }

        public void PutOnSale()
        {
            IsOnSale = true;
            Price = Price * 0.9;
        }
    }
}
