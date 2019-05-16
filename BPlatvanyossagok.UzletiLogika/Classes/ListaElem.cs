using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPlatvanyossagok.UzletiLogika.Classes
{
    class ListaElem<T>
    {
        public T Tartalom { get; set; }
        public ListaElem<T> Elozo { get; set; }
        public ListaElem<T> Kovetkezo { get; set; }

        public ListaElem()
        {
            Tartalom = default(T);
            Elozo = null;
            Kovetkezo = null;
        }

        public ListaElem(T tartalom)
        {
            Tartalom = tartalom;
            Elozo = null;
            Kovetkezo = null;
        }

        public ListaElem(T tartalom, ListaElem<T> elozo, ListaElem<T> kovetkezo)
        {
            Tartalom = tartalom;
            Elozo = elozo;
            Kovetkezo = kovetkezo;
        }
    }
}
