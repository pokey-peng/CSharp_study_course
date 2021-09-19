using System;using System.Collections;
namespace CSharpBook.Chapter15
{
    class Vowels
    {
        static void Main(string[] args)
        {
            int countA = 0, countE = 0, countI = 0, countO = 0, countU = 0, countAll = 0;
            Console.WriteLine("请输入字符串："); String str = Console.ReadLine();
            str = str.ToUpper(); char[] chars = str.ToCharArray();
            foreach (char ch in chars)
            {
                countAll++;   //统计字母总数
                switch (ch)
                {
                    case 'A': //统计元音'A'或'a'的出现次数
                        countA++; break;
                    case 'E': //统计元音'E'或'e'的出现次数
                        countE++; break;
                    case 'I': //统计元音'I'或'i'的出现次数
                        countI++; break;
                    case 'O': //统计元音'O'或'o'的出现次数
                        countO++; break;
                    case 'U': //统计元音'U'或'u'的出现次数
                        countU++; break;
                    default:
                        break;
                }
            }
            Console.WriteLine("所有字母的总数为：{0}", countAll);
            Console.WriteLine("元音字母出现的次数和频率分别为：");
            Console.WriteLine("A：\t{0}\t{1:#.00%}", countA, countA * 1.0 / countAll);
            Console.WriteLine("E：\t{0}\t{1:#.00%}", countE, countE * 1.0 / countAll);
            Console.WriteLine("I：\t{0}\t{1:#.00%}", countI, countI * 1.0 / countAll);
            Console.WriteLine("O：\t{0}\t{1:#.00%}", countO, countO * 1.0 / countAll);
            Console.WriteLine("U：\t{0}\t{1:#.00%}", countU, countU * 1.0 / countAll);
            Console.ReadKey();
        }
    }
}
