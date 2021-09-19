using System;using System.Collections;
namespace CSharpBook.Chapter17
{
    public class SortedListDemo
    {
        public static void Main()
        {
            SortedList list = new SortedList(); //创建List实例对象
            list.Add(5, "Friday"); list.Add(6, "Saturday"); list.Add(7, "Sunday"); list.Add(1, "Monday");
            list.Add(2, "Tuesday"); list.Add(3, "Wednesdy"); list.Add(4, "Thursday");
            list.Remove(7);  //使用Remove方法删除索引7位置的元素
            list.RemoveAt(5); //使用RemoveAt方法删除索引2位置的元素
            for (int i = 0; i < list.Count; i++) //输出元素
                Console.Write("({0},{1}) ", list.GetKey(i), list.GetByIndex(i));
            Console.WriteLine();
            foreach (DictionaryEntry de in list) //利用foreach枚举
                Console.Write("({0},{1}) ", de.Key, de.Value);
            Console.ReadKey();
        }
    }
}
