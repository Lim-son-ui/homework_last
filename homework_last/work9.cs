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
    public partial class work9 : Form
    {
        public work9()
        {
            InitializeComponent();
        }

        bool flag_odd_even = false;

        void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            txt_in.Clear();
        }

        private void button1_Click(object sender, EventArgs e)      //判斷輸入為奇數或偶數
        {

            int a;
            bool num = int.TryParse(txt_in.Text, out a);

            if (num)
            {

                label1.Text = null;

                if ((a % 2) == 0)
                {
                    label1.Text = "輸入為偶數";
                }
                else
                {
                    label1.Text = "輸入為奇數";
                }


            }

            else
            {
                MessageBox.Show("請重新輸入");
            }

            clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)          //判斷陣列內最大最小值
        {
            int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };

            int max = 0, i, min = 1000;
            label1.Text = null;

            for (i = 0; i < arr0711.Length; i++)
            {
                if (arr0711[i] > max)
                {
                    max = arr0711[i];
                }
                if (arr0711[i] < min)
                {
                    min = arr0711[i];
                }
            }
            label1.Text = "int陣列arr0711[1,5,6,8,7,97,54,887,65,578]"
                + "\r\n最大值為:" + max.ToString()
                + "\r\n最小值為:" + min.ToString();

        }

        private void button3_Click(object sender, EventArgs e)      //判斷奇偶數 數量
        {
            int[] arr0711 = new int[] { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int sum1 = 0, sum2 = 0;
            label1.Text = null;

            for (int i = 0; i < arr0711.Length; i++)
            {
                if (arr0711[i] % 2 == 1)
                {
                    sum1++;
                }

                else
                {
                    sum2++;
                }
            }

            label1.Text = "int陣列arr0711[1,5,6,8,7,97,54,887,65,578]"
                + "\r\n奇數共:" + sum1.ToString()
                + "\r\n偶數共:" + sum2.ToString();
        }

        private void button4_Click(object sender, EventArgs e)  //統計名字的長度
        {
            string[] arr0711_str = new string[] { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker" };
            int flag = 0, max = 0;
            label1.Text = null;

            for (int i = 0; i < arr0711_str.Length; i++)
            {
                if (flag == 0)
                {
                    max = arr0711_str[0].Length;
                    flag++;
                }

                else
                {
                    if (max < arr0711_str[i].Length)
                    {
                        max = i;
                    }
                    label1.Text = "陣列arr0711[]str[ 迪克蕭 J40 Candy Cindy  Coconut Motherfacker]"
                                    + "\r\n最長的名字:" + arr0711_str[max];
                }


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] arr0711_str = new string[] { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker" };
            int count = 0;
            label1.Text = null;



            for (int i = 0; i < arr0711_str.Length; i++)
            {

                if (arr0711_str[i].Contains("c") || arr0711_str[i].Contains("C"))
                {
                    count++;
                    continue;
                }

            }

            label1.Text = "陣列arr0711[]str[ 迪克蕭 J40 Candy Cindy  Coconut Motherfacker]"
                                    + "\r\n有C及C的名字共:" + count + "個";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string[] two_dimen = new string[10];
            label1.Text = null;

            for (int i = 0; i < 10; i++)
            {
                if (i == 0 || i == 9)
                {
                    two_dimen[i] = "1111111111";
                }
                else
                {
                    two_dimen[i] = "1000000001";
                }
            }

            for (int i = 0; i < 10; i++)
            {
                label1.Text += "\r\n" + two_dimen[i];
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string[] two_dimen = new string[10];
            label1.Text = null;

            for (int i = 0; i < 10; i++)
            {
                if (i == 0 || i == 9)
                {
                    two_dimen[i] = "0000000000";
                }
                else
                {
                    two_dimen[i] = "0111111110";
                }
            }

            for (int i = 0; i < 10; i++)
            {
                label1.Text += "\r\n" + two_dimen[i];
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string[] two_dimen = new string[10];
            label1.Text = null;

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    two_dimen[i] = "1010101010";
                }
                else
                {
                    two_dimen[i] = "0101010101";
                }
            }

            for (int i = 0; i < 10; i++)
            {
                label1.Text += "\r\n" + two_dimen[i];
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int n1 = 100, n2 = 200;
            label1.Text = null;
            label1.Text += "\r\n換位前 n1 =" + n1 + ",n2 =" + n2;
            swap(ref n1, ref n2);
            label1.Text += "\r\n換位後 n1 =" + n1 + ",n2 =" + n2;
        }

        void swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            int[] arr0711 = new int[] { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int sum = 0;
            label1.Text = null;

            for (int i = 0; i < arr0711.Length; i++)
            {
                sum += arr0711[i];
            }

            label1.Text = "int陣列arr0711[1,5,6,8,7,97,54,887,65,578]"
                            + "\r\n加總為:" + sum;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            int[] arr0711 = new int[] { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int min = arr0711[0];
            label1.Text = null;

            for (int i = 1; i < arr0711.Length; i++)
            {
                if (min > arr0711[i]) min = arr0711[i];

            }

            label1.Text = "int陣列arr0711[1,5,6,8,7,97,54,887,65,578]"
                            + "\r\n最小為:" + min;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int[] arr0711 = new int[] { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int max = arr0711[0];
            label1.Text = null;

            for (int i = 1; i < arr0711.Length; i++)
            {
                if (max < arr0711[i]) max = arr0711[i];

            }

            label1.Text = "int陣列arr0711[1,5,6,8,7,97,54,887,65,578]"
                            + "\r\n最大為:" + max;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int num;
            bool num_check = int.TryParse(textBox1.Text, out num);
            label1.Text = null;

            if (num_check)
            {
                for (int i = 1; i <= num; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (j == 0) label1.Text += "\r\n";
                        label1.Text += "*";
                    }
                    label1.Text += "\r\n";
                }

            }

            else
            {
                MessageBox.Show("請重新輸入");
            }

            clear();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void form1_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            string[] str = new string[20];
            int i = 0, hund = 100;
            label1.Text = null;

            do
            {
                str[i] = (hund % 2).ToString();
                hund /= 2;
                i++;
            } while (hund > 0);

            for (int j = (i - 1); j >= 0; j--)
            {
                label1.Text += str[j];
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            label1.Text = null;
            label1.Text += "九九乘法表";

            for (int i = 1; i < 10; i++)
            {
                for (int j = 2; j < 10; j++)
                {
                    if (j == 2) label1.Text += "\r\n" + j + "x" + i + "=" + j * i + "|  ";
                    else
                    {
                        label1.Text += "" + j + "x" + i + "=" + j * i + "    ";
                    }

                }


            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            label1.Text = null;

            label1.Text += "本次樂透的開獎號碼為\r\n";

            for (int i = 0; i < 6; i++)
            {
                int rd_num = rd.Next(1, 50);
                label1.Text += "  " + rd_num;
            }
        }


        void from_to(int flag)
        {
            int from, to, step;

            bool num1 = int.TryParse(textBox2.Text, out from);
            bool num2 = int.TryParse(textBox3.Text, out to);
            bool num3 = int.TryParse(textBox4.Text, out step);
            bool check_wrong = false;
            int sum = 0, i = 0;

            label1.Text = null;

            if (from + step > to || from > to)
            {
                check_wrong = true;
                MessageBox.Show("不符輸入規定");
            }

            if (num1 && num2 && num3 && !check_wrong)
            {

                if (flag == 0)
                {
                    for (i = from; i <= to; i = i + step)
                    {
                        sum += i;
                    }
                }

                else if (flag == 1)
                {
                    i = from;
                    while (i <= to)
                    {
                        sum += i;
                        i = i + step;
                    }
                }

                else if (flag == 2)
                {
                    i = from;
                    do
                    {
                        sum += i;
                        i = i + step;
                    } while (i <= to);
                }


                label1.Text += "\r\n" + textBox2.Text + "到" + textBox3.Text + "相隔" + (to - i + step) +
                    "\r\n" + "加總為" + sum;

            }

            else
            {
                MessageBox.Show("請正確輸入");
            }

            clear();
        }
        private void button17_Click(object sender, EventArgs e)     //使用for
        {   //  輸出 from  to   from到to透過step加總的數字   最後加step會差幾個到to
            from_to(0);

        }

        private void button18_Click(object sender, EventArgs e)         //while跑from to
        {
            from_to(1);
        }

        private void button19_Click(object sender, EventArgs e)         //do ...while跑from to
        {
            from_to(2);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            label1.Text = null;
            clear();
        }
    }
}
