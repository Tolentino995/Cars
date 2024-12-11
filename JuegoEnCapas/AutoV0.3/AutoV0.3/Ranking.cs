using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoV0._3
{
    public partial class Ranking : Form
    {
        public Ranking()
        {
            InitializeComponent();
        }

        private void Ranking_Load(object sender, EventArgs e)
        {
            //pictureBox1.Image = Image.FromFile(@"C:\Users\antho\Downloads\Autos encontra del usuaruio y poder.gif");    
            //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void VolverAlMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            EleccionDeAutos NuevaVentana = new EleccionDeAutos();
            NuevaVentana.Show();
        }
    }
}
