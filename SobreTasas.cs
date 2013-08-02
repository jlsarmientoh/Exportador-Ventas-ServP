using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Exportador_Ventas_ServP.Controller;
using EstacionDB.VO;
using EstacionDB.Exceptions;

namespace Exportador_Ventas_ServP
{
    public partial class SobreTasas : Form
    {
        private ControladorPersistencia cp = new ControladorPersistencia();
        private SobretasaVO currentSobretasa = null;

        public SobreTasas()
        {
            InitializeComponent();
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {   
            cboProducto.SelectedIndex = 0;
            txtFlete.Text = "0";
            txtPrecioBase.Text = "0";
            txtPrecioVenta.Text = "0";
            txtSobretasa.Text = "0";
            txtSoldicom.Text = "0";            
            txtFechaDesde.Text = "";
            txtFechaHasta.Text = "";
            cboProducto.Focus();
            currentSobretasa = null;
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentSobretasa == null)
                {
                    currentSobretasa = new SobretasaVO();
                }
                currentSobretasa.IdProducto = (int)cboProducto.SelectedValue;
                currentSobretasa.Fletes = double.Parse(txtFlete.Text);
                currentSobretasa.PrecioBase = double.Parse(txtPrecioBase.Text);
                currentSobretasa.Venta = double.Parse(txtPrecioVenta.Text);
                currentSobretasa.Sobretasa = double.Parse(txtSobretasa.Text);
                currentSobretasa.Soldicom = double.Parse(txtSoldicom.Text);
                DateTime fechaDesde = DateTime.Parse(txtFechaDesde.Text);
                DateTime fechaHasta = DateTime.Parse(txtFechaHasta.Text);
                currentSobretasa.Anio = fechaDesde.Year;
                currentSobretasa.Mes = fechaDesde.Month;
                currentSobretasa.DiaInicioVigencia = fechaDesde.Day;
                currentSobretasa.DiaFinVigenica = fechaHasta.Day;

                if (cp.guardarSobertasa(currentSobretasa))
                {
                    MessageBox.Show("Datos de la sobretasa han sido guardados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sobretasaVOBindingSource.DataSource = cp.consultarSobretasas();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar los datos de la sobretasa", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                cboProducto.Focus();
            }
            catch (PersistenciaException pe)
            {

            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            currentSobretasa = null;
            cboProducto.SelectedIndex = 0;
            txtFlete.Text = "0";
            txtPrecioBase.Text = "0";
            txtPrecioVenta.Text = "0";
            txtSobretasa.Text = "0";
            txtSoldicom.Text = "0";
            txtFechaDesde.Text = "";
            txtFechaHasta.Text = "";
            cboProducto.Focus();
        }

        private void SobreTasas_Load(object sender, EventArgs e)
        {
            productoVOBindingSource.DataSource = cp.consultarProductos();
            productoVOBindingSource1.DataSource = cp.consultarProductos();
            sobretasaVOBindingSource.DataSource = cp.consultarSobretasas();
        }

        private void gridSobretasa_SelectionChanged(object sender, EventArgs e)
        {
            if (sobretasaVOBindingSource.Current != null)
            {
                currentSobretasa = (SobretasaVO)sobretasaVOBindingSource.Current;
                cboProducto.SelectedValue = currentSobretasa.IdProducto;
                txtFlete.Text = currentSobretasa.Fletes.ToString();
                txtPrecioBase.Text = currentSobretasa.PrecioBase.ToString();
                txtPrecioVenta.Text = currentSobretasa.Venta.ToString();
                txtSobretasa.Text = currentSobretasa.Sobretasa.ToString();
                txtSoldicom.Text = currentSobretasa.Soldicom.ToString();
                DateTime fechaDesde = new DateTime(currentSobretasa.Anio, currentSobretasa.Mes, currentSobretasa.DiaInicioVigencia);
                DateTime fechaHasta = new DateTime(currentSobretasa.Anio, currentSobretasa.Mes, currentSobretasa.DiaFinVigenica);
                txtFechaDesde.Text = fechaDesde.ToShortDateString();
                txtFechaHasta.Text = fechaHasta.ToShortDateString();
            }
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            int idProd = (int)cboProducto.SelectedValue;
            DateTime fechaDesde = DateTime.Parse(txtFechaDesde.Text);
            sobretasaVOBindingSource.DataSource = cp.consultarSobretasasProductoFecha(fechaDesde.Month, fechaDesde.Year, idProd, fechaDesde.Day);
        }

        private void txtPrecioBase_Enter(object sender, EventArgs e)
        {
            txtPrecioBase.SelectionStart = 0;
            txtPrecioBase.SelectionLength = txtPrecioBase.Text.Length;
        }

        private void txtPrecioBase_Leave(object sender, EventArgs e)
        {
            try
            {
                double tmp = double.Parse(txtPrecioBase.Text);
                txtPrecioBase.Text = String.Format("{0,10:#,0.00}", tmp);
            }
            catch
            {
                txtPrecioBase.Text = String.Format("{0,10:#,0.00}", 0);
            }
        }

        private void txtPrecioBase_MouseClick(object sender, MouseEventArgs e)
        {
            txtPrecioBase.SelectionStart = 0;
            txtPrecioBase.SelectionLength = txtPrecioBase.Text.Length;
        }

        private void txtFlete_Enter(object sender, EventArgs e)
        {
            txtFlete.SelectionStart = 0;
            txtFlete.SelectionLength = txtFlete.Text.Length;
        }

        private void txtFlete_Leave(object sender, EventArgs e)
        {
            try
            {
                double tmp = double.Parse(txtFlete.Text);
                txtFlete.Text = String.Format("{0,10:#,0.00}", tmp);
            }
            catch
            {
                txtFlete.Text = String.Format("{0,10:#,0.00}", 0);
            }
        }

        private void txtFlete_MouseClick(object sender, MouseEventArgs e)
        {
            txtFlete.SelectionStart = 0;
            txtFlete.SelectionLength = txtFlete.Text.Length;
        }

        private void txtPrecioVenta_Enter(object sender, EventArgs e)
        {
            txtPrecioVenta.SelectionStart = 0;
            txtPrecioVenta.SelectionLength = txtPrecioVenta.Text.Length;
        }

        private void txtPrecioVenta_Leave(object sender, EventArgs e)
        {
            try
            {
                double tmp = double.Parse(txtPrecioVenta.Text);
                txtPrecioVenta.Text = String.Format("{0,10:#,0.00}", tmp);
            }
            catch
            {
                txtPrecioVenta.Text = String.Format("{0,10:#,0.00}", 0);
            }
        }

        private void txtPrecioVenta_MouseClick(object sender, MouseEventArgs e)
        {
            txtPrecioVenta.SelectionStart = 0;
            txtPrecioVenta.SelectionLength = txtPrecioVenta.Text.Length;
        }

        private void txtSoldicom_Enter(object sender, EventArgs e)
        {
            txtSoldicom.SelectionStart = 0;
            txtSoldicom.SelectionLength = txtSoldicom.Text.Length;
        }

        private void txtSoldicom_Leave(object sender, EventArgs e)
        {
            try
            {
                double tmp = double.Parse(txtSoldicom.Text);
                txtSoldicom.Text = String.Format("{0,10:#,0.00}", tmp);
            }
            catch
            {
                txtSoldicom.Text = String.Format("{0,10:#,0.00}", 0);
            }
        }

        private void txtSoldicom_MouseClick(object sender, MouseEventArgs e)
        {
            txtSoldicom.SelectionStart = 0;
            txtSoldicom.SelectionLength = txtSoldicom.Text.Length;
        }

        private void txtSobretasa_Enter(object sender, EventArgs e)
        {
            txtSobretasa.SelectionStart = 0;
            txtSobretasa.SelectionLength = txtSobretasa.Text.Length;
        }

        private void txtSobretasa_Leave(object sender, EventArgs e)
        {
            try
            {
                double tmp = double.Parse(txtSobretasa.Text);
                txtSobretasa.Text = String.Format("{0,10:#,0.00}", tmp);
            }
            catch
            {
                txtSobretasa.Text = String.Format("{0,10:#,0.00}", 0);
            }
        }

        private void txtSobretasa_MouseClick(object sender, MouseEventArgs e)
        {
            txtSobretasa.SelectionStart = 0;
            txtSobretasa.SelectionLength = txtSobretasa.Text.Length;
        }
    }
}