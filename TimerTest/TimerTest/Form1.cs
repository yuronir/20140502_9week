using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerTest
{
    public partial class Form1 : Form
    {
        int n;
        Boolean isTimering = false;

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 500;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            n++;
            label1.Text = n + "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isTimering == false) {
                timer1.Enabled = true;
                isTimering = true;
                button1.Text = "일시정지~";
            }
            else
            {
                timer1.Enabled = false;
                isTimering = false;
                label1.Text += " (Paused)";
                button1.Text = "다시 시작!";
            }
        }
    }
}
