using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EstacionDB.VO;
using Exportador_Ventas_ServP.Controller;
using EstacionDB.Utilidades;
using EstacionDB.DTO;
using System.Collections;
using EstacionDB.Exceptions;

namespace Exportador_Ventas_ServP
{
    public partial class Lecturas : Form
    {
        ControladorPersistencia cp = new ControladorPersistencia();

        public Lecturas()
        {
            InitializeComponent();
        }

        private void Lecturas_Load(object sender, EventArgs e)
        {
            productoVOBindingSource.DataSource = cp.consultarProductos();
            tanqueVOBindingSource.DataSource = cp.consultarTanques();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            //Consulta los galones a partir de la fecha, de la medida de la vara, del producto y tipo de tanque
            if (!txtFecha.Text.Equals("") && !txtMedida.Text.Equals(""))
            {
                DateTime fecha = DateTime.Parse(txtFecha.Text);
                LecturaDTO lectura = cp.consultarNivel((int)cboProducto.SelectedValue, (int)cboTanque.SelectedValue, double.Parse(txtMedida.Text));                
                if (lectura != null)
                {
                    lectura.Producto = ((ProductoVO)cboProducto.SelectedItem).Nombre;
                    lectura.Tanque = ((TanqueVO)cboTanque.SelectedItem).Descripcion;
                    lectura.Nivel = double.Parse(txtMedida.Text);
                    lecturaDTOBindingSource.Add(lectura);
                }
                else
                {
                    MessageBox.Show("No hay información en las tablas de aforo para el producto y tanque seleccionados", "No hay información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            //Consulta los galones a partir de la fecha y del producto
            else if (!txtFecha.Text.Equals("") && txtMedida.Text.Equals(""))
            {
                DateTime fecha = DateTime.Parse(txtFecha.Text);
                double galones = cp.consultarLecturaFinalProducto(fecha, fecha,(int)cboProducto.SelectedValue);
                LecturaDTO lectura = new LecturaDTO();
                lectura.IdProducto = ((ProductoVO)cboProducto.SelectedItem).IdProducto;
                lectura.Producto = ((ProductoVO)cboProducto.SelectedItem).Nombre;
                lectura.IdTanque = ((TanqueVO)cboTanque.SelectedItem).IdTanque;
                lectura.Tanque = ((TanqueVO)cboTanque.SelectedItem).Descripcion;
                lectura.Nivel = 0;
                lectura.Galones = galones;
                lecturaDTOBindingSource.Add(lectura);
                
                //MessageBox.Show("Debe llenar todos la fecha, producto, tanque y nivel", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if(lecturaDTOBindingSource.Count > 0){
                try
                {
                    DateTime fecha = DateTime.Parse(txtFecha.Text);
                    IList lista = lecturaDTOBindingSource.List;
                    LecturaDTO[] lecturas = new LecturaDTO[lista.Count];
                    lista.CopyTo(lecturas, 0);
                    int rows = cp.procesarControles(fecha, lecturas);
                    if (rows > 0)
                    {
                        lecturaDTOBindingSource.Clear();
                        txtMedida.Text = "";
                        txtFecha.Text = "";
                        MessageBox.Show("Lecturas guardadas", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se guardaron las lecturas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (PersistenciaException ex)
                {
                    MessageBox.Show("No se guardaron las lecturas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            if (lecturaDTOBindingSource.Current != null)
            {
                LecturaDTO l = (LecturaDTO)lecturaDTOBindingSource.Current;
                lecturaDTOBindingSource.Remove(l);
                dataGridView1.Update();
            }
        }

        private void txtMedida_Enter(object sender, EventArgs e)
        {
            txtMedida.SelectionStart = 0;
            txtMedida.SelectionLength = txtMedida.Text.Length;
        }

        private void txtMedida_Leave(object sender, EventArgs e)
        {
            try
            {
                double tmp = double.Parse(txtMedida.Text);
                txtMedida.Text = String.Format("{0,10:#,0.00}", tmp);
            }
            catch
            {
                txtMedida.Text = String.Format("{0,10:#,0.00}", 0);
            }
        }

        private void txtMedida_MouseClick(object sender, MouseEventArgs e)
        {
            txtMedida.SelectionStart = 0;
            txtMedida.SelectionLength = txtMedida.Text.Length;
        }
    }
}