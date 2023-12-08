using MangaStore_.Datos.Pilas;
using MangaStore_.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaStore_.Datos.Listas
{
    internal class IntermediarioListas
    {
        private ListasLogica listas=new ListasLogica();
        private Mangas[] manga;
        private static IntermediarioListas _instancia;
        public static IntermediarioListas Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new IntermediarioListas();
                }
                return _instancia;
            }
        }
        public Mangas[] OptenerListas()
        {
             return manga = listas.OptenerListado();
        }
        public void insertarLista(Mangas manga)
        {
            listas.InsertaNodo(manga);
        }
        public void InsertarEnMedio(Mangas manga)
        {
            listas.InsertarMedio(manga);
        }
        public void InsertarInicio(Mangas manga)
        {
            listas.InsertarInicio(manga);
        }

        public void EditarLitas(Mangas manga) {
            listas.Editar(manga);
        }
        public void EliminarLitas(int _ID)
        {
            listas.Eliminar(_ID);
        }
        public Mangas[] BuscarPrecio(double precio)
        {
            return listas.BuscarPrecio(precio);
        }
        public Mangas[] BuscarTitulo(string Titulo)
        {
            return listas.BuscarTitulo(Titulo);
        }
        public void vaciarLista() {
            listas = new ListasLogica();
        }

    }
}
