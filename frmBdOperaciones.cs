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
            String varSQL = "SELECT TITULO " +
                         "FROM LIBRO " +
                         "ORDER BY 1 DESC";
            objClaseDatos.Listar(dgvBaseDatos, varSQL);
        }

        //Proyeccion Multiple 
        private void cmdProyMulti_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT TITULO, AÑO " +
                          "FROM LIBRO " +
                          "ORDER BY TITULO ASC";
            objClaseDatos.Listar(dgvBaseDatos, varSQL);
        }


           

        //Join
        private void cmdJuntar_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT TITULO, NOMBRE  " +
                         "from LIBRO inner join PAIS " +
                         "on LIBRO.IDPAIS = PAIS.IDPAIS";
            objClaseDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void cmdSelecSimple_Click(object sender, EventArgs e)
        {

        }

        private void frmBdOperaciones_Load(object sender, EventArgs e)
        {

        }

        private void cmdSelecConv_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * " +
                         "FROM (select * from libro where idIdioma > 1 ) as X " +
                         "WHERE IDPAIS = 2 ";
            objClaseDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void cmdInterseccion_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * from libro " +
                          "where idIdioma = 2 and " +
                          "idLibro in " +
                          "(Select idLibro from libro where IdPais = 3 ) " +
                          "order by 1 asc ";
            objClaseDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void cmdDiferencia_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * from libro " +
                          "where idIdioma = 2 and " +
                          "idLibro not in " +
                          "(Select idLibro from libro where IdPais = 3 ) " +
                          "order by 1 asc ";
            objClaseDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void cmdUnion_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * " +
                         "FROM LIBRO " +
                         "WHERE IDIDIOMA = 1 " +
                         "UNION " +
                         "SELECT * " +
                         "FROM LIBRO " +
                         "WHERE IDIDIOMA = 2";
            objClaseDatos.Listar(dgvBaseDatos, varSQL);
        }
    }
}
