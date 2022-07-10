using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework
{
    public partial class work16 : Form
    {
        public work16()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.EnableVisualStyles();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        bool a = false , b = false;
        int h, m, s;
        private void timer1_Tick(object sender, EventArgs e)
        {

            label3.Text = DateTime.Now.ToString("HH-mm-ss");

            if(b)
            {
                if(h == DateTime.Now.Hour)
                {
                    if(m == DateTime.Now.Minute)
                    {
                        if(s == DateTime.Now.Second)
                        {
                            a = true;
                            label3.BackColor = Color.Yellow;
                            label3.ForeColor = Color.Red;
                            button1.Enabled = true;
                        }
                    }
                }
            }

            if(a)
            {
                if (b)
                {
                    label3.BackColor = Color.Red;
                    label3.ForeColor = Color.Yellow;
                    b = !b;
                }
                else
                {
                    label3.BackColor = Color.Yellow;
                    label3.ForeColor = Color.Red;
                    b = !b;
                }            
                
            }
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool num1 = int.TryParse(textBox2.Text,out h);
            bool num2 = int.TryParse(textBox3.Text, out m);
            bool num3 = int.TryParse(textBox4.Text, out s);
            if (checkBox1.Checked && num1 && num2 && num3)
            {
                
                b = true;
              
            }
            else
            {
               
                checkBox1.Checked = false;
            }

           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            a = false;  b = false;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.Black;
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            checkBox1.Checked = false;
            button1.Enabled = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Enabled = true;
        }
    }
}
