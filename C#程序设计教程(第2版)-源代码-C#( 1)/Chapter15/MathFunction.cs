using System;
namespace CSharpBook.Chapter15
{
    class MathTriangle//定义一个MathTriangle类，说明三角形的有关操作
    {
        private double sideA; private double sideB; private double sideC;//三角形三边
        public MathTriangle(double a, double b, double c)
        { // 假设sideA+sideB>sideC and sideA+sideC>sideB and sideB+sideC>sideA
            sideA = Math.Abs(a); sideB = Math.Abs(b); sideC = Math.Abs(c);
        }
        public double GetArea()//求面积
        { 
            double p = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }
        public double GetPerimeter()//求周长
        { 
            return sideA + sideB + sideC;
        }
        public double GetAHeight()//求边长A对应的高
        { 
            return 2 * GetArea() / sideA;
        }
        public double GetMaxSide()//求最长边长
        {  
            return Math.Max(sideA, Math.Max(sideB, sideC));
        }
        public double GetMinSide()//求最短边长
        { 
            return Math.Min(sideA, Math.Min(sideB, sideC));
        }
        private double GetPartSideA()//求边长A的一部分
        { 
            return Math.Sqrt((Math.Pow(sideB, 2.0) - Math.Pow(GetAHeight(), 2.0)));
        }
        static void Main(string[] args)
        {
         MathTriangle aTriangle = new MathTriangle(16.0, 10.0, 8.0);
         Console.WriteLine("三角形的三边为：16.0、10.0和8.0");
         Console.WriteLine("边长A对应的高为：{0:#.00} ", aTriangle.GetAHeight());
         Console.WriteLine("边长A的一部分长为：{0} ", aTriangle.GetPartSideA());
         Console.WriteLine("三角形的面积为：{0:#.00} ", aTriangle.GetArea());
         Console.WriteLine("三角形的周长为：{0} ", aTriangle.GetPerimeter());
         Console.WriteLine("三角形的最长的边为：{0} ", aTriangle.GetMaxSide());
         Console.WriteLine("三角形的最短的边为：{0} ", aTriangle.GetMinSide());
        }
    } 
}
