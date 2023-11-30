using MangaStore_.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaStore_.Datos.Pilas
{

    public class Intermeriatiopilas
    {
        private static Intermeriatiopilas _instancia;
        private Pila pila = new Pila();
        private Mangas[] manga;


        public static Intermeriatiopilas Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new Intermeriatiopilas();
                }
                return _instancia;
            }
        }

        public Mangas[] ObtenerAreglo()
        {
            manga = pila.ImprimirPila();
            return manga;
        }

        public void insertarAreglos(Mangas manga)
        {
            pila.Push(manga);
        }

    }
}
