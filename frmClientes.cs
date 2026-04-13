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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                
                txtNombre.Enabled = false;
               
            }
            else
            {
               
                txtNombre.Enabled = true;
                
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtDeuda.Enabled = false;
            }
            else
            {
                txtDeuda.Enabled = true;
            }
        }

        private void txtDeuda_TextChanged(object sender, EventArgs e)
        {
            if (txtDeuda.Text == "")
            {
                btnGrabar.Enabled = false;
            }
            else
            {
                btnGrabar.Enabled = true;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchivo = "Clientes.csv";
            x.Grabar(txtCodigo.Text, txtNombre.Text, txtDeuda.Text);
            x.Recorrer(dgvClientes);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchivo = "Clientes.csv";
            x.Borrar();
            x.Recorrer(dgvClientes);
            MessageBox.Show("Los datos se han borrado correctamente");
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDeuda.Clear();








        }
    }
}
