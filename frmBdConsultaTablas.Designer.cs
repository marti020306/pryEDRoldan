namespace pryEDRoldan
{
    partial class frmBdConsultaTablas
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
            this.cmdListar = new System.Windows.Forms.Button();
            this.cbTablas = new System.Windows.Forms.ComboBox();
            this.lblTabla = new System.Windows.Forms.Label();
            this.dgvConsultaTabla = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdListar
            // 
            this.cmdListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListar.Location = new System.Drawing.Point(380, 382);
            this.cmdListar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(106, 32);
            this.cmdListar.TabIndex = 7;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // cbTablas
            // 
            this.cbTablas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTablas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTablas.FormattingEnabled = true;
            this.cbTablas.Items.AddRange(new object[] {
            "Autor",
            "Idioma",
            "Libro",
            "Pais"});
            this.cbTablas.Location = new System.Drawing.Point(206, 387);
            this.cbTablas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTablas.Name = "cbTablas";
            this.cbTablas.Size = new System.Drawing.Size(154, 23);
            this.cbTablas.TabIndex = 6;
            // 
            // lblTabla
            // 
            this.lblTabla.AutoSize = true;
            this.lblTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabla.Location = new System.Drawing.Point(44, 390);
            this.lblTabla.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTabla.Name = "lblTabla";
            this.lblTabla.Size = new System.Drawing.Size(151, 15);
            this.lblTabla.TabIndex = 5;
            this.lblTabla.Text = "Tabla de la base de datos:";
            // 
            // dgvConsultaTabla
            // 
            this.dgvConsultaTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaTabla.Location = new System.Drawing.Point(26, 41);
            this.dgvConsultaTabla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvConsultaTabla.Name = "dgvConsultaTabla";
            this.dgvConsultaTabla.RowHeadersWidth = 51;
            this.dgvConsultaTabla.RowTemplate.Height = 24;
            this.dgvConsultaTabla.Size = new System.Drawing.Size(645, 320);
            this.dgvConsultaTabla.TabIndex = 4;
            // 
            // frmBdConsultaTablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 454);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.cbTablas);
            this.Controls.Add(this.lblTabla);
            this.Controls.Add(this.dgvConsultaTabla);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmBdConsultaTablas";
            this.Text = "Consulta de una Tabla";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.ComboBox cbTablas;
        private System.Windows.Forms.Label lblTabla;
        private System.Windows.Forms.DataGridView dgvConsultaTabla;
    }
}