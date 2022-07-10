using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//目前卡在想用另一個字串接最大最小
namespace homework
{
    public partial class work5 : Form
    {
        public work5()
        {
            InitializeComponent();

            textBox5.Text += $"\r\n{"姓名",-7}{"國文",6}{"英文",6}{"數學",6}{"總分",6}{"平均",6}{"最低",6}{"最高",6}{"",-5}";
        }



        parama para = new parama();


        void calcu()     //統一運算  總分  平均  最低   最高
        {
            double sum = 0;
            string[] course = new string[3] { "國文", "英文", "數學" };
            string split = "-------------------------------------------------------------------------";
            bool[] max_count = new bool[3] { false, false, false };
            bool[] min_count = new bool[3] { false, false, false };


            for (int i = 0; i < 3; i++)                     //目前為算單人 總分 平均  最低  最高
            {
                sum += para.score[para.stu_num, i];
                if (i == 0) para.min = para.max = para.score[para.stu_num, 0];

                else
                {
                    if (para.max < para.score[para.stu_num, i])
                    {       //找出最大
                        para.max = para.score[para.stu_num, i];
                        max_count[i] = true;
                        for (int j = 0; j < i; j++)   //把先前認定的極值刪去
                        {
                            max_count[j] = false;
                        }
                    }
                    if (para.min > para.score[para.stu_num, i])
                    {       //找出最小
                        para.min = para.score[para.stu_num, i];
                        min_count[i] = true;
                        for (int j = 0; j < i; j++)   //把先前認定的極值刪去
                        {
                            min_count[j] = false;
                        }
                    }
                }
            }

            for (int j = 0; j < 3; j++)       //根據先前找出的極值 比對出相同的數字
            {
                if (para.max == para.score[para.stu_num, j]) max_count[j] = true;
                if (para.min == para.score[para.stu_num, j]) min_count[j] = true;
            }


            para.sum = sum;
            para.avg = sum / 3;
            //MessageBox.Show("先"+para.avg);
            para.avg = Math.Round(para.avg, 1, MidpointRounding.AwayFromZero);
            // MessageBox.Show("後" + para.avg);

            textBox5.Text += $"\r\n{para.stu_num + 1,-7}{para.score[para.stu_num, 0],10}{para.score[para.stu_num, 1],8}{para.score[para.stu_num, 2],8}" +
                            $"{para.sum,8}{para.avg,8}";

            string[] str = new string[2] { "", "" };


            int sum_ma = 0, sum_mi = 0;
            int si = 0, sj = 0;

            for (int i = 0; i < 3; i++)
            {
                if (min_count[i])
                {
                    sum_mi++;
                    si = i;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (max_count[i])
                {
                    sum_ma++;
                    sj = i;
                }
            }

            if (sum_mi == 1 && sum_ma == 1) //當只有最大最小
            {
                textBox5.Text += $"{course[si],5}{para.min,3}{course[sj],4}{para.max,3}";
                textBox5.Text += $"\r\n{split,5}";

            }

            if (sum_mi == 3)   //當三個同分
            {
                textBox5.Text += $"{course[0],5}{para.min,3}{course[0],4}{para.max,3}" +
                    $"\r\n{course[1],54}{para.min,3}{course[1],4}{para.max,3}" +
                    $"\r\n{course[2],54}{para.min,3}{course[2],4}{para.max,3}";

                textBox5.Text += $"\r\n{split,5}";
            }

            if (sum_mi == 2)   //當最小有兩個  最大只會存到str[o]
            {
                int count = 0;

                for (int i = 0; i < 3; i++)           //先找出最小的兩行
                {

                    if (min_count[i] && count != 0)
                    {
                        str[1] += $"\r\n{course[i],54}{para.min,3}";
                    }

                    else if (min_count[i] && count == 0)
                    {
                        str[0] += $"{course[i],5}{para.min,3}";
                        count = 1;
                    }


                }


                for (int i = 0; i < 3; i++)         //補上最大值
                {
                    if (max_count[i])
                    {
                        str[0] += $"{course[i],4}{para.max,3}";
                    }
                }


                textBox5.Text += str[0] + str[1];
                textBox5.Text += $"\r\n{split,5}";
            }

            str[0] = null;
            str[1] = null;

            if (sum_mi == 1 && sum_ma > 1) //當最小只有一個  最大有兩個
            {
                for (int i = 0; i < 3; i++)   //找出最大的一行
                {
                    if (min_count[i])
                    {
                        str[0] += $"{course[i],5}{para.min,3}";
                    }
                }

                int count = 0;


                for (int i = 0; i < 3; i++)           //先找出最大的兩行
                {

                    if (max_count[i] && count != 0)
                    {
                        str[1] += $"\r\n{course[i],63}{para.max,3}";
                    }

                    else if (max_count[i] && count == 0)
                    {
                        str[0] += $"{course[i],4}{para.max,3}";
                        count = 1;
                    }


                }

                textBox5.Text += str[0] + str[1];
                textBox5.Text += $"\r\n{split,5}";
            }



        }

        void print()        //隨機生成的列表  所以textbox不會輸入
        {

            textBox5.Text += $"\r\n{para.stu_num + 1,-7}{para.score[para.stu_num, 0],10}{para.score[para.stu_num, 1],8}{para.score[para.stu_num, 2],8}" +
                $"{para.sum,8}{para.avg,8}{para.min,8}{para.max,8}{" ",-5}";
        }

        private void button1_Click(object sender, EventArgs e)      //插入字串所加入的新值
        {
            bool num1 = int.TryParse(textBox2.Text, out para.score[para.stu_num, 0]);//國文
            bool num2 = int.TryParse(textBox3.Text, out para.score[para.stu_num, 1]); //英文
            bool num3 = int.TryParse(textBox4.Text, out para.score[para.stu_num, 2]); //數學

            bool str = false;
            str = string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text)
                || string.IsNullOrEmpty(textBox4.Text);



            if (str)
            {
                MessageBox.Show("請重新輸入");

            }
            if (num1 && num2 && num3 && !str)
            {
                calcu();

                para.stu_num++;
            }

            clear();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)          //隨機加入1人
        {       //姓名  國文分數   英文分數   數學分數  各科名字 

            int[] score = new int[3];
            Random rd = new Random();
            //1.名字根據  排序 顯示出數字  2.隨機出三科分數   3.透過calcu算出剩餘


            for (int j = 0; j < 3; j++) //放入隨機參數
            {

                int rd_num = rd.Next(0, 100);
                para.score[para.stu_num, j] = rd_num;

            }

            calcu();

            para.stu_num++;

            clear();
        }



