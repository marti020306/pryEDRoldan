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
    public partial class frmGrafo : Form
    {
        public frmGrafo()
        {
            InitializeComponent();

            objGrafo.MostrarCiudades(cbOrigen);
            objGrafo.MostrarCiudades(cbDestino);

            objGrafo.MostrarCiudades(cbOrigen2);
            objGrafo.MostrarCiudades(cbDestino2);

            objGrafo.MostrarCiudades(cbDesde);
            objGrafo.MostrarCiudades(cbHasta);
        }
        clsGrafo objGrafo = new clsGrafo();

       

        private void gbListar_Enter(object sender, EventArgs e)
        {

        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            int fila = cbOrigen.SelectedIndex;
            int columna = cbDestino.SelectedIndex;
            decimal precio = Convert.ToDecimal(txtPrecio.Text);

            objGrafo.Agregar(fila, columna, precio);

            txtPrecio.Clear();
            txtPrecio.Focus();
        }

        private void frmGrafo_Load(object sender, EventArgs e)
        {

        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            int fila = cbOrigen.SelectedIndex;
            int columna = cbDestino.SelectedIndex;

            objGrafo.Eliminar(fila, columna);
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            int fila = cbOrigen2.SelectedIndex;
            int columna = cbDestino2.SelectedIndex;

            txtPrecio2.Text = objGrafo.Consultar(fila, columna).ToString();
        }

        private void cmdVerTodo_Click(object sender, EventArgs e)
        {
            objGrafo.MostrarTodo(dgvProvincias);
        }

        private void cmdListarDestinos_Click(object sender, EventArgs e)
        {
            objGrafo.MostrarDestinos(cbDesde.SelectedIndex, dgvProvincias);
        }

        private void cmdBorrarTodo_Click(object sender, EventArgs e)
        {
            objGrafo.BorrarTodo();
            dgvProvincias.Rows.Clear();
        }
    }
}
