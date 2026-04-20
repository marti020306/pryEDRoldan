using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryEDRoldan
{
    internal class clsNodos
    {
        //campo del nodos
        private Int32 cod;
        private String nom;
        private String tra;
        private clsNodos sig;

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
    }
}
