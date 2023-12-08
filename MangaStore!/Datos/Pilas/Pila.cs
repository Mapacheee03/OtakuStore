using MangaStore_.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace MangaStore_.Datos.Pilas
{

    public class Pila
    {
        private int _cima, _AuxCima;
        private int _longitudPila = 999;
        private Mangas[] _listaPila;
        private Mangas[] _auxPila;

        public Pila()
        {

            _cima = -1;
            _listaPila = new Mangas[_longitudPila];
            _auxPila = new Mangas[_longitudPila];
        }

        public bool PilaVacia()
        {
            return _cima == -1 ? true : false;
        }
        public bool PilaLlena()
        {
            return _cima == _longitudPila - 1;
        }
        /// <summary>
        public int Cantidadpila()
        {
            return _AuxCima + 1;
        }


        /// <returns></returns>
        public int LongitudPila()
        {
            return _longitudPila;
        }
        public int CantidadElemento()
        {
            return _cima + 1;
        }
        public Mangas ElementoCima()
        {
            if (PilaVacia())
            {
                return _listaPila[0];
            }
            else
            {
                return _listaPila[_cima];
            }
        }
        public bool Push(Mangas valor)
        {
            if (PilaLlena())
            {
                return false;
            }
            else
            {
                // Mover todos los elementos hacia abajo para dar espacio al nuevo elemento
                for (int i = _cima; i >= 0; i--)
                {
                    _listaPila[i + 1] = _listaPila[i];
                }

                _cima++;
                _listaPila[0] = valor; // Agregar el nuevo elemento en la posición 0 (nueva cima)
                Console.WriteLine("Se añadió un nuevo elemento a la pila."); // Mostrar mensaje
                return true;
            }
        }
        public Mangas ExtraerElemento()
       {
            if (PilaVacia())
            {
                throw new InvalidOperationException("The stack is empty.");
            }
            else
            {
                Mangas aux = _listaPila[_cima];
                _auxPila[_AuxCima] = aux; // Almacena el elemento extraído en la pila auxiliar
                _AuxCima++;
                _cima--;
                return aux;
            }
       }

    public void ReintegrarElementos()
    {
        while (_AuxCima > 0)
        {
            _cima++;
            _listaPila[_cima] = _auxPila[_AuxCima - 1];
            _AuxCima--;
        }
    }

    public void LimpiarAuxPila()
    {
        _AuxCima = 0;
    }
        public bool LimpiarPila()
        {
            if (PilaVacia())
            {
                return false;
            }
            else
            {
                while (!PilaVacia())
                {
                    ExtraerElemento();
                }
                //_cima = -1;
                return true;
            }
        }


        public void ActualizarDatos(Mangas mangas)
        {
            Pila pilaTemp = new Pila();

            while (!PilaVacia())
            {
                Mangas elemento = ExtraerElemento();
                if (elemento.Id == mangas.Id)
                {
                    elemento.Titulo = mangas.Titulo;
                    elemento.Tomo = mangas.Tomo;
                    elemento.Author = mangas.Author;
                    elemento.Editorial = mangas.Editorial;
                    elemento.Genereo = mangas.Genereo;
                    elemento.Precio = mangas.Precio;
                }
                pilaTemp.Push(elemento);
            }

            while (!pilaTemp.PilaVacia())
            {
                Push(pilaTemp.ExtraerElemento());
            }
        }
        public Mangas[] ImprimirPila()
        {
            if (!PilaVacia())
            {
                Mangas[] mangas = new Mangas[_longitudPila];
                Array.Copy(_listaPila, mangas, _longitudPila);
                return mangas;
            }
            else
            {
                return null;
            }
        }
    }
}
