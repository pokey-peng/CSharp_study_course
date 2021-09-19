/*****************************************************
* 程序读取FileReader/bin/Degbug/C2/AA.hdr文件中的信息。*
* 获取图像行数、列数、波段数、数据类型、数据解译方式。    *
* 若文件不存在，程序捕获异常，并输出异常信息             *
* 通过控制台输出获取的文本信息                          *
******************************************************/
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 定义一个头文件信息结构体，包含一个打印信息内容的打印函数
public struct Head_Message
{
    public int columns;
    public int lines;
    public int bands;
    public int datatype;
    public string interleave;

    public void print()
    {
        Console.WriteLine($"coloumns: {columns}");
        Console.WriteLine($"lines: {lines}");
        Console.WriteLine($"bands: {bands}");
        Console.WriteLine($"datatype: {datatype}");
        Console.WriteLine($"interleave: {interleave}");
    }
}

namespace FileReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Head_Message headmessage1 = new Head_Message();
            string file = "C2/AA.hdr";  // 文件路径
            bool message = Read_Convert.ReaderHDR(file, out headmessage1.columns,
                out headmessage1.lines,
                out headmessage1.bands,
                out headmessage1.datatype,
                out headmessage1.interleave);
            if (message)
            {
                Console.WriteLine("hdr头文件信息读取成功!");
                Read_Convert.write_txt("headmessage", headmessage1);
            }
            headmessage1.print();
        }
    }
    

}
