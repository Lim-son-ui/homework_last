using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    public class parama
    {
        public int[,] score = new int[100, 3];           //儲存每個學生的分數
        public int stu_num = 0;                         //記錄第幾位學生
        public double sum;                                 //單一人分數的總和
        public int min;                                 //單人的最小成績
        public int max;                                 //單人的最大成績
        public double avg;                              //單人的平均成績
    }

}
