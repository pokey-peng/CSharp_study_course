using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LoginDAL
{
    public class DataBase
    {
        private readonly string _DataFileUrl = "RegisteredStudent.txt"; // 登录用户信息文本文件
        private StreamReader _fileStream; // 读取文本文件登陆用户信息
        private StreamWriter _fileWriter; // 向文本文件写入注册用户信息
        private int _row = -1; // 返回操作结果代码;

        /// <summary>
        /// 用户登陆查询
        /// </summary>
        /// <param name="stuLoginInfo">登陆信息</param>
        /// <returns>
        /// 若已经注册，且姓名和密码输入正确，则返回用户ID，
        /// 若已经注册，但姓名或密码输入不正确，返回-2，
        /// 若没有注册，返回-1
        /// </returns>
        public int ReturnRowCount(LoginModel.LoginInfo stuLoginInfo)
        {
            string name = stuLoginInfo.StudentName; 
            string stuID = stuLoginInfo.StudentID; 
            string pwd = stuLoginInfo.Password;
            this._row = -1;
            this._fileStream = new StreamReader(this._DataFileUrl);
            this._fileStream.ReadLine(); // 跳过首行
            while(this._fileStream.EndOfStream != true)
            {
                string[] studentData = this._fileStream.ReadLine().Split(',');
                if (stuID == studentData[1])
                {
                    if (name == studentData[2] && pwd == studentData[4])
                    {
                        this._row = int.Parse(studentData[0]);
                        
                    }
                    else
                    {
                        this._row = -2;
                    }
                    return this._row;

                }
            }
            this._fileStream.Close();
            return this._row;
        }
        /// <summary>
        /// 向文本文件写入注册用户信息
        /// </summary>
        /// <param name="stuInfo">注册用户信息</param>
        /// <returns>
        /// 注册成功返回用户ID,
        /// 若用户已经注册返回-3
        /// </returns>
        public int WriteRowCount(LoginModel.StudentInfo stuInfo)
        {
            this._row = -1; // ID
            string RgID = stuInfo.StudentID;
            string[] studentData = new string[6];
            // 检测用户是否已经注册,若没有注册将其添加至文本文件最后一行
            using(this._fileStream = new StreamReader(this._DataFileUrl))
            {
                studentData = this._fileStream.ReadLine().Split(',');
                while (this._fileStream.EndOfStream != true)
                {
                    studentData = this._fileStream.ReadLine().Split(',');
                    if(studentData[1] == RgID)
                    {
                        this._row = -3;
                        return this._row;
                    }
                }
            }
            if(studentData[0] == "ID")
            {
                this._row = 0;
            }
            else
            {
                this._row = int.Parse(studentData[0]);
            }
            this._row += 1;
            this._fileWriter = new StreamWriter(this._DataFileUrl,true);
            
            this._fileWriter.WriteLine($"{this._row},{stuInfo.StudentID},{stuInfo.StudentName},{stuInfo.StudentDepartment},{stuInfo.Password},{stuInfo.Email}");
            this._fileWriter.Close();
            return this._row;
        }
    }
}
