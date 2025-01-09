
using System;
using UNIRPharmaFlow.Model;

namespace UNIRPharmaFlow.View.Interfaz
{
    /// <summary>
    /// Interfaz para la vista del formulario de pedidos.
    /// Define los métodos y propiedades que el controlador usará para interactuar con la vista.
    /// </summary>
    public interface IFormularioPedidoVista
    {
        // Propiedades para obtener datos del usuario.
        string GetNombreMedicamento();
        string GetTipoMedicamento();
        string GetCantidad();
        Distribuidor GetDistribuidorSeleccionado();

        // Métodos para manejar la selección de sucursales.
        bool IsSucursalPrincipalSeleccionada();
        bool IsSucursalSecundariaSeleccionada();

        // Métodos para actualizar la vista.
        void MostrarResumenPedido(Pedido pedido);
        void MostrarError(string mensaje);

        // Evento que se dispara al confirmar un pedido.
        event EventHandler ConfirmarPedidoClicked;
    }
}
