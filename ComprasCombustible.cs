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
            txtGalones.Text = String.Format("{0,10:#,0.00}", 0);
            txtValorUnitario.Text = String.Format("{0,10:#,0.00}", 0);
            txtValorTotal.Text = String.Format("{0,10:#,0.00}", 0);
            txtSoldicom.Text = String.Format("{0,10:#,0.00}", 0);
            txtFlete.Text = String.Format("{0,10:#,0.00}", 0);
            txtImpuesto.Text = String.Format("{0,10:#,0.00}", 0);
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

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            if (!txtFecha.Text.Equals(""))
            {
                compraCombustibleVOBindingSource.DataSource = cp.consultarComprasFecha(DateTime.Parse(txtFecha.Text));
            }
        }

        private void txtGalones_Enter(object sender, EventArgs e)
        {
            txtGalones.SelectionStart = 0;
            txtGalones.SelectionLength = txtGalones.Text.Length;
        }

        private void txtGalones_MouseClick(object sender, MouseEventArgs e)
        {
            txtGalones.SelectionStart = 0;
            txtGalones.SelectionLength = txtGalones.Text.Length;
        }

        private void txtGalones_Leave(object sender, EventArgs e)
        {
            try
            {
                double tmp = double.Parse(txtGalones.Text);
                txtGalones.Text = String.Format("{0,10:#,0.00}", tmp);
            }
            catch 
            {
                txtGalones.Text = String.Format("{0,10:#,0.00}", 0);
            }
        }

        private void txtValorUnitario_Leave(object sender, EventArgs e)
        {
            try
            {
                double tmp = double.Parse(txtValorUnitario.Text);
                txtValorUnitario.Text = String.Format("{0,10:#,0.00}", tmp);
            }
            catch
            {
                txtValorUnitario.Text = String.Format("{0,10:#,0.00}", 0);
            }
        }

        private void txtValorUnitario_Enter(object sender, EventArgs e)
        {
            txtValorUnitario.SelectionStart = 0;
            txtValorUnitario.SelectionLength = txtValorUnitario.Text.Length;
        }

        private void txtValorUnitario_MouseClick(object sender, MouseEventArgs e)
        {
            txtValorUnitario.SelectionStart = 0;
            txtValorUnitario.SelectionLength = txtValorUnitario.Text.Length;
        }

        private void txtValorTotal_MouseClick(object sender, MouseEventArgs e)
        {
            txtValorTotal.SelectionStart = 0;
            txtValorTotal.SelectionLength = txtValorTotal.Text.Length;
        }

        private void txtValorTotal_Leave(object sender, EventArgs e)
        {
            try
            {
                double tmp = double.Parse(txtValorTotal.Text);
                txtValorTotal.Text = String.Format("{0,10:#,0.00}", tmp);
            }
            catch
            {
                txtValorTotal.Text = String.Format("{0,10:#,0.00}", 0);
            }
        }

        private void txtValorTotal_Enter(object sender, EventArgs e)
        {
            txtValorTotal.SelectionStart = 0;
            txtValorTotal.SelectionLength = txtValorTotal.Text.Length;
        }

        private void txtFlete_Enter(object sender, EventArgs e)
        {
            txtFlete.SelectionStart = 0;
            txtFlete.SelectionLength = txtFlete.Text.Length;
        }

        private void txtFlete_Leave(object sender, EventArgs e)
        {
            try
            {
                double tmp = double.Parse(txtFlete.Text);
                txtFlete.Text = String.Format("{0,10:#,0.00}", tmp);
            }
            catch
            {
                txtFlete.Text = String.Format("{0,10:#,0.00}", 0);
            }
        }

        private void txtFlete_MouseClick(object sender, MouseEventArgs e)
        {
            txtFlete.SelectionStart = 0;
            txtFlete.SelectionLength = txtFlete.Text.Length;
        }

        private void txtSoldicom_Enter(object sender, EventArgs e)
        {
            txtSoldicom.SelectionStart = 0;
            txtSoldicom.SelectionLength = txtSoldicom.Text.Length;
        }

        private void txtSoldicom_Leave(object sender, EventArgs e)
        {
            try
            {
                double tmp = double.Parse(txtSoldicom.Text);
                txtSoldicom.Text = String.Format("{0,10:#,0.00}", tmp);
            }
            catch
            {
                txtSoldicom.Text = String.Format("{0,10:#,0.00}", 0);
            }
        }

        private void txtSoldicom_MouseClick(object sender, MouseEventArgs e)
        {
            txtSoldicom.SelectionStart = 0;
            txtSoldicom.SelectionLength = txtSoldicom.Text.Length;
        }

        private void txtImpuesto_Enter(object sender, EventArgs e)
        {
            txtImpuesto.SelectionStart = 0;
            txtImpuesto.SelectionLength = txtImpuesto.Text.Length;
        }

        private void txtImpuesto_Leave(object sender, EventArgs e)
        {
            try
            {
                double tmp = double.Parse(txtImpuesto.Text);
                txtImpuesto.Text = String.Format("{0,10:#,0.00}", tmp);
            }
            catch
            {
                txtImpuesto.Text = String.Format("{0,10:#,0.00}", 0);
            }
        }

        private void txtImpuesto_MouseClick(object sender, MouseEventArgs e)
        {
            txtImpuesto.SelectionStart = 0;
            txtImpuesto.SelectionLength = txtImpuesto.Text.Length;
        }        
    }
}