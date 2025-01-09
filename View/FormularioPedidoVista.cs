using System;

using System.Windows.Forms;
using UNIRPharmaFlow.Controller;
using UNIRPharmaFlow.Model;
using UNIRPharmaFlow.View;
using UNIRPharmaFlow.View.Interfaz;

namespace UNIRPharmaFlow
{
    /// <summary>
    /// Formulario que maneja la interfaz para la gestión de pedidos de medicamentos.
    /// Permite ingresar datos sobre el medicamento, el distribuidor, la cantidad y la sucursal.
    /// También proporciona funcionalidad para mostrar el histórico de pedidos y limpiar la pantalla.
    /// </summary>
    public partial class FormularioPedidoVista : Form, IFormularioPedidoVista
    {
        // Controlador que maneja la lógica del pedido
        private readonly PedidoManagementController _control;

        // Vista del historial de pedidos
        private readonly HistoricoVista _historicoVista = new HistoricoVista();

        // Contador de pedidos (para generar un número de pedido único)
        private int _contadorPedidos = 1;

        /// <summary>
        /// Constructor del formulario. Inicializa los componentes y configura el controlador y las propiedades iniciales.
        /// </summary>
        public FormularioPedidoVista()
        {
            InitializeComponent();
            _control = new PedidoManagementController(this);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Pedidos de Medicamentos";

            // Configuración para cerrar la aplicación cuando se cierra el formulario
            FormClosing += (sender, e) => Application.Exit();
        }

        // Implementación de IFormularioPedidoVista

        /// <summary>
        /// Obtiene el nombre del medicamento ingresado en el formulario.
        /// </summary>
        public string GetNombreMedicamento() => txtNombreMedicamento.Text.Trim();

        /// <summary>
        /// Obtiene el tipo de medicamento seleccionado en el formulario.
        /// </summary>
        public string GetTipoMedicamento() => cmbTipoMedicamento.SelectedItem?.ToString();

        /// <summary>
        /// Obtiene la cantidad de medicamento ingresada en el formulario.
        /// </summary>
        public string GetCantidad() => txtCantidad.Text.Trim();

        /// <summary>
        /// Obtiene el distribuidor seleccionado en el formulario.
        /// </summary>
        public Distribuidor GetDistribuidorSeleccionado()
        {
            string distribuidorSeleccionado = null;

            if (rCofarma.Checked)
                distribuidorSeleccionado = "Cofarma";
            else if (rEmpsephar.Checked)
                distribuidorSeleccionado = "Empsephar";
            else if (rCemefar.Checked)
                distribuidorSeleccionado = "Cemefar";

            switch (distribuidorSeleccionado)
            {
                case "Cofarma":
                    return new Distribuidor("Cofarma", "Calle Principal 1");
                case "Empsephar":
                    return new Distribuidor("Empsephar", "Calle Secundaria 2");
                case "Cemefar":
                    return new Distribuidor("Cemefar", "Calle Tercera 3");
                default:
                    return null; // Si no hay coincidencia, retorna null
            }
        }

        /// <summary>
        /// Verifica si la sucursal principal está seleccionada en el formulario.
        /// </summary>
        public bool IsSucursalPrincipalSeleccionada() => chkPrincipal.Checked;

        /// <summary>
        /// Verifica si la sucursal secundaria está seleccionada en el formulario.
        /// </summary>
        public bool IsSucursalSecundariaSeleccionada() => chkSecundaria.Checked;

