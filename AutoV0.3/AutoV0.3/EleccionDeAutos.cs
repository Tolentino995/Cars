using AutoV0._3.Properties;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace AutoV0._3
{
    public partial class EleccionDeAutos : Form
    {
        
        private System.Media.SoundPlayer player;
        private bool isMusicPlaying = true;
        public String usuario;

        public EleccionDeAutos()
        {
            InitializeComponent();
            InicializarMusica();
            ReproducirMusica();

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

        //Eventos de la seleccion de Autos, "que son los Botones"
        private void label1_Click(object sender, EventArgs e)
        {
            nombreAuto.Text = "TACHO";
            propiedadesDelAuto.Image = Properties.Resources.PropiedadesDelTacho;
            presntacionAuto.Image = Properties.Resources.PresentacionTacho;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            nombreAuto.Text = "TITIKO";
            propiedadesDelAuto.Image = Properties.Resources.PropiedadesDelTitiko;
            presntacionAuto.Image = Properties.Resources.PresentacionTitiko;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            nombreAuto.Text = "FITITO";
            propiedadesDelAuto.Image = Properties.Resources.PropiedadesDelFitito;
            presntacionAuto.Image = Properties.Resources.PresentacionFitito;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            nombreAuto.Text = "GREMLIN";
            propiedadesDelAuto.Image = Properties.Resources.PropiedadesDelGermlin;
            presntacionAuto.Image = Properties.Resources.PresentacionGermling;
        }


        // Tenemos el boton de Play

        private void play_Click(object sender, EventArgs e)
        {
            if (nombreAuto.Text == "")
            {
                // Aparecen Estos elementos para avisarle al usuario que tiene que escoger un auto
                button2.Visible = true;
                pictureBox1.Visible = true;
                //Desahbilito los botones de los autos
                TITIKO.Enabled = false;
                TACHO.Enabled = false;
                FITITO.Enabled = false;
                GRMLIN.Enabled = false;

            }
            else
            {

                // Metodo para ocultar la ventana actual
                //Creamos una instancia del Form1
                Form1 NuevaVentana = new Form1();

                if (nombreAuto.Text == "TACHO")
                {
                    NuevaVentana.JugadorImagen = Properties.Resources.PistaTacho;
                    NuevaVentana.CodigoAuto = 1;
                    NuevaVentana.vidas = 3;
                    NuevaVentana.vidasIniciales = 3;
                    NuevaVentana.puntos = 0;
                }
                else if (nombreAuto.Text == "TITIKO")
                {
                    NuevaVentana.JugadorImagen = Properties.Resources.PistaTitiko;
                    NuevaVentana.vidas = 4;
                    NuevaVentana.CodigoAuto = 2;
                    NuevaVentana.vidasIniciales = 4;
                    NuevaVentana.puntos = 0;
                }
                else if (nombreAuto.Text == "FITITO")
                {
                    NuevaVentana.JugadorImagen = Properties.Resources.PistaFitito;
                    NuevaVentana.vidas = 2;
                    NuevaVentana.CodigoAuto = 3;
                    NuevaVentana.vidasIniciales = 2;
                    NuevaVentana.puntos = 0;
                }
                else if (nombreAuto.Text == "GREMLIN")
                {
                    NuevaVentana.JugadorImagen = Properties.Resources.PistaGremlin;
                    NuevaVentana.vidas = 5;
                    NuevaVentana.CodigoAuto = 4;
                    NuevaVentana.vidasIniciales = 5;
                    NuevaVentana.puntos = 0;
                }

                NuevaVentana.UpdateLabelText(usuario);
                NuevaVentana.usuario = usuario;
                // Se muestra Form1
                NuevaVentana.Show();
                // Metodo para cerrar la ventana actual
                this.Close();
            }


        }


        //LLeva al formulario 
        private void Ranking_Click(object sender, EventArgs e)
        {
          
            Ranking NuevaVentana = new Ranking();
            NuevaVentana.Show();
            this.Close();
        }

        // Boton que permite al usuario poder seleccionar un auto
        private void button2_Click(object sender, EventArgs e)
        {
            // Oculta los elementos que avisaban al usuario que tiene que escoger un auto
            button2.Visible = false;
            pictureBox1.Visible = false;
            //Habilita los botones de los autos
            FITITO.Enabled = true;
            TACHO.Enabled = true;
            TITIKO.Enabled = true;
            GRMLIN.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Menu NuevaVentana = new Menu();
            NuevaVentana.Show();
            NuevaVentana.UpdateLabelText(usuario);
            NuevaVentana.usuario = usuario;
            this.Close();
        }
        

        private void musicaEleccion_Click(object sender, EventArgs e)
        {
            if (isMusicPlaying)
            {
                DetenerMusica();
                musicaEleccion.Image = Properties.Resources.Silenciar;
            }
            else
            {
                ReproducirMusica();
                musicaEleccion.Image = Properties.Resources.Sonido;
            }
        }

        public void UpdateLabelText(string text)
        {
            LblUsuario.Text = text;
        }


    }
}
