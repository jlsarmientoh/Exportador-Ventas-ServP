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
            this.CalendarHasta = new System.Windows.Forms.MonthCalendar();
            this.CalendarDesde = new System.Windows.Forms.MonthCalendar();
            this.cmdExportTxt = new System.Windows.Forms.Button();
            this.cmdExportExcel = new System.Windows.Forms.Button();
            this.GridLecturasCargadas = new System.Windows.Forms.DataGridView();
            this.frameAdicionar = new System.Windows.Forms.GroupBox();
            this.txtTotalGalonesDiesel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalGalonesSuper = new System.Windows.Forms.TextBox();
            this.txtTotalGalonesCorriente = new System.Windows.Forms.TextBox();
            this.txtTotalGalones = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdCalendarHasta = new System.Windows.Forms.Button();
            this.cmdCalendarDesde = new System.Windows.Forms.Button();
            this.txtFechaHasta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFechaDesde = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.txtVentaDiesel = new System.Windows.Forms.TextBox();
            this.txtVentaSuper = new System.Windows.Forms.TextBox();
            this.txtVentaCorriente = new System.Windows.Forms.TextBox();
            this.txtVentaTotal = new System.Windows.Forms.TextBox();
            this.txtSobretasaDiesel = new System.Windows.Forms.TextBox();
            this.txtSobretasaSuper = new System.Windows.Forms.TextBox();
            this.txtSobretasaCorriente = new System.Windows.Forms.TextBox();
            this.txtSobretasaTotal = new System.Windows.Forms.TextBox();
            this.txtNetaDiesel = new System.Windows.Forms.TextBox();
            this.txtNetaSuper = new System.Windows.Forms.TextBox();
            this.txtNetaCorriente = new System.Windows.Forms.TextBox();
            this.txtNetaTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridLecturasCargadas)).BeginInit();
            this.frameAdicionar.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalendarHasta
            // 
            this.CalendarHasta.Location = new System.Drawing.Point(304, 23);
            this.CalendarHasta.Name = "CalendarHasta";
            this.CalendarHasta.TabIndex = 15;
            this.CalendarHasta.Visible = false;
            this.CalendarHasta.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.CalendarHasta_DateChanged);
            // 
            // CalendarDesde
            // 
            this.CalendarDesde.Location = new System.Drawing.Point(77, 23);
            this.CalendarDesde.Name = "CalendarDesde";
            this.CalendarDesde.TabIndex = 14;
            this.CalendarDesde.Visible = false;
            this.CalendarDesde.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.CalendarDesde_DateChanged);
            // 
            // cmdExportTxt
            // 
            this.cmdExportTxt.Location = new System.Drawing.Point(614, 148);
            this.cmdExportTxt.Name = "cmdExportTxt";
            this.cmdExportTxt.Size = new System.Drawing.Size(75, 51);
            this.cmdExportTxt.TabIndex = 18;
            this.cmdExportTxt.Text = "Texto plano";
            this.cmdExportTxt.UseVisualStyleBackColor = true;
            // 
            // cmdExportExcel
            // 
            this.cmdExportExcel.Location = new System.Drawing.Point(704, 147);
            this.cmdExportExcel.Name = "cmdExportExcel";
            this.cmdExportExcel.Size = new System.Drawing.Size(75, 51);
            this.cmdExportExcel.TabIndex = 19;
            this.cmdExportExcel.Text = "Excel";
            this.cmdExportExcel.UseVisualStyleBackColor = true;
            // 
            // GridLecturasCargadas
            // 
            this.GridLecturasCargadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridLecturasCargadas.Location = new System.Drawing.Point(9, 245);
            this.GridLecturasCargadas.Name = "GridLecturasCargadas";
            this.GridLecturasCargadas.Size = new System.Drawing.Size(796, 241);
            this.GridLecturasCargadas.TabIndex = 16;
            // 
            // frameAdicionar
            // 
            this.frameAdicionar.Controls.Add(this.label10);
            this.frameAdicionar.Controls.Add(this.label9);
            this.frameAdicionar.Controls.Add(this.label8);
            this.frameAdicionar.Controls.Add(this.label7);
            this.frameAdicionar.Controls.Add(this.txtNetaDiesel);
            this.frameAdicionar.Controls.Add(this.txtNetaSuper);
            this.frameAdicionar.Controls.Add(this.txtNetaCorriente);
            this.frameAdicionar.Controls.Add(this.txtNetaTotal);
            this.frameAdicionar.Controls.Add(this.txtSobretasaDiesel);
            this.frameAdicionar.Controls.Add(this.txtSobretasaSuper);
            this.frameAdicionar.Controls.Add(this.txtSobretasaCorriente);
            this.frameAdicionar.Controls.Add(this.txtSobretasaTotal);
            this.frameAdicionar.Controls.Add(this.txtVentaDiesel);
            this.frameAdicionar.Controls.Add(this.txtVentaSuper);
            this.frameAdicionar.Controls.Add(this.txtVentaCorriente);
            this.frameAdicionar.Controls.Add(this.txtVentaTotal);
            this.frameAdicionar.Controls.Add(this.txtTotalGalonesDiesel);
            this.frameAdicionar.Controls.Add(this.label6);
            this.frameAdicionar.Controls.Add(this.txtTotalGalonesSuper);
            this.frameAdicionar.Controls.Add(this.txtTotalGalonesCorriente);
            this.frameAdicionar.Controls.Add(this.txtTotalGalones);
            this.frameAdicionar.Controls.Add(this.label5);
            this.frameAdicionar.Controls.Add(this.label4);
            this.frameAdicionar.Controls.Add(this.label3);
            this.frameAdicionar.Location = new System.Drawing.Point(25, 64);
            this.frameAdicionar.Name = "frameAdicionar";
            this.frameAdicionar.Size = new System.Drawing.Size(551, 165);
            this.frameAdicionar.TabIndex = 17;
            this.frameAdicionar.TabStop = false;
            this.frameAdicionar.Text = "Resumen lecturas";
            // 
            // txtTotalGalonesDiesel
            // 
            this.txtTotalGalonesDiesel.Location = new System.Drawing.Point(82, 132);
            this.txtTotalGalonesDiesel.Name = "txtTotalGalonesDiesel";
            this.txtTotalGalonesDiesel.ReadOnly = true;
            this.txtTotalGalonesDiesel.Size = new System.Drawing.Size(88, 20);
            this.txtTotalGalonesDiesel.TabIndex = 13;
            this.txtTotalGalonesDiesel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Diesel";
            // 
            // txtTotalGalonesSuper
            // 
            this.txtTotalGalonesSuper.Location = new System.Drawing.Point(82, 104);
            this.txtTotalGalonesSuper.Name = "txtTotalGalonesSuper";
            this.txtTotalGalonesSuper.ReadOnly = true;
            this.txtTotalGalonesSuper.Size = new System.Drawing.Size(88, 20);
            this.txtTotalGalonesSuper.TabIndex = 9;
            this.txtTotalGalonesSuper.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalGalonesCorriente
            // 
            this.txtTotalGalonesCorriente.Location = new System.Drawing.Point(82, 73);
            this.txtTotalGalonesCorriente.Name = "txtTotalGalonesCorriente";
            this.txtTotalGalonesCorriente.ReadOnly = true;
            this.txtTotalGalonesCorriente.Size = new System.Drawing.Size(87, 20);
            this.txtTotalGalonesCorriente.TabIndex = 8;
            this.txtTotalGalonesCorriente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalGalones
            // 
            this.txtTotalGalones.Location = new System.Drawing.Point(81, 43);
            this.txtTotalGalones.Name = "txtTotalGalones";
            this.txtTotalGalones.ReadOnly = true;
            this.txtTotalGalones.Size = new System.Drawing.Size(88, 20);
            this.txtTotalGalones.TabIndex = 7;
            this.txtTotalGalones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Super";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Corriente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total";
            // 
            // cmdCalendarHasta
            // 
            this.cmdCalendarHasta.Image = global::Exportador_Ventas_ServP.Properties.Resources.calendar;
            this.cmdCalendarHasta.Location = new System.Drawing.Point(476, 25);
            this.cmdCalendarHasta.Name = "cmdCalendarHasta";
            this.cmdCalendarHasta.Size = new System.Drawing.Size(22, 23);
            this.cmdCalendarHasta.TabIndex = 25;
            this.cmdCalendarHasta.UseVisualStyleBackColor = true;
            this.cmdCalendarHasta.Click += new System.EventHandler(this.cmdCalendarHasta_Click);
            // 
            // cmdCalendarDesde
            // 
            this.cmdCalendarDesde.Image = global::Exportador_Ventas_ServP.Properties.Resources.calendar;
            this.cmdCalendarDesde.Location = new System.Drawing.Point(249, 25);
            this.cmdCalendarDesde.Name = "cmdCalendarDesde";
            this.cmdCalendarDesde.Size = new System.Drawing.Size(22, 23);
            this.cmdCalendarDesde.TabIndex = 23;
            this.cmdCalendarDesde.UseVisualStyleBackColor = true;
            this.cmdCalendarDesde.Click += new System.EventHandler(this.cmdCalendarDesde_Click);
            // 
            // txtFechaHasta
            // 
            this.txtFechaHasta.Location = new System.Drawing.Point(357, 26);
            this.txtFechaHasta.Name = "txtFechaHasta";
            this.txtFechaHasta.Size = new System.Drawing.Size(116, 20);
            this.txtFechaHasta.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Hasta";
            // 
            // txtFechaDesde
            // 
            this.txtFechaDesde.Location = new System.Drawing.Point(130, 26);
            this.txtFechaDesde.Name = "txtFechaDesde";
            this.txtFechaDesde.Size = new System.Drawing.Size(115, 20);
            this.txtFechaDesde.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Fecha:  Desde";
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Location = new System.Drawing.Point(521, 25);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(133, 23);
            this.cmdConsultar.TabIndex = 26;
            this.cmdConsultar.Text = "Consultar Lecturas";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // txtVentaDiesel
            // 
            this.txtVentaDiesel.Location = new System.Drawing.Point(183, 131);
            this.txtVentaDiesel.Name = "txtVentaDiesel";
            this.txtVentaDiesel.ReadOnly = true;
            this.txtVentaDiesel.Size = new System.Drawing.Size(103, 20);
            this.txtVentaDiesel.TabIndex = 17;
            this.txtVentaDiesel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtVentaSuper
            // 
            this.txtVentaSuper.Location = new System.Drawing.Point(183, 103);
            this.txtVentaSuper.Name = "txtVentaSuper";
            this.txtVentaSuper.ReadOnly = true;
            this.txtVentaSuper.Size = new System.Drawing.Size(103, 20);
            this.txtVentaSuper.TabIndex = 16;
            this.txtVentaSuper.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtVentaCorriente
            // 
            this.txtVentaCorriente.Location = new System.Drawing.Point(183, 72);
            this.txtVentaCorriente.Name = "txtVentaCorriente";
            this.txtVentaCorriente.ReadOnly = true;
            this.txtVentaCorriente.Size = new System.Drawing.Size(102, 20);
            this.txtVentaCorriente.TabIndex = 15;
            this.txtVentaCorriente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtVentaTotal
            // 
            this.txtVentaTotal.Location = new System.Drawing.Point(182, 42);
            this.txtVentaTotal.Name = "txtVentaTotal";
            this.txtVentaTotal.ReadOnly = true;
            this.txtVentaTotal.Size = new System.Drawing.Size(103, 20);
            this.txtVentaTotal.TabIndex = 14;
            this.txtVentaTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSobretasaDiesel
            // 
            this.txtSobretasaDiesel.Location = new System.Drawing.Point(300, 131);
            this.txtSobretasaDiesel.Name = "txtSobretasaDiesel";
            this.txtSobretasaDiesel.ReadOnly = true;
            this.txtSobretasaDiesel.Size = new System.Drawing.Size(103, 20);
            this.txtSobretasaDiesel.TabIndex = 21;
            this.txtSobretasaDiesel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSobretasaSuper
            // 
            this.txtSobretasaSuper.Location = new System.Drawing.Point(300, 103);
            this.txtSobretasaSuper.Name = "txtSobretasaSuper";
            this.txtSobretasaSuper.ReadOnly = true;
            this.txtSobretasaSuper.Size = new System.Drawing.Size(103, 20);
            this.txtSobretasaSuper.TabIndex = 20;
            this.txtSobretasaSuper.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSobretasaCorriente
            // 
            this.txtSobretasaCorriente.Location = new System.Drawing.Point(300, 72);
            this.txtSobretasaCorriente.Name = "txtSobretasaCorriente";
            this.txtSobretasaCorriente.ReadOnly = true;
            this.txtSobretasaCorriente.Size = new System.Drawing.Size(102, 20);
            this.txtSobretasaCorriente.TabIndex = 19;
            this.txtSobretasaCorriente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSobretasaTotal
            // 
            this.txtSobretasaTotal.Location = new System.Drawing.Point(299, 43);
            this.txtSobretasaTotal.Name = "txtSobretasaTotal";
            this.txtSobretasaTotal.ReadOnly = true;
            this.txtSobretasaTotal.Size = new System.Drawing.Size(103, 20);
            this.txtSobretasaTotal.TabIndex = 18;
            this.txtSobretasaTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNetaDiesel
            // 
            this.txtNetaDiesel.Location = new System.Drawing.Point(417, 131);
            this.txtNetaDiesel.Name = "txtNetaDiesel";
            this.txtNetaDiesel.ReadOnly = true;
            this.txtNetaDiesel.Size = new System.Drawing.Size(103, 20);
            this.txtNetaDiesel.TabIndex = 25;
            this.txtNetaDiesel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNetaSuper
            // 
            this.txtNetaSuper.Location = new System.Drawing.Point(417, 103);
            this.txtNetaSuper.Name = "txtNetaSuper";
            this.txtNetaSuper.ReadOnly = true;
            this.txtNetaSuper.Size = new System.Drawing.Size(103, 20);
            this.txtNetaSuper.TabIndex = 24;
            this.txtNetaSuper.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNetaCorriente
            // 
            this.txtNetaCorriente.Location = new System.Drawing.Point(417, 73);
            this.txtNetaCorriente.Name = "txtNetaCorriente";
            this.txtNetaCorriente.ReadOnly = true;
            this.txtNetaCorriente.Size = new System.Drawing.Size(102, 20);
            this.txtNetaCorriente.TabIndex = 23;
            this.txtNetaCorriente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNetaTotal
            // 
            this.txtNetaTotal.Location = new System.Drawing.Point(416, 43);
            this.txtNetaTotal.Name = "txtNetaTotal";
            this.txtNetaTotal.ReadOnly = true;
            this.txtNetaTotal.Size = new System.Drawing.Size(103, 20);
            this.txtNetaTotal.TabIndex = 22;
            this.txtNetaTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Galones";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(201, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Venta Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(315, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Vr Sobretasa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(438, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Venta Neta";
            // 
            // Lecturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 496);
            this.Controls.Add(this.CalendarDesde);
            this.Controls.Add(this.CalendarHasta);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.cmdCalendarHasta);
            this.Controls.Add(this.cmdCalendarDesde);
            this.Controls.Add(this.txtFechaHasta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFechaDesde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdExportTxt);
            this.Controls.Add(this.cmdExportExcel);
            this.Controls.Add(this.GridLecturasCargadas);
            this.Controls.Add(this.frameAdicionar);
            this.MaximizeBox = false;
            this.Name = "Lecturas";
            this.Text = "Lecturas";
            ((System.ComponentModel.ISupportInitialize)(this.GridLecturasCargadas)).EndInit();
            this.frameAdicionar.ResumeLayout(false);
            this.frameAdicionar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar CalendarHasta;
        private System.Windows.Forms.MonthCalendar CalendarDesde;
        private System.Windows.Forms.Button cmdExportTxt;
        private System.Windows.Forms.Button cmdExportExcel;
        private System.Windows.Forms.DataGridView GridLecturasCargadas;
        private System.Windows.Forms.GroupBox frameAdicionar;
        private System.Windows.Forms.TextBox txtTotalGalonesDiesel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalGalonesSuper;
        private System.Windows.Forms.TextBox txtTotalGalonesCorriente;
        private System.Windows.Forms.TextBox txtTotalGalones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdCalendarHasta;
        private System.Windows.Forms.Button cmdCalendarDesde;
        private System.Windows.Forms.TextBox txtFechaHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFechaDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.TextBox txtNetaDiesel;
        private System.Windows.Forms.TextBox txtNetaSuper;
        private System.Windows.Forms.TextBox txtNetaCorriente;
        private System.Windows.Forms.TextBox txtNetaTotal;
        private System.Windows.Forms.TextBox txtSobretasaDiesel;
        private System.Windows.Forms.TextBox txtSobretasaSuper;
        private System.Windows.Forms.TextBox txtSobretasaCorriente;
        private System.Windows.Forms.TextBox txtSobretasaTotal;
        private System.Windows.Forms.TextBox txtVentaDiesel;
        private System.Windows.Forms.TextBox txtVentaSuper;
        private System.Windows.Forms.TextBox txtVentaCorriente;
        private System.Windows.Forms.TextBox txtVentaTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}