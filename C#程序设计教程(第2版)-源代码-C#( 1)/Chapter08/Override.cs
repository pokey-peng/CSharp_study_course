using System;
namespace CSharpBook.Chapter08
{
    public class Dimension             //基类
    {
        protected double x, y;
        public Dimension() { }  // 默认构造函数
        public Dimension(double x, double y) //有两个参数的构造函数
        {
            this.x = x; this.y = y;
        }
        public virtual double Area()
        {
            return x * y;
        }
    }
    public class Circle : Dimension   //派生类：圆
    {
        public Circle(double r) : base(r, 0) { }
        public override double Area()  //圆的面积
        {
            return Math.PI * x * x;
        }
    }
    class Sphere : Dimension   //派生类：球体
    {
        public Sphere(double r) : base(r, 0) { }
        public override double Area()  //球体表面积
        {
            return 4 * Math.PI * x * x;
        }
    }
    class Cylinder : Dimension    //派生类：圆柱体
    {
        public Cylinder(double r, double h) : base(r, h) { }
        public override double Area()  //圆柱体表面积
        {
            return 2 * Math.PI * x * x + 2 * Math.PI * x * y;
        }
    }
    class DimensionTest
    {
        static void Main()
        {
            double r = 3.0, h = 5.0;
            Dimension[] dimensions = { new Circle(r), new Sphere(r), new Cylinder(r, h) };
            foreach (Dimension item in dimensions)  // 显示各种不同形状的（表）面积
            {
                Console.WriteLine("Area of {0} = {1:F2}", item.GetType(), item.Area());
            }
            Console.ReadKey();
        }
    }
}
