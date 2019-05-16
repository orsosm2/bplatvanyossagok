using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPlatvanyossagok.UzletiLogika.Classes
{
    class ListaBejaro<T> : IEnumerator<T>
    {

        public ListaElem<T> elsoElottiElem;
        public ListaElem<T> elsoElem;

        public T Current { get { return elsoElem.Tartalom; } }
        object IEnumerator.Current { get { return Current; } }

        public ListaBejaro(ListaElem<T> elsoElem)
        {
            this.elsoElottiElem = elsoElem;
            this.elsoElem = null;
        }

        public void Dispose()
        {
            elsoElem = null;
            elsoElottiElem = null;
        }

        public bool MoveNext()
        {
            if (elsoElem == null)
            {
                elsoElem = elsoElottiElem;
            }
            else
            {
                elsoElem = elsoElem.Kovetkezo;
            }

            return elsoElem != null;
        }

        public void Reset()
        {
            elsoElem = null;
        }
    }
}
