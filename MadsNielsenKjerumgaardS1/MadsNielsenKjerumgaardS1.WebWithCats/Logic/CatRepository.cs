using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace MadsNielsenKjerumgaardS1.WebWithCats.Logic
{
    public class CatRepository
    {


        public static List<Cat> GetCatsFromFile()
        {
            List<string> newCat = new List<string>();
            using (StreamReader reader = new StreamReader("cat.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    newCat.Add(line); // adds to a  
                }
            }

            


            return GetCatsFromFile();
        }
    }
}
