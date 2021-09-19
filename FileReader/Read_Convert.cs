using System;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;

namespace FileReader
{
    public static class Read_Convert
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
        public static bool ReaderHDR(String FileName, out int ColumnsNum,
            out int LinesNum, out int BandsNum, out int DataType,
            out string InterLeave)
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
                string content = "";      // 存放每行字符串
                string pattern = @"[0-9a-zA-Z]+$"; // 寻找=后面数据的正则字符串
                string message = "";   // 存放要储存的信息
                // 设置while循环，当找到要读取的信息时跳出循环,继续下一个信息的循环读取
                // 顺序与hdr文件中的数据顺序一致，因此只要一遍就可以读取完成
                while (FileHDR.EndOfStream != true)
                {
                    // 获取像素列数
                    content = FileHDR.ReadLine();

                    if (content.Contains("samples"))
                    {
                        message = Regex.Match(content, pattern).Value; // 正则表达式匹配
                        ColumnsNum = int.Parse(message); // 转换为对应数据类型
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
                        break;
                    }

                }
                FileHDR.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("不存在该文件!:");
                Console.WriteLine(e.Message);
                return false;
            }
            catch (Exception e)
            {
                // 输出错误信息
                Console.WriteLine("文件读取失败!:");
                Console.WriteLine(e.Message);
                return false;
            }
           
            
            return true;
        }
        public static void write_txt(string fileName, Head_Message content)
        {
            string FileName = fileName + ".txt";
            StreamWriter sr; // 文件写入
            if (File.Exists(FileName)) //如果文件存在,则创建File.AppendText对象
            {
                sr = File.AppendText(FileName);
            }
            else  //如果文件不存在,则创建File.CreateText对象
            {
                sr = File.CreateText(FileName);
            }
            
            //将传入的数据写入文本文件
            sr.WriteLine($"coloumns: {content.columns}");
            sr.WriteLine($"lines: {content.lines}");
            sr.WriteLine($"bands: {content.bands}");
            sr.WriteLine($"datatype: {content.datatype}");
            sr.WriteLine($"interleave: {content.interleave}");
            sr.Close();
        }
    }
}
