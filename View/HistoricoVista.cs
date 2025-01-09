using System.Windows.Forms;
using UNIRPharmaFlow.Model;

namespace UNIRPharmaFlow.View
{
    /// <summary>
    /// Clase que representa la vista del historial de pedidos de medicamentos.
    /// Muestra una tabla con los pedidos realizados y un contador del número total de pedidos.
    /// </summary>
    public partial class HistoricoVista : Form
    {
        // Control para mostrar el historial de pedidos
        private DataGridView dgvHistorico = new DataGridView();

        // Etiqueta que muestra la cantidad de pedidos
        private Label lblCantidadPedidos;

        /// <summary>
        /// Propiedad pública de solo lectura que expone el DataGridView del historial.
        /// </summary>
        public DataGridView DataGridView => dgvHistorico;

        /// <summary>
        /// Constructor de la clase, configura la ventana del historial de pedidos.
        /// </summary>
        public HistoricoVista()
        {
            // Configuración básica del formulario
            this.Text = "Histórico de Pedidos de Medicamentos"; // Título del formulario
            this.StartPosition = FormStartPosition.CenterScreen; // Centra la ventana
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Define un borde fijo para el formulario
            this.MaximizeBox = false; // Deshabilita la opción de maximizar

            // Inicialización de componentes
            InitComponents();
            InitializeComponent();
        }

        /// <summary>
        /// Inicializa los componentes principales de la ventana, como la tabla y la etiqueta.
        /// </summary>
        private void InitComponents()
        {
            // Configuración de la etiqueta que muestra la cantidad de pedidos
            lblCantidadPedidos = new Label
            {
                Dock = DockStyle.Fill, // Hace que la etiqueta ocupe toda la anchura disponible
                Text = "Número de pedidos: 0", // Texto inicial
                TextAlign = System.Drawing.ContentAlignment.MiddleLeft // Alineación del texto a la izquierda
            };

            // Configuración del DataGridView para mostrar el historial de pedidos
            dgvHistorico = new DataGridView
            {
                Dock = DockStyle.Fill, // Hace que la tabla ocupe toda la anchura disponible
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None, // No ajusta las columnas automáticamente
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize, // Ajuste automático de la altura de las cabeceras
                AllowUserToAddRows = false, // Deshabilita la posibilidad de añadir filas manualmente
                Height = 200, // Altura predeterminada de la tabla
                ReadOnly = true // Bloquear toda la edición de celdas
            };

            // Definición de las columnas para la tabla
            dgvHistorico.Columns.Add("NumeroPedido", "N° Pedido");
            dgvHistorico.Columns.Add("Distribuidor", "Distribuidor");
            dgvHistorico.Columns.Add("Tipo", "Tipo");
            dgvHistorico.Columns.Add("Nombre", "Nombre");
            dgvHistorico.Columns.Add("Cantidad", "Cantidad");
            dgvHistorico.Columns.Add("Sucursal", "Sucursal");
            dgvHistorico.Columns.Add("Confirmado", "Confirmado");

            // Usar un TableLayoutPanel para organizar los controles en el formulario
            var layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill, // Asegura que el layout ocupe todo el espacio disponible
                RowCount = 4, // Define 4 filas en el layout
                ColumnCount = 1 // Define 1 columna
            };

            // Establece el porcentaje de altura para las filas del layout
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 90)); // 90% para la tabla
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 10)); // 10% para la etiqueta

            // Añade los controles al layout
            layout.Controls.Add(dgvHistorico, 0, 0); // Agrega el DataGridView en la fila 0
            layout.Controls.Add(lblCantidadPedidos, 0, 1); // Agrega la etiqueta en la fila 1

            // Ajustar el ancho de cada columna de acuerdo con el contenido más grande
            foreach (DataGridViewColumn column in dgvHistorico.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            // Añadir el layout al formulario
            this.Controls.Add(layout);

            // Configuración del tamaño automático del formulario
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        /// <summary>
        /// Agrega un nuevo pedido al historial de pedidos en la tabla.
        /// </summary>
        /// <param name="pedido">El objeto que representa el pedido que se va a agregar.</param>
        /// <param name="numeroPedido">El número de identificación del pedido.</param>
        public void AgregarPedidoATabla(Pedido pedido, int numeroPedido)
        {
            // Agrega una fila con los datos del pedido
            dgvHistorico.Rows.Add(
                numeroPedido,
                pedido.Distribuidor,
                pedido.TipoMedicamento,
                pedido.NombreMedicamento,
                pedido.Cantidad,
                pedido.Sucursal,
                "Si" // Estado de confirmación del pedido (siempre 'Sí' por defecto)
            );

            // Actualiza el contador de pedidos mostrado en la etiqueta
            lblCantidadPedidos.Text = $"Número de pedidos: {dgvHistorico.Rows.Count}";
        }
    }
}
