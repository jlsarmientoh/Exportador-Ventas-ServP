namespace Exportador_Ventas_ServP
{
    partial class ComprasCombustible
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComprasCombustible));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.txtSoldicom = new System.Windows.Forms.TextBox();
            this.txtFlete = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.txtGalones = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.productoVOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productoVOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.galonesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fleteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soldicomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impuestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compraCombustibleVOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoVOBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoVOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraCombustibleVOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtImpuesto);
            this.groupBox1.Controls.Add(this.txtSoldicom);
            this.groupBox1.Controls.Add(this.txtFlete);
            this.groupBox1.Controls.Add(this.txtValorTotal);
            this.groupBox1.Controls.Add(this.txtValorUnitario);
            this.groupBox1.Controls.Add(this.txtGalones);
            this.groupBox1.Location = new System.Drawing.Point(16, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 171);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(258, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Impuesto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(257, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Soldicom";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Flete";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Valor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Valor unitario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Galones";
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Location = new System.Drawing.Point(316, 120);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(100, 20);
            this.txtImpuesto.TabIndex = 9;
            this.txtImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtImpuesto.Leave += new System.EventHandler(this.txtImpuesto_Leave);
            this.txtImpuesto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtImpuesto_MouseClick);
            this.txtImpuesto.Enter += new System.EventHandler(this.txtImpuesto_Enter);
            // 
            // txtSoldicom
            // 
            this.txtSoldicom.Location = new System.Drawing.Point(316, 83);
            this.txtSoldicom.Name = "txtSoldicom";
            this.txtSoldicom.Size = new System.Drawing.Size(100, 20);
            this.txtSoldicom.TabIndex = 8;
            this.txtSoldicom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSoldicom.Leave += new System.EventHandler(this.txtSoldicom_Leave);
            this.txtSoldicom.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSoldicom_MouseClick);
            this.txtSoldicom.Enter += new System.EventHandler(this.txtSoldicom_Enter);
            // 
            // txtFlete
            // 
            this.txtFlete.Location = new System.Drawing.Point(316, 41);
            this.txtFlete.Name = "txtFlete";
            this.txtFlete.Size = new System.Drawing.Size(100, 20);
            this.txtFlete.TabIndex = 7;
            this.txtFlete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFlete.Leave += new System.EventHandler(this.txtFlete_Leave);
            this.txtFlete.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtFlete_MouseClick);
            this.txtFlete.Enter += new System.EventHandler(this.txtFlete_Enter);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(116, 119);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(100, 20);
            this.txtValorTotal.TabIndex = 6;
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorTotal.Leave += new System.EventHandler(this.txtValorTotal_Leave);
            this.txtValorTotal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtValorTotal_MouseClick);
            this.txtValorTotal.Enter += new System.EventHandler(this.txtValorTotal_Enter);
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Location = new System.Drawing.Point(116, 79);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(100, 20);
            this.txtValorUnitario.TabIndex = 5;
            this.txtValorUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorUnitario.Leave += new System.EventHandler(this.txtValorUnitario_Leave);
            this.txtValorUnitario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtValorUnitario_MouseClick);
            this.txtValorUnitario.Enter += new System.EventHandler(this.txtValorUnitario_Enter);
            // 
            // txtGalones
            // 
            this.txtGalones.Location = new System.Drawing.Point(116, 39);
            this.txtGalones.Name = "txtGalones";
            this.txtGalones.Size = new System.Drawing.Size(100, 20);
            this.txtGalones.TabIndex = 4;
            this.txtGalones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGalones.Leave += new System.EventHandler(this.txtGalones_Leave);
            this.txtGalones.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtGalones_MouseClick);
            this.txtGalones.Enter += new System.EventHandler(this.txtGalones_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdBuscar);
            this.groupBox2.Controls.Add(this.cboProducto);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtFactura);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtFecha);
            this.groupBox2.Location = new System.Drawing.Point(16, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(718, 100);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de la compra";
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Image = global::Exportador_Ventas_ServP.Properties.Resources.search;
            this.cmdBuscar.Location = new System.Drawing.Point(245, 39);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(26, 23);
            this.cmdBuscar.TabIndex = 11;
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // cboProducto
            // 
            this.cboProducto.DataSource = this.productoVOBindingSource;
            this.cboProducto.DisplayMember = "Nombre";
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(517, 40);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(158, 21);
            this.cboProducto.TabIndex = 3;
            this.cboProducto.ValueMember = "IdProducto";
            // 
            // productoVOBindingSource
            // 
            this.productoVOBindingSource.DataSource = typeof(EstacionDB.VO.ProductoVO);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Producto";
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(341, 41);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(100, 20);
            this.txtFactura.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Factura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha de compra";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(142, 41);
            this.txtFecha.Mask = "00/00/0000";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(99, 20);
            this.txtFecha.TabIndex = 1;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmdGuardar);
            this.groupBox3.Controls.Add(this.cmdLimpiar);
            this.groupBox3.Controls.Add(this.cmdAgregar);
            this.groupBox3.Location = new System.Drawing.Point(489, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 171);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Acciones";
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Location = new System.Drawing.Point(129, 76);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(75, 28);
            this.cmdGuardar.TabIndex = 15;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click_1);
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Image = global::Exportador_Ventas_ServP.Properties.Resources.del_hover;
            this.cmdLimpiar.Location = new System.Drawing.Point(46, 100);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(36, 30);
            this.cmdLimpiar.TabIndex = 14;
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Image = global::Exportador_Ventas_ServP.Properties.Resources.add_hover;
            this.cmdAgregar.Location = new System.Drawing.Point(46, 46);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(35, 31);
            this.cmdAgregar.TabIndex = 13;
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaDataGridViewTextBoxColumn,
            this.facturaDataGridViewTextBoxColumn,
            this.idProductoDataGridViewTextBoxColumn,
            this.galonesDataGridViewTextBoxColumn,
            this.valorUnitarioDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.fleteDataGridViewTextBoxColumn,
            this.soldicomDataGridViewTextBoxColumn,
            this.impuestoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.compraCombustibleVOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 321);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(719, 178);
            this.dataGridView1.TabIndex = 21;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.Width = 62;
            // 
            // facturaDataGridViewTextBoxColumn
            // 
            this.facturaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.facturaDataGridViewTextBoxColumn.DataPropertyName = "Factura";
            this.facturaDataGridViewTextBoxColumn.HeaderText = "Factura";
            this.facturaDataGridViewTextBoxColumn.Name = "facturaDataGridViewTextBoxColumn";
            this.facturaDataGridViewTextBoxColumn.Width = 68;
            // 
            // idProductoDataGridViewTextBoxColumn
            // 
            this.idProductoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idProductoDataGridViewTextBoxColumn.DataPropertyName = "IdProducto";
            this.idProductoDataGridViewTextBoxColumn.DataSource = this.productoVOBindingSource1;
            this.idProductoDataGridViewTextBoxColumn.DisplayMember = "Nombre";
            this.idProductoDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
            this.idProductoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idProductoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idProductoDataGridViewTextBoxColumn.ValueMember = "IdProducto";
            this.idProductoDataGridViewTextBoxColumn.Width = 75;
            // 
            // productoVOBindingSource1
            // 
            this.productoVOBindingSource1.DataSource = typeof(EstacionDB.VO.ProductoVO);
            // 
            // galonesDataGridViewTextBoxColumn
            // 
            this.galonesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.galonesDataGridViewTextBoxColumn.DataPropertyName = "Galones";
            this.galonesDataGridViewTextBoxColumn.HeaderText = "Galones";
            this.galonesDataGridViewTextBoxColumn.Name = "galonesDataGridViewTextBoxColumn";
            this.galonesDataGridViewTextBoxColumn.Width = 71;
            // 
            // valorUnitarioDataGridViewTextBoxColumn
            // 
            this.valorUnitarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.valorUnitarioDataGridViewTextBoxColumn.DataPropertyName = "ValorUnitario";
            this.valorUnitarioDataGridViewTextBoxColumn.HeaderText = "ValorUnitario";
            this.valorUnitarioDataGridViewTextBoxColumn.Name = "valorUnitarioDataGridViewTextBoxColumn";
            this.valorUnitarioDataGridViewTextBoxColumn.Width = 92;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.Width = 56;
            // 
            // fleteDataGridViewTextBoxColumn
            // 
            this.fleteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fleteDataGridViewTextBoxColumn.DataPropertyName = "Flete";
            this.fleteDataGridViewTextBoxColumn.HeaderText = "Flete";
            this.fleteDataGridViewTextBoxColumn.Name = "fleteDataGridViewTextBoxColumn";
            this.fleteDataGridViewTextBoxColumn.Width = 55;
            // 
            // soldicomDataGridViewTextBoxColumn
            // 
            this.soldicomDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.soldicomDataGridViewTextBoxColumn.DataPropertyName = "Soldicom";
            this.soldicomDataGridViewTextBoxColumn.HeaderText = "Soldicom";
            this.soldicomDataGridViewTextBoxColumn.Name = "soldicomDataGridViewTextBoxColumn";
            this.soldicomDataGridViewTextBoxColumn.Width = 75;
            // 
            // impuestoDataGridViewTextBoxColumn
            // 
            this.impuestoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.impuestoDataGridViewTextBoxColumn.DataPropertyName = "Impuesto";
            this.impuestoDataGridViewTextBoxColumn.HeaderText = "Impuesto";
            this.impuestoDataGridViewTextBoxColumn.Name = "impuestoDataGridViewTextBoxColumn";
            this.impuestoDataGridViewTextBoxColumn.Width = 75;
            // 
            // compraCombustibleVOBindingSource
            // 
            this.compraCombustibleVOBindingSource.DataSource = typeof(EstacionDB.VO.CompraCombustibleVO);
            // 
            // ComprasCombustible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 510);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ComprasCombustible";
            this.Text = "Inventario de combustible";
            this.Load += new System.EventHandler(this.ComprasCombustible_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ComprasCombustible_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoVOBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoVOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraCombustibleVOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource productoVOBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.TextBox txtSoldicom;
        private System.Windows.Forms.TextBox txtFlete;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.TextBox txtGalones;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtFecha;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource productoVOBindingSource1;
        private System.Windows.Forms.BindingSource compraCombustibleVOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn galonesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fleteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soldicomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn impuestoDataGridViewTextBoxColumn;
    }
}