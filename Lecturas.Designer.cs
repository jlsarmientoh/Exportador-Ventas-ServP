namespace Exportador_Ventas_ServP
{
    partial class Lecturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lecturas));
            this.label1 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.productoVOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.cboTanque = new System.Windows.Forms.ComboBox();
            this.tanqueVOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtMedida = new System.Windows.Forms.TextBox();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lecturaDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nivelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.galonesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productoVOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tanqueVOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturaDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Fecha:";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(89, 25);
            this.txtFecha.Mask = "00/00/0000";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 21;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Producto";
            // 
            // cboProducto
            // 
            this.cboProducto.DataSource = this.productoVOBindingSource;
            this.cboProducto.DisplayMember = "Nombre";
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(266, 24);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(146, 21);
            this.cboProducto.TabIndex = 23;
            this.cboProducto.ValueMember = "IdProducto";
            // 
            // productoVOBindingSource
            // 
            this.productoVOBindingSource.DataSource = typeof(EstacionDB.VO.ProductoVO);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tanque";
            // 
            // cboTanque
            // 
            this.cboTanque.DataSource = this.tanqueVOBindingSource;
            this.cboTanque.DisplayMember = "Descripcion";
            this.cboTanque.FormattingEnabled = true;
            this.cboTanque.Location = new System.Drawing.Point(486, 24);
            this.cboTanque.Name = "cboTanque";
            this.cboTanque.Size = new System.Drawing.Size(233, 21);
            this.cboTanque.TabIndex = 25;
            this.cboTanque.ValueMember = "IdTanque";
            // 
            // tanqueVOBindingSource
            // 
            this.tanqueVOBindingSource.DataSource = typeof(EstacionDB.VO.TanqueVO);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Nivel (Cms)";
            // 
            // txtMedida
            // 
            this.txtMedida.Location = new System.Drawing.Point(112, 66);
            this.txtMedida.Name = "txtMedida";
            this.txtMedida.Size = new System.Drawing.Size(100, 20);
            this.txtMedida.TabIndex = 27;
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Image = global::Exportador_Ventas_ServP.Properties.Resources.del_hover;
            this.cmdLimpiar.Location = new System.Drawing.Point(266, 124);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(36, 30);
            this.cmdLimpiar.TabIndex = 29;
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Image = global::Exportador_Ventas_ServP.Properties.Resources.add_hover;
            this.cmdAgregar.Location = new System.Drawing.Point(266, 70);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(35, 31);
            this.cmdAgregar.TabIndex = 28;
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
            this.nivelDataGridViewTextBoxColumn,
            this.galonesDataGridViewTextBoxColumn,
            this.productoDataGridViewTextBoxColumn,
            this.tanqueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lecturaDTOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(61, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(693, 215);
            this.dataGridView1.TabIndex = 30;
            // 
            // lecturaDTOBindingSource
            // 
            this.lecturaDTOBindingSource.DataSource = typeof(EstacionDB.DTO.LecturaDTO);
            // 
            // nivelDataGridViewTextBoxColumn
            // 
            this.nivelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nivelDataGridViewTextBoxColumn.DataPropertyName = "Nivel";
            this.nivelDataGridViewTextBoxColumn.HeaderText = "Nivel";
            this.nivelDataGridViewTextBoxColumn.Name = "nivelDataGridViewTextBoxColumn";
            this.nivelDataGridViewTextBoxColumn.ReadOnly = true;
            this.nivelDataGridViewTextBoxColumn.Width = 56;
            // 
            // galonesDataGridViewTextBoxColumn
            // 
            this.galonesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.galonesDataGridViewTextBoxColumn.DataPropertyName = "Galones";
            this.galonesDataGridViewTextBoxColumn.HeaderText = "Galones";
            this.galonesDataGridViewTextBoxColumn.Name = "galonesDataGridViewTextBoxColumn";
            this.galonesDataGridViewTextBoxColumn.ReadOnly = true;
            this.galonesDataGridViewTextBoxColumn.Width = 71;
            // 
            // productoDataGridViewTextBoxColumn
            // 
            this.productoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.productoDataGridViewTextBoxColumn.DataPropertyName = "Producto";
            this.productoDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.productoDataGridViewTextBoxColumn.Name = "productoDataGridViewTextBoxColumn";
            this.productoDataGridViewTextBoxColumn.ReadOnly = true;
            this.productoDataGridViewTextBoxColumn.Width = 75;
            // 
            // tanqueDataGridViewTextBoxColumn
            // 
            this.tanqueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tanqueDataGridViewTextBoxColumn.DataPropertyName = "Tanque";
            this.tanqueDataGridViewTextBoxColumn.HeaderText = "Tanque";
            this.tanqueDataGridViewTextBoxColumn.Name = "tanqueDataGridViewTextBoxColumn";
            this.tanqueDataGridViewTextBoxColumn.ReadOnly = true;
            this.tanqueDataGridViewTextBoxColumn.Width = 69;
            // 
            // Lecturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 496);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.cmdAgregar);
            this.Controls.Add(this.txtMedida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboTanque);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Lecturas";
            this.Text = "Lecturas";
            this.Load += new System.EventHandler(this.Lecturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productoVOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tanqueVOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturaDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.BindingSource productoVOBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTanque;
        private System.Windows.Forms.BindingSource tanqueVOBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMedida;
        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource lecturaDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn galonesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanqueDataGridViewTextBoxColumn;
    }
}