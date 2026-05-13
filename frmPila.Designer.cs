namespace pryEDRoldan
{
    partial class frmPila
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
            this.grbEliminar = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblTramiteBlanco = new System.Windows.Forms.Label();
            this.lblNombreBlanco = new System.Windows.Forms.Label();
            this.lblCodigoBlanco = new System.Windows.Forms.Label();
            this.lbCodigo1 = new System.Windows.Forms.Label();
            this.lblNombre1 = new System.Windows.Forms.Label();
            this.lblTramite1 = new System.Windows.Forms.Label();
            this.grbNuevo = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTramite = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.grbGrilla = new System.Windows.Forms.GroupBox();
            this.dgvPila = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstPila = new System.Windows.Forms.ListBox();
            this.picPila = new System.Windows.Forms.PictureBox();
            this.grbfoto = new System.Windows.Forms.GroupBox();
            this.grbEliminar.SuspendLayout();
            this.grbNuevo.SuspendLayout();
            this.grbGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPila)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPila)).BeginInit();
            this.grbfoto.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbEliminar
            // 
            this.grbEliminar.Controls.Add(this.btnEliminar);
            this.grbEliminar.Controls.Add(this.lblTramiteBlanco);
            this.grbEliminar.Controls.Add(this.lblNombreBlanco);
            this.grbEliminar.Controls.Add(this.lblCodigoBlanco);
            this.grbEliminar.Controls.Add(this.lbCodigo1);
            this.grbEliminar.Controls.Add(this.lblNombre1);
            this.grbEliminar.Controls.Add(this.lblTramite1);
            this.grbEliminar.Location = new System.Drawing.Point(573, 15);
            this.grbEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.grbEliminar.Name = "grbEliminar";
            this.grbEliminar.Padding = new System.Windows.Forms.Padding(4);
            this.grbEliminar.Size = new System.Drawing.Size(267, 246);
            this.grbEliminar.TabIndex = 0;
            this.grbEliminar.TabStop = false;
            this.grbEliminar.Text = "Elemento Eliminado";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(85, 210);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblTramiteBlanco
            // 
            this.lblTramiteBlanco.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTramiteBlanco.Location = new System.Drawing.Point(121, 167);
            this.lblTramiteBlanco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramiteBlanco.Name = "lblTramiteBlanco";
            this.lblTramiteBlanco.Size = new System.Drawing.Size(125, 27);
            this.lblTramiteBlanco.TabIndex = 12;
            // 
            // lblNombreBlanco
            // 
            this.lblNombreBlanco.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreBlanco.Location = new System.Drawing.Point(121, 110);
            this.lblNombreBlanco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreBlanco.Name = "lblNombreBlanco";
            this.lblNombreBlanco.Size = new System.Drawing.Size(125, 28);
            this.lblNombreBlanco.TabIndex = 11;
            // 
            // lblCodigoBlanco
            // 
            this.lblCodigoBlanco.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigoBlanco.Location = new System.Drawing.Point(121, 54);
            this.lblCodigoBlanco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoBlanco.Name = "lblCodigoBlanco";
            this.lblCodigoBlanco.Size = new System.Drawing.Size(125, 28);
            this.lblCodigoBlanco.TabIndex = 10;
            // 
            // lbCodigo1
            // 
            this.lbCodigo1.AutoSize = true;
            this.lbCodigo1.Location = new System.Drawing.Point(19, 54);
            this.lbCodigo1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCodigo1.Name = "lbCodigo1";
            this.lbCodigo1.Size = new System.Drawing.Size(51, 16);
            this.lbCodigo1.TabIndex = 7;
            this.lbCodigo1.Text = "Codigo";
            // 
            // lblNombre1
            // 
            this.lblNombre1.AutoSize = true;
            this.lblNombre1.Location = new System.Drawing.Point(19, 112);
            this.lblNombre1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre1.Name = "lblNombre1";
            this.lblNombre1.Size = new System.Drawing.Size(56, 16);
            this.lblNombre1.TabIndex = 8;
            this.lblNombre1.Text = "Nombre";
            // 
            // lblTramite1
            // 
            this.lblTramite1.AutoSize = true;
            this.lblTramite1.Location = new System.Drawing.Point(19, 180);
            this.lblTramite1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramite1.Name = "lblTramite1";
            this.lblTramite1.Size = new System.Drawing.Size(53, 16);
            this.lblTramite1.TabIndex = 9;
            this.lblTramite1.Text = "Tramite";
            // 
            // grbNuevo
            // 
            this.grbNuevo.Controls.Add(this.btnAgregar);
            this.grbNuevo.Controls.Add(this.lblCodigo);
            this.grbNuevo.Controls.Add(this.lblNombre);
            this.grbNuevo.Controls.Add(this.lblTramite);
            this.grbNuevo.Controls.Add(this.txtCodigo);
            this.grbNuevo.Controls.Add(this.txtNombre);
            this.grbNuevo.Controls.Add(this.txtTramite);
            this.grbNuevo.Location = new System.Drawing.Point(283, 15);
            this.grbNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.grbNuevo.Name = "grbNuevo";
            this.grbNuevo.Padding = new System.Windows.Forms.Padding(4);
            this.grbNuevo.Size = new System.Drawing.Size(267, 246);
            this.grbNuevo.TabIndex = 0;
            this.grbNuevo.TabStop = false;
            this.grbNuevo.Text = "Nuevo Elemento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(61, 210);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(127, 28);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(16, 42);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(51, 16);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 100);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(16, 167);
            this.lblTramite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(53, 16);
            this.lblTramite.TabIndex = 3;
            this.lblTramite.Text = "Tramite";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(113, 38);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(132, 22);
            this.txtCodigo.TabIndex = 4;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(113, 96);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 22);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(113, 159);
            this.txtTramite.Margin = new System.Windows.Forms.Padding(4);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(132, 22);
            this.txtTramite.TabIndex = 6;
            this.txtTramite.TextChanged += new System.EventHandler(this.txtTramite_TextChanged);
            // 
            // grbGrilla
            // 
            this.grbGrilla.Controls.Add(this.dgvPila);
            this.grbGrilla.Controls.Add(this.lstPila);
            this.grbGrilla.Location = new System.Drawing.Point(16, 290);
            this.grbGrilla.Margin = new System.Windows.Forms.Padding(4);
            this.grbGrilla.Name = "grbGrilla";
            this.grbGrilla.Padding = new System.Windows.Forms.Padding(4);
            this.grbGrilla.Size = new System.Drawing.Size(824, 267);
            this.grbGrilla.TabIndex = 1;
            this.grbGrilla.TabStop = false;
            this.grbGrilla.Text = "Listado en una Lista y una Grilla";
            // 
            // dgvPila
            // 
            this.dgvPila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvPila.Location = new System.Drawing.Point(275, 34);
            this.dgvPila.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPila.Name = "dgvPila";
            this.dgvPila.RowHeadersWidth = 51;
            this.dgvPila.Size = new System.Drawing.Size(493, 213);
            this.dgvPila.TabIndex = 1;
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
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tramite";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // lstPila
            // 
            this.lstPila.FormattingEnabled = true;
            this.lstPila.ItemHeight = 16;
            this.lstPila.Location = new System.Drawing.Point(8, 34);
            this.lstPila.Margin = new System.Windows.Forms.Padding(4);
            this.lstPila.Name = "lstPila";
            this.lstPila.Size = new System.Drawing.Size(213, 212);
            this.lstPila.TabIndex = 0;
            // 
            // picPila
            // 
            this.picPila.Image = global::pryEDRoldan.Properties.Resources.pila;
            this.picPila.Location = new System.Drawing.Point(0, 0);
            this.picPila.Margin = new System.Windows.Forms.Padding(4);
            this.picPila.Name = "picPila";
            this.picPila.Size = new System.Drawing.Size(236, 246);
            this.picPila.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPila.TabIndex = 1;
            this.picPila.TabStop = false;
            // 
            // grbfoto
            // 
            this.grbfoto.Controls.Add(this.picPila);
            this.grbfoto.Location = new System.Drawing.Point(24, 15);
            this.grbfoto.Margin = new System.Windows.Forms.Padding(4);
            this.grbfoto.Name = "grbfoto";
            this.grbfoto.Padding = new System.Windows.Forms.Padding(4);
            this.grbfoto.Size = new System.Drawing.Size(236, 246);
            this.grbfoto.TabIndex = 0;
            this.grbfoto.TabStop = false;
            // 
            // frmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 572);
            this.Controls.Add(this.grbGrilla);
            this.Controls.Add(this.grbNuevo);
            this.Controls.Add(this.grbEliminar);
            this.Controls.Add(this.grbfoto);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   ";
            this.grbEliminar.ResumeLayout(false);
            this.grbEliminar.PerformLayout();
            this.grbNuevo.ResumeLayout(false);
            this.grbNuevo.PerformLayout();
            this.grbGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPila)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPila)).EndInit();
            this.grbfoto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbEliminar;
        private System.Windows.Forms.GroupBox grbNuevo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lbCodigo1;
        private System.Windows.Forms.Label lblNombre1;
        private System.Windows.Forms.Label lblTramite1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTramiteBlanco;
        private System.Windows.Forms.Label lblNombreBlanco;
        private System.Windows.Forms.Label lblCodigoBlanco;
        private System.Windows.Forms.GroupBox grbGrilla;
        private System.Windows.Forms.DataGridView dgvPila;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ListBox lstPila;
        private System.Windows.Forms.PictureBox picPila;
        private System.Windows.Forms.GroupBox grbfoto;
    }
}