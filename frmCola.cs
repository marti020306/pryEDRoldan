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
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }
        clsCola ColaEspera = new clsCola(); //Global
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodos Persona = new clsNodos();
            Persona.Cod = Convert.ToInt32(txtCodigo.Text);
            Persona.Nom = txtNombre.Text;
            Persona.Tra = textBox3.Text;

            ColaEspera.Agregar(Persona);
            MessageBox.Show("Persona Agregada a la Cola de Espera");
            ColaEspera.Recorrer(lstLista);
            ColaEspera.Recorrer(dgvCola);
            ColaEspera.Recorrer("Cola.csv");

            txtCodigo.Clear();
            txtNombre.Clear();
            textBox3.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ColaEspera.Primero != null)
            {
               lblBlancoCodigo.Text = Convert.ToString(ColaEspera.Primero.Cod);
               lblBlancoNombre.Text = ColaEspera.Primero.Nom;
               lblBlancoTramite.Text = ColaEspera.Primero.Tra;
    
                 ColaEspera.Eliminar();
                 MessageBox.Show("Persona Eliminada de la Cola de Espera");
                 ColaEspera.Recorrer(lstLista);
                 ColaEspera.Recorrer(dgvCola);
                 ColaEspera.Recorrer("Cola.csv");

            }
            else
            {
               lblBlancoCodigo.Text = "";
               lblBlancoNombre.Text = "";
               lblBlancoTramite.Text = "";
            }
        }

        private void frmCola_Load(object sender, EventArgs e)
        {

        }
    }
}
