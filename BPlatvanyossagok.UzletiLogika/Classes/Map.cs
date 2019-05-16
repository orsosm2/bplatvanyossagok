using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPlatvanyossagok.UzletiLogika.Classes
{
    public class Map
    {


        public List<Csucs> Csucsok { get; set; }


        public Map()
        {
            Csucsok = new List<Csucs>();
        }


        public List<Csucs> Szomszedok(Csucs aktualisCsucs, Graf graf)
        {
            List<Csucs> szomszedok = new List<Csucs>();
            foreach (Csucs csucs in graf.Csucsok)
            {
                if (!csucs.Equals(aktualisCsucs)) //az aktuális csúcs nem szomszédja önmagának
                {
                    if (Utkereses.Tavolsag(aktualisCsucs, csucs, graf)>0)
                    {
                        szomszedok.Add(csucs);
                    }
                }
            }

            return (szomszedok);
        }

        
    }
}

