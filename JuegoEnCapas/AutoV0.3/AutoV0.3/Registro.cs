
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
    public partial class Registro : Form
    {
        bool Registrado;
        ServiciosRegistro Servicio = new ServiciosRegistro();
        public Registro()
        {
            InitializeComponent();
            
        }


        private void BtoAceptar_Click(object sender, EventArgs e)
        {
            string TextoUsuario = TBUsuario.Text.ToString();
            string TextoContraseña = TBContraseña.Text.ToString();
            string TextoCorreo = TBCorreo.Text.ToString();
            string TextoRContraseña = TBRepContraseña.Text.ToString();

            if (TextoRContraseña == TextoContraseña)
            {
                Registrado = Servicio.Registro(TextoUsuario,TextoContraseña,TextoCorreo);
                if (Registrado == true)
                {
                    MessageBox.Show("Registrado Correctamente");
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña muy cortas");
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden, ingreselas de nuevo por favor");
            }
        }
    }
}
