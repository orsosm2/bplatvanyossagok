using BPlatvanyossagok.UzletiLogika.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BPlatvanyossagok.UzletiLogika.Latvanyossagok;

namespace BPlatvanyossagok.UzletiLogika.Classes
{
    public delegate float EleketFrissit(Csucs honnan, Csucs hova, List<El> elek);

    public class Graf
    {
        public List<Csucs> Csucsok { get; }
        public List<El> Elek { get; }
        public Lista<ILatvanyossag> LatvanyossagokNagyonJo { get; set; }
        

        public Graf()
        {
            Csucsok = new List<Csucs>();
            Elek = new List<El>();
            LatvanyossagokNagyonJo = new Lista<ILatvanyossag>();
        }

        public void UjCsucs(Csucs csucs)
        {
            if (csucs != null && !Csucsok.Contains(csucs))
            {
                Csucsok.Add(csucs);
                if (csucs.Latvanyossag.Erdekesseg == ErdekessegiSzint.NagyonJó)
                {
                    LatvanyossagokNagyonJo.UjFelvetel(csucs.Latvanyossag);
                }
            }
            else
            {
                Console.WriteLine($"A paraméter null vagy már szerepel a gráfban: {nameof(csucs)}");
            }
        }

        public void CsucsTorol(Csucs csucs)
        {
            if (csucs != null && Csucsok.Contains(csucs))
            {
                Csucsok.Remove(csucs);
                Elek.RemoveAll(el => el.Honnan == csucs || el.Hova == csucs);
                if (csucs.Latvanyossag.Erdekesseg == ErdekessegiSzint.NagyonJó && LatvanyossagokNagyonJo.Contains(csucs.Latvanyossag))
                {
                    LatvanyossagokNagyonJo.Torol(csucs.Latvanyossag);
                }

            }
            else
            {
                Console.WriteLine($"A paraméter null vagy nincs ilyen csúcs a gráfban: {nameof(csucs)}");
            }
        }

        public void ElHozzaad(El el)
        {
            Elek.Add(el);
        }

        public void ElTorol(El el)
        {
            if (el != null && Elek.Contains(el))
            {
                Elek.Remove(el);
            }
            else
            {
                Console.WriteLine($"A paraméter null vagy nincs ilyen él a gráfban: {nameof(el)}");
            }
        }
        
        public bool VezetElIde(Csucs csucs) => Elek.Any(el => el.Hova == csucs);

        public bool VezetElInnen(Csucs csucs) => Elek.Any(el => el.Honnan == csucs);

        public El GetEl(Csucs honnan, Csucs hova)
        {
            return Elek.SingleOrDefault(el => el.Honnan == honnan && el.Hova == hova);
        }

        public bool VezetEL(Csucs honnan, Csucs hova)
        {
            if (Elek.SingleOrDefault(el => el.Honnan == honnan && el.Hova == hova) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double ElHossz(Csucs honnan, Csucs hova)
        {
            double hossz = 0;

            if (VezetEL(honnan, hova))
            {
                El el = GetEl(honnan, hova);
                hossz = el.Tavolsag;
            }
            return hossz;
        }

        public void EleketFrissit(EleketFrissit deleg)
        {
            var csucs1 = Csucsok[1];
            var csucs2 = Csucsok[8];
            deleg(csucs1, csucs2, Elek);
        }
    }
}
