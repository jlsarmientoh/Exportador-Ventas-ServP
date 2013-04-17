using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EstacionDB.VO;
using Exportador_Ventas_ServP.Controller;
using EstacionDB.Utilidades;

namespace Exportador_Ventas_ServP
{
    public partial class Lecturas : Form
    {
        private List<LecturaVO> lecturasExportar;

        public List<LecturaVO> LecturasExportar
        {
            get { return lecturasExportar; }
            set { lecturasExportar = value; }
        }

        public Lecturas()
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

        private void cmdCalendarHasta_Click(object sender, EventArgs e)
        {
            if (!CalendarHasta.Visible)
            {
                CalendarHasta.Visible = true;
            }
            else
            {
                CalendarHasta.Visible = false;
            }
        }

        private void CalendarHasta_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtFechaHasta.Text = CalendarHasta.SelectionStart.ToString("dd-MM-yyyy");
            CalendarHasta.Visible = false;
        }

        private void CalendarDesde_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtFechaDesde.Text = CalendarDesde.SelectionStart.ToString("dd-MM-yyyy");
            CalendarDesde.Visible = false;
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CalendarHasta.SelectionStart >= CalendarDesde.SelectionStart)
                {
                    ControladorPersistencia cp = new ControladorPersistencia();
                    lecturasExportar = cp.consultarLecturas(CalendarDesde.SelectionStart, CalendarHasta.SelectionStart.AddDays(1));
                    GridLecturasCargadas.DataSource = lecturasExportar;

                    if (lecturasExportar.Count == 0)
                    {
                        MessageBox.Show("No se encontraron Lecturas para la fecha seleccionada", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmdExportExcel.Enabled = false;
                        cmdExportTxt.Enabled = false;
                        //frameAdicionar.Enabled = false;
                    }
                    else
                    {
                        cmdExportExcel.Enabled = true;
                        cmdExportTxt.Enabled = true;
                        //frameAdicionar.Enabled = false;
                    }
                    
                    txtTotalGalonesSuper.Text = "0";
                    txtTotalGalonesCorriente.Text = "0";
                    txtTotalGalones.Text = "0";
                    txtTotalGalonesDiesel.Text = "0";
                    txtNetaDiesel.Text = "0";
                    txtNetaSuper.Text = "0";
                    txtNetaCorriente.Text = "0";
                    txtNetaTotal.Text = "0";
                    txtSobretasaDiesel.Text = "0";
                    txtSobretasaSuper.Text = "0";
                    txtSobretasaCorriente.Text = "0";
                    txtSobretasaTotal.Text = "0";
                    txtVentaDiesel.Text = "0";
                    txtVentaSuper.Text = "0";
                    txtVentaCorriente.Text = "0";
                    txtVentaTotal.Text = "0";

                    totalizarCifras();
                }
                else
                {
                    MessageBox.Show("Fecha de inicio no puede ser mayor a la fecha final", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                if (ex.InnerException != null)
                {
                    msg += " " + ex.InnerException.Message;
                }
                MessageBox.Show(msg);
            }
        }

        private void totalizarCifras()
        {
            double totalGalones = 0;
            double totalVenta = 0;
            double totalSobretasa = 0;
            double totalNeta = 0;
            double galonesCorriente = 0;
            double galonesDiesel = 0;
            double galonesSuper = 0;
            double ventaCorriente = 0;
            double ventaDiesel = 0;
            double ventaSuper = 0;
            double sobretasaCorriente = 0;
            double sobretasaDiesel = 0;
            double sobretasaSuper = 0;
            double netaCorriente = 0;
            double netaDiesel = 0;
            double netaSuper = 0;

            foreach (LecturaVO lec in lecturasExportar)
            {
                totalGalones += lec.VentaGalones;
                totalVenta += lec.VentaTotal;
                totalSobretasa += lec.ValorSobretasa;
                totalNeta += lec.VentaNeta;

                if (Utilidades.codigoCorriente == lec.CodigoArticulo)
                {
                    galonesCorriente += lec.VentaGalones;
                    ventaCorriente += lec.VentaTotal;
                    sobretasaCorriente += lec.ValorSobretasa;
                    netaCorriente += lec.VentaNeta;
                }
                if (Utilidades.codigoSuper == lec.CodigoArticulo)
                {
                    galonesSuper += lec.VentaGalones;
                    ventaSuper += lec.VentaTotal;
                    sobretasaSuper += lec.ValorSobretasa;
                    netaSuper += lec.VentaNeta;
                }
                if (Utilidades.codigoDiesel == lec.CodigoArticulo)
                {
                    galonesDiesel += lec.VentaGalones;
                    ventaDiesel += lec.VentaTotal;
                    sobretasaDiesel += lec.ValorSobretasa;
                    netaDiesel += lec.VentaNeta;
                }       
            }

            txtTotalGalonesSuper.Text = galonesSuper.ToString("##.##");
            txtTotalGalonesCorriente.Text = galonesCorriente.ToString("##.##");
            txtTotalGalones.Text = totalGalones.ToString("##.##");
            txtTotalGalonesDiesel.Text = galonesDiesel.ToString("##.##");
            txtNetaDiesel.Text = netaDiesel.ToString("c");
            txtNetaSuper.Text = netaSuper.ToString("c");
            txtNetaCorriente.Text = netaCorriente.ToString("c");
            txtNetaTotal.Text = totalNeta.ToString("c");
            txtSobretasaDiesel.Text = sobretasaDiesel.ToString("c");
            txtSobretasaSuper.Text = sobretasaSuper.ToString("c");
            txtSobretasaCorriente.Text = sobretasaCorriente.ToString("c");
            txtSobretasaTotal.Text = totalSobretasa.ToString("c");
            txtVentaDiesel.Text = ventaDiesel.ToString("c");
            txtVentaSuper.Text = ventaSuper.ToString("c");
            txtVentaCorriente.Text = ventaCorriente.ToString("c");
            txtVentaTotal.Text = totalVenta.ToString("c");
        }
    }
}