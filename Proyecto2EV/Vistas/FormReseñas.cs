using Proyecto2EV.Controladores;
using System.Windows.Forms;

namespace Proyecto2EV.Vistas {
    public partial class FormReseñas : Form {
        public FormReseñas() {
            InitializeComponent();
            dataGridViewReseñas.DataSource = ControladorReseñas.getReseñasBaseDatos();
        }
    }
}
