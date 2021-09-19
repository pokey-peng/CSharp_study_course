using System;using System.Collections;
namespace CSharpBook.Chapter17
{
    public class HashtableDemo
    {
        public static void Main()
        {
            Hashtable openWith = new Hashtable();//创建一个新的Hashtable
            openWith.Add("txt", "notepad.exe"); openWith.Add("bmp", "paint.exe");
            openWith.Add("jpg", "paint.exe"); openWith.Add("doc", "winword.exe");
            foreach (DictionaryEntry de in openWith) //利用foreach枚举Hashtable中每个元素
            {
                Console.WriteLine("Key = {0}, Value = {1}", de.Key, de.Value);
            }
            Console.ReadKey();
        }
    }
}
