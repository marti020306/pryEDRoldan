using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
    }
}
