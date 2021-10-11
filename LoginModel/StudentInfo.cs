using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginModel
{
    public class LoginInfo
    {
        // 定义登陆信息
        public string StudentName { get; set; } // 学生姓名
        public string StudentID { get; set; } // 学生学号
        public string Password { get; set; } // 学生登陆密码
    }
    public class StudentInfo
    {
        // 定义学生属性信息
        public int ID { get; set; } // ID关键字
        public string StudentName { get; set; } // 学生姓名
        public string StudentID { get; set; } // 学生学号
        public string StudentDepartment { get; set; } // 学生院系
        public string Password { get; set; } // 学生登陆密码
        public string Email { get; set; } // 学生邮箱地址

    }
}
