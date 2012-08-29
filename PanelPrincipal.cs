using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EstacionDB.Utilidades;
using System.Configuration;
using Exportador_Ventas_ServP.Reports;

namespace Exportador_Ventas_ServP
{
    public partial class PanelPrincipal : Form
    {
        private int childFormNumber = 0;
        #region Forms definition
        private Lecturas lecturas;
        private Clientes clientes;
        private Exportador exportador;
        private MovimientosDiarios movimientos;
        private ComprasCombustible comprasCombustible;
        private InformesCierre informes;
        private InformeDisposicionEfectivo rptDisposicionEfectivo;
        #endregion

        public PanelPrincipal()
        {
            InitializeComponent();
            Utilidades.cadenaConexion = ConfigurationSettings.AppSettings["Main.ConnectionString"].ToString();
            Utilidades.appCadenaConexion = ConfigurationSettings.AppSettings["App.ConnectionString"].ToString();
            Utilidades.configServ = ConfigurationSettings.AppSettings["ServConfig"].ToString();
            Utilidades.configExpo = ConfigurationSettings.AppSettings["ExpoConfig"].ToString();
            Utilidades.nombreVistaVentas = ConfigurationSettings.AppSettings["NombreVista"].ToString();
            Utilidades.nombreVistaLecturas = ConfigurationSettings.AppSettings["NombreVistaLecturas"].ToString();
            Utilidades.nombreTablaEmpleados = ConfigurationSettings.AppSettings["NombreTablaEmpleados"].ToString();
            Utilidades.rutaPrincipalExport = ConfigurationSettings.AppSettings["RutaPrincipalExport"].ToString();
            Utilidades.separador = ConfigurationSettings.AppSettings["Separador"].ToString();
            Utilidades.sobretasaCorriente = double.Parse(ConfigurationSettings.AppSettings["sobretasaCorriente"].ToString());
            Utilidades.sobretasaSuper = double.Parse(ConfigurationSettings.AppSettings["sobretasaSuper"].ToString());
            Utilidades.sobretasaDiesel = double.Parse(ConfigurationSettings.AppSettings["sobretasaDiesel"].ToString());
            Utilidades.codigoCorriente = int.Parse(ConfigurationSettings.AppSettings["codigoCorriente"].ToString());
            Utilidades.codigoSuper = int.Parse(ConfigurationSettings.AppSettings["codigoSuper"].ToString());
            Utilidades.codigoDiesel = int.Parse(ConfigurationSettings.AppSettings["codigoDiesel"].ToString());
            string encabezado = ConfigurationSettings.AppSettings["Encabezados"].ToString();
            if (encabezado.Equals("Si") || encabezado.Equals("si"))
            {
                Utilidades.usarEncabezados = true;
            }
            else
            {
                Utilidades.usarEncabezados = false;
            }
            Utilidades.grupo1 = ConfigurationSettings.AppSettings["grupoIsla1"].ToString();
            Utilidades.grupo2 = ConfigurationSettings.AppSettings["grupoIsla2"].ToString();
            Utilidades.multiplicarX = int.Parse(ConfigurationSettings.AppSettings["MultiplicarX"].ToString());
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            // Cree una nueva instancia del formulario secundario.
            Form childForm = new Form();
            // Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
                // TODO: agregar código aquí para abrir el archivo.
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
                // TODO: agregar código aquí para guardar el contenido actual del formulario en un archivo.
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: utilizar System.Windows.Forms.Clipboard para insertar el texto o las imágenes seleccionadas en el portapapeles
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: utilizar System.Windows.Forms.Clipboard para insertar el texto o las imágenes seleccionadas en el portapapeles
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: utilizar System.Windows.Forms.Clipboard.GetText() o System.Windows.Forms.GetData para recuperar la información del portapapeles.
        }

        
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void lecturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (lecturas == null)
            //{
                lecturas = new Lecturas();
            //}
            lecturas.MdiParent = this;
            lecturas.Show();
        }

        private void administrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (clientes == null)
            //{
                clientes = new Clientes();
            //}
            clientes.MdiParent = this;
            clientes.Show();
        }

        private void registroDiarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (exportador == null)
            //{
                exportador = new Exportador();
            //}
            exportador.MdiParent = this;
            exportador.Show();
        }

        private void ingresosEgresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (movimientos == null)
            //{
                movimientos = new MovimientosDiarios();
                movimientos.MdiParent = this;
                movimientos.Show();
            //}
            //else
            //{
            //    movimientos.Show();
            //}
            
        }

        private void combustibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comprasCombustible = new ComprasCombustible();
            comprasCombustible.MdiParent = this;
            movimientos.Show();

        }

        private void cierreVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            informes = new InformesCierre();
            informes.MdiParent = this;
            informes.Show();
        }

        private void disposiciónDeEfectivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rptDisposicionEfectivo = new InformeDisposicionEfectivo();
            rptDisposicionEfectivo.MdiParent = this;
            rptDisposicionEfectivo.Show();
        }
    }
}
