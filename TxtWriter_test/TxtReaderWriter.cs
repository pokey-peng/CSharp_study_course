using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TxtWriter_test
{
    class TxtReaderWriter
    {
        public static string Reader(string FileName)
        {
            FileStream fileStream = new FileStream(FileName, FileMode.Open);
            byte[] buffer = new byte[1024 * 1024];
            // 读取字节，及所有字节数；
            int bytenum = fileStream.Read(buffer, 0, buffer.Length);
            // 关闭文件流
            fileStream.Close();
            // 解码显示
            return Encoding.UTF8.GetString(buffer, 0, bytenum);
        }
        public static bool Writer(string FileName, string text)
        {
            try
            {
                FileStream fileStream = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Write);
                byte[] buffer = Encoding.UTF8.GetBytes(text);
                fileStream.Write(buffer, 0, buffer.Length);
                fileStream.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
           
        }
    }
}
