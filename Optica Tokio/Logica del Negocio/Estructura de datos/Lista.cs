using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Optica_Tokio.Logica_del_Negocio.Estructura_de_datos
{
    [Serializable]
    public class Lista<T> :IEnumerable<T>
    {
        private Nodo cabeza;
        private int tam;

        [Serializable]
        private class Nodo
        {
            public T Item { get; set; }
            public Nodo Enlace { get; set; }
        }

        public Lista()
        {
            cabeza = null;
            tam = 0;
        }

        public int GetTam()
        {
            return tam;
        }

        public bool EstaVacio()
        {
            return cabeza == null;
        }

        public void Insertar(T item)
        {
            cabeza = Insertar(cabeza, item);
        }

        private Nodo Insertar(Nodo x, T item)
        {
            if (x == null)
            {
                x = new Nodo
                {
                    Item = item,
                    Enlace = null
                };
                tam++;
                return x;
            }

            x.Enlace = Insertar(x.Enlace, item);
            return x;
        }

        public T Get(int pos)
        {
            if (pos >= GetTam())
            {
                throw new ArgumentOutOfRangeException("Posición fuera de rango");
            }

            Nodo actual = cabeza;
            for (int i = 0; i < pos; i++)
            {
                actual = actual.Enlace;
            }
            return actual.Item;
        }

        public bool Pertenece(T itemBuscado)
        {
            Nodo actual = cabeza;
            while (actual != null)
            {
                if (EqualityComparer<T>.Default.Equals(actual.Item, itemBuscado))
                {
                    return true;
                }
                actual = actual.Enlace;
            }
            return false;
        }

        public void MergeSort()
        {
            cabeza = MergeSort(cabeza);
        }

        private Nodo MergeSort(Nodo inicio)
        {
            if (inicio == null || inicio.Enlace == null)
            {
                return inicio;
            }

            Nodo mitad1 = GetMitad(inicio);
            Nodo mitad2 = mitad1.Enlace;
            mitad1.Enlace = null;

            Nodo mitad1Ordenado = MergeSort(inicio);
            Nodo mitad2Ordenado = MergeSort(mitad2);

            return Merge(mitad1Ordenado, mitad2Ordenado);
        }

        private Nodo Merge(Nodo lista1, Nodo lista2)
        {
            Nodo resultado = new Nodo();
            Nodo actual = resultado;

            while (lista1 != null && lista2 != null)
            {
                if (((IComparable<T>)lista1.Item).CompareTo(lista2.Item) <= 0)
                {
                    actual.Enlace = lista1;
                    lista1 = lista1.Enlace;
                }
                else
                {
                    actual.Enlace = lista2;
                    lista2 = lista2.Enlace;
                }
                actual = actual.Enlace;
            }

            actual.Enlace = lista1 ?? lista2;

            return resultado.Enlace;
        }

        private Nodo GetMitad(Nodo inicio)
        {
            Nodo siguiente = inicio.Enlace;
            Nodo indice = inicio;

            while (siguiente != null && siguiente.Enlace != null)
            {
                siguiente = siguiente.Enlace.Enlace;
                indice = indice.Enlace;
            }

            return indice;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new ListaIterador(cabeza);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class ListaIterador : IEnumerator<T>
        {
            private Nodo actual;
            private Nodo inicio;

            public ListaIterador(Nodo cabeza)
            {
                inicio = cabeza;
                actual = null;
            }

            public T Current => actual.Item;

            object IEnumerator.Current => Current;

            public bool MoveNext()
            {
                actual = (actual == null) ? inicio : actual.Enlace;
                return actual != null;
            }

            public void Reset()
            {
                actual = null;
            }

            public void Dispose() { }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            Nodo actual = cabeza;
            while (actual != null)
            {
                sb.Append(actual.Item.ToString());
                if (actual.Enlace != null)
                {
                    sb.Append(", ");
                }
                actual = actual.Enlace;
            }
            sb.Append("]");
            return sb.ToString();
        }
    }
}
