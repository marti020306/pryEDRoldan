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
            MessageBox.Show("Agregado correctamente");

            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
        }
    }
}
