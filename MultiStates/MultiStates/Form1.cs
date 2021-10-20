using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MultiStates.Tools;


namespace MultiStates
    //多态演示程序，LAB，2012-11-02
{
    
    public partial class Form1 : Form
    {
        //List<DrawingObject> mylist = new List<DrawingObject>();//存贮对象的容器
        //int x1, y1;//存贮鼠标位置
        //Point mouseMove;
        int Drawstyle=0;//绘图方式
        private Options op = new Options()
        {
            penColor = Color.FromArgb(255, 0, 128, 0),
            brushColor = Color.FromArgb(255, 0, 128, 0),
            penSize = 2
        };
        private Pen g_Pen = new Pen(Color.FromArgb(255, 0, 128, 0),2);
        private Tool _actionTool = null;
        private Graphics pb;
        private Tool actionTool
        {
            get
            {
                return _actionTool == null ? new NoneTool(op) : _actionTool;
            }
            set => _actionTool = value;
        }
        public Form1()
        {
            
            InitializeComponent();
            pb = pictureBox1.CreateGraphics();

        }
        /// <summary>
        /// 选择绘图方式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
          private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 获取绘图方式
            Drawstyle=this.comboBox2.SelectedIndex;
            // 创建相应的图形绘制工具
            actionTool = CreateToolFactory.getDrawTool(Drawstyle,op);

        }
        /// <summary>
        /// 在pictureBox1上绘制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            LayerService.DrawLayer(e.Graphics);
        }
        /// <summary>
        /// 鼠标左键按下时的操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // 绘制工具构造并添加图形对象，刷新窗口
            actionTool.onmousedown(e);
        }
        /// <summary>
        /// 鼠标左键松开时的操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            // 橡皮筋效果实现
            BufferedGraphicsContext Mybuffer = BufferedGraphicsManager.Current;
            BufferedGraphics buffered = Mybuffer.Allocate(pb, pictureBox1.ClientRectangle);

            buffered.Graphics.FillRectangle(Brushes.White, pictureBox1.ClientRectangle);
            actionTool.onmousemove(e, buffered.Graphics);
            LayerService.DrawLayer(buffered.Graphics);
            buffered.Render(pb);
            buffered.Dispose();
            Mybuffer.Dispose();

        }

        /// <summary>
        /// 窗体初如化操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBox2.SelectedIndex = 0;
        }

        private void PenColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            op.penColor = colorDialog1.Color;
        }

        private void BrushColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            op.brushColor = colorDialog1.Color;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                op.penSize = (int)numericUpDown1.Value;
            }
            catch
            {
                MessageBox.Show("大小设置失败");
            }
            
        }
    }
}
