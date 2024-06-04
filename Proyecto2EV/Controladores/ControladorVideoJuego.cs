using Proyecto2EV.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto2EV.Controladores {
    public static class ControladorVideoJuego {

        public static void ordenarPorAtributo(ref List<VideoJuego> listaVideoJuegos, Func<VideoJuego, IComparable> atributo) {
            // Ordena la lista segun el atributo especificado
            listaVideoJuegos = listaVideoJuegos.OrderBy(atributo).ToList();
        }


        public static List<VideoJuego> getVideoJuegosBaseDatos() {
            List<VideoJuego> listaVideoJuegos = new List<VideoJuego>();
            string query = "SELECT * FROM VideoJuegos";
            using (SqlConnection connection = new SqlConnection(ControladorBaseDatos.getConnectionString())) {
                try {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection)) {
                        using (SqlDataReader reader = command.ExecuteReader()) {
                            while (reader.Read()) {

                                int id = int.Parse(reader["Id"].ToString());
                                string nombre = reader["Nombre"].ToString();
                                DateTime fechaSalida = (DateTime)reader["FechaSalida"];
                                VideoJuego.PlataformaEnum plataforma = (VideoJuego.PlataformaEnum)reader["Plataforma"];
                                float precio = float.Parse(reader["Precio"].ToString());
                                byte[] byteImage = (byte[])reader["Imagen"];

                                MemoryStream memoryStream = new MemoryStream(byteImage);
                                Image imagen = Image.FromStream(memoryStream);

                                listaVideoJuegos.Add(new VideoJuego(id, nombre, fechaSalida, plataforma, precio, imagen));
                            }
                        }
                    }
                } catch (Exception ex) {
                    Logger.logError($"Error al cargar datos: {ex.Message}");
                    MessageBox.Show("Se ha producido un error al cargar el catalogo de videojuegos desde la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return listaVideoJuegos;
        }

        public static VideoJuego getVideoJuegoBaseDatosPorId(int idVideojuego) {
            VideoJuego videoJuego = null;
            string query = "SELECT * FROM VideoJuegos WHERE Id = @Id";
            using (SqlConnection connection = new SqlConnection(ControladorBaseDatos.getConnectionString())) {
                try {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection)) {
                        command.Parameters.AddWithValue("@Id", idVideojuego);
                        using (SqlDataReader reader = command.ExecuteReader()) {
                            while (reader.Read()) {
                                int id = int.Parse(reader["Id"].ToString());
                                string nombre = reader["Nombre"].ToString();
                                DateTime fechaSalida = (DateTime)reader["FechaSalida"];
                                VideoJuego.PlataformaEnum plataforma = (VideoJuego.PlataformaEnum)reader["Plataforma"];
                                float precio = float.Parse(reader["Precio"].ToString());
                                byte[] byteImage = (byte[])reader["Imagen"];

                                MemoryStream memoryStream = new MemoryStream(byteImage);
                                Image imagen = Image.FromStream(memoryStream);

                                videoJuego = new VideoJuego(id, nombre, fechaSalida, plataforma, precio, imagen);
                            }
                        }
                    }
                } catch (Exception ex) {
                    Logger.logError($"Error al cargar datos: {ex.Message}");
                    MessageBox.Show("Se ha producido un error al cargar el videojuego con id = " + idVideojuego, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return videoJuego;
        }
    }
}
