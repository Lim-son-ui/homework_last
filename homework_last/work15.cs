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
    public partial class work15 : Form
    {

        public int flag = 0, rd_num, rb_num;
        Random rd = new Random();

        public work15()
        {
            InitializeComponent();
            rd_num = rd.Next(1, 99);
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            rb_num = rd.Next(1, 99);
            work15out form2 = new work15out(rb_num);
            form2.Show();
            flag = 1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flag == 0) MessageBox.Show(rd_num.ToString());
            else MessageBox.Show(rb_num.ToString());

        }
    }

}
