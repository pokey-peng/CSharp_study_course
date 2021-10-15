using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MultiStates
{
    /// <summary>
    /// 图形绘制基类
    /// </summary>
    public class DrawingObject
    {

        public int X1, Y1, X2, Y2;
        public DrawingObject(int X1, int Y1, int X2, int Y2)
        {
            this.X1 = X1;
            this.X2 = X2;
            this.Y1 = Y1;
            this.Y2 = Y2;

        }
        public virtual void Draw(Graphics g,Pen p)
        { }

    }
    /// <summary>
    /// 直线绘制类
    /// </summary>
    public class Line : DrawingObject
    {

        public Line(int X1, int Y1, int X2, int Y2)
            : base(X1, Y1, X2, Y2)
        {
        }
        public override void Draw(Graphics g, Pen p)
        {
           
            g.DrawLine(p, X1, Y1, X2, Y2);
        }
    }
    /// <summary>
    /// 圆绘制类
    /// </summary>
    public class Circle : DrawingObject
    {
        public Circle(int X1, int Y1, int X2, int Y2)
            : base(X1, Y1, X2, Y2)
        {
        }
        public override void Draw(Graphics g, Pen p)
        {
     
            g.DrawEllipse(p, (X1 + X2) / 2, (Y1 + Y2) / 2, X2 - X1, X2 - X1);
        }
    }
    /// <summary>
    /// 矩形绘制类
    /// </summary>
    public class Square : DrawingObject
    {
        public Square(int X1, int Y1, int X2, int Y2)
            : base(X1, Y1, X2, Y2)
        {
        }
        public override void Draw(Graphics g, Pen p)
        {
          
            g.DrawRectangle(p, X1, Y1, X2 - X1, Y2 - Y1);
        }
    }
}
