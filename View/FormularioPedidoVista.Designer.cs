namespace UNIRPharmaFlow
{
    partial class FormularioPedidoVista
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panPrincipal = new System.Windows.Forms.Panel();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.lblDistribuidor = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkSecundaria = new System.Windows.Forms.CheckBox();
            this.chkPrincipal = new System.Windows.Forms.CheckBox();
            this.panelDistribuidor = new System.Windows.Forms.Panel();
            this.rCemefar = new System.Windows.Forms.RadioButton();
            this.rEmpsephar = new System.Windows.Forms.RadioButton();
            this.rCofarma = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbTipoMedicamento = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtNombreMedicamento = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblTMedicamento = new System.Windows.Forms.Label();
            this.lblNMedicamento = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panPrincipal.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelDistribuidor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panPrincipal
            // 
            this.panPrincipal.Controls.Add(this.lblSucursal);
            this.panPrincipal.Controls.Add(this.lblDistribuidor);
            this.panPrincipal.Controls.Add(this.btnSalir);
            this.panPrincipal.Controls.Add(this.btnBorrar);
            this.panPrincipal.Controls.Add(this.btnHistorico);
            this.panPrincipal.Controls.Add(this.btnConfirmar);
            this.panPrincipal.Controls.Add(this.panel2);
            this.panPrincipal.Controls.Add(this.panelDistribuidor);
            this.panPrincipal.Controls.Add(this.panel1);
            this.panPrincipal.Controls.Add(this.lblTitulo);
            this.panPrincipal.Location = new System.Drawing.Point(1, 0);
            this.panPrincipal.Name = "panPrincipal";
            this.panPrincipal.Size = new System.Drawing.Size(560, 543);
            this.panPrincipal.TabIndex = 0;
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Location = new System.Drawing.Point(287, 233);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(59, 16);
            this.lblSucursal.TabIndex = 8;
            this.lblSucursal.Text = "Sucursal";
            // 
            // lblDistribuidor
            // 
            this.lblDistribuidor.AutoSize = true;
            this.lblDistribuidor.Location = new System.Drawing.Point(34, 234);
            this.lblDistribuidor.Name = "lblDistribuidor";
            this.lblDistribuidor.Size = new System.Drawing.Size(75, 16);
            this.lblDistribuidor.TabIndex = 3;
            this.lblDistribuidor.Text = "Distribuidor";
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::UNIRPharmaFlow.Properties.Resources.icons8_salir_redondeado_64;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.Font = new System.Drawing.Font("Segoe Fluent Icons", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(296, 453);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(191, 81);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackgroundImage = global::UNIRPharmaFlow.Properties.Resources._3808224_broomstick_fly_magic_witch_109093;
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBorrar.Font = new System.Drawing.Font("Segoe Fluent Icons", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(37, 453);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(191, 81);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnHistorico
            // 
            this.btnHistorico.BackgroundImage = global::UNIRPharmaFlow.Properties.Resources.hourglass_sanglass_timer_clock_icon_185976;
            this.btnHistorico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHistorico.Font = new System.Drawing.Font("Segoe Fluent Icons", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorico.Location = new System.Drawing.Point(296, 366);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(191, 81);
            this.btnHistorico.TabIndex = 5;
            this.btnHistorico.Text = "Histórico";
            this.btnHistorico.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnHistorico.UseVisualStyleBackColor = true;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.AutoSize = true;
            this.btnConfirmar.BackColor = System.Drawing.SystemColors.Control;
            this.btnConfirmar.BackgroundImage = global::UNIRPharmaFlow.Properties.Resources.icons8_cuenta_verificada_48;
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe Fluent Icons", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(37, 366);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(191, 81);
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkSecundaria);
            this.panel2.Controls.Add(this.chkPrincipal);
            this.panel2.Location = new System.Drawing.Point(287, 250);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 3;
            // 
            // chkSecundaria
            // 
            this.chkSecundaria.AutoSize = true;
            this.chkSecundaria.Location = new System.Drawing.Point(46, 55);
            this.chkSecundaria.Name = "chkSecundaria";
            this.chkSecundaria.Size = new System.Drawing.Size(98, 20);
            this.chkSecundaria.TabIndex = 1;
            this.chkSecundaria.Text = "Secundaria";
            this.chkSecundaria.UseVisualStyleBackColor = true;
            // 
            // chkPrincipal
            // 
            this.chkPrincipal.AutoSize = true;
            this.chkPrincipal.Location = new System.Drawing.Point(46, 28);
            this.chkPrincipal.Name = "chkPrincipal";
            this.chkPrincipal.Size = new System.Drawing.Size(81, 20);
            this.chkPrincipal.TabIndex = 0;
            this.chkPrincipal.Text = "Principal";
            this.chkPrincipal.UseVisualStyleBackColor = true;
            // 
            // panelDistribuidor
            // 
            this.panelDistribuidor.AccessibleDescription = "Distribuidor";
            this.panelDistribuidor.AccessibleName = "Distribuidor";
            this.panelDistribuidor.Controls.Add(this.rCemefar);
            this.panelDistribuidor.Controls.Add(this.rEmpsephar);
            this.panelDistribuidor.Controls.Add(this.rCofarma);
            this.panelDistribuidor.Location = new System.Drawing.Point(37, 250);
            this.panelDistribuidor.Name = "panelDistribuidor";
            this.panelDistribuidor.Size = new System.Drawing.Size(200, 100);
            this.panelDistribuidor.TabIndex = 2;
            this.panelDistribuidor.Tag = "";
            // 
            // rCemefar
            // 
            this.rCemefar.AutoSize = true;
            this.rCemefar.Location = new System.Drawing.Point(26, 70);
            this.rCemefar.Name = "rCemefar";
            this.rCemefar.Size = new System.Drawing.Size(79, 20);
            this.rCemefar.TabIndex = 2;
            this.rCemefar.TabStop = true;
            this.rCemefar.Text = "Cemefar";
            this.rCemefar.UseVisualStyleBackColor = true;
            // 
            // rEmpsephar
            // 
            this.rEmpsephar.AutoSize = true;
            this.rEmpsephar.Location = new System.Drawing.Point(26, 43);
            this.rEmpsephar.Name = "rEmpsephar";
            this.rEmpsephar.Size = new System.Drawing.Size(98, 20);
            this.rEmpsephar.TabIndex = 1;
            this.rEmpsephar.TabStop = true;
            this.rEmpsephar.Text = "Empsephar";
            this.rEmpsephar.UseVisualStyleBackColor = true;
            // 
            // rCofarma
            // 
            this.rCofarma.AutoSize = true;
            this.rCofarma.Location = new System.Drawing.Point(26, 16);
            this.rCofarma.Name = "rCofarma";
            this.rCofarma.Size = new System.Drawing.Size(79, 20);
            this.rCofarma.TabIndex = 0;
            this.rCofarma.TabStop = true;
            this.rCofarma.Text = "Cofarma";
            this.rCofarma.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.cmbTipoMedicamento);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.txtNombreMedicamento);
            this.panel1.Controls.Add(this.lblCantidad);
            this.panel1.Controls.Add(this.lblTMedicamento);
            this.panel1.Controls.Add(this.lblNMedicamento);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(37, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 139);
            this.panel1.TabIndex = 1;
            // 
            // cmbTipoMedicamento
            // 
            this.cmbTipoMedicamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoMedicamento.FormattingEnabled = true;
            this.cmbTipoMedicamento.Items.AddRange(new object[] {
            "",
            "Analgésico",
            "Analéptico",
            "Anestésico",
            "Antiácido",
            "Antidepresivo",
            "Antibióticos"});
            this.cmbTipoMedicamento.Location = new System.Drawing.Point(183, 52);
            this.cmbTipoMedicamento.Name = "cmbTipoMedicamento";
            this.cmbTipoMedicamento.Size = new System.Drawing.Size(258, 24);
            this.cmbTipoMedicamento.TabIndex = 5;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(183, 93);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(258, 22);
            this.txtCantidad.TabIndex = 4;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtNombreMedicamento
            // 
            this.txtNombreMedicamento.Location = new System.Drawing.Point(183, 14);
            this.txtNombreMedicamento.Name = "txtNombreMedicamento";
            this.txtNombreMedicamento.Size = new System.Drawing.Size(258, 22);
            this.txtNombreMedicamento.TabIndex = 3;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(14, 93);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(64, 16);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblTMedicamento
            // 
            this.lblTMedicamento.AutoSize = true;
            this.lblTMedicamento.Location = new System.Drawing.Point(14, 52);
            this.lblTMedicamento.Name = "lblTMedicamento";
            this.lblTMedicamento.Size = new System.Drawing.Size(123, 16);
            this.lblTMedicamento.TabIndex = 1;
            this.lblTMedicamento.Text = "Tipo Medicamento:";
            // 
            // lblNMedicamento
            // 
            this.lblNMedicamento.AutoSize = true;
            this.lblNMedicamento.Location = new System.Drawing.Point(14, 14);
            this.lblNMedicamento.Name = "lblNMedicamento";
            this.lblNMedicamento.Size = new System.Drawing.Size(144, 16);
            this.lblNMedicamento.TabIndex = 0;
            this.lblNMedicamento.Text = "Nombre Medicamento:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe Fluent Icons", 46.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(-3, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(507, 77);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "UNIRPharmaFlow";
            // 
            // FormularioPedidoVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 542);
            this.Controls.Add(this.panPrincipal);
            this.Name = "FormularioPedidoVista";
            this.Text = "Form1";
            this.panPrincipal.ResumeLayout(false);
            this.panPrincipal.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelDistribuidor.ResumeLayout(false);
            this.panelDistribuidor.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panPrincipal;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNombreMedicamento;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblTMedicamento;
        private System.Windows.Forms.Label lblNMedicamento;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cmbTipoMedicamento;
        private System.Windows.Forms.Panel panelDistribuidor;
        private System.Windows.Forms.RadioButton rCemefar;
        private System.Windows.Forms.RadioButton rEmpsephar;
        private System.Windows.Forms.RadioButton rCofarma;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkSecundaria;
        private System.Windows.Forms.CheckBox chkPrincipal;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblDistribuidor;
        private System.Windows.Forms.Label lblSucursal;
    }
}

