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
                MessageBox.Show("Por favor, completa todos los campos antes de agregar un nuevo manga.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validación de entrada para el campo "Tomo"
            if (!int.TryParse(txtTomo.Text, out int tomo))
            {
                MessageBox.Show("Error en el formato del número de tomo. Por favor, introduce un valor entero válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación de entrada para el campo "Precio"
            if (!double.TryParse(txtPrecio.Text, out double precio))
            {
                MessageBox.Show("Error en el formato del precio. Por favor, introduce un valor numérico válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Mangas manga = new Mangas
                {
                    Id = 0,
                    Titulo = txtTitulo.Text,
                    Tomo = tomo,
                    Author = txtAuthor.Text,
                    Editorial = txtEditorial.Text,
                    Genereo = txtGenero.Text,
                    Precio = precio,
                };

                // Agrega fila
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
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al agregar el manga: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtboxnumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números, coma (,) o punto (.)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Permitir solo un punto o coma decimal
            if ((e.KeyChar == ',' || e.KeyChar == '.') && ((TextBox)sender).Text.IndexOf(',') > -1)
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

    }
}