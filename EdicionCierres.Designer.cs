namespace Exportador_Ventas_ServP
{
    partial class EdicionCierres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdicionCierres));
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idCierreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalVentasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efectivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bigPassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otrosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarjetasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarjetaPlusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketTronikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cierreVentasVOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCreditos = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTicketTronik = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTarjetas = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTarjetaPlus = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtOtros = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBigpass = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSodexo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalConsumo = new System.Windows.Forms.TextBox();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cierreVentasVOBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(85, 30);
            this.txtFecha.Mask = "00/00/0000";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 4;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCierreDataGridViewTextBoxColumn,
            this.totalVentasDataGridViewTextBoxColumn,
            this.islaDataGridViewTextBoxColumn,
            this.turnoDataGridViewTextBoxColumn,
            this.creditosDataGridViewTextBoxColumn,
            this.efectivoDataGridViewTextBoxColumn,
            this.sodexoDataGridViewTextBoxColumn,
            this.bigPassDataGridViewTextBoxColumn,
            this.otrosDataGridViewTextBoxColumn,
            this.tarjetasDataGridViewTextBoxColumn,
            this.tarjetaPlusDataGridViewTextBoxColumn,
            this.ticketTronikDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cierreVentasVOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(777, 183);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellLeave);
            this.dataGridView1.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowLeave);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // idCierreDataGridViewTextBoxColumn
            // 
            this.idCierreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idCierreDataGridViewTextBoxColumn.DataPropertyName = "IdCierre";
            this.idCierreDataGridViewTextBoxColumn.HeaderText = "Cierre";
            this.idCierreDataGridViewTextBoxColumn.Name = "idCierreDataGridViewTextBoxColumn";
            this.idCierreDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCierreDataGridViewTextBoxColumn.Width = 59;
            // 
            // totalVentasDataGridViewTextBoxColumn
            // 
            this.totalVentasDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.totalVentasDataGridViewTextBoxColumn.DataPropertyName = "TotalVentas";
            this.totalVentasDataGridViewTextBoxColumn.HeaderText = "TotalVentas";
            this.totalVentasDataGridViewTextBoxColumn.Name = "totalVentasDataGridViewTextBoxColumn";
            this.totalVentasDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalVentasDataGridViewTextBoxColumn.Width = 89;
            // 
            // islaDataGridViewTextBoxColumn
            // 
            this.islaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.islaDataGridViewTextBoxColumn.DataPropertyName = "Isla";
            this.islaDataGridViewTextBoxColumn.HeaderText = "Isla";
            this.islaDataGridViewTextBoxColumn.Name = "islaDataGridViewTextBoxColumn";
            this.islaDataGridViewTextBoxColumn.ReadOnly = true;
            this.islaDataGridViewTextBoxColumn.Width = 48;
            // 
            // turnoDataGridViewTextBoxColumn
            // 
            this.turnoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.turnoDataGridViewTextBoxColumn.DataPropertyName = "Turno";
            this.turnoDataGridViewTextBoxColumn.HeaderText = "Turno";
            this.turnoDataGridViewTextBoxColumn.Name = "turnoDataGridViewTextBoxColumn";
            this.turnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.turnoDataGridViewTextBoxColumn.Width = 60;
            // 
            // creditosDataGridViewTextBoxColumn
            // 
            this.creditosDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.creditosDataGridViewTextBoxColumn.DataPropertyName = "Creditos";
            this.creditosDataGridViewTextBoxColumn.HeaderText = "Creditos";
            this.creditosDataGridViewTextBoxColumn.Name = "creditosDataGridViewTextBoxColumn";
            this.creditosDataGridViewTextBoxColumn.Width = 70;
            // 
            // efectivoDataGridViewTextBoxColumn
            // 
            this.efectivoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.efectivoDataGridViewTextBoxColumn.DataPropertyName = "Efectivo";
            this.efectivoDataGridViewTextBoxColumn.HeaderText = "Efectivo";
            this.efectivoDataGridViewTextBoxColumn.Name = "efectivoDataGridViewTextBoxColumn";
            this.efectivoDataGridViewTextBoxColumn.Width = 71;
            // 
            // sodexoDataGridViewTextBoxColumn
            // 
            this.sodexoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sodexoDataGridViewTextBoxColumn.DataPropertyName = "Sodexo";
            this.sodexoDataGridViewTextBoxColumn.HeaderText = "Sodexo";
            this.sodexoDataGridViewTextBoxColumn.Name = "sodexoDataGridViewTextBoxColumn";
            this.sodexoDataGridViewTextBoxColumn.Width = 68;
            // 
            // bigPassDataGridViewTextBoxColumn
            // 
            this.bigPassDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.bigPassDataGridViewTextBoxColumn.DataPropertyName = "BigPass";
            this.bigPassDataGridViewTextBoxColumn.HeaderText = "BigPass";
            this.bigPassDataGridViewTextBoxColumn.Name = "bigPassDataGridViewTextBoxColumn";
            this.bigPassDataGridViewTextBoxColumn.Width = 70;
            // 
            // otrosDataGridViewTextBoxColumn
            // 
            this.otrosDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.otrosDataGridViewTextBoxColumn.DataPropertyName = "Otros";
            this.otrosDataGridViewTextBoxColumn.HeaderText = "Otros";
            this.otrosDataGridViewTextBoxColumn.Name = "otrosDataGridViewTextBoxColumn";
            this.otrosDataGridViewTextBoxColumn.Width = 57;
            // 
            // tarjetasDataGridViewTextBoxColumn
            // 
            this.tarjetasDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tarjetasDataGridViewTextBoxColumn.DataPropertyName = "Tarjetas";
            this.tarjetasDataGridViewTextBoxColumn.HeaderText = "Tarjetas";
            this.tarjetasDataGridViewTextBoxColumn.Name = "tarjetasDataGridViewTextBoxColumn";
            this.tarjetasDataGridViewTextBoxColumn.Width = 70;
            // 
            // tarjetaPlusDataGridViewTextBoxColumn
            // 
            this.tarjetaPlusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tarjetaPlusDataGridViewTextBoxColumn.DataPropertyName = "TarjetaPlus";
            this.tarjetaPlusDataGridViewTextBoxColumn.HeaderText = "TarjetaPlus";
            this.tarjetaPlusDataGridViewTextBoxColumn.Name = "tarjetaPlusDataGridViewTextBoxColumn";
            this.tarjetaPlusDataGridViewTextBoxColumn.Width = 85;
            // 
            // ticketTronikDataGridViewTextBoxColumn
            // 
            this.ticketTronikDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ticketTronikDataGridViewTextBoxColumn.DataPropertyName = "TicketTronik";
            this.ticketTronikDataGridViewTextBoxColumn.HeaderText = "TicketTronik";
            this.ticketTronikDataGridViewTextBoxColumn.Name = "ticketTronikDataGridViewTextBoxColumn";
            this.ticketTronikDataGridViewTextBoxColumn.Width = 92;
            // 
            // cierreVentasVOBindingSource
            // 
            this.cierreVentasVOBindingSource.DataSource = typeof(EstacionDB.VO.CierreVentasVO);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCreditos);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtEfectivo);
            this.groupBox2.Controls.Add(this.label2);
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
            this.groupBox2.Location = new System.Drawing.Point(29, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(777, 159);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Totales del día";
            // 
            // txtCreditos
            // 
            this.txtCreditos.Location = new System.Drawing.Point(359, 18);
            this.txtCreditos.Name = "txtCreditos";
            this.txtCreditos.ReadOnly = true;
            this.txtCreditos.Size = new System.Drawing.Size(141, 20);
            this.txtCreditos.TabIndex = 214;
            this.txtCreditos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCreditos.Leave += new System.EventHandler(this.txtCreditos_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(288, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 213;
            this.label13.Text = "Créditos";
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Location = new System.Drawing.Point(103, 19);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.ReadOnly = true;
            this.txtEfectivo.Size = new System.Drawing.Size(141, 20);
            this.txtEfectivo.TabIndex = 211;
            this.txtEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEfectivo.Leave += new System.EventHandler(this.txtEfectivo_Leave);
            this.txtEfectivo.Enter += new System.EventHandler(this.txtEfectivo_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 212;
            this.label2.Text = "Efectivo";
            // 
            // txtTicketTronik
            // 
            this.txtTicketTronik.Location = new System.Drawing.Point(361, 110);
            this.txtTicketTronik.Name = "txtTicketTronik";
            this.txtTicketTronik.ReadOnly = true;
            this.txtTicketTronik.Size = new System.Drawing.Size(141, 20);
            this.txtTicketTronik.TabIndex = 181;
            this.txtTicketTronik.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTicketTronik.Leave += new System.EventHandler(this.txtTicketTronik_Leave);
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
            this.txtTarjetas.ReadOnly = true;
            this.txtTarjetas.Size = new System.Drawing.Size(141, 20);
            this.txtTarjetas.TabIndex = 22;
            this.txtTarjetas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTarjetas.Leave += new System.EventHandler(this.txtTarjetas_Leave);
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
            // txtOtros
            // 
            this.txtOtros.Location = new System.Drawing.Point(360, 80);
            this.txtOtros.Name = "txtOtros";
            this.txtOtros.ReadOnly = true;
            this.txtOtros.Size = new System.Drawing.Size(141, 20);
            this.txtOtros.TabIndex = 23;
            this.txtOtros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOtros.Leave += new System.EventHandler(this.txtOtros_Leave);
            this.txtOtros.Enter += new System.EventHandler(this.txtOtros_Leave);
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
            // txtBigpass
            // 
            this.txtBigpass.Location = new System.Drawing.Point(103, 111);
            this.txtBigpass.Name = "txtBigpass";
            this.txtBigpass.ReadOnly = true;
            this.txtBigpass.Size = new System.Drawing.Size(141, 20);
            this.txtBigpass.TabIndex = 21;
            this.txtBigpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBigpass.Leave += new System.EventHandler(this.txtBigpass_Leave);
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
            // txtSodexo
            // 
            this.txtSodexo.Location = new System.Drawing.Point(103, 80);
            this.txtSodexo.Name = "txtSodexo";
            this.txtSodexo.ReadOnly = true;
            this.txtSodexo.Size = new System.Drawing.Size(141, 20);
            this.txtSodexo.TabIndex = 20;
            this.txtSodexo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSodexo.Leave += new System.EventHandler(this.txtSodexo_Leave);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Total consumo";
            // 
            // txtTotalConsumo
            // 
            this.txtTotalConsumo.Location = new System.Drawing.Point(459, 30);
            this.txtTotalConsumo.Name = "txtTotalConsumo";
            this.txtTotalConsumo.ReadOnly = true;
            this.txtTotalConsumo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalConsumo.Size = new System.Drawing.Size(162, 20);
            this.txtTotalConsumo.TabIndex = 32;
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Location = new System.Drawing.Point(191, 28);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(75, 23);
            this.cmdConsultar.TabIndex = 33;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Location = new System.Drawing.Point(294, 463);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(75, 28);
            this.cmdGuardar.TabIndex = 34;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(396, 463);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(75, 28);
            this.cmdCancelar.TabIndex = 35;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // EdicionCierres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 506);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.txtTotalConsumo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFecha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EdicionCierres";
            this.Text = "Edicion Cierres";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cierreVentasVOBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource cierreVentasVOBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTicketTronik;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTarjetas;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTarjetaPlus;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtOtros;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBigpass;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSodexo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCreditos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalConsumo;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCierreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalVentasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn islaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn efectivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bigPassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otrosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarjetasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarjetaPlusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketTronikDataGridViewTextBoxColumn;
    }
}