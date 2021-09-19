using System;using System.Collections.Generic;
namespace CSharpBook.Chapter17
{
    public class DictionaryDemo
    {
        public static void Main()
        {   //创建一个新的Hashtable
            Dictionary<string, string> openWith = new Dictionary<string, string>();
            openWith.Add("txt", "notepad.exe"); openWith.Add("bmp", "paint.exe");
            openWith.Add("jpg", "paint.exe"); openWith.Add("doc", "winword.exe");
            foreach (KeyValuePair<string, string> kvp in openWith) //利用foreach枚举Hashtable中每个元素
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            Console.ReadKey();
        }
    }
}
