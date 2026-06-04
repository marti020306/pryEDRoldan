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
    public partial class frmBdOperaciones : Form
    {
        public frmBdOperaciones()
        {
            InitializeComponent();
        }
        clsBaseDatos objClaseDatos = new clsBaseDatos();

        //Proyeccion Simple
        private void cmdProySimple_Click(object sender, EventArgs e)
        {
            objClaseDatos.Listar(dgvBaseDatos,
               "SELECT Titulo FROM Libro");
        }

        //Proyeccion Multiple REVISAR
        private void cmdProyMulti_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT Titulo " +
                 "FROM Libro " +
                 "ORDER BY 1 DESC ";
            objClaseDatos.Listar(dgvBaseDatos, varSQL);
        }


           

        //Join
        private void cmdJuntar_Click(object sender, EventArgs e)
        {
            objClaseDatos.Listar(dgvBaseDatos,
               "SELECT * FROM Libro WHERE CodigoLibro = 1");
        }

        private void cmdSelecSimple_Click(object sender, EventArgs e)
        {

        }


      



    }
}
