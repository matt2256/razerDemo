using System;

namespace EX07BooleanAlgebra_7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 4;

            Console.WriteLine(a==b || a > 0);
            Console.WriteLine(a+b>0&&a>0);
            Console.WriteLine(a==5&&a+b>0);
            Console.WriteLine((true||false)&&a>b);
            Console.WriteLine(3>5&&true||a==b);
            Console.WriteLine(b>4&&true||false||b>4);
            Console.WriteLine(b<4&&a<b||a+b>4&&true);
            Console.WriteLine(true&&false||false);
            Console.WriteLine(true&&false||true);
            Console.WriteLine(true||false||false);
            Console.WriteLine(false&&false);


            Console.ReadLine();
        }
    }
}
