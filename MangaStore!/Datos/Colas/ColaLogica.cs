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
            Cola colaTemp = new Cola();

            while (!ColaVacia())
            {
                Mangas elemento = Desencolar();
                if (elemento.Id == mangas.Id)
                {
                    elemento.Titulo = mangas.Titulo;
                    elemento.Tomo = mangas.Tomo;
                    elemento.Author = mangas.Author;
                    elemento.Editorial = mangas.Editorial;
                    elemento.Genereo = mangas.Genereo;
                    elemento.Precio = mangas.Precio;
                }
                colaTemp.Encolar(elemento);
            }

            while (!colaTemp.ColaVacia())
            {
                Encolar(colaTemp.Desencolar());
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
