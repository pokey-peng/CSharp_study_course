using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Message.Text = "您的计算机配置如下：";
            Message.Text += "\nCPU：" + comboBox1.Text; Message.Text += "\n内存：";
            if (listBox1.SelectedIndex > -1) Message.Text += listBox1.SelectedItem.ToString();
            else Message.Text += "您没有选择内存！";
            if (radioButtonHD1.Checked) Message.Text += "\n硬盘：" + radioButtonHD1.Text;
            else if (radioButtonHD2.Checked) Message.Text += "\n硬盘：" + radioButtonHD2.Text;
            if (radioButtonS1.Checked) Message.Text += "\n显示器：" + radioButtonS1.Text;
            else if (radioButtonS2.Checked) Message.Text += "\n显示器：" + radioButtonS2.Text;
            else if (radioButtonS3.Checked) Message.Text += "\n显示器：" + radioButtonS3.Text;
            Message.Text += "\n配件：";
            if (checkedListBox1.CheckedItems.Count != 0)
            {  // 选中配件CheckedListBox复选列表框，显示其内容.
                for (int i = 0; i <= checkedListBox1.CheckedItems.Count - 1; i++)
                { Message.Text += checkedListBox1.CheckedItems[i].ToString() + " "; }
            }
            else Message.Text += "您没有选择任何配件！";
        }
    }
}
