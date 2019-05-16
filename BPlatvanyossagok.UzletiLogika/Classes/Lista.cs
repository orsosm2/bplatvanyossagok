using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPlatvanyossagok.UzletiLogika.Interfaces;

namespace BPlatvanyossagok.UzletiLogika.Classes
{
    public class Lista<T> : IEnumerable<T> where T: ILatvanyossag
    {
        ListaElem<T> fej;
        ListaElem<T> farok;
        public int Hossz { get; set; }


        public Lista()
        {
            fej = farok = null;
            Hossz = 0;
        }

        public void UjFelvetel(T ujElem)
        {
            ListaElem<T> uj = new ListaElem<T>(ujElem);
            ListaElem<T> aktualis;

            // Ha a lista üres
            if (fej==null)
            {
                fej = new ListaElem<T>(ujElem, null, null);
                farok = fej;
                Hossz++;
            }  // A lista elejére kell beilleszteni az új elemet?
            else if (fej.Tartalom.Erdekesseg >= uj.Tartalom.Erdekesseg)
            {
                
                uj.Kovetkezo = fej;
                uj.Kovetkezo.Elozo = uj;
                fej = uj;
                Hossz++;
            }
            else
            {

                aktualis = fej;
                
                //Megkeresem azt az elemet, amely után beilleszthetem az új elemet.
                while (aktualis.Kovetkezo != null && aktualis.Kovetkezo.Tartalom.Erdekesseg < uj.Tartalom.Erdekesseg)
                {
                    aktualis = aktualis.Kovetkezo;
                    
                }

                //A megfelelő hivatkozások beállítása
                uj.Kovetkezo = aktualis.Kovetkezo;

                //Ha az új elem nem a lista végére került
                if (aktualis.Kovetkezo != null)
                {
                    uj.Kovetkezo.Elozo = uj;
                }

                aktualis.Kovetkezo = uj;
                uj.Elozo = aktualis;
                Hossz++;
            }
        }

        public void Torol(T elem)
        {
            ListaElem<T> torlendo = new ListaElem<T>(elem);
            ListaElem<T> aktualis = fej;

            while (aktualis!=null && aktualis.Tartalom.Nev != torlendo.Tartalom.Nev)
            {
                aktualis = aktualis.Kovetkezo;
            }

            if (aktualis.Tartalom.Nev == torlendo.Tartalom.Nev)
            {
                aktualis.Elozo.Kovetkezo = aktualis.Kovetkezo;
                aktualis = null;
            }
            else
            {
                throw new Exception("A megadott név nem található a listában!");
            }
        }

        public void Kilistaz()
        {
            while (fej!=null)
            {
                Console.Write(fej.Tartalom);
                fej = fej.Kovetkezo;
            }
        }

        public ILatvanyossag[] LatvanyossagTombbe()
        {
            Lista<ILatvanyossag> latvanyossagLista = new Lista<ILatvanyossag>();

            foreach (ILatvanyossag latvany in this)
            {
                latvanyossagLista.UjFelvetel(latvany);
            }

           

            return latvanyossagLista.ToArray();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new ListaBejaro<T>(fej);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
