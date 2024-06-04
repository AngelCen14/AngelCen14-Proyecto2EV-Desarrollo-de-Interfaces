using System;
using System.Collections.Generic;

namespace Proyecto2EV.Clases {
    [Serializable]
    public class Usuario {
        // Atributos
        private int id;
        private string nombre;
        private string clave;
        private DateTime fechaNacimiento;
        private Dictionary<VideoJuego, int> carrito;
        private Tarjeta tarjetaGuardada;

        // Constructores
        public Usuario() { }

        public Usuario(string nombre, string clave, DateTime fechaNacimiento) {
            this.nombre = nombre;
            this.clave = clave;
            this.fechaNacimiento = fechaNacimiento;
            carrito = new Dictionary<VideoJuego, int>();
        }

        // Getters y Setters
        public string Nombre { get => nombre; set => nombre = value; }
        public string Clave { get => clave; set => clave = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public Dictionary<VideoJuego, int> Carrito { get => carrito; set => carrito = value; }
        public Tarjeta TarjetaGuardada { get => tarjetaGuardada; set => tarjetaGuardada = value; }
        public int Id { get => id; set => id = value; }

        // Funciones
        public override string ToString() {
            return Nombre;
        }
    }
}
