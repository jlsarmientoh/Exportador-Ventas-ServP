using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EstacionDB.Utilidades;
using EstacionDB.DTO;
using EstacionDB.Core;
using EstacionDB.Exceptions;

namespace Exportador_Ventas_ServP
{
    public partial class ComprobarEgresos : Form
    {
        private string path;
        private OpenFileDialog openDialog;
        private StringBuilder sb;

        public ComprobarEgresos()
        {
            InitializeComponent();
            openDialog = new OpenFileDialog();
            sb = new StringBuilder();
        }

        private void cmdSeleccionar_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == openDialog.ShowDialog())
            {
                labelArchivo.Text = openDialog.FileName;
                cmdSeleccionar.Enabled = false;

                importWorker.RunWorkerAsync(openDialog.FileName);

                /*List<EgresoDTO> egresos = FileImporter.importarEgresos(@openDialog.FileName);

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Resultado:");

                foreach (EgresoDTO egreso in egresos)
                {   
                    sb.AppendLine(egreso.ToString());
                }

                txtResultado.Text = sb.ToString();*/
            }
        }

        private void importWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            List<EgresoDTO> egresos = FileImporter.importarEgresos(@e.Argument.ToString());
            int i = 1;
            importWorker.ReportProgress(egresos.Count, null);

            foreach (EgresoDTO egreso in egresos)
            {
                try
                {
                    DisposicionEfectivoCore.getInstance().validarEgreso(egreso);
                    importWorker.ReportProgress(i, "Egreso # " + egreso.Numero + "OK");
                }
                catch (CierreException ce)
                {
                    importWorker.ReportProgress(i, ce.Message);
                }

                i++;
            }

            e.Result = "Finalizado";
        }

        private void importWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState == null)
            {
                progressImport.Maximum = e.ProgressPercentage;
            }
            else
            {
                sb.AppendLine(e.UserState.ToString());
                txtResultado.Text = sb.ToString();
                progressImport.Value = e.ProgressPercentage;
            }
        }

        private void importWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            cmdSeleccionar.Enabled = true;
        }
    }
}