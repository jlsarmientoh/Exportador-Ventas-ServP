using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Exportador_Ventas_ServP.Reports.DTO;
using Exportador_Ventas_ServP.Controller;
using CrystalDecisions.Shared;
using EstacionDB.VO;

namespace Exportador_Ventas_ServP.Reports
{
    public partial class InformeVales : Form
    {
        private List<VentaDTO> detalles;
        private ControladorPersistencia cp = new ControladorPersistencia();
        public InformeVales()
        {
            InitializeComponent();
        }

        private void cmdGenerar_Click(object sender, EventArgs e)
        {
            if (!txtDesde.Text.Equals("  /  /") && !txtHasta.Text.Equals("  /  /") && cboClientes.SelectedIndex != -1)
            {

                if (this.crystalReportViewer1.Visible)
                {
                    this.crystalReportViewer1.Hide();
                    this.ListadoVales1.Refresh();
                    this.crystalReportViewer1.ReportSource = this.ListadoVales1;
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
            ParameterField cliente = new ParameterField();
            ParameterDiscreteValue value = new ParameterDiscreteValue();

            cliente.Name = ListadoVales1.Parameter_CLI_NOMBRE.ParameterFieldName;
            value = new ParameterDiscreteValue();
            cliente.ParameterValueType = ParameterValueKind.StringParameter;
            value.Value = ((ClienteVO)cboClientes.SelectedItem).Nombre;
            cliente.DefaultValues.Add(value);
            cliente.CurrentValues.Add(value);
            this.crystalReportViewer1.ParameterFieldInfo.Add(cliente);

            nombreEDS.Name = ListadoVales1.Parameter_EDS_NOMBRE.ParameterFieldName;
            value = new ParameterDiscreteValue();
            nombreEDS.ParameterValueType = ParameterValueKind.StringParameter;
            value.Value = Exportador_Ventas_ServP.Properties.Settings.Default.nombreEDS;
            nombreEDS.DefaultValues.Add(value);
            nombreEDS.CurrentValues.Add(value);
            this.crystalReportViewer1.ParameterFieldInfo.Add(nombreEDS);

            dirEDS.Name = ListadoVales1.Parameter_EDS_DIR.ParameterFieldName;
            value = new ParameterDiscreteValue();
            dirEDS.ParameterValueType = ParameterValueKind.StringParameter;
            value.Value = Exportador_Ventas_ServP.Properties.Settings.Default.Direccion;
            dirEDS.DefaultValues.Add(value);
            dirEDS.CurrentValues.Add(value);
            this.crystalReportViewer1.ParameterFieldInfo.Add(dirEDS);

            nitEDS.Name = ListadoVales1.Parameter_NIT_EDS.ParameterFieldName;
            value = new ParameterDiscreteValue();
            nitEDS.ParameterValueType = ParameterValueKind.StringParameter;
            value.Value = Exportador_Ventas_ServP.Properties.Settings.Default.NITEDS;
            nitEDS.DefaultValues.Add(value);
            nitEDS.CurrentValues.Add(value);
            this.crystalReportViewer1.ParameterFieldInfo.Add(nitEDS);

            telEDS.Name = ListadoVales1.Parameter_EDS_TEL.ParameterFieldName;
            value = new ParameterDiscreteValue();
            telEDS.ParameterValueType = ParameterValueKind.StringParameter;
            value.Value = Exportador_Ventas_ServP.Properties.Settings.Default.telefonoEDS;
            telEDS.DefaultValues.Add(value);
            telEDS.CurrentValues.Add(value);
            this.crystalReportViewer1.ParameterFieldInfo.Add(telEDS);

            fechaDesde.Name = ListadoVales1.Parameter_FECHA_INICIO.ParameterFieldName;
            value = new ParameterDiscreteValue();
            fechaDesde.ParameterValueType = ParameterValueKind.DateParameter;
            value.Value = DateTime.Parse(txtDesde.Text);
            fechaDesde.DefaultValues.Add(value);
            fechaDesde.CurrentValues.Add(value);
            this.crystalReportViewer1.ParameterFieldInfo.Add(fechaDesde);

            fechaHasta.Name = ListadoVales1.Parameter_FECHA_FIN.ParameterFieldName;
            value = new ParameterDiscreteValue();
            fechaHasta.ParameterValueType = ParameterValueKind.DateParameter;
            value.Value = DateTime.Parse(txtHasta.Text);
            fechaHasta.DefaultValues.Add(value);
            fechaHasta.CurrentValues.Add(value);
            this.crystalReportViewer1.ParameterFieldInfo.Add(fechaHasta);

            this.detalles = cp.consultarVentaCliente(DateTime.Parse(txtDesde.Text), DateTime.Parse(txtHasta.Text), ((ClienteVO)cboClientes.SelectedItem).Identificacion, ((ClienteVO)cboClientes.SelectedItem).Codigo);

            ListadoVales1.SetDataSource(this.detalles);
        }

        private void InformeVales_Load(object sender, EventArgs e)
        {   
            crystalReportViewer1.Hide();
            clienteVOBindingSource.DataSource = cp.consultarClientes();//cp.consultarClientesVentas();
        }

        private void InformeVales_Resize(object sender, EventArgs e)
        {
            panel1.SetBounds(panel1.Left, panel1.Top, this.Width - 30, this.Bottom - 30);
        }
    }
}