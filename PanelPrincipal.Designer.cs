namespace Exportador_Ventas_ServP
{
    partial class PanelPrincipal
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDiarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosEgresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.combustibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cierreVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.disposiciónDeEfectivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultasToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.ventasToolStripMenuItem1,
            this.movimientosToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.informesToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lecturasToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // lecturasToolStripMenuItem
            // 
            this.lecturasToolStripMenuItem.Name = "lecturasToolStripMenuItem";
            this.lecturasToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.lecturasToolStripMenuItem.Text = "Lecturas";
            this.lecturasToolStripMenuItem.Click += new System.EventHandler(this.lecturasToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // administrarToolStripMenuItem
            // 
            this.administrarToolStripMenuItem.Name = "administrarToolStripMenuItem";
            this.administrarToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.administrarToolStripMenuItem.Text = "Administrar";
            this.administrarToolStripMenuItem.Click += new System.EventHandler(this.administrarToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem1
            // 
            this.ventasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDiarioToolStripMenuItem});
            this.ventasToolStripMenuItem1.Name = "ventasToolStripMenuItem1";
            this.ventasToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.ventasToolStripMenuItem1.Text = "Ventas";
            // 
            // registroDiarioToolStripMenuItem
            // 
            this.registroDiarioToolStripMenuItem.Name = "registroDiarioToolStripMenuItem";
            this.registroDiarioToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.registroDiarioToolStripMenuItem.Text = "Registro diario";
            this.registroDiarioToolStripMenuItem.Click += new System.EventHandler(this.registroDiarioToolStripMenuItem_Click);
            // 
            // movimientosToolStripMenuItem
            // 
            this.movimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresosEgresosToolStripMenuItem});
            this.movimientosToolStripMenuItem.Name = "movimientosToolStripMenuItem";
            this.movimientosToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.movimientosToolStripMenuItem.Text = "Movimientos";
            // 
            // ingresosEgresosToolStripMenuItem
            // 
            this.ingresosEgresosToolStripMenuItem.Name = "ingresosEgresosToolStripMenuItem";
            this.ingresosEgresosToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.ingresosEgresosToolStripMenuItem.Text = "Egresos";
            this.ingresosEgresosToolStripMenuItem.Click += new System.EventHandler(this.ingresosEgresosToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.combustibleToolStripMenuItem});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // combustibleToolStripMenuItem
            // 
            this.combustibleToolStripMenuItem.Name = "combustibleToolStripMenuItem";
            this.combustibleToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.combustibleToolStripMenuItem.Text = "Combustible";
            this.combustibleToolStripMenuItem.Click += new System.EventHandler(this.combustibleToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cierreVentasToolStripMenuItem,
            this.disposiciónDeEfectivoToolStripMenuItem});
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // cierreVentasToolStripMenuItem
            // 
            this.cierreVentasToolStripMenuItem.Name = "cierreVentasToolStripMenuItem";
            this.cierreVentasToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.cierreVentasToolStripMenuItem.Text = "Cierre ventas";
            this.cierreVentasToolStripMenuItem.Click += new System.EventHandler(this.cierreVentasToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(40, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // disposiciónDeEfectivoToolStripMenuItem
            // 
            this.disposiciónDeEfectivoToolStripMenuItem.Name = "disposiciónDeEfectivoToolStripMenuItem";
            this.disposiciónDeEfectivoToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.disposiciónDeEfectivoToolStripMenuItem.Text = "Disposición de efectivo";
            this.disposiciónDeEfectivoToolStripMenuItem.Click += new System.EventHandler(this.disposiciónDeEfectivoToolStripMenuItem_Click);
            // 
            // PanelPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "PanelPrincipal";
            this.Text = "Gaslissa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registroDiarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresosEgresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem combustibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cierreVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disposiciónDeEfectivoToolStripMenuItem;
    }
}



