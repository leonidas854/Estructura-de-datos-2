using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Logica_del_Negocio.Estructura_de_datos
{
     class ArbolRN<K, V> where K : IComparable<K>
    {
        private const bool ROJO = true;
        private const bool NEGRO = false;

        private Nodo raiz;

        private class Nodo
        {
            public K Llave { get; set; }
            public V Valor { get; set; }
            public Nodo Izquierda { get; set; }
            public Nodo Derecha { get; set; }
            public bool Color { get; set; }
            public int Tam { get; set; }

            public Nodo(K llave, V valor, bool color, int tam)
            {
                Llave = llave;
                Valor = valor;
                Color = color;
                Tam = tam;
            }
        }

        public ArbolRN() { }

        private bool EsRojo(Nodo nodo)
        {
            if (nodo == null) return false;
            return nodo.Color == ROJO;
        }

        private int GetTam(Nodo nodo)
        {
            if (nodo == null) return 0;
            return nodo.Tam;
        }

        public int GetTam()
        {
            return GetTam(raiz);
        }

        public bool EstaVacio()
        {
            return raiz == null;
        }

        public V GetValorPorLlave(K llave)
        {
            if (llave == null) throw new ArgumentException("Llave no puede ser nula");
            return GetValorPorLlave(raiz, llave);
        }

        private V GetValorPorLlave(Nodo nodo, K llave)
        {
            while (nodo != null)
            {
                int cmp = llave.CompareTo(nodo.Llave);
                if (cmp < 0) nodo = nodo.Izquierda;
                else if (cmp > 0) nodo = nodo.Derecha;
                else return nodo.Valor;
            }
            return default(V);
        }

        public bool Contiene(K llave)
        {
            return GetValorPorLlave(llave) != null;
        }

        public void Insertar(K llave, V valor)
        {
            raiz = Insertar(raiz, llave, valor);
            raiz.Color = NEGRO;
        }

        private Nodo Insertar(Nodo nodo, K llave, V valor)
        {
            if (nodo == null)
            {
                return new Nodo(llave, valor, ROJO, 1);
            }

            int cmp = llave.CompareTo(nodo.Llave);
            if (cmp < 0)
            {
                nodo.Izquierda = Insertar(nodo.Izquierda, llave, valor);
            }
            else if (cmp > 0)
            {
                nodo.Derecha = Insertar(nodo.Derecha, llave, valor);
            }
            else
            {
                nodo.Valor = valor;
            }

            if (EsRojo(nodo.Derecha) && !EsRojo(nodo.Izquierda))
            {
                nodo = RotarIzquierda(nodo);
            }
            if (EsRojo(nodo.Izquierda) && EsRojo(nodo.Izquierda.Izquierda))
            {
                nodo = RotarDerecha(nodo);
            }
            if (EsRojo(nodo.Izquierda) && EsRojo(nodo.Derecha))
            {
                CambiarColor(nodo);
            }
            nodo.Tam = GetTam(nodo.Izquierda) + GetTam(nodo.Derecha) + 1;

            return nodo;
        }

        private Nodo RotarIzquierda(Nodo nodo)
        {
            Nodo temp = nodo.Derecha;
            nodo.Derecha = temp.Izquierda;
            temp.Izquierda = nodo;
            temp.Color = nodo.Color;
            nodo.Color = ROJO;
            temp.Tam = nodo.Tam;
            nodo.Tam = GetTam(nodo.Izquierda) + GetTam(nodo.Derecha) + 1;
            return temp;
        }

        private Nodo RotarDerecha(Nodo nodo)
        {
            Nodo temp = nodo.Izquierda;
            nodo.Izquierda = temp.Derecha;
            temp.Derecha = nodo;
            temp.Color = nodo.Color;
            nodo.Color = ROJO;
            temp.Tam = nodo.Tam;
            nodo.Tam = GetTam(nodo.Izquierda) + GetTam(nodo.Derecha) + 1;
            return temp;
        }

        private void CambiarColor(Nodo nodo)
        {
            nodo.Color = !nodo.Color;
            nodo.Izquierda.Color = !nodo.Izquierda.Color;
            nodo.Derecha.Color = !nodo.Derecha.Color;
        }

        public K GetMin()
        {
            if (EstaVacio()) throw new InvalidOperationException("Árbol vacío");
            return GetMin(raiz).Llave;
        }

        private Nodo GetMin(Nodo nodo)
        {
            if (nodo.Izquierda == null) return nodo;
            return GetMin(nodo.Izquierda);
        }

        public K GetMax()
        {
            if (EstaVacio()) throw new InvalidOperationException("Árbol vacío");
            return GetMax(raiz).Llave;
        }

        private Nodo GetMax(Nodo nodo)
        {
            if (nodo.Derecha == null) return nodo;
            return GetMax(nodo.Derecha);
        }

        public IEnumerable<V> RecorridoAmplitud()
        {
            var resultado = new List<V>();
            var cola = new Queue<Nodo>();
            if (raiz != null) cola.Enqueue(raiz);

            while (cola.Count > 0)
            {
                var actual = cola.Dequeue();
                resultado.Add(actual.Valor);

                if (actual.Izquierda != null) cola.Enqueue(actual.Izquierda);
                if (actual.Derecha != null) cola.Enqueue(actual.Derecha);
            }
            return resultado;
        }

        public IEnumerable<V> RecorridoPorProfundidad()
        {
            var resultado = new List<V>();
            var pila = new Stack<Nodo>();
            if (raiz != null) pila.Push(raiz);

            while (pila.Count > 0)
            {
                var actual = pila.Pop();
                resultado.Add(actual.Valor);

                if (actual.Derecha != null) pila.Push(actual.Derecha);
                if (actual.Izquierda != null) pila.Push(actual.Izquierda);
            }
            return resultado;
        }
    

}
}
