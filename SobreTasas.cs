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
            DateTime fechaDesde = new DateTime();
            DateTime fechaHasta = fechaDesde;
            txtFechaDesde.Text = fechaDesde.ToShortDateString();
            txtFechaHasta.Text = fechaHasta.ToShortDateString();
            cboProducto.Focus();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                currentSobretasa = new SobretasaVO();
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
            DateTime fechaDesde = new DateTime();
            DateTime fechaHasta = fechaDesde;
            txtFechaDesde.Text = fechaDesde.ToShortDateString();
            txtFechaHasta.Text = fechaHasta.ToShortDateString();
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
    }
}