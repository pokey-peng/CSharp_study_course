using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessaggeInput
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Commit_Click(object sender, EventArgs e)
        {
            // 当前学生信息
            StuMessage stuMessage;
            // 获取输入信息
            stuMessage.stuClass = Convert.ToInt32(StuClass.Text[0]);
            stuMessage.stuName = StuName.Text;
            stuMessage.stuNumber = int.Parse(StuNumber.Text);
            if (StuGender.GetItemChecked(0)&&StuGender.GetItemChecked(1))
            {
                MessageBox.Show("性别只能勾选一项!");
                return;
                
            }
            stuMessage.stuGender = StuGender.Text;
            // 向文本框中写入信息
            textBox1.Text = TxTReaderWriter.TextBoxShow(stuMessage);
            // 当前内容清空
            StuClass.Text = "";
            StuName.Text = "";
            StuNumber.Text = "";
            StuGender.SetItemChecked(0, false); // 取消当前选中
            StuGender.SetItemChecked(1, false);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            // 设置对话框标题
            sfd.Title = "请选择要保存的位置";
            // 设置打开的文件类型
            sfd.Filter = "文本文件|*.txt|所有文件|*.*";
            sfd.ShowDialog();

            // 获取保存的文件路径
            string FilePath = sfd.FileName;
            if (FilePath == "")
            {
                return;
            }
            // 将文件写入指定路径下
            if (TxTReaderWriter.SaveText(FilePath, textBox1.Text))
            {
                MessageBox.Show("文件保存成功!");
            }
            else
            {
                MessageBox.Show("保存失败!");
            }

        }
    }
}
