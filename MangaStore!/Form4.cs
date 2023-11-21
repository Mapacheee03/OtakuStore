using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MangaStore_
{
    public partial class Form4 : Form
    {
        List<object> Milista = new List<object>(); // Cambié el tipo de lista a object para permitir caracteres
        public Form4()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Milista.Add(txtValor.Text); // Agregar el texto directamente a la lista
            txtValor.Clear();
            txtValor.Focus();
        }

        private void btnMostraar_Click(object sender, EventArgs e)
        {
            Liver.Items.Clear();
            foreach (var item in Milista)
            {
                Liver.Items.Add(item.ToString()); // Mostrar cada elemento en el ListBox
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int pos;
            if (int.TryParse(txtPosicion.Text, out pos)) // Intentar convertir a entero
            {
                if (pos >= 0 && pos <= Milista.Count)
                {
                    Milista.Insert(pos, txtValor.Text); // Insertar el texto en la posición especificada
                }
                else
                {
                    MessageBox.Show("La posición está fuera del rango");
                }
            }
            else
            {
                MessageBox.Show("Ingrese una posición válida");
            }

            txtValor.Clear();
            txtValor.Focus();
            txtPosicion.Clear();
            txtPosicion.Focus();
        }

        private void btnEliminarDe_Click(object sender, EventArgs e)
        {
            int pos;
            if (int.TryParse(txtPosicion.Text, out pos)) // Intentar convertir a entero
            {
                if (pos >= 0 && pos < Milista.Count)
                {
                    Milista.RemoveAt(pos); // Eliminar el elemento en la posición especificada
                }
                else
                {
                    MessageBox.Show("La posición está fuera del rango");
                }
            }
            else
            {
                MessageBox.Show("Ingrese una posición válida");
            }

            txtPosicion.Clear();
            txtPosicion.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Milista.Remove(txtValor.Text); // Eliminar el texto especificado de la lista
            txtValor.Clear();
            txtValor.Focus();
        }

        private void btnCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
