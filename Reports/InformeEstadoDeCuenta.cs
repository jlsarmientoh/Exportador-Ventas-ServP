using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Exportador_Ventas_ServP.Reports.DTO;
using CrystalDecisions.Shared;
using Exportador_Ventas_ServP.Controller;
using EstacionDB.VO;
using EstacionDB.Utilidades;
using EstacionDB.DTO;

namespace Exportador_Ventas_ServP.Reports
{
    public partial class InformeEstadoDeCuenta : Form
    {
        private List<EstadoCuentaDTO> detalles;
        private ControladorPersistencia cp = new ControladorPersistencia();
       

        public InformeEstadoDeCuenta()
        {
            InitializeComponent();
        }

        private void cmdGenerar_Click(object sender, EventArgs e)
        {
            if (!txtDesde.Text.Equals("  /  /") && !txtHasta.Text.Equals("  /  /") && cboClientes.SelectedIndex != -1 && cboModoPago.SelectedIndex != -1)
            {
                
                if (this.crystalReportViewer1.Visible)
                {
                    this.crystalReportViewer1.Hide();
                    this.EstadoDeCuenta1.Refresh();                    
                    this.crystalReportViewer1.ReportSource = this.EstadoDeCuenta1;
                    getReportData();
                    this.crystalReportViewer1.Show();
                }
                else
                {
                    getReportData();
                    this.crystalReportViewer1.Show();
                }
            }
        }

