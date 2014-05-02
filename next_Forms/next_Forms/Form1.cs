using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace next_Forms
{
    public partial class Form1 : Form
    {
        int cnt = 0;

        public Form1()
        {
            InitializeComponent();
            textBox1.KeyDown += new KeyEventHandler(my_key_handler);
        }
        
        private void my_key_handler(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextboxChange();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextboxChange();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "입력하세욧.";
        }

        private void TextboxChange()
        {
            string addMsg = "";

            if (radioButton1.Checked)
            {
                addMsg += "차용빈 : ";
                radioButton2.Select();
            }
            else if (radioButton2.Checked)
            {
                addMsg += "심심이 : ";
                radioButton1.Select();
            }

            addMsg += textBox1.Text;

            if (textBox2.Text == "입력하세욧.")
            {
                textBox2.Text = addMsg + "\r\n";
            }
            else
            {
                textBox2.Text = textBox2.Text + addMsg + "\r\n";
            }
            textBox1.Text = "";

            cnt++;

            if (cnt == 10)
            {
                button1.Text = "아프다;";
            }
            else if (cnt == 20)
            {
                button1.Text = "그만해 ㅡㅡ";
            }
            else if (cnt == 30)
            {
                button1.Text = "ㅠㅠㅠㅠㅠ";
            }
        }
    }
}
