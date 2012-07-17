using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exportador_Ventas_ServP.Reports
{
    public partial class InformeDisposicionEfectivo : Form
    {
        public InformeDisposicionEfectivo()
        {
            InitializeComponent();
        }

        private void DisposicionEfectivo_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            //this.crystalReportViewer1.ReportRefresh();
        }
    }
}