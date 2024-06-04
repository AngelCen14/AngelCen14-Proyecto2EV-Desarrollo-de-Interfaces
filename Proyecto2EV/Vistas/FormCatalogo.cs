using Proyecto2EV.Clases;
using Proyecto2EV.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto2EV.Vistas {
    public partial class FormCatalogo : Form {

        private List<VideoJuego> listaVideojuegos;
        private Usuario usuario;

        public FormCatalogo(ref List<VideoJuego> listaVideojuegos, ref Usuario usuario) {
            InitializeComponent();
            this.listaVideojuegos = listaVideojuegos;
            this.usuario = usuario;
        }

        private enum TiposOrdenacion {
            Nombre = 0,
            Fecha = 1,
            Precio = 2
        }

        // Variables para colocar los checkBoxes
        private int posicionInicial;
        private int contadorNombre;

        private void cargarElementosComboBoxTiposOrdenacion() {
            // Añadir los tipos de ordenacion al comboBox
            foreach (TiposOrdenacion tipoOrdenacion in Enum.GetValues(typeof(TiposOrdenacion))) {
                comboBoxTiposOrdenacion.Items.Add(tipoOrdenacion);
            }

            comboBoxTiposOrdenacion.SelectedIndex = (int)TiposOrdenacion.Fecha;
        }

        private void cargarElementosComboBoxPlataforma() {
            // Añadir las distintas plataformas al comboBox
            comboBoxPlataforma.Items.Add("Todas");
            foreach (VideoJuego.PlataformaEnum plataforma in Enum.GetValues(typeof(VideoJuego.PlataformaEnum))) {
                comboBoxPlataforma.Items.Add(plataforma);
            }

            comboBoxPlataforma.SelectedIndex = 0;
        }

        private void crearChekBox(VideoJuego videoJuego) {
            // Crear el CheckBox
            CheckBox checkBoxVideoJuego = new CheckBox();
            checkBoxVideoJuego.AutoSize = true;
            // Se le suma 4 para que se cuadre bien con el linkLabel
            checkBoxVideoJuego.Location = new Point(10, posicionInicial + 4);
            checkBoxVideoJuego.Name = "checkBoxVideoJuego" + contadorNombre;
            checkBoxVideoJuego.TabIndex = 0;
            checkBoxVideoJuego.TabStop = false;
            checkBoxVideoJuego.Tag = videoJuego;

            // Crear el LinkLabel
            LinkLabel linkLabelVideoJuego = new LinkLabel();
            linkLabelVideoJuego.AutoSize = true;
            linkLabelVideoJuego.Text = videoJuego.Nombre;
            linkLabelVideoJuego.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            linkLabelVideoJuego.Tag = videoJuego;
            linkLabelVideoJuego.Location = new Point(25, posicionInicial);
            linkLabelVideoJuego.TabIndex = 0;
            linkLabelVideoJuego.TabStop = false;

            // Configurar colores del LinkLabel
            linkLabelVideoJuego.LinkColor = Color.Blue;
            linkLabelVideoJuego.ActiveLinkColor = Color.Red;
            linkLabelVideoJuego.VisitedLinkColor = Color.Purple;
            linkLabelVideoJuego.DisabledLinkColor = Color.Gray;

            // Manejar el evento LinkClicked del LinkLabel
            linkLabelVideoJuego.LinkClicked += LinkLabelVideojuego_LinkClicked;

            // Agregar el CheckBox y el LinkLabel al panelCatalogo
            panelCatalogo.Controls.Add(checkBoxVideoJuego);
            panelCatalogo.Controls.Add(linkLabelVideoJuego);

            this.posicionInicial += 20;
            this.contadorNombre++;
        }

        // Muestra todos los juegos
        private void mostrarJuegos(List<VideoJuego> videoJuegos) {
            panelCatalogo.Controls.Clear();
            this.contadorNombre = 1;
            this.posicionInicial = 1;
            videoJuegos.ForEach(videoJuego => crearChekBox(videoJuego));
        }

        // Muestra los juegos de la plataforma especificada (NO borra los que no se muestran)
        private void mostrarJuegos(List<VideoJuego> videoJuegos, VideoJuego.PlataformaEnum plataforma) {
            panelCatalogo.Controls.Clear();
            this.contadorNombre = 1;
            this.posicionInicial = 1;
            videoJuegos.Where(videoJuego => videoJuego.Plataforma == plataforma).ToList().ForEach(videoJuego => crearChekBox(videoJuego));
        }

        private List<VideoJuego> getVideoJuegosSeleccionados() {
            List<VideoJuego> videoJuegosSeleccionados = new List<VideoJuego>();

            foreach (Control control in panelCatalogo.Controls) {
                /*
                 * Como el panel contiene ChekcBoxes y LinkLabels
                 * antes de comprobar si el chekbox esta marcado 
                 * tambien hay que comprobar que el control sea un ChekcBox
                 */
                if (control is CheckBox checkBox && checkBox.Checked) {
                    videoJuegosSeleccionados.Add((VideoJuego)checkBox.Tag);
                }
            }

            return videoJuegosSeleccionados;
        }

        private void filtrarPorPlataforma() {
            // Mostrar los videojuegos segun la plataforma seleccionada
            switch (comboBoxPlataforma.SelectedItem) {
                case "Todas":
                    mostrarJuegos(listaVideojuegos);
                    break;
                case VideoJuego.PlataformaEnum.Pc:
                    mostrarJuegos(listaVideojuegos, VideoJuego.PlataformaEnum.Pc);
                    break;
                case VideoJuego.PlataformaEnum.Nintendo_Switch:
                    mostrarJuegos(listaVideojuegos, VideoJuego.PlataformaEnum.Nintendo_Switch);
                    break;
                case VideoJuego.PlataformaEnum.Xbox_Series_X:
                    mostrarJuegos(listaVideojuegos, VideoJuego.PlataformaEnum.Xbox_Series_X);
                    break;
                case VideoJuego.PlataformaEnum.Play_Station_5:
                    mostrarJuegos(listaVideojuegos, VideoJuego.PlataformaEnum.Play_Station_5);
                    break;
                default:
                    MessageBox.Show("Este error no deberia ocurrir nunca", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void ordenarPorAtributo() {
            // Ordenar los videojuegos segun el atributo seleccionado
            switch (comboBoxTiposOrdenacion.SelectedItem) {
                case TiposOrdenacion.Nombre:
                    ControladorVideoJuego.ordenarPorAtributo(ref listaVideojuegos, videoJuego => videoJuego.Nombre);
                    break;
                case TiposOrdenacion.Fecha:
                    ControladorVideoJuego.ordenarPorAtributo(ref listaVideojuegos, videoJuego => videoJuego.FechaSalida);
                    break;
                case TiposOrdenacion.Precio:
                    ControladorVideoJuego.ordenarPorAtributo(ref listaVideojuegos, videoJuego => videoJuego.Precio);
                    break;
                default:
                    MessageBox.Show("Este error no deberia ocurrir nunca", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            /* 
             * Filtrar por plataforma por si el usuario ha cambiado la 
             * plataforma por defecto del ComboBox, y tambien lo muestra
             */
            filtrarPorPlataforma();
        }


        // Eventos Componentes
        private void comboBoxPlataforma_SelectedIndexChanged(object sender, EventArgs e) {
            filtrarPorPlataforma();
        }

        private void comboBoxTiposOrdenacion_SelectedIndexChanged(object sender, EventArgs e) {
            ordenarPorAtributo();
        }

        private void LinkLabelVideojuego_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            FormVideoJuego formVideoJuego = new FormVideoJuego(ref usuario, (VideoJuego)((LinkLabel)sender).Tag);
            formVideoJuego.ShowDialog();
        }

        private void botonAñadirCarrito_Click(object sender, EventArgs e) {
            List<VideoJuego> juegos = getVideoJuegosSeleccionados();

            // Añadir juegos seleccionados al carrito
            if (juegos.Count > 0) {
                juegos.ForEach(juego => ControladorUsuario.añadirAlCarrito(ref usuario, ref juego));
                MessageBox.Show("Carrito actualizado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else MessageBox.Show("Selecciona algun juego para añadirlo al carrito", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            // Desmarcar todos los checkboxes
            foreach (Control control in panelCatalogo.Controls) {
                if (control is CheckBox checkBox && checkBox.Checked) {
                    checkBox.Checked = false;
                }
            }
        }

        // Eventos Formulario
        private void FormCatalogo_Load(object sender, EventArgs e) {
            cargarElementosComboBoxPlataforma();
            cargarElementosComboBoxTiposOrdenacion();
            ordenarPorAtributo();
        }
    }
}
