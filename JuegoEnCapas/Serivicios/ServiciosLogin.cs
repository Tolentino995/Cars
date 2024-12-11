using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades;




namespace Serivicios
{
    public class ServiciosLogin
    {
        private Consultas consulta; // Referencia a la clase Consultas en lugar de UsuarioDAL

        // Constructor
        public ServiciosLogin()
        {
            consulta = new Consultas(); // Inicializar la clase Consultas
        }

        // Método para obtener la información del usuario
        public UsuarioInfo ObtenerInformacionUsuario(string usuario, string contrasena)
        {
            // Llamada al método ConsultaUsuario de la clase Consultas
            DataTable dtUsuario = consulta.ConsultaUsuario(usuario, contrasena);
            UsuarioInfo usuarioInfo = new UsuarioInfo { EsValido = false, EsAdministrador = false, Nombre = string.Empty };

            // Verificar si se encontró el usuario en la base de datos
            if (dtUsuario.Rows.Count > 0)
            {
                DataRow usuarioData = dtUsuario.Rows[0];
                usuarioInfo.EsValido = true;
                usuarioInfo.EsAdministrador = usuarioData["rol"].ToString().Equals("Administrador", StringComparison.OrdinalIgnoreCase);
                usuarioInfo.Nombre = usuarioData["nombre"].ToString();
            }

            return usuarioInfo;
        }
    }
}
