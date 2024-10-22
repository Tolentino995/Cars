namespace AutoV0._3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            pictureBox = new PictureBox();
            Jugador = new PictureBox();
            lblPuntos = new Label();
            lblVidas = new Label();
            GameTimer = new System.Windows.Forms.Timer(components);
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            VolverAlMenu = new Button();
            Reiniciar = new Button();
            PararGuardar = new Button();
            PausaImg = new PictureBox();
            nombreUsuario = new PictureBox();
            usuarioLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Jugador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PausaImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nombreUsuario).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Bomba;
            pictureBox1.Location = new Point(168, 114);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "Obstaculos";
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.Transparent;
            pictureBox.Cursor = Cursors.No;
            pictureBox.Image = Properties.Resources.autoEnemigo1_0;
            pictureBox.Location = new Point(751, 72);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(55, 55);
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            pictureBox.Tag = "Obstaculos";
            // 
            // Jugador
            // 
            Jugador.BackColor = Color.Transparent;
            Jugador.Location = new Point(455, 438);
            Jugador.Name = "Jugador";
            Jugador.Size = new Size(67, 79);
            Jugador.SizeMode = PictureBoxSizeMode.Zoom;
            Jugador.TabIndex = 2;
            Jugador.TabStop = false;
            // 
            // lblPuntos
            // 
            lblPuntos.AutoSize = true;
            lblPuntos.BackColor = Color.Transparent;
            lblPuntos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPuntos.ForeColor = SystemColors.ButtonHighlight;
            lblPuntos.Image = Properties.Resources.Puntos;
            lblPuntos.Location = new Point(885, 118);
            lblPuntos.Name = "lblPuntos";
            lblPuntos.Size = new Size(23, 25);
            lblPuntos.TabIndex = 3;
            lblPuntos.Text = "0";
            // 
            // lblVidas
            // 
            lblVidas.AutoSize = true;
            lblVidas.BackColor = Color.Transparent;
            lblVidas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVidas.ForeColor = Color.White;
            lblVidas.Image = Properties.Resources.Vidas;
            lblVidas.Location = new Point(886, 35);
            lblVidas.Name = "lblVidas";
            lblVidas.Size = new Size(23, 25);
            lblVidas.TabIndex = 4;
            lblVidas.Text = "3";
            // 
            // GameTimer
            // 
            GameTimer.Enabled = true;
            GameTimer.Interval = 20;
            GameTimer.Tick += MainGameTimer;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.Vidas;
            pictureBox2.Location = new Point(844, -26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(114, 143);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.Puntos;
            pictureBox3.Location = new Point(844, 72);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(114, 122);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // VolverAlMenu
            // 
            VolverAlMenu.BackColor = Color.Transparent;
            VolverAlMenu.FlatAppearance.BorderSize = 0;
            VolverAlMenu.FlatAppearance.MouseDownBackColor = Color.Transparent;
            VolverAlMenu.FlatAppearance.MouseOverBackColor = Color.Transparent;
            VolverAlMenu.FlatStyle = FlatStyle.Flat;
            VolverAlMenu.Image = Properties.Resources.Volver1;
            VolverAlMenu.Location = new Point(329, 334);
            VolverAlMenu.Name = "VolverAlMenu";
            VolverAlMenu.Size = new Size(87, 78);
            VolverAlMenu.TabIndex = 11;
            VolverAlMenu.UseVisualStyleBackColor = false;
            VolverAlMenu.Visible = false;
            VolverAlMenu.Click += VolverAlMenu_Click;
            // 
            // Reiniciar
            // 
            Reiniciar.BackColor = Color.Transparent;
            Reiniciar.FlatAppearance.BorderSize = 0;
            Reiniciar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Reiniciar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Reiniciar.FlatStyle = FlatStyle.Flat;
            Reiniciar.Image = Properties.Resources.Reiniciar;
            Reiniciar.Location = new Point(481, 334);
            Reiniciar.Name = "Reiniciar";
            Reiniciar.Size = new Size(90, 78);
            Reiniciar.TabIndex = 12;
            Reiniciar.UseVisualStyleBackColor = false;
            Reiniciar.Visible = false;
            Reiniciar.Click += Reiniciar_Click;
            // 
            // PararGuardar
            // 
            PararGuardar.BackColor = Color.Transparent;
            PararGuardar.FlatAppearance.BorderSize = 0;
            PararGuardar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            PararGuardar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            PararGuardar.FlatStyle = FlatStyle.Flat;
            PararGuardar.Image = Properties.Resources.Stop;
            PararGuardar.Location = new Point(614, 334);
            PararGuardar.Name = "PararGuardar";
            PararGuardar.Size = new Size(90, 78);
            PararGuardar.TabIndex = 13;
            PararGuardar.UseVisualStyleBackColor = false;
            PararGuardar.Visible = false;
            PararGuardar.Click += PararGuardar_Click;
            // 
            // PausaImg
            // 
            PausaImg.BackColor = Color.Transparent;
            PausaImg.Location = new Point(303, 93);
            PausaImg.Name = "PausaImg";
            PausaImg.Size = new Size(427, 247);
            PausaImg.SizeMode = PictureBoxSizeMode.StretchImage;
            PausaImg.TabIndex = 14;
            PausaImg.TabStop = false;
            PausaImg.Visible = false;
            // 
            // nombreUsuario
            // 
            nombreUsuario.BackColor = Color.Transparent;
            nombreUsuario.Image = Properties.Resources.usuariolblFrom1;
            nombreUsuario.Location = new Point(-1, -26);
            nombreUsuario.Name = "nombreUsuario";
            nombreUsuario.Size = new Size(107, 101);
            nombreUsuario.TabIndex = 15;
            nombreUsuario.TabStop = false;
            // 
            // usuarioLbl
            // 
            usuarioLbl.AutoSize = true;
            usuarioLbl.BackColor = Color.White;
            usuarioLbl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usuarioLbl.Location = new Point(12, 22);
            usuarioLbl.Name = "usuarioLbl";
            usuarioLbl.Size = new Size(67, 15);
            usuarioLbl.TabIndex = 16;
            usuarioLbl.Text = "ERROR!!!!!!!!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.PistaV04;
            ClientSize = new Size(958, 538);
            Controls.Add(usuarioLbl);
            Controls.Add(nombreUsuario);
            Controls.Add(PausaImg);
            Controls.Add(PararGuardar);
            Controls.Add(Reiniciar);
            Controls.Add(VolverAlMenu);
            Controls.Add(lblPuntos);
            Controls.Add(pictureBox3);
            Controls.Add(lblVidas);
            Controls.Add(Jugador);
            Controls.Add(pictureBox);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Jugador).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)PausaImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)nombreUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox;
        private PictureBox Jugador;
        private Label lblPuntos;
        private Label lblVidas;
        private System.Windows.Forms.Timer GameTimer;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button VolverAlMenu;
        private Button Reiniciar;
        private Button PararGuardar;
        private PictureBox PausaImg;
        private PictureBox nombreUsuario;
        private Label usuarioLbl;
    }
}
