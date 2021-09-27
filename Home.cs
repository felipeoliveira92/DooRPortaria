using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoorPortaria
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            picboxHome.ImageLocation = DoorPortaria.Properties.Settings.Default.foto;
        }

        private void buttonMoradores_Click(object sender, EventArgs e)
        {
            Form1 capture = new Form1();
            capture.ShowDialog();
        }
    }
}
