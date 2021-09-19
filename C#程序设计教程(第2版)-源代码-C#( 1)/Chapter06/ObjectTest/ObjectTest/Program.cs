using System;
public class ObjectTest
{
    public static void Main()
    {
        Object[] objs = new Object[3];
        objs[0] = 123;          // 对象变量objs[0]赋值：123（Int32类型）
        objs[1] = "abc";        // 对象变量objs[1]赋值："abc"（String类型）
        objs[2] = new DateTime(2014, 7, 18);   // 对象变量objs[2]赋值：当前日期时间
        for (int i = 0; i < objs.Length; i++)
        {
            Console.Write("object[{0}]: {1}, {2}, {3}, {4} \n", i, objs[i],
                    (objs[i]).GetType(), (objs[i]).ToString(), (objs[i]).GetHashCode());
        }
        Object obj1 = objs[0];
        Object obj2 = objs[1];
        Console.Write("compare  obj1.equals(obj2): {0} \n", obj1.Equals(obj2));
        obj1 = obj2;
        Console.Write("compare  obj1.equals(obj2): {0} \n", obj1.Equals(obj2));
        Console.ReadKey();
    }
}
