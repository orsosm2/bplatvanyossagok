using BPlatvanyossagok.UzletiLogika.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BPlatvanyossagok.UzletiLogika.Latvanyossagok;

namespace BPlatvanyossagok.UzletiLogika.Classes
{
    public abstract class TuristaLatvanyossag : ILatvanyossag
    {
        public int JegyAr { get; set; }
        public ErdekessegiSzint Erdekesseg { get; set; }
        public  string Nev { get; set; }

        public abstract ILatvanyossag[] HasonloLatvanyossagok();

        
    }
}
