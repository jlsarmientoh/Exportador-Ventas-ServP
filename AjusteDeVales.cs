using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EstacionDB.VO;
using Exportador_Ventas_ServP.Controller;

namespace Exportador_Ventas_ServP
{
    public partial class AjusteDeVales : Form
    {
        private VentaVO venta;
        private ControladorPersistencia cp = new ControladorPersistencia();
        public AjusteDeVales()
        {
            InitializeComponent();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            if (!txtTiquete.Text.Equals(""))
            {
                venta = cp.consultarVentaExpo(long.Parse(txtTiquete.Text));
                if (venta != null)
                {
                    txtCliente.Text = venta.Cliente;
                    txtPlaca.Text = venta.Placa;
                }
                else 
                {
                    MessageBox.Show("Venta no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (!txtNewPlaca.Text.Equals("") && cboCliente.SelectedIndex > -1)
            {
                venta.Placa = txtNewPlaca.Text;
                venta.Cliente = ((ClienteVO)cboCliente.SelectedItem).Nombre;
                venta.Nit = ((ClienteVO)cboCliente.SelectedItem).Identificacion;
                int i = cp.guardarVenta(venta);
                if (i > 0)
                {
                    MessageBox.Show("Venta actualizada", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Venta No actualizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AjusteDeVales_Load(object sender, EventArgs e)
        {
            clienteVOBindingSource.DataSource = cp.consultarClientes();
        }
    }
}