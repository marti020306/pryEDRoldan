using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDRoldan
{
    internal class clsGrafo
    {
        //Vector

        private String[] Ciudades = new string[] { "Cordoba", "Mendoza", "Santa Fe", "Buenos Aires", "Salta" };

        //matriz
        private Decimal[,] Precio = new decimal[5, 5];

        //metodos Matriz

        public void Agregar(Int32 f, Int32 c, Decimal p)
        {
            Precio[f, c] = p;
        }

        public void Eliminar(Int32 f, Int32 c)
        {
            Precio[f, c] = 0;
        }

        public Decimal Consultar(Int32 f, Int32 c)
        {
            return Precio[f, c];
        }

        public void MostrarDestinos(Int32 f, DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            Grilla.Columns.Clear();
            Grilla.Columns.Add("Col1", "Destino");
            Grilla.Columns.Add("Col2", "Precio");
            Grilla.Columns[0].Width = 200;
            Grilla.Columns[1].Width = 200;

            if (f < 0 || f >= Ciudades.Length) return;

            for (Int32 c = 0; c < Ciudades.Length; c++)
            {
                if (Precio[f, c] > 0)
                {
                    Grilla.Rows.Add(Ciudades[c], Precio[f, c]);
                }
            }
        }

        public void MostrarTodo(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            Grilla.Columns.Clear();

                Grilla.Columns.Add("Origen", "Origen");
            for (Int32 i = 0; i < Ciudades.Length; i++)
            {
                Grilla.Columns.Add("Destino" + i.ToString(), Ciudades[i]);
            }

            for (Int32 f = 0; f < Ciudades.Length; f++)
            {
                Int32 rowIndex = Grilla.Rows.Add();
                Grilla.Rows[rowIndex].Cells[0].Value = Ciudades[f];
                for (Int32 c = 0; c < Ciudades.Length; c++)
                {
                    Grilla.Rows[rowIndex].Cells[c + 1].Value = Precio[f, c];
                }
            }
        }

        public void MostrarCiudades(ComboBox cmb)
        {
            cmb.Items.Clear();
            for (Int32 i = 0; i < Ciudades.Length; i++)
            {
                cmb.Items.Add(Ciudades[i]);
            }
            if (cmb.Items.Count > 0)
            {
                cmb.SelectedIndex = 0;
            }
        }

        public void BorrarTodo() 
        {
            for (Int32  f = 0;  f < 5;  f++)
            {
                for (Int32 c = 0; c < 5; c++) 
                { 
                    Precio[f, c] = 0;
                }
            }

        }


        public void MostrarOrigenes(Int32 destino, DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            Grilla.Columns.Clear();

            Grilla.Columns.Add("Col1", "Origen");
            Grilla.Columns.Add("Col2", "Precio");

            Grilla.Columns[0].Width = 200;
            Grilla.Columns[1].Width = 200;

            if (destino < 0 || destino >= Ciudades.Length) return;

            for (Int32 f = 0; f < Ciudades.Length; f++)
            {
                if (Precio[f, destino] > 0)
                {
                    Grilla.Rows.Add(Ciudades[f], Precio[f, destino]);
                }
            }
        }




    }
}
