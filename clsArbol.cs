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
            if (Raiz == null) return;
            InOrdenAsc(Grilla, Raiz);
        }

        private void InOrdenAsc(DataGridView Dgv, clsNodos R)
        {
            if (R == null) return;

            if (R.Izquierdo != null)
            {
                InOrdenAsc(Dgv, R.Izquierdo);
            }

            // Añadir el nodo actual en in-orden
            Dgv.Rows.Add(R.Cod, R.Nom, R.Tra);

            if (R.Derecho != null)
            {
                InOrdenAsc(Dgv, R.Derecho);
            }
        }


        private void InOrdenAsc(ComboBox Lst, clsNodos R)
        {
            if (R == null) return;

            if (R.Izquierdo != null)
            {
                InOrdenAsc(Lst, R.Izquierdo);
            }
            Lst.Items.Add(R.Cod); //primero del nodo
            if (R.Derecho != null)
            {
                InOrdenAsc(Lst, R.Derecho);
            }
        }


        private void PreOrden(DataGridView Dgv, clsNodos R)
        {
            if (R != null)
            {
                Dgv.Rows.Add(R.Cod, R.Nom, R.Tra); //primero del nodo

                if (R.Izquierdo != null)
                {
                    PreOrden(Dgv, R.Izquierdo);
                }
                if (R.Derecho != null)
                {
                    PreOrden(Dgv, R.Derecho);
                }
            }
        }

        private void PostOrden(DataGridView Dgv, clsNodos R)
        {
            if (R == null) return;

            if (R.Izquierdo != null)
            {
                PostOrden(Dgv, R.Izquierdo);

            }
            if (R.Derecho != null)
            {
                PostOrden(Dgv, R.Derecho);
            }
            Dgv.Rows.Add(R.Cod, R.Nom, R.Tra); //ultimo del nodo
        }

        //Recorrer grilla pre-orden y post-orden

        public void RecorrerPreOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            if (Raiz == null) return;
            PreOrden(Grilla, Raiz);
        }

        public void RecorrerPostOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            if (Raiz == null) return;
            PostOrden(Grilla, Raiz);
        }

        //mostrar en el TreeView/Arbol

        private void PreOrden(clsNodos R, TreeNode nodoTreeView)
        {
            if (R == null) return;

            TreeNode NodoPadre = new TreeNode(R.Cod.ToString());
            nodoTreeView.Nodes.Add(NodoPadre);
            if (R.Izquierdo != null)
            {
                PreOrden(R.Izquierdo, NodoPadre);
            }
            if (R.Derecho != null)
            {
                PreOrden(R.Derecho, NodoPadre);
            }


        }

        public void Recorrer(TreeView tree)
        {
            tree.Nodes.Clear();
            if (Raiz == null) return;
            TreeNode NodoPadre = new TreeNode("Arbol");
            tree.Nodes.Add(NodoPadre);
            PreOrden(Raiz, NodoPadre);
            tree.ExpandAll();

        }

        //Sobrecarga para comboBox

        public void Recorrer(ComboBox Lista)
        {
            Lista.Items.Clear();
            if (Raiz == null) return;
            InOrdenAsc(Lista, Raiz);
        }


        //Sobrecarga a un vector

        private void InOrdenAsc(int[] Vec, clsNodos R, ref int i)
        {
            //ref: Evita que se pisen los datos, compartiendo el mismo i e incrementandolo

            if (R == null) return;

            if (R.Izquierdo != null)
            {
                InOrdenAsc(Vec, R.Izquierdo, ref i);
            }
            Vec[i] = R.Cod;
            i++;
            if (R.Derecho != null)
            {
                InOrdenAsc(Vec, R.Derecho, ref i);
            }
        }

        public void Recorrer(int[] Vector)
        {
            int indice = 0;
            if (Raiz == null) return;
            InOrdenAsc(Vector, Raiz, ref indice);
        }

        public void Vaciar()
        {
            Raiz = null;
        }


        private void Equilibrar(int[] vec, int inicio, int fin)
        {
            if (inicio > fin) return;

            int medio = (inicio + fin) / 2;

            clsNodos nodo = new clsNodos();
            nodo.Cod = vec[medio];
            nodo.Nom = "";
            nodo.Tra = "";

            Agregar(nodo);

            Equilibrar(vec, inicio, medio - 1);
            Equilibrar(vec, medio + 1, fin);
        }

        public void Equilibrar()
        {
            int[] vec = new int[100];

            Recorrer(vec);

            int cantidad = 0;

            for (int i = 0; i < vec.Length; i++)
            {
                if (vec[i] != 0)
                    cantidad++;
            }

            Vaciar();

            Equilibrar(vec, 0, cantidad - 1);
        }

        private clsNodos EliminarNodo(clsNodos raiz, int codigo)
        {
            if (raiz == null)
                return null;

            if (codigo < raiz.Cod)
            {
                raiz.Izquierdo = EliminarNodo(raiz.Izquierdo, codigo);
            }
            else if (codigo > raiz.Cod)
            {
                raiz.Derecho = EliminarNodo(raiz.Derecho, codigo);
            }
            else
            {
                if (raiz.Izquierdo == null)
                    return raiz.Derecho;

                if (raiz.Derecho == null)
                    return raiz.Izquierdo;

                clsNodos aux = Menor(raiz.Derecho);

                raiz.Cod = aux.Cod;
                raiz.Nom = aux.Nom;
                raiz.Tra = aux.Tra;

                raiz.Derecho = EliminarNodo(raiz.Derecho, aux.Cod);
            }

            return raiz;
        }

        private clsNodos Menor(clsNodos nodo)
        {
            while (nodo.Izquierdo != null)
                nodo = nodo.Izquierdo;

            return nodo;
        }

        public void Eliminar(int codigo)
        {
            Raiz = EliminarNodo(Raiz, codigo);
        }






    }   
}