        private void button5_Click(object sender, EventArgs e)          //隨機加入20
        {
            int rd_num;
            Random rd = new Random();
            for (int i = 0; i < 20; i++)
            {
                //int[] score = new int[3];

                //1.名字根據  排序 顯示出數字  2.隨機出三科分數   3.透過calcu算出剩餘


                for (int j = 0; j < 3; j++) //放入隨機參數
                {
                    rd_num = rd.Next(0, 100);
                    para.score[para.stu_num, j] = rd_num;
                }

                calcu();
                //print();

                para.stu_num++;
            }

            clear();
        }

        private void button3_Click(object sender, EventArgs e)      //統計各科
        {
            textBox6.Text = null;
            double[] a_sum = new double[3];           //國英數的總分
            double[] a_avg = new double[3];           //國英數的平均
            int[] a_max = new int[3];           //國英數的最大
            int[] a_min = new int[3];           //國英數的最低
            string[] statis = new string[4] { "總分", "平均", "最高", "最低" };
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button5.Enabled = false;
            double sum;
            //單一科目的統計
            for (int i = 0; i < 3; i++)
            {
                sum = 0;
                for (int j = 0; j < para.stu_num; j++)           //第零科為國文 英文 數學 每次不同學生
                {

                    sum += para.score[j, i];
                    if (j == 0) para.min = para.max = para.score[j, i];

                    else
                    {
                        if (para.max < para.score[j, i]) para.max = para.score[j, i];
                        if (para.min > para.score[j, i]) para.min = para.score[j, i];
                    }



                }

                a_sum[i] = sum;
                para.avg = sum / para.stu_num;
                a_avg[i] = Math.Round(para.avg, 1, MidpointRounding.AwayFromZero);
                a_max[i] = para.max;
                a_min[i] = para.min;

            }


            textBox6.Text += $"\r\n{statis[0],-5}{a_sum[0],6}{a_sum[1],8}{a_sum[2],8}";
            textBox6.Text += $"\r\n{statis[1],-5}{a_avg[0],6}{a_avg[1],8}{a_avg[2],8}";
            textBox6.Text += $"\r\n{statis[2],-5}{a_max[0],6}{a_max[1],8}{a_max[2],8}";
            textBox6.Text += $"\r\n{statis[3],-5}{a_min[0],6}{a_min[1],8}{a_min[2],8}";
            clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            para.stu_num = 0;
            textBox5.Text = null;
            textBox6.Text = null;
            textBox5.Text += $"\r\n{"姓名",-7}{"國文",6}{"英文",6}{"數學",6}{"總分",6}{"平均",6}{"最低",6}{"最高",6}{"",-5}";

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button5.Enabled = true;

            clear();
        }

        void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
