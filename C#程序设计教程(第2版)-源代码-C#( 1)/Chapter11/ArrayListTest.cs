using System; using System.Collections;
public class ArrayListTest
{
    public static void Main()
    {
        ArrayList list1 = new ArrayList(); //创建数组列表list1
        list1.Add(3); list1.Add(105); //向数组列表list1添加元素3、5
        int sum1 = 0;    //数组列表list1各元素之和，赋初值0
        foreach (int x in list1) sum1 += x; //求和
        Console.WriteLine(sum1);      //输出结果
        ArrayList list2 = new ArrayList();//创建数组列表list1
        list2.Add(123); list2.Add("abc"); //向数组列表list2添加元素123、"abc"
        int sum2 = 0;                //数组列表list2各元素之和，赋初值0
        //foreach (int x in list2) sum2 += x;//求和，产生运行时异常：InvalidCastException
        Console.WriteLine(sum2);     //输出结果
        Console.ReadKey();
    }
}
