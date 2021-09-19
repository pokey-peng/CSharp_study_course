using System;using System.Collections.Generic;using System.Linq;
namespace CSharpBook.Chapter13
{
  class CountWords
  {
    static void Main()
    {
        string text = @"Encryption is the translation of data into a secret code." +
          @" Encryption is the most effective way to achieve data security." +
          @" To read an encrypted file, you must have access to a secret key" +
          @" or password that enables you to decrypt it.Unencrypted data " +
          @" is called plain text (or plaintext); encrypted data is " +
          @" referred to as cipher text (or ciphertext)." ; 
        string searchTerm = "data";
        //把字符串转换为字符串（单词）数组
        string[] source = text.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
        //创建查询：查询所有匹配"data" (不论大小写)的元素 
        var matchQuery = from word in source
                       where word.ToLowerInvariant() == searchTerm.ToLowerInvariant()
                       select word;
        int wordCount = matchQuery.Count();  //统计元素的个数
        Console.WriteLine("指定词{0}出现了{1}次", searchTerm, wordCount);
        Console.ReadKey();
    }
  }
}
