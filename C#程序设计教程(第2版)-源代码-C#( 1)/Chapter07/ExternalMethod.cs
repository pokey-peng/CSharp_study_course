using System; using System.Security.Permissions;
using System.Text; using System.Runtime.InteropServices;
namespace CSharpBook.Chapter07
{
  class MyPath 
  { 
    [DllImport("kernel32", SetLastError = true)] 
    public static extern bool CreateDirectory(string name, SecurityAttribute sa); 
    [DllImport("kernel32", SetLastError = true)]
    public static extern bool RemoveDirectory(string name); 
    [DllImport("kernel32", SetLastError = true)]
    public static extern int GetCurrentDirectory(int bufSize, StringBuilder buf); 
    [DllImport("kernel32", SetLastError = true)]
    public static extern bool SetCurrentDirectory(string name);
  }
  class MyPathTest
  {
    public static void Main()
    {
        StringBuilder sb=new StringBuilder(255);  MyPath.GetCurrentDirectory(255, sb);
        Console.WriteLine(sb.ToString());  Console.ReadLine();
    }
  }
}
