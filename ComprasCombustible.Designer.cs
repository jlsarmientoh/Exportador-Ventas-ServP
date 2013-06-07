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
            this.CalendarDesde = new System.Windows.Forms.MonthCalendar();
            this.txtFechaDesde = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.productoVOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtGalones = new System.Windows.Forms.TextBox();
            this.cmdCalendarDesde = new System.Windows.Forms.Button();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.txtInicial = new System.Windows.Forms.TextBox();
            this.txtMedida = new System.Windows.Forms.TextBox();
            this.txtSurtidor = new System.Windows.Forms.TextBox();
            this.Inicial = new System.Windows.Forms.Label();
            this.Final = new System.Windows.Forms.Label();
            this.Medida = new System.Windows.Forms.Label();
            this.Surtidor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSobranteDia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSonbranteAcumulado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.productoVOBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalendarDesde
            // 
            this.CalendarDesde.Location = new System.Drawing.Point(24, 14);
            this.CalendarDesde.Name = "CalendarDesde";
            this.CalendarDesde.TabIndex = 11;
            this.CalendarDesde.Visible = false;
            this.CalendarDesde.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.CalendarDesde_DateChanged);
            // 
            // txtFechaDesde
            // 
            this.txtFechaDesde.Location = new System.Drawing.Point(83, 27);
            this.txtFechaDesde.Name = "txtFechaDesde";
            this.txtFechaDesde.Size = new System.Drawing.Size(115, 20);
            this.txtFechaDesde.TabIndex = 1;
            this.txtFechaDesde.TextChanged += new System.EventHandler(this.txtFechaDesde_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fecha:";
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tipo de combustible";
            this.label2.UseWaitCursor = true;
            // 
            // cboProducto
            // 
            this.cboProducto.DataSource = this.productoVOBindingSource;
            this.cboProducto.DisplayMember = "Nombre";
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(348, 27);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(160, 21);
            this.cboProducto.TabIndex = 3;
            this.cboProducto.ValueMember = "IdProducto";
            this.cboProducto.SelectedIndexChanged += new System.EventHandler(this.cboProducto_SelectedIndexChanged);
            // 
            // productoVOBindingSource
            // 
            this.productoVOBindingSource.DataSource = typeof(EstacionDB.VO.ProductoVO);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Cantidad (Galones)";
            this.label3.UseWaitCursor = true;
            // 
            // txtGalones
            // 
            this.txtGalones.Location = new System.Drawing.Point(636, 28);
            this.txtGalones.Name = "txtGalones";
            this.txtGalones.Size = new System.Drawing.Size(77, 20);
            this.txtGalones.TabIndex = 4;
            this.txtGalones.TextChanged += new System.EventHandler(this.txtGalones_TextChanged);
            this.txtGalones.Enter += new System.EventHandler(this.txtGalones_Enter);
            // 
            // cmdCalendarDesde
            // 
            this.cmdCalendarDesde.Image = global::Exportador_Ventas_ServP.Properties.Resources.calendar;
            this.cmdCalendarDesde.Location = new System.Drawing.Point(200, 26);
            this.cmdCalendarDesde.Name = "cmdCalendarDesde";
            this.cmdCalendarDesde.Size = new System.Drawing.Size(22, 23);
            this.cmdCalendarDesde.TabIndex = 2;
            this.cmdCalendarDesde.UseVisualStyleBackColor = true;
            this.cmdCalendarDesde.Click += new System.EventHandler(this.cmdCalendarDesde_Click);
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(204, 30);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(77, 20);
            this.txtFinal.TabIndex = 6;
            this.txtFinal.TextChanged += new System.EventHandler(this.txtFinal_TextChanged);
            this.txtFinal.Enter += new System.EventHandler(this.txtFinal_Enter);
            // 
            // txtInicial
            // 
            this.txtInicial.Location = new System.Drawing.Point(63, 31);
            this.txtInicial.Name = "txtInicial";
            this.txtInicial.Size = new System.Drawing.Size(77, 20);
            this.txtInicial.TabIndex = 5;
            this.txtInicial.TextChanged += new System.EventHandler(this.txtInicial_TextChanged);
            this.txtInicial.Enter += new System.EventHandler(this.txtInicial_Enter);
            // 
            // txtMedida
            // 
            this.txtMedida.Location = new System.Drawing.Point(63, 28);
            this.txtMedida.Name = "txtMedida";
            this.txtMedida.ReadOnly = true;
            this.txtMedida.Size = new System.Drawing.Size(77, 20);
            this.txtMedida.TabIndex = 19;
            // 
            // txtSurtidor
            // 
            this.txtSurtidor.Location = new System.Drawing.Point(204, 27);
            this.txtSurtidor.Name = "txtSurtidor";
            this.txtSurtidor.Size = new System.Drawing.Size(77, 20);
            this.txtSurtidor.TabIndex = 7;
            this.txtSurtidor.TextChanged += new System.EventHandler(this.txtSurtidor_TextChanged);
            this.txtSurtidor.Enter += new System.EventHandler(this.txtSurtidor_Enter);
            // 
            // Inicial
            // 
            this.Inicial.AutoSize = true;
            this.Inicial.Location = new System.Drawing.Point(16, 35);
            this.Inicial.Name = "Inicial";
            this.Inicial.Size = new System.Drawing.Size(34, 13);
            this.Inicial.TabIndex = 21;
            this.Inicial.Text = "Inicial";
            // 
            // Final
            // 
            this.Final.AutoSize = true;
            this.Final.Location = new System.Drawing.Point(157, 35);
            this.Final.Name = "Final";
            this.Final.Size = new System.Drawing.Size(29, 13);
            this.Final.TabIndex = 22;
            this.Final.Text = "Final";
            // 
            // Medida
            // 
            this.Medida.AutoSize = true;
            this.Medida.Location = new System.Drawing.Point(14, 32);
            this.Medida.Name = "Medida";
            this.Medida.Size = new System.Drawing.Size(42, 13);
            this.Medida.TabIndex = 23;
            this.Medida.Text = "Medida";
            // 
            // Surtidor
            // 
            this.Surtidor.AutoSize = true;
            this.Surtidor.Location = new System.Drawing.Point(157, 31);
            this.Surtidor.Name = "Surtidor";
            this.Surtidor.Size = new System.Drawing.Size(43, 13);
            this.Surtidor.TabIndex = 24;
            this.Surtidor.Text = "Surtidor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMedida);
            this.groupBox1.Controls.Add(this.Surtidor);
            this.groupBox1.Controls.Add(this.Medida);
            this.groupBox1.Controls.Add(this.txtSurtidor);
            this.groupBox1.Location = new System.Drawing.Point(404, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 75);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ventas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtInicial);
            this.groupBox2.Controls.Add(this.Inicial);
            this.groupBox2.Controls.Add(this.Final);
            this.groupBox2.Controls.Add(this.txtFinal);
            this.groupBox2.Location = new System.Drawing.Point(48, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 75);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inventario";
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Location = new System.Drawing.Point(321, 272);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(85, 28);
            this.cmdGuardar.TabIndex = 8;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSobranteDia);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtSonbranteAcumulado);
            this.groupBox3.Location = new System.Drawing.Point(217, 177);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 75);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sobrantes";
            // 
            // txtSobranteDia
            // 
            this.txtSobranteDia.Location = new System.Drawing.Point(64, 28);
            this.txtSobranteDia.Name = "txtSobranteDia";
            this.txtSobranteDia.ReadOnly = true;
            this.txtSobranteDia.Size = new System.Drawing.Size(77, 20);
            this.txtSobranteDia.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Día";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Acumulado";
            // 
            // txtSonbranteAcumulado
            // 
            this.txtSonbranteAcumulado.Location = new System.Drawing.Point(212, 27);
            this.txtSonbranteAcumulado.Name = "txtSonbranteAcumulado";
            this.txtSonbranteAcumulado.ReadOnly = true;
            this.txtSonbranteAcumulado.Size = new System.Drawing.Size(77, 20);
            this.txtSonbranteAcumulado.TabIndex = 23;
            // 
            // ComprasCombustible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 313);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtGalones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CalendarDesde);
            this.Controls.Add(this.txtFechaDesde);
            this.Controls.Add(this.cmdCalendarDesde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ComprasCombustible";
            this.Text = "Inventario de combustible";
            this.Load += new System.EventHandler(this.ComprasCombustible_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ComprasCombustible_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.productoVOBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar CalendarDesde;
        private System.Windows.Forms.TextBox txtFechaDesde;
        private System.Windows.Forms.Button cmdCalendarDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGalones;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.TextBox txtInicial;
        private System.Windows.Forms.TextBox txtMedida;
        private System.Windows.Forms.TextBox txtSurtidor;
        private System.Windows.Forms.Label Inicial;
        private System.Windows.Forms.Label Final;
        private System.Windows.Forms.Label Medida;
        private System.Windows.Forms.Label Surtidor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource productoVOBindingSource;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSobranteDia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSonbranteAcumulado;
    }
}