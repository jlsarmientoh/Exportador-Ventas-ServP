﻿namespace Exportador_Ventas_ServP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelPrincipal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDiarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDiarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosEgresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.combustibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobretasasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cierreVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disposiciónDeEfectivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDeTanquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lecturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.ventasToolStripMenuItem1,
            this.movimientosToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.informesToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarToolStripMenuItem,
            this.importarToolStripMenuItem});
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
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.importarToolStripMenuItem.Text = "Importar";
            this.importarToolStripMenuItem.Click += new System.EventHandler(this.importarToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem1
            // 
            this.ventasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDiarioToolStripMenuItem,
            this.exportarToolStripMenuItem});
            this.ventasToolStripMenuItem1.Name = "ventasToolStripMenuItem1";
            this.ventasToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.ventasToolStripMenuItem1.Text = "Ventas";
            // 
            // registroDiarioToolStripMenuItem
            // 
            this.registroDiarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDiarioToolStripMenuItem1,
            this.modificarToolStripMenuItem});
            this.registroDiarioToolStripMenuItem.Name = "registroDiarioToolStripMenuItem";
            this.registroDiarioToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.registroDiarioToolStripMenuItem.Text = "Cierres";
            this.registroDiarioToolStripMenuItem.Click += new System.EventHandler(this.registroDiarioToolStripMenuItem_Click);
            // 
            // registroDiarioToolStripMenuItem1
            // 
            this.registroDiarioToolStripMenuItem1.Name = "registroDiarioToolStripMenuItem1";
            this.registroDiarioToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.registroDiarioToolStripMenuItem1.Text = "Registro diario";
            this.registroDiarioToolStripMenuItem1.Click += new System.EventHandler(this.registroDiarioToolStripMenuItem1_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.exportarToolStripMenuItem.Text = "Exportar";
            this.exportarToolStripMenuItem.Click += new System.EventHandler(this.exportarToolStripMenuItem_Click);
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
            this.combustibleToolStripMenuItem,
            this.sobretasasToolStripMenuItem});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.comprasToolStripMenuItem.Text = "Inventario";
            // 
            // combustibleToolStripMenuItem
            // 
            this.combustibleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lecturasToolStripMenuItem});
            this.combustibleToolStripMenuItem.Name = "combustibleToolStripMenuItem";
            this.combustibleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.combustibleToolStripMenuItem.Text = "Combustible";
            this.combustibleToolStripMenuItem.Click += new System.EventHandler(this.combustibleToolStripMenuItem_Click);
            // 
            // sobretasasToolStripMenuItem
            // 
            this.sobretasasToolStripMenuItem.Name = "sobretasasToolStripMenuItem";
            this.sobretasasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sobretasasToolStripMenuItem.Text = "Sobretasas";
            this.sobretasasToolStripMenuItem.Click += new System.EventHandler(this.sobretasasToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cierreVentasToolStripMenuItem,
            this.disposiciónDeEfectivoToolStripMenuItem,
            this.controlDeTanquesToolStripMenuItem});
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
            // disposiciónDeEfectivoToolStripMenuItem
            // 
            this.disposiciónDeEfectivoToolStripMenuItem.Name = "disposiciónDeEfectivoToolStripMenuItem";
            this.disposiciónDeEfectivoToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.disposiciónDeEfectivoToolStripMenuItem.Text = "Disposición de efectivo";
            this.disposiciónDeEfectivoToolStripMenuItem.Click += new System.EventHandler(this.disposiciónDeEfectivoToolStripMenuItem_Click);
            // 
            // controlDeTanquesToolStripMenuItem
            // 
            this.controlDeTanquesToolStripMenuItem.Name = "controlDeTanquesToolStripMenuItem";
            this.controlDeTanquesToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.controlDeTanquesToolStripMenuItem.Text = "Control de tanques";
            this.controlDeTanquesToolStripMenuItem.Click += new System.EventHandler(this.controlDeTanquesToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de ...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
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
            // lecturasToolStripMenuItem
            // 
            this.lecturasToolStripMenuItem.Name = "lecturasToolStripMenuItem";
            this.lecturasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lecturasToolStripMenuItem.Text = "Lecturas";
            this.lecturasToolStripMenuItem.Click += new System.EventHandler(this.lecturasToolStripMenuItem_Click_1);
            // 
            // PanelPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDiarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobretasasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlDeTanquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturasToolStripMenuItem;
    }
}



