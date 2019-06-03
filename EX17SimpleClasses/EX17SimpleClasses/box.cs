using System;
using System.Collections.Generic;
using System.Text;

namespace EX17SimpleClasses
{
    class Box
    {
        //fields - starter altid med småt bokstav
        public int width;
        public int height;
        public int lenght;

        //properties - Start altid med stort bokstav
        public int Volume { get; private set; }
        public int Surface { get; private set; }

        //construktor
        public Box(int width, int height, int lenght)
        {
            this.width = width;
            this.height = height;
            this.lenght = lenght;

        }

        public string BoxWidth()
        {
            return $"Bredde: {width} cm";
        }

        public string BoxHeight()
        {
            return $"Højde: {height} cm";
        }

        public string BoxLenght()
        {
            return $"Længde: {lenght} cm";
        }

        public string BoxArea()
        {
            Volume = height * width * lenght;
            return $"Rumfang: {Volume} m3";
        }

        public string BoxSurfaceArea()
        {
            CalculateSurface();
            return $"Overflade arealet er: {Surface} m2";
        }

        public void Printinfo()
        {
            Console.WriteLine("kassen har følgende mål:");
            Console.WriteLine(BoxHeight());
            Console.WriteLine(BoxLenght());
            Console.WriteLine(BoxWidth());
            Console.WriteLine(BoxArea());
            Console.WriteLine(BoxSurfaceArea());
        }

        public void CalculateSurface()
        {
            Surface = 2 * (width * height + height * lenght + width * lenght);
        }
    }
}