        private void getReportData()
        {
            ParameterFields campos = new ParameterFields();
            ParameterField nombreEDS = new ParameterField();
            ParameterField fechaDesde = new ParameterField();
            ParameterField fechaHasta = new ParameterField();
            ParameterField dirEDS = new ParameterField();
            ParameterField nitEDS = new ParameterField();
            ParameterField telEDS = new ParameterField();
            ParameterField cuenta = new ParameterField();
            ParameterField nitCliente = new ParameterField();
            ParameterField cliente = new ParameterField();
            ParameterField telCliente = new ParameterField();
            ParameterField total = new ParameterField();
            ParameterDiscreteValue value = new ParameterDiscreteValue();
            double totalEstadoCuenta = 0;

            telCliente.Name = EstadoDeCuenta1.Parameter_CLI_TEL.ParameterFieldName;
            value = new ParameterDiscreteValue();
            telCliente.ParameterValueType = ParameterValueKind.StringParameter;
            // Intenta obtener el teléfono del cliente
            NitDTO tmpNit = Utilidades.formatearNit(((ClienteVO)cboClientes.SelectedItem).Identificacion);
            List<ClienteVO> tmpCli = cp.consultarClientesPorCampo(tmpNit.Nit, Utilidades.C_CLI_NIT);
            if (tmpCli.Count > 0)
            {
                value.Value = tmpCli[0].Telefono + " - " + tmpCli[0].Direccion;
            }
            else
            {
                value.Value = "No registra";
            }
            telCliente.DefaultValues.Add(value);
            telCliente.CurrentValues.Add(value);
            this.crystalReportViewer1.ParameterFieldInfo.Add(telCliente);

            cliente.Name = EstadoDeCuenta1.Parameter_CLI_NOMBRE.ParameterFieldName;
            value = new ParameterDiscreteValue();
            cliente.ParameterValueType = ParameterValueKind.StringParameter;
            value.Value = ((ClienteVO)cboClientes.SelectedItem).Nombre;
            cliente.DefaultValues.Add(value);
            cliente.CurrentValues.Add(value);
            this.crystalReportViewer1.ParameterFieldInfo.Add(cliente);

            nitCliente.Name = EstadoDeCuenta1.Parameter_CLI_NIT.ParameterFieldName;
            value = new ParameterDiscreteValue();
            nitCliente.ParameterValueType = ParameterValueKind.StringParameter;
            value.Value = ((ClienteVO)cboClientes.SelectedItem).Identificacion;
            nitCliente.DefaultValues.Add(value);
            nitCliente.CurrentValues.Add(value);
            this.crystalReportViewer1.ParameterFieldInfo.Add(nitCliente);

            cuenta.Name = EstadoDeCuenta1.Parameter_N_CUENTA.ParameterFieldName;
            value = new ParameterDiscreteValue();
            cuenta.ParameterValueType = ParameterValueKind.StringParameter;
            value.Value = getNumeroCuenta(DateTime.Now);
            cuenta.DefaultValues.Add(value);
            cuenta.CurrentValues.Add(value);
            this.crystalReportViewer1.ParameterFieldInfo.Add(cuenta);

            nombreEDS.Name = EstadoDeCuenta1.Parameter_EDS_NOMBRE.ParameterFieldName;
            value = new ParameterDiscreteValue();
            nombreEDS.ParameterValueType = ParameterValueKind.StringParameter;
            value.Value = Exportador_Ventas_ServP.Properties.Settings.Default.nombreEDS;
            nombreEDS.DefaultValues.Add(value);
            nombreEDS.CurrentValues.Add(value);
            this.crystalReportViewer1.ParameterFieldInfo.Add(nombreEDS);

            dirEDS.Name = EstadoDeCuenta1.Parameter_EDS_DIR.ParameterFieldName;
            value = new ParameterDiscreteValue();
            dirEDS.ParameterValueType = ParameterValueKind.StringParameter;
            value.Value = Exportador_Ventas_ServP.Properties.Settings.Default.Direccion;
            dirEDS.DefaultValues.Add(value);
            dirEDS.CurrentValues.Add(value);
            this.crystalReportViewer1.ParameterFieldInfo.Add(dirEDS);

            nitEDS.Name = EstadoDeCuenta1.Parameter_EDS_NIT.ParameterFieldName;
            value = new ParameterDiscreteValue();
            nitEDS.ParameterValueType = ParameterValueKind.StringParameter;
            value.Value = Exportador_Ventas_ServP.Properties.Settings.Default.NITEDS;
            nitEDS.DefaultValues.Add(value);
            nitEDS.CurrentValues.Add(value);
            this.crystalReportViewer1.ParameterFieldInfo.Add(nitEDS);

            telEDS.Name = EstadoDeCuenta1.Parameter_EDS_TEL.ParameterFieldName;
            value = new ParameterDiscreteValue();
            telEDS.ParameterValueType = ParameterValueKind.StringParameter;
            value.Value = Exportador_Ventas_ServP.Properties.Settings.Default.telefonoEDS;
            telEDS.DefaultValues.Add(value);
            telEDS.CurrentValues.Add(value);
            this.crystalReportViewer1.ParameterFieldInfo.Add(telEDS);

            fechaDesde.Name = EstadoDeCuenta1.Parameter_FECHA_DESDE.ParameterFieldName;
            value = new ParameterDiscreteValue();
            fechaDesde.ParameterValueType = ParameterValueKind.DateParameter;
            value.Value = DateTime.Parse(txtDesde.Text);
            fechaDesde.DefaultValues.Add(value);
            fechaDesde.CurrentValues.Add(value);
            this.crystalReportViewer1.ParameterFieldInfo.Add(fechaDesde);

            fechaHasta.Name = EstadoDeCuenta1.Parameter_FECHA_HASTA.ParameterFieldName;
            value = new ParameterDiscreteValue();
            fechaHasta.ParameterValueType = ParameterValueKind.DateParameter;
            value.Value = DateTime.Parse(txtHasta.Text);
            fechaHasta.DefaultValues.Add(value);
            fechaHasta.CurrentValues.Add(value);
            this.crystalReportViewer1.ParameterFieldInfo.Add(fechaHasta);

            List<VentaVO> ventas = null;
            if (((ModoPagoDTO)cboModoPago.SelectedItem).Id == 0)
            {
                ventas = cp.consultarVentasAgrupadas(DateTime.Parse(txtDesde.Text), DateTime.Parse(txtHasta.Text), ((ClienteVO)cboClientes.SelectedItem).Identificacion, ((ClienteVO)cboClientes.SelectedItem).Codigo);
            }
            else
            {
                ventas = cp.consultarVentasAgrupadas(DateTime.Parse(txtDesde.Text), DateTime.Parse(txtHasta.Text), ((ClienteVO)cboClientes.SelectedItem).Identificacion, ((ClienteVO)cboClientes.SelectedItem).Codigo, ((ModoPagoDTO)cboModoPago.SelectedItem).Id);
            }
            this.detalles = new List<EstadoCuentaDTO>();
            foreach (VentaVO v in ventas)
            {
                EstadoCuentaDTO e = new EstadoCuentaDTO();
                e.Producto = v.Producto;
                e.ValorBruto = v.Total;
                e.ValorTotal = v.Total;
                totalEstadoCuenta += v.Total;
                this.detalles.Add(e);
            }

            total.Name = EstadoDeCuenta1.Parameter_TOTAL.ParameterFieldName;
            value = new ParameterDiscreteValue();
            fechaHasta.ParameterValueType = ParameterValueKind.NumberParameter;
            value.Value = totalEstadoCuenta;
            total.DefaultValues.Add(value);
            total.CurrentValues.Add(value);
            this.crystalReportViewer1.ParameterFieldInfo.Add(total);

            EstadoDeCuenta1.SetDataSource(this.detalles);

            //this.crystalReportViewer1.Show();
        }

        private string getNumeroCuenta(DateTime d)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(d.Year);
            sb.Append(d.Month);
            sb.Append(d.Day);
            sb.Append(d.Millisecond);
            return sb.ToString();
        }

        private List<ModoPagoDTO> getModosPago(){
            List<ModoPagoDTO> modos = new List<ModoPagoDTO>();
            modos.Add(new ModoPagoDTO(7, "Crédito con CHIP"));
            modos.Add(new ModoPagoDTO(1, "Crédito sin CHIP"));
            modos.Add(new ModoPagoDTO(2, "Tarjeta Plus"));
            modos.Add(new ModoPagoDTO(0, "Consolidado"));

            return modos;
        }

        private void InformeEstadoDeCuenta_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.Hide();
            clienteVOBindingSource.DataSource = cp.consultarClientes();//consultarClientesVentas();
            modoPagoDTOBindingSource.DataSource = getModosPago();
        }

        private void InformeEstadoDeCuenta_Resize(object sender, EventArgs e)
        {
            panel1.SetBounds(panel1.Left, panel1.Top, this.Width - 30, this.Bottom - 30);
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void InformeEstadoDeCuenta_ResizeEnd(object sender, EventArgs e)
        {
            
        }

        private void crystalReportViewer1_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {
            getReportData();
        }
    }
}