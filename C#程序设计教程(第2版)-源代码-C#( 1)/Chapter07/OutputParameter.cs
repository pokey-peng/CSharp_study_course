using System; 
namespace CSharpBook.Chapter07
{
  class Test 
  { 
    static void SplitPath(string path, out string dir, out string name) 
    {   // 取文件所在的目录以及文件名称
        int i = path.Length; 
        while (i > 0) 
        { 
            char ch = path[i-1]; 
            if (ch == '\\' || ch == '/' || ch == ':') break; 
            i--; 
        } 
        dir = path.Substring(0, i); name = path.Substring(i); //目录、文件
    } 
    static void Main() 
    { 
        string dir, name; 
        SplitPath("c:\\Windows\\System\\hello.txt", out dir, out name); 
        Console.WriteLine("目录 = {0}，文件名 = {1}",dir, name); 
        Console.ReadLine();
    } 
  }
}
