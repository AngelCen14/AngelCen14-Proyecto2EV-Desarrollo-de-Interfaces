using Proyecto2EV.Clases;
using System;
using System.IO;

namespace Proyecto2EV.Controladores {
    public static class ControladorLogger {
        public static void guardarLog(string mensaje) {
            try {
                using (StreamWriter writer = new StreamWriter(Constantes.FICHERO_LOGS, true)) {
                    writer.WriteLine(mensaje);
                }
            } catch (Exception e) {
                Console.WriteLine("Error al escribir en el archivo de log: " + e.Message);
            }
        }

        public static string cargarLog() {
            string contenidoLog;
            try {
                contenidoLog = File.ReadAllText(Constantes.FICHERO_LOGS);
            } catch (FileNotFoundException e) {
                contenidoLog = "Archivo de log no encontrado.";
                Console.WriteLine(e.StackTrace);
            } catch (Exception e) {
                contenidoLog = "Error al leer el archivo de log: " + e.Message;
                Console.WriteLine(e.StackTrace);
            }

            return contenidoLog;
        }
    }
}
