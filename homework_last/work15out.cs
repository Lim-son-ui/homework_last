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
    public partial class work15out : Form
    {
        public int max = 99, min = 1;
        public int rb_num;

        public work15out()
        {
            InitializeComponent();

        }

        public work15out(int rand)
        {
            InitializeComponent();
            rb_num = rand;
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int guess = int.Parse(textBox1.Text);
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(work15))
                {

                    if (guess > max || guess < min) MessageBox.Show("請重新輸入");
                    else if (guess != rb_num)
                    {
                        if (guess > rb_num) max = guess;
                        else if (guess < rb_num) min = guess;
                        ((work15)form).label1.Text = "最大為" + max + "最小為" + min;

                    }

                    else { ((work15)form).label1.Text = "恭喜答對 答案為" + rb_num; }

                }
            }


        }


    }
}
