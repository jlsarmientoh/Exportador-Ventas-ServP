namespace Exportador_Ventas_ServP.Reports
{
    partial class InformeEstadoDeCuenta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.EstadoDeCuenta1 = new Exportador_Ventas_ServP.EstadoDeCuenta();
            this.cmdGenerar = new System.Windows.Forms.Button();
            this.txtDesde = new System.Windows.Forms.MaskedTextBox();
            this.txtHasta = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.clienteVOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboModoPago = new System.Windows.Forms.ComboBox();
            this.modoPagoDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteVOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modoPagoDTOBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.crystalReportViewer1);
            this.panel1.Location = new System.Drawing.Point(19, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 348);
            this.panel1.TabIndex = 0;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.EstadoDeCuenta1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(727, 348);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            this.crystalReportViewer1.ReportRefresh += new CrystalDecisions.Windows.Forms.RefreshEventHandler(this.crystalReportViewer1_ReportRefresh);
            // 
            // cmdGenerar
            // 
            this.cmdGenerar.Location = new System.Drawing.Point(611, 35);
            this.cmdGenerar.Name = "cmdGenerar";
            this.cmdGenerar.Size = new System.Drawing.Size(81, 29);
            this.cmdGenerar.TabIndex = 5;
            this.cmdGenerar.Text = "Generar";
            this.cmdGenerar.UseVisualStyleBackColor = true;
            this.cmdGenerar.Click += new System.EventHandler(this.cmdGenerar_Click);
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(67, 21);
            this.txtDesde.Mask = "00/00/0000";
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(100, 20);
            this.txtDesde.TabIndex = 1;
            this.txtDesde.ValidatingType = typeof(System.DateTime);
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(67, 53);
            this.txtHasta.Mask = "00/00/0000";
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(100, 20);
            this.txtHasta.TabIndex = 2;
            this.txtHasta.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hasta";
            // 
            // cboClientes
            // 
            this.cboClientes.DataSource = this.clienteVOBindingSource;
            this.cboClientes.DisplayMember = "Nombre";
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(284, 21);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(271, 21);
            this.cboClientes.TabIndex = 3;
            this.cboClientes.ValueMember = "Identificacion";
            // 
            // clienteVOBindingSource
            // 
            this.clienteVOBindingSource.DataSource = typeof(EstacionDB.VO.ClienteVO);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Modo de pago";
            // 
            // cboModoPago
            // 
            this.cboModoPago.DataSource = this.modoPagoDTOBindingSource;
            this.cboModoPago.DisplayMember = "Nombre";
            this.cboModoPago.FormattingEnabled = true;
            this.cboModoPago.Location = new System.Drawing.Point(284, 52);
            this.cboModoPago.Name = "cboModoPago";
            this.cboModoPago.Size = new System.Drawing.Size(272, 21);
            this.cboModoPago.TabIndex = 4;
            this.cboModoPago.ValueMember = "Id";
            // 
            // modoPagoDTOBindingSource
            // 
            this.modoPagoDTOBindingSource.DataSource = typeof(Exportador_Ventas_ServP.Reports.DTO.ModoPagoDTO);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboModoPago);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboClientes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtHasta);
            this.groupBox1.Controls.Add(this.txtDesde);
            this.groupBox1.Controls.Add(this.cmdGenerar);
            this.groupBox1.Location = new System.Drawing.Point(22, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 87);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // InformeEstadoDeCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 471);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "InformeEstadoDeCuenta";
            this.Text = "Estado de Cuenta";
            this.Load += new System.EventHandler(this.InformeEstadoDeCuenta_Load);
            this.Resize += new System.EventHandler(this.InformeEstadoDeCuenta_Resize);
            this.ResizeEnd += new System.EventHandler(this.InformeEstadoDeCuenta_ResizeEnd);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clienteVOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modoPagoDTOBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private EstadoDeCuenta EstadoDeCuenta1;
        private System.Windows.Forms.Button cmdGenerar;
        private System.Windows.Forms.MaskedTextBox txtDesde;
        private System.Windows.Forms.MaskedTextBox txtHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboClientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboModoPago;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource clienteVOBindingSource;
        private System.Windows.Forms.BindingSource modoPagoDTOBindingSource;
    }
}