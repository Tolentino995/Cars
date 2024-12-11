using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class Conexion
    {
        private string cadenaConexion = ";Server=bmrsm1ejrsu4otzt9g4e-mysql.services.clever-cloud.com;Database=bmrsm1ejrsu4otzt9g4e;UId=u0q5qkuobug9rcmx;Pwd=aSp12cKFp2xc7jUFE54U";

        public MySqlConnection GetConnection()
        {

            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            conexion.Open();
            return conexion;
        }

    }
}
