using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EstacionDB.DAO;
using EstacionDB.VO;
using EstacionDB.Exceptions;

namespace Exportador_Ventas_ServP
{
    public partial class ComprasCombustible : Form
    {
        private ControladorPersistencia cp = new ControladorPersistencia();
        private int galones = 0;
        private int inicial = 0;
        private int final = 0;
        private int medida = 0;
        private int surtidor = 0;
        private int sobranteDia = 0;
        private int sobranteAcumulado = 0;
        private int sobranteAnterior = 0;
        private int porcetaje = 0;

        public ComprasCombustible()
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

        private void txtFechaDesde_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalendarDesde_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtFechaDesde.Text = CalendarDesde.SelectionStart.ToString("dd-MM-yyyy");
            getAcumuladoAnterior();
            CalendarDesde.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ComprasCombustible_Load(object sender, EventArgs e)
        {
            productoVOBindingSource.DataSource = cp.consultarProductos();
            cboProducto.SelectedItem = 0;
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ControlCombustibleVO cc = new ControlCombustibleVO();
                cc.Id = 0;
                cc.Fecha = CalendarDesde.SelectionStart;
                cc.GalonesCompra = galones;
                cc.InventarioInicial = inicial;
                cc.InventarioFinal = final;
                cc.VentaMedida = medida;
                cc.VentaSurtidor = surtidor;
                cc.SobranteDia = sobranteDia;
                cc.SobranteAcumulado = sobranteAcumulado;
                cc.Procentaje = 0;
                cc.IdProducto = (int)cboProducto.SelectedValue;
                cp.guardarControlCombustible(cc);

                MessageBox.Show("Se Guardó el control de combustible", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (PersistenciaException pe)
            {
                MessageBox.Show(pe.Message, "Error al guardar el control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            reiniciarValores();
        }

        private void reiniciarValores()
        {
            galones = 0;
            inicial = 0;
            final = 0;
            medida = 0;
            surtidor = 0;
            sobranteDia = 0;
            sobranteAcumulado = 0;
            porcetaje = 0;
        }

        private void ComprasCombustible_FormClosed(object sender, FormClosedEventArgs e)
        {
            reiniciarValores();
        }

        private void txtInicial_TextChanged(object sender, EventArgs e)
        {
            try
            {
                inicial = int.Parse(txtInicial.Text);
                calcularMedida();
            }
            catch (FormatException fe)
            {
                txtInicial.Text = "0";
            }
        }

        private void txtFinal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                final = int.Parse(txtFinal.Text);
                calcularMedida();
            }
            catch (FormatException fe)
            {
                txtFinal.Text = "0";
            }
        }

        private void txtSurtidor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                surtidor = int.Parse(txtSurtidor.Text);
                calcularAcumulados();
            }
            catch (FormatException fe)
            {
                txtSurtidor.Text = "0";
            }
        }

        private void txtGalones_TextChanged(object sender, EventArgs e)
        {
            try
            {
                galones = int.Parse(txtGalones.Text);
                calcularMedida();
            }
            catch(FormatException fe)
            {
                txtGalones.Text = "0";
            }
        }

        private void calcularMedida()
        {
            medida = (galones + inicial) - final;
            txtMedida.Text = medida.ToString();
        }

        private void calcularAcumulados()
        {
            sobranteDia = surtidor - medida;
            sobranteAcumulado = sobranteAnterior + sobranteDia;
            txtSobranteDia.Text = sobranteDia.ToString();
            txtSonbranteAcumulado.Text = sobranteAcumulado.ToString();
        }

        private void getAcumuladoAnterior()
        {
            try
            {
                DateTime tmp = CalendarDesde.SelectionStart;
                if (tmp.Day > 1)
                {
                    DateTime ayer = tmp.AddDays(-1d);
                    List<ControlCombustibleVO> controles = cp.consultarControlProductoFecha((int)cboProducto.SelectedValue, ayer, ayer);
                    if (controles.Count > 0)
                    {
                        ControlCombustibleVO cc = controles[0];
                        sobranteAnterior = cc.SobranteAcumulado;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            getAcumuladoAnterior();
        }

        
    }
}