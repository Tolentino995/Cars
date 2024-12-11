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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Serivicios;


namespace AutoV0._3
{
    public partial class Form1 : Form
    {
        private System.Media.SoundPlayer player;
        private bool isMusicPlaying;
        ServicioJuego Servicio = new ServicioJuego();

        private void ReproducirMusica()
        { // Reproducir la música en bucle
            string rutaMusica = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "sonidoChoque.wav");
            player = new System.Media.SoundPlayer(rutaMusica);
            player.Play();
            isMusicPlaying = true;
        }
        public Image JugadorImagen { get; set; }

        public int vidas { get; set; }

        public String usuario;

        public int vidasIniciales { get; set; }
        public int puntos { get; set; }

        private Conexion baseConexion;

        public int CodigoAuto; 

        bool uLeft, uRight, uUp, uDown;

        bool estaColisionando = false;

        int puntosMax = 3;
        int speed = 8;


        Random ranX = new Random();
        Random ranY = new Random();

        public Form1()
        {
            InitializeComponent();
            RestartGame();
            baseConexion = new Conexion();
        }

        private void SetOriginalImage()
        {
            Jugador.Image = JugadorImagen; // Reemplace 'Jugador' con su control de imagen real
        }

        private void SetTempImage()
        {
            Jugador.Image = Properties.Resources.Choque; // Reemplácelo con su recurso de imagen temporal
        }

        // se encarga de gestionar la lógica principal del juego,
        // incluyendo el movimiento del jugador, la actualización de
        // la puntuación y la vida, la detección de colisiones y la reaparición
        // de obstáculos
        private void MainGameTimer(object sender, EventArgs e)
        {
            SetOriginalImage();

            lblVidas.Text = " " + vidas;
            lblPuntos.Text = " " + puntos;

            if (uLeft == true && Jugador.Left - 10 >= 115)
            {
                Jugador.Left -= 10;
            }
            if (uRight == true && Jugador.Left + Jugador.Width + 10 <= 815)
            {
                Jugador.Left += 10;
            }
            if (uUp == true && Jugador.Top - 10 >= 0)
            {
                Jugador.Top -= 10;
            }
            if (uDown == true && Jugador.Top + Jugador.Height + 10 <= this.ClientSize.Height)
            {
                Jugador.Top += 10;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Obstaculos")
                {
                    x.Top += speed;
                }

                if (x.Top + x.Height > this.ClientSize.Height)
                {
                    x.Top = ranY.Next(80, 300) * -1;
                    x.Left = ranX.Next(115, 815);
                    puntos += 1;
                }

                if (Jugador.Bounds.IntersectsWith(x.Bounds) && x is PictureBox && (string)x.Tag == "Obstaculos")
                {
                    if (!estaColisionando)
                    {
                        SetTempImage();

                        // Lucas P***

                        ReproducirMusica();

                        vidas -= 1;
                        x.Top = -x.Height;
                        x.Left = ranX.Next(115, 815);
                        estaColisionando = true;

                        //Agregar un timer 
                        SetOriginalImage();
                    }

                }
                else
                {
                    estaColisionando = false;
                }
            }

            if (puntos > puntosMax)
            {
                speed += 4;
                puntosMax = puntos + 10;
            }

            if (vidas <= 0)
            {
                //lucas p***
                lblVidas.Text = " " + "0";

                PausaImg.Image = Properties.Resources.PerdioImG;
                PausaImg.Visible = true;
                Reiniciar.Visible = true;
                VolverAlMenu.Visible = true;
                PararGuardar.Visible = true;
                GameTimer.Stop();
            }
        }

        //se activa cuando el usuario presiona una tecla en el formulario
        private void KeyIsDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                if (GameTimer.Enabled)
                {
                    PausaImg.Image = Properties.Resources.PausaImG;
                    PausaImg.Visible = true;
                    Reiniciar.Visible = true;
                    VolverAlMenu.Visible = true;
                    PararGuardar.Visible = true;
                    GameTimer.Stop();
                }
                else
                {
                    PausaImg.Visible = false;
                    Reiniciar.Visible = false;
                    VolverAlMenu.Visible = false;
                    PararGuardar.Visible = false;
                    GameTimer.Start();
                }
            }
            if (e.KeyCode == Keys.Left)
            {
                uLeft = true;
            }
            else if (e.KeyCode == Keys.Right)
            {
                uRight = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                uUp = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                uDown = true;
            }
        }



        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                uLeft = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                uRight = false;
            }
            else if (e.KeyCode == Keys.Up)
            {
                uUp = false;
            }
            else if (e.KeyCode == Keys.Down)
            {
                uDown = false;
            }
        }

        private void RestartGame()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Obstaculos")
                {
                    x.Top = ranY.Next(80, 300) * -1;
                    x.Left = ranX.Next(115, 815);
                }
            }

            Jugador.Left = this.ClientSize.Width / 2;

            puntos = 0;
            speed = 8;

            uLeft = false;
            uRight = false;
            uDown = false;
            uUp = false;

            GameTimer.Start();


        }

        private void VolverAlMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            EleccionDeAutos NuevaVentana = new EleccionDeAutos();
            NuevaVentana.Show();
        }

        public void UpdateLabelText(string text)
        {
            usuarioLbl.Text = text;
        }

        private void Reiniciar_Click(object sender, EventArgs e)
        {

            PausaImg.Visible = false;
            Reiniciar.Visible = false;
            VolverAlMenu.Visible = false;
            PararGuardar.Visible = false;

            //this.Controls.Clear(); // Elimina todos los controles del formulario
            //InitializeComponent(); // Vuelve a inicializar los componentes (vuelve a agregar los controles)
            //RestartGame();
            //Solucion temporal
            //Abre una nueva ventana 

            this.Hide();

            Form1 NuevaVentana = new Form1();

            NuevaVentana.JugadorImagen = Jugador.Image;

            NuevaVentana.vidas = vidasIniciales;

            NuevaVentana.vidasIniciales = vidasIniciales;

            NuevaVentana.UpdateLabelText(usuario);
            NuevaVentana.usuario = usuario;

            NuevaVentana.Show();

            this.Close();


        }

        private void PararGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Servicio.GuardarPartida(usuario, vidas, CodigoAuto, puntos, speed));
            Menu menu = new Menu();
            menu.UpdateLabelText(usuario);
            menu.usuario = usuario;

            menu.Show();
            this.Close();

        }
    }
}
