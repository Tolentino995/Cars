namespace AutoV0._3
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSilenciar = new Button();
            botonJugar = new Button();
            botonSalir = new Button();
            botonContinuar = new Button();
            pictureBox1 = new PictureBox();
            imagenNombreUsuario = new PictureBox();
            usuarioLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imagenNombreUsuario).BeginInit();
            SuspendLayout();
            // 
            // btnSilenciar
            // 
            btnSilenciar.BackColor = Color.Transparent;
            btnSilenciar.BackgroundImageLayout = ImageLayout.Center;
            btnSilenciar.FlatAppearance.BorderSize = 0;
            btnSilenciar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSilenciar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSilenciar.FlatStyle = FlatStyle.Flat;
            btnSilenciar.Image = Properties.Resources.Sonido;
            btnSilenciar.Location = new Point(891, 12);
            btnSilenciar.Name = "btnSilenciar";
            btnSilenciar.Size = new Size(55, 55);
            btnSilenciar.TabIndex = 0;
            btnSilenciar.UseVisualStyleBackColor = false;
            btnSilenciar.Click += btnSilenciar_Click;
            // 
            // botonJugar
            // 
            botonJugar.BackColor = Color.Transparent;
            botonJugar.BackgroundImageLayout = ImageLayout.Center;
            botonJugar.FlatAppearance.BorderSize = 0;
            botonJugar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            botonJugar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            botonJugar.FlatStyle = FlatStyle.Flat;
            botonJugar.Image = Properties.Resources.botonJugar;
            botonJugar.Location = new Point(396, 238);
            botonJugar.Margin = new Padding(0);
            botonJugar.Name = "botonJugar";
            botonJugar.Size = new Size(167, 82);
            botonJugar.TabIndex = 4;
            botonJugar.UseVisualStyleBackColor = false;
            botonJugar.Click += botonJugar_Click;
            botonJugar.MouseEnter += botonJugar_MouseEnter;
            botonJugar.MouseLeave += botonJugar_MouseLeave;
            // 
            // botonSalir
            // 
            botonSalir.BackColor = Color.Transparent;
            botonSalir.BackgroundImageLayout = ImageLayout.Center;
            botonSalir.FlatAppearance.BorderSize = 0;
            botonSalir.FlatAppearance.MouseDownBackColor = Color.Transparent;
            botonSalir.FlatAppearance.MouseOverBackColor = Color.Transparent;
            botonSalir.FlatStyle = FlatStyle.Flat;
            botonSalir.Image = Properties.Resources.botonSalir;
            botonSalir.Location = new Point(396, 424);
            botonSalir.Margin = new Padding(0);
            botonSalir.Name = "botonSalir";
            botonSalir.Size = new Size(167, 82);
            botonSalir.TabIndex = 5;
            botonSalir.UseVisualStyleBackColor = false;
            botonSalir.Click += botonSalir_Click;
            botonSalir.MouseEnter += botonSalir_MouseEnter;
            botonSalir.MouseLeave += botonSalir_MouseLeave;
            // 
            // botonContinuar
            // 
            botonContinuar.BackColor = Color.Transparent;
            botonContinuar.BackgroundImageLayout = ImageLayout.Center;
            botonContinuar.FlatAppearance.BorderSize = 0;
            botonContinuar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            botonContinuar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            botonContinuar.FlatStyle = FlatStyle.Flat;
            botonContinuar.Image = Properties.Resources.botonContinuar;
            botonContinuar.Location = new Point(396, 332);
            botonContinuar.Margin = new Padding(0);
            botonContinuar.Name = "botonContinuar";
            botonContinuar.Size = new Size(167, 82);
            botonContinuar.TabIndex = 6;
            botonContinuar.UseVisualStyleBackColor = false;
            botonContinuar.Click += botonContinuar_Click;
            botonContinuar.MouseEnter += botonContinuar_MouseEnter;
            botonContinuar.MouseLeave += botonContinuar_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.logoUsuario;
            pictureBox1.Location = new Point(778, 259);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 121);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // imagenNombreUsuario
            // 
            imagenNombreUsuario.BackColor = Color.Transparent;
            imagenNombreUsuario.Image = Properties.Resources.nombreUsuario;
            imagenNombreUsuario.Location = new Point(747, 355);
            imagenNombreUsuario.Name = "imagenNombreUsuario";
            imagenNombreUsuario.Size = new Size(175, 100);
            imagenNombreUsuario.TabIndex = 8;
            imagenNombreUsuario.TabStop = false;
            // 
            // usuarioLbl
            // 
            usuarioLbl.AutoSize = true;
            usuarioLbl.BackColor = Color.White;
            usuarioLbl.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold);
            usuarioLbl.Location = new Point(778, 399);
            usuarioLbl.Name = "usuarioLbl";
            usuarioLbl.Size = new Size(119, 24);
            usuarioLbl.TabIndex = 9;
            usuarioLbl.Text = "ERROR!!!!!!!";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondoMenu;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(958, 538);
            Controls.Add(usuarioLbl);
            Controls.Add(pictureBox1);
            Controls.Add(imagenNombreUsuario);
            Controls.Add(botonContinuar);
            Controls.Add(botonSalir);
            Controls.Add(botonJugar);
            Controls.Add(btnSilenciar);
            DoubleBuffered = true;
            Name = "Menu";
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imagenNombreUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSilenciar;
        private Button botonJugar;
        private Button botonSalir;
        private Button botonContinuar;
        private PictureBox pictureBox1;
        private PictureBox imagenNombreUsuario;
        private Label usuarioLbl;
    }
}