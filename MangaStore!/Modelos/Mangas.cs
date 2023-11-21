using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaStore_.Modelos
{
    public class Mangas
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int Tomo { get; set; }
        public string Author { get; set; }
        public string Editorial { get; set; }
        public string Genereo { get; set; }
        public double Precio { get; set; }
    }
}
