
namespace repaso3
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcularPrecio = new System.Windows.Forms.Button();
            this.btnAgregarF = new System.Windows.Forms.Button();
            this.btnImpresion = new System.Windows.Forms.Button();
            this.tBnombre = new System.Windows.Forms.TextBox();
            this.tBcuit = new System.Windows.Forms.TextBox();
            this.tBprecioM = new System.Windows.Forms.TextBox();
            this.lBlista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cuit/Cuil:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio Material:";
            // 
            // btnCalcularPrecio
            // 
            this.btnCalcularPrecio.Location = new System.Drawing.Point(249, 124);
            this.btnCalcularPrecio.Name = "btnCalcularPrecio";
            this.btnCalcularPrecio.Size = new System.Drawing.Size(75, 39);
            this.btnCalcularPrecio.TabIndex = 3;
            this.btnCalcularPrecio.Text = "Calcular Precio";
            this.btnCalcularPrecio.UseVisualStyleBackColor = true;
            this.btnCalcularPrecio.Click += new System.EventHandler(this.btnCalcularPrecio_Click);
            // 
            // btnAgregarF
            // 
            this.btnAgregarF.Location = new System.Drawing.Point(249, 72);
            this.btnAgregarF.Name = "btnAgregarF";
            this.btnAgregarF.Size = new System.Drawing.Size(75, 46);
            this.btnAgregarF.TabIndex = 4;
            this.btnAgregarF.Text = "Agregar Figura";
            this.btnAgregarF.UseVisualStyleBackColor = true;
            this.btnAgregarF.Click += new System.EventHandler(this.btnAgregarF_Click);
            // 
            // btnImpresion
            // 
            this.btnImpresion.Location = new System.Drawing.Point(249, 25);
            this.btnImpresion.Name = "btnImpresion";
            this.btnImpresion.Size = new System.Drawing.Size(75, 41);
            this.btnImpresion.TabIndex = 5;
            this.btnImpresion.Text = "Crear Impresion";
            this.btnImpresion.UseVisualStyleBackColor = true;
            this.btnImpresion.Click += new System.EventHandler(this.btnImpresion_Click);
            // 
            // tBnombre
            // 
            this.tBnombre.Location = new System.Drawing.Point(97, 25);
            this.tBnombre.Name = "tBnombre";
            this.tBnombre.Size = new System.Drawing.Size(100, 20);
            this.tBnombre.TabIndex = 6;
            // 
            // tBcuit
            // 
            this.tBcuit.Location = new System.Drawing.Point(97, 64);
            this.tBcuit.Name = "tBcuit";
            this.tBcuit.Size = new System.Drawing.Size(100, 20);
            this.tBcuit.TabIndex = 7;
            // 
            // tBprecioM
            // 
            this.tBprecioM.Location = new System.Drawing.Point(97, 116);
            this.tBprecioM.Name = "tBprecioM";
            this.tBprecioM.Size = new System.Drawing.Size(100, 20);
            this.tBprecioM.TabIndex = 8;
            // 
            // lBlista
            // 
            this.lBlista.FormattingEnabled = true;
            this.lBlista.Location = new System.Drawing.Point(5, 182);
            this.lBlista.Name = "lBlista";
            this.lBlista.Size = new System.Drawing.Size(462, 199);
            this.lBlista.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 407);
            this.Controls.Add(this.lBlista);
            this.Controls.Add(this.tBprecioM);
            this.Controls.Add(this.tBcuit);
            this.Controls.Add(this.tBnombre);
            this.Controls.Add(this.btnImpresion);
            this.Controls.Add(this.btnAgregarF);
            this.Controls.Add(this.btnCalcularPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalcularPrecio;
        private System.Windows.Forms.Button btnAgregarF;
        public System.Windows.Forms.Button btnImpresion;
        private System.Windows.Forms.TextBox tBnombre;
        private System.Windows.Forms.TextBox tBcuit;
        private System.Windows.Forms.TextBox tBprecioM;
        private System.Windows.Forms.ListBox lBlista;
    }
}

