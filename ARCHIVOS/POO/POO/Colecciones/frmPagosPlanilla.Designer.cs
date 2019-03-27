namespace POO.Colecciones
{
    partial class frmPagosPlanilla
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.DGVPagos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.rbtPlanilla = new System.Windows.Forms.RadioButton();
            this.rbtContratado = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHorasTrabajadas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHorasExtras = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBonificacion = new System.Windows.Forms.TextBox();
            this.txtPagoHoraExtra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNeto = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPagoHora = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PagoHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PagoHET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bonificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Neto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPagos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(267, 187);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 36);
            this.btnEliminar.TabIndex = 43;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(186, 187);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 36);
            this.btnBuscar.TabIndex = 42;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(105, 187);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 36);
            this.btnGrabar.TabIndex = 40;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(22, 187);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(77, 36);
            this.btnNuevo.TabIndex = 39;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // DGVPagos
            // 
            this.DGVPagos.AllowUserToAddRows = false;
            this.DGVPagos.AllowUserToDeleteRows = false;
            this.DGVPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Estado,
            this.HT,
            this.PagoHT,
            this.HET,
            this.PagoHET,
            this.Salario,
            this.Bonificacion,
            this.Descuento,
            this.Neto});
            this.DGVPagos.Location = new System.Drawing.Point(22, 239);
            this.DGVPagos.Name = "DGVPagos";
            this.DGVPagos.ReadOnly = true;
            this.DGVPagos.Size = new System.Drawing.Size(976, 235);
            this.DGVPagos.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Cargo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(22, 93);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(139, 20);
            this.txtNombre.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nombre";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(22, 41);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(139, 20);
            this.txtCodigo.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Código";
            // 
            // cboCargo
            // 
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Items.AddRange(new object[] {
            "Gerente",
            "Jefe",
            "Supervisor",
            "Asistente",
            "Secretaria"});
            this.cboCargo.Location = new System.Drawing.Point(19, 145);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(141, 21);
            this.cboCargo.TabIndex = 44;
            // 
            // rbtPlanilla
            // 
            this.rbtPlanilla.AutoSize = true;
            this.rbtPlanilla.Location = new System.Drawing.Point(203, 42);
            this.rbtPlanilla.Name = "rbtPlanilla";
            this.rbtPlanilla.Size = new System.Drawing.Size(58, 17);
            this.rbtPlanilla.TabIndex = 45;
            this.rbtPlanilla.TabStop = true;
            this.rbtPlanilla.Text = "Planilla";
            this.rbtPlanilla.UseVisualStyleBackColor = true;
            // 
            // rbtContratado
            // 
            this.rbtContratado.AutoSize = true;
            this.rbtContratado.Location = new System.Drawing.Point(267, 42);
            this.rbtContratado.Name = "rbtContratado";
            this.rbtContratado.Size = new System.Drawing.Size(77, 17);
            this.rbtContratado.TabIndex = 45;
            this.rbtContratado.TabStop = true;
            this.rbtContratado.Text = "Contratado";
            this.rbtContratado.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Horas Trabajadas";
            // 
            // txtHorasTrabajadas
            // 
            this.txtHorasTrabajadas.Location = new System.Drawing.Point(203, 94);
            this.txtHorasTrabajadas.Name = "txtHorasTrabajadas";
            this.txtHorasTrabajadas.Size = new System.Drawing.Size(58, 20);
            this.txtHorasTrabajadas.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(200, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Horas Extras";
            // 
            // txtHorasExtras
            // 
            this.txtHorasExtras.Location = new System.Drawing.Point(203, 145);
            this.txtHorasExtras.Name = "txtHorasExtras";
            this.txtHorasExtras.Size = new System.Drawing.Size(58, 20);
            this.txtHorasExtras.TabIndex = 38;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBonificacion);
            this.groupBox1.Controls.Add(this.txtPagoHoraExtra);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtNeto);
            this.groupBox1.Controls.Add(this.txtDescuento);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtSalario);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtPagoHora);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(382, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 164);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Totales";
            // 
            // txtBonificacion
            // 
            this.txtBonificacion.Location = new System.Drawing.Point(118, 108);
            this.txtBonificacion.Name = "txtBonificacion";
            this.txtBonificacion.Size = new System.Drawing.Size(58, 20);
            this.txtBonificacion.TabIndex = 45;
            // 
            // txtPagoHoraExtra
            // 
            this.txtPagoHoraExtra.Location = new System.Drawing.Point(21, 107);
            this.txtPagoHoraExtra.Name = "txtPagoHoraExtra";
            this.txtPagoHoraExtra.Size = new System.Drawing.Size(58, 20);
            this.txtPagoHoraExtra.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(115, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Bonificacion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Pago hora Extra";
            // 
            // txtNeto
            // 
            this.txtNeto.Location = new System.Drawing.Point(192, 107);
            this.txtNeto.Name = "txtNeto";
            this.txtNeto.Size = new System.Drawing.Size(58, 20);
            this.txtNeto.TabIndex = 47;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(192, 55);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(58, 20);
            this.txtDescuento.TabIndex = 48;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(189, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "Neto";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(118, 56);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(58, 20);
            this.txtSalario.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(189, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Descuento";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPagoHora
            // 
            this.txtPagoHora.Location = new System.Drawing.Point(21, 55);
            this.txtPagoHora.Name = "txtPagoHora";
            this.txtPagoHora.Size = new System.Drawing.Size(58, 20);
            this.txtPagoHora.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(115, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Salario";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Pago Hora";
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // HT
            // 
            this.HT.DataPropertyName = "HT";
            this.HT.HeaderText = "HT";
            this.HT.Name = "HT";
            this.HT.ReadOnly = true;
            // 
            // PagoHT
            // 
            this.PagoHT.DataPropertyName = "PagoHT";
            this.PagoHT.HeaderText = "PagoHT";
            this.PagoHT.Name = "PagoHT";
            this.PagoHT.ReadOnly = true;
            // 
            // HET
            // 
            this.HET.DataPropertyName = "HET";
            this.HET.HeaderText = "HET";
            this.HET.Name = "HET";
            this.HET.ReadOnly = true;
            // 
            // PagoHET
            // 
            this.PagoHET.DataPropertyName = "PagoHET";
            this.PagoHET.HeaderText = "PagoHET";
            this.PagoHET.Name = "PagoHET";
            this.PagoHET.ReadOnly = true;
            // 
            // Salario
            // 
            this.Salario.DataPropertyName = "Salario";
            this.Salario.HeaderText = "Salario";
            this.Salario.Name = "Salario";
            this.Salario.ReadOnly = true;
            // 
            // Bonificacion
            // 
            this.Bonificacion.DataPropertyName = "Bonificacion";
            this.Bonificacion.HeaderText = "Bonificacion";
            this.Bonificacion.Name = "Bonificacion";
            this.Bonificacion.ReadOnly = true;
            // 
            // Descuento
            // 
            this.Descuento.DataPropertyName = "Descuento";
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            // 
            // Neto
            // 
            this.Neto.DataPropertyName = "Neto";
            this.Neto.HeaderText = "Neto";
            this.Neto.Name = "Neto";
            this.Neto.ReadOnly = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(682, 93);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(93, 85);
            this.btnCalcular.TabIndex = 51;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmPagosPlanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 495);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbtContratado);
            this.Controls.Add(this.rbtPlanilla);
            this.Controls.Add(this.cboCargo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.DGVPagos);
            this.Controls.Add(this.txtHorasTrabajadas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHorasExtras);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Name = "frmPagosPlanilla";
            this.Text = "frmPagosPlanilla";
            ((System.ComponentModel.ISupportInitialize)(this.DGVPagos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGVPagos;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.TextBox txtHorasTrabajadas;
        public System.Windows.Forms.TextBox txtHorasExtras;
        public System.Windows.Forms.TextBox txtBonificacion;
        public System.Windows.Forms.TextBox txtPagoHoraExtra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtNeto;
        public System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtPagoHora;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn HT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PagoHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn HET;
        private System.Windows.Forms.DataGridViewTextBoxColumn PagoHET;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bonificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Neto;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.Button btnGrabar;
        public System.Windows.Forms.Button btnNuevo;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cboCargo;
        public System.Windows.Forms.RadioButton rbtPlanilla;
        public System.Windows.Forms.RadioButton rbtContratado;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnCalcular;
    }
}