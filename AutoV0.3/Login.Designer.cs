namespace AutoV0._3
{
    partial class Login
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            TBoxUsuario = new TextBox();
            TBoxContraseña = new TextBox();
            TextUsuario = new Label();
            TextContraseña = new Label();
            groupBox1 = new GroupBox();
            TextRegistrarse = new LinkLabel();
            ButtAceptar = new Button();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TBoxUsuario
            // 
            TBoxUsuario.Location = new Point(133, 22);
            TBoxUsuario.Name = "TBoxUsuario";
            TBoxUsuario.Size = new Size(241, 23);
            TBoxUsuario.TabIndex = 0;
            TBoxUsuario.KeyDown += TBoxUsuario_KeyDown;
            // 
            // TBoxContraseña
            // 
            TBoxContraseña.Location = new Point(133, 63);
            TBoxContraseña.Name = "TBoxContraseña";
            TBoxContraseña.PasswordChar = '*';
            TBoxContraseña.Size = new Size(241, 23);
            TBoxContraseña.TabIndex = 1;
            TBoxContraseña.KeyDown += TBoxContraseña_KeyDown;
            // 
            // TextUsuario
            // 
            TextUsuario.AutoSize = true;
            TextUsuario.Location = new Point(18, 25);
            TextUsuario.Name = "TextUsuario";
            TextUsuario.Size = new Size(47, 15);
            TextUsuario.TabIndex = 2;
            TextUsuario.Text = "Usuario";
            // 
            // TextContraseña
            // 
            TextContraseña.AutoSize = true;
            TextContraseña.Location = new Point(18, 66);
            TextContraseña.Name = "TextContraseña";
            TextContraseña.Size = new Size(67, 15);
            TextContraseña.TabIndex = 3;
            TextContraseña.Text = "Contraseña";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(TextRegistrarse);
            groupBox1.Controls.Add(ButtAceptar);
            groupBox1.Controls.Add(TBoxContraseña);
            groupBox1.Controls.Add(TextUsuario);
            groupBox1.Controls.Add(TextContraseña);
            groupBox1.Controls.Add(TBoxUsuario);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(12, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(406, 137);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Iniciar Sesión";
            // 
            // TextRegistrarse
            // 
            TextRegistrarse.AutoSize = true;
            TextRegistrarse.Location = new Point(44, 112);
            TextRegistrarse.Name = "TextRegistrarse";
            TextRegistrarse.Size = new Size(64, 15);
            TextRegistrarse.TabIndex = 5;
            TextRegistrarse.TabStop = true;
            TextRegistrarse.Text = "Registrarse";
            TextRegistrarse.LinkClicked += TextRegistrarse_LinkClicked;
            // 
            // ButtAceptar
            // 
            ButtAceptar.FlatAppearance.BorderSize = 0;
            ButtAceptar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            ButtAceptar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            ButtAceptar.FlatStyle = FlatStyle.Flat;
            ButtAceptar.Location = new Point(181, 104);
            ButtAceptar.Name = "ButtAceptar";
            ButtAceptar.Size = new Size(110, 23);
            ButtAceptar.TabIndex = 4;
            ButtAceptar.Text = "Aceptar";
            ButtAceptar.UseVisualStyleBackColor = true;
            ButtAceptar.Click += ButtAceptar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(801, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "Login";
            Text = "Inicio de sesión";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox TBoxUsuario;
        private TextBox TBoxContraseña;
        private Label TextUsuario;
        private Label TextContraseña;
        private GroupBox groupBox1;
        private Button ButtAceptar;
        private LinkLabel TextRegistrarse;
        private PictureBox pictureBox1;
    }
}