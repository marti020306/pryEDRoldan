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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }
        clsPila objPila = new clsPila();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodos x = new clsNodos();
            x.Cod = Convert.ToInt32(txtCodigo.Text);
            x.Nom = txtNombre.Text;
            x.Tra = txtTramite.Text;

            objPila.Agregar(x);
            objPila.Recorrer(dgvPila);
            objPila.Recorrer(lstPila);
            objPila.Recorrer("Pila.csv");
            MessageBox.Show("Tramite agregado a la pila");

            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (objPila.Primero != null)
            {
                lblCodigoBlanco.Text = objPila.Primero.Cod.ToString();
                lblNombreBlanco.Text = objPila.Primero.Nom;
                lblTramiteBlanco.Text = objPila.Primero.Tra;

                objPila.Eliminar();
                objPila.Recorrer(dgvPila);
                objPila.Recorrer(lstPila);
                objPila.Recorrer("Pila.csv");
                MessageBox.Show("Tramite eliminado de la pila");

            }
            else
            {
                lblCodigoBlanco.Text = "";
                lblNombreBlanco.Text = "";
                lblTramiteBlanco.Text = "";

            }
        }
    }
}
