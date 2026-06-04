namespace pryEDRoldan
{
    partial class frmEstructuraDatos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menDatos = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDelDesarrolladorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coloresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carerraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estructurasLinealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaSimpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDobleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estructuraNoLinealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arbolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.baseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeUnaTablaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesEnBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasVariasConOperacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // menDatos
            // 
            this.menDatos.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menDatos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.estructurasLinealesToolStripMenuItem,
            this.estructuraNoLinealesToolStripMenuItem,
            this.baseDeDatosToolStripMenuItem});
            this.menDatos.Location = new System.Drawing.Point(0, 0);
            this.menDatos.Name = "menDatos";
            this.menDatos.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menDatos.Size = new System.Drawing.Size(689, 24);
            this.menDatos.TabIndex = 0;
            this.menDatos.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosDelDesarrolladorToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // datosDelDesarrolladorToolStripMenuItem
            // 
            this.datosDelDesarrolladorToolStripMenuItem.Name = "datosDelDesarrolladorToolStripMenuItem";
            this.datosDelDesarrolladorToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.datosDelDesarrolladorToolStripMenuItem.Text = "Datos del Desarrollador";
            this.datosDelDesarrolladorToolStripMenuItem.Click += new System.EventHandler(this.datosDesarrolladorToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.coloresToolStripMenuItem,
            this.mesesToolStripMenuItem,
            this.alumnosToolStripMenuItem,
            this.carerraToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(202, 20);
            this.toolStripMenuItem1.Text = "Programacion Orientada a Objetos";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.clientesToolStripMenuItem.Text = "Clientes...";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.ClientesToolStripMenuItem_Click);
            // 
            // coloresToolStripMenuItem
            // 
            this.coloresToolStripMenuItem.Name = "coloresToolStripMenuItem";
            this.coloresToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.coloresToolStripMenuItem.Text = "Colores...";
            this.coloresToolStripMenuItem.Click += new System.EventHandler(this.coloresToolStripMenuItem_Click);
            // 
            // mesesToolStripMenuItem
            // 
            this.mesesToolStripMenuItem.Name = "mesesToolStripMenuItem";
            this.mesesToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.mesesToolStripMenuItem.Text = "Meses...";
            this.mesesToolStripMenuItem.Click += new System.EventHandler(this.MesesToolStripMenuItem_Click);
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.alumnosToolStripMenuItem.Text = "Alumnos...";
            this.alumnosToolStripMenuItem.Click += new System.EventHandler(this.AlumnosToolStripMenuItem_Click);
            // 
            // carerraToolStripMenuItem
            // 
            this.carerraToolStripMenuItem.Name = "carerraToolStripMenuItem";
            this.carerraToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.carerraToolStripMenuItem.Text = "Carreras...";
            this.carerraToolStripMenuItem.Click += new System.EventHandler(this.carerraToolStripMenuItem_Click);
            // 
            // estructurasLinealesToolStripMenuItem
            // 
            this.estructurasLinealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colaToolStripMenuItem,
            this.pilaToolStripMenuItem,
            this.listaSimpleToolStripMenuItem,
            this.listaDobleToolStripMenuItem});
            this.estructurasLinealesToolStripMenuItem.Name = "estructurasLinealesToolStripMenuItem";
            this.estructurasLinealesToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.estructurasLinealesToolStripMenuItem.Text = "Estructuras Lineales";
            // 
            // colaToolStripMenuItem
            // 
            this.colaToolStripMenuItem.Name = "colaToolStripMenuItem";
            this.colaToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.colaToolStripMenuItem.Text = "Cola...";
            this.colaToolStripMenuItem.Click += new System.EventHandler(this.colaToolStripMenuItem_Click_1);
            // 
            // pilaToolStripMenuItem
            // 
            this.pilaToolStripMenuItem.Name = "pilaToolStripMenuItem";
            this.pilaToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.pilaToolStripMenuItem.Text = "Pila...";
            this.pilaToolStripMenuItem.Click += new System.EventHandler(this.pilaToolStripMenuItem_Click);
            // 
            // listaSimpleToolStripMenuItem
            // 
            this.listaSimpleToolStripMenuItem.Name = "listaSimpleToolStripMenuItem";
            this.listaSimpleToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.listaSimpleToolStripMenuItem.Text = "Lista Simple...";
            this.listaSimpleToolStripMenuItem.Click += new System.EventHandler(this.listaSimpleToolStripMenuItem_Click);
            // 
            // listaDobleToolStripMenuItem
            // 
            this.listaDobleToolStripMenuItem.Name = "listaDobleToolStripMenuItem";
            this.listaDobleToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.listaDobleToolStripMenuItem.Text = "Lista Doble...";
            this.listaDobleToolStripMenuItem.Click += new System.EventHandler(this.listaDobleToolStripMenuItem_Click);
            // 
            // estructuraNoLinealesToolStripMenuItem
            // 
            this.estructuraNoLinealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arbolToolStripMenuItem,
            this.grafoToolStripMenuItem});
            this.estructuraNoLinealesToolStripMenuItem.Name = "estructuraNoLinealesToolStripMenuItem";
            this.estructuraNoLinealesToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.estructuraNoLinealesToolStripMenuItem.Text = "Estructura No Lineales";
            // 
            // arbolToolStripMenuItem
            // 
            this.arbolToolStripMenuItem.Name = "arbolToolStripMenuItem";
            this.arbolToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.arbolToolStripMenuItem.Text = "Arbol...";
            this.arbolToolStripMenuItem.Click += new System.EventHandler(this.arbolToolStripMenuItem_Click);
            // 
            // grafoToolStripMenuItem
            // 
            this.grafoToolStripMenuItem.Name = "grafoToolStripMenuItem";
            this.grafoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.grafoToolStripMenuItem.Text = "Grafo...";
            this.grafoToolStripMenuItem.Click += new System.EventHandler(this.grafoToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // baseDeDatosToolStripMenuItem
            // 
            this.baseDeDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaDeUnaTablaToolStripMenuItem,
            this.consultaDeBaseDeDatosToolStripMenuItem,
            this.operacionesEnBaseDeDatosToolStripMenuItem,
            this.consultasVariasConOperacionesToolStripMenuItem});
            this.baseDeDatosToolStripMenuItem.Name = "baseDeDatosToolStripMenuItem";
            this.baseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.baseDeDatosToolStripMenuItem.Text = "Base de Datos";
            // 
            // consultaDeUnaTablaToolStripMenuItem
            // 
            this.consultaDeUnaTablaToolStripMenuItem.Name = "consultaDeUnaTablaToolStripMenuItem";
            this.consultaDeUnaTablaToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.consultaDeUnaTablaToolStripMenuItem.Text = "Consulta de una tabla...";
            this.consultaDeUnaTablaToolStripMenuItem.Click += new System.EventHandler(this.consultaDeUnaTablaToolStripMenuItem_Click);
            // 
            // consultaDeBaseDeDatosToolStripMenuItem
            // 
            this.consultaDeBaseDeDatosToolStripMenuItem.Name = "consultaDeBaseDeDatosToolStripMenuItem";
            this.consultaDeBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.consultaDeBaseDeDatosToolStripMenuItem.Text = "Consulta de Base de Datos...";
            this.consultaDeBaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.consultaDeBaseDeDatosToolStripMenuItem_Click);
            // 
            // operacionesEnBaseDeDatosToolStripMenuItem
            // 
            this.operacionesEnBaseDeDatosToolStripMenuItem.Name = "operacionesEnBaseDeDatosToolStripMenuItem";
            this.operacionesEnBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.operacionesEnBaseDeDatosToolStripMenuItem.Text = "operaciones en base de Datos";
            this.operacionesEnBaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.operacionesEnBaseDeDatosToolStripMenuItem_Click);
            // 
            // consultasVariasConOperacionesToolStripMenuItem
            // 
            this.consultasVariasConOperacionesToolStripMenuItem.Name = "consultasVariasConOperacionesToolStripMenuItem";
            this.consultasVariasConOperacionesToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.consultasVariasConOperacionesToolStripMenuItem.Text = "Consultas varias con operaciones";
            this.consultasVariasConOperacionesToolStripMenuItem.Click += new System.EventHandler(this.consultasVariasConOperacionesToolStripMenuItem_Click);
            // 
            // frmEstructuraDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryEDRoldan.Properties.Resources.pink_wallpaper_Windows_111;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(689, 366);
            this.Controls.Add(this.menDatos);
            this.MainMenuStrip = this.menDatos;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEstructuraDatos";
            this.Text = "Estructura De Datos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEstructuraDatos_Load);
            this.menDatos.ResumeLayout(false);
            this.menDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menDatos;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datosDelDesarrolladorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coloresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estructurasLinealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaSimpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDobleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estructuraNoLinealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arbolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carerraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeUnaTablaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesEnBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasVariasConOperacionesToolStripMenuItem;
    }
}

