using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            this.crystalReportViewer1.RefreshReport();
        }
    }
}