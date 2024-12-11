namespace AutoV0._3
{
    partial class Administrador
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
            button2 = new Button();
            botonJugar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.Salir;
            button2.Location = new Point(12, 383);
            button2.Name = "button2";
            button2.Size = new Size(55, 55);
            button2.TabIndex = 14;
            button2.UseVisualStyleBackColor = false;
            // 
            // botonJugar
            // 
            botonJugar.BackColor = Color.Transparent;
            botonJugar.BackgroundImageLayout = ImageLayout.Center;
            botonJugar.FlatAppearance.BorderSize = 0;
            botonJugar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            botonJugar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            botonJugar.FlatStyle = FlatStyle.Flat;
            botonJugar.Image = Properties.Resources.UsuariosBTN;
            botonJugar.Location = new Point(317, 205);
            botonJugar.Margin = new Padding(0);
            botonJugar.Name = "botonJugar";
            botonJugar.Size = new Size(167, 82);
            botonJugar.TabIndex = 18;
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
            button1.Image = Properties.Resources.JuegoBTN;
            button1.Location = new Point(317, 287);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(167, 82);
            button1.TabIndex = 19;
            button1.UseVisualStyleBackColor = false;
            // 
            // Administrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ADMINISTRADOR_FONDO;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(botonJugar);
            Controls.Add(button2);
            DoubleBuffered = true;
            Name = "Administrador";
            Text = "Administrador";
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Button botonJugar;
        private Button button1;
    }
}