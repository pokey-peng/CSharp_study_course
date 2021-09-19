using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FuleReader
{
    static class FileReader
    {
        /// <summary>
        /// 读取头文件.hdr文件信息
        /// </summary>
        /// <param name="FileName">头文件所存路径名称</param>
        /// <param name="ColumnsNum">像素列数</param>
        /// <param name="LinesNum">像素行数</param>
        /// <param name="BandsNum">波段数</param>
        /// <param name="DataType">数据类型代码</param>
        /// <param name="InterLeave">文件组织格式</param>
        /// <returns>返回布尔值是否读取成功</returns>
        public static bool ReaderHDR(String FileName,out int ColumnsNum,
            out int LinesNum,out int BandsNum,out int DataType,
            out String InterLeave)
        {
            // 各个变量初始化
            ColumnsNum = -1;
            LinesNum = -1;
            BandsNum = -1;
            DataType = -1;
            InterLeave = "";

            // 获取一个文件流
            StreamReader FileHDR;
            try
            {
                // 创建文件流实例，开始读取文件
                FileHDR = new StreamReader(FileName);
                String content = "";
                String pattern = @"(?<=[= ])[0-9a-zA-Z]+";
                String message = "";
                while (FileHDR.EndOfStream != true)
                {
                    // 获取像素列数
                    content = FileHDR.ReadLine();

                    if (content.Contains("samples"))
                    {
                        message = Regex.Match(content, pattern).Value;
                        ColumnsNum = int.Parse(message);
                        Console.WriteLine(message);
                        break;
                    }
                }
                while (FileHDR.EndOfStream != true)
                {
                    // 获取像素行数
                    content = FileHDR.ReadLine();

                    if (content.Contains("lines"))
                    {
                        message = Regex.Match(content, pattern).Value;
                        LinesNum = int.Parse(message);
                        Console.WriteLine(message);
                        break;
                    }
                }
                while (FileHDR.EndOfStream != true)
                {
                    // 获取波段个数
                    content = FileHDR.ReadLine();

                    if (content.Contains("bands"))
                    {
                        message = Regex.Match(content, pattern).Value;
                        BandsNum = int.Parse(message);
                        Console.WriteLine(message);
                        break;
                    }
                }
                while (FileHDR.EndOfStream != true)
                {
                    // 获取数据种类
                    content = FileHDR.ReadLine();

                    if (content.Contains("data type"))
                    {
                        message = Regex.Match(content, pattern).Value;
                        DataType = int.Parse(message);
                        Console.WriteLine(message);
                        break;
                    }
                }
                while (FileHDR.EndOfStream != true)
                {
                    // 获取数据组织方式
                    content = FileHDR.ReadLine();
                    if (content.Contains("interleave"))
                    {
                        message = Regex.Match(content, pattern).Value;
                        InterLeave = message;
                        Console.WriteLine(message);
                        break;
                    }

                }

            }
            catch (Exception e)
            {
                // 输出错误信息
                Console.WriteLine("File read failed!:");
                Console.WriteLine(e.Message);
                return false;
            }
            FileHDR.Close();
            return true;
        }
        /// <summary>
        /// 将多个二进制文件合并为一个BSQ文件
        /// </summary>
        /// <param name="FileNames">多个二进制文件名动态列表集合</param>
        /// <param name="OutputFile">BSQ输出文件路径</param>
        /// <param name="pixelColumns">像素列数</param>
        /// <param name="pixelLines">像素行数</param>
        /// <param name="bands">波段数</param>
        /// <param name="type">数据类型代码</param>
        /// <returns></returns>
        public static bool BinaryToBSQ(ArrayList FileNames,String OutputFile,
            int pixelColumns,int pixelLines,int bands,int type)
        {
            // 单个文件大小
            int singalsize = pixelColumns * pixelLines * type;
            // 文件输出流
            FileStream output = new FileStream(OutputFile, FileMode.CreateNew);
            // 打开每个波段二进制文件，按波段顺序输出
            try
            {
                foreach (String FileName in FileNames)
                {
                    // 单个波段二进制文件输入流
                    FileStream input = new FileStream(FileName, FileMode.CreateNew);
                    if (singalsize != input.Length)
                    {
                        return false;
                    }
                    // 将全部字节数据读入比特数组
                    int num = 0, bt;
                    byte[] bts = new byte[singalsize];
                    while ((bt = input.ReadByte()) > -1)
                    {
                        bts[num] = (byte)bt;
                        num++;
                    }
                    // 开始写入该波段数据
                    output.Write(bts, 0, singalsize);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("打开文件失败:");
                Console.WriteLine(e.Message);
                return false;
            }
                
            output.Flush();
            output.Close();
            return true;
        }

    }
}
