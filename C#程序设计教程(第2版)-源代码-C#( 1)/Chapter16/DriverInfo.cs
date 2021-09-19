using System; using System.IO;
namespace CSharpBook.Chapter10
{
   class DriverInfoTest
   {  
      static void Main()
      {  
         DriveInfo[] allDrives = DriveInfo.GetDrives();
         foreach (DriveInfo d in allDrives)
         {  
            Console.WriteLine("驱动器 {0}", d.Name); Console.WriteLine("  类型: {0}", d.DriveType);
            if (d.IsReady == true)
           { 
             Console.WriteLine("  卷标: {0}", d.VolumeLabel);
             Console.WriteLine("  文件系统: {0}", d.DriveFormat);
             Console.WriteLine("  当前用户可用空间: {0, 15}字节", d.AvailableFreeSpace);
             Console.WriteLine("  可用空间:         {0, 15}字节", d.TotalFreeSpace);
             Console.WriteLine("  磁盘总大小:       {0, 15}字节", d.TotalSize); Console.ReadLine();
          }
      }
     }
   }	
}
