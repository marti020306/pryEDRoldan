using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDRoldan
{
    internal class clsCola
    {
        //Campos
        private clsNodos pri;
        private clsNodos ult;

        //Propiedades
        public clsNodos Primero
        {
            get { return pri; }
            set { pri = value; }
        }
        public clsNodos Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }

        //Metodos de la clase

        public void Agregar(clsNodos nuevo)
        {
            if (Primero == null)
            {
                Primero = nuevo;
                Ultimo = nuevo;
            }
            else
            {
                Ultimo.Sig = nuevo;
                Ultimo = nuevo;
            }
        }
        public void Eliminar()
        {
            if (Primero == Ultimo)
            {
                Primero = null;
                Ultimo = null;

            }
            else
            {
                Primero = pri.Sig;
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
                Combo.Items.Add(aux.Nom);
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
                AD.Write(";" );
                AD.Write(aux.Nom);
                AD.Write(";" );
                AD.WriteLine(aux.Tra);
                aux = aux.Sig;

            }
            AD.Close();


        }
    }
}
