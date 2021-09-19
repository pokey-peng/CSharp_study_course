using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            // 为简便起见，仅针对.rtf文件类型
            openFileDialog1.Filter = "rft files (*.rtf)|*.rtf";
            openFileDialog1.FilterIndex = 2; openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //打开文件内容
            { richTextBox1.LoadFile(openFileDialog1.FileName); }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = "c:\\";
            saveFileDialog1.Filter = "rft files (*.rtf)|*.rtf"; // 仅针对.rtf文件类型
            saveFileDialog1.FilterIndex = 1; saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) //保存文件内容
            { richTextBox1.SaveFile(saveFileDialog1.FileName); }

        }

        private void buttonFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog1 = new FontDialog(); fontDialog1.ShowColor = true;
            fontDialog1.Font = richTextBox1.SelectionFont;
            fontDialog1.Color = richTextBox1.SelectionColor;
            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {  //对RichTextBox中选中的文件内容更新字体
                richTextBox1.SelectionFont = fontDialog1.Font;
                richTextBox1.SelectionColor = fontDialog1.Color;
            }

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
