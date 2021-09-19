using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotepad
{
    public partial class FormMain : Form
    {
        int n;
        public FormMain()
        {
            InitializeComponent();
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNote frm1 = new FormNote();
            n = n + 1;
            frm1.Text = "文档_" + n;
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNote frm1 = new FormNote();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\c#";
            // 为简便起见，仅针对.rtf文件类型
            openFileDialog1.Filter = " RichText files (*.rtf)|*.rtf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {  // 在RichTextBox中打开文件内容
                frm1.richTextBox1.LoadFile(openFileDialog1.FileName);
                frm1.Text = openFileDialog1.FileName;       //设置标题 
                frm1.MdiParent = this;
                frm1.Show();
                this.ActivateMdiChild(frm1);
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNote frm1 = (FormNote)this.ActiveMdiChild;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = "c:\\c#";
            // 为简便起见，仅针对.rtf文件类型
            saveFileDialog1.Filter = " RichText files (*.rtf)|*.rtf";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {  // 保存文件内容
                frm1.richTextBox1.SaveFile(saveFileDialog1.FileName);
            }

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void 层叠ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);        //层叠排列

        }

        private void 水平平铺ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal); //水平平铺

        }

        private void 垂直平铺ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);    //垂直平铺

        }

        private void 全部最小化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (FormNote frm in this.MdiChildren)
            {//全部子窗口最小化
                frm.WindowState = FormWindowState.Minimized;
            }
            this.LayoutMdi(System.Windows.Forms.MdiLayout.ArrangeIcons);  //排列图标

        }

        private void 版本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("版本 3.0.0，CopyRight 江红、余青松");

        }
    }
}
