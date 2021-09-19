using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharJudge
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = 'a';
            if (Char.IsLetter(ch))
            {
                if (Char.IsUpper(ch))
                    Console.WriteLine("字符 {0} 是大写字母", ch);
                else
                    Console.WriteLine("字符 {0} 是小写字母", ch);
            }
            else if (Char.IsNumber(ch))
                Console.WriteLine("字符 {0} 是数字字符", ch);
            else
                Console.WriteLine("字符 {0} 是其他字符", ch);

            if (Char.ToUpper(ch) >= 'A' && Char.ToUpper(ch) <= 'Z')
            {
                if (ch >= 'A' && ch <= 'Z')
                    Console.WriteLine("字符 {0} 是大写字母", ch);
                else
                    Console.WriteLine("字符 {0} 是小写字母", ch);
            }
            else if (ch >= '0' && ch <= '9')
                Console.WriteLine("字符 {0} 是数字字符", ch);
            else
                Console.WriteLine("字符 {0} 是其他字符", ch);

            Console.ReadKey();
        }
    }
}
