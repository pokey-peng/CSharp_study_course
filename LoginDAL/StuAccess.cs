using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginDAL
{
    public class StuAccess
    {
        // 实例化DataBase对象
        readonly DataBase dataBase = new DataBase();

        // 学生用户登陆方法
        public int StuLogin(LoginModel.LoginInfo stuLoginInfo)
        {
            return dataBase.ReturnRowCount(stuLoginInfo);
        }
        // 学生用户注册方法
        public int StuRegister(LoginModel.StudentInfo stuInfo)
        {
            return dataBase.WriteRowCount(stuInfo);
        }
    }
}
