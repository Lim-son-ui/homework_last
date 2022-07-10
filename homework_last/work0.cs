using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using homework;


namespace homework
{
    public partial class work0 : Form
    {
        public work0()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            splitContainer2.Panel2.Controls.Clear();

            homework.work1 frm = new homework.work1();
            frm.Top = 0;
            frm.Left = 0;
            frm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(frm);

            frm.Show();
        }



        //public static extern int setParent(int hwchild, int hwnnew) { 
        //}

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();

            homework.work2 frm = new homework.work2();
            frm.Top = 0;
            frm.Left = 0;
            frm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(frm);

            frm.Show();

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();

            homework.work3 frm = new homework.work3();
            frm.Top = 0;
            frm.Left = 0;
            frm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(frm);

            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();

            homework.work4 frm = new homework.work4();
            frm.Top = 0;
            frm.Left = 0;
            frm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(frm);

            frm.Show();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();

            homework.work5 frm = new homework.work5();
            frm.Top = 0;
            frm.Left = 0;
            frm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(frm);

            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();

            homework.work6 frm = new homework.work6();
            frm.Top = 0;
            frm.Left = 0;
            frm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(frm);

            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();

            homework.work8 frm = new homework.work8();
            frm.Top = 0;
            frm.Left = 0;
            frm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(frm);

            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();

            homework.work9 frm = new homework.work9();
            frm.Top = 0;
            frm.Left = 0;
            frm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(frm);

            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();

            homework.work15 frm = new homework.work15();
            frm.Top = 0;
            frm.Left = 0;
            frm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(frm);

            frm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();

            homework.work16 frm = new homework.work16();
            frm.Top = 0;
            frm.Left = 0;
            frm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(frm);

            frm.Show();
        }
    }
}
