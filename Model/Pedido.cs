
namespace UNIRPharmaFlow.Model
{
    /// <summary>
    /// Representa un pedido de medicamentos, incluyendo detalles como el nombre, tipo, cantidad,
    /// distribuidor y sucursal asociados al pedido.
    /// </summary>
    public class Pedido
    {
        /// <summary>
        /// Obtiene o establece el nombre del medicamento solicitado en el pedido.
        /// </summary>
        public string NombreMedicamento { get; set; }

        /// <summary>
        /// Obtiene o establece el tipo de medicamento solicitado en el pedido.
        /// </summary>
        public string TipoMedicamento { get; set; }

        /// <summary>
        /// Obtiene o establece la cantidad de unidades solicitadas en el pedido.
        /// </summary>
        public int Cantidad { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre del distribuidor del medicamento.
        /// </summary>
        public string Distribuidor { get; set; }

        /// <summary>
        /// Obtiene o establece la sucursal asociada al pedido (donde se debe entregar el medicamento).
        /// </summary>
        public string Sucursal { get; set; }

        /// <summary>
        /// Constructor por defecto para crear una instancia de la clase Pedido sin parámetros.
        /// </summary>
        public Pedido() { }

        /// <summary>
        /// Constructor para inicializar una nueva instancia de la clase Pedido con valores específicos.
        /// </summary>
        /// <param name="nombreMedicamento">El nombre del medicamento solicitado en el pedido.</param>
        /// <param name="tipoMedicamento">El tipo de medicamento solicitado en el pedido.</param>
        /// <param name="cantidad">La cantidad de unidades solicitadas en el pedido.</param>
        /// <param name="distribuidor">El distribuidor que proveerá el medicamento.</param>
        /// <param name="sucursal">La sucursal que recibirá el medicamento.</param>
        public Pedido(string nombreMedicamento, string tipoMedicamento, int cantidad, string distribuidor, string sucursal)
        {
            NombreMedicamento = nombreMedicamento;
            TipoMedicamento = tipoMedicamento;
            Cantidad = cantidad;
            Distribuidor = distribuidor;
            Sucursal = sucursal;
        }

        /// <summary>
        /// Verifica si el pedido es válido. Un pedido es válido si:
        /// - El nombre del medicamento no es nulo ni vacío.
        /// - El tipo de medicamento no es nulo ni vacío.
        /// - La cantidad es mayor que cero.
        /// - El distribuidor no es nulo ni vacío.
        /// - La sucursal no es nula ni vacía.
        /// </summary>
        /// <returns>True si el pedido es válido, false en caso contrario.</returns>
        public bool EsValido()
        {
            return !string.IsNullOrEmpty(NombreMedicamento) &&
                   !string.IsNullOrEmpty(TipoMedicamento) &&
                   Cantidad > 0 &&
                   !string.IsNullOrEmpty(Distribuidor) &&
                   !string.IsNullOrEmpty(Sucursal);
        }
    }
}
