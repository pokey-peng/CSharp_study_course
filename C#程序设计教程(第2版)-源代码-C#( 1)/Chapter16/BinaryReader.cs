using System; using System.IO;
namespace CSharpBook.Chapter16
{
    class BinaryReaderTest
{
       private const string PATH1 = @"Test.dat";
       public static void Main(String[] args)
       {
          if (File.Exists(PATH1))
          {
             using (BinaryReader br = new BinaryReader(File.Open(PATH1, FileMode.Open)))
             {  //读取并显示二进制文件中的数据内容
                int i1 = br.ReadInt32(); double d1 = br.ReadDouble();
                string s1 = br.ReadString(); bool b1 = br.ReadBoolean();
                Console.WriteLine(i1); Console.WriteLine(d1);
                Console.WriteLine(s1); Console.WriteLine(b1);
             }
             Console.ReadKey();
          }
       }
    }
}
