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
            this.grbEliminar = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.Tramite = new System.Windows.Forms.Label();
            this.lblCodigo1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.grbArbol = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radIN = new System.Windows.Forms.RadioButton();
            this.radPRE = new System.Windows.Forms.RadioButton();
            this.radPost = new System.Windows.Forms.RadioButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbNuevo.SuspendLayout();
            this.grbEliminar.SuspendLayout();
            this.grbArbol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // treArbol
            // 
            this.treArbol.Location = new System.Drawing.Point(12, 12);
            this.treArbol.Name = "treArbol";
            this.treArbol.Size = new System.Drawing.Size(182, 191);
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
            this.grbNuevo.Location = new System.Drawing.Point(210, 12);
            this.grbNuevo.Name = "grbNuevo";
            this.grbNuevo.Size = new System.Drawing.Size(200, 191);
            this.grbNuevo.TabIndex = 1;
            this.grbNuevo.TabStop = false;
            this.grbNuevo.Text = "Nuevo Elemento";
            // 
            // grbEliminar
            // 
            this.grbEliminar.Controls.Add(this.btnEliminar);
            this.grbEliminar.Controls.Add(this.comboBox1);
            this.grbEliminar.Controls.Add(this.lblCodigo1);
            this.grbEliminar.Location = new System.Drawing.Point(425, 12);
            this.grbEliminar.Name = "grbEliminar";
            this.grbEliminar.Size = new System.Drawing.Size(200, 123);
            this.grbEliminar.TabIndex = 0;
            this.grbEliminar.TabStop = false;
            this.grbEliminar.Text = "Elemento a Eliminar";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(15, 31);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 79);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // Tramite
            // 
            this.Tramite.AutoSize = true;
            this.Tramite.Location = new System.Drawing.Point(15, 121);
            this.Tramite.Name = "Tramite";
            this.Tramite.Size = new System.Drawing.Size(42, 13);
            this.Tramite.TabIndex = 4;
            this.Tramite.Text = "Tramite";
            // 
            // lblCodigo1
            // 
            this.lblCodigo1.AutoSize = true;
            this.lblCodigo1.Location = new System.Drawing.Point(19, 42);
            this.lblCodigo1.Name = "lblCodigo1";
            this.lblCodigo1.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo1.TabIndex = 5;
            this.lblCodigo1.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(80, 28);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(80, 72);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(80, 121);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 20);
            this.txtTramite.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(73, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(40, 162);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(107, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(53, 79);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(96, 23);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEquilibrar
            // 
            this.btnEquilibrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquilibrar.Location = new System.Drawing.Point(447, 155);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(135, 30);
            this.btnEquilibrar.TabIndex = 10;
            this.btnEquilibrar.Text = "Equilibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            // 
            // grbArbol
            // 
            this.grbArbol.Controls.Add(this.radPost);
            this.grbArbol.Controls.Add(this.radPRE);
            this.grbArbol.Controls.Add(this.radIN);
            this.grbArbol.Controls.Add(this.dataGridView1);
            this.grbArbol.Location = new System.Drawing.Point(12, 220);
            this.grbArbol.Name = "grbArbol";
            this.grbArbol.Size = new System.Drawing.Size(613, 218);
            this.grbArbol.TabIndex = 11;
            this.grbArbol.TabStop = false;
            this.grbArbol.Text = "Listado Del Arbol";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(136, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(458, 178);
            this.dataGridView1.TabIndex = 0;
            // 
            // radIN
            // 
            this.radIN.AutoSize = true;
            this.radIN.Location = new System.Drawing.Point(18, 34);
            this.radIN.Name = "radIN";
            this.radIN.Size = new System.Drawing.Size(66, 17);
            this.radIN.TabIndex = 0;
            this.radIN.TabStop = true;
            this.radIN.Text = "In-Orden";
            this.radIN.UseVisualStyleBackColor = true;
            this.radIN.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radPRE
            // 
            this.radPRE.AutoSize = true;
            this.radPRE.Location = new System.Drawing.Point(18, 85);
            this.radPRE.Name = "radPRE";
            this.radPRE.Size = new System.Drawing.Size(73, 17);
            this.radPRE.TabIndex = 1;
            this.radPRE.TabStop = true;
            this.radPRE.Text = "Pre-Orden";
            this.radPRE.UseVisualStyleBackColor = true;
            // 
            // radPost
            // 
            this.radPost.AutoSize = true;
            this.radPost.Location = new System.Drawing.Point(18, 135);
            this.radPost.Name = "radPost";
            this.radPost.Size = new System.Drawing.Size(78, 17);
            this.radPost.TabIndex = 2;
            this.radPost.TabStop = true;
            this.radPost.Text = "Post-Orden";
            this.radPost.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.Width = 180;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tramite";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 450);
            this.Controls.Add(this.grbArbol);
            this.Controls.Add(this.btnEquilibrar);
            this.Controls.Add(this.grbEliminar);
            this.Controls.Add(this.grbNuevo);
            this.Controls.Add(this.treArbol);
            this.Name = "frmArbolBinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructuras Ramificadas-Arbol Binario";
            this.grbNuevo.ResumeLayout(false);
            this.grbNuevo.PerformLayout();
            this.grbEliminar.ResumeLayout(false);
            this.grbEliminar.PerformLayout();
            this.grbArbol.ResumeLayout(false);
            this.grbArbol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblCodigo1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEquilibrar;
        private System.Windows.Forms.GroupBox grbArbol;
        private System.Windows.Forms.RadioButton radPost;
        private System.Windows.Forms.RadioButton radPRE;
        private System.Windows.Forms.RadioButton radIN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}