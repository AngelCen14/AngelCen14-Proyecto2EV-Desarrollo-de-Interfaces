namespace Proyecto2EV.Vistas {
    partial class FormCatalogo {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.groupBoxCatalogo = new System.Windows.Forms.GroupBox();
            this.panelCatalogo = new System.Windows.Forms.Panel();
            this.botonAñadirCarrito = new System.Windows.Forms.Button();
            this.comboBoxPlataforma = new System.Windows.Forms.ComboBox();
            this.labelPlataforma = new System.Windows.Forms.Label();
            this.labelOrdenarPor = new System.Windows.Forms.Label();
            this.comboBoxTiposOrdenacion = new System.Windows.Forms.ComboBox();
            this.groupBoxCatalogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCatalogo
            // 
            this.groupBoxCatalogo.Controls.Add(this.panelCatalogo);
            this.groupBoxCatalogo.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCatalogo.Name = "groupBoxCatalogo";
            this.groupBoxCatalogo.Size = new System.Drawing.Size(1040, 478);
            this.groupBoxCatalogo.TabIndex = 0;
            this.groupBoxCatalogo.TabStop = false;
            this.groupBoxCatalogo.Text = "Catalogo de juegos";
            // 
            // panelCatalogo
            // 
            this.panelCatalogo.AutoScroll = true;
            this.panelCatalogo.Location = new System.Drawing.Point(6, 19);
            this.panelCatalogo.Name = "panelCatalogo";
            this.panelCatalogo.Size = new System.Drawing.Size(1028, 453);
            this.panelCatalogo.TabIndex = 0;
            // 
            // botonAñadirCarrito
            // 
            this.botonAñadirCarrito.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAñadirCarrito.Location = new System.Drawing.Point(918, 493);
            this.botonAñadirCarrito.Name = "botonAñadirCarrito";
            this.botonAñadirCarrito.Size = new System.Drawing.Size(134, 25);
            this.botonAñadirCarrito.TabIndex = 2;
            this.botonAñadirCarrito.Text = "Añadir al carrito";
            this.botonAñadirCarrito.UseVisualStyleBackColor = true;
            this.botonAñadirCarrito.Click += new System.EventHandler(this.botonAñadirCarrito_Click);
            // 
            // comboBoxPlataforma
            // 
            this.comboBoxPlataforma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPlataforma.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPlataforma.FormattingEnabled = true;
            this.comboBoxPlataforma.Location = new System.Drawing.Point(131, 493);
            this.comboBoxPlataforma.Name = "comboBoxPlataforma";
            this.comboBoxPlataforma.Size = new System.Drawing.Size(183, 24);
            this.comboBoxPlataforma.TabIndex = 0;
            this.comboBoxPlataforma.SelectedIndexChanged += new System.EventHandler(this.comboBoxPlataforma_SelectedIndexChanged);
            // 
            // labelPlataforma
            // 
            this.labelPlataforma.AutoSize = true;
            this.labelPlataforma.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlataforma.Location = new System.Drawing.Point(7, 493);
            this.labelPlataforma.Name = "labelPlataforma";
            this.labelPlataforma.Size = new System.Drawing.Size(118, 25);
            this.labelPlataforma.TabIndex = 0;
            this.labelPlataforma.Text = "Plataforma:";
            // 
            // labelOrdenarPor
            // 
            this.labelOrdenarPor.AutoSize = true;
            this.labelOrdenarPor.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrdenarPor.Location = new System.Drawing.Point(328, 493);
            this.labelOrdenarPor.Name = "labelOrdenarPor";
            this.labelOrdenarPor.Size = new System.Drawing.Size(129, 25);
            this.labelOrdenarPor.TabIndex = 0;
            this.labelOrdenarPor.Text = "Ordenar por:";
            // 
            // comboBoxTiposOrdenacion
            // 
            this.comboBoxTiposOrdenacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTiposOrdenacion.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTiposOrdenacion.FormattingEnabled = true;
            this.comboBoxTiposOrdenacion.Location = new System.Drawing.Point(463, 493);
            this.comboBoxTiposOrdenacion.Name = "comboBoxTiposOrdenacion";
            this.comboBoxTiposOrdenacion.Size = new System.Drawing.Size(183, 24);
            this.comboBoxTiposOrdenacion.TabIndex = 1;
            this.comboBoxTiposOrdenacion.SelectedIndexChanged += new System.EventHandler(this.comboBoxTiposOrdenacion_SelectedIndexChanged);
            // 
            // FormCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 555);
            this.Controls.Add(this.labelOrdenarPor);
            this.Controls.Add(this.comboBoxTiposOrdenacion);
            this.Controls.Add(this.botonAñadirCarrito);
            this.Controls.Add(this.labelPlataforma);
            this.Controls.Add(this.comboBoxPlataforma);
            this.Controls.Add(this.groupBoxCatalogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormCatalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo";
            this.Load += new System.EventHandler(this.FormCatalogo_Load);
            this.groupBoxCatalogo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxCatalogo;
        private System.Windows.Forms.Panel panelCatalogo;
        private System.Windows.Forms.Button botonAñadirCarrito;
        private System.Windows.Forms.ComboBox comboBoxPlataforma;
        private System.Windows.Forms.Label labelPlataforma;
        private System.Windows.Forms.Label labelOrdenarPor;
        private System.Windows.Forms.ComboBox comboBoxTiposOrdenacion;
    }
}