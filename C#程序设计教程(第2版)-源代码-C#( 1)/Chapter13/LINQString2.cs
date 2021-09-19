using System;using System.Collections.Generic;using System.Linq;
namespace CSharpBook.Chapter13
{
  class CountWords
  {
    static void Main()
    {
        string text = @"Encryption is the translation of data into a secret code." +
          @"Encryption is the most effective way to achieve data security." +
          @"To read an encrypted file, you must have access to a secret key" +
          @"or password that enables you to decrypt it.Unencrypted data " +
          @"is called plain text (or plaintext); encrypted data is " +
          @"referred to as cipher text (or ciphertext)." ;
        string[] wordsToMatch = { "Encryption", "data" };//要查询的单词列表
        //把字符串转换为字符串（句子）数组
        string[] sentences = text.Split(new char[] { '.', '?', '!' });
        //创建查询：查询所有包含"Encryption"和"data"的元素
        var sentenceQuery = from sentence in sentences
                    let w = sentence.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' })
                    where w.Distinct().Intersect(wordsToMatch).Count() 
                                   == wordsToMatch.Count()
                    select sentence;
        Console.WriteLine("所有包含Encryption和data的句子有：");
        int i = 1;
        foreach (string str in sentenceQuery)//执行查询，并循环显示查询结果
        {
            Console.WriteLine("({0})：{1}",i++,str);
        }
        Console.ReadKey();
    }
  }
}
