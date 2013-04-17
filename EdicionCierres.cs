using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Exportador_Ventas_ServP.Controller;
using EstacionDB.Exceptions;
using EstacionDB.DTO;
using EstacionDB.VO;

namespace Exportador_Ventas_ServP
{
    public partial class EdicionCierres : Form
    {
        private double totalVentas = 0;
        private double totalCredito = 0;
        private double totalSodexo = 0;
        private double totalEfectivo = 0;
        private double totalBigPass = 0;
        private double totalOtros = 0;
        private double totalTarjetas = 0;
        private double totalPlus = 0;
        private double totalTicketTronik = 0;
        private CierreInfoDTO cierreInfo = null;

        private ControladorPersistencia cp = new ControladorPersistencia();

        public EdicionCierres()
        {
            InitializeComponent();
        }



        private void actualizarTotales()
        {
            totalVentas = 0;
            totalVentas += totalEfectivo;
            totalVentas += totalOtros;
            totalVentas += totalSodexo;
            totalVentas += totalBigPass;
            totalVentas += totalCredito;
            totalVentas += totalTarjetas;
            totalVentas += totalPlus;
            totalVentas += totalTicketTronik;

            txtCreditos.Text = String.Format("{0,10:#,0.00}", totalCredito);
            txtEfectivo.Text = String.Format("{0,10:#,0.00}", totalEfectivo);
            txtOtros.Text = String.Format("{0,10:#,0.00}", totalOtros);
            txtSodexo.Text = String.Format("{0,10:#,0.00}", totalSodexo);
            txtBigpass.Text = String.Format("{0,10:#,0.00}", totalBigPass);
            txtTarjetas.Text = String.Format("{0,10:#,0.00}", totalTarjetas);
            txtTarjetaPlus.Text = String.Format("{0,10:#,0.00}", totalPlus);
            txtTotal.Text = String.Format("{0,10:#,0.00}", totalVentas);
            txtTicketTronik.Text = String.Format("{0,10:#,0.00}", totalTicketTronik);
        }

        private void restaurarCampos()
        {   
            cmdGuardar.Enabled = false;
            cmdCancelar.Enabled = false;
            cierreVentasVOBindingSource.Clear();
            actualizarTotales();
            txtTotalConsumo.Text = String.Format("{0,10:#,0.00}", 0);
        }

        private void txtEfectivo_Leave(object sender, EventArgs e)
        {
            try
            {
                totalEfectivo = double.Parse(txtEfectivo.Text);
            }
            catch { }
            actualizarTotales();
        }

        private void txtSodexo_Leave(object sender, EventArgs e)
        {
            try
            {
                totalSodexo = double.Parse(txtSodexo.Text);
            }
            catch { }
            actualizarTotales();
        }

        private void txtBigpass_Leave(object sender, EventArgs e)
        {
            try
            {
                totalBigPass = double.Parse(txtBigpass.Text);
            }
            catch { }
            actualizarTotales();
        }

        private void txtCreditos_Leave(object sender, EventArgs e)
        {
            try
            {
                totalCredito = double.Parse(txtCreditos.Text);
            }
            catch { }
            actualizarTotales();
        }

        private void txtOtros_Leave(object sender, EventArgs e)
        {
            try
            {
                totalOtros = double.Parse(txtOtros.Text);
            }
            catch { }
            actualizarTotales();
        }

        private void txtEfectivo_Enter(object sender, EventArgs e)
        {
            txtEfectivo.SelectionStart = 0;
            txtEfectivo.SelectionLength = txtEfectivo.Text.Length;
        }

        private void txtSodexo_Enter(object sender, EventArgs e)
        {
            txtSodexo.SelectionStart = 0;
            txtSodexo.SelectionLength = txtSodexo.Text.Length;
        }

        private void txtBigpass_Enter(object sender, EventArgs e)
        {
            txtBigpass.SelectionStart = 0;
            txtBigpass.SelectionLength = txtBigpass.Text.Length;
        }

        private void txtOtros_Enter(object sender, EventArgs e)
        {
            txtOtros.SelectionStart = 0;
            txtOtros.SelectionLength = txtOtros.Text.Length;
        }

        private void txtTarjetaPlus_Enter(object sender, EventArgs e)
        {
            txtTarjetaPlus.SelectionStart = 0;
            txtTarjetaPlus.SelectionLength = txtTarjetaPlus.Text.Length;
        }

        private void txtTarjetas_Enter(object sender, EventArgs e)
        {
            txtTarjetas.SelectionStart = 0;
            txtTarjetas.SelectionLength = txtTarjetas.Text.Length;
        }

        private void txtTarjetas_Leave(object sender, EventArgs e)
        {
            try
            {
                totalTarjetas = double.Parse(txtTarjetas.Text);
            }
            catch { }
            actualizarTotales();
        }

        private void txtEfectivo_MouseClick(object sender, MouseEventArgs e)
        {
            txtEfectivo.SelectionStart = 0;
            txtEfectivo.SelectionLength = txtEfectivo.Text.Length;
        }

        private void txtSodexo_MouseClick(object sender, MouseEventArgs e)
        {
            txtSodexo.SelectionStart = 0;
            txtSodexo.SelectionLength = txtSodexo.Text.Length;
        }

