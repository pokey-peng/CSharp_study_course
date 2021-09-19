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

            string FilePath = opd.FileName;
            if(FilePath == "")
            {
                return;
            }
            textBox1.Text = TxtReaderWriter.Reader(FilePath);
        }
    }
}
