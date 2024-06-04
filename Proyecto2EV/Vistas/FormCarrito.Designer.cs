namespace Proyecto2EV.Vistas
{
    partial class FormCarrito
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxCarrito = new System.Windows.Forms.GroupBox();
            this.labelPrecioTotal = new System.Windows.Forms.Label();
            this.panelCarrito = new System.Windows.Forms.Panel();
            this.botonPagar = new System.Windows.Forms.Button();
            this.maskedTextBoxNumeroTarjeta = new System.Windows.Forms.MaskedTextBox();
            this.labelDatosTarjeta = new System.Windows.Forms.Label();
            this.labelNumeroTarjeta = new System.Windows.Forms.Label();
            this.labelTitular = new System.Windows.Forms.Label();
            this.textBoxTitular = new System.Windows.Forms.TextBox();
            this.labelCvv = new System.Windows.Forms.Label();
            this.maskedTextBoxCvv = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePickerFechaCaducidad = new System.Windows.Forms.DateTimePicker();
            this.labelFechaCaducidad = new System.Windows.Forms.Label();
            this.checkBoxGuardarTarjeta = new System.Windows.Forms.CheckBox();
            this.progressBarPago = new System.Windows.Forms.ProgressBar();
            this.labelProcesandoPago = new System.Windows.Forms.Label();
            this.timerPago = new System.Windows.Forms.Timer(this.components);
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.groupBoxCarrito.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCarrito
            // 
            this.groupBoxCarrito.Controls.Add(this.labelPrecioTotal);
            this.groupBoxCarrito.Controls.Add(this.panelCarrito);
            this.groupBoxCarrito.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCarrito.Name = "groupBoxCarrito";
            this.groupBoxCarrito.Size = new System.Drawing.Size(624, 385);
            this.groupBoxCarrito.TabIndex = 0;
            this.groupBoxCarrito.TabStop = false;
            this.groupBoxCarrito.Text = "Carrito";
            // 
            // labelPrecioTotal
            // 
            this.labelPrecioTotal.AutoSize = true;
            this.labelPrecioTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioTotal.Location = new System.Drawing.Point(6, 356);
            this.labelPrecioTotal.Name = "labelPrecioTotal";
            this.labelPrecioTotal.Size = new System.Drawing.Size(66, 26);
            this.labelPrecioTotal.TabIndex = 0;
            this.labelPrecioTotal.Text = "Total:";
            // 
            // panelCarrito
            // 
            this.panelCarrito.AutoScroll = true;
            this.panelCarrito.Location = new System.Drawing.Point(6, 19);
            this.panelCarrito.Name = "panelCarrito";
            this.panelCarrito.Size = new System.Drawing.Size(612, 334);
            this.panelCarrito.TabIndex = 0;
            // 
            // botonPagar
            // 
            this.botonPagar.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonPagar.Location = new System.Drawing.Point(641, 267);
            this.botonPagar.Name = "botonPagar";
            this.botonPagar.Size = new System.Drawing.Size(338, 36);
            this.botonPagar.TabIndex = 7;
            this.botonPagar.Text = "Pagar";
            this.botonPagar.UseVisualStyleBackColor = true;
            this.botonPagar.Click += new System.EventHandler(this.botonPagar_Click);
            // 
            // maskedTextBoxNumeroTarjeta
            // 
            this.maskedTextBoxNumeroTarjeta.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxNumeroTarjeta.Location = new System.Drawing.Point(795, 98);
            this.maskedTextBoxNumeroTarjeta.Mask = "0000-0000-0000-0000";
            this.maskedTextBoxNumeroTarjeta.Name = "maskedTextBoxNumeroTarjeta";
            this.maskedTextBoxNumeroTarjeta.Size = new System.Drawing.Size(184, 27);
            this.maskedTextBoxNumeroTarjeta.TabIndex = 1;
            // 
            // labelDatosTarjeta
            // 
            this.labelDatosTarjeta.AutoSize = true;
            this.labelDatosTarjeta.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatosTarjeta.Location = new System.Drawing.Point(636, 61);
            this.labelDatosTarjeta.Name = "labelDatosTarjeta";
            this.labelDatosTarjeta.Size = new System.Drawing.Size(178, 26);
            this.labelDatosTarjeta.TabIndex = 0;
            this.labelDatosTarjeta.Text = "Pago con Tarjeta:";
            // 
            // labelNumeroTarjeta
            // 
            this.labelNumeroTarjeta.AutoSize = true;
            this.labelNumeroTarjeta.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroTarjeta.Location = new System.Drawing.Point(637, 101);
            this.labelNumeroTarjeta.Name = "labelNumeroTarjeta";
            this.labelNumeroTarjeta.Size = new System.Drawing.Size(143, 20);
            this.labelNumeroTarjeta.TabIndex = 4;
            this.labelNumeroTarjeta.Text = "Numero de tarjeta";
            // 
            // labelTitular
            // 
            this.labelTitular.AutoSize = true;
            this.labelTitular.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitular.Location = new System.Drawing.Point(637, 134);
            this.labelTitular.Name = "labelTitular";
            this.labelTitular.Size = new System.Drawing.Size(145, 20);
            this.labelTitular.TabIndex = 6;
            this.labelTitular.Text = "Titular de la tarjeta";
            // 
            // textBoxTitular
            // 
            this.textBoxTitular.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitular.Location = new System.Drawing.Point(795, 131);
            this.textBoxTitular.Name = "textBoxTitular";
            this.textBoxTitular.Size = new System.Drawing.Size(184, 27);
            this.textBoxTitular.TabIndex = 3;
            // 
            // labelCvv
            // 
            this.labelCvv.AutoSize = true;
            this.labelCvv.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCvv.Location = new System.Drawing.Point(637, 167);
            this.labelCvv.Name = "labelCvv";
            this.labelCvv.Size = new System.Drawing.Size(39, 20);
            this.labelCvv.TabIndex = 9;
            this.labelCvv.Text = "CVV";
            // 
            // maskedTextBoxCvv
            // 
            this.maskedTextBoxCvv.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxCvv.Location = new System.Drawing.Point(795, 164);
            this.maskedTextBoxCvv.Mask = "000";
            this.maskedTextBoxCvv.Name = "maskedTextBoxCvv";
            this.maskedTextBoxCvv.Size = new System.Drawing.Size(184, 27);
            this.maskedTextBoxCvv.TabIndex = 4;
            // 
            // dateTimePickerFechaCaducidad
            // 
            this.dateTimePickerFechaCaducidad.Checked = false;
            this.dateTimePickerFechaCaducidad.CustomFormat = "MM/yyyy";
            this.dateTimePickerFechaCaducidad.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaCaducidad.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFechaCaducidad.Location = new System.Drawing.Point(795, 197);
            this.dateTimePickerFechaCaducidad.Name = "dateTimePickerFechaCaducidad";
            this.dateTimePickerFechaCaducidad.ShowUpDown = true;
            this.dateTimePickerFechaCaducidad.Size = new System.Drawing.Size(184, 27);
            this.dateTimePickerFechaCaducidad.TabIndex = 5;
            this.dateTimePickerFechaCaducidad.ValueChanged += new System.EventHandler(this.dateTimePickerFechaCaducidad_ValueChanged);
            // 
            // labelFechaCaducidad
            // 
            this.labelFechaCaducidad.AutoSize = true;
            this.labelFechaCaducidad.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaCaducidad.Location = new System.Drawing.Point(637, 202);
            this.labelFechaCaducidad.Name = "labelFechaCaducidad";
            this.labelFechaCaducidad.Size = new System.Drawing.Size(153, 20);
            this.labelFechaCaducidad.TabIndex = 11;
            this.labelFechaCaducidad.Text = "Fecha de caducidad";
            // 
            // checkBoxGuardarTarjeta
            // 
            this.checkBoxGuardarTarjeta.AutoSize = true;
            this.checkBoxGuardarTarjeta.Checked = true;
            this.checkBoxGuardarTarjeta.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGuardarTarjeta.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxGuardarTarjeta.Location = new System.Drawing.Point(641, 237);
            this.checkBoxGuardarTarjeta.Name = "checkBoxGuardarTarjeta";
            this.checkBoxGuardarTarjeta.Size = new System.Drawing.Size(137, 24);
            this.checkBoxGuardarTarjeta.TabIndex = 6;
            this.checkBoxGuardarTarjeta.Text = "Guardar tarjeta";
            this.checkBoxGuardarTarjeta.UseVisualStyleBackColor = true;
            // 
            // progressBarPago
            // 
            this.progressBarPago.Location = new System.Drawing.Point(641, 330);
            this.progressBarPago.Minimum = 1;
            this.progressBarPago.Name = "progressBarPago";
            this.progressBarPago.Size = new System.Drawing.Size(338, 23);
            this.progressBarPago.Step = 1;
            this.progressBarPago.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarPago.TabIndex = 0;
            this.progressBarPago.Value = 1;
            this.progressBarPago.Visible = false;
            // 
            // labelProcesandoPago
            // 
            this.labelProcesandoPago.AutoSize = true;
            this.labelProcesandoPago.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProcesandoPago.Location = new System.Drawing.Point(637, 306);
            this.labelProcesandoPago.Name = "labelProcesandoPago";
            this.labelProcesandoPago.Size = new System.Drawing.Size(155, 21);
            this.labelProcesandoPago.TabIndex = 0;
            this.labelProcesandoPago.Text = "Procesando pago...";
            this.labelProcesandoPago.Visible = false;
            // 
            // timerPago
            // 
            this.timerPago.Interval = 10;
            this.timerPago.Tick += new System.EventHandler(this.timerPago_Tick);
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCorreo.Location = new System.Drawing.Point(795, 31);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(184, 27);
            this.textBoxCorreo.TabIndex = 0;
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreo.Location = new System.Drawing.Point(637, 34);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(60, 20);
            this.labelCorreo.TabIndex = 0;
            this.labelCorreo.Text = "Correo";
            // 
            // FormCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 410);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.labelCorreo);
            this.Controls.Add(this.labelProcesandoPago);
            this.Controls.Add(this.progressBarPago);
            this.Controls.Add(this.checkBoxGuardarTarjeta);
            this.Controls.Add(this.labelFechaCaducidad);
            this.Controls.Add(this.maskedTextBoxCvv);
            this.Controls.Add(this.dateTimePickerFechaCaducidad);
            this.Controls.Add(this.textBoxTitular);
            this.Controls.Add(this.maskedTextBoxNumeroTarjeta);
            this.Controls.Add(this.labelCvv);
            this.Controls.Add(this.labelTitular);
            this.Controls.Add(this.labelNumeroTarjeta);
            this.Controls.Add(this.labelDatosTarjeta);
            this.Controls.Add(this.botonPagar);
            this.Controls.Add(this.groupBoxCarrito);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormCarrito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carrito";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCarrito_FormClosing);
            this.Load += new System.EventHandler(this.FormCarrito_Load);
            this.groupBoxCarrito.ResumeLayout(false);
            this.groupBoxCarrito.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCarrito;
        private System.Windows.Forms.Panel panelCarrito;
        private System.Windows.Forms.Button botonPagar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumeroTarjeta;
        private System.Windows.Forms.Label labelDatosTarjeta;
        private System.Windows.Forms.Label labelNumeroTarjeta;
        private System.Windows.Forms.Label labelTitular;
        private System.Windows.Forms.TextBox textBoxTitular;
        private System.Windows.Forms.Label labelCvv;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCvv;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaCaducidad;
        private System.Windows.Forms.Label labelFechaCaducidad;
        private System.Windows.Forms.Label labelPrecioTotal;
        private System.Windows.Forms.CheckBox checkBoxGuardarTarjeta;
        private System.Windows.Forms.ProgressBar progressBarPago;
        private System.Windows.Forms.Label labelProcesandoPago;
        private System.Windows.Forms.Timer timerPago;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.Label labelCorreo;
    }
}