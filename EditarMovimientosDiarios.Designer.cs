namespace Exportador_Ventas_ServP
{
    partial class EditarMovimientosDiarios
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
            this.txtFechaCierre = new System.Windows.Forms.MaskedTextBox();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tipoIdVOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beneficiarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAplica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egresoDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalEgresos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkEditar = new System.Windows.Forms.CheckBox();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdCierre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoIdVOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.egresoDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFechaCierre
            // 
            this.txtFechaCierre.Location = new System.Drawing.Point(105, 30);
            this.txtFechaCierre.Mask = "00/00/0000";
            this.txtFechaCierre.Name = "txtFechaCierre";
            this.txtFechaCierre.Size = new System.Drawing.Size(100, 20);
            this.txtFechaCierre.TabIndex = 0;
            this.txtFechaCierre.ValidatingType = typeof(System.DateTime);
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Image = global::Exportador_Ventas_ServP.Properties.Resources.refresh_hov;
            this.cmdConsultar.Location = new System.Drawing.Point(207, 28);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(25, 23);
            this.cmdConsultar.TabIndex = 1;
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoDocumento,
            this.numeroDataGridViewTextBoxColumn,
            this.beneficiarioDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.FechaAplica});
            this.dataGridView1.DataSource = this.egresoDTOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(643, 231);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowLeave);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.DataPropertyName = "TipoDocumento";
            this.TipoDocumento.DataSource = this.tipoIdVOBindingSource;
            this.TipoDocumento.DisplayMember = "Nombre";
            this.TipoDocumento.HeaderText = "Tipo Documento";
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            this.TipoDocumento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TipoDocumento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TipoDocumento.ValueMember = "IdTipo";
            // 
            // tipoIdVOBindingSource
            // 
            this.tipoIdVOBindingSource.DataSource = typeof(EstacionDB.VO.TipoIdVO);
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // beneficiarioDataGridViewTextBoxColumn
            // 
            this.beneficiarioDataGridViewTextBoxColumn.DataPropertyName = "Beneficiario";
            this.beneficiarioDataGridViewTextBoxColumn.HeaderText = "Beneficiario";
            this.beneficiarioDataGridViewTextBoxColumn.Name = "beneficiarioDataGridViewTextBoxColumn";
            this.beneficiarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha Egreso";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FechaAplica
            // 
            this.FechaAplica.DataPropertyName = "FechaAplica";
            this.FechaAplica.HeaderText = "Fecha Aplica";
            this.FechaAplica.Name = "FechaAplica";
            this.FechaAplica.ReadOnly = true;
            // 
            // egresoDTOBindingSource
            // 
            this.egresoDTOBindingSource.DataSource = typeof(EstacionDB.DTO.EgresoDTO);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha del cierre";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(268, 310);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(152, 20);
            this.txtSaldo.TabIndex = 18;
            this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Saldo a disponer";
            // 
            // txtTotalEgresos
            // 
            this.txtTotalEgresos.Location = new System.Drawing.Point(505, 309);
            this.txtTotalEgresos.Name = "txtTotalEgresos";
            this.txtTotalEgresos.ReadOnly = true;
            this.txtTotalEgresos.Size = new System.Drawing.Size(152, 20);
            this.txtTotalEgresos.TabIndex = 16;
            this.txtTotalEgresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Total egresos";
            // 
            // chkEditar
            // 
            this.chkEditar.AutoSize = true;
            this.chkEditar.Enabled = false;
            this.chkEditar.Location = new System.Drawing.Point(427, 33);
            this.chkEditar.Name = "chkEditar";
            this.chkEditar.Size = new System.Drawing.Size(53, 17);
            this.chkEditar.TabIndex = 19;
            this.chkEditar.Text = "Editar";
            this.chkEditar.UseVisualStyleBackColor = true;
            this.chkEditar.CheckedChanged += new System.EventHandler(this.chkEditar_CheckedChanged);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Enabled = false;
            this.cmdGuardar.Location = new System.Drawing.Point(575, 29);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(75, 23);
            this.cmdGuardar.TabIndex = 21;
            this.cmdGuardar.Text = "Guardar egresos";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Enabled = false;
            this.cmdEliminar.Location = new System.Drawing.Point(490, 29);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(75, 23);
            this.cmdEliminar.TabIndex = 22;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdCierre
            // 
            this.cmdCierre.Enabled = false;
            this.cmdCierre.Location = new System.Drawing.Point(16, 306);
            this.cmdCierre.Name = "cmdCierre";
            this.cmdCierre.Size = new System.Drawing.Size(118, 24);
            this.cmdCierre.TabIndex = 23;
            this.cmdCierre.Text = "Confirmar Cerrar";
            this.cmdCierre.UseVisualStyleBackColor = true;
            this.cmdCierre.Click += new System.EventHandler(this.cmdCierre_Click);
            // 
            // EditarMovimientosDiarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 338);
            this.Controls.Add(this.cmdCierre);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.chkEditar);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotalEgresos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.txtFechaCierre);
            this.MaximizeBox = false;
            this.Name = "EditarMovimientosDiarios";
            this.Text = "Disposición de efectivo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoIdVOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.egresoDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtFechaCierre;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource egresoDTOBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn tipoDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tipoIdVOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAplicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalEgresos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewComboBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beneficiarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAplica;
        private System.Windows.Forms.CheckBox chkEditar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdCierre;
    }
}