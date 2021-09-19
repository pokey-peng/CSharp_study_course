using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpBook.Chapter01
{
    public class Point             //声明类Point
    {
        public int x, y;         //声明字段x和y，表示左边(x,y)
        public Point(int x, int y)  //构造函数
        {
            this.x = x; this.y = y;
        }
        public double Distance(Point p) //声明方法Distance，计算该对象（坐标点）与对象p（另一坐标点）的距离
        {
            return Math.Sqrt((x - p.x) * (x - p.x) + (y - p.y) * (y - p.y));
        }
    }

}
