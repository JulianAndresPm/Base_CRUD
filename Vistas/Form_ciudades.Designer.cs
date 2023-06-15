namespace AdminEmpleados.Vistas
{
    partial class Form_ciudades
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
            this.gridCiudad = new System.Windows.Forms.DataGridView();
            this.txtNomCiudad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtIdCiudad = new System.Windows.Forms.Label();
            this.btnCancelarCiudad = new System.Windows.Forms.Button();
            this.btnBorrarCiudad = new System.Windows.Forms.Button();
            this.btnModificarCiudad = new System.Windows.Forms.Button();
            this.btnAgregarCiudad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCiudad)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCiudad
            // 
            this.gridCiudad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCiudad.Location = new System.Drawing.Point(42, 155);
            this.gridCiudad.Name = "gridCiudad";
            this.gridCiudad.Size = new System.Drawing.Size(469, 134);
            this.gridCiudad.TabIndex = 23;
            // 
            // txtNomCiudad
            // 
            this.txtNomCiudad.Location = new System.Drawing.Point(275, 81);
            this.txtNomCiudad.Name = "txtNomCiudad";
            this.txtNomCiudad.Size = new System.Drawing.Size(236, 20);
            this.txtNomCiudad.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nombre Ciudad";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 20);
            this.textBox1.TabIndex = 20;
            // 
            // txtIdCiudad
            // 
            this.txtIdCiudad.AutoSize = true;
            this.txtIdCiudad.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.txtIdCiudad.Location = new System.Drawing.Point(39, 51);
            this.txtIdCiudad.Name = "txtIdCiudad";
            this.txtIdCiudad.Size = new System.Drawing.Size(40, 13);
            this.txtIdCiudad.TabIndex = 19;
            this.txtIdCiudad.Text = "Codigo";
            // 
            // btnCancelarCiudad
            // 
            this.btnCancelarCiudad.Location = new System.Drawing.Point(367, 117);
            this.btnCancelarCiudad.Name = "btnCancelarCiudad";
            this.btnCancelarCiudad.Size = new System.Drawing.Size(74, 23);
            this.btnCancelarCiudad.TabIndex = 40;
            this.btnCancelarCiudad.Text = "Cancelar";
            this.btnCancelarCiudad.UseVisualStyleBackColor = true;
            // 
            // btnBorrarCiudad
            // 
            this.btnBorrarCiudad.Location = new System.Drawing.Point(286, 117);
            this.btnBorrarCiudad.Name = "btnBorrarCiudad";
            this.btnBorrarCiudad.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarCiudad.TabIndex = 39;
            this.btnBorrarCiudad.Text = "Borrar";
            this.btnBorrarCiudad.UseVisualStyleBackColor = true;
            // 
            // btnModificarCiudad
            // 
            this.btnModificarCiudad.Location = new System.Drawing.Point(205, 117);
            this.btnModificarCiudad.Name = "btnModificarCiudad";
            this.btnModificarCiudad.Size = new System.Drawing.Size(75, 23);
            this.btnModificarCiudad.TabIndex = 38;
            this.btnModificarCiudad.Text = "Modificar";
            this.btnModificarCiudad.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCiudad
            // 
            this.btnAgregarCiudad.Location = new System.Drawing.Point(120, 117);
            this.btnAgregarCiudad.Name = "btnAgregarCiudad";
            this.btnAgregarCiudad.Size = new System.Drawing.Size(79, 23);
            this.btnAgregarCiudad.TabIndex = 37;
            this.btnAgregarCiudad.Text = "Agregar";
            this.btnAgregarCiudad.UseVisualStyleBackColor = true;
            // 
            // Form_ciudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 450);
            this.Controls.Add(this.btnCancelarCiudad);
            this.Controls.Add(this.btnBorrarCiudad);
            this.Controls.Add(this.btnModificarCiudad);
            this.Controls.Add(this.btnAgregarCiudad);
            this.Controls.Add(this.gridCiudad);
            this.Controls.Add(this.txtNomCiudad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtIdCiudad);
            this.Name = "Form_ciudades";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridCiudad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCiudad;
        private System.Windows.Forms.TextBox txtNomCiudad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtIdCiudad;
        private System.Windows.Forms.Button btnCancelarCiudad;
        private System.Windows.Forms.Button btnBorrarCiudad;
        private System.Windows.Forms.Button btnModificarCiudad;
        private System.Windows.Forms.Button btnAgregarCiudad;
    }
}