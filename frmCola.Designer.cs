namespace pryEDRoldan
{
    partial class frmCola
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
            this.picboxCola = new System.Windows.Forms.PictureBox();
            this.grbElemento = new System.Windows.Forms.GroupBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grbEliminado = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblTramite2 = new System.Windows.Forms.Label();
            this.lblBlancoTramite = new System.Windows.Forms.Label();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.lblBlancoNombre = new System.Windows.Forms.Label();
            this.lblCodigo2 = new System.Windows.Forms.Label();
            this.lblBlancoCodigo = new System.Windows.Forms.Label();
            this.grbListaGrilla = new System.Windows.Forms.GroupBox();
            this.dgvCola = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstLista = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxCola)).BeginInit();
            this.grbElemento.SuspendLayout();
            this.grbEliminado.SuspendLayout();
            this.grbListaGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxCola
            // 
            this.picboxCola.Image = global::pryEDRoldan.Properties.Resources.descarga;
            this.picboxCola.Location = new System.Drawing.Point(16, 22);
            this.picboxCola.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picboxCola.Name = "picboxCola";
            this.picboxCola.Size = new System.Drawing.Size(248, 271);
            this.picboxCola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxCola.TabIndex = 0;
            this.picboxCola.TabStop = false;
            // 
            // grbElemento
            // 
            this.grbElemento.Controls.Add(this.lblTramite);
            this.grbElemento.Controls.Add(this.lblNombre);
            this.grbElemento.Controls.Add(this.textBox3);
            this.grbElemento.Controls.Add(this.txtNombre);
            this.grbElemento.Controls.Add(this.lblCodigo);
            this.grbElemento.Controls.Add(this.txtCodigo);
            this.grbElemento.Controls.Add(this.btnAgregar);
            this.grbElemento.Location = new System.Drawing.Point(289, 15);
            this.grbElemento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbElemento.Name = "grbElemento";
            this.grbElemento.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbElemento.Size = new System.Drawing.Size(271, 278);
            this.grbElemento.TabIndex = 2;
            this.grbElemento.TabStop = false;
            this.grbElemento.Text = "Nuevo Elemento";
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramite.Location = new System.Drawing.Point(8, 154);
            this.lblTramite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(57, 18);
            this.lblTramite.TabIndex = 3;
            this.lblTramite.Text = "Tramite:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(8, 101);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(61, 18);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(129, 150);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 22);
            this.textBox3.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(129, 101);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(8, 54);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(55, 18);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(151, 50);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(111, 22);
            this.txtCodigo.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(24, 220);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(223, 38);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // grbEliminado
            // 
            this.grbEliminado.Controls.Add(this.btnEliminar);
            this.grbEliminado.Controls.Add(this.lblTramite2);
            this.grbEliminado.Controls.Add(this.lblBlancoTramite);
            this.grbEliminado.Controls.Add(this.lblNombre2);
            this.grbEliminado.Controls.Add(this.lblBlancoNombre);
            this.grbEliminado.Controls.Add(this.lblCodigo2);
            this.grbEliminado.Controls.Add(this.lblBlancoCodigo);
            this.grbEliminado.Location = new System.Drawing.Point(608, 15);
            this.grbEliminado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbEliminado.Name = "grbEliminado";
            this.grbEliminado.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbEliminado.Size = new System.Drawing.Size(291, 278);
            this.grbEliminado.TabIndex = 0;
            this.grbEliminado.TabStop = false;
            this.grbEliminado.Text = "Elemento Eliminado";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(27, 220);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(237, 38);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblTramite2
            // 
            this.lblTramite2.AutoSize = true;
            this.lblTramite2.Location = new System.Drawing.Point(8, 159);
            this.lblTramite2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramite2.Name = "lblTramite2";
            this.lblTramite2.Size = new System.Drawing.Size(56, 16);
            this.lblTramite2.TabIndex = 5;
            this.lblTramite2.Text = "Tramite:";
            // 
            // lblBlancoTramite
            // 
            this.lblBlancoTramite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBlancoTramite.Location = new System.Drawing.Point(131, 154);
            this.lblBlancoTramite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBlancoTramite.Name = "lblBlancoTramite";
            this.lblBlancoTramite.Size = new System.Drawing.Size(152, 28);
            this.lblBlancoTramite.TabIndex = 6;
            this.lblBlancoTramite.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Location = new System.Drawing.Point(8, 110);
            this.lblNombre2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(62, 16);
            this.lblNombre2.TabIndex = 4;
            this.lblNombre2.Text = "Nombre: ";
            // 
            // lblBlancoNombre
            // 
            this.lblBlancoNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBlancoNombre.Location = new System.Drawing.Point(131, 101);
            this.lblBlancoNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBlancoNombre.Name = "lblBlancoNombre";
            this.lblBlancoNombre.Size = new System.Drawing.Size(152, 28);
            this.lblBlancoNombre.TabIndex = 7;
            this.lblBlancoNombre.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCodigo2
            // 
            this.lblCodigo2.AutoSize = true;
            this.lblCodigo2.Location = new System.Drawing.Point(8, 50);
            this.lblCodigo2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo2.Name = "lblCodigo2";
            this.lblCodigo2.Size = new System.Drawing.Size(57, 16);
            this.lblCodigo2.TabIndex = 3;
            this.lblCodigo2.Text = "Codigo: ";
            // 
            // lblBlancoCodigo
            // 
            this.lblBlancoCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBlancoCodigo.Location = new System.Drawing.Point(163, 49);
            this.lblBlancoCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBlancoCodigo.Name = "lblBlancoCodigo";
            this.lblBlancoCodigo.Size = new System.Drawing.Size(120, 28);
            this.lblBlancoCodigo.TabIndex = 8;
            this.lblBlancoCodigo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // grbListaGrilla
            // 
            this.grbListaGrilla.Controls.Add(this.dgvCola);
            this.grbListaGrilla.Controls.Add(this.lstLista);
            this.grbListaGrilla.Location = new System.Drawing.Point(16, 327);
            this.grbListaGrilla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbListaGrilla.Name = "grbListaGrilla";
            this.grbListaGrilla.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbListaGrilla.Size = new System.Drawing.Size(883, 325);
            this.grbListaGrilla.TabIndex = 3;
            this.grbListaGrilla.TabStop = false;
            this.grbListaGrilla.Text = "Listado en una lista y una grilla";
            // 
            // dgvCola
            // 
            this.dgvCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvCola.Location = new System.Drawing.Point(323, 38);
            this.dgvCola.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCola.Name = "dgvCola";
            this.dgvCola.RowHeadersWidth = 51;
            this.dgvCola.Size = new System.Drawing.Size(533, 261);
            this.dgvCola.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
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
            this.Column3.Width = 120;
            // 
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.ItemHeight = 16;
            this.lstLista.Location = new System.Drawing.Point(20, 38);
            this.lstLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(260, 260);
            this.lstLista.TabIndex = 0;
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 683);
            this.Controls.Add(this.grbListaGrilla);
            this.Controls.Add(this.grbEliminado);
            this.Controls.Add(this.grbElemento);
            this.Controls.Add(this.picboxCola);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura Dinamica Lineal - Cola";
            this.Load += new System.EventHandler(this.frmCola_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxCola)).EndInit();
            this.grbElemento.ResumeLayout(false);
            this.grbElemento.PerformLayout();
            this.grbEliminado.ResumeLayout(false);
            this.grbEliminado.PerformLayout();
            this.grbListaGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxCola;
        private System.Windows.Forms.GroupBox grbElemento;
        private System.Windows.Forms.GroupBox grbEliminado;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTramite2;
        private System.Windows.Forms.Label lblBlancoTramite;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.Label lblBlancoNombre;
        private System.Windows.Forms.Label lblCodigo2;
        private System.Windows.Forms.Label lblBlancoCodigo;
        private System.Windows.Forms.GroupBox grbListaGrilla;
        private System.Windows.Forms.DataGridView dgvCola;
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}