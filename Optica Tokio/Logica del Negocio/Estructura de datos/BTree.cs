using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Logica_del_Negocio.Estructura_de_datos
{
     class BTree<Llave, Valor> where Llave : IComparable<Llave>
    {
        private class Nodo
        {
            public int Cantidad;
            public bool EsHoja;
            public Lista<Llave> Llaves = new Lista<Llave>();
            public Lista<Valor> Valores = new Lista<Valor>();
            public Lista<Nodo> Hijos = new Lista<Nodo>();

            public Nodo(bool esHoja)
            {
                EsHoja = esHoja;
            }
        }

        private readonly int _gradoMinimo;
        private Nodo _raiz;

        public BTree(int grado)
        {
            _gradoMinimo = grado;
            _raiz = new Nodo(true);
        }

        public bool EstaVacio => _raiz.Cantidad == 0;

        public int Tamano => ObtenerTamano(_raiz);

        private int ObtenerTamano(Nodo nodo)
        {
            if (nodo == null) return 0;
            int tamano = nodo.Cantidad;
            foreach (var hijo in nodo.Hijos)
                tamano += ObtenerTamano(hijo);
            return tamano;
        }

        // Obtener valor por clave
        public Valor Obtener(Llave llave)
        {
            var nodo = _raiz;
            while (nodo != null)
            {
                int i = 0;
                while (i < nodo.Cantidad && llave.CompareTo(nodo.Llaves.Get(i)) > 0)
                    i++;
                if (i < nodo.Cantidad && llave.CompareTo(nodo.Llaves.Get(i)) == 0)
                    return nodo.Valores.Get(i);
                if (nodo.EsHoja)
                    break;
                nodo = nodo.Hijos.Get(i);
            }
            throw new KeyNotFoundException("La llave no se encuentra en el árbol.");
        }

        // Insertar clave y valor en el B-tree
        public void Insertar(Llave llave, Valor valor)
        {
            if (_raiz.Cantidad == 2 * _gradoMinimo - 1)
            {
                var nuevaRaiz = new Nodo(false);
                nuevaRaiz.Hijos.Insertar(_raiz);
                DividirHijo(nuevaRaiz, 0);
                _raiz = nuevaRaiz;
            }
            InsertarNoLleno(_raiz, llave, valor);
        }

        private void InsertarNoLleno(Nodo nodo, Llave llave, Valor valor)
        {
            int i = nodo.Cantidad - 1;
            if (nodo.EsHoja)
            {
                nodo.Llaves.Insertar(llave);
                nodo.Valores.Insertar(valor);
                nodo.Cantidad++;
            }
            else
            {
                while (i >= 0 && llave.CompareTo(nodo.Llaves.Get(i)) < 0)
                    i--;
                i++;
                if (nodo.Hijos.Get(i).Cantidad == 2 * _gradoMinimo - 1)
                {
                    DividirHijo(nodo, i);
                    if (llave.CompareTo(nodo.Llaves.Get(i)) > 0)
                        i++;
                }
                InsertarNoLleno(nodo.Hijos.Get(i), llave, valor);
            }
        }

        private void DividirHijo(Nodo padre, int indice)
        {
            var hijoCompleto = padre.Hijos.Get(indice);
            var nuevoHijo = new Nodo(hijoCompleto.EsHoja) { Cantidad = _gradoMinimo - 1 };

            for (int j = 0; j < _gradoMinimo - 1; j++)
            {
                nuevoHijo.Llaves.Insertar(hijoCompleto.Llaves.Get(j + _gradoMinimo));
                nuevoHijo.Valores.Insertar(hijoCompleto.Valores.Get(j + _gradoMinimo));
            }
            if (!hijoCompleto.EsHoja)
            {
                for (int j = 0; j < _gradoMinimo; j++)
                    nuevoHijo.Hijos.Insertar(hijoCompleto.Hijos.Get(j + _gradoMinimo));
            }
            hijoCompleto.Cantidad = _gradoMinimo - 1;
            padre.Hijos.Insertar(nuevoHijo);
            padre.Llaves.Insertar(hijoCompleto.Llaves.Get(_gradoMinimo - 1));
            padre.Valores.Insertar(hijoCompleto.Valores.Get(_gradoMinimo - 1));
            padre.Cantidad++;
        }

        // Recorrido en amplitud utilizando Cola
        public Lista<Valor> RecorridoAmplitud()
        {
            var resultado = new Lista<Valor>();
            var frontera = new Cola<Nodo>();
            frontera.Encolar(_raiz);

            while (!frontera.EstaVacio())
            {
                var nodoActual = frontera.Desencolar();
                foreach (var valor in nodoActual.Valores)
                    resultado.Insertar(valor);

                if (!nodoActual.EsHoja)
                {
                    foreach (var hijo in nodoActual.Hijos)
                        frontera.Encolar(hijo);
                }
            }
            return resultado;
        }

        // Recorrido en profundidad utilizando Pila
        public Lista<Valor> RecorridoProfundidad()
        {
            var resultado = new Lista<Valor>();
            var pila = new Pila<Nodo>();
            pila.Empilar(_raiz);

            while (!pila.EstaVacio())
            {
                var nodoActual = pila.Desempilar();
                foreach (var valor in nodoActual.Valores)
                    resultado.Insertar(valor);

                if (!nodoActual.EsHoja)
                {
                    for (int i = nodoActual.Hijos.GetTam() - 1; i >= 0; i--)
                        pila.Empilar(nodoActual.Hijos.Get(i));
                }
            }
            return resultado;
        }

        // Obtener los valores entre dos llaves utilizando Lista
        public Lista<Valor> ValoresEntreLlaves(Llave k1, Llave k2)
        {
            var resultado = new Lista<Valor>();
            ObtenerEntreLlaves(_raiz, k1, k2, resultado);
            return resultado;
        }

        private void ObtenerEntreLlaves(Nodo nodo, Llave k1, Llave k2, Lista<Valor> resultado)
        {
            if (nodo == null) return;

            int i;
            for (i = 0; i < nodo.Cantidad && k1.CompareTo(nodo.Llaves.Get(i)) > 0; i++) { }

            for (; i < nodo.Cantidad && k2.CompareTo(nodo.Llaves.Get(i)) >= 0; i++)
            {
                if (k1.CompareTo(nodo.Llaves.Get(i)) <= 0 && k2.CompareTo(nodo.Llaves.Get(i)) >= 0)
                    resultado.Insertar(nodo.Valores.Get(i));
            }

            if (!nodo.EsHoja)
            {
                for (int j = 0; j <= nodo.Cantidad; j++)
                {
                    if ((i == nodo.Cantidad && j == nodo.Cantidad) || (k2.CompareTo(nodo.Llaves.Get(j)) >= 0))
                    {
                        ObtenerEntreLlaves(nodo.Hijos.Get(j), k1, k2, resultado);
                    }
                }
            }
        }

    }
}
