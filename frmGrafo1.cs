csharp frmGrafo.cs
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

            MessageBox.Show("Viaje eliminado");
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            int fila = cbOrigen2.SelectedIndex;
            int columna = cbDestino2.SelectedIndex;
            

            decimal precio = objGrafo.Consultar(fila, columna);

            if (precio > 0)
            {
                txtPrecio2.Text = precio.ToString();

                // Obtener nombres de origen y destino (si no hay SelectedItem usar Text)
                string origen = cbOrigen2.SelectedItem != null ? cbOrigen2.SelectedItem.ToString() : cbOrigen2.Text;
                string destino = cbDestino2.SelectedItem != null ? cbDestino2.SelectedItem.ToString() : cbDestino2.Text;

                // Asegurar que la grilla tenga las columnas esperadas antes de agregar filas
                if (dgvProvincias.Columns["Origen"] == null)
                {
                    dgvProvincias.Columns.Clear();
                    dgvProvincias.Columns.Add("Origen", "Origen");
                    dgvProvincias.Columns.Add("Destino", "Destino");
                    dgvProvincias.Columns.Add("Precio", "Precio");
                }

                // Agregar la fila con origen, destino y precio formateado
                dgvProvincias.Rows.Add(origen, destino, precio.ToString("F2"));
            }
            else
                MessageBox.Show("No existe un viaje cargado");
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
            MessageBox.Show("Todos los viajes fueron eliminados");
        }

        private void cmdListarOrigenes_Click(object sender, EventArgs e)
        {
            objGrafo.MostrarOrigenes(cbHasta.SelectedIndex, dgvProvincias);
        }
    }
}