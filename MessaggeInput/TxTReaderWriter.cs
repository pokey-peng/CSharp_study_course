using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessaggeInput
{
    // 定义学生信息结构
    public struct StuMessage
    {
        public int stuClass; // 班级
        public string stuName; // 姓名
        public int stuNumber; // 学号
        public string stuGender; // 性别
    }
    class TxTReaderWriter
    {
        // 用于保存所有输入学生信息的列表
        public static List<StuMessage> stuTable = new List<StuMessage>();
        public static string TextBoxShow(StuMessage stuMessage)
        {
            // 文本首行
            string content = "班级\t姓名\t学号\t性别\r\n";
            // 将当前学生信息加入列表
            stuTable.Add(stuMessage);
            // 排序，首先是班级升序，若相同则按学号升序排列
            stuTable.Sort((StuMessage stu1, StuMessage stu2) =>
            {
                int re = stu1.stuClass.CompareTo(stu2.stuClass);
                if (0 == re)
                {
                    return stu1.stuNumber.CompareTo(stu2.stuNumber);
                }
                return re;
            });
            // 遍历列表,将列表信息加入字符串返回给textbox
            foreach(StuMessage stuTemp in stuTable)
            {
                content += Convert.ToChar(stuTemp.stuClass) + "班\t" + stuTemp.stuName + 
                    "\t" + stuTemp.stuNumber + "\t" + stuTemp.stuGender + 
                    "\r\n";
            }
            return content;
               
        }
        public static bool SaveText(string FileName, string text)
        {
            try
            {
                FileStream fileStream = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Write);
                // 获取文本框内容
                byte[] buffer = Encoding.UTF8.GetBytes(text);
                // 向文件中写入文本框内容
                fileStream.Write(buffer, 0, buffer.Length);
                // 关闭文件
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
