using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace pryEDRoldan
{
    internal class clsArchivo
    {
        public string NomArchivo = "Colores.txt";
    
        public void Grabar()
        {
            StreamWriter AD = new StreamWriter(NomArchivo);
            AD.WriteLine("Hola!!");
            AD.Close();
        }

        public void Grabar( String Dato)
        {
            StreamWriter AD = new StreamWriter(NomArchivo, true);
            AD.WriteLine(Dato);
            AD.Close();
        }

        public void Recorrer(ListBox lstDatos)
        {

            lstDatos.Items.Clear();
            string DatoLeido = "";
            StreamReader AD = new StreamReader(NomArchivo);
            DatoLeido = AD.ReadLine();
            while (DatoLeido != null)
            {
                lstDatos.Items.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            AD.Close();

           


        }

        public string NombreMeses = "Meses.txt";
            public void GrabarMeses(string DatoMeses)
            {
                StreamWriter AD = new StreamWriter(NombreMeses);
                AD.WriteLine(DatoMeses);
               
                AD.Close();

            }

           public void RecorrerMeses(ListBox lstDatos)
           {
                lstDatos.Items.Clear();
                string DatoLeido = "";
                StreamReader AD = new StreamReader(NombreMeses);
                DatoLeido = AD.ReadLine();
                while (DatoLeido != null)
                {
                    lstDatos.Items.Add(DatoLeido);
                    DatoLeido = AD.ReadLine();
                }
                AD.Close();
           }


        public string NombreClientes = "Clientes.txt";

        public void GrabarClientes(string DatoClientes)
        {
            StreamWriter AD = new StreamWriter(NombreClientes);
            AD.WriteLine(DatoClientes);
            AD.Close();
        }






    }
}
