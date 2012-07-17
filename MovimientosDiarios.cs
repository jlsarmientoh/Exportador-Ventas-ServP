using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EstacionDB.DAO;
using EstacionDB.VO;

namespace Exportador_Ventas_ServP
{
    public partial class MovimientosDiarios : Form
    {
        private ControladorPersistencia cp = new ControladorPersistencia();

        private double totalIngresos = 0;
        private double totalEgresos = 0;
        private double saldo = 0;

        private IngresoVO[] ingresos = null;
        private EgresoVO[] egresos = null;

        public MovimientosDiarios()
        {
            InitializeComponent();
            bancoVOBindingSource.DataSource = cp.consultarBancos();
            tipoIdVOBindingSource.Add(new TipoIdVO(1, "CS"));
            tipoIdVOBindingSource1.Add(new TipoIdVO(1, "CE"));

            txtTotalIngresos.Text = String.Format("{0,10:#,0.00}", totalIngresos);
            txtTotalEgresos.Text = String.Format("{0,10:#,0.00}", totalEgresos);
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

        private void gridIngresos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Datos inválidos: " + e.Exception.Message, "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void gridEgresos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Datos inválidos: " + e.Exception.Message, "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void cmdGuardarIngresos_Click(object sender, EventArgs e)
        {
            this.UseWaitCursor = true;
            try
            {
                if (ingresoVOBindingSource.List.Count > 0 && !txtFechaDesde.Text.Equals(""))
                {
                    DialogResult resp = MessageBox.Show("Resumen del cierre:\n\n" +
                    "\tIngresos:\t\t\t$ " + String.Format("{0,10:#,0.00}", totalIngresos) + "\n" +
                    "TOTAL:\t\t\t$ " + String.Format("{0,10:#,0.00}", totalIngresos) + "\n\n" +
                    "¿Desea continuar con el cierre?\n", "Resumen de ingresos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resp == DialogResult.Yes)
                    {
                        System.Collections.IList tmpIngresos = ingresoVOBindingSource.List;
                        ingresos = new IngresoVO[tmpIngresos.Count];
                        tmpIngresos.CopyTo(ingresos, 0);

                        DateTime fecha = DateTime.Parse(txtFechaDesde.Text);

                        int res = 0;
                        res = cp.guardarIngresos(new List<IngresoVO>(ingresos), fecha);

                        MessageBox.Show("Ingresos guardados para la fecha: " + txtFechaDesde.Text, "Ingresos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ingresoVOBindingSource.Clear();
                        txtTotalIngresos.Text = "0";
                    }
                }
                else
                {
                    MessageBox.Show("No hay ingresos para guardar o no ha seleccionado la fecha", "No hay ingresos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.UseWaitCursor = false;
        }

        private void cmdGuardarEgresos_Click(object sender, EventArgs e)
        {
            this.UseWaitCursor = true;
            try
            {
                if (egresoVOBindingSource.List.Count > 0 && !txtFechaDesde.Text.Equals("") && !txtFechaAplica.Text.Equals(""))
                {
                    DialogResult resp = MessageBox.Show("Resumen del cierre:\n\n" +
                    "\tEgresos:\t\t\t$ " + String.Format("{0,10:#,0.00}", totalEgresos) + "\n" +
                    "TOTAL:\t\t\t$ " + String.Format("{0,10:#,0.00}", totalEgresos) + "\n\n" +
                    "¿Desea continuar?\n", "Resumen de egresos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resp == DialogResult.Yes)
                    {
                        if (totalEgresos <= saldo)
                        {
                            System.Collections.IList tmpEgresos = egresoVOBindingSource.List;
                            egresos = new EgresoVO[tmpEgresos.Count];
                            tmpEgresos.CopyTo(egresos, 0);

                            DateTime fecha = DateTime.Parse(txtFechaDesde.Text);
                            DateTime fechaAplica = DateTime.Parse(txtFechaAplica.Text);                            

                            int res = 0;
                            res = cp.guardarEgresos(new List<EgresoVO>(egresos), fecha, fechaAplica);

                            MessageBox.Show("Egresos guardados para la fecha: " + txtFechaDesde.Text + "\n\n" +
                                "Aplicados la fecha: " + txtFechaAplica.Text, "Egresos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            egresoVOBindingSource.Clear();
                            txtTotalEgresos.Text = "0";
                            txtSaldo.Text = "0";
                        }
                        else
                        {
                            MessageBox.Show("El valor total de los egresos supera el saldo en efectivo para la fecha seleccionada", "Consulta egresos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No hay egresos para guardar o no ha seleccionado la fecha", "No hay egresos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.UseWaitCursor = false;
        }

        private void txtFechaDesde_Leave(object sender, EventArgs e)
        {

        }

        private void gridIngresos_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            System.Collections.IList tmpIngresos = ingresoVOBindingSource.List;
            ingresos = new IngresoVO[tmpIngresos.Count];
            tmpIngresos.CopyTo(ingresos, 0);

            totalIngresos = 0;
            for (int i = 0; i < ingresos.Length; i++)
            {
                totalIngresos += ingresos[i].Valor;
            }

            txtTotalIngresos.Text = String.Format("{0,10:#,0.00}", totalIngresos);
        }

        private void grisEgresos_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            System.Collections.IList tmpEgresos = egresoVOBindingSource.List;
            egresos = new EgresoVO[tmpEgresos.Count];
            tmpEgresos.CopyTo(egresos, 0);

            totalEgresos = 0;
            for (int i = 0; i < egresos.Length; i++)
            {
                totalEgresos += egresos[i].Valor;
            }

            txtTotalEgresos.Text = String.Format("{0,10:#,0.00}", totalEgresos);
        }

        private void cmdConsultarAplicados_Click(object sender, EventArgs e)
        {
            this.UseWaitCursor = true;
            if (!txtFechaAplica.Text.Equals(""))
            {
                DateTime fecha = DateTime.Parse(txtFechaDesde.Text);
                DateTime fechaAplica = DateTime.Parse(txtFechaAplica.Text);                
                double efectivo = 0;
                double egresosAplicados = 0;
                saldo = 0;

                efectivo = cp.consultarTotalEfectivoFecha(fechaAplica, fechaAplica.AddDays(1));
                egresosAplicados = cp.consultarTotalEgresosAplicadosFecha(fechaAplica, fechaAplica.AddDays(1));
                saldo = efectivo - egresosAplicados;
                txtTotalEgresos.Text = "0";
                txtSaldo.Text = String.Format("{0,10:#,0.00}", saldo);
            }
            else
            {
                MessageBox.Show("No ha seleccionado la fecha e isla a la cual va a aplicar los egresos", "Información requerida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            this.UseWaitCursor = false;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtFechaAplica.Text = calendarAplica.SelectionStart.ToString("dd-MM-yyyy");
            calendarAplica.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!calendarAplica.Visible)
            {
                calendarAplica.Visible = true;
            }
            else
            {
                calendarAplica.Visible = false;
            }
        }
    }
}