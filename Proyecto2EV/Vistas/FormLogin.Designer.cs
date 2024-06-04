namespace Proyecto2EV
{
    partial class FormLogin
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
            this.textBoxUsuarioLogin = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxClaveLogin = new System.Windows.Forms.TextBox();
            this.botonLogin = new System.Windows.Forms.Button();
            this.labelRegistro = new System.Windows.Forms.Label();
            this.botonRegister = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxClaveRegistro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUsuarioRegistro = new System.Windows.Forms.TextBox();
            this.dateTimePickerFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.labelFechaNacimiento = new System.Windows.Forms.Label();
            this.botonCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxUsuarioLogin
            // 
            this.textBoxUsuarioLogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuarioLogin.Location = new System.Drawing.Point(214, 49);
            this.textBoxUsuarioLogin.Name = "textBoxUsuarioLogin";
            this.textBoxUsuarioLogin.Size = new System.Drawing.Size(190, 24);
            this.textBoxUsuarioLogin.TabIndex = 0;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(70, 45);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(99, 28);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contraseña:";
            // 
            // textBoxClaveLogin
            // 
            this.textBoxClaveLogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClaveLogin.Location = new System.Drawing.Point(214, 83);
            this.textBoxClaveLogin.Name = "textBoxClaveLogin";
            this.textBoxClaveLogin.PasswordChar = '●';
            this.textBoxClaveLogin.Size = new System.Drawing.Size(190, 24);
            this.textBoxClaveLogin.TabIndex = 1;
            this.textBoxClaveLogin.Enter += new System.EventHandler(this.textBoxClaveLogin_Enter);
            this.textBoxClaveLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxClaveLogin_KeyDown);
            // 
            // botonLogin
            // 
            this.botonLogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonLogin.Location = new System.Drawing.Point(75, 133);
            this.botonLogin.Name = "botonLogin";
            this.botonLogin.Size = new System.Drawing.Size(329, 29);
            this.botonLogin.TabIndex = 2;
            this.botonLogin.Text = "Iniciar Sesion";
            this.botonLogin.UseVisualStyleBackColor = true;
            this.botonLogin.Click += new System.EventHandler(this.botonLogin_Click);
            // 
            // labelRegistro
            // 
            this.labelRegistro.AutoSize = true;
            this.labelRegistro.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistro.Location = new System.Drawing.Point(110, 188);
            this.labelRegistro.Name = "labelRegistro";
            this.labelRegistro.Size = new System.Drawing.Size(241, 21);
            this.labelRegistro.TabIndex = 5;
            this.labelRegistro.Text = "¿No tienes cuenta? Registrate:\r\n";
            // 
            // botonRegister
            // 
            this.botonRegister.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRegister.Location = new System.Drawing.Point(75, 354);
            this.botonRegister.Name = "botonRegister";
            this.botonRegister.Size = new System.Drawing.Size(329, 29);
            this.botonRegister.TabIndex = 6;
            this.botonRegister.Text = "Registrarse";
            this.botonRegister.UseVisualStyleBackColor = true;
            this.botonRegister.Click += new System.EventHandler(this.botonRegister_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Contraseña:";
            // 
            // textBoxClaveRegistro
            // 
            this.textBoxClaveRegistro.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClaveRegistro.Location = new System.Drawing.Point(214, 259);
            this.textBoxClaveRegistro.Name = "textBoxClaveRegistro";
            this.textBoxClaveRegistro.PasswordChar = '●';
            this.textBoxClaveRegistro.Size = new System.Drawing.Size(190, 24);
            this.textBoxClaveRegistro.TabIndex = 4;
            this.textBoxClaveRegistro.Enter += new System.EventHandler(this.textBoxClaveRegistro_Enter);
            this.textBoxClaveRegistro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxClaveRegistro_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Usuario:";
            // 
            // textBoxUsuarioRegistro
            // 
            this.textBoxUsuarioRegistro.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuarioRegistro.Location = new System.Drawing.Point(214, 229);
            this.textBoxUsuarioRegistro.Name = "textBoxUsuarioRegistro";
            this.textBoxUsuarioRegistro.Size = new System.Drawing.Size(190, 24);
            this.textBoxUsuarioRegistro.TabIndex = 3;
            // 
            // dateTimePickerFechaNacimiento
            // 
            this.dateTimePickerFechaNacimiento.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaNacimiento.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaNacimiento.Location = new System.Drawing.Point(214, 321);
            this.dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            this.dateTimePickerFechaNacimiento.Size = new System.Drawing.Size(190, 24);
            this.dateTimePickerFechaNacimiento.TabIndex = 5;
            // 
            // labelFechaNacimiento
            // 
            this.labelFechaNacimiento.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaNacimiento.Location = new System.Drawing.Point(70, 289);
            this.labelFechaNacimiento.Name = "labelFechaNacimiento";
            this.labelFechaNacimiento.Size = new System.Drawing.Size(138, 62);
            this.labelFechaNacimiento.TabIndex = 0;
            this.labelFechaNacimiento.Text = "Fecha Nacimento:";
            // 
            // botonCerrar
            // 
            this.botonCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonCerrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCerrar.Location = new System.Drawing.Point(75, 410);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(329, 29);
            this.botonCerrar.TabIndex = 13;
            this.botonCerrar.Text = "Salir";
            this.botonCerrar.UseVisualStyleBackColor = true;
            this.botonCerrar.Click += new System.EventHandler(this.botonCerrar_Click);
            // 
            // FormLogin
            // 
            this.AcceptButton = this.botonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.botonCerrar;
            this.ClientSize = new System.Drawing.Size(474, 451);
            this.ControlBox = false;
            this.Controls.Add(this.botonCerrar);
            this.Controls.Add(this.labelFechaNacimiento);
            this.Controls.Add(this.dateTimePickerFechaNacimiento);
            this.Controls.Add(this.botonRegister);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxClaveRegistro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxUsuarioRegistro);
            this.Controls.Add(this.labelRegistro);
            this.Controls.Add(this.botonLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxClaveLogin);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.textBoxUsuarioLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsuarioLogin;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxClaveLogin;
        private System.Windows.Forms.Button botonLogin;
        private System.Windows.Forms.Label labelRegistro;
        private System.Windows.Forms.Button botonRegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxClaveRegistro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUsuarioRegistro;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaNacimiento;
        private System.Windows.Forms.Label labelFechaNacimiento;
        private System.Windows.Forms.Button botonCerrar;
    }
}

