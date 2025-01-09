
namespace UNIRPharmaFlow.Model
{
    /// <summary>
    /// Representa un distribuidor de medicamentos con información sobre su nombre y dirección.
    /// </summary>
    public class Distribuidor
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase Distribuidor con el nombre y la dirección.
        /// </summary>
        /// <param name="nombre">El nombre del distribuidor.</param>
        /// <param name="direccion">La dirección del distribuidor.</param>
        public Distribuidor(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
        }

        /// <summary>
        /// Obtiene o establece el nombre del distribuidor.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Obtiene o establece la dirección del distribuidor.
        /// </summary>
        public string Direccion { get; set; }
    }

}
