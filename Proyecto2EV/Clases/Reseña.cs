namespace Proyecto2EV.Clases {
    public class Reseña {
        private Usuario usuario;
        private VideoJuego videoJuego;
        private int nota;
        private string opinion;

        // Constructores
        public Reseña() { }

        public Reseña(Usuario usuario, VideoJuego videoJuego, int nota, string opinion) {
            this.usuario = usuario;
            this.videoJuego = videoJuego;
            this.nota = nota;
            this.opinion = opinion;
        }

        // Getters y Setters
        public Usuario Usuario { get => usuario; set => usuario = value; }
        public VideoJuego VideoJuego { get => videoJuego; set => videoJuego = value; }
        public int Nota { get => nota; set => nota = value; }
        public string Opinion { get => opinion; set => opinion = value; }

        public override string ToString() {
            return usuario + ", " + videoJuego + ", " + nota + ", " + opinion;
        }
    }
}
