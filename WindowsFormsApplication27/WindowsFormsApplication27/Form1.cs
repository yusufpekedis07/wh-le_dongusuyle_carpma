using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int sayı;
            sayı = Convert.ToInt16(textBox1.Text);
            if (sayı < 10)
            {
                sayı++;
            }
            textBox1.Text = sayı.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayı;
            sayı = Convert.ToInt16(textBox1.Text);
            if (sayı > 0)
            {
                sayı--;
            }
            textBox1.Text = sayı.ToString();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            listBox1.Items.Clear();
            int y = 1;
            while ( y < 11)
            {
                listBox1.Items.Add(y + "*" + (textBox1.Text) + "=" + y * sayi);
                y++;
            }

        }
        }
    }



