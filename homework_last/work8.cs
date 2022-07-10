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
    public partial class work8 : Form
    {
        public work8()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            double sum = 0, a = 0, b = 0;

            bool isNum1 = double.TryParse(textBox1.Text, out a);
            bool isNum2 = double.TryParse(textBox2.Text, out b);

            if (isNum1 && isNum2)
            {
                sum = a + b;
                textBox3.Text = sum.ToString();
            }
            //sum = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text);

            else
            {
                MessageBox.Show("輸入錯誤");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sum = 0, a = 0, b = 0;
            bool isNum1 = double.TryParse(textBox1.Text, out a);
            bool isNum2 = double.TryParse(textBox2.Text, out b);

            if (isNum1 && isNum2)
            {
                sum = a - b;
                textBox3.Text = sum.ToString();
            }

            else
            {
                MessageBox.Show("輸入錯誤");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sum = 0, a = 0, b = 0;
            bool isNum1 = double.TryParse(textBox1.Text, out a);
            bool isNum2 = double.TryParse(textBox2.Text, out b);

            if (isNum1 && isNum2)
            {
                sum = a * b;
                textBox3.Text = sum.ToString();
            }

            else
            {
                MessageBox.Show("輸入錯誤");
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sum = 0, a = 0, b = 0;
            bool isNum1 = double.TryParse(textBox1.Text, out a);
            bool isNum2 = double.TryParse(textBox2.Text, out b);

            if (isNum1 && isNum2)
            {
                if (b == 0) MessageBox.Show("分母不能為零");
                else
                {
                    sum = a / b;
                    sum = Math.Round(sum, 1, MidpointRounding.AwayFromZero);
                    textBox3.Text = sum.ToString();
                }

            }

            else
            {
                MessageBox.Show("輸入錯誤");
            }


        }
    }
}
