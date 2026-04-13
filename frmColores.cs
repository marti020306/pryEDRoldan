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
    public partial class frmColores : Form
    {
        public frmColores()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lstColores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                btnGrabar.Enabled = true;
                btnListar.Enabled = true;
            }
            else
            {
                btnGrabar.Enabled = false;
                btnListar.Enabled = false;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
           
            clsArchivo x = new clsArchivo();
            x.NomArchivo = "Colores.txt";
            x.Grabar(txtNombre.Text);
            x.Recorrer(lstColores);
            txtNombre.Clear();

            MessageBox.Show("El color " + txtNombre.Text + " se ha grabado correctamente");
        }

        private void frmColores_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchivo = "Colores.txt";
            x.Borrar();
            x.Recorrer(lstColores);
            txtNombre.Clear();
            MessageBox.Show("Los datos se han borrado correctamente");
            
        }
    }
}
