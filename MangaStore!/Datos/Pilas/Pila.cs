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

        public Pila()
        {

            _cima = -1;
            _listaPila = new Mangas[_longitudPila];
        }

        public bool PilaVacia()
        {
            return _cima == -1 ? true : false;
        }
        public bool PilaLlena()
        {
            if (_cima == _longitudPila - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
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
                _cima++;
                _listaPila[_cima] = valor;
                return true;
            }

        }
        public Mangas ExtraerElemento()
        {
            if (PilaVacia())
            {
                // return _cima;
                throw new InvalidOperationException("The stack is empty.");
            }
            else
            {
                Mangas aux = _listaPila[_cima];
                _cima--;
                return aux;
            }
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
        public void EliminarDatos(int id)
        {
            if (_cima == -1)
            {
                Console.WriteLine("La pila está vacía. No se pueden eliminar elementos.");
                return;
            }

            int elementoAEliminar = -1;

            // Buscar el elemento con el ID proporcionado
            for (int i = _cima; i >= 0; i--)
            {
                if (_listaPila[i] != null && id == _listaPila[i].Id)
                {
                    elementoAEliminar = i;
                    break;
                }
            }

            if (elementoAEliminar != -1)
            {
                // Eliminar el elemento encontrando, moviendo los elementos restantes hacia arriba en la pila
                for (int i = elementoAEliminar; i < _cima; i++)
                {
                    _listaPila[i] = _listaPila[i + 1];
                }

                _listaPila[_cima] = null;
                _cima--;
                Console.WriteLine($"Elemento con ID {id} eliminado de la pila.");
            }
            else
            {
                Console.WriteLine($"Elemento con ID {id} no encontrado en la pila.");
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
