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
        int Drawstyle=0;//绘图方式
        // 绘制图形的颜色，画笔大小等选项信息
        private Options op = new Options()
        {
            penColor = Color.FromArgb(255, 0, 128, 0), // 画笔颜色
            brushColor = Color.FromArgb(255, 0, 128, 0), // 画刷颜色
            penSize = 2 // 画笔大小
        };
        // 绘制工具
        private Tool _actionTool = null;
        private Tool actionTool
        {
            get
            {
                return _actionTool == null ? new NoneTool(op) : _actionTool;
            }
            set => _actionTool = value;
        }
        private Graphics pb; 
        public Form1()
        {
            
            InitializeComponent();
            pb = pictureBox1.CreateGraphics();// 获取pictureBox1空间的绘制画布

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
        private void pictureBox1_Paint(object sender, PaintEventArgs e) { }
        /// <summary>
        /// 鼠标左键按下时的操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // 使用绘制工具构造并添加图形对像
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
        /// <summary>
        /// 鼠标移动时的操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            // 利用双缓冲实现橡皮筋效果和绘制图层容器图形
            BufferedGraphicsContext Mybuffer = BufferedGraphicsManager.Current;
            BufferedGraphics buffered = Mybuffer.Allocate(pb, pictureBox1.ClientRectangle);
            // 设置背景色为白色
            buffered.Graphics.FillRectangle(Brushes.White, pictureBox1.ClientRectangle);
            // 绘制当前的图形
            actionTool.onmousemove(e, buffered.Graphics);
            // 绘制图层容器中的图形
            LayerService.DrawLayer(buffered.Graphics);
            // 将图形渲染到屏幕上
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
        /// <summary>
        /// 设置画笔颜色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PenColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            op.penColor = colorDialog1.Color;
        }
        /// <summary>
        /// 设置画刷颜色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BrushColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            op.brushColor = colorDialog1.Color;
        }
        /// <summary>
        /// 设置画笔大小
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
