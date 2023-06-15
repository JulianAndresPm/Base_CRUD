namespace AdminEmpleados
{
    partial class frm_home
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
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnCiudades = new System.Windows.Forms.Button();
            this.btnDepto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUsuario
            // 
            this.btnUsuario.Location = new System.Drawing.Point(6, 128);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(143, 72);
            this.btnUsuario.TabIndex = 1;
            this.btnUsuario.Text = "Usuarios";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCiudades
            // 
            this.btnCiudades.Location = new System.Drawing.Point(166, 128);
            this.btnCiudades.Name = "btnCiudades";
            this.btnCiudades.Size = new System.Drawing.Size(143, 72);
            this.btnCiudades.TabIndex = 2;
            this.btnCiudades.Text = "Ciudades";
            this.btnCiudades.UseVisualStyleBackColor = true;
            this.btnCiudades.Click += new System.EventHandler(this.btnCiudades_Click);
            // 
            // btnDepto
            // 
            this.btnDepto.Location = new System.Drawing.Point(332, 128);
            this.btnDepto.Name = "btnDepto";
            this.btnDepto.Size = new System.Drawing.Size(143, 72);
            this.btnDepto.TabIndex = 3;
            this.btnDepto.Text = "Departamentos";
            this.btnDepto.UseVisualStyleBackColor = true;
            this.btnDepto.Click += new System.EventHandler(this.btnDepto_Click);
            // 
            // frm_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 303);
            this.Controls.Add(this.btnDepto);
            this.Controls.Add(this.btnCiudades);
            this.Controls.Add(this.btnUsuario);
            this.Name = "frm_home";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnCiudades;
        private System.Windows.Forms.Button btnDepto;
    }
}

