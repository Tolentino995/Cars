using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;


namespace Serivicios
{
    public class ServiciosRegistro
    {
        Consultas Consulta = new Consultas();
        public bool Registro (String Usuario, String Contraseña, String Correo)
        {
            string UsuarioVacio = "";
            string ContraseñaVacia = "";
            string CorreoVacio = "";
            bool Registrado = false;

            if (UsuarioVacio == Usuario)
            {

                Registrado = false;
            }
            else if (ContraseñaVacia == Contraseña)
            {
                Registrado = false;
            }
            else if (CorreoVacio == Correo) 
            {
                Registrado = false;
            }
            else
            {
                Registrado= Consulta.Alta(Usuario,Contraseña, Correo);
                
            }
            return Registrado;
        }
    }
}
