using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EstacionDB.Exceptions;
using EstacionDB.Core;
using EstacionDB.Utilidades;
using System.Configuration;

namespace Exportador_Ventas_ServP
{
    public partial class Login : Form
    {   
        public Login()
        {
            InitializeComponent();
            Utilidades.configExpo = Application.StartupPath + ConfigurationSettings.AppSettings["ExpoConfig"].ToString();
        }

        private void cmdIngresar_Click(object sender, EventArgs e)
        {
            if (!txtPwd.Text.Equals("") && !txtUsuario.Text.Equals(""))
            {
                try
                {
                    Utilidades.usuarioSesion = UsuarioCore.getInstance().validarUsuario(txtUsuario.Text, txtPwd.Text);
                    PanelPrincipal panel = new PanelPrincipal();
                    panel.Show();
                    this.Hide();
                }
                catch (UsuarioException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPwd.Text = "";
                    txtUsuario.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar todo los campos", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}