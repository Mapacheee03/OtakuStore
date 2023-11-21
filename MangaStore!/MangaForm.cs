using MangaStore_.Datos;
using MangaStore_.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangaStore_
{
    public partial class MangaForm : Form
    {
        public MangaForm()
        {
            InitializeComponent();
        }

        private void MangasForm_Load(object sender, EventArgs e)
        {
            Pila pila = new Pila();
            Mangas[] arregloMangas = pila.ImprimirPila();

            if (arregloMangas != null && arregloMangas.Length > 0)
            {
                foreach (Mangas manga in arregloMangas)
                {
                    // Agregar una fila al DataGridView y establecer los valores
                    int n = dtgvMangas.Rows.Add();
                    dtgvMangas.Rows[n].Cells["Id"].Value = manga.Id;
                    dtgvMangas.Rows[n].Cells["Titulo"].Value = manga.Titulo;
                    dtgvMangas.Rows[n].Cells["Tomo"].Value = manga.Tomo;
                    dtgvMangas.Rows[n].Cells["Author"].Value = manga.Author;
                    dtgvMangas.Rows[n].Cells["Editorial"].Value = manga.Editorial;
                    dtgvMangas.Rows[n].Cells["Genero"].Value = manga.Genereo;
                    dtgvMangas.Rows[n].Cells["Precio"].Value = manga.Precio;
                }
            }
            else
            {
                Console.WriteLine("La pila está vacía.");
            }
        }
    }
}