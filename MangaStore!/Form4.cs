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
    public partial class Form4 : Form
    {
        List<int> Milista = new List<int>();
        public Form4()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int n;
            n = int.Parse(txtValor.Text);
            Milista.Add(n);
            txtValor.Clear();
            txtValor.Focus();
        }

        private void btnMostraar_Click(object sender, EventArgs e)
        {

            int i;
            Liver.Items.Clear();
            for (i = 0; i <= Milista.Count - 1; i++)
            {
                Liver.Items.Add(Milista.ElementAt(i));
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int n, pos;
            n = int.Parse(txtValor.Text);
            pos = int.Parse(txtPosicion.Text);
            Milista.Insert(pos, n);
            txtValor.Clear();
            txtValor.Focus();
            txtPosicion.Focus();
            txtPosicion.Clear();
        }

        private void btnEliminarDe_Click(object sender, EventArgs e)
        {
            int pos;
            pos = int.Parse(txtPosicion.Text);
            txtPosicion.Clear();
            txtPosicion.Focus();
            Milista.RemoveAt(pos);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int n;
            n = int.Parse(txtValor.Text);
            Milista.Remove(n);
            txtValor.Clear();
            txtValor.Focus();
        }

        private void btnCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
