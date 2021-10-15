using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace MultiStates
    //多态演示程序，LAB，2012-11-02
{
    public partial class Form1 : Form
    {
        List<DrawingObject> mylist = new List<DrawingObject>();//存贮对象的容器
        int x1, y1;//存贮鼠标位置
        int Drawstyle=0;//绘图方式
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 选择绘图方式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
          private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Drawstyle=this.comboBox2.SelectedIndex;
            
        }
        /// <summary>
        /// 在pictureBox1上绘制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (DrawingObject tmp in mylist)
            {
                tmp.Draw(e.Graphics,new Pen(Color.Red,2));
            }
        }
        /// <summary>
        /// 鼠标左键按下时的操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
        }
        /// <summary>
        /// 鼠标左键松开时的操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
           switch(Drawstyle)
           {
               case 0: mylist.Add(new Line(x1, y1, e.X, e.Y)); break;
               case 1: mylist.Add(new Circle(x1, y1, e.X, e.Y)); break;
               case 2: mylist.Add(new Square(x1, y1, e.X, e.Y)); break;
               default: mylist.Add(new Line(x1, y1, e.X, e.Y)); break;

        }
            pictureBox1.Invalidate();
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
    }

    

   
}
