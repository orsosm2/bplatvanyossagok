using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPlatvanyossagok.UzletiLogika.Interfaces;
using static BPlatvanyossagok.UzletiLogika.Latvanyossagok;

namespace BPlatvanyossagok.UzletiLogika.Classes
{
    public class Templom : Latvanyossag
    {
        public Lista<ILatvanyossag> hasonloLatvanyossagok;
        /*  private string nev;


          public string Nev
          {
              get { return nev; }
              set { nev = value; }
          }
  */
        public Templom(string nev, int jegyAr, ErdekessegiSzint erdekessegiSzint)
        {
            this.Nev = nev;
            this.JegyAr = jegyAr;
            this.Erdekesseg = erdekessegiSzint;

            hasonloLatvanyossagok = new Lista<ILatvanyossag>();
        }

        
    }
}
