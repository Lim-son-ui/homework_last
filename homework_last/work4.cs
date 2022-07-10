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

    public partial class work4 : Form
    {
        public work4()
        {
            InitializeComponent();
        }

        struct Stati        //陣列結構 儲存同一學生輸入成績
        {
            public string[] stu_grade;
        }
        Stati st;          //無須實作new出一個
        int[] score = new int[3];
        bool flag_prt = false, flag_stati = false;


        void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
        private void button1_Click(object sender, EventArgs e)      //儲存輸入資料
        {
            st.stu_grade = new string[4];

            bool num1 = int.TryParse(textBox2.Text, out score[0]);
            bool num2 = int.TryParse(textBox3.Text, out score[1]);
            bool num3 = int.TryParse(textBox4.Text, out score[2]);

            if (!string.IsNullOrEmpty(textBox1.Text) && num1 && num2 && num3)
            {
                st.stu_grade[0] = textBox1.Text;
                st.stu_grade[1] = textBox2.Text;
                st.stu_grade[2] = textBox3.Text;
                st.stu_grade[3] = textBox4.Text;
                flag_prt = true;
            }
            else
            {
                DialogResult result = MessageBox.Show("輸入格式錯誤!!", "Warning",
                    MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }


        }

        private void button2_Click(object sender, EventArgs e)  //顯示儲存內容
        {

            if (flag_prt)
            {
                textBox6.Text = "姓名:" + st.stu_grade[0] + "\r\n" +
                                "國文:" + st.stu_grade[1] + "\r\n" +
                                "英文:" + st.stu_grade[2] + "\r\n" +
                                "數學:" + st.stu_grade[3] + "\r\n";
                flag_prt = false;
                flag_stati = true;

            }
            else
            {
                MessageBox.Show("操作錯誤");
            }

            clear();
        }

        private void button3_Click(object sender, EventArgs e)  //最高分最低分
        {

            int max = 0, min = 0;

            bool[] max_count = new bool[3] { false, false, false };
            bool[] min_count = new bool[3] { false, false, false };

            string[] course = new string[3] { "國文", "英文", "數學" };


            if (flag_stati)
            {
                flag_stati = !flag_stati;
                for (int j = 0; j < 3; j++)      //先確定出一組最大最小
                {
                    if (j == 0) max = min = score[j];
                    else
                    {
                        if (max < score[j])
                        {
                            max = score[j];
                            max_count[j] = true;
                            for (int i = 0; i < j; i++)   //把先前認定的極值刪去
                            {
                                max_count[i] = false;
                            }

                        }
                        if (min > score[j])
                        {
                            min = score[j];
                            min_count[j] = true;
                            for (int i = 0; i < j; i++)   //把先前認定的極值刪去
                            {
                                min_count[i] = false;
                            }
                        }
                    }
                }

                for (int j = 0; j < 3; j++)       //根據先前找出的極值 比對出相同的數字
                {
                    if (max == score[j]) max_count[j] = true;
                    if (min == score[j]) min_count[j] = true;
                }

                textBox7.Text = null;       //清空先前的值

                bool flag_ma = false, flag_mi = false;
                for (int i = 0; i < 3; i++)
                {

                    if (flag_ma && max_count[i])
                    {
                        textBox7.Text += "\t" + course[i] + ":" + max + "\r\n";
                    }

                    else if (!flag_ma)
                    {
                        textBox7.Text += "最高科目成績為:\r\n";
                        if (max_count[i]) textBox7.Text += "\t" + course[i] + ":" + max + "\r\n";

                        flag_ma = true;
                    }

                }

                for (int i = 0; i < 3; i++)
                {
                    if (flag_mi && min_count[i])
                    {
                        textBox7.Text += "\t" + course[i] + ":" + min + "\r\n";
                    }

                    else if (!flag_mi)
                    {
                        textBox7.Text += "最低科目成績為:\r\n";
                        if (min_count[i]) textBox7.Text += "\t" + course[i] + ":" + min + "\r\n";
                        flag_mi = true;
                    }


                }

            }

            else
            {
                MessageBox.Show("操作錯誤");
            }

            clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }

    //class 
}
