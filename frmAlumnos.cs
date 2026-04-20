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
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
            CargarCarreras();
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
                cbxCarrera.Enabled = false;
            }

            else
            {
                cbxCarrera.Enabled = true;
            }

            
        }

        private void cbxCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCarrera.Text == "")
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
            x.NomArchivo = "Alumnos.csv";
            x.Grabar(txtCodigo.Text, txtNombre.Text, cbxCarrera.Text);
            x.Recorrer(dgbAlumnos);
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchivo = "Alumnos.csv";
            x.Borrar();
            x.Recorrer(dgbAlumnos);
            MessageBox.Show("Datos eliminados correctamente");
            txtCodigo.Clear();
            txtNombre.Clear();
            cbxCarrera.Text = "";


        } 
        public void CargarCarreras()

        {
            clsArchivo x = new clsArchivo();
            x.NomArchivo = "Carreras.csv";
            x.Recorrer(cbxCarrera);
        }



        private void dgbAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
