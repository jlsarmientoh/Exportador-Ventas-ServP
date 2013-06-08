using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Exportador_Ventas_ServP.Controller;
using EstacionDB.VO;
using EstacionDB.Exceptions;

namespace Exportador_Ventas_ServP
{
    public partial class ComprasCombustible : Form
    {
        private ControladorPersistencia cp = new ControladorPersistencia();        

        public ComprasCombustible()
        {
            InitializeComponent();
        }

        private void ComprasCombustible_Load(object sender, EventArgs e)
        {
            productoVOBindingSource.DataSource = cp.consultarProductos();
            productoVOBindingSource1.DataSource = cp.consultarProductos();
            cboProducto.SelectedIndex = 0;
        }

        
        private void reiniciarValores()
        {   
            txtGalones.Text = "0";
            txtValorUnitario.Text = "0";
            txtValorTotal.Text = "0";
            txtSoldicom.Text = "0";
            txtFlete.Text = "0";
            txtImpuesto.Text = "0";
        }

        private void ComprasCombustible_FormClosed(object sender, FormClosedEventArgs e)
        {
            reiniciarValores();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            CompraCombustibleVO cc = new CompraCombustibleVO();
            cc.Fecha = DateTime.Parse(txtFecha.Text);
            cc.Factura = long.Parse(txtFactura.Text);
            cc.IdProducto = (int)cboProducto.SelectedValue;
            cc.Galones = double.Parse(txtGalones.Text);
            cc.ValorUnitario = double.Parse(txtValorUnitario.Text);
            cc.Valor = double.Parse(txtValorTotal.Text);
            cc.Soldicom = double.Parse(txtSoldicom.Text);
            cc.Flete = double.Parse(txtFlete.Text);
            cc.Impuesto = double.Parse(txtImpuesto.Text);

            compraCombustibleVOBindingSource.Add(cc);

            reiniciarValores();
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            if (compraCombustibleVOBindingSource.Current != null)
            {
                CompraCombustibleVO c = (CompraCombustibleVO)compraCombustibleVOBindingSource.Current;
                compraCombustibleVOBindingSource.Remove(c);
                dataGridView1.Update();
            }
        }

        private void cmdGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if(compraCombustibleVOBindingSource.Count > 0){
                    IList<CompraCombustibleVO> compras = (IList<CompraCombustibleVO>)compraCombustibleVOBindingSource.List;
                    int rows = 0;
                    foreach (CompraCombustibleVO c in compras)
                    {
                        rows += cp.guardarCompraCombustible(c);
                    }
                    if (rows > 0)
                    {
                        MessageBox.Show("La compras de combustible se guardaron", "Compras guardadas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se guardaron las compras de combustible", "Compras no guardadas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    reiniciarValores();
                    compraCombustibleVOBindingSource.Clear();
                    txtFactura.Text = "";
                    txtFecha.Text = "";
                }
            }
            catch (PersistenciaException ex)
            {
                MessageBox.Show("No se pudo guadar la compra: " + ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        /*private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (compraCombustibleVOBindingSource.Current != null)
            {
                CompraCombustibleVO c = (CompraCombustibleVO)compraCombustibleVOBindingSource.Current;
                txtFecha.Text = c.Fecha.ToShortDateString();
                txtFactura.Text = c.Factura.ToString(); ;
                cboProducto.SelectedValue = c.IdProducto;
                txtGalones.Text = c.Galones.ToString();
                txtValorUnitario.Text = c.ValorUnitario.ToString();
                txtValorTotal.Text = c.Valor.ToString();
                txtSoldicom.Text = c.Soldicom.ToString();
                txtFlete.Text = c.Flete.ToString();
                txtImpuesto.Text = c.Impuesto.ToString();
            }
        }*/

       

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            if (!txtFecha.Text.Equals(""))
            {
                compraCombustibleVOBindingSource.DataSource = cp.consultarComprasFecha(DateTime.Parse(txtFecha.Text));
            }
        }        
    }
}