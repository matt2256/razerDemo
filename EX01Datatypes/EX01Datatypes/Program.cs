using System;

namespace EX01Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //variabler
            string fornavn = "Karsten";
            string efternavn = "Hansen";
            int alder = 35;

            //Print til CMD - navn
            Console.WriteLine(fornavn);
            Console.WriteLine(efternavn);
            Console.WriteLine(alder);
            

            //string interpolation på navn
            Console.WriteLine($"fornavn: {fornavn}. efternavn: {efternavn}. alder: {alder}");

            //nye variabler 
            string title = "Lord of The Rings - The Two Towers";
            Int64 ISBN = 9780007117116;
            int sider = 400;
            double pris = 249.95;

            //Print til CMD - LOTR 
            Console.WriteLine(title);
            Console.WriteLine(ISBN);
            Console.WriteLine(sider);
            Console.WriteLine(pris);

            Console.WriteLine($"Title: {title}. ISBN: {ISBN}. Antal sider: {sider}. Pris på bogen: {pris}");

            //Max og min værdi for int
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;

            //Print til CMD - Størst og mindste værdi af int
            Console.WriteLine(maxInt);
            Console.WriteLine(minInt);

            //Max og min værdi for uint
            uint maxUint = uint.MaxValue;
            uint minUint = uint.MinValue;

            //Print til CMD - Størst og mindste værdi af unit
            Console.WriteLine(maxUint);
            Console.WriteLine(minUint);

            //Max og min værdi for long
            long maxlong = long.MaxValue;
            long minlong = long.MinValue;

            //Print til CMD - Størst og mindste værdi af long
            Console.WriteLine(maxlong);
            Console.WriteLine(minlong);

            //Max og min værdi for byte
            byte maxByte = byte.MaxValue;
            byte minByte = byte.MinValue;

            //Print til CMD - Størst og mindste værdi af byte
            Console.WriteLine(maxByte);
            Console.WriteLine(minByte);

            //Max og min værdi for short
            short maxShort = short.MaxValue;
            short minShort = short.MinValue;

            //Print til CMD - Størst og mindste værdi af byte   
            Console.WriteLine(maxShort);
            Console.WriteLine(minShort);

            //ReadKey
            Console.ReadKey();
        }
    }
}
