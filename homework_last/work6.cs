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
    public partial class work6 : Form
    {
        public work6()
        {
            InitializeComponent();

            textBox7.Text += $"{"姓名",-5}{"國文",6}{"英文",6}{"數學",6}{"總分",6}{"平均",6}{"最低",6}{"最高",6}{"",-5}";
        }

        struct student
        {
            public string name;
            public int chinese, english, math;
            public int[] min;
            public int[] max;
            public string[] min_course;
            public string[] max_course;
            public double sum, avg;

        }
        student st;

        List<student> studen = new List<student>();
        bool correct_input = false, have_num = false;

        void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        void showstudent()
        {

            textBox7.Text = null;
            textBox7.Text += $"{"姓名",-5}{"國文",6}{"英文",6}{"數學",6}{"總分",6}{"平均",6}{"最低",6}{"最高",6}{"",-5}";

            foreach (student st in studen)
            {
                textBox7.Text += $"\r\n{st.name,-7}{st.chinese,8}{st.english,8}{st.math,8}" +
                    $"{st.sum,8}{st.avg,8}{st.min_course[0],4}{st.min[0],3}{st.max_course[0],4}{st.max[0],3}{"",-5}";


                if (st.min[1] != 0 && st.max[1] == 0) { textBox7.Text += $"\r\n{st.min_course[1],51}{st.min[1],3}{"",7}{"",-5}"; }
                if (st.min[1] == 0 && st.max[1] != 0) { textBox7.Text += $"\r\n{"",56}{st.max_course[1],4}{st.max[0],3}{"",-5}"; }
                if (st.min[1] != 0 && st.max[1] != 0)
                {
                    textBox7.Text += $"\r\n{st.min_course[1],51}{st.min[1],3}{st.max_course[1],4}{st.max[1],3}{"",-5}" +
                        $"\r\n{st.min_course[2],51}{st.min[2],3}{st.max_course[2],4}{st.max[2],3}{"",-5}";
                }

            }

        }

        void calcu()
        {
            st.name = null;
            st.name = textBox1.Text;
            bool num1 = int.TryParse(textBox2.Text, out st.chinese);
            bool num2 = int.TryParse(textBox3.Text, out st.english);
            bool num3 = int.TryParse(textBox4.Text, out st.math);

            st.sum = st.chinese + st.english + st.math;
            st.avg = st.sum / 3;
            st.avg = Math.Round(st.avg, 1, MidpointRounding.AwayFromZero);
            st.max = new int[3];
            st.min = new int[3];
            st.max_course = new string[3];
            st.min_course = new string[3];


            if (!string.IsNullOrEmpty(textBox1.Text) && num1 && num2 && num3)
            {
                correct_input = true;

                if (st.chinese == st.english && st.english == st.math)  //當三科分數相等
                {

                    st.min_course[0] = "國文:"; st.min_course[1] = "英文:"; st.min_course[2] = "數學:";
                    st.max_course[0] = "國文:"; st.max_course[1] = "英文:"; st.max_course[2] = "數學:";
                    st.min[0] = st.chinese; st.min[1] = st.english; st.min[2] = st.math;
                    st.max[0] = st.chinese; st.max[1] = st.english; st.max[2] = st.math;
                }

                else if (st.chinese < st.english && st.english < st.math)
                {
                    st.min_course[0] = "國文:"; st.max_course[0] = "數學:";
                    st.min[0] = st.chinese; st.max[0] = st.math;
                }
                else if (st.chinese == st.english && st.chinese < st.math)
                {
                    st.min_course[0] = "國文:"; st.max_course[0] = "數學:"; st.min_course[1] = "英文:";
                    st.min[0] = st.chinese; st.max[0] = st.math; st.min[1] = st.english;
                }

                else if (st.chinese < st.math && st.math < st.english)
                {
                    st.min_course[0] = "國文:"; st.max_course[0] = "英文:";
                    st.min[0] = st.chinese; st.max[0] = st.english;
                }
                else if (st.chinese < st.english && st.chinese == st.math)
                {
                    st.min_course[0] = "國文:"; st.max_course[0] = "英文:"; st.min_course[1] = "數學:";
                    st.min[0] = st.chinese; st.max[0] = st.english; st.min[1] = st.math;
                }
                else if (st.chinese < st.english && st.english == st.math)
                {
                    st.min_course[0] = "國文:"; st.max_course[0] = "英文:"; st.max_course[1] = "數學:";
                    st.min[0] = st.chinese; st.max[0] = st.english; st.max[1] = st.math;
                }

                else if (st.english < st.chinese && st.chinese < st.math)
                {
                    st.min_course[0] = "英文:"; st.max_course[0] = "數學:";
                    st.min[0] = st.english; st.max[0] = st.math;
                }

                else if (st.english < st.math && st.math < st.chinese)
                {
                    st.min_course[0] = "英文:"; st.max_course[0] = "國文:";
                    st.min[0] = st.english; st.max[0] = st.chinese;
                }
                else if (st.english < st.chinese && st.english == st.math)
                {
                    st.min_course[0] = "英文:"; st.max_course[0] = "國文:"; st.min_course[1] = "數學:";
                    st.min[0] = st.english; st.max[0] = st.chinese; st.min[1] = st.math;
                }
                else if (st.english < st.chinese && st.chinese == st.math)
                {
                    st.min_course[0] = "英文:"; st.max_course[0] = "國文:"; st.max_course[1] = "數學:";
                    st.min[0] = st.english; st.max[0] = st.chinese; st.max[1] = st.math;
                }

                else if (st.math < st.chinese && st.chinese < st.english)
                {
                    st.min_course[0] = "數學:"; st.max_course[0] = "英文:";
                    st.min[0] = st.math; st.max[0] = st.english;
                }
                else if (st.math < st.english && st.english < st.chinese)
                {
                    st.min_course[0] = "數學:"; st.max_course[0] = "國文:";
                    st.min[0] = st.math; st.max[0] = st.chinese;
                }
                else if (st.math < st.chinese && st.chinese == st.english)
                {
                    st.min_course[0] = "數學:"; st.max_course[0] = "國文:"; st.max_course[1] = "英文:";
                    st.min[0] = st.math; st.max[0] = st.chinese; st.max[1] = st.english;
                }
            }


            else
            {
                correct_input = false;
                MessageBox.Show("請正確輸入");
            }


        }

        private void button6_Click(object sender, EventArgs e)      //各科目統計 後面再做
        {
            double chinese_sum = 0, english_sum = 0, math_sum = 0;
            double chinese_avg = 0, english_avg = 0, math_avg = 0;
            int chinese_min = 0, english_min = 0, math_min = 0;
            int chinese_max = 0, english_max = 0, math_max = 0;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button6.Enabled = false;

            for (int i = 0; i < studen.Count; i++)
            {
                //算各科總分
                chinese_sum += studen[i].chinese;
                english_sum += studen[i].english;
                math_sum += studen[i].math;

                if (i == 0)
                {
                    chinese_min = chinese_max = studen[i].chinese;
                    english_min = english_max = studen[i].english;
                    math_min = math_max = studen[i].math;
                }

                else        //找各科極值
                {
                    if (chinese_max < studen[i].chinese) chinese_max = studen[i].chinese;
                    if (chinese_min > studen[i].chinese) chinese_min = studen[i].chinese;
                    if (english_max < studen[i].english) english_max = studen[i].english;
                    if (english_min > studen[i].english) english_min = studen[i].english;
                    if (math_max < studen[i].math) math_max = studen[i].math;
                    if (math_min > studen[i].math) math_min = studen[i].math;

                }

            }
            chinese_avg = chinese_sum / studen.Count;           //算各科平均  四捨五入小數第一位
            chinese_avg = Math.Round(chinese_avg, 1, MidpointRounding.AwayFromZero);
            english_avg = english_sum / studen.Count;
            english_avg = Math.Round(english_avg, 1, MidpointRounding.AwayFromZero);
            math_avg = math_sum / studen.Count;
            math_avg = Math.Round(math_avg, 1, MidpointRounding.AwayFromZero);


            textBox8.Text += $"\r\n{"總分",-5}{chinese_sum,6}{english_sum,6}{math_sum,8}";
            textBox8.Text += $"\r\n{"平均",-5}{chinese_avg,6}{english_avg,6}{math_avg,8}";
            textBox8.Text += $"\r\n{"最高",-5}{chinese_max,6}{english_max,6}{math_max,8}";
            textBox8.Text += $"\r\n{"最低",-5}{chinese_min,6}{english_min,6}{math_min,8}";

            clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            calcu();
            if (correct_input)
            {
                studen.Add(st);
                showstudent();
            }
            clear();
        }


        private void button2_Click(object sender, EventArgs e)
        {

            calcu();
            if (correct_input)
            {
                studen.Insert(0, st);
                showstudent();
            }
            clear();
        }

        private void button3_Click(object sender, EventArgs e)      //清除上表的學生
        {
            if (studen.Count > 0) have_num = true;
            if (!have_num)
            {
                MessageBox.Show("內容為空無法移除");
            }

            if (have_num)
            {
                studen.RemoveAt(0);
                showstudent();
                have_num = false;
            }
            clear();
        }

        private void button4_Click(object sender, EventArgs e)      //全部清除
        {

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button6.Enabled = true;
            if (studen.Count > 0) have_num = true;
            if (!have_num)
            {
                MessageBox.Show("內容為空無法清除");
            }

            if (have_num)
            {
                studen.Clear();
                showstudent();
                textBox8.Text = null;
                have_num = false;
            }
            clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)          //找尋特定國文分數範圍的學生
        {
            int from, to;
            bool num1 = int.TryParse(textBox5.Text, out from);
            bool num2 = int.TryParse(textBox6.Text, out to);
            int i = 0;

            textBox7.Text = null;
            textBox7.Text += $"{"姓名",-5}{"國文",6}{"英文",6}{"數學",6}{"總分",6}{"平均",6}{"最低",6}{"最高",6}{"",-5}";


            if (studen.Count > 0) have_num = true;
            if (!have_num)
            {
                MessageBox.Show("內容為空無法移除");
            }

            if (have_num && from <= to)
            {
                foreach (student st in studen)
                {
                    if (studen[i].chinese >= from && studen[i].chinese <= to)
                    {
                        textBox7.Text += $"\r\n{st.name,-7}{st.chinese,8}{st.english,8}{st.math,8}" +
                       $"{st.sum,8}{st.avg,8}{st.min_course[0],4}{st.min[0],3}{st.max_course[0],4}{st.max[0],3}{"",-5}";


                        if (st.min[1] != 0 && st.max[1] == 0) { textBox7.Text += $"\r\n{st.min_course[1],51}{st.min[1],3}{"",7}{"",-5}"; }
                        if (st.min[1] == 0 && st.max[1] != 0) { textBox7.Text += $"\r\n{"",56}{st.max_course[1],4}{st.max[0],3}{"",-5}"; }
                        if (st.min[1] != 0 && st.max[1] != 0)
                        {
                            textBox7.Text += $"\r\n{st.min_course[1],51}{st.min[1],3}{st.max_course[1],4}{st.max[1],3}{"",-5}" +
                                $"\r\n{st.min_course[2],51}{st.min[2],3}{st.max_course[2],4}{st.max[2],3}{"",-5}";
                        }
                    }

                    i++;
                }

                have_num = false;
            }

            if (from > to)
            {
                showstudent();
                MessageBox.Show("左邊為小右邊為大");
            }


            clear();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
