namespace Exportador_Ventas_ServP
{
    partial class ImportarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportarCliente));
            this.progressImport = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmdImportar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // progressImport
            // 
            this.progressImport.Location = new System.Drawing.Point(40, 79);
            this.progressImport.Name = "progressImport";
            this.progressImport.Size = new System.Drawing.Size(387, 23);
            this.progressImport.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(42, 43);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(65, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Preparado...";
            // 
            // cmdImportar
            // 
            this.cmdImportar.Location = new System.Drawing.Point(184, 113);
            this.cmdImportar.Name = "cmdImportar";
            this.cmdImportar.Size = new System.Drawing.Size(80, 26);
            this.cmdImportar.TabIndex = 2;
            this.cmdImportar.Text = "Importar";
            this.cmdImportar.UseVisualStyleBackColor = true;
            this.cmdImportar.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // ImportarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 150);
            this.Controls.Add(this.cmdImportar);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.progressImport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ImportarCliente";
            this.Text = "Importar Cliente";
            this.Load += new System.EventHandler(this.ImportarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressImport;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button cmdImportar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}