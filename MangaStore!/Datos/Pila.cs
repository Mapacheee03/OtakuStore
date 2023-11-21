using MangaStore_.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaStore_.Datos
{
    public class Pila
    {
        private int _cima;
        private int _longitudPila = 5;
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
            if (_cima == (_longitudPila - 1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
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

        public void ImprimirPila()
        {
            if (!PilaVacia())
            {
                Console.WriteLine($"La pila  es {_listaPila[_cima].Id}");
                Console.WriteLine($"La pila  es {_listaPila[_cima].Titulo}");
                Console.WriteLine($"La pila  es {_listaPila[_cima].Tomo}");
                Console.WriteLine($"La pila  es {_listaPila[_cima].Author}");
                Console.WriteLine($"La pila  es {_listaPila[_cima].Editorial}");
                Console.WriteLine($"La pila  es {_listaPila[_cima].Genereo}");
                Console.WriteLine($"La pila  es {_listaPila[_cima].Precio}");
            }
            else
                Console.WriteLine("la pila esta vacia");
        }

    }
}
