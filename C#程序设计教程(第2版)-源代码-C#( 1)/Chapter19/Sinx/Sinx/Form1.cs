using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int ORIGIN_X = 0;          // 原点X
            int ORIGIN_Y = this.Height / 2; //原点Y：窗体高度的一半
            int SCALE_X = 40;     //X轴缩放倍数
            int SCALE_Y = 100;    //Y轴缩放倍数
            int END_ARC = 360 * 2; //画多长
            double ox = 0, oy = 0, x = 0, y = 0;//坐标初始值
            double arc = 0; //弧度
            Graphics g = e.Graphics; Pen pen = new Pen(Color.Red, 3);
            g.DrawLine(pen, ORIGIN_X, ORIGIN_Y, this.Width, ORIGIN_Y); //x横轴
            g.DrawLine(pen, ORIGIN_X, 0, ORIGIN_X, this.Height); //y纵轴
            for (int i = 0; i < END_ARC; i += 10) //绘制线
            {
                arc = Math.PI * i * 2 / 360; x = ORIGIN_X + arc * SCALE_X;
                y = ORIGIN_Y - Math.Sin(arc) * SCALE_Y;
                if (arc > 0) { g.DrawLine(pen, (int)ox, (int)oy, (int)x, (int)y); }
                ox = x; oy = y;
            }

        }
    }
}
