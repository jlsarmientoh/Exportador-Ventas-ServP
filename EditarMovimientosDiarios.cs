using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Exportador_Ventas_ServP.Controller;
using EstacionDB.Core;
using EstacionDB.Utilidades;
using System.Collections;
using EstacionDB.DTO;
using EstacionDB.Exceptions;

namespace Exportador_Ventas_ServP
{
    public partial class EditarMovimientosDiarios : Form
    {
        private ControladorPersistencia cp;
        private double saldo = 0;
        private double totalEfectivo = 0;
        private double totalEgresos = 0;
        public EditarMovimientosDiarios()
        {
            InitializeComponent();
            cp = new ControladorPersistencia();
            tipoIdVOBindingSource.DataSource = cp.consultarTipos();
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtFechaCierre.Text.Equals("  /  /"))
                {
                    limpiarCampos();
                    DateTime fecha = DateTime.Parse(txtFechaCierre.Text);
                    if (!CierreEfectivoCore.getInstance().existeCierre(fecha, fecha))
                    {
                        egresoDTOBindingSource.DataSource = DisposicionEfectivoCore.getInstance().consultarEgresosAplicados(fecha);
                        totalEfectivo = DisposicionEfectivoCore.getInstance().getTotalEfectivoFecha(fecha);
                        totalEgresos = DisposicionEfectivoCore.getInstance().getTotalEfectivoDispuestoFecha(fecha);
                        saldo = totalEfectivo - totalEgresos;

                        chkEditar.Enabled = true;
                        cmdGuardar.Enabled = true;
                        actualizarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un cierre para la fecha seleccionada", "Cierre ya existe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (CierreException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiarCampos()
        {   
            txtTotalEgresos.Text = "";
            txtSaldo.BackColor = Color.Empty;            
            txtSaldo.Text = "";
            totalEfectivo = 0;
            totalEgresos = 0;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;            
            chkEditar.Checked = false;
            chkEditar.Enabled = false;
            cmdEliminar.Enabled = false;
            cmdGuardar.Enabled = false;
            cmdCierre.Enabled = false;
            saldo = 0;
        }

        private void actualizarCampos()
        {
            txtTotalEgresos.Text = Utilidades.formatearDecimal(totalEgresos);
            if (Math.Abs(saldo) > Math.Abs(Exportador_Ventas_ServP.Properties.Settings.Default.DiferenciaSaldoDisposicion))
            {
                txtSaldo.BackColor = Color.Red;
                cmdCierre.Enabled = false;
            }
            else
            {
                txtSaldo.BackColor = Color.Empty;
                cmdCierre.Enabled = true;
            }
            txtSaldo.Text = Utilidades.formatearDecimal(saldo);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //MessageBox.Show("Datos inválidos: " + e.Exception.Message, "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            IList tmp = egresoDTOBindingSource.List;
            totalEgresos = 0;

            foreach (EgresoDTO dto in tmp)
            {
                totalEgresos += dto.Valor;
            }

            saldo = totalEfectivo - totalEgresos;
            actualizarCampos();
        }

        private void chkEditar_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = !chkEditar.Checked;
            dataGridView1.AllowUserToAddRows = chkEditar.Checked;
            cmdEliminar.Enabled = chkEditar.Checked;
            cmdGuardar.Enabled = true;
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (egresoDTOBindingSource.Current != null)
            {
                try
                {
                    EgresoDTO tmp = (EgresoDTO)egresoDTOBindingSource.Current;
                    int rows = DisposicionEfectivoCore.getInstance().eliminarEgreso(tmp);
                    if (rows > 0)
                    {   
                        totalEgresos -= tmp.Valor;
                        saldo = totalEfectivo - totalEgresos;
                        txtSaldo.BackColor = Color.Empty;
                        actualizarCampos();
                        egresoDTOBindingSource.Remove(tmp);
                        dataGridView1.Update();
                    }
                }
                catch (CierreException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {   
            if (egresoDTOBindingSource.List.Count > 0)
            {
                DialogResult resp = MessageBox.Show("Resumen del cierre:\n\n" +
                "\tEgresos:\t\t\t$ " + Utilidades.formatearDecimal(totalEgresos) + "\n" +
                "TOTAL:\t\t\t$ " + Utilidades.formatearDecimal(totalEgresos) + "\n\n" +
                "¿Desea continuar?\n", "Resumen de egresos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    if (totalEgresos > totalEfectivo)
                    {
                        DialogResult confirm = MessageBox.Show("El valor total de los egresos supera el saldo en efectivo para la fecha seleccionada. \n\n¿Desea continuar?", "Consulta egresos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (confirm == DialogResult.Yes)
                        {
                            guardarEgreso();
                        }
                    }
                    else
                    {
                        guardarEgreso();
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay egresos para guardar o no ha seleccionado la fecha", "No hay egresos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }            
        }

        private void guardarEgreso()
        {
            try
            {
                DisposicionEfectivoCore.getInstance().guardarEgresos(egresoDTOBindingSource.List);
                MessageBox.Show("Los egresos han sido guardados", "Egresos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                egresoDTOBindingSource.Clear();
                limpiarCampos();
            }
            catch (CierreException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdCierre_Click(object sender, EventArgs e)
        {
            if (!txtFechaCierre.Text.Equals("  /  /"))
            {
                DateTime fecha = DateTime.Parse(txtFechaCierre.Text);
                if (!CierreEfectivoCore.getInstance().existeCierre(fecha, fecha))
                {
                    DialogResult resp = MessageBox.Show("Resumen del cierre:\n\n" +
                    "Egresos:\t\t\t$ " + Utilidades.formatearDecimal(totalEgresos) + "\n" +
                    "Efectivo:\t\t\t$ " + Utilidades.formatearDecimal(totalEfectivo) + "\n" +
                    "Diferencia:\t\t\t$ " + Utilidades.formatearDecimal(saldo) + "\n" +
                    "¿Desea continuar?\n", "Resumen del cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resp == DialogResult.Yes)
                    {
                        if (totalEgresos > totalEfectivo)
                        {
                            DialogResult confirm = MessageBox.Show("El valor total de los egresos supera el saldo en efectivo para la fecha seleccionada. \n\n¿Desea continuar?", "Confirmación del cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (confirm == DialogResult.Yes)
                            {
                                guardarCierre();
                            }
                        }
                        else
                        {
                            guardarCierre();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe un cierre para la fecha seleccionada", "Cierre ya existe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("No ha seleccionado la fecha", "Cierre de efectivo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void guardarCierre()
        {
            try
            {
                CierreEfectivoDTO dto = new CierreEfectivoDTO();
                dto.Efectivo = totalEfectivo;
                dto.Egresos = totalEgresos;
                dto.Estado = true;
                dto.Fecha = DateTime.Parse(txtFechaCierre.Text);

                CierreEfectivoCore.getInstance().guardarCierre(dto);
                MessageBox.Show("El cierre han sido confirmado", "Cierre confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                egresoDTOBindingSource.Clear();
                limpiarCampos();
            }
            catch (CierreException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}