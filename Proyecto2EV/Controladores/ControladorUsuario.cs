using Proyecto2EV.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto2EV.Controladores {
    public static class ControladorUsuario {
        public static void añadirAlCarrito(ref Usuario usuario, ref VideoJuego videoJuego) {
            // Si el juego no esta en el carrito lo añade, si ya esta aumenta la cantidad
            if (usuario.Carrito.TryGetValue(videoJuego, out int cantidad)) {
                usuario.Carrito[videoJuego] = ++cantidad;
                actualizarCarritoBaseDatos(usuario, videoJuego);
            } else {
                usuario.Carrito.Add(videoJuego, 1);
                insertarJuegoAlCarritoBaseDatos(usuario, videoJuego);
            }

            Logger.logInfo("El usuario " + usuario.Nombre + " ha añadido (" + videoJuego.Nombre + ", " + usuario.Carrito[videoJuego] + ") a su carrito");
        }

        public static void setValorCarrito(ref Usuario usuario, ref VideoJuego videoJuego, int valor) {
            usuario.Carrito[videoJuego] = valor;
            actualizarCarritoBaseDatos(usuario, videoJuego);
            Logger.logInfo("El usuario " + usuario.Nombre + " ha actualizado su carrito (" + videoJuego.Nombre + ", " + usuario.Carrito[videoJuego] + ")");
        }

        public static void vaciarCarrito(ref Usuario usuario) {
            foreach (KeyValuePair<VideoJuego, int> entradaCarrito in usuario.Carrito) {
                eliminarJuegoCarritoBaseDatos(usuario, entradaCarrito.Key);
            }
            usuario.Carrito.Clear();
        }

        public static float getPrecioTotalCarrito(ref Usuario usuario) {
            float precioTotal = 0f;
            foreach (KeyValuePair<VideoJuego, int> item in usuario.Carrito) {
                precioTotal += item.Key.Precio * item.Value;
            }

            return (float)Math.Round(precioTotal, 2);
        }

        // Base de datos

        // FUNCIONES PARA MANEJAR LOS USUARIOS

        // Añade un usuario a la base de datos
        public static void insertarUsuarioBaseDatos(Usuario usuario) {
            string connectionString = ControladorBaseDatos.getConnectionString();

            string query = "INSERT INTO Usuarios " +
                "(Nombre, Clave, FechaNacimiento) " +
                "VALUES(@Nombre, @Clave, @FechaNacimiento)";

            // Crear la conexión
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                // Abrir la conexión
                connection.Open();

                // Crear un objeto SqlCommand con la consulta y la conexión
                using (SqlCommand command = new SqlCommand(query, connection)) {
                    // Agregar parámetros y sus valores
                    command.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                    command.Parameters.AddWithValue("@Clave", usuario.Clave);
                    command.Parameters.AddWithValue("@FechaNacimiento", usuario.FechaNacimiento);

                    try {
                        // Ejecutar la query inserción
                        int registrosAfectados = command.ExecuteNonQuery();
                        Logger.logInfo("Se ha registrado el usuario " + usuario.Nombre);
                        Logger.logInfo($"Se insertó correctamente el registro. Registros afectados: {registrosAfectados}");
                        MessageBox.Show("Se ha registrado correctamente el usuario " + usuario.Nombre, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } catch (Exception ex) {
                        Logger.logError("Error al registrar al usuario: " + usuario.Nombre);
                        Logger.logError($"Error al insertar el registro: {ex.Message}");
                        MessageBox.Show("Se ha producido un error al registar al usuario: " + usuario.Nombre, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Devuelve todos los usuarios
        public static List<Usuario> getUsuariosBaseDatos() {
            List<Usuario> listaUsuarios = new List<Usuario>();
            string query = "SELECT * FROM Usuarios";
            using (SqlConnection connection = new SqlConnection(ControladorBaseDatos.getConnectionString())) {
                try {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection)) {
                        using (SqlDataReader reader = command.ExecuteReader()) {
                            while (reader.Read()) {
                                int id = int.Parse(reader["Id"].ToString());
                                string nombre = reader["Nombre"].ToString();
                                string clave = reader["Clave"].ToString();
                                DateTime fechaNacimiento = (DateTime)reader["FechaNacimiento"];

                                Usuario usuario = new Usuario(nombre, clave, fechaNacimiento);
                                usuario.Id = id;

                                listaUsuarios.Add(usuario);
                            }
                        }
                    }
                } catch (Exception ex) {
                    Logger.logError($"Error al cargar datos: {ex.Message}");
                    MessageBox.Show("Se ha producido un error al cargar los usuarios desde la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return listaUsuarios;
        }

        // Devuelve un usuario segun su id
        public static Usuario getUsuarioBaseDatosPorId(int idUsuario) {
            Usuario usuario = null;
            string query = "SELECT * FROM Usuarios WHERE Id = @Id";
            using (SqlConnection connection = new SqlConnection(ControladorBaseDatos.getConnectionString())) {
                try {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection)) {
                        command.Parameters.AddWithValue("@Id", idUsuario);
                        using (SqlDataReader reader = command.ExecuteReader()) {
                            while (reader.Read()) {
                                int id = int.Parse(reader["Id"].ToString());
                                string nombre = reader["Nombre"].ToString();
                                string clave = reader["Clave"].ToString();
                                DateTime fechaNacimiento = (DateTime)reader["FechaNacimiento"];

                                usuario = new Usuario(nombre, clave, fechaNacimiento);
                                usuario.Id = id;
                            }
                        }
                    }
                } catch (Exception ex) {
                    Logger.logError($"Error al cargar datos: {ex.Message}");
                    MessageBox.Show("Se ha producido un error al cargar el usuario con id = " + idUsuario, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return usuario;
        }


        // FUNCIONES PARA MANEJAR LOS CARRITOS
        public static void insertarJuegoAlCarritoBaseDatos(Usuario usuario, VideoJuego videoJuego) {
            string connectionString = ControladorBaseDatos.getConnectionString();

            string query = "INSERT INTO Carritos " +
                "(IdUsuario, IdVideojuego, Cantidad) " +
                "VALUES(@IdUsuario, @IdVideojuego, @Cantidad)";

            // Crear la conexión
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                // Abrir la conexión
                connection.Open();

                // Crear un objeto SqlCommand con la consulta y la conexión
                using (SqlCommand command = new SqlCommand(query, connection)) {

                    int cantidad = usuario.Carrito[videoJuego];

                    // Agregar parámetros y sus valores
                    command.Parameters.AddWithValue("@IdUsuario", usuario.Id);
                    command.Parameters.AddWithValue("@IdVideojuego", videoJuego.Id);
                    command.Parameters.AddWithValue("@Cantidad", cantidad);

                    try {
                        // Ejecutar la query inserción
                        int registrosAfectados = command.ExecuteNonQuery();
                        Logger.logInfo("El usuario con id = " + usuario.Id + " ha añadido el videojuego con id = " + videoJuego.Id + ", " + cantidad + " veces a su carrito");
                        Logger.logInfo($"Se insertó correctamente el registro. Registros afectados: {registrosAfectados}");
                    } catch (Exception ex) {
                        Logger.logError("Error al añadir el videojuego con id = " + videoJuego.Id + " al carrito drl usuario con id = " + usuario.Id + ", " + cantidad + " veces");
                        Logger.logError($"Error al insertar el registro: {ex.Message}");
                        MessageBox.Show("Error al añadir un juego al carrito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public static void actualizarCarritoBaseDatos(Usuario usuario, VideoJuego videoJuego) {
            string connectionString = ControladorBaseDatos.getConnectionString();

            string query = "UPDATE Carritos SET Cantidad = @Cantidad " +
                "WHERE IdUsuario = @IdUsuario AND IdVideojuego = @IdVideojuego";

            // Crear la conexión
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                // Abrir la conexión
                connection.Open();

                // Crear un objeto SqlCommand con la consulta y la conexión
                using (SqlCommand command = new SqlCommand(query, connection)) {

                    int cantidad = usuario.Carrito[videoJuego];

                    // Agregar parámetros y sus valores
                    command.Parameters.AddWithValue("@IdUsuario", usuario.Id);
                    command.Parameters.AddWithValue("@IdVideojuego", videoJuego.Id);
                    command.Parameters.AddWithValue("@Cantidad", cantidad);

                    try {
                        // Ejecutar la query inserción
                        int registrosAfectados = command.ExecuteNonQuery();
                        Logger.logInfo("El usuario con id = " + usuario.Id + " ha actualizdo su carrito: videojuego con id = " + videoJuego.Id + "ahora esta " + cantidad + " veces");
                        Logger.logInfo($"Se actualizó correctamente el registro. Registros afectados: {registrosAfectados}");
                    } catch (Exception ex) {
                        Logger.logError("Error al actualizar el carrito del usuario con id = " + usuario.Id + ": videojuego con id = " + videoJuego.Id + ", " + cantidad + " veces");
                        Logger.logError($"Error al actualizar el registro: {ex.Message}");
                        MessageBox.Show("Error al actualizar el carrito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Devuelve el carrito segun la id del usuario
        public static Dictionary<VideoJuego, int> getCarritoUsuarioBaseDatos(int idUsuario) {
            Dictionary<VideoJuego, int> carrito = new Dictionary<VideoJuego, int>();
            string query = "SELECT * FROM Carritos WHERE IdUsuario = @IdUsuario";
            using (SqlConnection connection = new SqlConnection(ControladorBaseDatos.getConnectionString())) {
                try {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection)) {
                        command.Parameters.AddWithValue("@IdUsuario", idUsuario);
                        using (SqlDataReader reader = command.ExecuteReader()) {
                            while (reader.Read()) {
                                int idVideojuego = int.Parse(reader["IdVideojuego"].ToString());
                                VideoJuego videoJuego = ControladorVideoJuego.getVideoJuegoBaseDatosPorId(idVideojuego);

                                int cantidad = int.Parse(reader["Cantidad"].ToString());

                                carrito.Add(videoJuego, cantidad);
                            }
                        }
                    }
                } catch (Exception ex) {
                    Logger.logError($"Error al cargar datos: {ex.Message}");
                    MessageBox.Show("Se ha producido un error al cargar el carrtito del usuaro con id = " + idUsuario, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return carrito;
        }

        public static void eliminarJuegoCarritoBaseDatos(Usuario usuario, VideoJuego videoJuego) {
            string connectionString = ControladorBaseDatos.getConnectionString();
            string query = "DELETE FROM Carritos WHERE IdUsuario = @IdUsuario AND IdVideojuego = @IdVideojuego";

            // Crear la conexión
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                // Abrir la conexión
                connection.Open();

                // Crear un objeto SqlCommand con la consulta y la conexión
                using (SqlCommand command = new SqlCommand(query, connection)) {
                    // Agregar parámetros y sus valores
                    command.Parameters.AddWithValue("@IdUsuario", usuario.Id);
                    command.Parameters.AddWithValue("@IdVideojuego", videoJuego.Id);

                    try {
                        // Ejecutar la query inserción
                        int registrosAfectados = command.ExecuteNonQuery();
                        Logger.logInfo("El usuario con id = " + usuario.Id + " ha eliminado el juego con id = " + videoJuego.Id + " de su carrito");
                        Logger.logInfo($"Se eliminó correctamente el registro. Registros afectados: {registrosAfectados}");
                    } catch (Exception ex) {
                        Logger.logError("Error al eliminar el videojuego con id = " + videoJuego.Id + " del carrito del usuario con id = " + usuario.Id);
                        Logger.logError($"Error al eliminar el registro: {ex.Message}");
                        MessageBox.Show("Error al eliminar un juego del carrito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
