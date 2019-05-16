using BPlatvanyossagok.UzletiLogika.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPlatvanyossagok.UzletiLogika.Classes
{
    public class Csucs
    {
        public TuristaLatvanyossag Latvanyossag { get; set; }

        public Csucs(TuristaLatvanyossag latvanyossag)
        {
            Latvanyossag = latvanyossag;
        }
    }
}
