using System;

namespace EX09Switch_9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case -3:
                    Console.WriteLine("For den ringe præstation. Karakteren -3 gives for den helt uacceptable præstation");
                    break;
                case 00:
                    Console.WriteLine("For den utilstrækkelige præstation. Karakteren 00 gives for den utilstrækkelige præstation, der ikke demonstrerer en acceptabel grad af opfyldelse af fagets/fagelementets mål");
                    break;
                case 02:
                    Console.WriteLine("For den tilstrækkelige præstation. Karakteren 02 gives for den tilstrækkelige præstation, der demonstrerer den minimalt acceptable grad af opfyldelse af fagets/fagelementets mål");
                    break;
                case 4:
                    Console.WriteLine("For den jævne præstation. Karakteren 4 gives for den jævne præstation, der demonstrerer en mindre grad af opfyldelse af fagets/fagelementets mål, med adskillige væsentlige mangler");
                    break;
                case 7:
                    Console.WriteLine("For den gode præstation. Karakteren 7 gives for den gode præstation, der demonstrerer opfyldelse af fagets/fagelementets mål, med en del mangler");
                    break;
                case 10:
                    Console.WriteLine("For den fortrinlige præstation. Karakteren 10 gives for den fortrinlige præstation, der demonstrerer omfattende opfyldelse af fagets/fagelementets mål, med nogle mindre væsentlige mangler");
                    break;
                case 12:
                    Console.WriteLine("For den fremragende præstation. Karakteren 12 gives for den fremragende præstation, der demonstrerer udtømmende opfyldelse af fagets/fagelementets mål, med ingen eller få uvæsentlige mangler");
                    break;
                default:
                    Console.WriteLine("karakteren du ønsker at finde, findes ikke ");
                    break;
            }
            Console.ReadLine();
        }
    }
}
