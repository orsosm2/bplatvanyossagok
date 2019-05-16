using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPlatvanyossagok.UzletiLogika.Interfaces;
using static BPlatvanyossagok.UzletiLogika.Latvanyossagok;

namespace BPlatvanyossagok.UzletiLogika.Classes
{
    public class Kilato : Latvanyossag
    {


        public Kilato(string nev, int jegyAr, ErdekessegiSzint erdekessegiSzint)
        {
            this.Nev = nev;
            this.JegyAr = jegyAr;
            this.Erdekesseg = erdekessegiSzint;
        }

       
        
    }
}
