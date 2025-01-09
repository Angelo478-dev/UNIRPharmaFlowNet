using System.Windows.Forms;
using UNIRPharmaFlow.Model;

namespace UNIRPharmaFlow.View
{
    partial class HistoricoVista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblHistorico = new System.Windows.Forms.DataGridView();
            this.ColumnNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDistribuidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Confirmado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // tblHistorico
            // 
            this.tblHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblHistorico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumero,
            this.ColumnDistribuidor,
            this.ColumnTipo,
            this.ColumnMedicamento,
            this.ColumnCantidad,
            this.ColumnSucursal,
            this.Confirmado});
            this.tblHistorico.Location = new System.Drawing.Point(0, 0);
            this.tblHistorico.Name = "tblHistorico";
            this.tblHistorico.RowHeadersWidth = 51;
            this.tblHistorico.RowTemplate.Height = 24;
            this.tblHistorico.Size = new System.Drawing.Size(936, 204);
            this.tblHistorico.TabIndex = 0;
            // 
            // ColumnNumero
            // 
            this.ColumnNumero.HeaderText = "N°Pedido";
            this.ColumnNumero.MinimumWidth = 6;
            this.ColumnNumero.Name = "ColumnNumero";
            this.ColumnNumero.Width = 125;
            // 
            // ColumnDistribuidor
            // 
            this.ColumnDistribuidor.HeaderText = "Distribuidor";
            this.ColumnDistribuidor.MinimumWidth = 6;
            this.ColumnDistribuidor.Name = "ColumnDistribuidor";
            this.ColumnDistribuidor.Width = 125;
            // 
            // ColumnTipo
            // 
            this.ColumnTipo.HeaderText = "Tipo";
            this.ColumnTipo.MinimumWidth = 6;
            this.ColumnTipo.Name = "ColumnTipo";
            this.ColumnTipo.Width = 125;
            // 
            // ColumnMedicamento
            // 
            this.ColumnMedicamento.HeaderText = "Medicamento";
            this.ColumnMedicamento.MinimumWidth = 6;
            this.ColumnMedicamento.Name = "ColumnMedicamento";
            this.ColumnMedicamento.Width = 125;
            // 
            // ColumnCantidad
            // 
            this.ColumnCantidad.HeaderText = "Cantidad";
            this.ColumnCantidad.MinimumWidth = 6;
            this.ColumnCantidad.Name = "ColumnCantidad";
            this.ColumnCantidad.Width = 125;
            // 
            // ColumnSucursal
            // 
            this.ColumnSucursal.HeaderText = "Sucursal";
            this.ColumnSucursal.MinimumWidth = 6;
            this.ColumnSucursal.Name = "ColumnSucursal";
            this.ColumnSucursal.Width = 125;
            // 
            // Confirmado
            // 
            this.Confirmado.HeaderText = "Confirmado";
            this.Confirmado.MinimumWidth = 6;
            this.Confirmado.Name = "Confirmado";
            this.Confirmado.ReadOnly = true;
            this.Confirmado.Width = 125;
            // 
            // HistoricoVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 435);
            this.Controls.Add(this.tblHistorico);
            this.Name = "HistoricoVista";
            this.Text = "HistoricoVista";
            ((System.ComponentModel.ISupportInitialize)(this.tblHistorico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView tblHistorico;
        private DataGridViewTextBoxColumn ColumnNumero;
        private DataGridViewTextBoxColumn ColumnDistribuidor;
        private DataGridViewTextBoxColumn ColumnTipo;
        private DataGridViewTextBoxColumn ColumnMedicamento;
        private DataGridViewTextBoxColumn ColumnCantidad;
        private DataGridViewTextBoxColumn ColumnSucursal;
        private DataGridViewTextBoxColumn Confirmado;
    }
}