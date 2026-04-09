using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDRoldan
{
    public partial class frmMeses : Form
    {
        public frmMeses()
        {
            InitializeComponent();
        }

        private void frmMeses_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                btnListar.Enabled = false;
            }

            else
            {
                btnListar.Enabled = true;
            }

            if (txtNombre.Text == "")
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
            x.NomArchivo = "Meses.txt";
            x.Grabar(txtNombre.Text);
            x.Recorrer(lstMeses); 
            MessageBox.Show("El mes " + txtNombre.Text + " se ha grabado correctamente");
        }
    }
}
