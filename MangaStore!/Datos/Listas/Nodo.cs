using MangaStore_.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaStore_.Datos.Listas
{
    public class Nodo
    {
        private Mangas _manga;
        private Nodo _Siguiente;
        public Nodo(Mangas manga) { 
            _manga = manga;
            _Siguiente = null;
        }
        public Nodo(Mangas manga,Nodo siguiente)
        {
            _manga = manga;
            _Siguiente = siguiente;
        }
        public Mangas Dato
        {
            get { return _manga; }
            set { _manga = value; }
        }
        public Nodo Siguiente
        {
            get { return _Siguiente; }
            set { _Siguiente = value; }
        }


    }
}