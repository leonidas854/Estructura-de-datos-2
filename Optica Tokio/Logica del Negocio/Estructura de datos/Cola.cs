using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Logica_del_Negocio.Estructura_de_datos
{
    class Cola<T> :IEnumerable<T>
    {
        private Nodo<T> ultimo;
        private Nodo<T> primero;
        private int tam;

        private class Nodo<U>
        {
            public U item;
            public Nodo<U> enlace;
        }

        public Cola()
        {
            primero = null;
            ultimo = null;
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

        public void Encolar(T i)
        {
            Nodo<T> ultimoAnterior = ultimo;
            ultimo = new Nodo<T> { item = i, enlace = null };

            if (EstaVacio())
            {
                primero = ultimo;
            }
            else
            {
                ultimoAnterior.enlace = ultimo;
            }
            tam++;
        }

        public T Desencolar()
        {
            if (EstaVacio())
            {
                throw new InvalidOperationException("La cola está vacía");
            }

            T result = primero.item;
            primero = primero.enlace;
            tam--;

            if (EstaVacio())
            {
                ultimo = null;
            }

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

        public override string ToString()
        {
            var sb = new System.Text.StringBuilder();
            sb.Append("[");
            Nodo<T> actual = primero;

            while (actual != null)
            {
                sb.Append("(").Append(actual.item).Append(")");
                if (actual.enlace != null)
                {
                    sb.Append(", ");
                }
                actual = actual.enlace;
            }
            sb.Append("]");
            return sb.ToString();
        }
    }
}
