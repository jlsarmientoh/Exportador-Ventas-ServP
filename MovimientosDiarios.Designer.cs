namespace Exportador_Ventas_ServP
{
    partial class MovimientosDiarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovimientosDiarios));
            this.CalendarDesde = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFechaDesde = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotalIngresos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridIngresos = new System.Windows.Forms.DataGridView();
            this.documentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tipoIdVOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numConsignacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBancoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bancoVOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingresoVOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalEgresos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grisEgresos = new System.Windows.Forms.DataGridView();
            this.documentoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tipoIdVOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beneficiarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egresoVOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmdGuardarEgresos = new System.Windows.Forms.Button();
            this.cmdCalendarDesde = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdConsultarAplicados = new System.Windows.Forms.Button();
            this.calendarAplica = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFechaAplica = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridIngresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoIdVOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoVOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingresoVOBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grisEgresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoIdVOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.egresoVOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CalendarDesde
            // 
            this.CalendarDesde.Location = new System.Drawing.Point(13, 22);
            this.CalendarDesde.Name = "CalendarDesde";
            this.CalendarDesde.TabIndex = 7;
            this.CalendarDesde.Visible = false;
            this.CalendarDesde.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.CalendarDesde_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha:";
            // 
            // txtFechaDesde
            // 
            this.txtFechaDesde.Location = new System.Drawing.Point(67, 23);
            this.txtFechaDesde.Name = "txtFechaDesde";
            this.txtFechaDesde.Size = new System.Drawing.Size(115, 20);
            this.txtFechaDesde.TabIndex = 8;
            this.txtFechaDesde.Leave += new System.EventHandler(this.txtFechaDesde_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTotalIngresos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.gridIngresos);
            this.groupBox1.Location = new System.Drawing.Point(12, 315);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 245);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresos";
            this.groupBox1.Visible = false;
            // 
            // txtTotalIngresos
            // 
            this.txtTotalIngresos.Location = new System.Drawing.Point(588, 212);
            this.txtTotalIngresos.Name = "txtTotalIngresos";
            this.txtTotalIngresos.ReadOnly = true;
            this.txtTotalIngresos.Size = new System.Drawing.Size(152, 20);
            this.txtTotalIngresos.TabIndex = 10;
            this.txtTotalIngresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total ingresos";
            // 
            // gridIngresos
            // 
            this.gridIngresos.AutoGenerateColumns = false;
            this.gridIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridIngresos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.documentoDataGridViewTextBoxColumn,
            this.numConsignacionDataGridViewTextBoxColumn,
            this.idBancoDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn});
            this.gridIngresos.DataSource = this.ingresoVOBindingSource;
            this.gridIngresos.Location = new System.Drawing.Point(15, 18);
            this.gridIngresos.Name = "gridIngresos";
            this.gridIngresos.Size = new System.Drawing.Size(724, 184);
            this.gridIngresos.TabIndex = 8;
            this.gridIngresos.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridIngresos_RowLeave);
            this.gridIngresos.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.gridIngresos_DataError);
            // 
            // documentoDataGridViewTextBoxColumn
            // 
            this.documentoDataGridViewTextBoxColumn.DataPropertyName = "Documento";
            this.documentoDataGridViewTextBoxColumn.DataSource = this.tipoIdVOBindingSource;
            this.documentoDataGridViewTextBoxColumn.DisplayMember = "Nombre";
            this.documentoDataGridViewTextBoxColumn.HeaderText = "Documento";
            this.documentoDataGridViewTextBoxColumn.Name = "documentoDataGridViewTextBoxColumn";
            this.documentoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.documentoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.documentoDataGridViewTextBoxColumn.ValueMember = "IdTipo";
            // 
            // tipoIdVOBindingSource
            // 
            this.tipoIdVOBindingSource.DataSource = typeof(EstacionDB.VO.TipoIdVO);
            // 
            // numConsignacionDataGridViewTextBoxColumn
            // 
            this.numConsignacionDataGridViewTextBoxColumn.DataPropertyName = "NumConsignacion";
            this.numConsignacionDataGridViewTextBoxColumn.HeaderText = "NumConsignacion";
            this.numConsignacionDataGridViewTextBoxColumn.Name = "numConsignacionDataGridViewTextBoxColumn";
            // 
            // idBancoDataGridViewTextBoxColumn
            // 
            this.idBancoDataGridViewTextBoxColumn.DataPropertyName = "IdBanco";
            this.idBancoDataGridViewTextBoxColumn.DataSource = this.bancoVOBindingSource;
            this.idBancoDataGridViewTextBoxColumn.DisplayMember = "Nombre";
            this.idBancoDataGridViewTextBoxColumn.HeaderText = "Banco";
            this.idBancoDataGridViewTextBoxColumn.Name = "idBancoDataGridViewTextBoxColumn";
            this.idBancoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idBancoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idBancoDataGridViewTextBoxColumn.ValueMember = "IdBanco";
            // 
            // bancoVOBindingSource
            // 
            this.bancoVOBindingSource.DataSource = typeof(EstacionDB.VO.BancoVO);
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            // 
            // ingresoVOBindingSource
            // 
            this.ingresoVOBindingSource.DataSource = typeof(EstacionDB.VO.IngresoVO);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSaldo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtTotalEgresos);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.grisEgresos);
            this.groupBox2.Location = new System.Drawing.Point(12, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(765, 250);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Egresos";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(349, 221);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(152, 20);
            this.txtSaldo.TabIndex = 14;
            this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Saldo a disponer";
            // 
            // txtTotalEgresos
            // 
            this.txtTotalEgresos.Location = new System.Drawing.Point(591, 220);
            this.txtTotalEgresos.Name = "txtTotalEgresos";
            this.txtTotalEgresos.ReadOnly = true;
            this.txtTotalEgresos.Size = new System.Drawing.Size(152, 20);
            this.txtTotalEgresos.TabIndex = 12;
            this.txtTotalEgresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Total egresos";
            // 
            // grisEgresos
            // 
            this.grisEgresos.AutoGenerateColumns = false;
            this.grisEgresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grisEgresos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.documentoDataGridViewTextBoxColumn1,
            this.numeroDataGridViewTextBoxColumn,
            this.beneficiarioDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn1});
            this.grisEgresos.DataSource = this.egresoVOBindingSource;
            this.grisEgresos.Location = new System.Drawing.Point(20, 20);
            this.grisEgresos.Name = "grisEgresos";
            this.grisEgresos.Size = new System.Drawing.Size(722, 190);
            this.grisEgresos.TabIndex = 0;
            this.grisEgresos.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.grisEgresos_RowLeave);
            this.grisEgresos.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.gridEgresos_DataError);
            // 
            // documentoDataGridViewTextBoxColumn1
            // 
            this.documentoDataGridViewTextBoxColumn1.DataPropertyName = "Documento";
            this.documentoDataGridViewTextBoxColumn1.DataSource = this.tipoIdVOBindingSource1;
            this.documentoDataGridViewTextBoxColumn1.DisplayMember = "Nombre";
            this.documentoDataGridViewTextBoxColumn1.HeaderText = "Documento";
            this.documentoDataGridViewTextBoxColumn1.Name = "documentoDataGridViewTextBoxColumn1";
            this.documentoDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.documentoDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.documentoDataGridViewTextBoxColumn1.ValueMember = "IdTipo";
            // 
            // tipoIdVOBindingSource1
            // 
            this.tipoIdVOBindingSource1.DataSource = typeof(EstacionDB.VO.TipoIdVO);
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            // 
            // beneficiarioDataGridViewTextBoxColumn
            // 
            this.beneficiarioDataGridViewTextBoxColumn.DataPropertyName = "Beneficiario";
            this.beneficiarioDataGridViewTextBoxColumn.HeaderText = "Beneficiario";
            this.beneficiarioDataGridViewTextBoxColumn.Name = "beneficiarioDataGridViewTextBoxColumn";
            // 
            // valorDataGridViewTextBoxColumn1
            // 
            this.valorDataGridViewTextBoxColumn1.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn1.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn1.Name = "valorDataGridViewTextBoxColumn1";
            // 
            // egresoVOBindingSource
            // 
            this.egresoVOBindingSource.DataSource = typeof(EstacionDB.VO.EgresoVO);
            // 
            // cmdGuardarEgresos
            // 
            this.cmdGuardarEgresos.Location = new System.Drawing.Point(660, 21);
            this.cmdGuardarEgresos.Name = "cmdGuardarEgresos";
            this.cmdGuardarEgresos.Size = new System.Drawing.Size(111, 25);
            this.cmdGuardarEgresos.TabIndex = 12;
            this.cmdGuardarEgresos.Text = "Guardar egresos";
            this.cmdGuardarEgresos.UseVisualStyleBackColor = true;
            this.cmdGuardarEgresos.Click += new System.EventHandler(this.cmdGuardarEgresos_Click);
            // 
            // cmdCalendarDesde
            // 
            this.cmdCalendarDesde.Image = global::Exportador_Ventas_ServP.Properties.Resources.calendar;
            this.cmdCalendarDesde.Location = new System.Drawing.Point(184, 22);
            this.cmdCalendarDesde.Name = "cmdCalendarDesde";
            this.cmdCalendarDesde.Size = new System.Drawing.Size(22, 23);
            this.cmdCalendarDesde.TabIndex = 6;
            this.cmdCalendarDesde.UseVisualStyleBackColor = true;
            this.cmdCalendarDesde.Click += new System.EventHandler(this.cmdCalendarDesde_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Aplicar día";
            // 
            // cmdConsultarAplicados
            // 
            this.cmdConsultarAplicados.Image = global::Exportador_Ventas_ServP.Properties.Resources.refresh_hov;
            this.cmdConsultarAplicados.Location = new System.Drawing.Point(564, 24);
            this.cmdConsultarAplicados.Name = "cmdConsultarAplicados";
            this.cmdConsultarAplicados.Size = new System.Drawing.Size(25, 23);
            this.cmdConsultarAplicados.TabIndex = 17;
            this.cmdConsultarAplicados.UseVisualStyleBackColor = true;
            this.cmdConsultarAplicados.Click += new System.EventHandler(this.cmdConsultarAplicados_Click);
            // 
            // calendarAplica
            // 
            this.calendarAplica.Location = new System.Drawing.Point(337, 25);
            this.calendarAplica.Name = "calendarAplica";
            this.calendarAplica.TabIndex = 19;
            this.calendarAplica.Visible = false;
            this.calendarAplica.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // button1
            // 
            this.button1.Image = global::Exportador_Ventas_ServP.Properties.Resources.calendar;
            this.button1.Location = new System.Drawing.Point(508, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 23);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFechaAplica
            // 
            this.txtFechaAplica.Location = new System.Drawing.Point(396, 25);
            this.txtFechaAplica.Name = "txtFechaAplica";
            this.txtFechaAplica.Size = new System.Drawing.Size(103, 20);
            this.txtFechaAplica.TabIndex = 20;
            // 
            // MovimientosDiarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 325);
            this.Controls.Add(this.calendarAplica);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFechaAplica);
            this.Controls.Add(this.cmdConsultarAplicados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdGuardarEgresos);
            this.Controls.Add(this.CalendarDesde);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtFechaDesde);
            this.Controls.Add(this.cmdCalendarDesde);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MovimientosDiarios";
            this.Text = "Ingresos / Egresos [Diario]";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridIngresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoIdVOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoVOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingresoVOBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grisEgresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoIdVOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.egresoVOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar CalendarDesde;
        private System.Windows.Forms.Button cmdCalendarDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFechaDesde;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridIngresos;
        private System.Windows.Forms.BindingSource ingresoVOBindingSource;
        private System.Windows.Forms.BindingSource bancoVOBindingSource;
        private System.Windows.Forms.DataGridView grisEgresos;
        private System.Windows.Forms.BindingSource egresoVOBindingSource;
        private System.Windows.Forms.BindingSource tipoIdVOBindingSource;
        private System.Windows.Forms.Button cmdGuardarEgresos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalIngresos;
        private System.Windows.Forms.TextBox txtTotalEgresos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource tipoIdVOBindingSource1;
        private System.Windows.Forms.DataGridViewComboBoxColumn documentoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beneficiarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn documentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numConsignacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idBancoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdConsultarAplicados;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MonthCalendar calendarAplica;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFechaAplica;
    }
}