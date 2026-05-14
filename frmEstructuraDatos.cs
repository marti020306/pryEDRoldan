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
    public partial class frmEstructuraDatos : Form
    {
        public frmEstructuraDatos()
        {
            InitializeComponent();
        }

        private void frmEstructuraDatos_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datosDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosDesarrollador v = new frmDatosDesarrollador();
            v.ShowDialog();
        }

        private void MesesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMeses frmMeses = new frmMeses();
            frmMeses.ShowDialog();
        }

        private void coloresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColores frmColores = new frmColores();
            frmColores.ShowDialog();
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes frmClientes = new frmClientes();
            frmClientes.ShowDialog();
        }

        private void AlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnos frmAlumnos = new frmAlumnos();
            frmAlumnos.ShowDialog();
        }

        private void carerraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCarreras frmCarreras = new frmCarreras();
            frmCarreras.ShowDialog();
        }

       

        private void colaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCola frmCola = new frmCola();
            frmCola.ShowDialog();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila frmPila = new frmPila();   
            frmPila.ShowDialog();
        }

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple frmListaSimple = new frmListaSimple();
            frmListaSimple.ShowDialog();
        }

        private void listaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDoble frm = new frmListaDoble();  
            frm.ShowDialog();
        }

        private void arbolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArbolBinario frmArbol = new frmArbolBinario();
            frmArbol.ShowDialog();
        }
    }
}
