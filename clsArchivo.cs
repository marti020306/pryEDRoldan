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
        public string NomArchivo = "";
    
       

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
        
        public void Borrar()
        {
            StreamWriter AD = new StreamWriter(NomArchivo, false);
            AD.Close();

        }

        public void Grabar(String Dato1, String Dato2, String Dato3)
        {
            StreamWriter AD = new StreamWriter(NomArchivo, true);
            AD.Write(Dato1);
            AD.Write(";");
            AD.Write(Dato2);
            AD.Write(";");
            AD.WriteLine(Dato3);
            AD.Close();

        }
    }
}   
