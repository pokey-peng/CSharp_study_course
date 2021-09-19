using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TxtWriter_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 点击打开文本对话框

            // 创建打开文本框对象
            OpenFileDialog opd = new OpenFileDialog();
            // 设置对话框标题
            opd.Title = "请选择要打开的文本文件";
            // 设置打开的文件类型
            opd.Filter = "文本文件|*.txt|所有文件|*.*";
            // 展示打开文本框
            opd.ShowDialog();
            // 获取打开文件路径
            string FilePath = opd.FileName;
            if(FilePath == "")
            {
                return;
            }
            // 读入文件并显示
            textBox1.Text = TxtReaderWriter.Reader(FilePath);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            // 设置对话框标题
            sfd.Title = "请选择要保存的位置";
            // 设置打开的文件类型
            sfd.Filter = "文本文件|*.txt|所有文件|*.*";
            sfd.ShowDialog();

            // 获取保存的文件路径
            string FilePath = sfd.FileName;
            if(FilePath == "")
            {
                return;
            }
            // 将文件写入指定路径下
            if(TxtReaderWriter.Writer(FilePath, textBox1.Text))
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
