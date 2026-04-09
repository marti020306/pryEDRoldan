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
    public partial class frmCarreras : Form
    {
        public frmCarreras()
        {
            InitializeComponent();
        }

        private void txtCarreras_TextChanged(object sender, EventArgs e)
        {
            if (txtCarreras.Text != "")
            {
                btnGrabar.Enabled = true;
               
            }
            else
            {
                btnGrabar.Enabled = false;
               
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchivo = "Carreras.csv";
            x.Grabar(txtCarreras.Text);
            x.Recorrer(lstCarrera);
            MessageBox.Show("El mes " + txtCarreras.Text + " se ha grabado correctamente");

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchivo = "Carreras.csv";
            x.Borrar();
            x.Recorrer(lstCarrera);
            MessageBox.Show("Los datos se han borrado correctamente");
        }
    }
}
