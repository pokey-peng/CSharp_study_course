using System; using System.IO; using System.Text;
namespace CSharpBook.Chapter16
{
    class FileStreamTest
{
       private const string PATH1 = @"Ascii.dat";
       public static void Main(String[] args)
       { //创建文件
         using (FileStream fs = File.Create(PATH1))
         {
            AddText(fs, "ASCII码字符子集：\r\n");
            for (int i = 32; i < 127; i++)
            {
               AddText(fs, Convert.ToChar(i).ToString());
               if (i % 10 == 0) AddText(fs, "\r\n"); // 每行10字符
            }
            // 读取并显示其内容
            fs.Seek(0,SeekOrigin.Begin); //定位到开始位置
            byte[] b = new byte[1024]; UTF8Encoding temp = new UTF8Encoding(true);
            while (fs.Read(b, 0, b.Length) > 0) { Console.WriteLine(temp.GetString(b)); }
         }
         Console.ReadKey();
       }
       private static void AddText(FileStream fs, string value)
       {
         byte[] info = new UTF8Encoding(true).GetBytes(value); fs.Write(info, 0, info.Length);
       }
   }
}
