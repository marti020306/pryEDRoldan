namespace pryEDRoldan
{
    partial class frmGrafo
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
            this.gbConsulta = new System.Windows.Forms.GroupBox();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.cmdBorrarTodo = new System.Windows.Forms.Button();
            this.txtPrecio2 = new System.Windows.Forms.TextBox();
            this.cbDestino2 = new System.Windows.Forms.ComboBox();
            this.cbOrigen2 = new System.Windows.Forms.ComboBox();
            this.lblPrecio2 = new System.Windows.Forms.Label();
            this.lblDestino2 = new System.Windows.Forms.Label();
            this.lblOrigen2 = new System.Windows.Forms.Label();
            this.gbCargaDatos = new System.Windows.Forms.GroupBox();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cbDestino = new System.Windows.Forms.ComboBox();
            this.cbOrigen = new System.Windows.Forms.ComboBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.gbListar = new System.Windows.Forms.GroupBox();
            this.dgvProvincias = new System.Windows.Forms.DataGridView();
            this.clOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCordoba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMendoza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSantaFe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clBuenosAires = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSalta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdVerTodo = new System.Windows.Forms.Button();
            this.cmdListarOrigenes = new System.Windows.Forms.Button();
            this.cmdListarDestinos = new System.Windows.Forms.Button();
            this.cbHasta = new System.Windows.Forms.ComboBox();
            this.cbDesde = new System.Windows.Forms.ComboBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbConsulta.SuspendLayout();
            this.gbCargaDatos.SuspendLayout();
            this.gbListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvincias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbConsulta
            // 
            this.gbConsulta.Controls.Add(this.cmdConsultar);
            this.gbConsulta.Controls.Add(this.cmdBorrarTodo);
            this.gbConsulta.Controls.Add(this.txtPrecio2);
            this.gbConsulta.Controls.Add(this.cbDestino2);
            this.gbConsulta.Controls.Add(this.cbOrigen2);
            this.gbConsulta.Controls.Add(this.lblPrecio2);
            this.gbConsulta.Controls.Add(this.lblDestino2);
            this.gbConsulta.Controls.Add(this.lblOrigen2);
            this.gbConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsulta.Location = new System.Drawing.Point(752, 23);
            this.gbConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbConsulta.Name = "gbConsulta";
            this.gbConsulta.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbConsulta.Size = new System.Drawing.Size(267, 233);
            this.gbConsulta.TabIndex = 11;
            this.gbConsulta.TabStop = false;
            this.gbConsulta.Text = "Consulta de Datos:";
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConsultar.Location = new System.Drawing.Point(9, 188);
            this.cmdConsultar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(117, 39);
            this.cmdConsultar.TabIndex = 6;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // cmdBorrarTodo
            // 
            this.cmdBorrarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBorrarTodo.Location = new System.Drawing.Point(144, 188);
            this.cmdBorrarTodo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdBorrarTodo.Name = "cmdBorrarTodo";
            this.cmdBorrarTodo.Size = new System.Drawing.Size(117, 39);
            this.cmdBorrarTodo.TabIndex = 6;
            this.cmdBorrarTodo.Text = "Borrar Todo";
            this.cmdBorrarTodo.UseVisualStyleBackColor = true;
            this.cmdBorrarTodo.Click += new System.EventHandler(this.cmdBorrarTodo_Click);
            // 
            // txtPrecio2
            // 
            this.txtPrecio2.Location = new System.Drawing.Point(84, 134);
            this.txtPrecio2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecio2.Name = "txtPrecio2";
            this.txtPrecio2.Size = new System.Drawing.Size(157, 24);
            this.txtPrecio2.TabIndex = 5;
            // 
            // cbDestino2
            // 
            this.cbDestino2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDestino2.FormattingEnabled = true;
            this.cbDestino2.Location = new System.Drawing.Point(84, 87);
            this.cbDestino2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDestino2.Name = "cbDestino2";
            this.cbDestino2.Size = new System.Drawing.Size(157, 26);
            this.cbDestino2.TabIndex = 4;
            // 
            // cbOrigen2
            // 
            this.cbOrigen2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrigen2.FormattingEnabled = true;
            this.cbOrigen2.Location = new System.Drawing.Point(84, 39);
            this.cbOrigen2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbOrigen2.Name = "cbOrigen2";
            this.cbOrigen2.Size = new System.Drawing.Size(157, 26);
            this.cbOrigen2.TabIndex = 3;
            // 
            // lblPrecio2
            // 
            this.lblPrecio2.AutoSize = true;
            this.lblPrecio2.Location = new System.Drawing.Point(5, 139);
            this.lblPrecio2.Name = "lblPrecio2";
            this.lblPrecio2.Size = new System.Drawing.Size(55, 18);
            this.lblPrecio2.TabIndex = 2;
            this.lblPrecio2.Text = "Precio:";
            // 
            // lblDestino2
            // 
            this.lblDestino2.AutoSize = true;
            this.lblDestino2.Location = new System.Drawing.Point(5, 94);
            this.lblDestino2.Name = "lblDestino2";
            this.lblDestino2.Size = new System.Drawing.Size(63, 18);
            this.lblDestino2.TabIndex = 1;
            this.lblDestino2.Text = "Destino:";
            // 
            // lblOrigen2
            // 
            this.lblOrigen2.AutoSize = true;
            this.lblOrigen2.Location = new System.Drawing.Point(5, 47);
            this.lblOrigen2.Name = "lblOrigen2";
            this.lblOrigen2.Size = new System.Drawing.Size(56, 18);
            this.lblOrigen2.TabIndex = 0;
            this.lblOrigen2.Text = "Origen:";
            // 
            // gbCargaDatos
            // 
            this.gbCargaDatos.Controls.Add(this.cmdBorrar);
            this.gbCargaDatos.Controls.Add(this.cmdCargar);
            this.gbCargaDatos.Controls.Add(this.txtPrecio);
            this.gbCargaDatos.Controls.Add(this.cbDestino);
            this.gbCargaDatos.Controls.Add(this.cbOrigen);
            this.gbCargaDatos.Controls.Add(this.lblPrecio);
            this.gbCargaDatos.Controls.Add(this.lblDestino);
            this.gbCargaDatos.Controls.Add(this.lblOrigen);
            this.gbCargaDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCargaDatos.Location = new System.Drawing.Point(419, 23);
            this.gbCargaDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCargaDatos.Name = "gbCargaDatos";
            this.gbCargaDatos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCargaDatos.Size = new System.Drawing.Size(270, 233);
            this.gbCargaDatos.TabIndex = 10;
            this.gbCargaDatos.TabStop = false;
            this.gbCargaDatos.Text = "Carga de Datos:";
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBorrar.Location = new System.Drawing.Point(17, 188);
            this.cmdBorrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(119, 39);
            this.cmdBorrar.TabIndex = 7;
            this.cmdBorrar.Text = "Borrar todo";
            this.cmdBorrar.UseVisualStyleBackColor = true;
            this.cmdBorrar.Click += new System.EventHandler(this.cmdBorrar_Click);
            // 
            // cmdCargar
            // 
            this.cmdCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargar.Location = new System.Drawing.Point(141, 188);
            this.cmdCargar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(119, 39);
            this.cmdCargar.TabIndex = 7;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(84, 134);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(157, 24);
            this.txtPrecio.TabIndex = 5;
            // 
            // cbDestino
            // 
            this.cbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDestino.FormattingEnabled = true;
            this.cbDestino.Location = new System.Drawing.Point(84, 86);
            this.cbDestino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(157, 26);
            this.cbDestino.TabIndex = 4;
            // 
            // cbOrigen
            // 
            this.cbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrigen.FormattingEnabled = true;
            this.cbOrigen.Location = new System.Drawing.Point(84, 39);
            this.cbOrigen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbOrigen.Name = "cbOrigen";
            this.cbOrigen.Size = new System.Drawing.Size(157, 26);
            this.cbOrigen.TabIndex = 3;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(5, 139);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(55, 18);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(5, 94);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(63, 18);
            this.lblDestino.TabIndex = 1;
            this.lblDestino.Text = "Destino:";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(5, 47);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(56, 18);
            this.lblOrigen.TabIndex = 0;
            this.lblOrigen.Text = "Origen:";
            // 
            // gbListar
            // 
            this.gbListar.Controls.Add(this.dgvProvincias);
            this.gbListar.Controls.Add(this.cmdVerTodo);
            this.gbListar.Controls.Add(this.cmdListarOrigenes);
            this.gbListar.Controls.Add(this.cmdListarDestinos);
            this.gbListar.Controls.Add(this.cbHasta);
            this.gbListar.Controls.Add(this.cbDesde);
            this.gbListar.Controls.Add(this.lblHasta);
            this.gbListar.Controls.Add(this.lblDesde);
            this.gbListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListar.Location = new System.Drawing.Point(34, 277);
            this.gbListar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbListar.Name = "gbListar";
            this.gbListar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbListar.Size = new System.Drawing.Size(1025, 354);
            this.gbListar.TabIndex = 12;
            this.gbListar.TabStop = false;
            this.gbListar.Text = "Listar viajes ....";
            this.gbListar.Enter += new System.EventHandler(this.gbListar_Enter);
            // 
            // dgvProvincias
            // 
            this.dgvProvincias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProvincias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clOrigen,
            this.clCordoba,
            this.clMendoza,
            this.clSantaFe,
            this.clBuenosAires,
            this.clSalta});
            this.dgvProvincias.Location = new System.Drawing.Point(11, 92);
            this.dgvProvincias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProvincias.Name = "dgvProvincias";
            this.dgvProvincias.RowHeadersWidth = 51;
            this.dgvProvincias.RowTemplate.Height = 24;
            this.dgvProvincias.Size = new System.Drawing.Size(1009, 256);
            this.dgvProvincias.TabIndex = 9;
            // 
            // clOrigen
            // 
            this.clOrigen.HeaderText = "Origen";
            this.clOrigen.MinimumWidth = 6;
            this.clOrigen.Name = "clOrigen";
            this.clOrigen.Width = 110;
            // 
            // clCordoba
            // 
            this.clCordoba.HeaderText = "Córdoba";
            this.clCordoba.MinimumWidth = 6;
            this.clCordoba.Name = "clCordoba";
            this.clCordoba.Width = 125;
            // 
            // clMendoza
            // 
            this.clMendoza.HeaderText = "Mendoza";
            this.clMendoza.MinimumWidth = 6;
            this.clMendoza.Name = "clMendoza";
            this.clMendoza.Width = 125;
            // 
            // clSantaFe
            // 
            this.clSantaFe.HeaderText = "Santa Fe";
            this.clSantaFe.MinimumWidth = 6;
            this.clSantaFe.Name = "clSantaFe";
            this.clSantaFe.Width = 125;
            // 
            // clBuenosAires
            // 
            this.clBuenosAires.HeaderText = "Buenos Aires";
            this.clBuenosAires.MinimumWidth = 6;
            this.clBuenosAires.Name = "clBuenosAires";
            this.clBuenosAires.Width = 125;
            // 
            // clSalta
            // 
            this.clSalta.HeaderText = "Salta";
            this.clSalta.MinimumWidth = 6;
            this.clSalta.Name = "clSalta";
            this.clSalta.Width = 125;
            // 
            // cmdVerTodo
            // 
            this.cmdVerTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVerTodo.Location = new System.Drawing.Point(791, 25);
            this.cmdVerTodo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdVerTodo.Name = "cmdVerTodo";
            this.cmdVerTodo.Size = new System.Drawing.Size(208, 39);
            this.cmdVerTodo.TabIndex = 8;
            this.cmdVerTodo.Text = "Ver todos los viajes";
            this.cmdVerTodo.UseVisualStyleBackColor = true;
            this.cmdVerTodo.Click += new System.EventHandler(this.cmdVerTodo_Click);
            // 
            // cmdListarOrigenes
            // 
            this.cmdListarOrigenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListarOrigenes.Location = new System.Drawing.Point(637, 30);
            this.cmdListarOrigenes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdListarOrigenes.Name = "cmdListarOrigenes";
            this.cmdListarOrigenes.Size = new System.Drawing.Size(128, 26);
            this.cmdListarOrigenes.TabIndex = 7;
            this.cmdListarOrigenes.Text = "Listar Origenes";
            this.cmdListarOrigenes.UseVisualStyleBackColor = true;
            // 
            // cmdListarDestinos
            // 
            this.cmdListarDestinos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListarDestinos.Location = new System.Drawing.Point(244, 30);
            this.cmdListarDestinos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdListarDestinos.Name = "cmdListarDestinos";
            this.cmdListarDestinos.Size = new System.Drawing.Size(128, 26);
            this.cmdListarDestinos.TabIndex = 6;
            this.cmdListarDestinos.Text = "Listar Destinos";
            this.cmdListarDestinos.UseVisualStyleBackColor = true;
            this.cmdListarDestinos.Click += new System.EventHandler(this.cmdListarDestinos_Click);
            // 
            // cbHasta
            // 
            this.cbHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHasta.FormattingEnabled = true;
            this.cbHasta.Location = new System.Drawing.Point(464, 30);
            this.cbHasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbHasta.Name = "cbHasta";
            this.cbHasta.Size = new System.Drawing.Size(157, 26);
            this.cbHasta.TabIndex = 4;
            // 
            // cbDesde
            // 
            this.cbDesde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDesde.FormattingEnabled = true;
            this.cbDesde.Location = new System.Drawing.Point(68, 30);
            this.cbDesde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDesde.Name = "cbDesde";
            this.cbDesde.Size = new System.Drawing.Size(157, 26);
            this.cbDesde.TabIndex = 3;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(397, 37);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(51, 18);
            this.lblHasta.TabIndex = 1;
            this.lblHasta.Text = "Hasta:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(7, 39);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(55, 18);
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Text = "Desde:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryEDRoldan.Properties.Resources.descarga2;
            this.pictureBox1.Location = new System.Drawing.Point(34, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 649);
            this.Controls.Add(this.gbListar);
            this.Controls.Add(this.gbConsulta);
            this.Controls.Add(this.gbCargaDatos);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmGrafo";
            this.Text = "Operaciones en un grafo";
            this.Load += new System.EventHandler(this.frmGrafo_Load);
            this.gbConsulta.ResumeLayout(false);
            this.gbConsulta.PerformLayout();
            this.gbCargaDatos.ResumeLayout(false);
            this.gbCargaDatos.PerformLayout();
            this.gbListar.ResumeLayout(false);
            this.gbListar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvincias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConsulta;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.Button cmdBorrarTodo;
        private System.Windows.Forms.TextBox txtPrecio2;
        private System.Windows.Forms.ComboBox cbDestino2;
        private System.Windows.Forms.ComboBox cbOrigen2;
        private System.Windows.Forms.Label lblPrecio2;
        private System.Windows.Forms.Label lblDestino2;
        private System.Windows.Forms.Label lblOrigen2;
        private System.Windows.Forms.GroupBox gbCargaDatos;
        private System.Windows.Forms.Button cmdBorrar;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox cbDestino;
        private System.Windows.Forms.ComboBox cbOrigen;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbListar;
        private System.Windows.Forms.DataGridView dgvProvincias;
        private System.Windows.Forms.DataGridViewTextBoxColumn clOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCordoba;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMendoza;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSantaFe;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBuenosAires;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSalta;
        private System.Windows.Forms.Button cmdVerTodo;
        private System.Windows.Forms.Button cmdListarOrigenes;
        private System.Windows.Forms.Button cmdListarDestinos;
        private System.Windows.Forms.ComboBox cbHasta;
        private System.Windows.Forms.ComboBox cbDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
    }
}