using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LoginBLL
{
    
    public class LoginManager
    {
        readonly LoginDAL.StuAccess stuAccess = new LoginDAL.StuAccess();
        public string LoginAcess(LoginModel.LoginInfo stuLoginInfo)
        {
            string Message = "登陆成功!";
            Regex StuIDCheck = new Regex(@"^\d{8}$");

            if (!StuIDCheck.IsMatch(stuLoginInfo.StudentID)) Message = "学号应为8位数字!";
            else
            {
                int MgNumber = stuAccess.StuLogin(stuLoginInfo);
                if (MgNumber == -1)
                {
                    Message = "登陆失败,您似乎没有注册。请先注册!";
                }
                if (MgNumber == -2) Message = "姓名或密码错误!";
            }
            return Message;
        }

        public string RegisterAcess(LoginModel.StudentInfo stuRegisterInfo,string pwdConfirm)
        {
            string Message = "恭喜您！注册成功!";
            Regex StuIDCheck = new Regex(@"^\d{8}$");
            Regex EmailCheck = new Regex(@"^[0-9a-zA-Z_]{0,19}@[0-9a-zA-Z]{1,13}\.[com,cn,net]{1,3}$");
            if (!StuIDCheck.IsMatch(stuRegisterInfo.StudentID))
            {
                Message = "学号应为8位数字!";
                return Message;
            }
            if (pwdConfirm != stuRegisterInfo.Password)
            {
                Message = "确认密码输入不正确!";
                return Message;
            }
            if (!EmailCheck.IsMatch(stuRegisterInfo.Email)) Message = "输入邮箱地址无效!";
            else
            {
                if (stuAccess.StuRegister(stuRegisterInfo) == -3)
                {
                    Message = "您已经注册!";
                }
            }
            
            return Message;
        }
    }
}
