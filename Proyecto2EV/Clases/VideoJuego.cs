using System;
using System.Drawing;

namespace Proyecto2EV.Clases {
    [Serializable]
    public class VideoJuego {
        // Atributos
        private int id;
        private string nombre;
        private DateTime fechaSalida;
        private PlataformaEnum plataforma;
        private float precio;
        private Image imagen;

        public enum PlataformaEnum {
            Pc = 0,
            Nintendo_Switch = 1,
            Xbox_Series_X = 2,
            Play_Station_5 = 3
        }

        // Constructores
        public VideoJuego() { }

        public VideoJuego(int id, string nombre, DateTime fechaSalida, PlataformaEnum plataforma, float precio, Image imagen) {
            this.id = id;
            this.nombre = nombre;
            this.fechaSalida = fechaSalida;
            this.plataforma = plataforma;
            this.precio = precio;
            this.imagen = imagen;
        }

        // Getters y Setters
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaSalida { get => fechaSalida; set => fechaSalida = value; }
        public PlataformaEnum Plataforma { get => plataforma; set => plataforma = value; }
        public float Precio { get => precio; set => precio = value; }
        public Image Imagen { get => imagen; set => imagen = value; }

        public override string ToString() {
            return nombre;
        }

        /* 
         * Equals y HasCode son necesarios para poder comparar
         * objetos que hayan sido cargados desde algun fichero
         * o desde la base de datos ya que sino al agregarlos
         * al carrito se piensa que son juegos distintos 
         */
        public override bool Equals(object obj) {
            if (obj == null || GetType() != obj.GetType()) return false;

            VideoJuego v = (VideoJuego)obj;
            return (Nombre == v.Nombre);
        }

        public override int GetHashCode() {
            return Nombre.GetHashCode();
        }
    }
}
