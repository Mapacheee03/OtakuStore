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
        
        private Pila _pila = new Pila();
        private Mangas[] manga;

        private static Intermeriatiopilas _instancia;
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

        public Mangas[] ObtenerPila()
        {
            manga = _pila.ImprimirPila();
            return manga;
        }

        public void insertarAreglos(Mangas manga)
        {
            _pila.Push(manga);
        }
        public void ActualizarDatos(Mangas manga)
        {
            _pila.ActualizarDatos(manga);
        }

        //public void EliminarDatos(int id)
        //{
        //    _pila.EliminarDatos(id);
        //}
    }
}
