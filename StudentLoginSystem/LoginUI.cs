using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentLoginSystem
{
    public partial class LoginUI : Form
    {
        // 实例化StudentInfo类用于传递数据
        readonly LoginModel.StudentInfo StuInfo = new LoginModel.StudentInfo();
        readonly LoginModel.LoginInfo LgInfo = new LoginModel.LoginInfo();

        // 实例化LoginManager类用于匹配文本文件中的数据
        readonly LoginBLL.LoginManager LoginManager = new LoginBLL.LoginManager();
        public LoginUI()
        {
            InitializeComponent();
        }

        /* 登陆界面初始化*/
        private void LoginUI_Load(object sender, EventArgs e)
        {
            LoginPanel.Visible = true;
            RegisterPanel.Visible = false;
            StuName.Focus();
        }

        /*登陆按钮设置*/
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            // 获取登陆信息
            LgInfo.StudentName = StuName.Text;
            LgInfo.StudentID = StuID.Text;
            LgInfo.Password = StuPassword.Text;
            MessageBox.Show(LoginManager.LoginAcess(LgInfo));
        }
        
        /*注册按钮设置*/
        private void RgBtn_Click(object sender, EventArgs e)
        {
            StuInfo.StudentName = RgName.Text;
            StuInfo.StudentID = RgID.Text;
            StuInfo.StudentDepartment = RgDepartment.Text;
            StuInfo.Password = RgPwd.Text;
            StuInfo.Email = RgEmail.Text;
            string PwdConfirm = RgPwdConfirm.Text;
            MessageBox.Show(LoginManager.RegisterAcess(StuInfo,PwdConfirm));
        }

        /*界面跳转按钮设置*/
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            // 跳转到注册界面
            LoginPanel.Visible = false;
            RegisterPanel.Visible = true;
            RgName.Focus();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // 跳转到登陆界面
            RegisterPanel.Visible = false;
            LoginPanel.Visible = true;
            StuName.Focus();
        }

        /*按enter建，焦点自动移至下一个文本框*/
        private void StuName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                StuID.Focus();
            }
        }

        private void StuID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                StuPassword.Focus();
            }
        }

        private void RgName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                RgID.Focus();
            }
        }

        private void RgID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                RgDepartment.Focus();
            }
        }

        private void RgDepartment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                RgPwd.Focus();
            }
        }

        private void RgPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                RgPwdConfirm.Focus();
            }
        }

        private void RgPwdConfirm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                RgEmail.Focus();
            }
        }

        
    }
}
