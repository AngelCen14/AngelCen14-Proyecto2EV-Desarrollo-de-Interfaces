namespace Proyecto2EV.Vistas
{
    partial class FormPublicarReseña
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
            this.labelJuego = new System.Windows.Forms.Label();
            this.labelNota = new System.Windows.Forms.Label();
            this.comboBoxVideoJuegos = new System.Windows.Forms.ComboBox();
            this.numericUpDownNota = new System.Windows.Forms.NumericUpDown();
            this.labelReseña = new System.Windows.Forms.Label();
            this.richTextBoxReseña = new System.Windows.Forms.RichTextBox();
            this.labelCaracteresRestantes = new System.Windows.Forms.Label();
            this.botonPublicar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNota)).BeginInit();
            this.SuspendLayout();
            // 
            // labelJuego
            // 
            this.labelJuego.AutoSize = true;
            this.labelJuego.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJuego.Location = new System.Drawing.Point(96, 26);
            this.labelJuego.Name = "labelJuego";
            this.labelJuego.Size = new System.Drawing.Size(76, 28);
            this.labelJuego.TabIndex = 0;
            this.labelJuego.Text = "Juego:";
            // 
            // labelNota
            // 
            this.labelNota.AutoSize = true;
            this.labelNota.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNota.Location = new System.Drawing.Point(96, 64);
            this.labelNota.Name = "labelNota";
            this.labelNota.Size = new System.Drawing.Size(67, 28);
            this.labelNota.TabIndex = 0;
            this.labelNota.Text = "Nota:";
            // 
            // comboBoxVideoJuegos
            // 
            this.comboBoxVideoJuegos.DropDownHeight = 100;
            this.comboBoxVideoJuegos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVideoJuegos.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVideoJuegos.FormattingEnabled = true;
            this.comboBoxVideoJuegos.IntegralHeight = false;
            this.comboBoxVideoJuegos.ItemHeight = 17;
            this.comboBoxVideoJuegos.Location = new System.Drawing.Point(178, 29);
            this.comboBoxVideoJuegos.Name = "comboBoxVideoJuegos";
            this.comboBoxVideoJuegos.Size = new System.Drawing.Size(285, 25);
            this.comboBoxVideoJuegos.TabIndex = 0;
            // 
            // numericUpDownNota
            // 
            this.numericUpDownNota.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownNota.Location = new System.Drawing.Point(178, 64);
            this.numericUpDownNota.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownNota.Name = "numericUpDownNota";
            this.numericUpDownNota.Size = new System.Drawing.Size(120, 24);
            this.numericUpDownNota.TabIndex = 1;
            // 
            // labelReseña
            // 
            this.labelReseña.AutoSize = true;
            this.labelReseña.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReseña.Location = new System.Drawing.Point(96, 104);
            this.labelReseña.Name = "labelReseña";
            this.labelReseña.Size = new System.Drawing.Size(90, 28);
            this.labelReseña.TabIndex = 0;
            this.labelReseña.Text = "Reseña:";
            // 
            // richTextBoxReseña
            // 
            this.richTextBoxReseña.Location = new System.Drawing.Point(101, 135);
            this.richTextBoxReseña.MaxLength = 400;
            this.richTextBoxReseña.Name = "richTextBoxReseña";
            this.richTextBoxReseña.Size = new System.Drawing.Size(362, 190);
            this.richTextBoxReseña.TabIndex = 2;
            this.richTextBoxReseña.Text = "";
            this.richTextBoxReseña.TextChanged += new System.EventHandler(this.richTextBoxReseña_TextChanged);
            // 
            // labelCaracteresRestantes
            // 
            this.labelCaracteresRestantes.AutoSize = true;
            this.labelCaracteresRestantes.Location = new System.Drawing.Point(98, 328);
            this.labelCaracteresRestantes.Name = "labelCaracteresRestantes";
            this.labelCaracteresRestantes.Size = new System.Drawing.Size(107, 13);
            this.labelCaracteresRestantes.TabIndex = 0;
            this.labelCaracteresRestantes.Text = "Caracteres restantes:";
            // 
            // botonPublicar
            // 
            this.botonPublicar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonPublicar.Location = new System.Drawing.Point(379, 359);
            this.botonPublicar.Name = "botonPublicar";
            this.botonPublicar.Size = new System.Drawing.Size(84, 29);
            this.botonPublicar.TabIndex = 3;
            this.botonPublicar.Text = "Publicar";
            this.botonPublicar.UseVisualStyleBackColor = true;
            this.botonPublicar.Click += new System.EventHandler(this.botonPublicar_Click);
            // 
            // FormPublicarReseña
            // 
            this.AcceptButton = this.botonPublicar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 403);
            this.Controls.Add(this.botonPublicar);
            this.Controls.Add(this.labelCaracteresRestantes);
            this.Controls.Add(this.richTextBoxReseña);
            this.Controls.Add(this.labelReseña);
            this.Controls.Add(this.numericUpDownNota);
            this.Controls.Add(this.comboBoxVideoJuegos);
            this.Controls.Add(this.labelNota);
            this.Controls.Add(this.labelJuego);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormPublicarReseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Publicar Reseña";
            this.Load += new System.EventHandler(this.FormPublicarReseña_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelJuego;
        private System.Windows.Forms.Label labelNota;
        private System.Windows.Forms.ComboBox comboBoxVideoJuegos;
        private System.Windows.Forms.NumericUpDown numericUpDownNota;
        private System.Windows.Forms.Label labelReseña;
        private System.Windows.Forms.RichTextBox richTextBoxReseña;
        private System.Windows.Forms.Label labelCaracteresRestantes;
        private System.Windows.Forms.Button botonPublicar;
    }
}