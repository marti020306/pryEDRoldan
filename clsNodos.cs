using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace pryEDRoldan
{
    internal class clsNodos
    {
        //campo del nodos
        private Int32 cod;
        private String nom;
        private String tra;
        private clsNodos sig;
        private clsNodos ant;
       

        //Propiedades del nodo
        public Int32 Cod
        {
            get { return cod; }
            set { cod = value; }
        }

        public clsNodos Sig
        {
            get { return sig; }
            set { sig = value; }
        }

        public String Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public String Tra
        {
            get { return tra; }
            set { tra = value; }
        }

        public clsNodos anterior
        {
            get { return ant; }
            set { ant = value; }
        }

        

    }
}
