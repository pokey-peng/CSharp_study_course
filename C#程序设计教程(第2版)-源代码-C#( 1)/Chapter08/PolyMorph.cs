using System;
abstract class Shape  //抽象基类
{ 
    public double x, y;
    public Shape(double x, double y) //带2个参数的构造函数
    {
        this.x = x;  this.y = y;
    }
    public abstract double getArea(); //抽象方法
}
class Rectangle : Shape //派生类Rectangle
{
    public Rectangle(double width, double height) : base(width, height) { }
    public override double getArea() { return x * y; } //重写方法
}
class Circle : Shape //派生类Circle
{
    public Circle(double radius) : base(radius, 0.0) { }
    public override double getArea() { return Math.PI * x * x; }//重写方法
}
public class PolyMorphByAbstractClass
{
    public static void Main() {
	Shape[] shapes = new Shape[5]; //声明5个形状类型数组
	Random rnd = new Random();
	for (int i = 0; i < shapes.Length; i++) {//随机产生形状
		int type = rnd.Next(0,1);     //产生随机数：0或1
		double x = rnd.NextDouble() * 100 + 1;//产生随机数：1<=随机数<101
		double y = rnd.NextDouble() * 100 + 1;//产生随机数：1<=随机数<101
			switch (type) {
			case 0: shapes[i] = new Rectangle(x,y); break;
			case 1: shapes[i] = new Circle(x); break;
			}
		}
		double area_sum = 0.0; //各形状面积之和
		for (int i = 0; i < shapes.Length; i++) { //打印各形状
			if (shapes[i] is Rectangle) {
                Console.WriteLine("第{0}号形状：矩形({1:0.00}, {2:0.00}),面积={3:0.00}",i+1, shapes[i].x, shapes[i].y, shapes[i].getArea());
			}else{
                Console.WriteLine("第{0}号形状：圆形(1:0.00});面积={2:0.00}",i+1, shapes[i].x, shapes[i].getArea());
			}
			area_sum = area_sum + shapes[i].getArea(); //面积之和
		}
        Console.WriteLine("面积之和：{0:0.00}\n", area_sum);
        Console.ReadKey();
	}
}