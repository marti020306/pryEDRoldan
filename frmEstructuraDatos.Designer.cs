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
            this.estructuraNoLinealesToolStripMenuItem});
            this.menDatos.Location = new System.Drawing.Point(0, 0);
            this.menDatos.Name = "menDatos";
            this.menDatos.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menDatos.Size = new System.Drawing.Size(919, 28);
            this.menDatos.TabIndex = 0;
            this.menDatos.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosDelDesarrolladorToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // datosDelDesarrolladorToolStripMenuItem
            // 
            this.datosDelDesarrolladorToolStripMenuItem.Name = "datosDelDesarrolladorToolStripMenuItem";
            this.datosDelDesarrolladorToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.datosDelDesarrolladorToolStripMenuItem.Text = "Datos del Desarrollador";
            this.datosDelDesarrolladorToolStripMenuItem.Click += new System.EventHandler(this.datosDesarrolladorToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
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
            this.toolStripMenuItem1.Size = new System.Drawing.Size(254, 24);
            this.toolStripMenuItem1.Text = "Programacion Orientada a Objetos";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.clientesToolStripMenuItem.Text = "Clientes...";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.ClientesToolStripMenuItem_Click);
            // 
            // coloresToolStripMenuItem
            // 
            this.coloresToolStripMenuItem.Name = "coloresToolStripMenuItem";
            this.coloresToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.coloresToolStripMenuItem.Text = "Colores...";
            this.coloresToolStripMenuItem.Click += new System.EventHandler(this.coloresToolStripMenuItem_Click);
            // 
            // mesesToolStripMenuItem
            // 
            this.mesesToolStripMenuItem.Name = "mesesToolStripMenuItem";
            this.mesesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mesesToolStripMenuItem.Text = "Meses...";
            this.mesesToolStripMenuItem.Click += new System.EventHandler(this.MesesToolStripMenuItem_Click);
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.alumnosToolStripMenuItem.Text = "Alumnos...";
            this.alumnosToolStripMenuItem.Click += new System.EventHandler(this.AlumnosToolStripMenuItem_Click);
            // 
            // carerraToolStripMenuItem
            // 
            this.carerraToolStripMenuItem.Name = "carerraToolStripMenuItem";
            this.carerraToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
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
            this.estructurasLinealesToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.estructurasLinealesToolStripMenuItem.Text = "Estructuras Lineales";
            // 
            // colaToolStripMenuItem
            // 
            this.colaToolStripMenuItem.Name = "colaToolStripMenuItem";
            this.colaToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.colaToolStripMenuItem.Text = "Cola...";
            this.colaToolStripMenuItem.Click += new System.EventHandler(this.colaToolStripMenuItem_Click_1);
            // 
            // pilaToolStripMenuItem
            // 
            this.pilaToolStripMenuItem.Name = "pilaToolStripMenuItem";
            this.pilaToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.pilaToolStripMenuItem.Text = "Pila...";
            this.pilaToolStripMenuItem.Click += new System.EventHandler(this.pilaToolStripMenuItem_Click);
            // 
            // listaSimpleToolStripMenuItem
            // 
            this.listaSimpleToolStripMenuItem.Name = "listaSimpleToolStripMenuItem";
            this.listaSimpleToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.listaSimpleToolStripMenuItem.Text = "Lista Simple...";
            this.listaSimpleToolStripMenuItem.Click += new System.EventHandler(this.listaSimpleToolStripMenuItem_Click);
            // 
            // listaDobleToolStripMenuItem
            // 
            this.listaDobleToolStripMenuItem.Name = "listaDobleToolStripMenuItem";
            this.listaDobleToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.listaDobleToolStripMenuItem.Text = "Lista Doble...";
            this.listaDobleToolStripMenuItem.Click += new System.EventHandler(this.listaDobleToolStripMenuItem_Click);
            // 
            // estructuraNoLinealesToolStripMenuItem
            // 
            this.estructuraNoLinealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arbolToolStripMenuItem,
            this.grafoToolStripMenuItem});
            this.estructuraNoLinealesToolStripMenuItem.Name = "estructuraNoLinealesToolStripMenuItem";
            this.estructuraNoLinealesToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.estructuraNoLinealesToolStripMenuItem.Text = "Estructura No Lineales";
            // 
            // arbolToolStripMenuItem
            // 
            this.arbolToolStripMenuItem.Name = "arbolToolStripMenuItem";
            this.arbolToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.arbolToolStripMenuItem.Text = "Arbol...";
            // 
            // grafoToolStripMenuItem
            // 
            this.grafoToolStripMenuItem.Name = "grafoToolStripMenuItem";
            this.grafoToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.grafoToolStripMenuItem.Text = "Grafo...";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmEstructuraDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryEDRoldan.Properties.Resources.pink_wallpaper_Windows_111;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(919, 450);
            this.Controls.Add(this.menDatos);
            this.MainMenuStrip = this.menDatos;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}

