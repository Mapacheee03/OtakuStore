using MangaStore_.Datos.Areglos;
using MangaStore_.Datos.Colas;
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

namespace MangaStore_.Vista.Colas
{
    public partial class Cola : Form
    {
        private Intermeriatiocolas _Intermedio = Intermeriatiocolas.Instancia;
        int rowIndex;
        private int X = 0;
        public Cola()
        {
            InitializeComponent();
        }

        private void Cola_Load(object sender, EventArgs e)
        {
            RefrescarLista();
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

            if (!int.TryParse(txtTomo.Text, out int tomo))
            {
                MessageBox.Show("Error en el formato del número de tomo. Por favor, introduce un valor entero válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtPrecio.Text, out double precio))
            {
                MessageBox.Show("Error en el formato del precio. Por favor, introduce un valor numérico válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Mangas[] manga1 = _Intermedio.ObtenerAreglo();

                X++;

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

                _Intermedio.InsertarEnCola(manga);
                RefrescarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al agregar el manga: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtboxnumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',' || e.KeyChar == '.') && ((TextBox)sender).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }

        private void numericUpDownTomo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private int ObtenerNuevoId()
        {
            Random random = new Random();
            return random.Next(1, 1000);
        }

        public void RefrescarLista()
        {
            // Clear existing columns and rows
            dtgvMangas.Columns.Clear();
            dtgvMangas.Rows.Clear();

            // Add columns programmatically
            dtgvMangas.Columns.Add("Id", "ID");
            dtgvMangas.Columns.Add("Titulo", "Title");
            dtgvMangas.Columns.Add("Tomo", "Volume");
            dtgvMangas.Columns.Add("Author", "Author");
            dtgvMangas.Columns.Add("Editorial", "Editorial");
            dtgvMangas.Columns.Add("Genero", "Genre");
            dtgvMangas.Columns.Add("Precio", "Price");

            // Editar
            DataGridViewButtonColumn editarButtonColumn = new DataGridViewButtonColumn();
            editarButtonColumn.HeaderText = "Editar";
            editarButtonColumn.Text = "Editar";
            editarButtonColumn.UseColumnTextForButtonValue = true;
            dtgvMangas.Columns.Add(editarButtonColumn);

            // Eliminar
            DataGridViewButtonColumn eliminarButtonColumn = new DataGridViewButtonColumn();
            eliminarButtonColumn.HeaderText = "Eliminar";
            eliminarButtonColumn.Text = "Eliminar";
            eliminarButtonColumn.UseColumnTextForButtonValue = true;
            dtgvMangas.Columns.Add(eliminarButtonColumn);

            Mangas[] arreglo = _Intermedio.ObtenerAreglo();

            if (arreglo != null)
                foreach (Mangas manga in arreglo)
                {
                    if (manga == null)
                        break;

                    int rowIndex = dtgvMangas.Rows.Add();
                    dtgvMangas.Rows[rowIndex].Cells[0].Value = manga.Id;
                    dtgvMangas.Rows[rowIndex].Cells[1].Value = manga.Titulo;
                    dtgvMangas.Rows[rowIndex].Cells[2].Value = manga.Tomo;
                    dtgvMangas.Rows[rowIndex].Cells[3].Value = manga.Author;
                    dtgvMangas.Rows[rowIndex].Cells[4].Value = manga.Editorial;
                    dtgvMangas.Rows[rowIndex].Cells[5].Value = manga.Genereo;
                    dtgvMangas.Rows[rowIndex].Cells[6].Value = manga.Precio;
                }
        }

        private void dgv_CeldaClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7 || e.ColumnIndex == 8)
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
                    if (Convert.ToInt32(dtgvMangas.Rows[e.RowIndex].Cells[0].Value) == 0)
                        MessageBox.Show($"No existe nada que pueda editar");
                    else
                    {
                        EditarCola editar = new EditarCola(manga);
                        editar.ShowDialog();

                    }


                }
                else if (e.ColumnIndex == 8) // Botón de Borrar
                {
                    if (Convert.ToInt32(dtgvMangas.Rows[e.RowIndex].Cells[0].Value) == 0)
                        MessageBox.Show($"No existe nada que pueda borrar");
                    else
                    {
                        var result = MessageBox.Show($"Esta seguro de borar \"{manga.Titulo}\". ¿Deseas continuar?",
                                      "Error",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Error);

                        if (result == DialogResult.Yes)
                        {
                            // _Intermedio.EliminarDatos(manga.Id);



                        }
                    }
                }
                RefrescarLista();

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dtgvMangas.Rows.RemoveAt(rowIndex);

        }



        private void TextUpDownTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextUpDownAuthor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextUpDownEditorial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
