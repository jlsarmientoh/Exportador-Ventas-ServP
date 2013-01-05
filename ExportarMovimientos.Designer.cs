namespace Exportador_Ventas_ServP
{
    partial class ExportarMovimientos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdExportExcel = new System.Windows.Forms.Button();
            this.cmdExportTxt = new System.Windows.Forms.Button();
            this.CalendarDesde = new System.Windows.Forms.MonthCalendar();
            this.txtFechaDesde = new System.Windows.Forms.TextBox();
            this.cmdCalendarDesde = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.workerTxt = new System.ComponentModel.BackgroundWorker();
            this.workerExcel = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdExportExcel);
            this.groupBox1.Controls.Add(this.cmdExportTxt);
            this.groupBox1.Location = new System.Drawing.Point(32, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 83);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exportar";
            // 
            // cmdExportExcel
            // 
            this.cmdExportExcel.Location = new System.Drawing.Point(166, 32);
            this.cmdExportExcel.Name = "cmdExportExcel";
            this.cmdExportExcel.Size = new System.Drawing.Size(85, 26);
            this.cmdExportExcel.TabIndex = 16;
            this.cmdExportExcel.Text = "Excel (csv)";
            this.cmdExportExcel.UseVisualStyleBackColor = true;
            this.cmdExportExcel.Click += new System.EventHandler(this.cmdExportExcel_Click);
            // 
            // cmdExportTxt
            // 
            this.cmdExportTxt.Location = new System.Drawing.Point(62, 32);
            this.cmdExportTxt.Name = "cmdExportTxt";
            this.cmdExportTxt.Size = new System.Drawing.Size(89, 26);
            this.cmdExportTxt.TabIndex = 15;
            this.cmdExportTxt.Text = "Texto plano";
            this.cmdExportTxt.UseVisualStyleBackColor = true;
            this.cmdExportTxt.Click += new System.EventHandler(this.cmdExportTxt_Click);
            // 
            // CalendarDesde
            // 
            this.CalendarDesde.Location = new System.Drawing.Point(214, 23);
            this.CalendarDesde.Name = "CalendarDesde";
            this.CalendarDesde.TabIndex = 20;
            this.CalendarDesde.Visible = false;
            this.CalendarDesde.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.CalendarDesde_DateChanged);
            // 
            // txtFechaDesde
            // 
            this.txtFechaDesde.Location = new System.Drawing.Point(268, 24);
            this.txtFechaDesde.Name = "txtFechaDesde";
            this.txtFechaDesde.Size = new System.Drawing.Size(115, 20);
            this.txtFechaDesde.TabIndex = 21;
            // 
            // cmdCalendarDesde
            // 
            this.cmdCalendarDesde.Image = global::Exportador_Ventas_ServP.Properties.Resources.calendar;
            this.cmdCalendarDesde.Location = new System.Drawing.Point(385, 23);
            this.cmdCalendarDesde.Name = "cmdCalendarDesde";
            this.cmdCalendarDesde.Size = new System.Drawing.Size(22, 23);
            this.cmdCalendarDesde.TabIndex = 19;
            this.cmdCalendarDesde.UseVisualStyleBackColor = true;
            this.cmdCalendarDesde.Click += new System.EventHandler(this.cmdCalendarDesde_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Fecha:";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(37, 28);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(62, 13);
            this.lblDocumento.TabIndex = 22;
            this.lblDocumento.Text = "Documento";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(107, 25);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(100, 20);
            this.txtDocumento.TabIndex = 23;
            // 
            // workerTxt
            // 
            this.workerTxt.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerTxt_DoWork);
            this.workerTxt.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerTxt_RunWorkerCompleted);
            // 
            // workerExcel
            // 
            this.workerExcel.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerExcel_DoWork);
            this.workerExcel.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerExcel_RunWorkerCompleted);
            // 
            // ExportarMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 177);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.CalendarDesde);
            this.Controls.Add(this.txtFechaDesde);
            this.Controls.Add(this.cmdCalendarDesde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "ExportarMovimientos";
            this.Text = "ExportarMovimientos";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdExportExcel;
        private System.Windows.Forms.Button cmdExportTxt;
        private System.Windows.Forms.MonthCalendar CalendarDesde;
        private System.Windows.Forms.TextBox txtFechaDesde;
        private System.Windows.Forms.Button cmdCalendarDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.ComponentModel.BackgroundWorker workerTxt;
        private System.ComponentModel.BackgroundWorker workerExcel;
    }
}