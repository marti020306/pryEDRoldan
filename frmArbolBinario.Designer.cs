namespace pryEDRoldan
{
    partial class frmArbolBinario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treArbol = new System.Windows.Forms.TreeView();
            this.grbNuevo = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.Tramite = new System.Windows.Forms.Label();
            this.grbEliminar = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cmbCodigo = new System.Windows.Forms.ComboBox();
            this.lblCodigo1 = new System.Windows.Forms.Label();
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.grbArbol = new System.Windows.Forms.GroupBox();
            this.radPost = new System.Windows.Forms.RadioButton();
            this.radPRE = new System.Windows.Forms.RadioButton();
            this.radIN = new System.Windows.Forms.RadioButton();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbNuevo.SuspendLayout();
            this.grbEliminar.SuspendLayout();
            this.grbArbol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // treArbol
            // 
            this.treArbol.Location = new System.Drawing.Point(16, 15);
            this.treArbol.Margin = new System.Windows.Forms.Padding(4);
            this.treArbol.Name = "treArbol";
            this.treArbol.Size = new System.Drawing.Size(241, 234);
            this.treArbol.TabIndex = 0;
            // 
            // grbNuevo
            // 
            this.grbNuevo.Controls.Add(this.btnAgregar);
            this.grbNuevo.Controls.Add(this.txtTramite);
            this.grbNuevo.Controls.Add(this.txtNombre);
            this.grbNuevo.Controls.Add(this.txtCodigo);
            this.grbNuevo.Controls.Add(this.lblCodigo);
            this.grbNuevo.Controls.Add(this.lblNombre);
            this.grbNuevo.Controls.Add(this.Tramite);
            this.grbNuevo.Location = new System.Drawing.Point(280, 15);
            this.grbNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.grbNuevo.Name = "grbNuevo";
            this.grbNuevo.Padding = new System.Windows.Forms.Padding(4);
            this.grbNuevo.Size = new System.Drawing.Size(267, 235);
            this.grbNuevo.TabIndex = 1;
            this.grbNuevo.TabStop = false;
            this.grbNuevo.Text = "Nuevo Elemento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(53, 199);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(143, 28);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(107, 149);
            this.txtTramite.Margin = new System.Windows.Forms.Padding(4);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(132, 22);
            this.txtTramite.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(107, 89);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 22);
            this.txtNombre.TabIndex = 6;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(107, 34);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(132, 22);
            this.txtCodigo.TabIndex = 5;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(20, 38);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(51, 16);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 97);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // Tramite
            // 
            this.Tramite.AutoSize = true;
            this.Tramite.Location = new System.Drawing.Point(20, 149);
            this.Tramite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Tramite.Name = "Tramite";
            this.Tramite.Size = new System.Drawing.Size(53, 16);
            this.Tramite.TabIndex = 4;
            this.Tramite.Text = "Tramite";
            // 
            // grbEliminar
            // 
            this.grbEliminar.Controls.Add(this.btnEliminar);
            this.grbEliminar.Controls.Add(this.cmbCodigo);
            this.grbEliminar.Controls.Add(this.lblCodigo1);
            this.grbEliminar.Location = new System.Drawing.Point(567, 15);
            this.grbEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.grbEliminar.Name = "grbEliminar";
            this.grbEliminar.Padding = new System.Windows.Forms.Padding(4);
            this.grbEliminar.Size = new System.Drawing.Size(267, 151);
            this.grbEliminar.TabIndex = 0;
            this.grbEliminar.TabStop = false;
            this.grbEliminar.Text = "Elemento a Eliminar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(71, 97);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(128, 28);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Location = new System.Drawing.Point(97, 48);
            this.cmbCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(143, 24);
            this.cmbCodigo.TabIndex = 8;
            // 
            // lblCodigo1
            // 
            this.lblCodigo1.AutoSize = true;
            this.lblCodigo1.Location = new System.Drawing.Point(25, 52);
            this.lblCodigo1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo1.Name = "lblCodigo1";
            this.lblCodigo1.Size = new System.Drawing.Size(51, 16);
            this.lblCodigo1.TabIndex = 5;
            this.lblCodigo1.Text = "Codigo";
            // 
            // btnEquilibrar
            // 
            this.btnEquilibrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquilibrar.Location = new System.Drawing.Point(596, 191);
            this.btnEquilibrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(180, 37);
            this.btnEquilibrar.TabIndex = 10;
            this.btnEquilibrar.Text = "Equilibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            // 
            // grbArbol
            // 
            this.grbArbol.Controls.Add(this.radPost);
            this.grbArbol.Controls.Add(this.radPRE);
            this.grbArbol.Controls.Add(this.radIN);
            this.grbArbol.Controls.Add(this.dgvGrilla);
            this.grbArbol.Location = new System.Drawing.Point(16, 271);
            this.grbArbol.Margin = new System.Windows.Forms.Padding(4);
            this.grbArbol.Name = "grbArbol";
            this.grbArbol.Padding = new System.Windows.Forms.Padding(4);
            this.grbArbol.Size = new System.Drawing.Size(817, 268);
            this.grbArbol.TabIndex = 11;
            this.grbArbol.TabStop = false;
            this.grbArbol.Text = "Listado Del Arbol";
            // 
            // radPost
            // 
            this.radPost.AutoSize = true;
            this.radPost.Location = new System.Drawing.Point(24, 166);
            this.radPost.Margin = new System.Windows.Forms.Padding(4);
            this.radPost.Name = "radPost";
            this.radPost.Size = new System.Drawing.Size(96, 20);
            this.radPost.TabIndex = 2;
            this.radPost.TabStop = true;
            this.radPost.Text = "Post-Orden";
            this.radPost.UseVisualStyleBackColor = true;
            this.radPost.CheckedChanged += new System.EventHandler(this.radPost_CheckedChanged);
            // 
            // radPRE
            // 
            this.radPRE.AutoSize = true;
            this.radPRE.Location = new System.Drawing.Point(24, 105);
            this.radPRE.Margin = new System.Windows.Forms.Padding(4);
            this.radPRE.Name = "radPRE";
            this.radPRE.Size = new System.Drawing.Size(90, 20);
            this.radPRE.TabIndex = 1;
            this.radPRE.TabStop = true;
            this.radPRE.Text = "Pre-Orden";
            this.radPRE.UseVisualStyleBackColor = true;
            this.radPRE.CheckedChanged += new System.EventHandler(this.radPRE_CheckedChanged);
            // 
            // radIN
            // 
            this.radIN.AutoSize = true;
            this.radIN.Location = new System.Drawing.Point(24, 42);
            this.radIN.Margin = new System.Windows.Forms.Padding(4);
            this.radIN.Name = "radIN";
            this.radIN.Size = new System.Drawing.Size(79, 20);
            this.radIN.TabIndex = 0;
            this.radIN.TabStop = true;
            this.radIN.Text = "In-Orden";
            this.radIN.UseVisualStyleBackColor = true;
            this.radIN.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvGrilla.Location = new System.Drawing.Point(181, 23);
            this.dgvGrilla.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.RowHeadersWidth = 51;
            this.dgvGrilla.Size = new System.Drawing.Size(611, 219);
            this.dgvGrilla.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 180;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tramite";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 554);
            this.Controls.Add(this.grbArbol);
            this.Controls.Add(this.btnEquilibrar);
            this.Controls.Add(this.grbEliminar);
            this.Controls.Add(this.grbNuevo);
            this.Controls.Add(this.treArbol);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmArbolBinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructuras Ramificadas - Arbol Binario ";
            this.grbNuevo.ResumeLayout(false);
            this.grbNuevo.PerformLayout();
            this.grbEliminar.ResumeLayout(false);
            this.grbEliminar.PerformLayout();
            this.grbArbol.ResumeLayout(false);
            this.grbArbol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treArbol;
        private System.Windows.Forms.GroupBox grbNuevo;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label Tramite;
        private System.Windows.Forms.GroupBox grbEliminar;
        private System.Windows.Forms.ComboBox cmbCodigo;
        private System.Windows.Forms.Label lblCodigo1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEquilibrar;
        private System.Windows.Forms.GroupBox grbArbol;
        private System.Windows.Forms.RadioButton radPost;
        private System.Windows.Forms.RadioButton radPRE;
        private System.Windows.Forms.RadioButton radIN;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}