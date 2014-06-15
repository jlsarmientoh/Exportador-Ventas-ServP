namespace Exportador_Ventas_ServP
{
    partial class ExportadorContingencia
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportadorContingencia));
            this.label1 = new System.Windows.Forms.Label();
            this.GridVentasCargadas = new System.Windows.Forms.DataGridView();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiqueteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilometrajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventaVOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.dialogoGuardar = new System.Windows.Forms.SaveFileDialog();
            this.frameAdicionar = new System.Windows.Forms.GroupBox();
            this.chkPlus = new System.Windows.Forms.CheckBox();
            this.cmdRecargarCliente = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.clienteVOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTiquete = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdHabilitarAdicion = new System.Windows.Forms.Button();
            this.frameTurno = new System.Windows.Forms.GroupBox();
            this.fechaDesdePicker = new System.Windows.Forms.DateTimePicker();
            this.cboEmpleados = new System.Windows.Forms.ComboBox();
            this.empleadoVOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTurno = new System.Windows.Forms.TextBox();
            this.txtIsla = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.frameAcciones = new System.Windows.Forms.GroupBox();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdCargarLecturas = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtLecFinDiesel = new System.Windows.Forms.TextBox();
            this.txtLecIniDiesel = new System.Windows.Forms.TextBox();
            this.txtLecFinSuper = new System.Windows.Forms.TextBox();
            this.txtLecIniSuper = new System.Windows.Forms.TextBox();
            this.txtLecFinCorriente = new System.Windows.Forms.TextBox();
            this.txtLecIniCorriente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.txtSodexo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBigpass = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCreditos = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtOtros = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTotalVentas = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtTicketTronik = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTarjetas = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTarjetaPlus = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cierreWorker = new System.ComponentModel.BackgroundWorker();
            this.consultaWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.GridVentasCargadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaVOBindingSource)).BeginInit();
            this.frameAdicionar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteVOBindingSource)).BeginInit();
            this.frameTurno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoVOBindingSource)).BeginInit();
            this.frameAcciones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha:  Desde";
            // 
            // GridVentasCargadas
            // 
            this.GridVentasCargadas.AutoGenerateColumns = false;
            this.GridVentasCargadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridVentasCargadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaDataGridViewTextBoxColumn,
            this.nitDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.productoDataGridViewTextBoxColumn,
            this.tiqueteDataGridViewTextBoxColumn,
            this.placaDataGridViewTextBoxColumn,
            this.kilometrajeDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.islaDataGridViewTextBoxColumn,
            this.turnoDataGridViewTextBoxColumn});
            this.GridVentasCargadas.DataSource = this.ventaVOBindingSource;
            this.GridVentasCargadas.Location = new System.Drawing.Point(32, 288);
            this.GridVentasCargadas.Name = "GridVentasCargadas";
            this.GridVentasCargadas.Size = new System.Drawing.Size(773, 258);
            this.GridVentasCargadas.TabIndex = 8;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // nitDataGridViewTextBoxColumn
            // 
            this.nitDataGridViewTextBoxColumn.DataPropertyName = "Nit";
            this.nitDataGridViewTextBoxColumn.HeaderText = "Nit";
            this.nitDataGridViewTextBoxColumn.Name = "nitDataGridViewTextBoxColumn";
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            // 
            // productoDataGridViewTextBoxColumn
            // 
            this.productoDataGridViewTextBoxColumn.DataPropertyName = "Producto";
            this.productoDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.productoDataGridViewTextBoxColumn.Name = "productoDataGridViewTextBoxColumn";
            // 
            // tiqueteDataGridViewTextBoxColumn
            // 
            this.tiqueteDataGridViewTextBoxColumn.DataPropertyName = "Tiquete";
            this.tiqueteDataGridViewTextBoxColumn.HeaderText = "Tiquete";
            this.tiqueteDataGridViewTextBoxColumn.Name = "tiqueteDataGridViewTextBoxColumn";
            // 
            // placaDataGridViewTextBoxColumn
            // 
            this.placaDataGridViewTextBoxColumn.DataPropertyName = "Placa";
            this.placaDataGridViewTextBoxColumn.HeaderText = "Placa";
            this.placaDataGridViewTextBoxColumn.Name = "placaDataGridViewTextBoxColumn";
            // 
            // kilometrajeDataGridViewTextBoxColumn
            // 
            this.kilometrajeDataGridViewTextBoxColumn.DataPropertyName = "Kilometraje";
            this.kilometrajeDataGridViewTextBoxColumn.HeaderText = "Kilometraje";
            this.kilometrajeDataGridViewTextBoxColumn.Name = "kilometrajeDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // islaDataGridViewTextBoxColumn
            // 
            this.islaDataGridViewTextBoxColumn.DataPropertyName = "Isla";
            this.islaDataGridViewTextBoxColumn.HeaderText = "Isla";
            this.islaDataGridViewTextBoxColumn.Name = "islaDataGridViewTextBoxColumn";
            // 
            // turnoDataGridViewTextBoxColumn
            // 
            this.turnoDataGridViewTextBoxColumn.DataPropertyName = "Turno";
            this.turnoDataGridViewTextBoxColumn.HeaderText = "Turno";
            this.turnoDataGridViewTextBoxColumn.Name = "turnoDataGridViewTextBoxColumn";
            // 
            // ventaVOBindingSource
            // 
            this.ventaVOBindingSource.DataSource = typeof(EstacionDB.VO.VentaVO);
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Location = new System.Drawing.Point(670, 25);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(82, 23);
            this.cmdConsultar.TabIndex = 6;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // frameAdicionar
            // 
            this.frameAdicionar.Controls.Add(this.chkPlus);
            this.frameAdicionar.Controls.Add(this.cmdRecargarCliente);
            this.frameAdicionar.Controls.Add(this.label7);
            this.frameAdicionar.Controls.Add(this.cboCliente);
            this.frameAdicionar.Controls.Add(this.txtPlaca);
            this.frameAdicionar.Controls.Add(this.label6);
            this.frameAdicionar.Controls.Add(this.cmdLimpiar);
            this.frameAdicionar.Controls.Add(this.cmdAgregar);
            this.frameAdicionar.Controls.Add(this.txtNombre);
            this.frameAdicionar.Controls.Add(this.txtId);
            this.frameAdicionar.Controls.Add(this.txtTiquete);
            this.frameAdicionar.Controls.Add(this.label5);
            this.frameAdicionar.Controls.Add(this.label4);
            this.frameAdicionar.Controls.Add(this.label3);
            this.frameAdicionar.Location = new System.Drawing.Point(32, 87);
            this.frameAdicionar.Name = "frameAdicionar";
            this.frameAdicionar.Size = new System.Drawing.Size(453, 189);
            this.frameAdicionar.TabIndex = 12;
            this.frameAdicionar.TabStop = false;
            this.frameAdicionar.Text = "Datos de la venta a agregar";
            // 
            // chkPlus
            // 
            this.chkPlus.AutoSize = true;
            this.chkPlus.Location = new System.Drawing.Point(299, 27);
            this.chkPlus.Name = "chkPlus";
            this.chkPlus.Size = new System.Drawing.Size(82, 17);
            this.chkPlus.TabIndex = 8;
            this.chkPlus.Text = "Tarjeta Plus";
            this.chkPlus.UseVisualStyleBackColor = true;
            // 
            // cmdRecargarCliente
            // 
            this.cmdRecargarCliente.Image = global::Exportador_Ventas_ServP.Properties.Resources.refresh_hov;
            this.cmdRecargarCliente.Location = new System.Drawing.Point(296, 58);
            this.cmdRecargarCliente.Name = "cmdRecargarCliente";
            this.cmdRecargarCliente.Size = new System.Drawing.Size(22, 23);
            this.cmdRecargarCliente.TabIndex = 50;
            this.cmdRecargarCliente.UseVisualStyleBackColor = true;
            this.cmdRecargarCliente.Click += new System.EventHandler(this.cmdRecargarCliente_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cliente";
            // 
            // cboCliente
            // 
            this.cboCliente.DataSource = this.clienteVOBindingSource;
            this.cboCliente.DisplayMember = "Nombre";
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(151, 59);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(143, 21);
            this.cboCliente.TabIndex = 9;
            this.cboCliente.ValueMember = "Identificacion";
            this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.cboCliente_SelectedIndexChanged);
            // 
            // clienteVOBindingSource
            // 
            this.clienteVOBindingSource.DataSource = typeof(EstacionDB.VO.ClienteVO);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(152, 151);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(142, 20);
            this.txtPlaca.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Placa";
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Image = global::Exportador_Ventas_ServP.Properties.Resources.del_hover;
            this.cmdLimpiar.Location = new System.Drawing.Point(388, 83);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(36, 30);
            this.cmdLimpiar.TabIndex = 12;
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Image = global::Exportador_Ventas_ServP.Properties.Resources.add_hover;
            this.cmdAgregar.Location = new System.Drawing.Point(388, 29);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(35, 31);
            this.cmdAgregar.TabIndex = 11;
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(152, 123);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(142, 20);
            this.txtNombre.TabIndex = 49;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(152, 92);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(141, 20);
            this.txtId.TabIndex = 48;
            // 
            // txtTiquete
            // 
            this.txtTiquete.Location = new System.Drawing.Point(151, 25);
            this.txtTiquete.Name = "txtTiquete";
            this.txtTiquete.Size = new System.Drawing.Size(142, 20);
            this.txtTiquete.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre del cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Identificación cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Número de Tiquete";
            // 
            // cmdHabilitarAdicion
            // 
            this.cmdHabilitarAdicion.Location = new System.Drawing.Point(61, 22);
            this.cmdHabilitarAdicion.Name = "cmdHabilitarAdicion";
            this.cmdHabilitarAdicion.Size = new System.Drawing.Size(91, 26);
            this.cmdHabilitarAdicion.TabIndex = 13;
            this.cmdHabilitarAdicion.Text = "Agregar venta";
            this.cmdHabilitarAdicion.UseVisualStyleBackColor = true;
            this.cmdHabilitarAdicion.Click += new System.EventHandler(this.cmdHabilitarAdicion_Click);
            // 
            // frameTurno
            // 
            this.frameTurno.Controls.Add(this.fechaDesdePicker);
            this.frameTurno.Controls.Add(this.cboEmpleados);
            this.frameTurno.Controls.Add(this.txtTurno);
            this.frameTurno.Controls.Add(this.cmdConsultar);
            this.frameTurno.Controls.Add(this.txtIsla);
            this.frameTurno.Controls.Add(this.label10);
            this.frameTurno.Controls.Add(this.label9);
            this.frameTurno.Controls.Add(this.label8);
            this.frameTurno.Controls.Add(this.label1);
            this.frameTurno.Location = new System.Drawing.Point(33, 15);
            this.frameTurno.Name = "frameTurno";
            this.frameTurno.Size = new System.Drawing.Size(770, 64);
            this.frameTurno.TabIndex = 14;
            this.frameTurno.TabStop = false;
            this.frameTurno.Text = "Datos de la consulta";
            // 
            // fechaDesdePicker
            // 
            this.fechaDesdePicker.Location = new System.Drawing.Point(507, 26);
            this.fechaDesdePicker.Name = "fechaDesdePicker";
            this.fechaDesdePicker.Size = new System.Drawing.Size(158, 20);
            this.fechaDesdePicker.TabIndex = 8;
            // 
            // cboEmpleados
            // 
            this.cboEmpleados.DataSource = this.empleadoVOBindingSource;
            this.cboEmpleados.DisplayMember = "Nombre";
            this.cboEmpleados.FormattingEnabled = true;
            this.cboEmpleados.Location = new System.Drawing.Point(96, 24);
            this.cboEmpleados.Name = "cboEmpleados";
            this.cboEmpleados.Size = new System.Drawing.Size(126, 21);
            this.cboEmpleados.TabIndex = 7;
            this.cboEmpleados.ValueMember = "Id";
            // 
            // empleadoVOBindingSource
            // 
            this.empleadoVOBindingSource.DataSource = typeof(EstacionDB.VO.EmpleadoVO);
            this.empleadoVOBindingSource.Sort = "Nombre";
            // 
            // txtTurno
            // 
            this.txtTurno.Location = new System.Drawing.Point(265, 25);
            this.txtTurno.Name = "txtTurno";
            this.txtTurno.Size = new System.Drawing.Size(56, 20);
            this.txtTurno.TabIndex = 2;
            // 
            // txtIsla
            // 
            this.txtIsla.Location = new System.Drawing.Point(356, 25);
            this.txtIsla.Name = "txtIsla";
            this.txtIsla.Size = new System.Drawing.Size(56, 20);
            this.txtIsla.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(325, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Isla";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(222, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Turno";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Cod. Empleado";
            // 
            // frameAcciones
            // 
            this.frameAcciones.Controls.Add(this.cmdGuardar);
            this.frameAcciones.Controls.Add(this.cmdHabilitarAdicion);
            this.frameAcciones.Location = new System.Drawing.Point(507, 89);
            this.frameAcciones.Name = "frameAcciones";
            this.frameAcciones.Size = new System.Drawing.Size(298, 59);
            this.frameAcciones.TabIndex = 15;
            this.frameAcciones.TabStop = false;
            this.frameAcciones.Text = "Acciones";
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Location = new System.Drawing.Point(164, 22);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(87, 26);
            this.cmdGuardar.TabIndex = 14;
            this.cmdGuardar.Text = "Cerrar Turno";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdCargarLecturas);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txtLecFinDiesel);
            this.groupBox1.Controls.Add(this.txtLecIniDiesel);
            this.groupBox1.Controls.Add(this.txtLecFinSuper);
            this.groupBox1.Controls.Add(this.txtLecIniSuper);
            this.groupBox1.Controls.Add(this.txtLecFinCorriente);
            this.groupBox1.Controls.Add(this.txtLecIniCorriente);
            this.groupBox1.Location = new System.Drawing.Point(507, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 124);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lecturas";
            // 
            // cmdCargarLecturas
            // 
            this.cmdCargarLecturas.Image = global::Exportador_Ventas_ServP.Properties.Resources.refresh_hov;
            this.cmdCargarLecturas.Location = new System.Drawing.Point(257, 96);
            this.cmdCargarLecturas.Name = "cmdCargarLecturas";
            this.cmdCargarLecturas.Size = new System.Drawing.Size(29, 23);
            this.cmdCargarLecturas.TabIndex = 9;
            this.cmdCargarLecturas.UseVisualStyleBackColor = true;
            this.cmdCargarLecturas.Click += new System.EventHandler(this.cmdCargarLecturas_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(15, 73);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(36, 13);
            this.label22.TabIndex = 8;
            this.label22.Text = "Diesel";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(15, 50);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 13);
            this.label21.TabIndex = 7;
            this.label21.Text = "Super";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(15, 23);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 13);
            this.label20.TabIndex = 6;
            this.label20.Text = "Corriente";
            // 
            // txtLecFinDiesel
            // 
            this.txtLecFinDiesel.Location = new System.Drawing.Point(187, 72);
            this.txtLecFinDiesel.Name = "txtLecFinDiesel";
            this.txtLecFinDiesel.Size = new System.Drawing.Size(100, 20);
            this.txtLecFinDiesel.TabIndex = 5;
            // 
            // txtLecIniDiesel
            // 
            this.txtLecIniDiesel.Location = new System.Drawing.Point(83, 72);
            this.txtLecIniDiesel.Name = "txtLecIniDiesel";
            this.txtLecIniDiesel.Size = new System.Drawing.Size(100, 20);
            this.txtLecIniDiesel.TabIndex = 4;
            // 
            // txtLecFinSuper
            // 
            this.txtLecFinSuper.Location = new System.Drawing.Point(187, 47);
            this.txtLecFinSuper.Name = "txtLecFinSuper";
            this.txtLecFinSuper.Size = new System.Drawing.Size(100, 20);
            this.txtLecFinSuper.TabIndex = 3;
            // 
            // txtLecIniSuper
            // 
            this.txtLecIniSuper.Location = new System.Drawing.Point(83, 47);
            this.txtLecIniSuper.Name = "txtLecIniSuper";
            this.txtLecIniSuper.Size = new System.Drawing.Size(100, 20);
            this.txtLecIniSuper.TabIndex = 2;
            // 
            // txtLecFinCorriente
            // 
            this.txtLecFinCorriente.Location = new System.Drawing.Point(187, 22);
            this.txtLecFinCorriente.Name = "txtLecFinCorriente";
            this.txtLecFinCorriente.Size = new System.Drawing.Size(100, 20);
            this.txtLecFinCorriente.TabIndex = 1;
            // 
            // txtLecIniCorriente
            // 
            this.txtLecIniCorriente.Location = new System.Drawing.Point(83, 22);
            this.txtLecIniCorriente.Name = "txtLecIniCorriente";
            this.txtLecIniCorriente.Size = new System.Drawing.Size(100, 20);
            this.txtLecIniCorriente.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 583);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 170;
            this.label2.Text = "Efectivo";
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Location = new System.Drawing.Point(135, 579);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(141, 20);
            this.txtEfectivo.TabIndex = 18;
            this.txtEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEfectivo.Leave += new System.EventHandler(this.txtEfectivo_Leave);
            this.txtEfectivo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtEfectivo_MouseClick);
            this.txtEfectivo.Enter += new System.EventHandler(this.txtEfectivo_Enter);
            // 
            // txtSodexo
            // 
            this.txtSodexo.Location = new System.Drawing.Point(103, 80);
            this.txtSodexo.Name = "txtSodexo";
            this.txtSodexo.Size = new System.Drawing.Size(141, 20);
            this.txtSodexo.TabIndex = 20;
            this.txtSodexo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSodexo.Leave += new System.EventHandler(this.txtSodexo_Leave);
            this.txtSodexo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSodexo_MouseClick);
            this.txtSodexo.Enter += new System.EventHandler(this.txtSodexo_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 172;
            this.label11.Text = "Sodexho";
            // 
            // txtBigpass
            // 
            this.txtBigpass.Location = new System.Drawing.Point(103, 111);
            this.txtBigpass.Name = "txtBigpass";
            this.txtBigpass.Size = new System.Drawing.Size(141, 20);
            this.txtBigpass.TabIndex = 21;
            this.txtBigpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBigpass.Leave += new System.EventHandler(this.txtBigpass_Leave);
            this.txtBigpass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBigpass_MouseClick);
            this.txtBigpass.Enter += new System.EventHandler(this.txtBigpass_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 174;
            this.label12.Text = "Big Pass";
            // 
            // txtCreditos
            // 
            this.txtCreditos.Location = new System.Drawing.Point(391, 578);
            this.txtCreditos.Name = "txtCreditos";
            this.txtCreditos.ReadOnly = true;
            this.txtCreditos.Size = new System.Drawing.Size(141, 20);
            this.txtCreditos.TabIndex = 210;
            this.txtCreditos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCreditos.Leave += new System.EventHandler(this.txtCreditos_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(320, 581);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 171;
            this.label13.Text = "Créditos";
            // 
            // txtOtros
            // 
            this.txtOtros.Location = new System.Drawing.Point(360, 80);
            this.txtOtros.Name = "txtOtros";
            this.txtOtros.Size = new System.Drawing.Size(141, 20);
            this.txtOtros.TabIndex = 23;
            this.txtOtros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOtros.Leave += new System.EventHandler(this.txtOtros_Leave);
            this.txtOtros.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtOtros_MouseClick);
            this.txtOtros.Enter += new System.EventHandler(this.txtOtros_Enter);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(288, 83);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 173;
            this.label14.Text = "Otros";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(597, 52);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(141, 20);
            this.txtTotal.TabIndex = 28;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(530, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 176;
            this.label15.Text = "TOTAL";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTotalVentas);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.txtTicketTronik);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtTarjetas);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtTarjetaPlus);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtOtros);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtBigpass);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtSodexo);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(32, 560);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(777, 145);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Totales";
            // 
            // txtTotalVentas
            // 
            this.txtTotalVentas.Location = new System.Drawing.Point(597, 91);
            this.txtTotalVentas.Name = "txtTotalVentas";
            this.txtTotalVentas.ReadOnly = true;
            this.txtTotalVentas.Size = new System.Drawing.Size(141, 20);
            this.txtTotalVentas.TabIndex = 184;
            this.txtTotalVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(531, 96);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 13);
            this.label19.TabIndex = 183;
            this.label19.Text = "VENTAS";
            // 
            // txtTicketTronik
            // 
            this.txtTicketTronik.Location = new System.Drawing.Point(361, 110);
            this.txtTicketTronik.Name = "txtTicketTronik";
            this.txtTicketTronik.Size = new System.Drawing.Size(141, 20);
            this.txtTicketTronik.TabIndex = 181;
            this.txtTicketTronik.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTicketTronik.Leave += new System.EventHandler(this.txtTicketTronik_Leave);
            this.txtTicketTronik.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTicketTronik_MouseClick);
            this.txtTicketTronik.Enter += new System.EventHandler(this.txtTicketTronik_Enter);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(289, 113);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 13);
            this.label18.TabIndex = 182;
            this.label18.Text = "Ticket Prom";
            // 
            // txtTarjetas
            // 
            this.txtTarjetas.Location = new System.Drawing.Point(360, 51);
            this.txtTarjetas.Name = "txtTarjetas";
            this.txtTarjetas.Size = new System.Drawing.Size(141, 20);
            this.txtTarjetas.TabIndex = 22;
            this.txtTarjetas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTarjetas.Leave += new System.EventHandler(this.txtTarjetas_Leave);
            this.txtTarjetas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTarjetas_MouseClick);
            this.txtTarjetas.Enter += new System.EventHandler(this.txtTarjetas_Enter);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(288, 54);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 13);
            this.label16.TabIndex = 180;
            this.label16.Text = "Tarjetas";
            // 
            // txtTarjetaPlus
            // 
            this.txtTarjetaPlus.Location = new System.Drawing.Point(103, 51);
            this.txtTarjetaPlus.Name = "txtTarjetaPlus";
            this.txtTarjetaPlus.ReadOnly = true;
            this.txtTarjetaPlus.Size = new System.Drawing.Size(141, 20);
            this.txtTarjetaPlus.TabIndex = 19;
            this.txtTarjetaPlus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTarjetaPlus.Enter += new System.EventHandler(this.txtTarjetaPlus_Enter);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(37, 55);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 13);
            this.label17.TabIndex = 179;
            this.label17.Text = "Tarjeta Plus";
            // 
            // cierreWorker
            // 
            this.cierreWorker.WorkerReportsProgress = true;
            this.cierreWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.cierreWorker_DoWork);
            // 
            // consultaWorker
            // 
            this.consultaWorker.WorkerReportsProgress = true;
            // 
            // ExportadorContingencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 716);
            this.Controls.Add(this.txtCreditos);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtEfectivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GridVentasCargadas);
            this.Controls.Add(this.frameAdicionar);
            this.Controls.Add(this.frameTurno);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.frameAcciones);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ExportadorContingencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro diario [Ventas]";
            this.Load += new System.EventHandler(this.Exportador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridVentasCargadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaVOBindingSource)).EndInit();
            this.frameAdicionar.ResumeLayout(false);
            this.frameAdicionar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteVOBindingSource)).EndInit();
            this.frameTurno.ResumeLayout(false);
            this.frameTurno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoVOBindingSource)).EndInit();
            this.frameAcciones.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridVentasCargadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiqueteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilometrajeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn islaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ventaVOBindingSource;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.SaveFileDialog dialogoGuardar;
        private System.Windows.Forms.GroupBox frameAdicionar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTiquete;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.Button cmdHabilitarAdicion;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.BindingSource clienteVOBindingSource;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox frameTurno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTurno;
        private System.Windows.Forms.TextBox txtIsla;
        private System.Windows.Forms.GroupBox frameAcciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdRecargarCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.TextBox txtSodexo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBigpass;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCreditos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtOtros;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboEmpleados;
        private System.Windows.Forms.BindingSource empleadoVOBindingSource;
        private System.Windows.Forms.TextBox txtTarjetas;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTarjetaPlus;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox chkPlus;
        private System.Windows.Forms.TextBox txtTicketTronik;
        private System.Windows.Forms.Label label18;
        private System.ComponentModel.BackgroundWorker cierreWorker;
        private System.ComponentModel.BackgroundWorker consultaWorker;
        private System.Windows.Forms.TextBox txtTotalVentas;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker fechaDesdePicker;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtLecFinDiesel;
        private System.Windows.Forms.TextBox txtLecIniDiesel;
        private System.Windows.Forms.TextBox txtLecFinSuper;
        private System.Windows.Forms.TextBox txtLecIniSuper;
        private System.Windows.Forms.TextBox txtLecFinCorriente;
        private System.Windows.Forms.TextBox txtLecIniCorriente;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button cmdCargarLecturas;
    }
}

