using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPlatvanyossagok.UzletiLogika.Interfaces;
using static BPlatvanyossagok.UzletiLogika.Latvanyossagok;

namespace BPlatvanyossagok.UzletiLogika.Classes
{
    public class Var : Latvanyossag
    {
      /*  private string nev;

        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }
*/
        public Var(string nev, int jegyAr, ErdekessegiSzint erdekessegiSzint)
        {
            this.Nev = nev;
            this.JegyAr = jegyAr;
            this.Erdekesseg = erdekessegiSzint;
        }
        

    }
}
