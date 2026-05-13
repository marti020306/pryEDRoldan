namespace pryEDRoldan
{
    partial class frmListaDoble
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
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.grbNuevo = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.grbEliminar = new System.Windows.Forms.GroupBox();
            this.cbxCodigo = new System.Windows.Forms.ComboBox();
            this.lblCodigo1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.grbListar = new System.Windows.Forms.GroupBox();
            this.radDescendente = new System.Windows.Forms.RadioButton();
            this.radAscendente = new System.Windows.Forms.RadioButton();
            this.grbGrilla = new System.Windows.Forms.GroupBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstDoble = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.grbNuevo.SuspendLayout();
            this.grbEliminar.SuspendLayout();
            this.grbListar.SuspendLayout();
            this.grbGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // picImagen
            // 
            this.picImagen.Image = global::pryEDRoldan.Properties.Resources.dobleenlace;
            this.picImagen.Location = new System.Drawing.Point(16, 15);
            this.picImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(241, 261);
            this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagen.TabIndex = 0;
            this.picImagen.TabStop = false;
            // 
            // grbNuevo
            // 
            this.grbNuevo.Controls.Add(this.txtNombre);
            this.grbNuevo.Controls.Add(this.txtCodigo);
            this.grbNuevo.Controls.Add(this.txtTramite);
            this.grbNuevo.Controls.Add(this.btnAgregar);
            this.grbNuevo.Controls.Add(this.lblTramite);
            this.grbNuevo.Controls.Add(this.lblNombre);
            this.grbNuevo.Controls.Add(this.lblCodigo);
            this.grbNuevo.Location = new System.Drawing.Point(280, 15);
            this.grbNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbNuevo.Name = "grbNuevo";
            this.grbNuevo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbNuevo.Size = new System.Drawing.Size(267, 261);
            this.grbNuevo.TabIndex = 1;
            this.grbNuevo.TabStop = false;
            this.grbNuevo.Text = "Nuevo Elemento";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(127, 87);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(127, 34);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(132, 22);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(127, 135);
            this.txtTramite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(132, 22);
            this.txtTramite.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(53, 183);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(133, 28);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(21, 135);
            this.lblTramite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(53, 16);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Tramite";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 87);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(24, 34);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(51, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            // 
            // grbEliminar
            // 
            this.grbEliminar.Controls.Add(this.cbxCodigo);
            this.grbEliminar.Controls.Add(this.lblCodigo1);
            this.grbEliminar.Controls.Add(this.btnEliminar);
            this.grbEliminar.Location = new System.Drawing.Point(589, 15);
            this.grbEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbEliminar.Name = "grbEliminar";
            this.grbEliminar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbEliminar.Size = new System.Drawing.Size(269, 126);
            this.grbEliminar.TabIndex = 0;
            this.grbEliminar.TabStop = false;
            this.grbEliminar.Text = "Elemento a eliminar";
            // 
            // cbxCodigo
            // 
            this.cbxCodigo.FormattingEnabled = true;
            this.cbxCodigo.Location = new System.Drawing.Point(93, 44);
            this.cbxCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxCodigo.Name = "cbxCodigo";
            this.cbxCodigo.Size = new System.Drawing.Size(160, 24);
            this.cbxCodigo.TabIndex = 8;
            // 
            // lblCodigo1
            // 
            this.lblCodigo1.AutoSize = true;
            this.lblCodigo1.Location = new System.Drawing.Point(8, 48);
            this.lblCodigo1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo1.Name = "lblCodigo1";
            this.lblCodigo1.Size = new System.Drawing.Size(51, 16);
            this.lblCodigo1.TabIndex = 7;
            this.lblCodigo1.Text = "Codigo";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(75, 87);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // grbListar
            // 
            this.grbListar.Controls.Add(this.radDescendente);
            this.grbListar.Controls.Add(this.radAscendente);
            this.grbListar.Location = new System.Drawing.Point(589, 150);
            this.grbListar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbListar.Name = "grbListar";
            this.grbListar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbListar.Size = new System.Drawing.Size(269, 126);
            this.grbListar.TabIndex = 2;
            this.grbListar.TabStop = false;
            this.grbListar.Text = "Listar Datos";
            // 
            // radDescendente
            // 
            this.radDescendente.AutoSize = true;
            this.radDescendente.Location = new System.Drawing.Point(61, 76);
            this.radDescendente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radDescendente.Name = "radDescendente";
            this.radDescendente.Size = new System.Drawing.Size(109, 20);
            this.radDescendente.TabIndex = 3;
            this.radDescendente.TabStop = true;
            this.radDescendente.Text = "Descendente";
            this.radDescendente.UseVisualStyleBackColor = true;
            // 
            // radAscendente
            // 
            this.radAscendente.AutoSize = true;
            this.radAscendente.Location = new System.Drawing.Point(61, 34);
            this.radAscendente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radAscendente.Name = "radAscendente";
            this.radAscendente.Size = new System.Drawing.Size(100, 20);
            this.radAscendente.TabIndex = 4;
            this.radAscendente.TabStop = true;
            this.radAscendente.Text = "Ascendente";
            this.radAscendente.UseVisualStyleBackColor = true;
            // 
            // grbGrilla
            // 
            this.grbGrilla.Controls.Add(this.dgvLista);
            this.grbGrilla.Controls.Add(this.lstDoble);
            this.grbGrilla.Location = new System.Drawing.Point(16, 295);
            this.grbGrilla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbGrilla.Name = "grbGrilla";
            this.grbGrilla.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbGrilla.Size = new System.Drawing.Size(843, 266);
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
            this.dgvLista.Location = new System.Drawing.Point(264, 23);
            this.dgvLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.Size = new System.Drawing.Size(535, 229);
            this.dgvLista.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
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
            // lstDoble
            // 
            this.lstDoble.FormattingEnabled = true;
            this.lstDoble.ItemHeight = 16;
            this.lstDoble.Location = new System.Drawing.Point(8, 23);
            this.lstDoble.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstDoble.Name = "lstDoble";
            this.lstDoble.Size = new System.Drawing.Size(232, 228);
            this.lstDoble.TabIndex = 0;
            this.lstDoble.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // frmListaDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 576);
            this.Controls.Add(this.grbGrilla);
            this.Controls.Add(this.grbListar);
            this.Controls.Add(this.grbEliminar);
            this.Controls.Add(this.grbNuevo);
            this.Controls.Add(this.picImagen);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmListaDoble";
            this.Text = "Lista Doblemente Enlazada";
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.grbNuevo.ResumeLayout(false);
            this.grbNuevo.PerformLayout();
            this.grbEliminar.ResumeLayout(false);
            this.grbEliminar.PerformLayout();
            this.grbListar.ResumeLayout(false);
            this.grbListar.PerformLayout();
            this.grbGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picImagen;
        private System.Windows.Forms.GroupBox grbNuevo;
        private System.Windows.Forms.GroupBox grbEliminar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cbxCodigo;
        private System.Windows.Forms.Label lblCodigo1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox grbListar;
        private System.Windows.Forms.RadioButton radDescendente;
        private System.Windows.Forms.RadioButton radAscendente;
        private System.Windows.Forms.GroupBox grbGrilla;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.ListBox lstDoble;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}