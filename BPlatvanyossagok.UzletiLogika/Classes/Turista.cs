using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPlatvanyossagok.UzletiLogika.Classes
{
    public class Turista
    {
        public String Nev { get; set; }
        public List<Csucs> Utvonal { get; set; }

        List<Csucs> utvonal = new List<Csucs>();

        public Turista(string nev)
        {
            this.Nev = nev;
        }
    }
}
