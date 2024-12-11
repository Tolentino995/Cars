namespace AutoV0._3
{
    partial class Ranking
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            VolverAlMenu = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(319, 266);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 1;
            label1.Text = "PUESTO 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(448, 194);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "PUESTO 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(581, 301);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 3;
            label3.Text = "PUESTO 3";
            // 
            // VolverAlMenu
            // 
            VolverAlMenu.BackColor = Color.Transparent;
            VolverAlMenu.FlatAppearance.BorderSize = 0;
            VolverAlMenu.FlatAppearance.MouseDownBackColor = Color.Transparent;
            VolverAlMenu.FlatAppearance.MouseOverBackColor = Color.Transparent;
            VolverAlMenu.FlatStyle = FlatStyle.Flat;
            VolverAlMenu.Image = Properties.Resources.Volver;
            VolverAlMenu.Location = new Point(12, 462);
            VolverAlMenu.Name = "VolverAlMenu";
            VolverAlMenu.Size = new Size(66, 61);
            VolverAlMenu.TabIndex = 12;
            VolverAlMenu.UseVisualStyleBackColor = false;
            VolverAlMenu.Click += VolverAlMenu_Click;
            // 
            // Ranking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.PuestosJugadores;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(871, 535);
            Controls.Add(VolverAlMenu);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Ranking";
            Text = "Ranking";
            Load += Ranking_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Button VolverAlMenu;
    }
}