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
    public partial class frmBdConsultaSql : Form
    {
        public frmBdConsultaSql()
        {
            InitializeComponent();
        }
        clsBaseDatos objBaseDatos = new clsBaseDatos();
        private void cmdListar_Click(object sender, EventArgs e)
        {
            if (txtConsulta.Text != "")
            {
                objBaseDatos.Listar(dgvConsultaSQL, txtConsulta.Text);
            }
            else
            {
                MessageBox.Show("Ingrese una consulta SQL");
            }
        }

        private void frmBdConsultaSql_Load(object sender, EventArgs e)
        {

        }
    }
}
