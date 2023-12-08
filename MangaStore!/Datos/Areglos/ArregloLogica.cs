
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
        public int Cont = -1;
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
        public void insertarfinal(Mangas _manga)
        {
            Cont++;
            _Mangas[Cont] = _manga;
        }
        public void insertarinicio(Mangas _manga)
        {
            Cont++;
            if (Cont >= 1)
            {
                for (int i = Cont + 1; i > 0; i--)
                {
                    _Mangas[i] = _Mangas[i - 1];
                }
            }
            _Mangas[0] = _manga;

        }
        public void InsertarEnMedio(Mangas _manga)
        {
            Cont++;

            if (Cont % 2 == 0)
            {
                
                for (int i = Cont; i > Cont / 2; i--)
                {
                    _Mangas[i] = _Mangas[i - 1];
                }
                _Mangas[Cont / 2] = _manga;
            }
            else
            {
         
                int posicionMedio = Cont / 2;
                for (int i = Cont; i > posicionMedio; i--)
                {
                    _Mangas[i] = _Mangas[i - 1];
                }
                _Mangas[posicionMedio] = _manga;
            }
        }
        public void Actualizardatos(Mangas mangas)
        {
            for (int i = 0; i <= Cont; i++)
            {
                if (_Mangas[i] != null && _Mangas[i].Id == mangas.Id)
                {
                    _Mangas[i] = mangas;
                   
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

        public void ordenar(string ordenamionto) {
            if (_Mangas != null && Cont >= 0 && Cont <= _Mangas.Length)
            {
                int j;
                Mangas auxiliar;
                for (int i = 0; i <= Cont; i++)  // Ajuste aquí
                {
                    auxiliar = _Mangas[i];
                    j = i - 1;
                    while (j >= 0 && auxiliar.Precio > _Mangas[j].Precio)
                    {
                        _Mangas[j + 1] = _Mangas[j];
                        j--;
                    }

                   
                    if (j + 1 < Cont)
                    {
                        _Mangas[j + 1] = auxiliar;
                    }
                }
            }
        }
    }
}
