using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Div3
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 0;     //控制一行显示的数字个数
            for (int i = 100; i <= 200; i++)
            {
                if (i % 3 == 0) continue; // 被3整除的数
                Console.Write("{0}  ", i);
                j++; if (j % 10 == 0) Console.WriteLine(); //一行显示10个数后换行
            }
            Console.ReadKey();
        }
    }
}
