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
                // Eliminar y obtener el nodo eliminado
                clsNodos eliminado = objPila.Eliminar();

                if (eliminado != null)
                {
                    // Mostrar los datos del elemento eliminado en las etiquetas lblBlanco
                    lblCodigoBlanco.Text = eliminado.Cod.ToString();
                    lblNombreBlanco.Text = eliminado.Nom;
                    lblTramiteBlanco.Text = eliminado.Tra;

                    // Actualizar vistas y archivo
                    objPila.Recorrer(dgvPila);
                    objPila.Recorrer(lstPila);
                    objPila.Recorrer("Pila.csv");

                    MessageBox.Show("Elemento eliminado correctamente");
                }
                else
                {
                    // Caso improbable: no se pudo eliminar
                    lblCodigoBlanco.Text = "";
                    lblNombreBlanco.Text = "";
                    lblTramiteBlanco.Text = "";
                    MessageBox.Show("Error al eliminar elemento");
                }
            }
            else
            {
                lblCodigoBlanco.Text = "";
                lblNombreBlanco.Text = "";
                lblTramiteBlanco.Text = "";
                MessageBox.Show("No hay Personas en la pila");
            }
        }
    }
}
