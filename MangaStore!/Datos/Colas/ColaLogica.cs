using MangaStore_.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaStore_.Datos.Colas
{
    public class Cola
    {
        private int _frente, _fin;
        private int _longitudCola = 999;
        private Mangas[] _listaCola;

        public Cola()
        {
            _frente = -1;
            _fin = -1;
            _listaCola = new Mangas[_longitudCola];
        }

        public bool ColaVacia()
        {
            return _frente == -1;
        }

        public bool ColaLlena()
        {
            return _fin == _longitudCola - 1;
        }

        public int CantidadCola()
        {
            if (ColaVacia())
                return 0;
            else
                return _fin - _frente + 1;
        }

        public int LongitudCola()
        {
            return _longitudCola;
        }

        public Mangas ElementoFrente()
        {
            if (ColaVacia())
                throw new InvalidOperationException("La cola está vacía.");

            return _listaCola[_frente];
        }

        public bool Encolar(Mangas valor)
        {
            if (ColaLlena())
                return false;

            if (_frente == -1)
                _frente = 0;

            _listaCola[++_fin] = valor;
            return true;
        }

        public Mangas Desencolar()
        {
            if (ColaVacia())
                throw new InvalidOperationException("La cola está vacía.");

            Mangas valorDesencolado = _listaCola[_frente];

            if (_frente == _fin)
            {
                _frente = -1;
                _fin = -1;
            }
            else
            {
                _frente++;
            }

            return valorDesencolado;
        }

        public bool LimpiarCola()
        {
            if (ColaVacia())
                return false;

            _frente = -1;
            _fin = -1;
            return true;
        }
        public void ActualizarDatos(Mangas mangas)
        {
            for (int i = _frente; i <= _fin; i++)
            {
                if (_listaCola[i] != null && _listaCola[i].Id == mangas.Id)
                {
                    _listaCola[i].Titulo = mangas.Titulo;
                    _listaCola[i].Tomo = mangas.Tomo;
                    _listaCola[i].Author = mangas.Author;
                    _listaCola[i].Editorial = mangas.Editorial;
                    _listaCola[i].Genereo = mangas.Genereo;
                    _listaCola[i].Precio = mangas.Precio;
                    break;
                }
            }
        }

        public void EliminarDatos(int id)
        {
            for (int i = _frente; i <= _fin; i++)
            {
                if (_listaCola[i] != null && id == _listaCola[i].Id)
                {
                    for (int j = i; j < _fin; j++)
                        _listaCola[j] = _listaCola[j + 1];

                    _listaCola[_fin] = null;
                    _fin--;
                    break;
                }
            }
        }
        public Mangas[] ImprimirCola()
        {
            if (!ColaVacia())
            {
                Mangas[] mangasEnCola = new Mangas[CantidadCola()];
                Array.Copy(_listaCola, _frente, mangasEnCola, 0, CantidadCola());
                return mangasEnCola;
            }
            else
            {
                return null;
            }
        }
    }
}
