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
    }
}