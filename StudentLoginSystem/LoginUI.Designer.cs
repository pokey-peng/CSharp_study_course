
namespace StudentLoginSystem
{
    partial class LoginUI
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginBtn = new System.Windows.Forms.Button();
            this.StuName = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.Label();
            this.UserID = new System.Windows.Forms.Label();
            this.StuID = new System.Windows.Forms.TextBox();
            this.UserPassword = new System.Windows.Forms.Label();
            this.StuPassword = new System.Windows.Forms.TextBox();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.RegisterPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.RgDepartment = new System.Windows.Forms.TextBox();
            this.RgPwdConfirm = new System.Windows.Forms.TextBox();
            this.RgPwd = new System.Windows.Forms.TextBox();
            this.RgEmail = new System.Windows.Forms.TextBox();
            this.RgBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.RgID = new System.Windows.Forms.TextBox();
            this.RgName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginPanel.SuspendLayout();
            this.RegisterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.LoginBtn.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LoginBtn.Location = new System.Drawing.Point(157, 249);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(93, 51);
            this.LoginBtn.TabIndex = 6;
            this.LoginBtn.Text = "登陆";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // StuName
            // 
            this.StuName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StuName.Location = new System.Drawing.Point(240, 76);
            this.StuName.Name = "StuName";
            this.StuName.Size = new System.Drawing.Size(144, 26);
            this.StuName.TabIndex = 3;
            this.StuName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StuName_KeyPress);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserName.Location = new System.Drawing.Point(180, 79);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(51, 20);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "姓名：";
            // 
            // UserID
            // 
            this.UserID.AutoSize = true;
            this.UserID.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserID.Location = new System.Drawing.Point(180, 124);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(51, 20);
            this.UserID.TabIndex = 1;
            this.UserID.Text = "学号：";
            // 
            // StuID
            // 
            this.StuID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StuID.Location = new System.Drawing.Point(240, 121);
            this.StuID.Name = "StuID";
            this.StuID.Size = new System.Drawing.Size(144, 26);
            this.StuID.TabIndex = 4;
            this.StuID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StuID_KeyPress);
            // 
            // UserPassword
            // 
            this.UserPassword.AutoSize = true;
            this.UserPassword.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserPassword.Location = new System.Drawing.Point(180, 167);
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.Size = new System.Drawing.Size(51, 20);
            this.UserPassword.TabIndex = 2;
            this.UserPassword.Text = "密码：";
            // 
            // StuPassword
            // 
            this.StuPassword.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StuPassword.Location = new System.Drawing.Point(240, 164);
            this.StuPassword.Name = "StuPassword";
            this.StuPassword.Size = new System.Drawing.Size(144, 26);
            this.StuPassword.TabIndex = 5;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.RegisterBtn.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RegisterBtn.Location = new System.Drawing.Point(364, 249);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(93, 51);
            this.RegisterBtn.TabIndex = 7;
            this.RegisterBtn.Text = "注册";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.StuName);
            this.LoginPanel.Controls.Add(this.UserName);
            this.LoginPanel.Controls.Add(this.UserID);
            this.LoginPanel.Controls.Add(this.StuID);
            this.LoginPanel.Controls.Add(this.UserPassword);
            this.LoginPanel.Controls.Add(this.StuPassword);
            this.LoginPanel.Controls.Add(this.RegisterBtn);
            this.LoginPanel.Controls.Add(this.LoginBtn);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(651, 385);
            this.LoginPanel.TabIndex = 8;
            // 
            // RegisterPanel
            // 
            this.RegisterPanel.Controls.Add(this.button1);
            this.RegisterPanel.Controls.Add(this.RgDepartment);
            this.RegisterPanel.Controls.Add(this.RgPwdConfirm);
            this.RegisterPanel.Controls.Add(this.RgPwd);
            this.RegisterPanel.Controls.Add(this.RgEmail);
            this.RegisterPanel.Controls.Add(this.RgBtn);
            this.RegisterPanel.Controls.Add(this.label6);
            this.RegisterPanel.Controls.Add(this.RgID);
            this.RegisterPanel.Controls.Add(this.RgName);
            this.RegisterPanel.Controls.Add(this.label5);
            this.RegisterPanel.Controls.Add(this.label4);
            this.RegisterPanel.Controls.Add(this.label3);
            this.RegisterPanel.Controls.Add(this.label2);
            this.RegisterPanel.Controls.Add(this.label1);
            this.RegisterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegisterPanel.Location = new System.Drawing.Point(0, 0);
            this.RegisterPanel.Name = "RegisterPanel";
            this.RegisterPanel.Size = new System.Drawing.Size(651, 385);
            this.RegisterPanel.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(364, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 24);
            this.button1.TabIndex = 13;
            this.button1.Text = "返回登陆界面";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // RgDepartment
            // 
            this.RgDepartment.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RgDepartment.Location = new System.Drawing.Point(271, 140);
            this.RgDepartment.Name = "RgDepartment";
            this.RgDepartment.Size = new System.Drawing.Size(123, 26);
            this.RgDepartment.TabIndex = 8;
            this.RgDepartment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RgDepartment_KeyPress);
            // 
            // RgPwdConfirm
            // 
            this.RgPwdConfirm.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RgPwdConfirm.Location = new System.Drawing.Point(271, 214);
            this.RgPwdConfirm.Name = "RgPwdConfirm";
            this.RgPwdConfirm.Size = new System.Drawing.Size(123, 26);
            this.RgPwdConfirm.TabIndex = 10;
            this.RgPwdConfirm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RgPwdConfirm_KeyPress);
            // 
            // RgPwd
            // 
            this.RgPwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RgPwd.Location = new System.Drawing.Point(271, 182);
            this.RgPwd.Name = "RgPwd";
            this.RgPwd.Size = new System.Drawing.Size(123, 26);
            this.RgPwd.TabIndex = 9;
            this.RgPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RgPwd_KeyPress);
            // 
            // RgEmail
            // 
            this.RgEmail.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RgEmail.Location = new System.Drawing.Point(271, 243);
            this.RgEmail.Name = "RgEmail";
            this.RgEmail.Size = new System.Drawing.Size(123, 26);
            this.RgEmail.TabIndex = 11;
            // 
            // RgBtn
            // 
            this.RgBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RgBtn.Location = new System.Drawing.Point(157, 306);
            this.RgBtn.Name = "RgBtn";
            this.RgBtn.Size = new System.Drawing.Size(75, 23);
            this.RgBtn.TabIndex = 12;
            this.RgBtn.Text = "注册";
            this.RgBtn.UseVisualStyleBackColor = true;
            this.RgBtn.Click += new System.EventHandler(this.RgBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(186, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "确认密码：";
            // 
            // RgID
            // 
            this.RgID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RgID.Location = new System.Drawing.Point(271, 103);
            this.RgID.Name = "RgID";
            this.RgID.Size = new System.Drawing.Size(123, 26);
            this.RgID.TabIndex = 7;
            this.RgID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RgID_KeyPress);
            // 
            // RgName
            // 
            this.RgName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RgName.Location = new System.Drawing.Point(271, 56);
            this.RgName.Name = "RgName";
            this.RgName.Size = new System.Drawing.Size(123, 26);
            this.RgName.TabIndex = 6;
            this.RgName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RgName_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(214, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "邮箱：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(186, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "登陆密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(214, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "院系：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(214, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "学号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(214, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // LoginUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(651, 385);
            this.Controls.Add(this.RegisterPanel);
            this.Controls.Add(this.LoginPanel);
            this.Name = "LoginUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginUI_Load);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.RegisterPanel.ResumeLayout(false);
            this.RegisterPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox StuName;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.TextBox StuID;
        private System.Windows.Forms.Label UserPassword;
        private System.Windows.Forms.TextBox StuPassword;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Panel RegisterPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RgID;
        private System.Windows.Forms.TextBox RgName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button RgBtn;
        private System.Windows.Forms.TextBox RgDepartment;
        private System.Windows.Forms.TextBox RgPwdConfirm;
        private System.Windows.Forms.TextBox RgPwd;
        private System.Windows.Forms.TextBox RgEmail;
        private System.Windows.Forms.Button button1;
    }
}

