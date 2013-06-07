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
            else
            {
                MessageBox.Show("Debe llenar todos la fecha, producto, tanque y nivel", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
    }
}