using AutoV0._3.Properties;
using Microsoft.VisualBasic.ApplicationServices;
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

namespace AutoV0._3
{
    public partial class Menu : Form
    {
        private System.Media.SoundPlayer player;
        private bool isMusicPlaying = true;
        public String usuario;
        private Conexion baseConexion;
        private int vidas;
        private int codigoAuto;
        private int puntaje;
        private int velocidad;


        public Menu()
        {
            baseConexion = new Conexion();
            InitializeComponent();
            InicializarMusica();
            ReproducirMusica();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ReproducirMusica();
            InicializarMusica();
        }

        public void InicializarMusica()
        { // Ruta del archivo de música
            string rutaMusica = " C:\\Users\\lucas\\Downloads\\AutoV0.3\\AutoV0.3\\Resources\\menuSonido.wav";
            player = new System.Media.SoundPlayer(rutaMusica);
        }

        public void DetenerMusica()
        {
            player.Stop();
            isMusicPlaying = false;
        }

        private void ReproducirMusica()
        { // Reproducir la música en bucle
            player.PlayLooping();
            isMusicPlaying = true;
        }

        /*--------------->BOTONES<---------------*/

        private void botonJugar_Click(object sender, EventArgs e)
        {
            EleccionDeAutos eleccionDeAutos = new EleccionDeAutos();
            eleccionDeAutos.UpdateLabelText(usuario);
            eleccionDeAutos.usuario = usuario;
            eleccionDeAutos.Show();
            this.Close();
        }

        /*Deberia estar séparado en la capa de servicio y acceso a datos pero no tengo ni idea como hacerlo Firma: Lucas*/

        private void botonContinuar_Click(object sender, EventArgs e)
        {
            if (baseConexion.GetConnection != null)
            {
                MySqlCommand mySqlCommand = new MySqlCommand();

                try
                {
                    mySqlCommand.Connection = baseConexion.GetConnection();
                    mySqlCommand.CommandText = ($"SELECT * FROM Partida WHERE usuario='{usuario}'");
                    MySqlDataReader myreader = mySqlCommand.ExecuteReader();
                    
                    if (myreader.HasRows)
                        if (myreader.HasRows) 
                    {     
                            myreader.Read();
                            vidas = (int)myreader["vidasActuales"];
                            codigoAuto = (int)myreader["auto"];
                            velocidad = (int)myreader["velocidad"];
                            puntaje = (int)myreader["puntaje"];

                        Form1 NuevaVentana = new Form1();

                        if (codigoAuto == 1)
                        {
                            NuevaVentana.JugadorImagen = Resources.PistaTacho;
                            NuevaVentana.CodigoAuto = 1;
                            NuevaVentana.vidasIniciales = 3;
                            NuevaVentana.vidas = vidas;
                            NuevaVentana.puntos = puntaje;
                        }
                        else if (codigoAuto == 2)
                        {
                            NuevaVentana.JugadorImagen = Resources.PistaTitiko;
                            NuevaVentana.CodigoAuto = 2;
                            NuevaVentana.vidasIniciales = 4;
                            NuevaVentana.vidas = vidas;
                            NuevaVentana.puntos = puntaje;
                        }
                        else if (codigoAuto == 3)
                        {
                            NuevaVentana.JugadorImagen = Resources.PistaFitito;
                            NuevaVentana.CodigoAuto = 3;
                            NuevaVentana.vidasIniciales = 2;
                            NuevaVentana.vidas = vidas;
                            NuevaVentana.puntos = puntaje;
                        }
                        else if (codigoAuto == 4)
                        {
                            NuevaVentana.JugadorImagen = Resources.PistaGremlin;
                            NuevaVentana.CodigoAuto = 4;
                            NuevaVentana.vidasIniciales = 5;
                            NuevaVentana.vidas = vidas;
                            NuevaVentana.puntos = puntaje;
                        }

                        NuevaVentana.UpdateLabelText(usuario);
                        NuevaVentana.usuario = usuario;
                        NuevaVentana.Show();
                        this.Close();
                    }
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fallo");

                }

            }


            

        }
        private void botonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void btnSilenciar_Click(object sender, EventArgs e)
        {
            if (isMusicPlaying)
            {
                DetenerMusica();
                btnSilenciar.Image = Properties.Resources.Silenciar;
            }
            else
            {
                ReproducirMusica();
                btnSilenciar.Image = Properties.Resources.Sonido;
            }
        }

        /*--------------->lABEL<---------------*/

        public void UpdateLabelText(string text)
        {
            usuarioLbl.Text = text;
        }

        /*--------------->EFECTOS DE LOS BOTONES<---------------*/
        private void botonJugar_MouseEnter(object sender, EventArgs e)
        {
            botonJugar.Image = Properties.Resources.Choque;
        }

        private void botonJugar_MouseLeave(object sender, EventArgs e)
        {
            botonJugar.Image = Properties.Resources.botonJugar;
        }

        private void botonContinuar_MouseEnter(object sender, EventArgs e)
        {
            botonContinuar.Image = Properties.Resources.Choque;
        }

        private void botonContinuar_MouseLeave(object sender, EventArgs e)
        {
            botonContinuar.Image = Properties.Resources.botonContinuar;
        }

        private void botonSalir_MouseEnter(object sender, EventArgs e)
        {
            botonSalir.Image = Properties.Resources.Choque;
        }

        private void botonSalir_MouseLeave(object sender, EventArgs e)
        {
            botonSalir.Image = Properties.Resources.botonSalir;
        }

       
    }
}
