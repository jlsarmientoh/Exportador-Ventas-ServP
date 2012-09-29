using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EstacionDB.Utilidades;
using EstacionDB.Exceptions;
using EstacionDB.DAO;

namespace Exportador_Ventas_ServP
{
    public partial class ExportarMovimientos : Form
    {
        private DateTime fecha;
        private string documento;
        public ExportarMovimientos()
        {
            InitializeComponent();
        }

        private void cmdExportTxt_Click(object sender, EventArgs e)
        {
            if (!txtDocumento.Text.Equals("") && !txtFechaDesde.Text.Equals(""))
            {
                fecha = CalendarDesde.SelectionStart;
                documento = txtDocumento.Text;
                cmdExportExcel.Enabled = false;
                cmdExportTxt.Enabled = false;
                workerTxt.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fecha e ingresar el # de documento contable", "Campo requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmdExportExcel_Click(object sender, EventArgs e)
        {
            if (!txtDocumento.Text.Equals("") && !txtFechaDesde.Text.Equals(""))
            {
                fecha = CalendarDesde.SelectionStart;
                documento = txtDocumento.Text;
                cmdExportExcel.Enabled = false;
                cmdExportTxt.Enabled = false;
                workerExcel.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fecha e ingresar el # de documento contable", "Campo requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void CalendarDesde_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtFechaDesde.Text = CalendarDesde.SelectionStart.ToString("dd-MM-yyyy");
            CalendarDesde.Visible = false;
        }

        private void workerTxt_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                ControladorPersistencia cp = new ControladorPersistencia();
                bool exportado = false;
                exportado = FileExporter.exportar(cp.getMovimientosContables(fecha, fecha, documento)
                    , Utilidades.rutaPrincipalExport + "movimientos_contables_" + fecha.ToString("dd-MM-yyy") + ".txt"
                    , FileExporter.PLANO);
                if (exportado)
                {
                    e.Result = "Exportado";
                }
                else
                {
                    e.Result = "No Exportado";
                }
            }
            catch (PersistenciaException ex)
            {
                e.Result = "Error al exportar: " + ex.Message;
            }
        }

        private void workerTxt_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show(e.Result.ToString(), "Resultado de la exportación", MessageBoxButtons.OK);            
            documento = "";
            cmdExportExcel.Enabled = true;
            cmdExportTxt.Enabled = true;
        }

        private void workerExcel_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                ControladorPersistencia cp = new ControladorPersistencia();
                bool exportado = false;
                exportado = FileExporter.exportar(cp.getMovimientosContables(fecha, fecha, documento)
                    , Utilidades.rutaPrincipalExport + "movimientos_contables_" + fecha.ToString("dd-MM-yyy") + ".csv"
                    , FileExporter.EXCEL);
                if (exportado)
                {
                    e.Result = "Exportado";
                }
                else
                {
                    e.Result = "No Exportado";
                }
            }
            catch (PersistenciaException ex)
            {
                e.Result = "Error al exportar: " + ex.Message;
            }
        }

        private void workerExcel_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show(e.Result.ToString(), "Resultado de la exportación", MessageBoxButtons.OK);            
            documento = "";
            cmdExportExcel.Enabled = true;
            cmdExportTxt.Enabled = true;
        }
    }
}