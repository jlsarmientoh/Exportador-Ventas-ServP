namespace Exportador_Ventas_ServP
{
    partial class SobreTasas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SobreTasas));
            this.label1 = new System.Windows.Forms.Label();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.productoVOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtFechaDesde = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFechaHasta = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioBase = new System.Windows.Forms.TextBox();
            this.txtFlete = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoldicom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSobretasa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gridSobretasa = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productoVOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.anioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaInicioVigenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaFinVigenicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioBaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fletesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soldicomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobretasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobretasaVOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmdNuevo = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productoVOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSobretasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoVOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobretasaVOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // cboProducto
            // 
            this.cboProducto.DataSource = this.productoVOBindingSource;
            this.cboProducto.DisplayMember = "Nombre";
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(100, 35);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(121, 21);
            this.cboProducto.TabIndex = 1;
            this.cboProducto.ValueMember = "IdProducto";
            // 
            // productoVOBindingSource
            // 
            this.productoVOBindingSource.DataSource = typeof(EstacionDB.VO.ProductoVO);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Desde";
            // 
            // txtFechaDesde
            // 
            this.txtFechaDesde.Location = new System.Drawing.Point(310, 35);
            this.txtFechaDesde.Mask = "00/00/0000";
            this.txtFechaDesde.Name = "txtFechaDesde";
            this.txtFechaDesde.Size = new System.Drawing.Size(100, 20);
            this.txtFechaDesde.TabIndex = 2;
            this.txtFechaDesde.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hasta";
            // 
            // txtFechaHasta
            // 
            this.txtFechaHasta.Location = new System.Drawing.Point(481, 34);
            this.txtFechaHasta.Mask = "00/00/0000";
            this.txtFechaHasta.Name = "txtFechaHasta";
            this.txtFechaHasta.Size = new System.Drawing.Size(100, 20);
            this.txtFechaHasta.TabIndex = 3;
            this.txtFechaHasta.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Precio base";
            // 
            // txtPrecioBase
            // 
            this.txtPrecioBase.Location = new System.Drawing.Point(136, 82);
            this.txtPrecioBase.Name = "txtPrecioBase";
            this.txtPrecioBase.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioBase.TabIndex = 4;
            this.txtPrecioBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecioBase.Leave += new System.EventHandler(this.txtPrecioBase_Leave);
            this.txtPrecioBase.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPrecioBase_MouseClick);
            this.txtPrecioBase.Enter += new System.EventHandler(this.txtPrecioBase_Enter);
            // 
            // txtFlete
            // 
            this.txtFlete.Location = new System.Drawing.Point(136, 122);
            this.txtFlete.Name = "txtFlete";
            this.txtFlete.Size = new System.Drawing.Size(100, 20);
            this.txtFlete.TabIndex = 5;
            this.txtFlete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFlete.Leave += new System.EventHandler(this.txtFlete_Leave);
            this.txtFlete.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtFlete_MouseClick);
            this.txtFlete.Enter += new System.EventHandler(this.txtFlete_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fletes";
            // 
            // txtSoldicom
            // 
            this.txtSoldicom.Location = new System.Drawing.Point(358, 83);
            this.txtSoldicom.Name = "txtSoldicom";
            this.txtSoldicom.Size = new System.Drawing.Size(100, 20);
            this.txtSoldicom.TabIndex = 6;
            this.txtSoldicom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSoldicom.Leave += new System.EventHandler(this.txtSoldicom_Leave);
            this.txtSoldicom.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSoldicom_MouseClick);
            this.txtSoldicom.Enter += new System.EventHandler(this.txtSoldicom_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Soldicom";
            // 
            // txtSobretasa
            // 
            this.txtSobretasa.Location = new System.Drawing.Point(358, 122);
            this.txtSobretasa.Name = "txtSobretasa";
            this.txtSobretasa.Size = new System.Drawing.Size(100, 20);
            this.txtSobretasa.TabIndex = 7;
            this.txtSobretasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSobretasa.Leave += new System.EventHandler(this.txtSobretasa_Leave);
            this.txtSobretasa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSobretasa_MouseClick);
            this.txtSobretasa.Enter += new System.EventHandler(this.txtSobretasa_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sobretasa";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(136, 161);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioVenta.TabIndex = 8;
            this.txtPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecioVenta.Leave += new System.EventHandler(this.txtPrecioVenta_Leave);
            this.txtPrecioVenta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPrecioVenta_MouseClick);
            this.txtPrecioVenta.Enter += new System.EventHandler(this.txtPrecioVenta_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Precio de venta";
            // 
            // gridSobretasa
            // 
            this.gridSobretasa.AllowUserToAddRows = false;
            this.gridSobretasa.AllowUserToDeleteRows = false;
            this.gridSobretasa.AutoGenerateColumns = false;
            this.gridSobretasa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridSobretasa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSobretasa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idProductoDataGridViewTextBoxColumn,
            this.anioDataGridViewTextBoxColumn,
            this.mesDataGridViewTextBoxColumn,
            this.diaInicioVigenciaDataGridViewTextBoxColumn,
            this.diaFinVigenicaDataGridViewTextBoxColumn,
            this.precioBaseDataGridViewTextBoxColumn,
            this.fletesDataGridViewTextBoxColumn,
            this.soldicomDataGridViewTextBoxColumn,
            this.sobretasaDataGridViewTextBoxColumn,
            this.ventaDataGridViewTextBoxColumn});
            this.gridSobretasa.DataSource = this.sobretasaVOBindingSource;
            this.gridSobretasa.Location = new System.Drawing.Point(20, 206);
            this.gridSobretasa.Name = "gridSobretasa";
            this.gridSobretasa.ReadOnly = true;
            this.gridSobretasa.Size = new System.Drawing.Size(687, 205);
            this.gridSobretasa.TabIndex = 11;
            this.gridSobretasa.SelectionChanged += new System.EventHandler(this.gridSobretasa_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 41;
            // 
            // idProductoDataGridViewTextBoxColumn
            // 
            this.idProductoDataGridViewTextBoxColumn.DataPropertyName = "IdProducto";
            this.idProductoDataGridViewTextBoxColumn.DataSource = this.productoVOBindingSource1;
            this.idProductoDataGridViewTextBoxColumn.DisplayMember = "Nombre";
            this.idProductoDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
            this.idProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProductoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idProductoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idProductoDataGridViewTextBoxColumn.ValueMember = "IdProducto";
            this.idProductoDataGridViewTextBoxColumn.Width = 75;
            // 
            // productoVOBindingSource1
            // 
            this.productoVOBindingSource1.DataSource = typeof(EstacionDB.VO.ProductoVO);
            // 
            // anioDataGridViewTextBoxColumn
            // 
            this.anioDataGridViewTextBoxColumn.DataPropertyName = "Anio";
            this.anioDataGridViewTextBoxColumn.HeaderText = "Año";
            this.anioDataGridViewTextBoxColumn.Name = "anioDataGridViewTextBoxColumn";
            this.anioDataGridViewTextBoxColumn.ReadOnly = true;
            this.anioDataGridViewTextBoxColumn.Width = 51;
            // 
            // mesDataGridViewTextBoxColumn
            // 
            this.mesDataGridViewTextBoxColumn.DataPropertyName = "Mes";
            this.mesDataGridViewTextBoxColumn.HeaderText = "Mes";
            this.mesDataGridViewTextBoxColumn.Name = "mesDataGridViewTextBoxColumn";
            this.mesDataGridViewTextBoxColumn.ReadOnly = true;
            this.mesDataGridViewTextBoxColumn.Width = 52;
            // 
            // diaInicioVigenciaDataGridViewTextBoxColumn
            // 
            this.diaInicioVigenciaDataGridViewTextBoxColumn.DataPropertyName = "DiaInicioVigencia";
            this.diaInicioVigenciaDataGridViewTextBoxColumn.HeaderText = "Dia Inicio Vigencia";
            this.diaInicioVigenciaDataGridViewTextBoxColumn.Name = "diaInicioVigenciaDataGridViewTextBoxColumn";
            this.diaInicioVigenciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.diaInicioVigenciaDataGridViewTextBoxColumn.Width = 110;
            // 
            // diaFinVigenicaDataGridViewTextBoxColumn
            // 
            this.diaFinVigenicaDataGridViewTextBoxColumn.DataPropertyName = "DiaFinVigenica";
            this.diaFinVigenicaDataGridViewTextBoxColumn.HeaderText = "Dia Fin Vigencia";
            this.diaFinVigenicaDataGridViewTextBoxColumn.Name = "diaFinVigenicaDataGridViewTextBoxColumn";
            this.diaFinVigenicaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioBaseDataGridViewTextBoxColumn
            // 
            this.precioBaseDataGridViewTextBoxColumn.DataPropertyName = "PrecioBase";
            this.precioBaseDataGridViewTextBoxColumn.HeaderText = "Precio Base";
            this.precioBaseDataGridViewTextBoxColumn.Name = "precioBaseDataGridViewTextBoxColumn";
            this.precioBaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioBaseDataGridViewTextBoxColumn.Width = 82;
            // 
            // fletesDataGridViewTextBoxColumn
            // 
            this.fletesDataGridViewTextBoxColumn.DataPropertyName = "Fletes";
            this.fletesDataGridViewTextBoxColumn.HeaderText = "Fletes";
            this.fletesDataGridViewTextBoxColumn.Name = "fletesDataGridViewTextBoxColumn";
            this.fletesDataGridViewTextBoxColumn.ReadOnly = true;
            this.fletesDataGridViewTextBoxColumn.Width = 60;
            // 
            // soldicomDataGridViewTextBoxColumn
            // 
            this.soldicomDataGridViewTextBoxColumn.DataPropertyName = "Soldicom";
            this.soldicomDataGridViewTextBoxColumn.HeaderText = "Soldicom";
            this.soldicomDataGridViewTextBoxColumn.Name = "soldicomDataGridViewTextBoxColumn";
            this.soldicomDataGridViewTextBoxColumn.ReadOnly = true;
            this.soldicomDataGridViewTextBoxColumn.Width = 75;
            // 
            // sobretasaDataGridViewTextBoxColumn
            // 
            this.sobretasaDataGridViewTextBoxColumn.DataPropertyName = "Sobretasa";
            this.sobretasaDataGridViewTextBoxColumn.HeaderText = "Sobretasa";
            this.sobretasaDataGridViewTextBoxColumn.Name = "sobretasaDataGridViewTextBoxColumn";
            this.sobretasaDataGridViewTextBoxColumn.ReadOnly = true;
            this.sobretasaDataGridViewTextBoxColumn.Width = 80;
            // 
            // ventaDataGridViewTextBoxColumn
            // 
            this.ventaDataGridViewTextBoxColumn.DataPropertyName = "Venta";
            this.ventaDataGridViewTextBoxColumn.HeaderText = "Venta";
            this.ventaDataGridViewTextBoxColumn.Name = "ventaDataGridViewTextBoxColumn";
            this.ventaDataGridViewTextBoxColumn.ReadOnly = true;
            this.ventaDataGridViewTextBoxColumn.Width = 60;
            // 
            // sobretasaVOBindingSource
            // 
            this.sobretasaVOBindingSource.DataSource = typeof(EstacionDB.VO.SobretasaVO);
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.Location = new System.Drawing.Point(577, 78);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(84, 29);
            this.cmdNuevo.TabIndex = 11;
            this.cmdNuevo.Text = "Nuevo";
            this.cmdNuevo.UseVisualStyleBackColor = true;
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(577, 159);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(84, 29);
            this.cmdCancelar.TabIndex = 10;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Location = new System.Drawing.Point(576, 117);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(84, 30);
            this.cmdGuardar.TabIndex = 9;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Image = global::Exportador_Ventas_ServP.Properties.Resources.search;
            this.cmdBuscar.Location = new System.Drawing.Point(602, 32);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(29, 24);
            this.cmdBuscar.TabIndex = 12;
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // SobreTasas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 435);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.gridSobretasa);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSobretasa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSoldicom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFlete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrecioBase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFechaHasta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFechaDesde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboProducto);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SobreTasas";
            this.Text = "SobreTasas";
            this.Load += new System.EventHandler(this.SobreTasas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productoVOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSobretasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoVOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobretasaVOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.BindingSource productoVOBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtFechaDesde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtFechaHasta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecioBase;
        private System.Windows.Forms.TextBox txtFlete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoldicom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSobretasa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView gridSobretasa;
        private System.Windows.Forms.BindingSource sobretasaVOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productoVOBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn anioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaInicioVigenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaFinVigenicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioBaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fletesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soldicomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobretasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button cmdNuevo;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdBuscar;
    }
}