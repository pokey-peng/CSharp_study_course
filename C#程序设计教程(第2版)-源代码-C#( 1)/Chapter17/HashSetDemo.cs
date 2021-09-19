using System;using System.Collections.Generic;
namespace CSharpBook.Chapter17
{
    public class HashSetDemo
    {
        public static void Main()
        {  //构造测试集
            HashSet<int> oddNumbers = new HashSet<int>(); //奇数集合O={1,3,5,7,9}
            HashSet<int> evenNumbers = new HashSet<int>();//偶数集合E={0,2,4,6,8}
            HashSet<int> allNumbers = new HashSet<int>(); //整数集合A={0,1,2,3,4,5,6,7,8,9}
            for (int i = 0; i < 5; i++) { oddNumbers.Add(i * 2 + 1); evenNumbers.Add(2 * i); }
            for (int i = 0; i < 10; i++) allNumbers.Add(i); //HashSet赋初值
            HashSet<int> setUnion = new HashSet<int>(oddNumbers);
            setUnion.UnionWith(evenNumbers); //并集O∪E
            Console.Write("O ∪ E = "); DisplaySet(setUnion);
            HashSet<int> setIntersect = new HashSet<int>(allNumbers); 
            setIntersect.IntersectWith(evenNumbers); //交集A∩E
            Console.Write("A ∩ E = "); DisplaySet(setIntersect);
            HashSet<int> setExcept = new HashSet<int>(allNumbers); //差集A-E
            setExcept.ExceptWith(evenNumbers);
            Console.Write("A - E = "); DisplaySet(setExcept);
            HashSet<int> setSymmetricExcept = new HashSet<int>(allNumbers);
            setSymmetricExcept.SymmetricExceptWith(evenNumbers); //对称差集A△E
            Console.Write("A △ E = "); DisplaySet(setSymmetricExcept);
            // 测试集合
            Console.WriteLine("偶数集合和整数集合重叠？{0}", evenNumbers.Overlaps(allNumbers));
            Console.WriteLine("整数集合和偶数集合相等？{0}", allNumbers.SetEquals(evenNumbers));
            Console.WriteLine("奇数集合为整数集合的子集？{0}", oddNumbers.IsSubsetOf(allNumbers));
            Console.WriteLine("整数集合为奇数集合的超集？{0}", allNumbers.IsSupersetOf(oddNumbers));
            Console.WriteLine("偶数集合为整数集合的真子集？{0}", evenNumbers.IsProperSubsetOf(allNumbers));
            Console.WriteLine("整数集合为偶数集合的真超集？{0}", allNumbers.IsProperSupersetOf(evenNumbers));
        }
        private static void DisplaySet(HashSet<int> set) //显示集合内容
        {
            Console.Write("{"); foreach (int i in set) Console.Write(" {0}", i); Console.WriteLine(" }");
        }
    }
}
