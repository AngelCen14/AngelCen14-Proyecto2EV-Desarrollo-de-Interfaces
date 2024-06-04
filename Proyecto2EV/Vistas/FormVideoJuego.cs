using Proyecto2EV.Clases;
using Proyecto2EV.Controladores;
using System;
using System.Windows.Forms;

namespace Proyecto2EV.Vistas {
    public partial class FormVideoJuego : Form {

        private Usuario usuario;
        private VideoJuego videoJuego;

        public FormVideoJuego(ref Usuario usuario, VideoJuego videoJuego) {
            InitializeComponent();

            this.usuario = usuario;
            this.videoJuego = videoJuego;

            pictureBoxVideoJuego.Image = videoJuego.Imagen;
            labelNombre.Text = videoJuego.Nombre;
            labelFechaSalida.Text = videoJuego.FechaSalida.ToString("dd/MM/yyyy");
            labelPlataforma.Text = videoJuego.Plataforma.ToString();
            labelPrecio.Text = videoJuego.Precio + "€";

            this.Text = videoJuego.Nombre;
        }

        private void botonAñadirAlCarrito_Click(object sender, EventArgs e) {
            ControladorUsuario.añadirAlCarrito(ref usuario, ref videoJuego);
            MessageBox.Show("Carrito actualizado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
