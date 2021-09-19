using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questionnaire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
               Message.Text = textBoxName.Text + " 您好！";
    if (radioButton1.Checked) Message.Text += "\n您的性别是： " + radioButton1.Text;
    else if (radioButton2.Checked) Message.Text += "\n您的性别是： " + radioButton2.Text;
    Message.Text += "\n您的爱好是： ";
    if (checkBox1.Checked) Message.Text += checkBox1.Text + " ";
    if (checkBox2.Checked) Message.Text += checkBox2.Text + " ";
    if (checkBox3.Checked) Message.Text += checkBox3.Text + " ";
    if (checkBox4.Checked) Message.Text += checkBox4.Text + " ";
    if ((!checkBox1.Checked) && (!checkBox2.Checked) && (!checkBox3.Checked) && (!checkBox4.Checked))
        Message.Text += "\n您居然没有兴趣爱好！";

        }
    }
}
