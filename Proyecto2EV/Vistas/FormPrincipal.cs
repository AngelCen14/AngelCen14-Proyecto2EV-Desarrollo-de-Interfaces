using Proyecto2EV.Clases;
using Proyecto2EV.Controladores;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace Proyecto2EV.Vistas {
    public partial class FormPrincipal : Form {

        private Usuario usuario;
        private List<VideoJuego> listaVideoJuegos;

        public FormPrincipal(Usuario usuario) {
            InitializeComponent();
            this.usuario = usuario;
            this.Text += " - " + this.usuario.Nombre;
        }

        private void cargarToolTips() {
            // Steam
            toolTip.SetToolTip(pictureBoxSteam, "Steam");
            toolTip.SetToolTip(linkLabelSteam, Constantes.LINK_STEAM);
            // Switch
            toolTip.SetToolTip(pictureBoxSwitch, "Nintendo Switch");
            toolTip.SetToolTip(linkLabelSwitch, Constantes.LINK_NINTENDO);
            // Xbox
            toolTip.SetToolTip(pictureBoxXbox, "Xbox");
            toolTip.SetToolTip(linkLabelXbox, Constantes.LINK_XBOX);
            // Ps5
            toolTip.SetToolTip(pictureBoxPs5, "PlayStation");
            toolTip.SetToolTip(linkLabelPs5, Constantes.LINK_PLAY_STATION);
        }

        // Eventos Componentes
        // Menu Catalogo
        private void catalogoToolStripMenuItem_Click(object sender, EventArgs e) {
            FormCatalogo formCatalogo = new FormCatalogo(ref listaVideoJuegos, ref usuario);
            formCatalogo.ShowDialog();
        }

        // Menu Reseñas
        private void publicarToolStripMenuItem_Click(object sender, EventArgs e) {
            FormPublicarReseña formPublicarReseña = new FormPublicarReseña(ref usuario, ref listaVideoJuegos);
            formPublicarReseña.ShowDialog();
        }
        private void verReseñasToolStripMenuItem_Click(object sender, EventArgs e) {
            FormReseñas formReseñas = new FormReseñas();
            formReseñas.ShowDialog();
        }

        // Menu Carrito
        private void carritoToolStripMenuItem_Click(object sender, EventArgs e) {
            FormCarrito formCarrito = new FormCarrito(ref usuario);
            formCarrito.ShowDialog();
        }

        // Menu Logs
        private void verLogsToolStripMenuItem_Click(object sender, EventArgs e) {
            FormLogs formLogs = new FormLogs();
            formLogs.ShowDialog();
        }

        // Links
        private void linkLabelSteam_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start(Constantes.LINK_STEAM);
        }

        private void linkLabelSwitch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start(Constantes.LINK_NINTENDO);
        }

        private void linkLabelXbox_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start(Constantes.LINK_XBOX);
        }

        private void linkLabelPs5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start(Constantes.LINK_PLAY_STATION);
        }

        // Eventos Formulario
        private void FormPrincipal_Load(object sender, EventArgs e) {
            cargarToolTips();
            /*
             * Como la lista de videojuegos no se puede modificar desde el programa
             * se carga una vez al iniciar el programa y asi no hay que 
             * hacer una consulta cada vez que se abre FormCatalogo
             */
            listaVideoJuegos = ControladorVideoJuego.getVideoJuegosBaseDatos();
            usuario.Carrito = ControladorUsuario.getCarritoUsuarioBaseDatos(usuario.Id);
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e) {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que quieres cerrar el programa?", "Cerrar Programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes) e.Cancel = false;
            else e.Cancel = true;
        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

    }
}
