using System;  using System.Collections.Generic;
public class ListTest
{
    public static void Main()
    {
        List<int> list1 = new List<int>();//创建整型列表list2
        list1.Add(3); list1.Add(105);//向整型列表list1添加元素3、5
        int sum1 = 0;    //数组整型列表list1各元素之和，赋初值0
        foreach (int x in list1) sum1 += x;//求和
        Console.WriteLine(sum1);     //输出结果
        List<int> list2 = new List<int>();//创建整型列表list2
        list2.Add(123);  //向整型列表list1添加整型元素123
        //list2.Add("abc"); //向整型列表list1添加字符串"abc"，将导致编译错误
        Console.ReadKey();
    }
}
