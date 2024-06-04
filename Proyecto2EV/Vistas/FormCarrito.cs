using Proyecto2EV.Clases;
using Proyecto2EV.Controladores;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Proyecto2EV.Vistas {
    public partial class FormCarrito : Form {

        private Usuario usuario;

        // Variables para colocar los labels
        private int posicionInicial;
        private int contadorNombre;

        public FormCarrito(ref Usuario usuario) {
            InitializeComponent();

            this.usuario = usuario;
        }

        private void crearElementoCarrito(VideoJuego videoJuego, Dictionary<VideoJuego, int> carrito) {
            // Nombre del juego y precio
            Label labelJuego = new Label();
            labelJuego.AutoSize = true;
            labelJuego.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            labelJuego.Location = new Point(1, posicionInicial);
            labelJuego.Name = "labelVideoJuego" + contadorNombre;
            labelJuego.Size = new Size(291, 20);
            labelJuego.TabIndex = 0;
            labelJuego.Text = videoJuego.Nombre + ": " + videoJuego.Precio;

            // Cantidad de veces que se va a comprar
            NumericUpDown numericUpDown = new NumericUpDown();
            numericUpDown.AutoSize = true;
            numericUpDown.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            numericUpDown.Location = new Point(380, posicionInicial);
            numericUpDown.Name = "numericUpDown" + contadorNombre;
            numericUpDown.TabIndex = 1;
            numericUpDown.Minimum = 1;
            numericUpDown.Maximum = 99;
            numericUpDown.Value = carrito[videoJuego];
            numericUpDown.TabIndex = 0;
            numericUpDown.TabStop = false;
            numericUpDown.Tag = videoJuego;
            numericUpDown.ValueChanged += numericUpDown_ValueChanged;

            // Boton para eliminar un elemento del carrito
            Button botonEliminar = new Button();
            botonEliminar.AutoSize = true;
            numericUpDown.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            botonEliminar.Location = new Point(510, posicionInicial);
            botonEliminar.Name = "botonEliminar" + contadorNombre;
            botonEliminar.TabIndex = 1;
            botonEliminar.Text = "Quitar";
            botonEliminar.TabIndex = 0;
            botonEliminar.TabStop = false;
            botonEliminar.Tag = videoJuego;
            botonEliminar.Click += botonEliminar_Click;

            panelCarrito.Controls.Add(labelJuego);
            panelCarrito.Controls.Add(numericUpDown);
            panelCarrito.Controls.Add(botonEliminar);

            this.posicionInicial += 30;
            this.contadorNombre++;
        }

        private void mostrarCarrito() {

            panelCarrito.Controls.Clear();
            this.contadorNombre = 1;
            this.posicionInicial = 1;

            // Obtener el carrito desde la base de datos cada vez que se actualiza la intrefaz
            usuario.Carrito = ControladorUsuario.getCarritoUsuarioBaseDatos(usuario.Id);

            foreach (KeyValuePair<VideoJuego, int> item in usuario.Carrito) {
                crearElementoCarrito(item.Key, usuario.Carrito);
            }

            actualizarPrecioTotal();
        }

        private void cargarTarjetaGuardada() {
            // Cargar datos de la tarjeta en los campos del formulario
            maskedTextBoxNumeroTarjeta.Text = usuario.TarjetaGuardada.Numero.ToString();
            textBoxTitular.Text = usuario.TarjetaGuardada.Titular;
            maskedTextBoxCvv.Text = usuario.TarjetaGuardada.Cvv.ToString();
            dateTimePickerFechaCaducidad.Value = usuario.TarjetaGuardada.FechaCaducidad;
        }

        private bool validarCorreo(string correo) {
            Regex regexCorreo = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            return regexCorreo.IsMatch(correo);
        }

        private void realizarPago() {
            try {
                string numeroTarjetaString = maskedTextBoxNumeroTarjeta.Text.Replace("-", "");
                long numeroTarjeta = long.Parse(numeroTarjetaString);

                string titularTarjeta = textBoxTitular.Text;
                int cvv = int.Parse(maskedTextBoxCvv.Text);
                DateTime fechaCaducidad = dateTimePickerFechaCaducidad.Value.Date;

                Tarjeta tarjeta = new Tarjeta(numeroTarjeta, cvv, titularTarjeta, fechaCaducidad);

                if (checkBoxGuardarTarjeta.Checked) {
                    if (usuario.TarjetaGuardada == null) {
                        // Si no hay ninguna tarjeta guardada se añade a la base de datos
                        ControladorTarjeta.insertarTarjetaBaseDatos(tarjeta, usuario.Id);
                    } else {
                        // Si ya hay una tarjeta guardada se actualizan los datos
                        ControladorTarjeta.actualizarTarjetaBaseDatos(tarjeta, usuario.Id);
                    }
                } else {
                    usuario.TarjetaGuardada = null;
                    ControladorTarjeta.eliminarTarjetaPorIdUsuarioBaseDatos(usuario.Id);
                }
                

                ControladorUsuario.vaciarCarrito(ref usuario);
                mostrarCarrito();

                MessageBox.Show("Compra realizada con exito, recibiras las claves de activacion de tus producos al correo: " + textBoxCorreo.Text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Logger.logInfo("El usuario " + usuario.Nombre + " ha realizado un pago");
                vaciarControles();
            } catch (FormatException exception) {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.logError("El usuario " + usuario.Nombre + " ha sufrido un error al realizar un pago");
            }
        }

        private bool validarFormulario() {
            if (!validarCorreo(textBoxCorreo.Text)) {
                MessageBox.Show("Correo invlálido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (usuario.Carrito.Count == 0) {
                MessageBox.Show("No hay ningun producto en el carrito", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if ((!maskedTextBoxNumeroTarjeta.MaskCompleted || !maskedTextBoxCvv.MaskCompleted) || string.IsNullOrEmpty(textBoxTitular.Text)) {
                MessageBox.Show("Rellena todos los campos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void actualizarPrecioTotal() {
            labelPrecioTotal.Text = "Total: " + ControladorUsuario.getPrecioTotalCarrito(ref usuario) + " €";
        }

        private void vaciarControles() {
            textBoxCorreo.Clear();

            if (!checkBoxGuardarTarjeta.Checked) {
                maskedTextBoxNumeroTarjeta.Clear();
                textBoxTitular.Clear();
                maskedTextBoxCvv.Clear();
                dateTimePickerFechaCaducidad.Value = DateTime.Now;
            }
        }

        // Eventos Componentes
        private void numericUpDown_ValueChanged(object sender, EventArgs e) {
            // Sincronizar el carrito con el valor del NumericUpDown
            NumericUpDown numericUpDown = sender as NumericUpDown;
            VideoJuego videoJuego = (VideoJuego)numericUpDown.Tag;
            ControladorUsuario.setValorCarrito(ref usuario, ref videoJuego, (int)numericUpDown.Value);
            actualizarPrecioTotal();
        }

        private void botonEliminar_Click(object sender, EventArgs e) {
            // Eliminar el juego del carrito y recargar la pantalla
            VideoJuego videoJuego = (VideoJuego)((Button)sender).Tag;
            ControladorUsuario.eliminarJuegoCarritoBaseDatos(usuario, videoJuego);
            usuario.Carrito.Remove(videoJuego);
            mostrarCarrito();
            Logger.logInfo("El usuario " + usuario.Nombre + " ha eliminado " + videoJuego.Nombre + " de su carrito");
        }

        private void botonPagar_Click(object sender, EventArgs e) {
            // Simular que el pago se tiene que procesar usando progressbar y timer
            if (validarFormulario()) {
                progressBarPago.Value = 1;
                timerPago.Start();
                labelProcesandoPago.Visible = true;
                progressBarPago.Visible = true;
            }
        }

        private void timerPago_Tick(object sender, EventArgs e) {
            // Aumentar el step de la progressbar en cada tick del timer
            progressBarPago.PerformStep();

            // Si ha llegado al maximo parar el timer y realizar el pago
            if (progressBarPago.Value == progressBarPago.Maximum) {
                timerPago.Stop();
                realizarPago();
                labelProcesandoPago.Visible = false;
                progressBarPago.Visible = false;
            }
        }

        private void dateTimePickerFechaCaducidad_ValueChanged(object sender, EventArgs e) {
            /* 
             * Esto es por que como la fecha de caducidad es solo mes y año
             * si el dia actual es mayor que 28 al bajar hasta febrero revienta
             */
            if (dateTimePickerFechaCaducidad.Value.Day != 1) {
                dateTimePickerFechaCaducidad.Value = new DateTime(dateTimePickerFechaCaducidad.Value.Year, dateTimePickerFechaCaducidad.Value.Month, 1);
            }
        }

        // Eventos formulario
        private void FormCarrito_Load(object sender, EventArgs e) {
            /* 
             * Esto es por que como la fecha de caducidad es solo mes y año
             * si el dia actual es mayor que 28 al bajar hasta febrero revienta
             */
            dateTimePickerFechaCaducidad.Value = new DateTime(dateTimePickerFechaCaducidad.Value.Year, dateTimePickerFechaCaducidad.Value.Month, 1);
            mostrarCarrito();

            // Si el usuario tiene alguna tarjeta guardada se carga
            usuario.TarjetaGuardada = ControladorTarjeta.getTarjetaBaseDatosPorIdUsuario(usuario.Id);
            if (usuario.TarjetaGuardada != null) {
                cargarTarjetaGuardada();
            }
        }

        private void FormCarrito_FormClosing(object sender, FormClosingEventArgs e) {
            // Aunque el usuario no haya pagado nada si no ha seleccionado guardar se borra la tarjeta 
            if (!checkBoxGuardarTarjeta.Checked) {
                usuario.TarjetaGuardada = null;
                ControladorTarjeta.eliminarTarjetaPorIdUsuarioBaseDatos(usuario.Id);
            }
        }
    }
}
