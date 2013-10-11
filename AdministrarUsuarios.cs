using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EstacionDB.DTO;
using EstacionDB.Exceptions;
using EstacionDB.Core;

namespace Exportador_Ventas_ServP
{
    public partial class AdministrarUsuarios : Form
    {
        public AdministrarUsuarios()
        {
            InitializeComponent();
            usuarioDTOBindingSource.DataSource = UsuarioCore.getInstance().consultarUsuarios();
        }

        private bool validarCampos(){
            bool valido = true;
            if (txtUsuario.Text.Equals(""))
            {
                txtUsuario.BackColor = Color.Red;
                valido = false;
            }
            if(txtPwd.Text.Equals(""))
            {
                txtPwd.BackColor = Color.Red;
                valido = false;
            }
            if (txtPwd2.Text.Equals(""))
            {
                txtPwd2.BackColor = Color.Red;
                valido = false;
            }
            if (!txtPwd.Text.Equals(txtPwd2.Text))
            {
                txtPwd.BackColor = Color.Red;
                txtPwd2.BackColor = Color.Red;
                valido = false;
            }
            return valido;
        }

        private void limpiarCampos()
        {
            txtUsuario.Text = "";
            txtUsuario.ReadOnly = false;
            txtUsuario.Focus();
            txtPwd.Text = "";
            txtPwd2.Text = "";
            txtUsuario.BackColor = Color.White;
            txtPwd.BackColor = Color.White;
            txtPwd.BackColor = Color.White;
            txtPwd2.BackColor = Color.White;
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            cmdUpdate.Enabled = false;
            cmdGuardar.Enabled = true;
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                try
                {
                    UsuarioDTO dto = new UsuarioDTO();
                    dto.Usuario = txtUsuario.Text;
                    dto.Pwd = txtPwd.Text;
                    dto.IsAdmin = chkAdmin.Checked;

                    int row = UsuarioCore.getInstance().crearUsuario(dto);
                    MessageBox.Show("(" + row + ") Usuario agregado", "Usuario creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCampos();
                    dto.Pwd = "";
                    usuarioDTOBindingSource.Add(dto);
                }
                catch (UsuarioException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Verifique la información que ha ingresado. Los campos obligatorios están marcados en rojos.\n\nLa contraseña debe coincidir con el campo de confirmación.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                try
                {
                    UsuarioDTO dto = (UsuarioDTO)usuarioDTOBindingSource.Current;
                    dto.Usuario = txtUsuario.Text;
                    dto.Pwd = txtPwd.Text;
                    dto.IsAdmin = chkAdmin.Checked;

                    int row = UsuarioCore.getInstance().actualizarUsuario(dto);
                    MessageBox.Show("(" + row + ") Usuario actualizado", "Usuario actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCampos();
                    dto.Pwd = "";
                    dataGridView.Refresh();
                }
                catch (UsuarioException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Verifique la información que ha ingresado. Los campos obligatorios están marcados en rojos.\n\nLa contraseña debe coincidir con el campo de confirmación.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (usuarioDTOBindingSource.Current != null)
            {
                limpiarCampos();
                txtUsuario.Text = ((UsuarioDTO)usuarioDTOBindingSource.Current).Usuario;
                txtUsuario.ReadOnly = true;

                cmdGuardar.Enabled = false;
                cmdUpdate.Enabled = true;
            }
        }
    }
}