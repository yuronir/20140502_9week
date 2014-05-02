using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Wave
{
    public partial class Form1 : Form
    {
        SoundPlayer sp;
        Boolean isPlaying = false;

        public Form1()
        {
            InitializeComponent();
            sp = new SoundPlayer(Properties.Resources.bell);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isPlaying == false)
            {
                sp.PlayLooping();
                isPlaying = true;
                button1.Text = "Stop";
            }
            else
            {
                sp.Stop();
                isPlaying = false;
                button1.Text = "Play";
            }

        }
    }
}
