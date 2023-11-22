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
        Intermedio _Intermedio = Intermedio.Instancia;
        // Intermedio _Intermedio = new Intermedio();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Mangas[] manga1 = _Intermedio.Areglos();
            if (manga1 != null && manga1.Length > 0)
            {
                for (int n = 0; n < manga1.Length; n++)
                {
                    if(manga1[n]!=null){ 
                        int rowIndex = dtgvMangas.Rows.Add();
                        dtgvMangas.Rows[rowIndex].Cells[0].Value = manga1[n].Id;
                        dtgvMangas.Rows[rowIndex].Cells[1].Value = manga1[n].Titulo;
                        dtgvMangas.Rows[rowIndex].Cells[2].Value = manga1[n].Tomo;
                        dtgvMangas.Rows[rowIndex].Cells[3].Value = manga1[n].Author;
                        dtgvMangas.Rows[rowIndex].Cells[4].Value = manga1[n].Editorial;
                        dtgvMangas.Rows[rowIndex].Cells[5].Value = manga1[n].Genereo;
                        dtgvMangas.Rows[rowIndex].Cells[6].Value = manga1[n].Precio;
                    }
                }
            }
        }

        private void btnCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            Mangas manga = new Mangas
            {
                Id = 0,
                Titulo = txtTitulo.Text,
                Tomo = Convert.ToInt32(txtTomo.Text),
                Author = txtAuthor.Text,
                Editorial = txtEditorial.Text,
                Genereo = txtGenero.Text,
                Precio = Convert.ToSingle(txtPrecio.Text),
            };

            //agrega fila
            _Intermedio.Areglos2(manga);
            Mangas[] manga1 = _Intermedio.Areglos();
             int n = dtgvMangas.Rows.Add();
            dtgvMangas.Rows[n].Cells[0].Value = manga1[n].Id;
            dtgvMangas.Rows[n].Cells[1].Value = manga1[n].Titulo;
            dtgvMangas.Rows[n].Cells[2].Value = manga1[n].Tomo;
            dtgvMangas.Rows[n].Cells[3].Value = manga1[n].Author;
            dtgvMangas.Rows[n].Cells[4].Value = manga1[n].Editorial;
            dtgvMangas.Rows[n].Cells[5].Value = manga1[n].Genereo;
            dtgvMangas.Rows[n].Cells[6].Value = manga1[n].Precio;



        }
    }
}

