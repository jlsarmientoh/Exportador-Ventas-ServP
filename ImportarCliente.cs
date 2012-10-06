using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EstacionDB.VO;
using EstacionDB.DAO;
using EstacionDB.Exceptions;
using EstacionDB.Utilidades;
using EstacionDB.DTO;

namespace Exportador_Ventas_ServP
{
    public partial class ImportarCliente : Form
    {
        public ImportarCliente()
        {
            InitializeComponent();
        }

        private void ImportarCliente_Load(object sender, EventArgs e)
        {   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Preparando importación....";
            cmdImportar.Enabled = false;
            progressImport.Value = 0;
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int procesados = 0;
            int importados = 0;
            int noImportados = 0;
            WorkStatusDTO estado = new WorkStatusDTO();
            
            ControladorPersistencia cp = new ControladorPersistencia();
            List<ClienteVO> clientesServP = cp.consultarClientesServP();

            estado.Status = WorkStatusDTO.START;
            estado.Percentage = clientesServP.Count + 5;
            estado.Message = "(" + clientesServP.Count + ") Clientes encontrados";
            backgroundWorker1.ReportProgress(5, estado);            

            foreach (ClienteVO cliente in clientesServP)
            {
                String nit = cliente.Identificacion.Trim();
                if (cliente.TipoNit.Equals("Nit"))
                {
                    cliente.IdCliente = 0;
                    cliente.TipoId = 1; //Nit

                    NitDTO nitDTO = Utilidades.formatearNit(nit);
                    cliente.Identificacion = nitDTO.Nit;
                    cliente.Consecutivo = nitDTO.DigitoVerfificacion;
                    cliente.Codigo = nitDTO.Codigo;
                }
                else
                {
                    cliente.TipoId = 2;
                    cliente.Identificacion = nit;
                    cliente.Codigo = "0";
                    cliente.Consecutivo = "0";
                }

                try
                {
                    cp.guardarCliente(cliente);
                    importados++;
                }
                catch (PersistenciaException ex)
                {
                    noImportados++;
                }

                procesados++;

                estado.Status = WorkStatusDTO.IN_PROGRESS;
                estado.Percentage = 5 + procesados;
                estado.Message = "(" + procesados + "/" + clientesServP.Count + ") Clientes procesados";
                backgroundWorker1.ReportProgress(procesados, estado);
            }

            e.Result = "Proceso finalizado:\n\n" +
                "Importados:\t\t" + importados + "\n" +
                "No importados:\t\t" + noImportados;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            WorkStatusDTO workStatus = (WorkStatusDTO)e.UserState;
            switch (workStatus.Status)
            {
                case WorkStatusDTO.START: {
                    progressImport.Maximum = workStatus.Percentage;
                    progressImport.Value = e.ProgressPercentage;
                    lblStatus.Text = workStatus.Message;
                    break; 
                }
                case WorkStatusDTO.IN_PROGRESS: {                    
                    progressImport.Value = workStatus.Percentage;
                    lblStatus.Text = workStatus.Message;
                    break; 
                }
                case WorkStatusDTO.END: { 
                    break; 
                }
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show(e.Result.ToString(), "Resultados", MessageBoxButtons.OK);
            cmdImportar.Enabled = true;
            lblStatus.Text = "Finalizado";
        }
    }
}