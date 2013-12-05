using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Exportador_Ventas_ServP.Controller;
using CrystalDecisions.Shared;
using EstacionDB.VO;
using EstacionDB.Core;
using EstacionDB.Exceptions;

namespace Exportador_Ventas_ServP.Reports
{
    public partial class InformeCombustible : Form
    {
        private ControladorPersistencia cp = new ControladorPersistencia();
        private int idProd = 0;
        private DateTime fechaInicio;
        private DateTime fechaFin;

        public InformeCombustible()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!txtDesde.Text.Equals("  /  /") && !txtHasta.Text.Equals("  /  /"))
            {
                this.UseWaitCursor = true;
                idProd = (int)cboProducto.SelectedValue;
                fechaInicio = DateTime.Parse(txtDesde.Text);
                fechaFin = DateTime.Parse(txtHasta.Text);
                procesarDatosWorker.RunWorkerAsync();
                /*if (this.crystalReportViewer1.Visible)
                {
                    this.crystalReportViewer1.Hide();
                    this.InformeCombustible1.Refresh();
                    this.crystalReportViewer1.ReportSource = this.InformeCombustible1;
                    getReportData();
                    this.crystalReportViewer1.Show();
                }
                else
                {
                    getReportData();
                    this.crystalReportViewer1.Show();
                }*/
            }
            else
            {
                MessageBox.Show("Debe selecionar fecha y producto", "Debe selecionar fecha y producto", MessageBoxButtons.OK ,MessageBoxIcon.Exclamation);
            }

        }

        private void InformeCombustible_Load(object sender, EventArgs e)
        {
            productoVOBindingSource.DataSource = cp.consultarProductos();
            cboProducto.SelectedIndex = 0;
            crystalReportViewer1.Hide();
        }

        private void InformeCombustible_ResizeEnd(object sender, EventArgs e)
        {
            
        }

        private void InformeCombustible_Resize(object sender, EventArgs e)
        {
            crystalReportViewer1.SetBounds(crystalReportViewer1.Left, crystalReportViewer1.Top, this.Width - 10, this.Bottom - 30);
        }

        private void crystalReportViewer1_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {
            getReportData();
        }

        private void getReportData()
        {
            ParameterFields campos = new ParameterFields();
            ParameterField nombreEDS = new ParameterField();
            ParameterField fechaDesde = new ParameterField();
            ParameterField fechaHasta = new ParameterField();
            ParameterField producto = new ParameterField();
            ParameterField idProducto = new ParameterField();
            ParameterField inventarioInicial = new ParameterField();

            nombreEDS.Name = "NOMBRE_EDS";
            ParameterDiscreteValue value = new ParameterDiscreteValue();
            nombreEDS.ParameterValueType = ParameterValueKind.StringParameter;
            value.Value = Exportador_Ventas_ServP.Properties.Settings.Default.nombreEDS;
            nombreEDS.DefaultValues.Add(value);
            nombreEDS.CurrentValues.Add(value);
            this.crystalReportViewer1.ParameterFieldInfo.Add(nombreEDS);
            
            fechaDesde.Name = "FECHA_INICIO";
            value = new ParameterDiscreteValue();
            fechaDesde.ParameterValueType = ParameterValueKind.DateParameter;
            value.Value = DateTime.Parse(txtDesde.Text);
            fechaDesde.DefaultValues.Add(value);
            fechaDesde.CurrentValues.Add(value);
            this.crystalReportViewer1.ParameterFieldInfo.Add(fechaDesde);
            
            fechaHasta.Name = "FECHA_FIN";
            value = new ParameterDiscreteValue();
            fechaHasta.ParameterValueType = ParameterValueKind.DateParameter;
            value.Value = DateTime.Parse(txtHasta.Text);
            fechaHasta.DefaultValues.Add(value);
            fechaHasta.CurrentValues.Add(value);
            this.crystalReportViewer1.ParameterFieldInfo.Add(fechaHasta);
            
            producto.Name = "PRODUCTO";
            value = new ParameterDiscreteValue();
            producto.ParameterValueType = ParameterValueKind.StringParameter;
            value.Value = cboProducto.Text;
            producto.DefaultValues.Add(value);
            producto.CurrentValues.Add(value);
            this.crystalReportViewer1.ParameterFieldInfo.Add(producto);
            
            idProducto.Name = "ID_PRODUCTO";
            value = new ParameterDiscreteValue();
            idProducto.ParameterValueType = ParameterValueKind.NumberParameter;
            value.Value = cboProducto.SelectedValue;
            idProducto.DefaultValues.Add(value);
            idProducto.CurrentValues.Add(value);
            this.crystalReportViewer1.ParameterFieldInfo.Add(idProducto);
            
            inventarioInicial.Name = "INVENTARIO_INICIAL";
            value = new ParameterDiscreteValue();
            inventarioInicial.ParameterValueType = ParameterValueKind.NumberParameter;

            List<ControlCombustibleVO> controles = cp.consultarControlProductoFecha((int)cboProducto.SelectedValue, DateTime.Parse(txtDesde.Text), DateTime.Parse(txtHasta.Text));
            if (controles.Count > 0)
            {
                ControlCombustibleVO cc = controles[0];
                value.Value = cc.InventarioInicial;
            }
            else
            {
                value.Value = 0;
            }
            inventarioInicial.DefaultValues.Add(value);
            inventarioInicial.CurrentValues.Add(value);
            this.crystalReportViewer1.ParameterFieldInfo.Add(inventarioInicial);
            
            

            //this.crystalReportViewer1.Show();
        }

        private void procesarDatosWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.UseWaitCursor = false;
            if (e.Result != null && e.Result.ToString().Length > 0)
            {
                MessageBox.Show(e.Result.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (this.crystalReportViewer1.Visible)
            {
                this.crystalReportViewer1.Hide();
                this.InformeCombustible1.Refresh();
                this.crystalReportViewer1.ReportSource = this.InformeCombustible1;
                getReportData();
                this.crystalReportViewer1.Show();
            }
            else
            {
                getReportData();
                this.crystalReportViewer1.Show();
            }
        }

        private void procesarDatosWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                ControlTanquesCore.getInstance().reProcesarControlesProducto(idProd, fechaInicio, fechaFin);
            }
            catch (ControlCombustibleException ex)
            {
                e.Result = ex.Message;
            }
        }
    }
}