        /// <summary>
        /// Muestra un mensaje de error en un cuadro de mensaje.
        /// </summary>
        public void MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Muestra el resumen de un pedido, solicitando confirmación al usuario para enviarlo.
        /// Si el usuario confirma, agrega el pedido al histórico y limpia la pantalla.
        /// </summary>
        public void MostrarResumenPedido(Pedido pedido)
        {
            try
            {
                var mensaje = $"Medicamento: {pedido.Cantidad} unidades de {pedido.TipoMedicamento} {pedido.NombreMedicamento}\n" +
                              $"Dirección farmacia: {pedido.Sucursal}";
                var titulo = $"Pedido del distribuidor {pedido.Distribuidor}";

                // Mostrar un cuadro de mensaje con botones "Enviar" y "Cancelar"
                var opcion = MessageBox.Show(mensaje, titulo, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                // Si el usuario presiona "OK", consideramos que es "Enviar"
                if (opcion == DialogResult.OK)
                {
                    var peticion = _contadorPedidos++;
                    _historicoVista.AgregarPedidoATabla(pedido, peticion);
                    LimpiarPantalla();
                    Console.WriteLine("\n***************************  Pedido Enviado  ***************************");
                    Console.WriteLine(titulo + "\n" + mensaje);
                    Console.WriteLine("\n***************************  Pedido Enviado  ***************************");
                }
                else
                {
                    // Si el usuario presiona "Cancelar"
                    Console.WriteLine("El pedido fue cancelado.");
                }
            }
            catch (Exception e)
            {
                MostrarError("Error al mostrar el resumen del pedido: " + e.Message);
            }
        }


        /// <summary>
        /// Limpia todos los campos de entrada en el formulario.
        /// </summary>
        private void LimpiarPantalla()
        {
            txtNombreMedicamento.Clear();
            txtCantidad.Clear();
            cmbTipoMedicamento.SelectedIndex = -1;
            rCofarma.Checked = false;
            rEmpsephar.Checked = false;
            rCemefar.Checked = false;
            chkPrincipal.Checked = false;
            chkSecundaria.Checked = false;
        }

        public event EventHandler ConfirmarPedidoClicked;

        /// <summary>
        /// Evento que se dispara cuando se hace clic en el botón "Confirmar" para confirmar un pedido.
        /// </summary>
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ConfirmarPedidoClicked?.Invoke(this, EventArgs.Empty);
        }

        // Eventos de la interfaz

        /// <summary>
        /// Controla el evento de la tecla presionada en el campo de cantidad.
        /// Permite solo la entrada de números.
        /// </summary>
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter ingresado es un número o una tecla de control (por ejemplo, retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MostrarError("Por favor, ingrese solo números válidos.");
            }

            // Limitar la longitud del texto a 10 caracteres
            if (txtCantidad.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MostrarError("La cantidad no puede tener más de 10 caracteres.");
            }
        }


        /// <summary>
        /// Abre la ventana del histórico de pedidos. Si no hay información, muestra un mensaje informativo.
        /// </summary>
        private void btnHistorico_Click(object sender, EventArgs e)
        {
            try
            {
                if (_historicoVista.DataGridView.RowCount == 0) // Verificar si no hay registros
                {
                    MessageBox.Show("No hay información en el histórico.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; // Salir del método si no hay datos
                }

                _historicoVista.StartPosition = FormStartPosition.CenterParent;
                _historicoVista.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MostrarError("Error al abrir el histórico: " + ex.Message);
            }
        }

        /// <summary>
        /// Borra la información ingresada en el formulario. Si no hay información, muestra un mensaje de error.
        /// </summary>
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            // Verificar si los campos de entrada están vacíos
            if (string.IsNullOrWhiteSpace(txtNombreMedicamento.Text) &&
                string.IsNullOrWhiteSpace(txtCantidad.Text) &&
                cmbTipoMedicamento.SelectedIndex == -1 &&
                !rCofarma.Checked && !rEmpsephar.Checked && !rCemefar.Checked &&
                !chkPrincipal.Checked && !chkSecundaria.Checked)
            {
                // Mostrar mensaje si no hay información para borrar
                MostrarError("No hay información para borrar en formulario.");
            }
            else
            {
                // Limpiar pantalla si hay información
                LimpiarPantalla();
            }
        }

        /// <summary>
        /// Muestra un mensaje de agradecimiento y cierra el formulario.
        /// </summary>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Mostrar mensaje de agradecimiento
            MessageBox.Show("¡Gracias por preferirnos! Esperamos verte pronto.", "Despedida", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Cerrar el formulario después de mostrar el mensaje
            Close();
        }
    }

}
