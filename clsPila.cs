using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;

namespace pryEDRoldan
{
    internal class clsPila
    {
        private clsNodos pri;

        public clsNodos Primero 
        { 
            get { return pri; }
            set { pri = value; }
        }
        
        public void Agregar(clsNodos Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
            }
            else
            {
                Nuevo.Sig = Primero;
                Primero = Nuevo;
            }
        }

        // Ahora devuelve el nodo eliminado para que el formulario pueda mostrar sus datos
        public clsNodos Eliminar()
        {
            if (Primero == null)
            {
                return null;
            }

            clsNodos eliminado = Primero;
            Primero = Primero.Sig;
            eliminado.Sig = null; // desconectar el nodo eliminado
            return eliminado;
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

        public void Recorrer(string NombreArchivo)
        {
            clsNodos aux = Primero;
            using (var AD = new StreamWriter(NombreArchivo, false, Encoding.UTF8))
            {
                AD.WriteLine("Lista de espera");
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
            }
        }
    }
}
