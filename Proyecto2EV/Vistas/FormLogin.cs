using Proyecto2EV.Clases;
using Proyecto2EV.Controladores;
using Proyecto2EV.Vistas;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TextBox = System.Windows.Forms.TextBox;

namespace Proyecto2EV {
    public partial class FormLogin : Form {
        public FormLogin() {
            InitializeComponent();
        }

        private List<Usuario> listaUsuarios = new List<Usuario>();
        private int intentosLogin = 0;

        private void cargarUsuarios() {
            listaUsuarios = ControladorUsuario.getUsuariosBaseDatos();
        }

        private bool validarFechaNacimiento(DateTime fechaNacimiento) {
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - fechaNacimiento.Year;

            // Verificar mes y dia de nacimiento
            if (fechaActual.Month < fechaNacimiento.Month ||
                (fechaActual.Month == fechaNacimiento.Month &&
                fechaActual.Day < fechaNacimiento.Day)) {
                // Si todavia no ha cumplido años se le resta 1
                edad--;
            }

            return edad >= 18;
        }

        private void registrarUsuario(Usuario usuario) {
            int index = listaUsuarios.FindIndex(user => user.Nombre == usuario.Nombre.ToLower());
            if (index == -1) {
                // Si el usuario no existe se registra
                if (validarFechaNacimiento(usuario.FechaNacimiento)) {
                    // Mayor de edad
                    ControladorUsuario.insertarUsuarioBaseDatos(usuario);

                    textBoxUsuarioRegistro.Clear();
                    textBoxClaveRegistro.Clear();
                    dateTimePickerFechaNacimiento.Value = DateTime.Now;
                } else {
                    // Menor de edad
                    MessageBox.Show("Debes tener 18 años o mas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else if ((string.IsNullOrEmpty(textBoxUsuarioRegistro.Text) || string.IsNullOrEmpty(textBoxClaveRegistro.Text))) {
                // Alguno de los campos esta vacio
                MessageBox.Show("Rellena todos los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                // El usuario ya existe
                MessageBox.Show("Ya existe el usuario " + usuario.Nombre);
                textBoxUsuarioRegistro.Clear();
                textBoxClaveRegistro.Clear();
                dateTimePickerFechaNacimiento.Value = DateTime.Now;
            }
        }

        private bool validarLogin(string nombre, string clave) {
            bool valido = false;
            int index = listaUsuarios.FindIndex(user => user.Nombre == nombre.ToLower());
            if (index != -1) {
                if (listaUsuarios[index].Clave == clave) {
                    // El nombre y la contraseña son validos
                    valido = true;
                } else {
                    // El nombre es valido pero la contraseña no
                    textBoxClaveLogin.Clear();
                    MessageBox.Show("Contraseña incorrecta");
                }
            } else {
                // El nombre no es valido
                textBoxUsuarioLogin.Clear();
                textBoxClaveLogin.Clear();
                MessageBox.Show("No existe el usuario " + nombre, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return valido;
        }

        private void login(string nombre, string clave) {
            cargarUsuarios(); // Volver a recoger los usuarios de la base de datos por si se registra uno nuevo
            if (listaUsuarios.Count == 0) {
                // No hay ningun usuario en la base de datos
                textBoxUsuarioLogin.Clear();
                textBoxClaveLogin.Clear();
                MessageBox.Show("No existen usuarios registrados");
            } else if ((string.IsNullOrEmpty(textBoxUsuarioLogin.Text) || string.IsNullOrEmpty(textBoxClaveLogin.Text))) {
                // Alguno de los campos esta vacio
                MessageBox.Show("Rellena todos los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                if (validarLogin(nombre, clave)) {
                    // Login correcto
                    int indiceUsario = listaUsuarios.FindIndex(usuario => usuario.Nombre == nombre);
                    FormPrincipal formPrincipal = new FormPrincipal(listaUsuarios[indiceUsario]);
                    formPrincipal.Show();
                    this.Close();
                    Logger.logInfo("El usuario " + listaUsuarios[indiceUsario].Nombre + " ha iniciado sesion");
                } else {
                    // Login incorrecto
                    intentosLogin++;
                    if (intentosLogin == Constantes.MAX_INTENTOS_LOGIN) {
                        // Intentos maximos de login superados
                        MessageBox.Show("Has superado el maximo de intentos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Logger.logWarning("Aplicacion cerrada por superar el numero maximo de intentos de inicio de sesion");
                        Application.Exit();
                    }
                }
            }
        }

        private void bloquearCopiadoDeTexto(KeyEventArgs e, TextBox textBox) {
            if (e.Control == true) {
                switch (e.KeyCode) {
                    case Keys.C:
                    case Keys.P:
                    case Keys.X:
                        e.Handled = true;
                        textBox.SelectionLength = 0;
                        break;
                }
            }
        }

        // Eventos Componentes
        private void botonRegister_Click(object sender, EventArgs e) {
            string nombre = textBoxUsuarioRegistro.Text;
            string clave = textBoxClaveRegistro.Text;
            DateTime fechaNacimiento = dateTimePickerFechaNacimiento.Value.Date;

            registrarUsuario(new Usuario(nombre, clave, fechaNacimiento));
        }

        private void botonLogin_Click(object sender, EventArgs e) {
            string nombre = textBoxUsuarioLogin.Text;
            string clave = textBoxClaveLogin.Text;

            login(nombre, clave);
        }

        private void textBoxClaveLogin_KeyDown(object sender, KeyEventArgs e) {
            bloquearCopiadoDeTexto(e, sender as TextBox);
        }

        private void textBoxClaveRegistro_KeyDown(object sender, KeyEventArgs e) {
            bloquearCopiadoDeTexto(e, sender as TextBox);
        }

        private void textBoxClaveLogin_Enter(object sender, EventArgs e) {
            Clipboard.Clear();
        }

        private void textBoxClaveRegistro_Enter(object sender, EventArgs e) {
            Clipboard.Clear();
        }

        // Eventos Formularios
        private void FormLogin_Load(object sender, EventArgs e) {
            cargarUsuarios();
        }

        private void botonCerrar_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
