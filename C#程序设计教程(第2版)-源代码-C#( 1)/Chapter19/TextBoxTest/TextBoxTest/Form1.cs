using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = @"TextBox控件用于输入文本信息。" +
                    @"此控件具有标准Windows文本框控件所没有" +
                    @"的附加功能，包括多行编辑和密码字符屏蔽。";
               textBox1.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += richTextBox1.SelectedText;
            richTextBox1.SelectionFont = new Font("Tahoma", 12, FontStyle.Bold);
            richTextBox1.SelectionColor = System.Drawing.Color.Red;
        }
    }
}
