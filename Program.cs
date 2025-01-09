using System;
using System.Windows.Forms;

namespace UNIRPharmaFlow
{
    /// <summary>
    /// Clase principal que sirve como punto de entrada de la aplicación.
    /// Esta clase inicializa la aplicación y ejecuta la ventana principal.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// Este método configura la aplicación, habilita los estilos visuales y ejecuta la ventana principal.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Habilitar los estilos visuales de la aplicación.
            Application.EnableVisualStyles();

            // Establecer el texto compatible con el renderizado estándar.
            Application.SetCompatibleTextRenderingDefault(false);

            // Iniciar la aplicación ejecutando el formulario principal.
            Application.Run(new FormularioPedidoVista());
        }
    }

}
