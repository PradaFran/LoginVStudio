namespace login2
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
            this.Registrar = new System.Windows.Forms.Button();
            this.Contrasena = new System.Windows.Forms.TextBox();
            this.ConfirmContrasena = new System.Windows.Forms.TextBox();
            this.contrasenaRegistro = new System.Windows.Forms.Label();
            this.nombreRegistro = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Registrar
            // 
            this.Registrar.Location = new System.Drawing.Point(344, 319);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(75, 23);
            this.Registrar.TabIndex = 0;
            this.Registrar.Text = "Registrar";
            this.Registrar.UseVisualStyleBackColor = true;
            this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // Contrasena
            // 
            this.Contrasena.Location = new System.Drawing.Point(254, 146);
            this.Contrasena.Name = "Contrasena";
            this.Contrasena.Size = new System.Drawing.Size(243, 20);
            this.Contrasena.TabIndex = 1;
            // 
            // ConfirmContrasena
            // 
            this.ConfirmContrasena.Location = new System.Drawing.Point(254, 209);
            this.ConfirmContrasena.Name = "ConfirmContrasena";
            this.ConfirmContrasena.Size = new System.Drawing.Size(243, 20);
            this.ConfirmContrasena.TabIndex = 2;
            // 
            // contrasenaRegistro
            // 
            this.contrasenaRegistro.AutoSize = true;
            this.contrasenaRegistro.Location = new System.Drawing.Point(149, 146);
            this.contrasenaRegistro.Name = "contrasenaRegistro";
            this.contrasenaRegistro.Size = new System.Drawing.Size(61, 13);
            this.contrasenaRegistro.TabIndex = 3;
            this.contrasenaRegistro.Text = "Contraseña";
            // 
            // nombreRegistro
            // 
            this.nombreRegistro.AutoSize = true;
            this.nombreRegistro.Location = new System.Drawing.Point(149, 89);
            this.nombreRegistro.Name = "nombreRegistro";
            this.nombreRegistro.Size = new System.Drawing.Size(44, 13);
            this.nombreRegistro.TabIndex = 4;
            this.nombreRegistro.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirmar contraseña";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(254, 81);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(243, 20);
            this.Nombre.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nombreRegistro);
            this.Controls.Add(this.contrasenaRegistro);
            this.Controls.Add(this.ConfirmContrasena);
            this.Controls.Add(this.Contrasena);
            this.Controls.Add(this.Registrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Registrar;
        private System.Windows.Forms.TextBox Contrasena;
        private System.Windows.Forms.TextBox ConfirmContrasena;
        private System.Windows.Forms.Label contrasenaRegistro;
        private System.Windows.Forms.Label nombreRegistro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Nombre;
    }
}

