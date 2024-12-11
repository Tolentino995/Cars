using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class Consultas
    {
        Conexion baseConexion = new Conexion();
        bool Valido;

        // Método para consultar un usuario con parámetros
        public DataTable ConsultaUsuario(string usuario, string contrasena)
        {
            DataTable dt = new DataTable();
            using (var conn = baseConexion.GetConnection())
            {
                string query = "SELECT * FROM Usuario WHERE usuario = @usuario AND contraseña = @contrasena";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);

                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        // Método para registrar un nuevo usuario
        public bool Alta(String Usuario, String Contraseña, String Correo)
        {
            if (baseConexion.GetConnection != null)
            {
                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.Connection = baseConexion.GetConnection();
                mySqlCommand.CommandText = ("insert into Usuario(usuario,contraseña,correo) values('" + Usuario + "','" + Contraseña + "','" + Correo + "');");
                mySqlCommand.ExecuteNonQuery();
                baseConexion.GetConnection().Close();
                Valido = true;
            }
            return Valido;
        }

        // Método para guardar partida
        public bool GuardarPartida(String Usuario, int Vidas, int CodigoAuto, int Puntos, int Velocidad)
        {
            if (baseConexion.GetConnection != null)
            {
                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.Connection = baseConexion.GetConnection();
                mySqlCommand.CommandText = ($"Delete FROM Partida WHERE usuario='{Usuario}'");
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = ("insert into Partida(usuario,vidasActuales,auto,puntaje,velocidad) values('" + Usuario + "','" + Vidas + "','" + CodigoAuto + "','" + Puntos + "','" + Velocidad + "');");
                mySqlCommand.ExecuteNonQuery();
                baseConexion.GetConnection().Close();
                Valido = true;
            }
            else
            {
                // Handle failure
            }
            return Valido;
        }
    }
}
