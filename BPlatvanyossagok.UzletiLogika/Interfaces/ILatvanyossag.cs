using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BPlatvanyossagok.UzletiLogika.Latvanyossagok;

namespace BPlatvanyossagok.UzletiLogika.Interfaces
{
    public interface ILatvanyossag
    {
         int JegyAr { get; set; }
        string Nev { get; set; }
         ErdekessegiSzint Erdekesseg { get; set; }

        ILatvanyossag[] HasonloLatvanyossagok();
    }
}
