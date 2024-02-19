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
            this.acceder = new System.Windows.Forms.Button();
            this.Usuario = new System.Windows.Forms.Label();
            this.contrasena = new System.Windows.Forms.Label();
            this.entradaUsuario = new System.Windows.Forms.TextBox();
            this.contrasenaLogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // acceder
            // 
            this.acceder.Location = new System.Drawing.Point(325, 318);
            this.acceder.Name = "acceder";
            this.acceder.Size = new System.Drawing.Size(75, 23);
            this.acceder.TabIndex = 0;
            this.acceder.Text = "Acceder";
            this.acceder.UseVisualStyleBackColor = true;
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(170, 160);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(43, 13);
            this.Usuario.TabIndex = 1;
            this.Usuario.Text = "Usuario";
            // 
            // contrasena
            // 
            this.contrasena.AutoSize = true;
            this.contrasena.Location = new System.Drawing.Point(170, 201);
            this.contrasena.Name = "contrasena";
            this.contrasena.Size = new System.Drawing.Size(61, 13);
            this.contrasena.TabIndex = 2;
            this.contrasena.Text = "Contraseña";
            // 
            // entradaUsuario
            // 
            this.entradaUsuario.Location = new System.Drawing.Point(250, 152);
            this.entradaUsuario.Name = "entradaUsuario";
            this.entradaUsuario.Size = new System.Drawing.Size(205, 20);
            this.entradaUsuario.TabIndex = 3;
            // 
            // contrasenaLogin
            // 
            this.contrasenaLogin.Location = new System.Drawing.Point(250, 201);
            this.contrasenaLogin.Name = "contrasenaLogin";
            this.contrasenaLogin.Size = new System.Drawing.Size(205, 20);
            this.contrasenaLogin.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contrasenaLogin);
            this.Controls.Add(this.entradaUsuario);
            this.Controls.Add(this.contrasena);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.acceder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button acceder;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label contrasena;
        private System.Windows.Forms.TextBox entradaUsuario;
        private System.Windows.Forms.TextBox contrasenaLogin;
    }
}

