using Proyecto2EV.Clases;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto2EV.Controladores {
    public static class ControladorTarjeta {
        public static void insertarTarjetaBaseDatos(Tarjeta tarjeta, int idUsuario) {
            string connectionString = ControladorBaseDatos.getConnectionString();

            string query = "INSERT INTO Tarjetas " +
                "(Numero, Cvv, Titular, FechaCaducidad, IdUsuario) " +
                "VALUES(@Numero, @Cvv, @Titular, @FechaCaducidad, @IdUsuario)";

            // Crear la conexión
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                // Abrir la conexión
                connection.Open();

                // Crear un objeto SqlCommand con la consulta y la conexión
                using (SqlCommand command = new SqlCommand(query, connection)) {
                    // Agregar parámetros y sus valores
                    command.Parameters.AddWithValue("@Numero", tarjeta.Numero);
                    command.Parameters.AddWithValue("@Cvv", tarjeta.Cvv);
                    command.Parameters.AddWithValue("@Titular", tarjeta.Titular);
                    command.Parameters.AddWithValue("@FechaCaducidad", tarjeta.FechaCaducidad);
                    command.Parameters.AddWithValue("@IdUsuario", idUsuario);

                    try {
                        // Ejecutar la query inserción
                        int registrosAfectados = command.ExecuteNonQuery();
                        Logger.logInfo("Se ha guardado la tarjeta con idUsuario = " + idUsuario + " en la base de datos");
                        Logger.logInfo($"Se insertó correctamente el registro. Registros afectados: {registrosAfectados}");
                    } catch (Exception ex) {
                        Logger.logError("Error al guardar la tarjeta con idUsuario = " + idUsuario + " en la base de datos");
                        Logger.logError($"Error al insertar el registro: {ex.Message}");
                    }
                }
            }
        }

        public static Tarjeta getTarjetaBaseDatosPorIdUsuario(int idUsuario) {
            Tarjeta tarjeta = null;
            string query = "SELECT * FROM Tarjetas WHERE IdUsuario = @IdUsuario";
            using (SqlConnection connection = new SqlConnection(ControladorBaseDatos.getConnectionString())) {
                try {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection)) {
                        command.Parameters.AddWithValue("@IdUsuario", idUsuario);
                        using (SqlDataReader reader = command.ExecuteReader()) {
                            while (reader.Read()) {
                                int id = int.Parse(reader["Id"].ToString());
                                long numero = long.Parse(reader["Numero"].ToString());
                                int cvv = int.Parse(reader["Cvv"].ToString());
                                string titular = reader["Titular"].ToString();
                                DateTime fechaCaducidad = (DateTime)reader["FechaCaducidad"];

                                tarjeta = new Tarjeta(numero, cvv, titular, fechaCaducidad);
                                tarjeta.Id = id;
                            }
                        }
                    }
                } catch (Exception ex) {
                    Logger.logError($"Error al cargar datos: {ex.Message}");
                    MessageBox.Show("Se ha producido un error al cargar la tarjeta con idUsuario = " + idUsuario, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return tarjeta;
        }

        public static void actualizarTarjetaBaseDatos(Tarjeta tarjeta, int idUsuario) {
            string connectionString = ControladorBaseDatos.getConnectionString();

            string query = "UPDATE Tarjetas SET Numero = @Numero, Cvv = @Cvv, Titular = @Titular, FechaCaducidad = @FechaCaducidad " +
                "WHERE IdUsuario = @IdUsuario";

            // Crear la conexión
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                // Abrir la conexión
                connection.Open();

                // Crear un objeto SqlCommand con la consulta y la conexión
                using (SqlCommand command = new SqlCommand(query, connection)) {

                    // Agregar parámetros y sus valores
                    command.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    command.Parameters.AddWithValue("@Numero", tarjeta.Numero);
                    command.Parameters.AddWithValue("@Cvv", tarjeta.Cvv);
                    command.Parameters.AddWithValue("@Titular", tarjeta.Titular);
                    command.Parameters.AddWithValue("@FechaCaducidad", tarjeta.FechaCaducidad);

                    try {
                        // Ejecutar la query inserción
                        int registrosAfectados = command.ExecuteNonQuery();
                        Logger.logInfo("Se ha actualizado la tarjeta del usuario con id = " + idUsuario);
                        Logger.logInfo($"Se actualizó correctamente el registro. Registros afectados: {registrosAfectados}");
                    } catch (Exception ex) {
                        Logger.logError("Error al actualizar la tarjeta del usuario con id = " + idUsuario);
                        Logger.logError($"Error al actualizar el registro: {ex.Message}");
                    }
                }
            }
        }

        public static void eliminarTarjetaPorIdUsuarioBaseDatos(int idUsuario) {
            string connectionString = ControladorBaseDatos.getConnectionString();
            string query = "DELETE FROM Tarjetas WHERE IdUsuario = @IdUsuario";

            // Crear la conexión
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                // Abrir la conexión
                connection.Open();

                // Crear un objeto SqlCommand con la consulta y la conexión
                using (SqlCommand command = new SqlCommand(query, connection)) {
                    // Agregar parámetros y sus valores
                    command.Parameters.AddWithValue("@IdUsuario", idUsuario);

                    try {
                        // Ejecutar la query inserción
                        int registrosAfectados = command.ExecuteNonQuery();
                        Logger.logInfo("El usuario con id = " + idUsuario + " ha eliminado su tarjeta de la base de datos");
                        Logger.logInfo($"Se eliminó correctamente el registro. Registros afectados: {registrosAfectados}");
                    } catch (Exception ex) {
                        Logger.logError("Error al eliminar la tarjeta del usuario con id = " + idUsuario + ", de la base de datos");
                        Logger.logError($"Error al eliminar el registro: {ex.Message}");
                    }
                }
            }
        }
    }
}
