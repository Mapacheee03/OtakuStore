﻿using MangaStore_.Datos;
using MangaStore_.Datos.Areglos;
using MangaStore_.Modelos;
using MangaStore_.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangaStore_
{
    public partial class Areglos : Form
    {
        ArregloLogica _ArregloLogica = ArregloLogica.Instancia;
       
        // Intermedio _Intermedio = new Intermedio();
        public Areglos()
        {
            InitializeComponent();
        }

        private void Areglos_Load(object sender, EventArgs e)
        {
            Mangas[] manga1 = _ArregloLogica.ObtenerAreglo();
            if (manga1 != null && manga1.Length > 0)
            {
                for (int n = 0; n < manga1.Length; n++)
                {
                    if (manga1[n] != null)
                    {
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
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) ||
                string.IsNullOrWhiteSpace(txtTomo.Text) ||
                string.IsNullOrWhiteSpace(txtAuthor.Text) ||
                string.IsNullOrWhiteSpace(txtEditorial.Text) ||
                string.IsNullOrWhiteSpace(txtGenero.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de " +
                    "agregar un nuevo manga.", "Campos vacíos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validación de entrada para el campo "Tomo"
            if (!int.TryParse(txtTomo.Text, out int tomo))
            {
                MessageBox.Show("Error en el formato del número de tomo. Por favor," +
                    " introduce un valor entero válido.", "Error de formato",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación de entrada para el campo "Precio"
            if (!double.TryParse(txtPrecio.Text, out double precio))
            {
                MessageBox.Show("Error en el formato del precio. Por favor," +
                    " introduce un valor numérico válido.", "Error de formato",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Mangas[] manga1 = _ArregloLogica.ObtenerAreglo();

                int x = 1;
                if (manga1 != null)
                {
                    for (int i = 0; i < manga1.Length && manga1[i] != null; i++)
                    {
                        x = ObtenerNuevoId();
                    }
                }

                Mangas manga = new Mangas
                {
                    Id = x,
                    Titulo = txtTitulo.Text,
                    Tomo = tomo,
                    Author = txtAuthor.Text,
                    Editorial = txtEditorial.Text,
                    Genereo = txtGenero.Text,
                    Precio = precio,
                };
                // Agrega fila
                _ArregloLogica.insertarAreglos(manga);
                manga1 = _ArregloLogica.ObtenerAreglo();
                int n = dtgvMangas.Rows.Add();
                dtgvMangas.Rows[n].Cells[0].Value = manga1[n].Id;
                dtgvMangas.Rows[n].Cells[1].Value = manga1[n].Titulo;
                dtgvMangas.Rows[n].Cells[2].Value = manga1[n].Tomo;
                dtgvMangas.Rows[n].Cells[3].Value = manga1[n].Author;
                dtgvMangas.Rows[n].Cells[4].Value = manga1[n].Editorial;
                dtgvMangas.Rows[n].Cells[5].Value = manga1[n].Genereo;
                dtgvMangas.Rows[n].Cells[6].Value = manga1[n].Precio;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al agregar el manga: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtboxnumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números, coma (,) o punto (.)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Permitir solo un punto o coma decimal
            if ((e.KeyChar == ',' || e.KeyChar == '.') &&
                ((TextBox)sender).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }

        private void numericUpDownTomo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y teclas de control (por ejemplo, borrar, retroceso)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private int ObtenerNuevoId()
        {
            // Lógica para obtener un nuevo ID único
            // Puedes utilizar alguna lógica similar a la proporcionada anteriormente
            Random random = new Random();
            return random.Next(1, 1000);
        }

        private void dgv_CeldaClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewButtonCell buttonCell;
            Mangas manga = new Mangas
            {
                // Obtén los datos de la celda seleccionada
                Id = Convert.ToInt32(dtgvMangas.Rows[e.RowIndex].Cells[0].Value),
                Titulo = Convert.ToString(dtgvMangas.Rows[e.RowIndex].Cells[1].Value),
                Tomo = Convert.ToInt32(dtgvMangas.Rows[e.RowIndex].Cells[2].Value),
                Author = Convert.ToString(dtgvMangas.Rows[e.RowIndex].Cells[3].Value),
                Editorial = Convert.ToString(dtgvMangas.Rows[e.RowIndex].Cells[4].Value),
                Genereo = Convert.ToString(dtgvMangas.Rows[e.RowIndex].Cells[5].Value),
                Precio = Convert.ToDouble(dtgvMangas.Rows[e.RowIndex].Cells[6].Value),
            };

            if (e.ColumnIndex == 7)
            {

                // Instancia la forma EditarAgreglos y pasa los datos
                EditarAgreglos editar = new EditarAgreglos(manga);
                editar.Show();

            }
            else if (e.ColumnIndex == 8) // Botón de Borrar
            {
                if (Convert.ToInt32(dtgvMangas.Rows[e.RowIndex].Cells[0].Value) == 0)
                    MessageBox.Show($"No existe nada que borrar");
                else
                {
                    var result = MessageBox.Show($"Esta seguro de borar \"{manga.Titulo}\". ¿Deseas continuar?",
                                  "Error",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Error);

                    if (result == DialogResult.Yes)
                    {
                        _ArregloLogica.EliminarDatos(manga.Id);
                    }
                }
            }
                
        }
        
    }


    
}