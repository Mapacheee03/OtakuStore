using MangaStore_.Datos.Colas;
using MangaStore_.Datos.Pilas;
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

namespace MangaStore_.Vista.Pilas
{
    public partial class EditarPila : Form
    {
        public Mangas manga3;

        public EditarPila(Mangas mangas)
        {
            InitializeComponent();
            manga3 = mangas;
        }

        private void EditarPila_Load(object sender, EventArgs e)
        {
            Codigo_de_barra.Text = manga3.Id.ToString();
            txtTitulo.Text = manga3.Titulo.ToString();
            txtTomo.Text = manga3.Tomo.ToString();
            txtAuthor.Text = manga3.Author.ToString();
            txtEditorial.Text = manga3.Editorial.ToString();
            txtGenero.Text = manga3.Genereo.ToString();
            txtPrecio.Text = manga3.Precio.ToString();
        }

        private void Click_Editar(object sender, EventArgs e)
        {
            Intermeriatiopilas _Intermedio = Intermeriatiopilas.Instancia;
            Mangas manga = new Mangas
            {
                Id = Convert.ToInt32(Codigo_de_barra.Text),
                Titulo = txtTitulo.Text,
                Tomo = Convert.ToInt32(txtTomo.Text),
                Author = txtAuthor.Text,
                Editorial = txtEditorial.Text,
                Genereo = txtGenero.Text,
                Precio = Convert.ToDouble(txtPrecio.Text),
            };
            _Intermedio.ActualizarDatos(manga);


            this.Close();
        }
    }
}
