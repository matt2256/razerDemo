using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadsNielsenKjerumgaardS1.WebWithCats.Logic
{
    public class Cat
    {
        //fields - altid med lille
        public string url = "";
        public string overskrift = "";
        public string beskrivelse = "";
        public string alternativ = "";

        //constructor
        public Cat(string url, string overskrift, string beskrivelse, string alternativ)
        {
            this.url = url;
            this.overskrift = overskrift;
            this.beskrivelse = beskrivelse;
            this.alternativ = alternativ;
        }

        public string catUrl()
        {
            return "";
        }

        public string catOverskrift()
        {
            return "";
        }

        public string catBeskrivelse()
        {
            return "";
        }

        public string catAlternativ()
        {
            return "";
        }
    }
}
