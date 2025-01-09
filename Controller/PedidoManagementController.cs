using System;
using System.Linq;
using UNIRPharmaFlow.Model;
using UNIRPharmaFlow.View.Interfaz;

namespace UNIRPharmaFlow.Controller
{
    /// <summary>
    /// Controlador que maneja la lógica del negocio para la gestión de pedidos de medicamentos.
    /// Se comunica con la vista para obtener la entrada del usuario y validar la información.
    /// </summary>
    public class PedidoManagementController
    {
        // Vista a la que se conecta el controlador
        private readonly IFormularioPedidoVista _vista;

        /// <summary>
        /// Constructor que inicializa el controlador y suscribe el evento de confirmación de pedido.
        /// </summary>
        /// <param name="vista">La vista que implementa la interfaz IFormularioPedidoVista.</param>
        public PedidoManagementController(IFormularioPedidoVista vista)
        {
            this._vista = vista;

            // Se suscribe al evento que indica que el usuario ha confirmado el pedido
            this._vista.ConfirmarPedidoClicked += OnConfirmarPedido;
        }

        public IFormularioPedidoVista IFormularioPedidoVista
        {
            get => default;
            set
            {
            }
        }

        public Distribuidor Distribuidor
        {
            get => default;
            set
            {
            }
        }

        public Pedido Pedido
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Maneja el evento cuando el usuario hace clic en el botón de confirmar pedido.
        /// Realiza la validación de entrada y luego crea un modelo de pedido.
        /// </summary>
        private void OnConfirmarPedido(object sender, EventArgs e)
        {
            // Si la validación falla, no se procesa el pedido
            if (!ValidarEntrada())
                return;

            // Recupera los datos de la vista
            string nombre = _vista.GetNombreMedicamento();
            string tipo = _vista.GetTipoMedicamento();
            int cantidad = int.Parse(_vista.GetCantidad());
            var distribuidor = _vista.GetDistribuidorSeleccionado();

            // Determina la sucursal según la selección
            string sucursal = _vista.IsSucursalPrincipalSeleccionada()
                ? "Para la farmacia situada en Calle de la Rosa n. 28"
                : "Para la farmacia situada en Calle Alcazabilla n. 3";

            // Crea el modelo de pedido con los datos obtenidos
            var pedido = new Pedido(nombre, tipo, cantidad, distribuidor.Nombre, sucursal);

            // Muestra un resumen del pedido en la vista
            _vista.MostrarResumenPedido(pedido);
        }

        /// <summary>
        /// Valida la entrada de datos en los campos del formulario.
        /// Asegura que todos los campos tengan valores correctos antes de proceder.
        /// </summary>
        /// <returns>True si todos los datos son válidos, False si alguna validación falla.</returns>
        private bool ValidarEntrada()
        {
            // Recupera los datos ingresados por el usuario
            string nombre = _vista.GetNombreMedicamento();
            string tipo = _vista.GetTipoMedicamento();
            string cantidadStr = _vista.GetCantidad();
            var distribuidor = _vista.GetDistribuidorSeleccionado();

            // Validación: El nombre no debe estar vacío
            if (string.IsNullOrWhiteSpace(nombre))
            {
                _vista.MostrarError("El nombre del medicamento no puede estar vacío.");
                return false;
            }

            // Validación: El nombre no debe comenzar con un número
            if (char.IsDigit(nombre.Trim().FirstOrDefault()))
            {
                _vista.MostrarError("El nombre del medicamento no puede comenzar con un número.");
                return false;
            }

            // Validación: El tipo debe ser especificado
            if (string.IsNullOrWhiteSpace(tipo))
            {
                _vista.MostrarError("Debe especificar el tipo de medicamento.");
                return false;
            }

            // Validación: La cantidad debe ser un número entero positivo
            if (string.IsNullOrWhiteSpace(cantidadStr) || !int.TryParse(cantidadStr, out int cantidad) || cantidad <= 0)
            {
                _vista.MostrarError("La cantidad debe ser un número entero positivo.");
                return false;
            }

            // Validación: Un distribuidor debe ser seleccionado
            if (distribuidor == null)
            {
                _vista.MostrarError("Debe seleccionar un distribuidor.");
                return false;
            }

            // Validación: Se debe seleccionar al menos una sucursal
            if (!_vista.IsSucursalPrincipalSeleccionada() && !_vista.IsSucursalSecundariaSeleccionada())
            {
                _vista.MostrarError("Debe seleccionar una sucursal.");
                return false;
            }

            // Si todas las validaciones pasan, retorna true
            return true;
        }
    }

}
