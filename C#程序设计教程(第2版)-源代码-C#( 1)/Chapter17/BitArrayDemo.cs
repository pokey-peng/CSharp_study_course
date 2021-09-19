using System;using System.Collections;
namespace CSharpBook.Chapter17
{
    public class BitArrayDemo
    {
        public static void Main()
        {  //创建2个同样长度的BitArrays，然后赋值并显示
            BitArray ba1 = new BitArray(4); BitArray ba2 = new BitArray(4);
            ba1.SetAll(true); PrintValues("ba1", ba1); //将ba1所有值设置为true。显示ba1
            ba1.Set(ba1.Count - 1, false); PrintValues("ba1", ba1);//ba1末元素值设置为false。显示ba1
            Console.Write("\nba1前2个元素的值：{0} {1}", ba1.Get(0), ba1.Get(1));
            ba2[0] = ba2[2] = false; ba2[1] = ba2[3] = true; PrintValues("ba2", ba2);//ba2赋值并显示
            ba1.SetAll(true); ba1.Not();  //按位NOT操作，反转BitArray1中所有位值
            PrintValues("Not ba1", ba1); //显示ba1
            ba1.SetAll(true); PrintValues("ba1 And ba2", ba1.And(ba2));//按位AND运算
            ba1.SetAll(true); PrintValues("ba1 Or ba2", ba1.Or(ba2));//按位OR运算
            ba1.SetAll(true); PrintValues("ba1 Xor ba2", ba1.Xor(ba2));//按位XOR运算
        }
        public static void PrintValues(string name, IEnumerable myList) //显示BitArray的内容
        {
            Console.Write("\n{0} = ", name);
            foreach (Object obj in myList) Console.Write("{0} ", obj);
        }
    }
}
