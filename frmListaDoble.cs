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
    public partial class frmListaDoble : Form
    {
        clsListaDoble objListaD = new clsListaDoble();
        public frmListaDoble()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodos x = new clsNodos();
            x.Cod = Convert.ToInt32(txtCodigo.Text);
            x.Nom = txtNombre.Text;
            x.Tra = txtTramite.Text;

            objListaD.Agregar(x);
            objListaD.Recorrer(dgvLista);
            objListaD.Recorrer(cbxCodigo);
            objListaD.Recorrer(lstDoble);
            objListaD.Recorrer("clsListaDoble.csv");

            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (objListaD.Primero != null)
            {
                Int32 x = Convert.ToInt32(cbxCodigo.Text);
                objListaD.Eliminar(x);
                objListaD.Recorrer(dgvLista);
                objListaD.Recorrer(lstDoble);
                objListaD.Recorrer(cbxCodigo);
                objListaD.Recorrer("clsListaDoble.csv");
                MessageBox.Show("Elemento eliminado");
            }
            else
            {
                MessageBox.Show("No hay elementos para eliminar");
            }
            btnEliminar.Enabled = false;
            cbxCodigo.Text = "";

        }

        private void radAscendente_CheckedChanged(object sender, EventArgs e)
        {
            if (radAscendente.Checked == true)
            {
                objListaD.RecorrerAsc(dgvLista);
            }
        }

        private void radDescendente_CheckedChanged(object sender, EventArgs e)
        {
            if (radDescendente.Checked == true)
            {
                objListaD.RecorrerDes(dgvLista);
            }
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
