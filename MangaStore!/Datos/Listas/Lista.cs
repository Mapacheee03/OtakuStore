using MangaStore_.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaStore_.Datos.Listas
{
    public class Lista
    {
        private Nodo _primero = new Nodo();
        private Nodo _ultimo = new Nodo();

        public Lista()
        {
            _primero = null;
            _ultimo = null;
        }
        public void InsertaNodo(Mangas nuevoManga)
        {
            //tAL VEZ LO QUITE
            Nodo nuevo = new Nodo();

            nuevo.Dato = nuevoManga;

            if (_primero == null)
            {
                _primero = nuevo;
                _primero.Siguiente = _primero;
                _ultimo = _primero;
            }
            else
            {
                _ultimo.Siguiente = nuevo;
                nuevo.Siguiente = _primero;
                _ultimo = nuevo;
            }

           // Console.WriteLine("\n Nodo ingresado con Éxito\n\n");
        }

        public void DesplegarLista()
        {
            Nodo actual = _primero;

            if (actual != null)
            {
                do
                {
                    Console.WriteLine(" " + actual.Dato);
                    actual = actual.Siguiente;
                } while (actual != _primero);
            }
            else
            {
                Console.WriteLine("\n La lista se encuentra vacía \n");
            }
        }
    }
}
