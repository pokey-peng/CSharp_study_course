using System;
namespace CSharpBook.Chapter04
{
    class DoWhileLoopGCF_LCM
    {
        static void Main()
        {
            int m, n, r, m1, n1;
            Console.Write("请输入整数 m (>0):   ");
            m1 = int.Parse(Console.ReadLine());  //将数字字符串转换为等效的整数
            Console.Write("请输入整数n (>0):   ");
            n1 = int.Parse(Console.ReadLine());  //将数字字符串转换为等效的整数
            Console.WriteLine("整数1={0}, 整数2={1}", m1, n1);
            if (m1 > n1) { m = m1; n = n1; } //使得m>n（m是被除数，n是除数）
            else { m = n1; n = m1; }       //使得m>n（m是被除数，n是除数）
            do
            {
                r = m % n; m = n; n = r;
            } while (r != 0);
            Console.WriteLine("最大公约数 = {0}, 最小公倍数 = {1}", m, m1 * n1 / m);
            Console.ReadLine();
        }
    }
}
