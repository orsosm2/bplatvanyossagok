using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPlatvanyossagok.UzletiLogika.Interfaces;
using static BPlatvanyossagok.UzletiLogika.Latvanyossagok;

namespace BPlatvanyossagok.UzletiLogika.Classes
{
    public class Latvanyossag : TuristaLatvanyossag
    {
        Lista<ILatvanyossag> hasonloLatvanyossagok;
       // private string nev;
       // public string Nev { get { return nev; } set { nev = value; } }

        public Latvanyossag()
        {
        
            hasonloLatvanyossagok = new Lista<ILatvanyossag>();      
        }


        public void HasonloLatvanyossagHozzaad(ILatvanyossag latvanyossag)
        {
            hasonloLatvanyossagok.UjFelvetel(latvanyossag);
        }

        public void HasonloLatvanyossagTorol(ILatvanyossag latvanyossag)
        {
            hasonloLatvanyossagok.Torol(latvanyossag);
        }

        public override ILatvanyossag[] HasonloLatvanyossagok()
        {
            return hasonloLatvanyossagok.LatvanyossagTombbe();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
