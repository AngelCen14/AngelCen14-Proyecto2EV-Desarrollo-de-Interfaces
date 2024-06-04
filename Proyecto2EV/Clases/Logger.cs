using Proyecto2EV.Controladores;
using System;

namespace Proyecto2EV.Clases {
    public class Logger {
        public static void logInfo(string mensaje) {
            mensaje = "[Info: " + DateTime.Now + "] " + mensaje + ".";
            Console.WriteLine(mensaje);
            ControladorLogger.guardarLog(mensaje);
        }

        public static void logWarning(string mensaje) {
            mensaje = "[Warning: " + DateTime.Now + "] " + mensaje + ".";
            Console.WriteLine(mensaje);
            ControladorLogger.guardarLog(mensaje);
        }

        public static void logError(string mensaje) {
            mensaje = "[Error: " + DateTime.Now + "] " + mensaje + ".";
            Console.WriteLine(mensaje);
            ControladorLogger.guardarLog(mensaje);
        }
    }
}
