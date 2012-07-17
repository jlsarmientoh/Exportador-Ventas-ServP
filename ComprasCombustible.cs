using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exportador_Ventas_ServP
{
    public partial class ComprasCombustible : Form
    {
        public ComprasCombustible()
        {
            InitializeComponent();
        }

        private void cmdCalendarDesde_Click(object sender, EventArgs e)
        {
            if (!CalendarDesde.Visible)
            {
                CalendarDesde.Visible = true;
            }
            else
            {
                CalendarDesde.Visible = false;
            }
        }

        private void txtFechaDesde_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalendarDesde_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtFechaDesde.Text = CalendarDesde.SelectionStart.ToString("dd-MM-yyyy");
            CalendarDesde.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}