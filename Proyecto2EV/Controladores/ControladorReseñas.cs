using Proyecto2EV.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Proyecto2EV.Controladores {
    public static class ControladorReseñas {

        public static bool validarReseña(Reseña reseña) {
            // Si no existe la reseña devuelve true
            return getReseñasBaseDatosPorId(reseña.Usuario.Id, reseña.VideoJuego.Id) == null;
        }

        // Base de datos
        public static void insertarReseñaBaseDatos(Reseña reseña) {
            string connectionString = ControladorBaseDatos.getConnectionString();

            string query = "INSERT INTO Reseñas " +
                "(IdUsuario, IdVideojuego, Nota, Opinion) " +
                "VALUES(@IdUsuario, @IdVideojuego, @Nota, @Opinion)";

            // Crear la conexión
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                // Abrir la conexión
                connection.Open();

                // Crear un objeto SqlCommand con la consulta y la conexión
                using (SqlCommand command = new SqlCommand(query, connection)) {
                    // Agregar parámetros y sus valores
                    command.Parameters.AddWithValue("@IdUsuario", reseña.Usuario.Id);
                    command.Parameters.AddWithValue("@IdVideojuego", reseña.VideoJuego.Id);
                    command.Parameters.AddWithValue("@Nota", reseña.Nota);
                    command.Parameters.AddWithValue("@Opinion", reseña.Opinion);

                    try {
                        // Ejecutar la query inserción
                        int registrosAfectados = command.ExecuteNonQuery();
                        Logger.logInfo("Se añadido la reseña del usuario " + reseña.Usuario.Nombre + " sobre el videojuego " + reseña.VideoJuego.Nombre);
                        Logger.logInfo($"Se insertó correctamente el registro. Registros afectados: {registrosAfectados}");
                        MessageBox.Show("Reseña publicada correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } catch (Exception ex) {
                        Logger.logError("Error al añadir la reseña del usuario " + reseña.Usuario + " sobre el videojuego " + reseña.VideoJuego.Nombre);
                        Logger.logError($"Error al insertar el registro: {ex.Message}");
                        MessageBox.Show("Se ha producido un error al publicar la reseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public static List<Reseña> getReseñasBaseDatos() {
            List<Reseña> listaReseñas = new List<Reseña>();
            string query = "SELECT * FROM Reseñas";
            using (SqlConnection connection = new SqlConnection(ControladorBaseDatos.getConnectionString())) {
                try {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection)) {
                        using (SqlDataReader reader = command.ExecuteReader()) {
                            while (reader.Read()) {
                                int idUsuario = int.Parse(reader["IdUsuario"].ToString());
                                int idVideojuego = int.Parse(reader["IdVideojuego"].ToString());
                                int nota = int.Parse(reader["Nota"].ToString());
                                string opinion = reader["Opinion"].ToString();

                                Usuario usuario = ControladorUsuario.getUsuarioBaseDatosPorId(idUsuario);
                                VideoJuego videoJuego = ControladorVideoJuego.getVideoJuegoBaseDatosPorId(idVideojuego);

                                listaReseñas.Add(new Reseña(usuario, videoJuego, nota, opinion));
                            }
                        }
                    }
                } catch (Exception ex) {
                    Logger.logError($"Error al cargar datos: {ex.Message}");
                    MessageBox.Show("Se ha producido un error al cargar las reseñas desde la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return listaReseñas;
        }

        public static Reseña getReseñasBaseDatosPorId(int idUsuario, int idVideojuego) {
            Reseña reseña = null;
            string query = "SELECT * FROM Reseñas WHERE IdUsuario = @IdUsuario AND IdVideojuego = @IdVideojuego";
            using (SqlConnection connection = new SqlConnection(ControladorBaseDatos.getConnectionString())) {
                try {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection)) {
                        command.Parameters.AddWithValue("@IdUsuario", idUsuario);
                        command.Parameters.AddWithValue("@IdVideojuego", idVideojuego);
                        using (SqlDataReader reader = command.ExecuteReader()) {
                            while (reader.Read()) {
                                int nota = int.Parse(reader["Nota"].ToString());
                                string opinion = reader["Opinion"].ToString();

                                Usuario usuario = ControladorUsuario.getUsuarioBaseDatosPorId(idUsuario);
                                VideoJuego videoJuego = ControladorVideoJuego.getVideoJuegoBaseDatosPorId(idVideojuego);

                                reseña = new Reseña(usuario, videoJuego, nota, opinion);
                            }
                        }
                    }
                } catch (Exception ex) {
                    Logger.logError($"Error al cargar datos: {ex.Message}");
                    MessageBox.Show("Se ha producido un error al cargar la reseña con IdUsuario = " + idUsuario + " e IdVideojuego = " + idVideojuego, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return reseña;
        }
    }
}
