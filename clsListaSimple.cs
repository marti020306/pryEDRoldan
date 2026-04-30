using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryEDRoldan
{
    internal class clsListaSimple
    {
        private clsNodos pri;


        public clsNodos Primero
        {
            get { return pri; }
            set { pri = value; }
        }

        public void Agregar(clsNodos nuevo)
        {
            if (pri == null)
            {
                pri = nuevo;
            }
            else
            {
                if (nuevo.Cod <= pri.Cod)
                {
                    nuevo.Sig = pri;
                    pri = nuevo;
                }
                else
                {
                    clsNodos aux = pri;
                    clsNodos ant = pri;

                    while (aux.Cod < nuevo.Cod)
                    {
                        aux = aux;
                        aux = aux.Sig;
                        if (aux == null)
                        {
                            break;
                        }
                    }
                    nuevo.Sig = aux;
                    aux.Sig = nuevo;
                }
            }
        }
        public void Recorrer(ListBox Lista)
        {
            clsNodos aux = Primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Cod);
                aux = aux.Sig;
            }
        }

        public void Recorrer(DataGridView Grilla)
        {
            clsNodos aux = pri;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Cod, aux.Nom, aux.Tra);
                aux = aux.Sig;
            }
        }


        public void Eliminar(int cod)
        {
            if (pri != null)
            {
                if (pri.Cod == cod)
                {
                    pri = pri.Sig;
                }
                else
                {
                    clsNodos aux = pri;
                    clsNodos ant = pri;
                    while (aux.Cod != cod)
                    {
                        ant = aux;
                        aux = aux.Sig;
                        if (aux == null)
                        {
                            break;
                        }
                    }
                    if (aux != null)
                    {
                        ant.Sig = aux.Sig;
                    }
                }
            }
        }

        public void Recorrer(String NombreArchivo)
        {
            clsNodos aux = Primero;
            StreamWriter AD = new StreamWriter(NombreArchivo, false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Codigo;Nombre;Tramite");
            while (aux != null)
            {
                AD.Write(aux.Cod);
                AD.Write(";");
                AD.Write(aux.Nom);
                AD.Write(";");
                AD.WriteLine(aux.Tra);
                aux = aux.Sig;

            }
            AD.Close();




        }
        public void Recorrer(ComboBox Combo)
        {
            clsNodos aux = Primero;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Tra);
                aux = aux.Sig;
            }

        }


    }
}
