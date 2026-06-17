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
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radIN.Checked)
            {
                objArbol.Recorrer(dgvGrilla);
            }   
        }
        clsArbol objArbol = new clsArbol();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodos Persona = new clsNodos();
            Persona.Cod = Convert.ToInt32(txtCodigo.Text);
            Persona.Nom = txtNombre.Text;
            Persona.Tra = txtTramite.Text;

            //Pasar el nodo al metodoAgregar
            objArbol.Agregar(Persona);

            //Grilla
            objArbol.Recorrer(dgvGrilla);

            //Arbol
            objArbol.Recorrer(treArbol);

            //ComboBox
            objArbol.Recorrer(cmbCodigo);

            //Vector
            int[] vec = new int[10];
            objArbol.Recorrer(vec);


            //Limpiar
            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
            txtCodigo.Focus();

        }

        private void radPRE_CheckedChanged(object sender, EventArgs e)
        {
            if (radPRE.Checked)
            {
                objArbol.RecorrerPreOrden(dgvGrilla);
            }
        }

        private void radPost_CheckedChanged(object sender, EventArgs e)
        {
            if (radPost.Checked)
            {
                objArbol.RecorrerPostOrden(dgvGrilla);
            }
        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            objArbol.Equilibrar();

            objArbol.Recorrer(dgvGrilla);
            objArbol.Recorrer(treArbol);
            objArbol.Recorrer(cmbCodigo);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbCodigo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un código");
                return;
            }

            int codigo = Convert.ToInt32(cmbCodigo.Text);

            objArbol.Eliminar(codigo);

            dgvGrilla.Rows.Clear();
            cmbCodigo.Items.Clear();
            treArbol.Nodes.Clear();

            objArbol.Recorrer(dgvGrilla);
            objArbol.Recorrer(cmbCodigo);
            objArbol.Recorrer(treArbol);
        }
    }
}
