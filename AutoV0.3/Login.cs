using Microsoft.Win32;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Serivicios;

namespace AutoV0._3
{
    public partial class Login : Form
    {
        ServiciosLogin Servicio = new ServiciosLogin();
        bool valido = false;
        public Login()
        {

            InitializeComponent();

        }

        private void TextRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro frmRegistrese = new Registro();
            frmRegistrese.Show();
            this.Hide();

        }

        //Ejecuta metodo si los datos son correctos pasa al menu

        /*Lucas aca tenemos que cambiar el If añadiendo, 
             con el objetivo de que abra */
        private void ButtAceptar_Click(object sender, EventArgs e)
        {
            string TextoUsuario = TBoxUsuario.Text.ToString();
            string TextoContraseña = TBoxContraseña.Text.ToString();
            if (Servicio.UsuarioValido(TextoUsuario, TextoContraseña) == true)
            {
                Menu menu = new Menu();
                menu.UpdateLabelText(TextoUsuario);
                menu.usuario = TextoUsuario;
                menu.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Ingrese un usuario y contraseña valida");
            }

        }

        private void TBoxUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtAceptar_Click(this, new EventArgs());
            }
        }

        private void TBoxContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtAceptar_Click(this, new EventArgs());
            }
        }
    }
}
