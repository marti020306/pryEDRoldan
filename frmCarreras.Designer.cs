namespace pryEDRoldan
{
    partial class frmCarreras
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
            this.lblCarreras = new System.Windows.Forms.Label();
            this.txtCarreras = new System.Windows.Forms.TextBox();
            this.lstCarrera = new System.Windows.Forms.ListBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCarreras
            // 
            this.lblCarreras.AutoSize = true;
            this.lblCarreras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarreras.Location = new System.Drawing.Point(29, 40);
            this.lblCarreras.Name = "lblCarreras";
            this.lblCarreras.Size = new System.Drawing.Size(59, 16);
            this.lblCarreras.TabIndex = 0;
            this.lblCarreras.Text = "Carreras";
            // 
            // txtCarreras
            // 
            this.txtCarreras.Location = new System.Drawing.Point(133, 40);
            this.txtCarreras.Name = "txtCarreras";
            this.txtCarreras.Size = new System.Drawing.Size(152, 20);
            this.txtCarreras.TabIndex = 3;
            this.txtCarreras.TextChanged += new System.EventHandler(this.txtCarreras_TextChanged);
            // 
            // lstCarrera
            // 
            this.lstCarrera.FormattingEnabled = true;
            this.lstCarrera.Location = new System.Drawing.Point(12, 160);
            this.lstCarrera.Name = "lstCarrera";
            this.lstCarrera.Size = new System.Drawing.Size(273, 173);
            this.lstCarrera.TabIndex = 2;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Enabled = false;
            this.btnGrabar.Location = new System.Drawing.Point(144, 99);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(141, 23);
            this.btnGrabar.TabIndex = 1;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(12, 99);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(108, 23);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 354);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtCarreras);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.lstCarrera);
            this.Controls.Add(this.lblCarreras);
            this.Name = "frmCarreras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carreras";
            this.Load += new System.EventHandler(this.frmCarreras_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarreras;
        private System.Windows.Forms.TextBox txtCarreras;
        private System.Windows.Forms.ListBox lstCarrera;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}