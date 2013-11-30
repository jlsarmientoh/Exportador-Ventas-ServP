namespace Exportador_Ventas_ServP
{
    partial class ComprobarEgresos
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
            this.importWorker = new System.ComponentModel.BackgroundWorker();
            this.groupBoxResultados = new System.Windows.Forms.GroupBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.cmdSeleccionar = new System.Windows.Forms.Button();
            this.labelArchivo = new System.Windows.Forms.Label();
            this.progressImport = new System.Windows.Forms.ProgressBar();
            this.cmdReprocesar = new System.Windows.Forms.Button();
            this.groupBoxResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // importWorker
            // 
            this.importWorker.WorkerReportsProgress = true;
            this.importWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.importWorker_DoWork);
            this.importWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.importWorker_RunWorkerCompleted);
            this.importWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.importWorker_ProgressChanged);
            // 
            // groupBoxResultados
            // 
            this.groupBoxResultados.Controls.Add(this.txtResultado);
            this.groupBoxResultados.Location = new System.Drawing.Point(24, 63);
            this.groupBoxResultados.Name = "groupBoxResultados";
            this.groupBoxResultados.Size = new System.Drawing.Size(743, 426);
            this.groupBoxResultados.TabIndex = 0;
            this.groupBoxResultados.TabStop = false;
            this.groupBoxResultados.Text = "Resultados";
            // 
            // txtResultado
            // 
            this.txtResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResultado.Location = new System.Drawing.Point(3, 16);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(737, 407);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.Text = "Resultado:";
            // 
            // cmdSeleccionar
            // 
            this.cmdSeleccionar.Location = new System.Drawing.Point(28, 19);
            this.cmdSeleccionar.Name = "cmdSeleccionar";
            this.cmdSeleccionar.Size = new System.Drawing.Size(81, 27);
            this.cmdSeleccionar.TabIndex = 1;
            this.cmdSeleccionar.Text = "Examinar...";
            this.cmdSeleccionar.UseVisualStyleBackColor = true;
            this.cmdSeleccionar.Click += new System.EventHandler(this.cmdSeleccionar_Click);
            // 
            // labelArchivo
            // 
            this.labelArchivo.AutoSize = true;
            this.labelArchivo.Location = new System.Drawing.Point(122, 27);
            this.labelArchivo.Name = "labelArchivo";
            this.labelArchivo.Size = new System.Drawing.Size(154, 13);
            this.labelArchivo.TabIndex = 2;
            this.labelArchivo.Text = "No se ha seleccionado archivo";
            // 
            // progressImport
            // 
            this.progressImport.Location = new System.Drawing.Point(27, 495);
            this.progressImport.Name = "progressImport";
            this.progressImport.Size = new System.Drawing.Size(737, 23);
            this.progressImport.Step = 1;
            this.progressImport.TabIndex = 4;
            // 
            // cmdReprocesar
            // 
            this.cmdReprocesar.Image = global::Exportador_Ventas_ServP.Properties.Resources.refresh_hov;
            this.cmdReprocesar.Location = new System.Drawing.Point(736, 19);
            this.cmdReprocesar.Name = "cmdReprocesar";
            this.cmdReprocesar.Size = new System.Drawing.Size(25, 25);
            this.cmdReprocesar.TabIndex = 5;
            this.cmdReprocesar.UseVisualStyleBackColor = true;
            this.cmdReprocesar.Click += new System.EventHandler(this.cmdReprocesar_Click);
            // 
            // ComprobarEgresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 522);
            this.Controls.Add(this.cmdReprocesar);
            this.Controls.Add(this.progressImport);
            this.Controls.Add(this.labelArchivo);
            this.Controls.Add(this.cmdSeleccionar);
            this.Controls.Add(this.groupBoxResultados);
            this.MaximizeBox = false;
            this.Name = "ComprobarEgresos";
            this.Text = "Comprobar Egresos";
            this.groupBoxResultados.ResumeLayout(false);
            this.groupBoxResultados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker importWorker;
        private System.Windows.Forms.GroupBox groupBoxResultados;
        private System.Windows.Forms.Button cmdSeleccionar;
        private System.Windows.Forms.Label labelArchivo;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.ProgressBar progressImport;
        private System.Windows.Forms.Button cmdReprocesar;
    }
}