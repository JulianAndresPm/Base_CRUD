namespace AdminEmpleados.Vistas
{
    partial class Form_deptos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdDepto = new System.Windows.Forms.TextBox();
            this.txtNomDepto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridDepto = new System.Windows.Forms.DataGridView();
            this.btnCancelarDepto = new System.Windows.Forms.Button();
            this.btnBorrarDepto = new System.Windows.Forms.Button();
            this.btnModificarDepto = new System.Windows.Forms.Button();
            this.btnAgregarDepto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridDepto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.label1.Location = new System.Drawing.Point(31, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // txtIdDepto
            // 
            this.txtIdDepto.Location = new System.Drawing.Point(34, 67);
            this.txtIdDepto.Name = "txtIdDepto";
            this.txtIdDepto.Size = new System.Drawing.Size(183, 20);
            this.txtIdDepto.TabIndex = 1;
            // 
            // txtNomDepto
            // 
            this.txtNomDepto.Location = new System.Drawing.Point(267, 67);
            this.txtNomDepto.Name = "txtNomDepto";
            this.txtNomDepto.Size = new System.Drawing.Size(236, 20);
            this.txtNomDepto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Depto";
            // 
            // gridDepto
            // 
            this.gridDepto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDepto.Location = new System.Drawing.Point(34, 141);
            this.gridDepto.Name = "gridDepto";
            this.gridDepto.Size = new System.Drawing.Size(469, 134);
            this.gridDepto.TabIndex = 18;
            // 
            // btnCancelarDepto
            // 
            this.btnCancelarDepto.Location = new System.Drawing.Point(353, 103);
            this.btnCancelarDepto.Name = "btnCancelarDepto";
            this.btnCancelarDepto.Size = new System.Drawing.Size(74, 23);
            this.btnCancelarDepto.TabIndex = 40;
            this.btnCancelarDepto.Text = "Cancelar";
            this.btnCancelarDepto.UseVisualStyleBackColor = true;
            // 
            // btnBorrarDepto
            // 
            this.btnBorrarDepto.Location = new System.Drawing.Point(272, 103);
            this.btnBorrarDepto.Name = "btnBorrarDepto";
            this.btnBorrarDepto.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarDepto.TabIndex = 39;
            this.btnBorrarDepto.Text = "Borrar";
            this.btnBorrarDepto.UseVisualStyleBackColor = true;
            // 
            // btnModificarDepto
            // 
            this.btnModificarDepto.Location = new System.Drawing.Point(191, 103);
            this.btnModificarDepto.Name = "btnModificarDepto";
            this.btnModificarDepto.Size = new System.Drawing.Size(75, 23);
            this.btnModificarDepto.TabIndex = 38;
            this.btnModificarDepto.Text = "Modificar";
            this.btnModificarDepto.UseVisualStyleBackColor = true;
            // 
            // btnAgregarDepto
            // 
            this.btnAgregarDepto.Location = new System.Drawing.Point(106, 103);
            this.btnAgregarDepto.Name = "btnAgregarDepto";
            this.btnAgregarDepto.Size = new System.Drawing.Size(79, 23);
            this.btnAgregarDepto.TabIndex = 37;
            this.btnAgregarDepto.Text = "Agregar";
            this.btnAgregarDepto.UseVisualStyleBackColor = true;
            this.btnAgregarDepto.Click += new System.EventHandler(this.btnAgregarDepto_Click);
            // 
            // Form_deptos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 450);
            this.Controls.Add(this.btnCancelarDepto);
            this.Controls.Add(this.btnBorrarDepto);
            this.Controls.Add(this.btnModificarDepto);
            this.Controls.Add(this.btnAgregarDepto);
            this.Controls.Add(this.gridDepto);
            this.Controls.Add(this.txtNomDepto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdDepto);
            this.Controls.Add(this.label1);
            this.Name = "Form_deptos";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridDepto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdDepto;
        private System.Windows.Forms.TextBox txtNomDepto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridDepto;
        private System.Windows.Forms.Button btnCancelarDepto;
        private System.Windows.Forms.Button btnBorrarDepto;
        private System.Windows.Forms.Button btnModificarDepto;
        private System.Windows.Forms.Button btnAgregarDepto;
    }
}