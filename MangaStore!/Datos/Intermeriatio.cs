using MangaStore_.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaStore_.Datos
{
   
        public class Intermedio
        {
            private static Intermedio _instancia;
            private Pila pila = new Pila();
            private Mangas[] manga;

            private Intermedio() { }

            public static Intermedio Instancia
            {
                get
                {
                    if (_instancia == null)
                    {
                        _instancia = new Intermedio();
                    }
                    return _instancia;
                }
            }

            public Mangas[] Areglos()
            {
                manga = pila.ImprimirPila();
                return manga;
            }

            public void Areglos2(Mangas manga)
            {
                pila.Push(manga);
            }
        }
    }