        private void txtBigpass_MouseClick(object sender, MouseEventArgs e)
        {
            txtBigpass.SelectionStart = 0;
            txtBigpass.SelectionLength = txtBigpass.Text.Length;
        }

        private void txtTarjetas_MouseClick(object sender, MouseEventArgs e)
        {
            txtTarjetas.SelectionStart = 0;
            txtTarjetas.SelectionLength = txtTarjetas.Text.Length;
        }

        private void txtOtros_MouseClick(object sender, MouseEventArgs e)
        {
            txtOtros.SelectionStart = 0;
            txtOtros.SelectionLength = txtOtros.Text.Length;
        }

        private void txtTicketTronik_Leave(object sender, EventArgs e)
        {
            try
            {
                totalTicketTronik = double.Parse(txtTicketTronik.Text);
            }
            catch { }
            actualizarTotales();
        }

        private void txtTicketTronik_Enter(object sender, EventArgs e)
        {
            txtTicketTronik.SelectionStart = 0;
            txtTicketTronik.SelectionLength = txtTicketTronik.Text.Length;
        }

        private void txtTicketTronik_MouseClick(object sender, MouseEventArgs e)
        {
            txtTicketTronik.SelectionStart = 0;
            txtTicketTronik.SelectionLength = txtTicketTronik.Text.Length;
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtFecha.Text.Equals(""))
                {
                    DateTime fechaConsulta = DateTime.Parse(txtFecha.Text);
                    cierreInfo = cp.getCierreInfo(fechaConsulta, fechaConsulta);
                    cierreVentasVOBindingSource.DataSource = cierreInfo.CierresTurnos;
                    txtTotalConsumo.Text = String.Format("{0,10:#,0.00}", cierreInfo.TotalConsumo);

                    totalVentas = cierreInfo.CierreDia.TotalVentas;
                    totalEfectivo = cierreInfo.CierreDia.Efectivo;
                    totalOtros = cierreInfo.CierreDia.Otros;
                    totalSodexo = cierreInfo.CierreDia.Sodexo;
                    totalBigPass = cierreInfo.CierreDia.BigPass;
                    totalCredito = cierreInfo.CierreDia.Creditos;
                    totalTarjetas = cierreInfo.CierreDia.Tarjetas;
                    totalPlus = cierreInfo.CierreDia.TarjetaPlus;
                    totalTicketTronik = cierreInfo.CierreDia.TicketTronik;

                    actualizarTotales();

                    cmdGuardar.Enabled = true;
                    cmdCancelar.Enabled = true;
                }
                else
                {

                }
            }
            catch (PersistenciaException pe)
            {
                MessageBox.Show(pe.Message, "Error al consultar la información del cierre", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
               
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            System.Collections.IList tmpCierres = cierreVentasVOBindingSource.List;
            CierreVentasVO[] cierres = new CierreVentasVO[tmpCierres.Count];
            tmpCierres.CopyTo(cierres, 0);

            /*DateTime fecha = DateTime.Parse(txtFechaDesde.Text);
            DateTime fechaAplica = DateTime.Parse(txtFechaAplica.Text);*/

            int res = 0;
            res = cp.guardarCierres(new List<CierreVentasVO>(cierres));

            MessageBox.Show("Cierres guardados para la fecha: " + txtFecha.Text, "Cambios guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cierreVentasVOBindingSource.Clear();
            totalEfectivo = 0;
            totalOtros = 0;
            totalSodexo = 0;
            totalBigPass = 0;
            totalCredito = 0;
            totalTarjetas = 0;
            totalPlus = 0;
            totalTicketTronik = 0;
            totalVentas = 0;

            restaurarCampos();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            cierreVentasVOBindingSource.Clear();
            totalEfectivo = 0;
            totalOtros = 0;
            totalSodexo = 0;
            totalBigPass = 0;
            totalCredito = 0;
            totalTarjetas = 0;
            totalPlus = 0;
            totalTicketTronik = 0;
            totalVentas = 0;

            restaurarCampos();
        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            CierreVentasVO tmpCierre = (CierreVentasVO)cierreVentasVOBindingSource.List[e.RowIndex];
            tmpCierre.TotalVentas = recalcularTotalCierre(tmpCierre);
            cierreVentasVOBindingSource.List[e.RowIndex] = tmpCierre;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CierreVentasVO tmpCierre = (CierreVentasVO)cierreVentasVOBindingSource.List[e.RowIndex];
            tmpCierre.TotalVentas = recalcularTotalCierre(tmpCierre);
            cierreVentasVOBindingSource.List[e.RowIndex] = tmpCierre;
        }

        private double recalcularTotalCierre(CierreVentasVO cierre)
        {
            double totalCierre = 0;

            totalCierre += cierre.Efectivo;
            totalCierre += cierre.Otros;
            totalCierre += cierre.Sodexo;
            totalCierre += cierre.BigPass;
            totalCierre += cierre.Creditos;
            totalCierre += cierre.Tarjetas;
            totalCierre += cierre.TarjetaPlus;
            totalCierre += cierre.TicketTronik;

            return totalCierre;
        }

        
    }
}