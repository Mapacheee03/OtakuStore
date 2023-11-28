
using MangaStore_.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaStore_.Datos.Areglos
{
    public class ArregloLogica
    {

        private Mangas[] _Mangas = new Mangas[90];
        private int Cont = -1;
        private static ArregloLogica _instanciaAtreglo;
       
        public static ArregloLogica Instancia
        {
            get
            {
                if (_instanciaAtreglo == null)
                {
                    _instanciaAtreglo = new ArregloLogica();
                }
                return _instanciaAtreglo;
            }
        }

        public void insertarAreglos(Mangas _manga)
        {
            Cont++;
            _Mangas[Cont] = new Mangas();
            _Mangas[Cont].Id = _manga.Id;
            _Mangas[Cont].Titulo = _manga.Titulo;
            _Mangas[Cont].Tomo = _manga.Tomo;
            _Mangas[Cont].Author = _manga.Author;
            _Mangas[Cont].Editorial = _manga.Editorial;
            _Mangas[Cont].Genereo = _manga.Genereo;
            _Mangas[Cont].Precio = _manga.Precio;
        }
        public void Actualizardatos(Mangas mangas)
        {
            for (int i = 0; i <= Cont; i++)
            {
                if (_Mangas[i] != null && _Mangas[i].Id == mangas.Id)
                {
                    _Mangas[i].Id = mangas.Id;
                    _Mangas[i].Titulo = mangas.Titulo;
                    _Mangas[i].Tomo = mangas.Tomo;
                    _Mangas[i].Author = mangas.Author;
                    _Mangas[i].Editorial = mangas.Editorial;
                    _Mangas[i].Genereo = mangas.Genereo;
                    _Mangas[i].Precio = mangas.Precio;
                    break;
                }
            }
        }
        public void EliminarDatos(int Id)
        {
            for (int i = 0; i <= Cont; i++)
            {
                if (_Mangas[i] != null && Id == _Mangas[i].Id)
                {
                    
                    for (int j = i; j < Cont - 1; j++)
                        _Mangas[j] = _Mangas[j + 1];
                    
                    _Mangas[Cont] = null;
                    Cont--;
                    break;
                }
            }
        }
        public Mangas[] ObtenerAreglo()
        {
            return _Mangas; 
        }

    }
}
