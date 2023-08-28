
namespace repaso3
{
    partial class FDatos
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
            this.rBcirculo = new System.Windows.Forms.RadioButton();
            this.rBprisma = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBlargo = new System.Windows.Forms.TextBox();
            this.tBancho = new System.Windows.Forms.TextBox();
            this.tBalto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rBcirculo
            // 
            this.rBcirculo.AutoSize = true;
            this.rBcirculo.Location = new System.Drawing.Point(13, 30);
            this.rBcirculo.Name = "rBcirculo";
            this.rBcirculo.Size = new System.Drawing.Size(57, 17);
            this.rBcirculo.TabIndex = 0;
            this.rBcirculo.TabStop = true;
            this.rBcirculo.Text = "Circulo";
            this.rBcirculo.UseVisualStyleBackColor = true;
            // 
            // rBprisma
            // 
            this.rBprisma.AutoSize = true;
            this.rBprisma.Location = new System.Drawing.Point(13, 64);
            this.rBprisma.Name = "rBprisma";
            this.rBprisma.Size = new System.Drawing.Size(56, 17);
            this.rBprisma.TabIndex = 1;
            this.rBprisma.TabStop = true;
            this.rBprisma.Text = "Prisma";
            this.rBprisma.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Largo/Radio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ancho:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alto:";
            // 
            // tBlargo
            // 
            this.tBlargo.Location = new System.Drawing.Point(298, 20);
            this.tBlargo.Name = "tBlargo";
            this.tBlargo.Size = new System.Drawing.Size(100, 20);
            this.tBlargo.TabIndex = 5;
            // 
            // tBancho
            // 
            this.tBancho.Location = new System.Drawing.Point(298, 64);
            this.tBancho.Name = "tBancho";
            this.tBancho.Size = new System.Drawing.Size(100, 20);
            this.tBancho.TabIndex = 6;
            // 
            // tBalto
            // 
            this.tBalto.Location = new System.Drawing.Point(298, 110);
            this.tBalto.Name = "tBalto";
            this.tBalto.Size = new System.Drawing.Size(100, 20);
            this.tBalto.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(42, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(218, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 223);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tBalto);
            this.Controls.Add(this.tBancho);
            this.Controls.Add(this.tBlargo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rBprisma);
            this.Controls.Add(this.rBcirculo);
            this.Name = "FDatos";
            this.Text = "FDatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RadioButton rBcirculo;
        public System.Windows.Forms.RadioButton rBprisma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tBlargo;
        public System.Windows.Forms.TextBox tBancho;
        public System.Windows.Forms.TextBox tBalto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}