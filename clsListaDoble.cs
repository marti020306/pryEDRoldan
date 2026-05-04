using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace pryEDRoldan
{
    internal class clsListaDoble
    {
        private clsNodos primero;
        private clsNodos ultimo;

        public clsNodos Primero
        {
            get { return primero; }
            set { primero = value; }
        }

        public clsNodos Ultimo
        {
            get { return ultimo; }
            set { ultimo = value; }
        }

        public void Agregar(clsNodos Nvo)
        {
            if (Primero == null)
            {
                Primero = Nvo;
                Ultimo = Nvo;
            }
            else
            {
                if(Nvo.Cod < Primero.Cod)
                {
                    Nvo.Sig = Primero;
                    Primero.ant = Nvo;
                    Primero = Nvo;
                }
                else if (Nvo.Cod > Ultimo.Cod)
                {
                    Ultimo.Sig = Nvo;
                    Nvo.ant = Ultimo;
                    Ultimo = Nvo;
                }
                else
                {
                    clsNodos Aux = Primero;
                    clsNodos Ant = Primero;

                    while (Aux.Cod < Nvo.Cod)
                    {
                        
                        Ant = Aux;
                        Aux = Aux.Sig;
                    }
                    Ant.Sig = Nvo;
                    Nvo.Sig = Aux;
                    Aux.anterior = Nvo;
                    Nvo.anterior = Ant;
                }
            }

        }


    }
}
