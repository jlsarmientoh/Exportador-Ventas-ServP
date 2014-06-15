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
        private ExportadorContingencia exportadorContingencia;
        private MovimientosDiarios movimientos;
        private ComprasCombustible comprasCombustible;
        private InformesCierre informes;
        private InformeDisposicionEfectivo rptDisposicionEfectivo;
        private Exportador_Ventas_ServP.Reports.InformeCombustible informeCombustible;
        private InformeEstadoDeCuenta informaEstadoDeCuenta;
        private ImportarCliente importarCliente;
        private ExportarMovimientos exportarMovimientos;
        private EdicionCierres edicionCierres;
        private SobreTasas sobretasas;
        private InformeVales informeVales;
        private AjusteDeVales ajusteVales;
        private AdministrarUsuarios adminUsuarios;
        private EditarMovimientosDiarios editarMovimientosDiarios;
        private ComprobarEgresos comprobarEgresos;
        private AboutGaslissa about;
        #endregion

        public PanelPrincipal()
        {
            InitializeComponent();            
            Utilidades.cadenaConexion = ConfigurationSettings.AppSettings["Main.ConnectionString"].ToString();
            Utilidades.appCadenaConexion = ConfigurationSettings.AppSettings["App.ConnectionString"].ToString();
            Utilidades.configServ = Application.StartupPath + ConfigurationSettings.AppSettings["ServConfig"].ToString();
            Utilidades.configExpo = Application.StartupPath + ConfigurationSettings.AppSettings["ExpoConfig"].ToString();
            Utilidades.nombreVistaVentas = ConfigurationSettings.AppSettings["NombreVista"].ToString();
            Utilidades.nombreVistaLecturas = ConfigurationSettings.AppSettings["NombreVistaLecturas"].ToString();
            Utilidades.nombreTablaEmpleados = ConfigurationSettings.AppSettings["NombreTablaEmpleados"].ToString();
            Utilidades.rutaPrincipalExport = ConfigurationSettings.AppSettings["RutaPrincipalExport"].ToString();
            Utilidades.separador = ConfigurationSettings.AppSettings["Separador"].ToString();            
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
            Utilidades.corrienteMultiplicarX = int.Parse(ConfigurationSettings.AppSettings["CorrienteMultiplicarX"].ToString());
            Utilidades.superMultiplicarX = int.Parse(ConfigurationSettings.AppSettings["SuperMultiplicarX"].ToString());
            Utilidades.dieselMultiplicarX = int.Parse(ConfigurationSettings.AppSettings["DieselMultiplicarX"].ToString());
            Utilidades.TipoMovimiento = ConfigurationSettings.AppSettings["TipoMovimiento"].ToString();
            Utilidades.NatutalezaDebito = ConfigurationSettings.AppSettings["NatutalezaDebito"].ToString();
            Utilidades.NatutalezaCredito = ConfigurationSettings.AppSettings["NatutalezaCredito"].ToString();
            Utilidades.NitEDS = ConfigurationSettings.AppSettings["NitEDS"].ToString();
            Utilidades.NitSodexo = ConfigurationSettings.AppSettings["NitSodexo"].ToString();
            Utilidades.NitBigPass = ConfigurationSettings.AppSettings["NitBigPass"].ToString();
            Utilidades.NitTicketTronik = ConfigurationSettings.AppSettings["NitTicketTronik"].ToString();
            Utilidades.CuentaCredito = ConfigurationSettings.AppSettings["CuentaCredito"].ToString();
            Utilidades.CuentaEfectivo = ConfigurationSettings.AppSettings["CuentaEfectivo"].ToString();
            Utilidades.CuentaSodexo = ConfigurationSettings.AppSettings["CuentaSodexo"].ToString();
            Utilidades.CuentaBigPass = ConfigurationSettings.AppSettings["CuentaBigPass"].ToString();
            Utilidades.CuentaTarjetas = ConfigurationSettings.AppSettings["CuentaTarjetas"].ToString();
            Utilidades.CuentaOtros = ConfigurationSettings.AppSettings["CuentaOtros"].ToString();
            Utilidades.CuentaTarjetaPlus = ConfigurationSettings.AppSettings["CuentaTarjetaPlus"].ToString();
            Utilidades.CuentaTicketTronik = ConfigurationSettings.AppSettings["CuentaTicketTronik"].ToString();
            Utilidades.CuentaSobretasaCorriente = ConfigurationSettings.AppSettings["CuentaSobretasaCorriente"].ToString();
            Utilidades.CuentaSobretasaSuper = ConfigurationSettings.AppSettings["CuentaSobretasaSuper"].ToString();
            Utilidades.CuentaSobretasaDiesel = ConfigurationSettings.AppSettings["CuentaSobretasaDiesel"].ToString();
            Utilidades.CuentaVentaCorriente = ConfigurationSettings.AppSettings["CuentaVentaCorriente"].ToString();
            Utilidades.CuentaVentaSuper = ConfigurationSettings.AppSettings["CuentaVentaSuper"].ToString();
            Utilidades.CuentaVentaDiesel = ConfigurationSettings.AppSettings["CuentaVentaDiesel"].ToString();
            Utilidades.CuentaAjuste = ConfigurationSettings.AppSettings["CuentaAjuste"].ToString();
            string homologar = ConfigurationSettings.AppSettings["HomologarNits"].ToString();
            if (homologar.Trim().Equals("true"))
            {
                Utilidades.HomologarNits = true;
            }
            Utilidades.CuentaBancaria = ConfigurationSettings.AppSettings["CuentaBancaria"].ToString();
            Utilidades.NitBanco = ConfigurationSettings.AppSettings["NitBanco"].ToString();
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
            /*exportador = new Exportador();            
            exportador.MdiParent = this;
            exportador.Show();*/
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
            //comprasCombustible = new ComprasCombustible();
            //comprasCombustible.MdiParent = this;
            //comprasCombustible.Show();

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

        private void importarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            importarCliente = new ImportarCliente();
            importarCliente.MdiParent = this;
            importarCliente.Show();
        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exportarMovimientos = new ExportarMovimientos();
            exportarMovimientos.MdiParent = this;
            exportarMovimientos.Show();
        }

        private void registroDiarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {            
            exportador = new Exportador();            
            exportador.MdiParent = this;
            exportador.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edicionCierres = new EdicionCierres();
            edicionCierres.MdiParent = this;
            edicionCierres.Show();
        }

        private void sobretasasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sobretasas = new SobreTasas();
            sobretasas.MdiParent = this;
            sobretasas.Show();
        }

        private void controlDeTanquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            informeCombustible = new Exportador_Ventas_ServP.Reports.InformeCombustible();
            informeCombustible.MdiParent = this;
            informeCombustible.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about = new AboutGaslissa();
            about.MdiParent = this;
            about.Show();
        }

        private void lecturasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            lecturas = new Lecturas();
            lecturas.MdiParent = this;
            lecturas.Show();
        }

        private void comprasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            comprasCombustible = new ComprasCombustible();
            comprasCombustible.MdiParent = this;
            comprasCombustible.Show();
        }

        private void estadosDeCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            informaEstadoDeCuenta = new InformeEstadoDeCuenta();
            informaEstadoDeCuenta.MdiParent = this;
            informaEstadoDeCuenta.Show();
        }

        private void valesCréditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            informeVales = new InformeVales();
            informeVales.MdiParent = this;
            informeVales.Show();
        }

        private void ajustarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ajusteVales = new AjusteDeVales();
            ajusteVales.MdiParent = this;
            ajusteVales.Show();
        }

        private void PanelPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminUsuarios = new AdministrarUsuarios();
            adminUsuarios.MdiParent = this;
            adminUsuarios.Show();
        }

        private void revisarEgresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editarMovimientosDiarios = new EditarMovimientosDiarios();
            editarMovimientosDiarios.MdiParent = this;
            editarMovimientosDiarios.Show();
        }

        private void cruzarInformaciónEgresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comprobarEgresos = new ComprobarEgresos();
            comprobarEgresos.MdiParent = this;
            comprobarEgresos.Show();
        }

        private void PanelPrincipal_Load(object sender, EventArgs e)
        {
            modificarToolStripMenuItem.Enabled = Utilidades.usuarioSesion.IsAdmin;
            administrarToolStripMenuItem1.Enabled = Utilidades.usuarioSesion.IsAdmin;
            revisarEgresosToolStripMenuItem.Enabled = Utilidades.usuarioSesion.IsAdmin;
            registroDiarioContingenciaToolStripMenuItem.Enabled = Utilidades.usuarioSesion.IsAdmin;
        }

        private void registroDiarioContingenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exportadorContingencia = new ExportadorContingencia();
            exportadorContingencia.MdiParent = this;
            exportadorContingencia.Show();
        }
        
    }
}
