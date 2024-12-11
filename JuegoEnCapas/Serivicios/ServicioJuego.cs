using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Serivicios
{
    public class ServicioJuego
    {
        Consultas Consulta = new Consultas();
        string TextoMostrar;

        public String GuardarPartida(String Usuario, int Vidas, int CodigoAuto, int Puntos, int Velocidad)
        {
            if (Consulta.GuardarPartida(Usuario,Vidas,CodigoAuto,Puntos,Velocidad)== true)
            {
                TextoMostrar = "Guardado Correcto";
            }
            else
            {
                TextoMostrar = "Falla en guardado";
            }
            return TextoMostrar;
        }
    }
}
