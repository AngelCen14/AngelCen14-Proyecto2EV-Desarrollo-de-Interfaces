using System;

namespace Proyecto2EV.Clases {
    [Serializable]
    public class Tarjeta {
        // Atributos
        private int id;
        private long numero;
        private int cvv;
        private String titular;
        private DateTime fechaCaducidad;

        // Constructores
        public Tarjeta() { }
        public Tarjeta(long numero, int cvv, string titular, DateTime fechaCaducidad) {
            this.numero = numero;
            this.cvv = cvv;
            this.titular = titular;
            this.fechaCaducidad = fechaCaducidad;
        }

        // Getters y Setters
        public int Id { get => id; set => id = value; }
        public long Numero { get => numero; set => numero = value; }
        public int Cvv { get => cvv; set => cvv = value; }
        public string Titular { get => titular; set => titular = value; }
        public DateTime FechaCaducidad { get => fechaCaducidad; set => fechaCaducidad = value; }
    }
}
