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

        private int _Id = 0;
        private string _Titulo;
        private string _Tomo;
        private string _Author;
        private string _Editorial;
        private string _Genereo;
        private double _Precio;
        public MangaForm()
        {
            InitializeComponent();


        }

        
        private void MangasForm_Load(object sender, EventArgs e)
        {
            Pila pila=new Pila();
            var arregloMangas=pila.ImprimirPila();
             
            if (arregloMangas != null && arregloMangas.Length > 0)
            {
                foreach (Mangas manga in arregloMangas)
                {
                    // Agregar una fila al DataGridView y establecer los valores
                    int n = dtgvMangas.Rows.Add();
                    dtgvMangas.Rows[n].Cells[0].Value = manga.Id;
                    dtgvMangas.Rows[n].Cells[1].Value = manga.Titulo;
                    dtgvMangas.Rows[n].Cells[2].Value = manga.Tomo;
                    dtgvMangas.Rows[n].Cells[3].Value = manga.Author;
                    dtgvMangas.Rows[n].Cells[4].Value = manga.Editorial;
                    dtgvMangas.Rows[n].Cells[5].Value = manga.Genereo;
                    dtgvMangas.Rows[n].Cells[6].Value = manga.Precio;
                }
            }
            else
            {
                Console.WriteLine("La pila está vacía.");
            }
        }
    }
}