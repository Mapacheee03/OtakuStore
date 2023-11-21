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
    public partial class Manga : Form
    {

        private int i = 0; // Contador para identificar los ítems agregados
        private int posicion = -1; // Variable para almacenar la posición seleccionada en el DataGridView

        public Manga()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string producto, detalle, valor;

            producto = txtProducto.Text;
            detalle = txtDetalles.Text;
            valor = txtValor.Text;
            dgvDetalles.Rows.Add(i + "", producto, detalle, valor);
            i = i + 1;
            limpiar();
            txtProducto.Focus();
        }

        void limpiar()
        {
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            txtProducto.Text = "";
            txtDetalles.Text = "";
            txtValor.Text = "";
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dgvDetalles.CurrentRow.Index;
            txtProducto.Text = dgvDetalles[1, posicion].Value.ToString();
            txtDetalles.Text = dgvDetalles[2, posicion].Value.ToString();
            txtValor.Text = dgvDetalles[4, posicion].Value.ToString();
            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            txtProducto.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string producto, detalle, valor;

            producto = txtProducto.Text;
            detalle = txtDetalles.Text;
            valor = txtValor.Text;
            dgvDetalles[1, posicion].Value = txtProducto.Text;
            dgvDetalles[2, posicion].Value = txtDetalles.Text;
            dgvDetalles[3, posicion].Value = txtValor.Text;
            limpiar();
            txtProducto.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dgvDetalles.Rows.RemoveAt(posicion);
            txtProducto.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            btnAgregar.Enabled = true;
            txtProducto.Focus();
        }
    }
}
