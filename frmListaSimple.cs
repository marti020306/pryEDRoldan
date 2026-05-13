using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDRoldan
{
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        clsListaSimple objLista = new clsListaSimple();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodos x = new clsNodos();

            x.Cod = Convert.ToInt32(txtCodigo.Text);
            x.Nom = txtNombre.Text;
            x.Tra = txtTramite.Text;
            objLista.Agregar(x);
            objLista.Recorrer(lstLista);
            objLista.Recorrer(dgvLista);
            objLista.Recorrer(cbxCodigo);
            objLista.Recorrer("clsListaSimple.csv");
            MessageBox.Show("Agregado correctamente");

            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (objLista.Primero != null)
            {
                Int32 x = Convert.ToInt32(cbxCodigo.Text);
                objLista.Eliminar(x);
                objLista.Recorrer(dgvLista);
                objLista.Recorrer(lstLista);
                objLista.Recorrer(cbxCodigo);
                objLista.Recorrer("clsListaSimple.csv");
                MessageBox.Show("Eliminado correctamente");
            }
            else
            {
                MessageBox.Show("No hay elementos para eliminar");
            }
            cbxCodigo.Text = "";
        }

        private void ValidarDatos()
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void cbxCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCodigo.Text != "")
            {
                btnEliminar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
            }
        }
    }
}
