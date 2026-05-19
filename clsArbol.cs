using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace pryEDRoldan
{
    internal class clsArbol
    {
        private clsNodos Pri;

        public clsNodos Raiz
        {
            get { return Pri; }
            set { Pri = value; }
        }

        public void Agregar(clsNodos Nvo)
        {
            if (Raiz == null)
            {
                Raiz = Nvo;
            }
            else
            {
                clsNodos P = Raiz;//ant
                clsNodos Aux = Raiz;
                while (Aux != null)
                {
                    P = Aux;
                    if (Nvo.Cod < Aux.Cod)
                    {
                        Aux = Aux.Izquierdo;
                    }
                    else
                    {
                        Aux = Aux.Derecho;
                    }
                }

                if (Nvo.Cod < P.Cod)
                {
                    P.Izquierdo = Nvo;
                }
                else
                {
                    P.Derecho = Nvo;
                }
            }
        }

        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }

        private void InOrdenAsc(DataGridView Dgv, clsNodos R)
        {
            if (R.Izquierdo != null)
            {
                InOrdenAsc(Dgv, R.Izquierdo);
            }
            if (R.Derecho != null)
            {
                InOrdenAsc(Dgv, R.Derecho);
            }
        }

        public void Recorrer(ComboBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
        }
        private void InOrdenAsc(ComboBox Lst, clsNodos R)
        {
            if (R.Izquierdo != null)
            {
                InOrdenAsc(Lst, R.Izquierdo);
            }
            if (R.Derecho != null)
            {
                InOrdenAsc(Lst, R.Derecho);
            }
        }
    }
}
