namespace AutoV0._3
{
    partial class AdministradorUsuario
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
            imagenNombreUsuario = new PictureBox();
            TBoxUsuario = new TextBox();
            botonJugar = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)imagenNombreUsuario).BeginInit();
            SuspendLayout();
            // 
            // imagenNombreUsuario
            // 
            imagenNombreUsuario.BackColor = Color.Transparent;
            imagenNombreUsuario.Image = Properties.Resources.nombreUsuario;
            imagenNombreUsuario.Location = new Point(318, 195);
            imagenNombreUsuario.Name = "imagenNombreUsuario";
            imagenNombreUsuario.Size = new Size(180, 120);
            imagenNombreUsuario.SizeMode = PictureBoxSizeMode.AutoSize;
            imagenNombreUsuario.TabIndex = 10;
            imagenNombreUsuario.TabStop = false;
            // 
            // TBoxUsuario
            // 
            TBoxUsuario.BackColor = Color.White;
            TBoxUsuario.BorderStyle = BorderStyle.None;
            TBoxUsuario.Location = new Point(338, 244);
            TBoxUsuario.Name = "TBoxUsuario";
            TBoxUsuario.Size = new Size(133, 16);
            TBoxUsuario.TabIndex = 16;
            // 
            // botonJugar
            // 
            botonJugar.BackColor = Color.Transparent;
            botonJugar.BackgroundImageLayout = ImageLayout.Center;
            botonJugar.FlatAppearance.BorderSize = 0;
            botonJugar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            botonJugar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            botonJugar.FlatStyle = FlatStyle.Flat;
            botonJugar.Image = Properties.Resources.DeshabilitarBTN;
            botonJugar.Location = new Point(176, 318);
            botonJugar.Margin = new Padding(0);
            botonJugar.Name = "botonJugar";
            botonJugar.Size = new Size(167, 82);
            botonJugar.TabIndex = 17;
            botonJugar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.HabilitarBTN;
            button1.Location = new Point(486, 318);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(167, 82);
            button1.TabIndex = 18;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.Salir;
            button2.Location = new Point(12, 392);
            button2.Name = "button2";
            button2.Size = new Size(55, 55);
            button2.TabIndex = 19;
            button2.UseVisualStyleBackColor = false;
            // 
            // AdministradorUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MenuAdminUsuario;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(botonJugar);
            Controls.Add(TBoxUsuario);
            Controls.Add(imagenNombreUsuario);
            DoubleBuffered = true;
            Name = "AdministradorUsuario";
            Text = "AdministradorUsuario";
            ((System.ComponentModel.ISupportInitialize)imagenNombreUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imagenNombreUsuario;
        private TextBox TBoxUsuario;
        private Button botonJugar;
        private Button button1;
        private Button button2;
    }
}