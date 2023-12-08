using MangaStore_.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaStore_.Datos.Colas
{
    public class Intermeriatiocolas
    {
        private Cola _cola = new Cola();
        private Mangas[] _mangas;

        private static Intermeriatiocolas _instancia;
        public static Intermeriatiocolas Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new Intermeriatiocolas();
                }
                return _instancia;
            }
        }

        public Mangas[] ObtenerAreglo()
        {
            _mangas = _cola.ImprimirCola();
            return _mangas;
        }

        public void InsertarEnCola(Mangas manga)
        {
            _cola.Encolar(manga);
        }

        public void ActualizarDatos(Mangas manga)
        {
            _cola.ActualizarDatos(manga);
        }

        //public void EliminarDatos(int id)
        //{
        //    _cola.EliminarDatos(id);
        //}
    }
}
