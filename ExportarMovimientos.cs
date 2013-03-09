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
        private DateTime fechaHasta;
        private DateTime tmFecha;
        private string documento;
        private bool rango;
        private TimeSpan intervalo;
        private ControladorPersistencia cp = new ControladorPersistencia();
        public ExportarMovimientos()
        {
            InitializeComponent();
        }

        private void cmdExportTxt_Click(object sender, EventArgs e)
        {
            if (!txtDocumento.Text.Equals("") && !txtFechaDesde.Text.Equals(""))
            {
                fecha = CalendarDesde.SelectionStart;
                fechaHasta = calendarHasta.SelectionStart;
                documento = txtDocumento.Text;
                rango = chkRango.Checked;
                cmdExportExcel.Enabled = false;
                cmdExportTxt.Enabled = false;
                if (chkRango.Checked && !txtFechaHasta.Text.Equals(""))
                {   
                    fechaHasta = calendarHasta.SelectionStart;
                    intervalo = fechaHasta - fecha;
                }
                else
                {
                    fechaHasta = fecha;
                    intervalo = fechaHasta - fecha;
                }
                tmFecha = fecha;
                progressImport.Maximum = (intervalo.Days + 1);
                progressImport.Step = 1;
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
                fechaHasta = calendarHasta.SelectionStart;
                documento = txtDocumento.Text;
                rango = chkRango.Checked;
                cmdExportExcel.Enabled = false;
                cmdExportTxt.Enabled = false;
                if (chkRango.Checked && !txtFechaHasta.Text.Equals(""))
                {
                    fechaHasta = calendarHasta.SelectionStart;
                    intervalo = fechaHasta - fecha;
                }
                else
                {
                    fechaHasta = fecha;
                    intervalo = fechaHasta - fecha;
                }
                tmFecha = fecha;
                progressImport.Maximum = (intervalo.Days + 1);
                progressImport.Step = 1;
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
                //ControladorPersistencia cp = new ControladorPersistencia();
                bool exportado = false;
                int i = 0; // cuenta los exportados
                int j = 0; // cuenta los nos exportados
                int k = 0; // cuenta el progreso general
                if (rango)
                {
                    while (DateTime.Compare(tmFecha, fechaHasta) <= 0)
                    {
                        StringBuilder sb = new StringBuilder();
                        if (tmFecha.Day < 10)
                        {
                            sb.Append("0");
                        }
                        sb.Append(tmFecha.Day);
                        if (tmFecha.Month < 10)
                        {
                            sb.Append("0");
                        }
                        sb.Append(tmFecha.Month);
                        documento = sb.ToString();
                        exportado = FileExporter.exportar(cp.getMovimientosContables(tmFecha, tmFecha, documento)
                            , Utilidades.rutaPrincipalExport + "movimientos_contables_" + tmFecha.ToString("dd-MM-yyy") + ".txt"
                            , FileExporter.PLANO);
                        if (exportado)
                        {
                            i++;
                            //e.Result = "Exportado";
                        }
                        else
                        {
                            j++;
                            //e.Result = "No Exportado";
                        }
                        k++;
                        tmFecha = tmFecha.AddDays(1d);
                        workerTxt.ReportProgress(k);
                    }

                    e.Result = "Exportados: ("+ i +")\nNo exportados: ("+ j +")";
                }
                else
                {
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
            chkRango.Checked = false;
            progressImport.Value = 0;
            /*tmFecha = null;
            fecha = null;
            fechaHasta = null;*/
        }

        private void workerExcel_DoWork(object sender, DoWorkEventArgs e)
        {
            
            try
            {
                //ControladorPersistencia cp = new ControladorPersistencia();
                bool exportado = false;
                int i = 0; // cuenta los exportados
                int j = 0; // cuenta los nos exportados
                int k = 0; // cuenta el progreso general
                if (rango)
                {
                    while (DateTime.Compare(tmFecha, fechaHasta) <= 0)
                    {
                        StringBuilder sb = new StringBuilder();
                        if (tmFecha.Day < 10)
                        {
                            sb.Append("0");
                        }
                        sb.Append(tmFecha.Day);
                        if (tmFecha.Month < 10)
                        {
                            sb.Append("0");
                        }
                        sb.Append(tmFecha.Month);
                        documento = sb.ToString();
                        exportado = FileExporter.exportar(cp.getMovimientosContables(tmFecha, tmFecha, documento)
                            , Utilidades.rutaPrincipalExport + "movimientos_contables_" + tmFecha.ToString("dd-MM-yyy") + ".csv"
                            , FileExporter.EXCEL);
                        if (exportado)
                        {
                            i++;
                            //e.Result = "Exportado";
                        }
                        else
                        {
                            j++;
                            //e.Result = "No Exportado";
                        }
                        k++;
                        tmFecha = tmFecha.AddDays(1d);
                        workerTxt.ReportProgress(k);
                    }

                    e.Result = "Exportados: (" + i + ")\nNo exportados: (" + j + ")";
                }
                else
                {
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
            chkRango.Checked = false;
            progressImport.Value = 0;
            /*tmFecha = null;
            fecha = null;
            fechaHasta = null;*/
        }

        private void cmdCalendarHasta_Click(object sender, EventArgs e)
        {
            if (!calendarHasta.Visible)
            {
                calendarHasta.Visible = true;
            }
            else
            {
                calendarHasta.Visible = false;
            }
        }

        private void calendarHasta_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtFechaHasta.Text = calendarHasta.SelectionStart.ToString("dd-MM-yyyy");
            calendarHasta.Visible = false;
        }

        private void workerTxt_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {   
            progressImport.Value = e.ProgressPercentage;
        }

        private void workerExcel_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressImport.Value = e.ProgressPercentage;
        }
    }
}