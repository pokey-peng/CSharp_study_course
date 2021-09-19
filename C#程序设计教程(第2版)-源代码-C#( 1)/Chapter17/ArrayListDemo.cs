using System;using System.Collections;
namespace CSharpBook.Chapter17
{
    public class ArrayListDemo
    {
        public static void Main()
        {  //声明并创建ArrayList
            ArrayList list = new ArrayList();
            string str;
            try
            {
                Console.WriteLine("请输入成绩，空行结束");
                while ((str = Console.ReadLine()).Length > 0)
                    list.Add(Int32.Parse(str));
                int sum = 0, max = 0, min = 100;
                foreach (int score in list) //循环并统计结果
                {
                    sum += score;
                    if (max < score) max = score;
                    if (min > score) min = score;
                    Console.Write("{0} ", score);
                }
                Console.WriteLine("\n平均成绩：{0}，最高分：{1}，最低分：{2}", sum / list.Count, max, min);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
