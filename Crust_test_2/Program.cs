using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crust_test_2
{
    /*点类*/
    public class Point
    {
        public int x, y;         //声明字段x和y，表示左边(x,y)
        public Point(int x, int y)  //构造函数
        {
            this.x = x; 
            this.y = y;
        }
        public double Distance(Point p) //声明方法Distance，计算该对象（坐标点）与对象p（另一坐标点）的距离
        {
            return Math.Sqrt((x - p.x) * (x - p.x) + (y - p.y) * (y - p.y));
        }
    }
    /*圆形类*/
    public class Circle //声明类Circle
    {
        public double R; //声明字段R,表示圆半径
        public Point p;  //声明字段p,表示圆心点坐标
        public Circle(int x, int y, double R)  // 构造函数,xy为圆心坐标,R为半径
        {
            this.R = R;
            this.p = new Point(x, y);
        }
        public double Area() // 声明方法Area,计算半径为R的圆的面积
        {
            return Math.PI * R * R;
        }
        public double perimeter() // 声明方法perimeter,计算半径为R的圆的周长
        {
            return 2 * Math.PI * R;
        }

        //声明方法CheckPoint,若坐标为xy的点在圆外返回False,在圆上或圆内返回True
        public bool CheckPoint(int x, int y) 
        {
            double tag;  
            Point p2 = new Point(x, y); // 根据传入的坐标，声明一个点
            tag = p2.Distance(this.p) - this.R; // 调用该点的Distance方法计算距离并减去半径
            if (tag <= 0) // 若小于或等于0则该点在圆内或圆上，返回True,否则返回False
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CircleIntersect(Circle C1) //判断与圆C1是否相交
        {
            double dis = this.p.Distance(C1.p);
            if (dis <= this.R + C1.R)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
    /*矩形类*/
    // 成员
    // param:width,height为矩形长和宽
    public class Rectangle
    {
        public double width;
        public double height;

        public Rectangle(double w, double h) //构造函数,w,h分别为矩形长和宽
        {
            width = w; height = h;
        }
        
        public double getPerimeter() //获取矩形周长
        {
            return (width + height) * 2.0;
        }

        public double getArea()  //获取矩形面积
        {
            return width * height;
        }
        
        public double getDiagonal() //获取矩形对角线长度
        {
            return Math.Sqrt(width * width + height * height);
        }
    }
}
