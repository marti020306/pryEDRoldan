using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace pryEDRoldan
{
    internal class clsBaseDatos
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string CadenaConexion1 = "Provider=Microsoft.JetOLEDB.4.0;Data Source=Libreria.mdb";
        private string CadenaConexion2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Libreria.mdb";

        public void Listar(DataGridView Grilla) 
        {
            try
            {

                conexion.ConnectionString = CadenaConexion2;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Libro";

                DataSet Ds = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(Ds, "Libro");

                Grilla.DataSource = null;
                Grilla.DataSource = Ds.Tables["Libro"];

                conexion.Close();
            }
            catch (Exception x) 
            {
                MessageBox.Show(x.ToString());

            }

            

        }

        public void Listar(String tabla, DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion2;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = tabla;

                DataSet Ds = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(Ds, tabla);

                Grilla.DataSource = null;
                Grilla.DataSource = Ds.Tables[tabla];

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conexion.Close();
            }
        }

        public void Listar(DataGridView Grilla, String varInstruccionSQL)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion2;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = varInstruccionSQL;

                adaptador = new OleDbDataAdapter(comando);
                DataSet Ds = new DataSet();
                adaptador.Fill(Ds, "Resultado");

                Grilla.DataSource = null;
                Grilla.DataSource = Ds.Tables["Resultado"];

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conexion.Close();
            }
        }


    }
}
