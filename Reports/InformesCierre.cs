using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace Exportador_Ventas_ServP
{
    public partial class InformesCierre : Form
    {
        public InformesCierre()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ParameterFields campos = new ParameterFields();
            ParameterField nombreEDS = new ParameterField();
            ParameterDiscreteValue value = new ParameterDiscreteValue();
            nombreEDS.Name = "EDS_NOMBRE";
            nombreEDS.ParameterValueType = ParameterValueKind.StringParameter;
            value.Value = Exportador_Ventas_ServP.Properties.Settings.Default.nombreEDS;
            nombreEDS.DefaultValues.Add(value);
            nombreEDS.CurrentValues.Add(value);
            this.crystalReportViewer1.ParameterFieldInfo.Add(nombreEDS);
            //this.crystalReportViewer1.RefreshReport();
        }

        private void crystalReportViewer1_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {
            ParameterFields campos = new ParameterFields();
            ParameterField nombreEDS = new ParameterField();
            ParameterDiscreteValue value = new ParameterDiscreteValue();
            nombreEDS.Name = "EDS_NOMBRE";
            nombreEDS.ParameterValueType = ParameterValueKind.StringParameter;
            value.Value = Exportador_Ventas_ServP.Properties.Settings.Default.nombreEDS;
            nombreEDS.DefaultValues.Add(value);
            nombreEDS.CurrentValues.Add(value);
            this.crystalReportViewer1.ParameterFieldInfo.Add(nombreEDS);
        }
    }
}