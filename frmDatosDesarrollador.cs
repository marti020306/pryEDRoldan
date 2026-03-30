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
    public partial class frmDatosDesarrollador : Form
    {
        public frmDatosDesarrollador()
        {
            InitializeComponent();
        }

        private void lblEdad_Click(object sender, EventArgs e)
        {

        }

        private void frmDatosDesarrollador_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            if (txtEdad.Text == "")
            {
                txtdni.Enabled = false;

            }
                else
                {
                    txtdni.Enabled = true;
                }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtEdad.Enabled = false;
            }
            else
            {
                txtEdad.Enabled = true;
            }
        }

        private void txtdni_TextChanged(object sender, EventArgs e)
        {
            if (txtdni.Text == "")
            {
               txtTelefono.Enabled = false;
            }
            else
            {
              txtTelefono.Enabled = true;

            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "")
            {
                txtNacimiento.Enabled = false;
            }
            else
            {
                txtNacimiento.Enabled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtdni.Clear();
            txtTelefono.Clear();
            txtNacimiento.Clear();
        }

        private void txtNacimiento_TextChanged(object sender, EventArgs e)
        {
            if (txtNacimiento.Text == "")
            {
                btnLimpiar.Enabled = false;
            }
            else
            {
                btnLimpiar.Enabled = true;
            }

            if (txtNombre.Text != "" && txtEdad.Text != "" && txtdni.Text != "" && txtTelefono.Text != "" && txtNacimiento.Text != "")
            {
                btnGuardar.Enabled = true;
            }
            else
            {
                btnGuardar.Enabled = false;
            }
        }
}
    }
