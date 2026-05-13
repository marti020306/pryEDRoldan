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
                    Primero.anterior = Nvo; 
                    Primero = Nvo;
                }
                else if (Nvo.Cod > Ultimo.Cod)
                {
                    Ultimo.Sig = Nvo;
                    Nvo.anterior = Ultimo; 
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

        public void Recorrer(DataGridView Grilla)
        {
            clsNodos aux = Primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Cod, aux.Nom, aux.Tra);
                aux = aux.Sig;
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

        public void Recorrer(ComboBox Combo)
        {
            clsNodos aux = Primero;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Cod);
                aux = aux.Sig;
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

        public void RecorrerAsc(DataGridView Grilla)
        {
            clsNodos aux = Primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Cod, aux.Nom, aux.Tra);
                aux = aux.Sig;
            }
        }
        public void RecorrerDes(DataGridView Grilla)
        {
            clsNodos aux = Ultimo;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Cod, aux.Nom, aux.Tra);
                aux = aux.anterior;
            }
        }

        public void Eliminar(Int32 Codigo)
        {
            if (Primero.Cod == Codigo && Ultimo == Primero)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                if (Primero.Cod == Codigo)
                {
                    Primero = Primero.Sig;
                    Primero.anterior = null;
                }
                else
                {
                    if (Ultimo.Cod == Codigo)
                    {
                        Ultimo = Ultimo.anterior;
                        Ultimo.Sig = null;
                    }
                    else
                    {
                        clsNodos aux = Primero;
                        clsNodos ant = Primero;
                        while (aux.Cod < Codigo)
                        {
                            ant = aux;
                            aux = aux.Sig;
                        }
                        aux = aux.Sig;
                        ant.Sig = aux;
                        aux.anterior = ant;
                    }
                }
            }


        }







    }
}
