using System;
using System.IO;

namespace Proyecto2EV.Controladores {
    public static class ControladorBaseDatos {
        public static string getConnectionString() {
            // Directorio del archivo de base de datos relativo al directorio de ejecución
            string databaseFileName = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\BaseDatosProyecto2EV.mdf"));
            // Cadena de conexión
            string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename ={databaseFileName}; Integrated Security = True";
            // Usar la cadena de conexión
            return connectionString;
        }
    }
}
