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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Pila pila =new Pila();
            Mangas manga = new Mangas
            {
                Id = 0,
                Titulo = txtTitulo.Text,
                Tomo = Convert.ToInt32(txtTomo.Text),
                Author =txtAuthor.Text,
                Editorial =txtEditorial.Text,
                Genereo = txtGenero.Text,
                Precio = Convert.ToSingle(txtPrecio.Text),
            };

            //agrega fila
            pila.Push(manga);
            MangaForm hola = new MangaForm();
            hola.ShowDialog();


               
        }
    }
}
