using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Logica_del_Negocio.Estructura_de_datos
{
    public class Pila<T>:IEnumerable<T>
    {
        private Nodo<T> primero;
        private int tam;

        private class Nodo<U>
        {
            public U item;
            public Nodo<U> enlace;
        }

        public Pila()
        {
            primero = null;
            tam = 0;
        }

        public int GetTam()
        {
            return tam;
        }

        public bool EstaVacio()
        {
            return primero == null;
        }

        public void Empilar(T item)
        {
            Nodo<T> antiguo = primero;
            primero = new Nodo<T> { item = item, enlace = antiguo };
            tam++;
        }

        public T Desempilar()
        {
            if (EstaVacio())
            {
                throw new InvalidOperationException("La pila está vacía");
            }

            T result = primero.item;
            primero = primero.enlace;
            tam--;
            return result;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new ListaIterador(primero);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class ListaIterador : IEnumerator<T>
        {
            private Nodo<T> actual;
            private Nodo<T> inicio;

            public ListaIterador(Nodo<T> inicio)
            {
                this.inicio = inicio;
                this.actual = null;
            }

            public bool MoveNext()
            {
                if (actual == null)
                {
                    actual = inicio;
                }
                else
                {
                    actual = actual.enlace;
                }
                return actual != null;
            }

            public void Reset()
            {
                actual = null;
            }

            public T Current => actual.item;

            object IEnumerator.Current => Current;

            public void Dispose() { }
        }
    }
}
