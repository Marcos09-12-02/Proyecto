
namespace Cliente
{
    partial class Geometry_wars
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
            this.usuario = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.registration = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.consulta1 = new System.Windows.Forms.RadioButton();
            this.consulta2 = new System.Windows.Forms.RadioButton();
            this.consulta3 = new System.Windows.Forms.RadioButton();
            this.edad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(286, 118);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(197, 26);
            this.usuario.TabIndex = 0;
            // 
            // contraseña
            // 
            this.contraseña.Location = new System.Drawing.Point(286, 204);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(197, 26);
            this.contraseña.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(300, 248);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(150, 41);
            this.login.TabIndex = 5;
            this.login.Text = "Iniciar session";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // registration
            // 
            this.registration.Location = new System.Drawing.Point(303, 309);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(147, 42);
            this.registration.TabIndex = 6;
            this.registration.Text = "Registrarse";
            this.registration.UseVisualStyleBackColor = true;
            this.registration.Click += new System.EventHandler(this.registration_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Consultas";
            this.label1.Visible = false;
            // 
            // consulta1
            // 
            this.consulta1.AutoSize = true;
            this.consulta1.Location = new System.Drawing.Point(76, 118);
            this.consulta1.Name = "consulta1";
            this.consulta1.Size = new System.Drawing.Size(106, 24);
            this.consulta1.TabIndex = 8;
            this.consulta1.TabStop = true;
            this.consulta1.Text = "Consulta1";
            this.consulta1.UseVisualStyleBackColor = true;
            this.consulta1.Visible = false;
            // 
            // consulta2
            // 
            this.consulta2.AutoSize = true;
            this.consulta2.Location = new System.Drawing.Point(76, 160);
            this.consulta2.Name = "consulta2";
            this.consulta2.Size = new System.Drawing.Size(106, 24);
            this.consulta2.TabIndex = 9;
            this.consulta2.TabStop = true;
            this.consulta2.Text = "Consulta2";
            this.consulta2.UseVisualStyleBackColor = true;
            this.consulta2.Visible = false;
            // 
            // consulta3
            // 
            this.consulta3.AutoSize = true;
            this.consulta3.Location = new System.Drawing.Point(76, 204);
            this.consulta3.Name = "consulta3";
            this.consulta3.Size = new System.Drawing.Size(106, 24);
            this.consulta3.TabIndex = 10;
            this.consulta3.TabStop = true;
            this.consulta3.Text = "Consulta3";
            this.consulta3.UseVisualStyleBackColor = true;
            this.consulta3.Visible = false;
            // 
            // edad
            // 
            this.edad.Location = new System.Drawing.Point(523, 204);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(197, 26);
            this.edad.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(582, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Edad";
            // 
            // Geometry_wars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edad);
            this.Controls.Add(this.consulta3);
            this.Controls.Add(this.consulta2);
            this.Controls.Add(this.consulta1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registration);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.usuario);
            this.Name = "Geometry_wars";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Geometry_wars_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button registration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton consulta1;
        private System.Windows.Forms.RadioButton consulta2;
        private System.Windows.Forms.RadioButton consulta3;
        private System.Windows.Forms.TextBox edad;
        private System.Windows.Forms.Label label4;
    }
}

