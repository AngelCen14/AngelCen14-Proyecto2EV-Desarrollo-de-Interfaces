namespace Proyecto2EV.Vistas
{
    partial class FormVideoJuego
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelFechaSalida = new System.Windows.Forms.Label();
            this.labelPlataforma = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.pictureBoxVideoJuego = new System.Windows.Forms.PictureBox();
            this.botonAñadirAlCarrito = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVideoJuego)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(226, 12);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(100, 28);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // labelFechaSalida
            // 
            this.labelFechaSalida.AutoSize = true;
            this.labelFechaSalida.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaSalida.Location = new System.Drawing.Point(226, 40);
            this.labelFechaSalida.Name = "labelFechaSalida";
            this.labelFechaSalida.Size = new System.Drawing.Size(138, 28);
            this.labelFechaSalida.TabIndex = 0;
            this.labelFechaSalida.Text = "Fecha Salida";
            // 
            // labelPlataforma
            // 
            this.labelPlataforma.AutoSize = true;
            this.labelPlataforma.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlataforma.Location = new System.Drawing.Point(226, 68);
            this.labelPlataforma.Name = "labelPlataforma";
            this.labelPlataforma.Size = new System.Drawing.Size(123, 28);
            this.labelPlataforma.TabIndex = 0;
            this.labelPlataforma.Text = "Plataforma";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.Location = new System.Drawing.Point(226, 96);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(75, 28);
            this.labelPrecio.TabIndex = 0;
            this.labelPrecio.Text = "Precio";
            // 
            // pictureBoxVideoJuego
            // 
            this.pictureBoxVideoJuego.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxVideoJuego.Name = "pictureBoxVideoJuego";
            this.pictureBoxVideoJuego.Size = new System.Drawing.Size(208, 283);
            this.pictureBoxVideoJuego.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVideoJuego.TabIndex = 5;
            this.pictureBoxVideoJuego.TabStop = false;
            // 
            // botonAñadirAlCarrito
            // 
            this.botonAñadirAlCarrito.Location = new System.Drawing.Point(231, 258);
            this.botonAñadirAlCarrito.Name = "botonAñadirAlCarrito";
            this.botonAñadirAlCarrito.Size = new System.Drawing.Size(133, 37);
            this.botonAñadirAlCarrito.TabIndex = 0;
            this.botonAñadirAlCarrito.Text = "Añadir al carrito";
            this.botonAñadirAlCarrito.UseVisualStyleBackColor = true;
            this.botonAñadirAlCarrito.Click += new System.EventHandler(this.botonAñadirAlCarrito_Click);
            // 
            // FormVideoJuego
            // 
            this.AcceptButton = this.botonAñadirAlCarrito;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 314);
            this.Controls.Add(this.botonAñadirAlCarrito);
            this.Controls.Add(this.pictureBoxVideoJuego);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelPlataforma);
            this.Controls.Add(this.labelFechaSalida);
            this.Controls.Add(this.labelNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormVideoJuego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVideoJuego";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVideoJuego)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelFechaSalida;
        private System.Windows.Forms.Label labelPlataforma;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.PictureBox pictureBoxVideoJuego;
        private System.Windows.Forms.Button botonAñadirAlCarrito;
    }
}