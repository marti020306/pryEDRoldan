namespace pryEDRoldan
{
    partial class frmListaSimple
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
            this.picLista = new System.Windows.Forms.PictureBox();
            this.grbEliminar = new System.Windows.Forms.GroupBox();
            this.cbxCodigo = new System.Windows.Forms.ComboBox();
            this.lblCodigo2 = new System.Windows.Forms.Label();
            this.grbNuevo = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.grbGrilla = new System.Windows.Forms.GroupBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picLista)).BeginInit();
            this.grbEliminar.SuspendLayout();
            this.grbNuevo.SuspendLayout();
            this.grbGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // picLista
            // 
            this.picLista.Image = global::pryEDRoldan.Properties.Resources.descarga1;
            this.picLista.Location = new System.Drawing.Point(16, 15);
            this.picLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picLista.Name = "picLista";
            this.picLista.Size = new System.Drawing.Size(287, 263);
            this.picLista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLista.TabIndex = 0;
            this.picLista.TabStop = false;
            // 
            // grbEliminar
            // 
            this.grbEliminar.Controls.Add(this.cbxCodigo);
            this.grbEliminar.Controls.Add(this.lblCodigo2);
            this.grbEliminar.Location = new System.Drawing.Point(628, 15);
            this.grbEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbEliminar.Name = "grbEliminar";
            this.grbEliminar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbEliminar.Size = new System.Drawing.Size(267, 263);
            this.grbEliminar.TabIndex = 1;
            this.grbEliminar.TabStop = false;
            this.grbEliminar.Text = "Elemento a eliminar";
            // 
            // cbxCodigo
            // 
            this.cbxCodigo.FormattingEnabled = true;
            this.cbxCodigo.Location = new System.Drawing.Point(103, 161);
            this.cbxCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxCodigo.Name = "cbxCodigo";
            this.cbxCodigo.Size = new System.Drawing.Size(143, 24);
            this.cbxCodigo.TabIndex = 3;
            // 
            // lblCodigo2
            // 
            this.lblCodigo2.AutoSize = true;
            this.lblCodigo2.Location = new System.Drawing.Point(25, 165);
            this.lblCodigo2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo2.Name = "lblCodigo2";
            this.lblCodigo2.Size = new System.Drawing.Size(54, 16);
            this.lblCodigo2.TabIndex = 1;
            this.lblCodigo2.Text = "Codigo:";
            // 
            // grbNuevo
            // 
            this.grbNuevo.Controls.Add(this.btnAgregar);
            this.grbNuevo.Controls.Add(this.txtTramite);
            this.grbNuevo.Controls.Add(this.txtNombre);
            this.grbNuevo.Controls.Add(this.txtCodigo);
            this.grbNuevo.Controls.Add(this.lblTramite);
            this.grbNuevo.Controls.Add(this.lblNombre);
            this.grbNuevo.Controls.Add(this.lblCodigo);
            this.grbNuevo.Location = new System.Drawing.Point(336, 15);
            this.grbNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbNuevo.Name = "grbNuevo";
            this.grbNuevo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbNuevo.Size = new System.Drawing.Size(267, 263);
            this.grbNuevo.TabIndex = 0;
            this.grbNuevo.TabStop = false;
            this.grbNuevo.Text = "Nuevo Elemento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(40, 209);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(160, 28);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(125, 161);
            this.txtTramite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(132, 22);
            this.txtTramite.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(125, 101);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(125, 39);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(132, 22);
            this.txtCodigo.TabIndex = 3;
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(20, 165);
            this.lblTramite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(56, 16);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Tramite:";
            this.lblTramite.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 105);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(20, 43);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.ItemHeight = 16;
            this.lstLista.Location = new System.Drawing.Point(8, 21);
            this.lstLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(252, 228);
            this.lstLista.TabIndex = 2;
            // 
            // grbGrilla
            // 
            this.grbGrilla.Controls.Add(this.dgvLista);
            this.grbGrilla.Controls.Add(this.lstLista);
            this.grbGrilla.Location = new System.Drawing.Point(16, 293);
            this.grbGrilla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbGrilla.Name = "grbGrilla";
            this.grbGrilla.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbGrilla.Size = new System.Drawing.Size(892, 261);
            this.grbGrilla.TabIndex = 3;
            this.grbGrilla.TabStop = false;
            this.grbGrilla.Text = "Listado en una Lista y una Grilla";
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvLista.Location = new System.Drawing.Point(287, 23);
            this.dgvLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.Size = new System.Drawing.Size(584, 226);
            this.dgvLista.TabIndex = 4;
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
            this.Column2.Width = 170;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tramite";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // frmListaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 569);
            this.Controls.Add(this.grbGrilla);
            this.Controls.Add(this.grbNuevo);
            this.Controls.Add(this.grbEliminar);
            this.Controls.Add(this.picLista);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmListaSimple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura de datos lineal: Lista Simple";
            ((System.ComponentModel.ISupportInitialize)(this.picLista)).EndInit();
            this.grbEliminar.ResumeLayout(false);
            this.grbEliminar.PerformLayout();
            this.grbNuevo.ResumeLayout(false);
            this.grbNuevo.PerformLayout();
            this.grbGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLista;
        private System.Windows.Forms.GroupBox grbEliminar;
        private System.Windows.Forms.GroupBox grbNuevo;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ComboBox cbxCodigo;
        private System.Windows.Forms.Label lblCodigo2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.GroupBox grbGrilla;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}