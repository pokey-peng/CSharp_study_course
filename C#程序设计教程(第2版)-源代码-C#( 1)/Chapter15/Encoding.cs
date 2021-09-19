using System;using System.Text;
namespace CSharpBook.Chapter15
{
   class ConvertExampleClass
   {
      static void Main()
      {
         string unicodeString = "本字符串包含unicode字符Pi(\u03a0)";
         // 创建2个不同的编码：ASCII和UNICODE
         Encoding ascii = Encoding.ASCII; Encoding unicode = Encoding.Unicode;
         byte[] unicodeBytes = unicode.GetBytes(unicodeString); //将string转换为byte[]
         byte[] asciiBytes = Encoding.Convert(unicode, ascii, unicodeBytes); //转换编码
         //将byte[]转换为char[]，再转换为string
         //演示GetCharCount/GetChars转换方法的使用，注意其中的细微差别
         char[] asciiChars = new char[ascii.GetCharCount(asciiBytes, 0, asciiBytes.Length)];
         ascii.GetChars(asciiBytes, 0, asciiBytes.Length, asciiChars, 0);
         string asciiString = new string(asciiChars);
         //显示字符串转换之前和转换之后的内容
         Console.WriteLine("原始string（Unicode）：{0}", unicodeString);
         Console.WriteLine("转换后的string（Ascii）：{0}", asciiString);
      }
   }
}
