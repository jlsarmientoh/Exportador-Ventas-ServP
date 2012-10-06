using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EstacionDB.VO;
using EstacionDB.DAO;
using EstacionDB.Utilidades;
using System.Configuration;
using System.IO;
using EstacionDB.Exceptions;

namespace Exportador_Ventas_ServP
{
    public partial class Exportador : Form
    {
        private const int EXCEL = 1;
        private const int PLANO = 2;

        private double totalVentas = 0;
        private double totalCredito = 0;
        private double totalSodexo = 0;
        private double totalEfectivo = 0;
        private double totalBigPass = 0;
        private double totalOtros = 0;
        private double totalTarjetas = 0;
        private double totalPlus = 0;
        private double totalTicketTronik = 0;

        private ControladorPersistencia cp = new ControladorPersistencia();

        private List<VentaVO> ventasExportar;

        public List<VentaVO> VentasExportar
        {
            get { return ventasExportar; }
            set { ventasExportar = value; }
        }

        public Exportador()
        {
            InitializeComponent();            
            cmdExportExcel.Enabled = false;
            cmdExportTxt.Enabled = false;
            frameAdicionar.Enabled = false;
            empleadoVOBindingSource.DataSource = cp.getEmpleados();
        }

        private void CalendarDesde_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtFechaDesde.Text = CalendarDesde.SelectionStart.ToString("dd-MM-yyyy");
            CalendarDesde.Visible = false;
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

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            this.UseWaitCursor = true;
            ventaVOBindingSource.DataSource = null;
            try
            {
                if (cboEmpleados.SelectedIndex != -1 && !txtIsla.Text.Equals("") && !txtTurno.Text.Equals(""))
                {

                    long codEmp = long.Parse(cboEmpleados.SelectedValue.ToString());
                    long isla = long.Parse(txtIsla.Text);
                    long turno = long.Parse(txtTurno.Text);
                    cp = new ControladorPersistencia();
                    if (cp.existeCierre(codEmp, turno, isla, CalendarDesde.SelectionStart, CalendarDesde.SelectionStart) == 0)
                    {
                        totalCredito = cp.consultarTotalVentasFidelizadas(codEmp, turno, isla, CalendarDesde.SelectionStart, CalendarDesde.SelectionStart);
                        ventaVOBindingSource.DataSource = cp.consultarVentasFidelizados(codEmp, CalendarDesde.SelectionStart, CalendarDesde.SelectionStart, isla, turno);

                        if (ventaVOBindingSource.Count == 0)
                        {
                            MessageBox.Show("No se encontraron ventas crédito para la fecha, turno e isla seleccionados", "Resultado del cierre ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                        cmdExportExcel.Enabled = true;
                        cmdExportTxt.Enabled = true;
                        cmdGuardar.Enabled = true;
                        frameAdicionar.Enabled = false;

                        txtNombre.Text = "";
                        txtId.Text = "";
                        txtTiquete.Text = "";
                        txtPlaca.Text = "";

                        actualizarTotales();
                    }
                    else
                    {
                        MessageBox.Show("Ya se ha realizado cierre para la fecha seleccionada", "Resultado del cierre ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar la fecha, el código de empleado, el turno y la isla", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    restaurarCampos();
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;                
                if(ex.InnerException != null) 
                {
                    msg += " " + ex.InnerException.Message;
                }
                MessageBox.Show(msg);
            }
            this.UseWaitCursor = false;
        }

        private void cmdExportTxt_Click(object sender, EventArgs e)
        {
            /*try
            {
                bool exportado = false;

                dialogoGuardar.Title = "Exportar a archivo plano";
                dialogoGuardar.InitialDirectory = Utilidades.rutaPrincipalExport;
                dialogoGuardar.AddExtension = true;
                //dialogoGuardar.Filter = "(*.txt)|*.txt";
                dialogoGuardar.Filter = "(*.csv)|*.csv";
                dialogoGuardar.FileName = Utilidades.rutaPrincipalExport + "creditos_servp_" + DateTime.Now.ToFileTime();
                DialogResult resul = dialogoGuardar.ShowDialog();

                exportado = FileExporter.exportar(cp.getMovimientosContables(CalendarDesde.SelectionStart, CalendarDesde.SelectionStart, "24")
                    , "C:\\Temp\\exportado_helissa.csv"
                    ,FileExporter.EXCEL);
            }
            catch (PersistenciaException ex)
            {

            }
            /*bool exportado = false;

            dialogoGuardar.Title = "Exportar a archivo plano";
            dialogoGuardar.InitialDirectory = Utilidades.rutaPrincipalExport;
            dialogoGuardar.AddExtension = true;
            dialogoGuardar.Filter = "(*.txt)|*.txt";
            dialogoGuardar.FileName = Utilidades.rutaPrincipalExport + "creditos_servp_" + DateTime.Now.ToFileTime();
            DialogResult resul = dialogoGuardar.ShowDialog();


            exportado = exportar(ventasExportar, dialogoGuardar.FileName, PLANO);            

            if (exportado)
            {
                MessageBox.Show("Exportado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No Exportado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void cmdExportExcel_Click(object sender, EventArgs e)
        {
            /*bool exportado = false;

            dialogoGuardar.Title = "Exportar a archivo csv";
            dialogoGuardar.InitialDirectory = Utilidades.rutaPrincipalExport;
            dialogoGuardar.AddExtension = true;
            dialogoGuardar.Filter = "(*.csv)|*.csv";
            dialogoGuardar.FileName = Utilidades.rutaPrincipalExport + "creditos_servp_" + DateTime.Now.ToFileTime();
            DialogResult resul = dialogoGuardar.ShowDialog();

            exportado = exportar(ventasExportar, dialogoGuardar.FileName, EXCEL);

            if (exportado)
            {
                MessageBox.Show("Exportado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No Exportado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

       
        private bool exportar(List<VentaVO> ventas, string ruta, int tipo)
        {
            try
            {
                FileStream fileStream = new FileStream(@ruta, FileMode.Create);

                TextWriter sw = new StreamWriter(fileStream);
                if (tipo == PLANO)
                {
                    if (Utilidades.usarEncabezados)
                    {
                        sw.WriteLine("Fecha\tNit\tCliente\tProducto\tTiquete\tPlaca\tKilometraje\tTotal\tIsla\tTurno");
                    }
                    foreach (VentaVO linea in ventas)
                    {
                        sw.WriteLine(linea.Fecha.ToString("dd-MM-yyyy") + "\t" + linea.Nit + "\t" + linea.Cliente + "\t" + linea.Producto + "\t" + linea.Tiquete + "\t" + linea.Placa + "\t" + linea.Kilometraje.ToString() + "\t" + linea.Total.ToString() + "\t" + linea.Isla.ToString() + "\t" + linea.Turno.ToString());
                    }
                }
                if (tipo == EXCEL)
                {
                    if (Utilidades.usarEncabezados)
                    {
                        sw.WriteLine("Fecha" + Utilidades.separador + "Nit" + Utilidades.separador + "Cliente" + Utilidades.separador + "Producto" + Utilidades.separador + "Tiquete" + Utilidades.separador + "Placa" + Utilidades.separador + "Kilometraje" + Utilidades.separador + "Total" + Utilidades.separador + "Isla" + Utilidades.separador + "Turno");
                    }
                    foreach (VentaVO linea in ventas)
                    {
                        sw.WriteLine(linea.Fecha.ToString("dd-MM-yyyy") + Utilidades.separador + linea.Nit + Utilidades.separador + linea.Cliente + Utilidades.separador + linea.Producto + Utilidades.separador + linea.Tiquete + Utilidades.separador + linea.Placa + Utilidades.separador + linea.Kilometraje.ToString() + Utilidades.separador + linea.Total.ToString() + Utilidades.separador + linea.Isla.ToString() + Utilidades.separador + linea.Turno.ToString());
                    }
                }

                sw.Close();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            if (txtTiquete.Text.Equals("") || txtId.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar el número del tiquete y la identificación del cliente", "", MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
            else
            {
                cp = new ControladorPersistencia();
                VentaVO venta = cp.consultarVentaTurno(long.Parse(txtTiquete.Text), CalendarDesde.SelectionStart, CalendarDesde.SelectionStart, int.Parse(txtIsla.Text), int.Parse(txtTurno.Text));
                if (venta != null)
                {
                    venta.Nit = txtId.Text;
                    if (txtNombre.Text.Equals(""))
                    {
                        venta.Cliente = "CLIENTE NO FIDELIZADO";
                    }
                    else
                    {
                        venta.Cliente = txtNombre.Text;
                    }
                    if (!txtPlaca.Text.Equals(""))
                    {
                        venta.Placa = txtPlaca.Text;
                    }

                    if (chkPlus.Checked)
                    {
                        venta.ModoPago = 2;
                        totalPlus += venta.Total;
                    }
                    else
                    {
                        venta.ModoPago = 1;
                        totalCredito += venta.Total;
                    }

                    ventaVOBindingSource.Add(venta);
                    actualizarTotales();

                    MessageBox.Show("Tiquete agregado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNombre.Text = "";
                    txtId.Text = "";
                    txtTiquete.Text = "";
                    txtPlaca.Text = "";                    
                    cboCliente.SelectedIndex = 0;
                    chkPlus.Checked = false;
                }
                else
                {
                    MessageBox.Show("Número de tiquete no existe", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                long tiquete = long.Parse(txtTiquete.Text);

                foreach (VentaVO venta in ventaVOBindingSource.List)
                {
                    if (venta.Tiquete == tiquete)
                    {
                        switch (venta.ModoPago)
                        {
                            case 1:
                                {
                                    totalCredito -= venta.Total;
                                    break;
                                }
                            case 2:
                                {
                                    totalPlus -= venta.Total;
                                    break;
                                }
                        }
                        ventaVOBindingSource.Remove(venta);
                        GridVentasCargadas.Update();
                        actualizarTotales();
                    }
                }
            }
            catch (Exception ex)
            {
                txtNombre.Text = "";
                txtId.Text = "";
                txtTiquete.Text = "";
            }
        }

        private void cmdHabilitarAdicion_Click(object sender, EventArgs e)
        {
            frameAdicionar.Enabled = true;
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNombre.Text = cboCliente.Text;
            txtId.Text = (string)cboCliente.SelectedValue;
        }

        private void Exportador_Load(object sender, EventArgs e)
        {
            cboCliente.DataSource = cp.consultarClientes();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            String resumen = "";
            resumen = "Resumen del cierre:\n\n" +
                "\tCreditos:\t\t\t$ " + String.Format("{0,10:#,0.00}", totalCredito) + "\n" +
                "\tEfectivo:\t\t\t$ " + String.Format("{0,10:#,0.00}", totalEfectivo) + "\n" +
                "\tSodexho:\t\t\t$ " + String.Format("{0,10:#,0.00}", totalSodexo) + "\n" +                
                "\tBig Pass:\t\t\t$ " + String.Format("{0,10:#,0.00}", totalBigPass) + "\n" +
                "\tTarjetas:\t\t\t$ " + String.Format("{0,10:#,0.00}", totalTarjetas) + "\n" +
                "\tTarjeta Plus:\t\t$ " + String.Format("{0,10:#,0.00}", totalPlus) + "\n" +
                "\tTicket Prom:\t\t$ " + String.Format("{0,10:#,0.00}", totalTicketTronik) + "\n" +
                "\tOtros:\t\t\t$ " + String.Format("{0,10:#,0.00}", totalOtros) + "\n" +
                "TOTAL:\t\t\t$ " + String.Format("{0,10:#,0.00}", totalVentas) + "\n\n" +
                "¿Desea continuar con el cierre?\n";
            DialogResult res = MessageBox.Show(resumen, "Resumen del cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.UseWaitCursor = true;
                CierreVentasVO cierre = new CierreVentasVO();
                cierre.CodEmpleado = long.Parse(cboEmpleados.SelectedValue.ToString());
                cierre.Isla = long.Parse(txtIsla.Text.Trim());
                cierre.Turno = long.Parse(txtTurno.Text.Trim());
                cierre.Efectivo = totalEfectivo;
                cierre.Creditos = totalCredito;
                cierre.Sodexo = totalSodexo;
                cierre.BigPass = totalBigPass;
                cierre.Tarjetas = totalTarjetas;
                cierre.TarjetaPlus = totalPlus;
                cierre.Otros = totalOtros;
                cierre.TicketTronik = totalTicketTronik;
                cierre.TotalVentas = totalVentas;
                cierre.Fecha = CalendarDesde.SelectionStart;

                if (cp.existeCierre(cierre.CodEmpleado, cierre.Turno, cierre.Isla, CalendarDesde.SelectionStart, CalendarDesde.SelectionStart) == 0)
                {

                    int rows = 0;
                    int rowsTurno = 0;

                    rows = cp.guardarCierre(cierre);

                    if (rows > 0)
                    {

                        System.Collections.IList tmpVentas = ventaVOBindingSource.List;
                        VentaVO[] ventas = new VentaVO[tmpVentas.Count];
                        tmpVentas.CopyTo(ventas, 0);
                        ventasExportar = new List<VentaVO>(ventas);

                        rows = cp.guardarVentasDia(ventasExportar);
                        //rowsTurno = cp.guardarVentasTurno(cp.consultarVentasTurno(cierre.CodEmpleado, CalendarDesde.SelectionStart, CalendarDesde.SelectionStart, cierre.Isla, cierre.Turno));
                        rowsTurno = cp.guardarProductosTurno(cp.consultarProductosTurno(CalendarDesde.SelectionStart, CalendarDesde.SelectionStart, cierre.Isla, cierre.Turno));
                        MessageBox.Show("Se guardaron (" + rows + ") ventas en este cierre", "Resultado del cierre ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        totalEfectivo = 0;
                        totalOtros = 0;
                        totalSodexo = 0;
                        totalBigPass = 0;
                        totalCredito = 0;
                        totalTarjetas = 0;
                        totalPlus = 0;
                        totalTicketTronik = 0;
                        totalVentas = 0;

                        restaurarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Nose pudo registrar el cierre", "Resultado del cierre ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ya se ha realizado cierre para la fecha seleccionada", "Resultado del cierre ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                  
                UseWaitCursor = false;
            }
        }

        private void cmdRecargarCliente_Click(object sender, EventArgs e)
        {
            cboCliente.DataSource = cp.consultarClientes();
        }

        private void actualizarTotales()
        {
            totalVentas = 0;
            totalVentas += totalEfectivo;
            totalVentas += totalOtros;
            totalVentas += totalSodexo;
            totalVentas += totalBigPass;
            totalVentas += totalCredito;
            totalVentas += totalTarjetas;
            totalVentas += totalPlus;
            totalVentas += totalTicketTronik;

            txtCreditos.Text = String.Format("{0,10:#,0.00}", totalCredito);
            txtEfectivo.Text = String.Format("{0,10:#,0.00}", totalEfectivo);
            txtOtros.Text = String.Format("{0,10:#,0.00}", totalOtros);
            txtSodexo.Text = String.Format("{0,10:#,0.00}", totalSodexo);
            txtBigpass.Text = String.Format("{0,10:#,0.00}", totalBigPass);
            txtTarjetas.Text = String.Format("{0,10:#,0.00}", totalTarjetas);
            txtTarjetaPlus.Text = String.Format("{0,10:#,0.00}", totalPlus);
            txtTotal.Text = String.Format("{0,10:#,0.00}", totalVentas);
            txtTicketTronik.Text = String.Format("{0,10:#,0.00}", totalTicketTronik);
        }

        private void restaurarCampos()
        {
            cmdExportExcel.Enabled = false;
            cmdExportTxt.Enabled = false;
            cmdGuardar.Enabled = false;
            frameAdicionar.Enabled = false;
            ventaVOBindingSource.Clear();
            actualizarTotales();
        }

        private void txtEfectivo_Leave(object sender, EventArgs e)
        {
            try
            {
                totalEfectivo = double.Parse(txtEfectivo.Text);
            }
            catch { }
            actualizarTotales();
        }

        private void txtSodexo_Leave(object sender, EventArgs e)
        {
            try
            {
                totalSodexo = double.Parse(txtSodexo.Text);
            }
            catch { }
            actualizarTotales();
        }

        private void txtBigpass_Leave(object sender, EventArgs e)
        {
            try
            {
                totalBigPass = double.Parse(txtBigpass.Text);
            }
            catch { }
            actualizarTotales();
        }

        private void txtCreditos_Leave(object sender, EventArgs e)
        {
            try
            {
                totalCredito = double.Parse(txtCreditos.Text);
            }
            catch { }
            actualizarTotales();
        }

        private void txtOtros_Leave(object sender, EventArgs e)
        {
            try
            {
                totalOtros = double.Parse(txtOtros.Text);
            }
            catch { }
            actualizarTotales();
        }

        private void txtFechaDesde_Leave(object sender, EventArgs e)
        {
            try
            {
                txtFechaDesde.Text = CalendarDesde.SelectionStart.ToString("dd-MM-yyyy");
            }
            catch { }
        }

        private void txtEfectivo_Enter(object sender, EventArgs e)
        {
            txtEfectivo.SelectionStart = 0;
            txtEfectivo.SelectionLength = txtEfectivo.Text.Length;
        }

        private void txtSodexo_Enter(object sender, EventArgs e)
        {
            txtSodexo.SelectionStart = 0;
            txtSodexo.SelectionLength = txtSodexo.Text.Length;
        }

        private void txtBigpass_Enter(object sender, EventArgs e)
        {
            txtBigpass.SelectionStart = 0;
            txtBigpass.SelectionLength = txtBigpass.Text.Length;
        }

        private void txtOtros_Enter(object sender, EventArgs e)
        {
            txtOtros.SelectionStart = 0;
            txtOtros.SelectionLength = txtOtros.Text.Length;
        }

        private void txtTarjetaPlus_Enter(object sender, EventArgs e)
        {
            txtTarjetaPlus.SelectionStart = 0;
            txtTarjetaPlus.SelectionLength = txtTarjetaPlus.Text.Length;
        }

        private void txtTarjetas_Enter(object sender, EventArgs e)
        {
            txtTarjetas.SelectionStart = 0;
            txtTarjetas.SelectionLength = txtTarjetas.Text.Length;
        }

        private void txtTarjetas_Leave(object sender, EventArgs e)
        {
            try
            {
                totalTarjetas = double.Parse(txtTarjetas.Text);
            }
            catch { }
            actualizarTotales();
        }

        private void txtEfectivo_MouseClick(object sender, MouseEventArgs e)
        {
            txtEfectivo.SelectionStart = 0;
            txtEfectivo.SelectionLength = txtEfectivo.Text.Length;
        }

        private void txtSodexo_MouseClick(object sender, MouseEventArgs e)
        {
            txtSodexo.SelectionStart = 0;
            txtSodexo.SelectionLength = txtSodexo.Text.Length;
        }

        private void txtBigpass_MouseClick(object sender, MouseEventArgs e)
        {
            txtBigpass.SelectionStart = 0;
            txtBigpass.SelectionLength = txtBigpass.Text.Length;
        }

        private void txtTarjetas_MouseClick(object sender, MouseEventArgs e)
        {
            txtTarjetas.SelectionStart = 0;
            txtTarjetas.SelectionLength = txtTarjetas.Text.Length;
        }

        private void txtOtros_MouseClick(object sender, MouseEventArgs e)
        {
            txtOtros.SelectionStart = 0;
            txtOtros.SelectionLength = txtOtros.Text.Length;
        }

        private void txtTicketTronik_Leave(object sender, EventArgs e)
        {
            try
            {
                totalTicketTronik = double.Parse(txtTicketTronik.Text);
            }
            catch { }
            actualizarTotales();
        }

        private void txtTicketTronik_Enter(object sender, EventArgs e)
        {
            txtTicketTronik.SelectionStart = 0;
            txtTicketTronik.SelectionLength = txtTicketTronik.Text.Length;
        }

        private void txtTicketTronik_MouseClick(object sender, MouseEventArgs e)
        {
            txtTicketTronik.SelectionStart = 0;
            txtTicketTronik.SelectionLength = txtTicketTronik.Text.Length;
        }

        private void cierreWorker_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}