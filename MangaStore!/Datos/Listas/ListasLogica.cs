using MangaStore_.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaStore_.Datos.Listas
{
    public class ListasLogica
    {
        private Nodo _primero;
        private Nodo _ultimo;

        public ListasLogica()
        {
            _primero = null;
            _ultimo = null;
        }
        public void InsertaNodo(Mangas manga)
        {
            Nodo nuevo = new Nodo(manga);
            if (_primero == null)
              _ultimo=_primero = nuevo;
            else
             _ultimo=_ultimo.Siguiente = nuevo;
        }
        public int Longitud() {
            int cont = 0;
            Nodo actual = _primero;
            while (actual != null)
            { 
                cont ++;
                actual = actual.Siguiente;
            }
            return cont;
        }
   
        public void Editar(Mangas mangas)
        {
            Nodo _actual = _primero;
         
                while (_actual != null)
                { 
                    if (_actual.Dato.Id ==mangas.Id)
                    {
                        _actual.Dato = mangas;
                        break;
                    }
                    _actual = _actual.Siguiente;
                }
          
        }
        public void Eliminar(int Idmanga)
        {
            Nodo actual = _primero;
            Nodo anterior = null;
            while (actual != null)
            {
                if (actual.Dato.Id == Idmanga)
                {
                    if (anterior == null)
                    {
                        _primero = actual.Siguiente;
                        if (_primero == null)
                            _ultimo = null;

                    }
                    else
                    {
                        anterior.Siguiente = actual.Siguiente;

                        if (actual.Siguiente == null)
                            _ultimo= anterior;
                    }

                    break;
                }

                anterior = actual;
                actual = actual.Siguiente;
            }
        }
        public Mangas[] OptenerListado()
        {
            Mangas[] mangas = new Mangas[Longitud()];
            Nodo _actual = _primero;
            
                for (int i = 0; i < Longitud()&&_actual!=null; i++)
                {
                    mangas[i] = _actual.Dato;
                    _actual = _actual.Siguiente;
                }
            return mangas;
        }
    }
}
