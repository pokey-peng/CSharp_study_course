using System; using System.IO;
namespace CSharpBook.Chapter10
{
   class CopyDir
   {  //将源目录复制到目标目录
      static public void CopyDirectory(string srcDir, string dstDir)
      {
         DirectoryInfo src= new DirectoryInfo(srcDir);
         DirectoryInfo dst = new DirectoryInfo(dstDir);
         if (!src.Exists) return; //如果源目录不存在，返回主程序
         if (!dst.Exists) dst.Create();//如果目标目录不存在，则创建之
         FileInfo[] sfs = src.GetFiles();         //获取目录中的文件
         for (int i = 0; i < sfs.Length; ++i)       //文件复制
             File.Copy(sfs[i].FullName, dst.FullName + "\\" + sfs[i].Name, true);
         DirectoryInfo[] srcDirs = src.GetDirectories();  //获取目录信息
         for (int j = 0; j < srcDirs.Length; ++j)         //目录复制
             CopyDirectory(srcDirs[j].FullName, dst.FullName + "\\" + srcDirs[j].Name);
      }
      static void Main(string[] args)
      {
         try
         {
            string src = args[0];      //命令行参数1（源目录）
            string dst = args[1];      //命令行参数2（目标目录）
            CopyDirectory(src, dst);  //将源目录复制到目标目录
            Console.WriteLine("\n源目录{0}所有内容已经成功复制到目标目录{1}中！", src, dst);
         }
         catch (Exception e) { Console.WriteLine("\n操作失败: {0}", e.ToString()); }
         finally { }
         Console.ReadLine();
      }
   }
}
