using Proyecto2EV.Clases;
using Proyecto2EV.Controladores;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto2EV.Vistas {
    public partial class FormPublicarReseña : Form {

        private Usuario usuario;
        private List<VideoJuego> listaVideoJuegos;

        public FormPublicarReseña(ref Usuario usuario, ref List<VideoJuego> listaVideoJuegos) {
            InitializeComponent();
            this.usuario = usuario;
            this.listaVideoJuegos = listaVideoJuegos;
        }

        private void mostrarCaracteresRestantes() {
            int caracteresRestantes = richTextBoxReseña.MaxLength - richTextBoxReseña.Text.Length;
            labelCaracteresRestantes.Text = "Caracteres restantes: " + caracteresRestantes;
        }

        private void cargarElemntosComboBox() {
            ControladorVideoJuego.ordenarPorAtributo(ref listaVideoJuegos, videoJuego => videoJuego.Nombre);
            comboBoxVideoJuegos.Items.AddRange(listaVideoJuegos.ToArray());
            comboBoxVideoJuegos.SelectedIndex = 0;
        }

        private bool validarFormulario() {
            return !string.IsNullOrEmpty(richTextBoxReseña.Text);
        }

        // Eventos Componentes
        private void richTextBoxReseña_TextChanged(object sender, EventArgs e) {
            mostrarCaracteresRestantes();
        }

        private void botonPublicar_Click(object sender, EventArgs e) {
            if (validarFormulario()) {
                VideoJuego videoJuego = (VideoJuego)comboBoxVideoJuegos.SelectedItem;
                int nota = (int)numericUpDownNota.Value;
                string textoReseña = richTextBoxReseña.Text;

                Reseña reseña = new Reseña(usuario, videoJuego, nota, textoReseña);
                if (ControladorReseñas.validarReseña(reseña)) {
                    ControladorReseñas.insertarReseñaBaseDatos(reseña);
                } else {
                    MessageBox.Show("Ya has publicado una reseña de " + videoJuego.Nombre, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Logger.logWarning("El usuario " + usuario.Nombre + " ha intentado reseñar el mismo juego mas de una vez");
                }

                numericUpDownNota.Value = 0;
                richTextBoxReseña.Clear();
            } else MessageBox.Show("Rellena todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Eventos Formulario
        private void FormPublicarReseña_Load(object sender, EventArgs e) {
            cargarElemntosComboBox();
            mostrarCaracteresRestantes();
        }
    }
}
