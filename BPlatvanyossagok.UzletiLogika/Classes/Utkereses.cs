using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPlatvanyossagok.UzletiLogika.Classes
{
    public class Utkereses
    {
        public static List<Csucs> LegrovidebbUt(Map map, Csucs forrasCsucs, Csucs celCsucs, Graf graf)
        {
            //Útvonalkeresés a forrás és cél cúcsok között
            List<Csucs> utvonal = new List<Csucs>();
            utvonal.Add(forrasCsucs);

            Csucs aktualisCsucs = forrasCsucs;
            while (true)
            {
                // Aktuális csúcs összes szomszédjának feltérképezése
                List<Csucs> osszesSzomszed = map.Szomszedok(aktualisCsucs, graf);

                //Duplikátumok elkerülése
                IEnumerable<Csucs> szomszedok = from szomszed in osszesSzomszed
                                              where !utvonal.Contains(szomszed)
                                              select szomszed;

                //Kilép, ha nincs szomszéd, vagy elértük a cél csúcsot
                if (szomszedok.Count() == 0) break;
                if (szomszedok.Contains(celCsucs))
                {
                    utvonal.Add(celCsucs);
                    break;
                }

                // Kiválasztjuk a következő csúcsot (a legközelebbi szomszédot)
                Csucs legkozelebbiCsucs = LegkozelebbiCsucs(szomszedok, celCsucs, graf);
                utvonal.Add(legkozelebbiCsucs);
                aktualisCsucs = legkozelebbiCsucs;
            }

            return (utvonal);
        }

        public static double Tavolsag(Csucs csucs1, Csucs csucs2, Graf graf)
        {

            double tavolsag = graf.ElHossz(csucs1, csucs2);
           
            return (tavolsag);
        }

        public static Csucs LegkozelebbiCsucs(IEnumerable<Csucs> csucsok, Csucs celCsucs, Graf graf)
        {
            double legrovidebbTavolsag = -1;
            Csucs legkozelebbiCSucs = null;

            int index = 0;
            foreach (Csucs csucs in csucsok)
            {
                double tavolsag = Tavolsag(csucs, celCsucs, graf);
                if (index == 0)
                {
                    legrovidebbTavolsag = tavolsag;
                    legkozelebbiCSucs = csucs;
                }
                else if (legrovidebbTavolsag > tavolsag)
                {
                    legrovidebbTavolsag = tavolsag;
                    legkozelebbiCSucs = csucs;
                }
                index += 1;
            }

            return (legkozelebbiCSucs);
        }

    }
}
