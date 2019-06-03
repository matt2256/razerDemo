using System;

namespace _15._6_Opgave_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myStringArray = new string[5];

            for (int i = 0; i < myStringArray.Length; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(printArray(myStringArray));

            Console.ReadLine();


        }

        static string printArray (string[] strings)
        {
            foreach (var input in strings)
            {
                Console.WriteLine(input);
            }
            return string.Join("", strings);
        }
    }
}
