using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int k, m=2, i;
            //方法1：利用for循环和break语句
            k = (int)(Math.Sqrt(m));  // 取整
            for (i = 2; i <= k; i++)
                if (m % i == 0) break;  //可以整除，肯定不是素数，结束循环
            if (i == k + 1)
                Console.WriteLine("整数 {0} 是素数！", m);
            else
                Console.WriteLine("整数 {0} 是合数！", m);
            //方法2：利用while循环和bool变量
            bool flag = true;          //假设所输整数为素数
            k = (int)(Math.Sqrt(m));   // 取整
            i = 2;
            while (i <= k && flag == true)
            {
                if (m % i == 0) flag = false; //可以整除，肯定不是素数，结束循环
                else i++;
            }
            if (flag == true)
                Console.WriteLine("整数 {0} 是素数！", m);
            else
                Console.WriteLine("整数 {0} 是合数！", m);
            Console.ReadKey();
        }
    }
}
