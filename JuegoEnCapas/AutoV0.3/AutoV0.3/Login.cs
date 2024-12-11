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
using System.Net.Http.Headers;
using Entidades;

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
            string usuario = TBoxUsuario.Text;
            string contrasena = TBoxContraseña.Text;

            UsuarioInfo usuarioInfo = Servicio.ObtenerInformacionUsuario(usuario, contrasena);

            if (usuarioInfo.EsValido)
            {
                if (usuarioInfo.EsAdministrador)
                {
                    //MenuAdmin menuAdmin = new MenuAdmin();
                    //menuAdmin.UpdateLabelText(usuarioInfo.Nombre);
                    //menuAdmin.Show();
                }
                else
                {
                    Menu menuUsuario = new Menu();
                    menuUsuario.UpdateLabelText(usuarioInfo.Nombre);
                    menuUsuario.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Intente de nuevo.");
            }
        }
    }
}
