namespace AutoV0._3
{
    partial class Registro
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
            BtoAceptar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TBUsuario = new TextBox();
            TBCorreo = new TextBox();
            TBRepContraseña = new TextBox();
            TBContraseña = new TextBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // BtoAceptar
            // 
            BtoAceptar.Location = new Point(191, 236);
            BtoAceptar.Name = "BtoAceptar";
            BtoAceptar.Size = new Size(75, 23);
            BtoAceptar.TabIndex = 0;
            BtoAceptar.Text = "Aceptar";
            BtoAceptar.UseVisualStyleBackColor = true;
            BtoAceptar.Click += BtoAceptar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 35);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 87);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 144);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 3;
            label3.Text = "Repetir Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 193);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 4;
            label4.Text = "Correo";
            // 
            // TBUsuario
            // 
            TBUsuario.Location = new Point(120, 32);
            TBUsuario.Name = "TBUsuario";
            TBUsuario.Size = new Size(318, 23);
            TBUsuario.TabIndex = 5;
            // 
            // TBCorreo
            // 
            TBCorreo.Location = new Point(120, 190);
            TBCorreo.Name = "TBCorreo";
            TBCorreo.Size = new Size(318, 23);
            TBCorreo.TabIndex = 6;
            // 
            // TBRepContraseña
            // 
            TBRepContraseña.Location = new Point(120, 136);
            TBRepContraseña.Name = "TBRepContraseña";
            TBRepContraseña.PasswordChar = '*';
            TBRepContraseña.Size = new Size(318, 23);
            TBRepContraseña.TabIndex = 7;
            // 
            // TBContraseña
            // 
            TBContraseña.Location = new Point(120, 84);
            TBContraseña.Name = "TBContraseña";
            TBContraseña.PasswordChar = '*';
            TBContraseña.Size = new Size(318, 23);
            TBContraseña.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(BtoAceptar);
            groupBox1.Controls.Add(TBCorreo);
            groupBox1.Controls.Add(TBRepContraseña);
            groupBox1.Controls.Add(TBContraseña);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TBUsuario);
            groupBox1.Location = new Point(91, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(495, 319);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Resgistrase";
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.GREMLIN_registr;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Name = "Registro";
            Text = "Registro";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtoAceptar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TBUsuario;
        private TextBox TBCorreo;
        private TextBox TBRepContraseña;
        private TextBox TBContraseña;
        private GroupBox groupBox1;
    }
}