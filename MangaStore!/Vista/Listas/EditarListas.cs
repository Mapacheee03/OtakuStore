﻿using MangaStore_.Datos.Areglos;
using MangaStore_.Datos.Listas;
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

namespace MangaStore_.Vista
{
    public partial class EditarListas : Form
    {

        public Mangas manga1;
        public EditarListas(Mangas manga)
        {
            InitializeComponent();
            manga1 = manga;
        }

        private void EditarAgreglos_Load(object sender, EventArgs e)
        {
            Codigo_de_barra.Text = manga1.Id.ToString();
            txtTitulo.Text = manga1.Titulo.ToString();
            txtTomo.Text = manga1.Tomo.ToString();
            txtAuthor.Text = manga1.Author.ToString();
            txtEditorial.Text = manga1.Editorial.ToString();
            txtGenero.Text = manga1.Genereo.ToString();
            txtPrecio.Text = manga1.Precio.ToString();
        }



        private void Click_Editar(object sender, EventArgs e)
        {
            IntermediarioListas _IntermediarioListas = IntermediarioListas.Instancia;
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
            _IntermediarioListas.EditarLitas(manga);


            this.Close();
        }
    }
}