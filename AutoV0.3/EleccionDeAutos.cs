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
        /*------->MUSICA<---------*/
        public void InicializarMusica()
        {
            string rutaMusica = " C:\\Users\\antho\\Downloads\\AutoV0.3\\AutoV0.3\\Resources\\menuSonido.wav";
            player = new System.Media.SoundPlayer(rutaMusica);
        }
        public void DetenerMusica()
        {
            player.Stop();
            isMusicPlaying = false;
        }
        private void ReproducirMusica()
        {
            player.PlayLooping();
            isMusicPlaying = true;
        }

        /*---------->LABEL CARTE<----------*/
        private void label1_Click(object sender, EventArgs e)
        {
            nombreAuto.Text = "TACHO";
            propiedadesDelAuto.Image = Resources.PropiedadesDelTacho;
            presntacionAuto.Image = Resources.PresentacionTacho;
        }
        private void label2_Click(object sender, EventArgs e)
        {
            nombreAuto.Text = "TITIKO";
            propiedadesDelAuto.Image = Resources.PropiedadesDelTitiko;
            presntacionAuto.Image = Resources.PresentacionTitiko;
        }
        private void label3_Click(object sender, EventArgs e)
        {
            nombreAuto.Text = "FITITO";
            propiedadesDelAuto.Image = Resources.PropiedadesDelFitito;
            presntacionAuto.Image = Resources.PresentacionFitito;
        }
        private void label4_Click(object sender, EventArgs e)
        {
            nombreAuto.Text = "GREMLIN";
            propiedadesDelAuto.Image = Resources.PropiedadesDelGermlin;
            presntacionAuto.Image = Resources.PresentacionGermling;
        }
        /*------------>BOTONES<-----------*/
        private void play_Click(object sender, EventArgs e)
        {
            if (nombreAuto.Text == "")
            {
                // Aparecen Estos elementos para avisarle al usuario que tiene que escoger un auto
                OK.Visible = true;
                pictureBox1.Visible = true;
                //Desabilita los botones de los autos
                TITIKO.Enabled = false;
                TACHO.Enabled = false;
                FITITO.Enabled = false;
                GRMLIN.Enabled = false;
            }
            else /*Selecciona al auto, cierra y abre una nueva ventana*/
            {
                Form1 NuevaVentana = new Form1();

                if (nombreAuto.Text == "TACHO")
                {
                    NuevaVentana.JugadorImagen = Resources.PistaTacho;
                    NuevaVentana.CodigoAuto = 1;
                    NuevaVentana.vidas = 3;
                    NuevaVentana.vidasIniciales = 3;
                    NuevaVentana.puntos = 0;
                }
                else if (nombreAuto.Text == "TITIKO")
                {
                    NuevaVentana.JugadorImagen = Resources.PistaTitiko;
                    NuevaVentana.vidas = 4;
                    NuevaVentana.CodigoAuto = 2;
                    NuevaVentana.vidasIniciales = 4;
                    NuevaVentana.puntos = 0;
                }
                else if (nombreAuto.Text == "FITITO")
                {
                    NuevaVentana.JugadorImagen = Resources.PistaFitito;
                    NuevaVentana.vidas = 2;
                    NuevaVentana.CodigoAuto = 3;
                    NuevaVentana.vidasIniciales = 2;
                    NuevaVentana.puntos = 0;
                }
                else if (nombreAuto.Text == "GREMLIN")
                {
                    NuevaVentana.JugadorImagen = Resources.PistaGremlin;
                    NuevaVentana.vidas = 5;
                    NuevaVentana.CodigoAuto = 4;
                    NuevaVentana.vidasIniciales = 5;
                    NuevaVentana.puntos = 0;
                }

                NuevaVentana.UpdateLabelText(usuario);
                NuevaVentana.usuario = usuario;
                NuevaVentana.Show();
                this.Close();
            }
        }
        private void Ranking_Click(object sender, EventArgs e)
        {
            Ranking NuevaVentana = new Ranking();
            NuevaVentana.Show();
            this.Close();
        }
        // Boton que permite al usuario poder seleccionar un auto
        private void OK_Click(object sender, EventArgs e)
        {
            // Oculta los elementos que avisaban al usuario que tiene que escoger un auto
            OK.Visible = false;
            pictureBox1.Visible = false;
            //Habilita los botones de los autos
            FITITO.Enabled = true;
            TACHO.Enabled = true;
            TITIKO.Enabled = true;
            GRMLIN.Enabled = true;
        }

        private void botonVolverMenu_Click(object sender, EventArgs e)
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
                musicaEleccion.Image = Resources.Silenciar;
            }
            else
            {
                ReproducirMusica();
                musicaEleccion.Image = Resources.Sonido;
            }
        }

        public void UpdateLabelText(string text)
        {
            LblUsuario.Text = text;
        }

        
    }
}
